// <auto-generated />
using MAVN.Job.QuorumTransactionWatcher.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Job.QuorumTransactionWatcher.MsSqlRepositories.Migrations
{
    [DbContext(typeof(QtwContext))]
    [Migration("20190620090318_StoreOnlyLastIndexedBlockInDB")]
    partial class StoreOnlyLastIndexedBlockInDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("quorum_transaction_watcher")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Job.QuorumTransactionWatcher.MsSqlRepositories.Entities.LastIndexedBlockEntity", b =>
                {
                    b.Property<long>("LastIndexedBlockNumber")
                        .HasColumnName("last_indexed_block_number");

                    b.HasKey("LastIndexedBlockNumber");

                    b.ToTable("last_indexed_block");
                });
#pragma warning restore 612, 618
        }
    }
}