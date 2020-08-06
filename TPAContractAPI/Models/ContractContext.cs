using Microsoft.EntityFrameworkCore;

namespace TPAContractAPI.Models
{
    public class ContractContext : DbContext
    {
        public ContractContext(DbContextOptions<ContractContext> options) : base(options)
        {

        }
        public DbSet<Contract> Contracts { get; set; }
    }
}