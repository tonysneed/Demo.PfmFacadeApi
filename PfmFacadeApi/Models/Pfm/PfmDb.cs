namespace PfmFacadeApi.Models.Pfm
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PfmDb : DbContext
    {
        public PfmDb()
            : base("name=PfmDb")
        {
        }

        public virtual DbSet<ForecastDeclineCurveType> ForecastDeclineCurveTypes { get; set; }
        public virtual DbSet<ForecastDeclineType> ForecastDeclineTypes { get; set; }
        public virtual DbSet<ForecastDurationOuomType> ForecastDurationOuomTypes { get; set; }
        public virtual DbSet<ForecastGlobalRisk> ForecastGlobalRisks { get; set; }
        public virtual DbSet<ForecastHorizontal> ForecastHorizontals { get; set; }
        public virtual DbSet<ForecastHorizontalBase> ForecastHorizontalBases { get; set; }
        public virtual DbSet<ForecastHorizontalBaseDetail> ForecastHorizontalBaseDetails { get; set; }
        public virtual DbSet<ForecastHorizontalDetail> ForecastHorizontalDetails { get; set; }
        public virtual DbSet<ForecastParameter> ForecastParameters { get; set; }
        public virtual DbSet<ForecastParameterDetail> ForecastParameterDetails { get; set; }
        public virtual DbSet<ForecastParemeterProductType> ForecastParemeterProductTypes { get; set; }
        public virtual DbSet<ForecastRatioCurveType> ForecastRatioCurveTypes { get; set; }
        public virtual DbSet<ForecastRatioFluidType> ForecastRatioFluidTypes { get; set; }
        public virtual DbSet<ForecastRatioVolumeOuomType> ForecastRatioVolumeOuomTypes { get; set; }
        public virtual DbSet<Forecast> Forecasts { get; set; }
        public virtual DbSet<ForecastSeasonalRisk> ForecastSeasonalRisks { get; set; }
        public virtual DbSet<ForecastSegmentType> ForecastSegmentTypes { get; set; }
        public virtual DbSet<ForecastType> ForecastTypes { get; set; }
        public virtual DbSet<ForecastVerticalDetail> ForecastVerticalDetails { get; set; }
        public virtual DbSet<ForecastVertical> ForecastVerticals { get; set; }
        public virtual DbSet<ForecastWellRisk> ForecastWellRisks { get; set; }
        public virtual DbSet<TypeCurveRisking> TypeCurveRiskings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForecastDeclineCurveType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastDeclineCurveType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastDeclineType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastDeclineType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastDurationOuomType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastDurationOuomType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastGlobalRisk>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastGlobalRisk>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontal>()
                .Property(e => e.SiMergeBufferNumberOfDays)
                .HasPrecision(10, 6);

            modelBuilder.Entity<ForecastHorizontal>()
                .Property(e => e.TerminalOilDecline)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ForecastHorizontal>()
                .Property(e => e.TerminalGasDecline)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ForecastHorizontal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontal>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontal>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontal>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontal>()
                .HasOptional(e => e.ForecastGlobalRisk)
                .WithRequired(e => e.ForecastHorizontal);

            modelBuilder.Entity<ForecastHorizontal>()
                .HasMany(e => e.ForecastHorizontalDetails)
                .WithRequired(e => e.ForecastHorizontal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForecastHorizontal>()
                .HasMany(e => e.ForecastSeasonalRisks)
                .WithRequired(e => e.ForecastHorizontal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForecastHorizontal>()
                .HasOptional(e => e.ForecastWellRisk)
                .WithRequired(e => e.ForecastHorizontal);

            modelBuilder.Entity<ForecastHorizontalBase>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalBase>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalBase>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalBase>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalBase>()
                .HasMany(e => e.ForecastHorizontalBaseDetails)
                .WithRequired(e => e.ForecastHorizontalBase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForecastHorizontalBaseDetail>()
                .Property(e => e.Pdp)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalBaseDetail>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalBaseDetail>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalDetail>()
                .Property(e => e.Pdp)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalDetail>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastHorizontalDetail>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParameter>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParameter>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParameter>()
                .HasMany(e => e.ForecastParameterDetails)
                .WithOptional(e => e.ForecastParameter)
                .HasForeignKey(e => e.ForecastParemeterId);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.Duration)
                .HasPrecision(22, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.InitialRate)
                .HasPrecision(22, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.InitialDecline)
                .HasPrecision(22, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.NFactor)
                .HasPrecision(17, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.FinalDecline)
                .HasPrecision(22, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.FinalRate)
                .HasPrecision(22, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.MinimumDecline)
                .HasPrecision(18, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.RatioInitialRate)
                .HasPrecision(22, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.RatioFinalRate)
                .HasPrecision(22, 15);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParameterDetail>()
                .Property(e => e.SegmentId)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParemeterProductType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParemeterProductType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastParemeterProductType>()
                .HasMany(e => e.ForecastParameterDetails)
                .WithRequired(e => e.ForecastParemeterProductType)
                .HasForeignKey(e => e.ForecastParamterProductTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForecastRatioCurveType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastRatioCurveType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastRatioFluidType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastRatioFluidType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastRatioVolumeOuomType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastRatioVolumeOuomType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Forecast>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Forecast>()
                .HasMany(e => e.ForecastHorizontals)
                .WithRequired(e => e.Forecast)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForecastSeasonalRisk>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastSeasonalRisk>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastSegmentType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastSegmentType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastSegmentType>()
                .HasMany(e => e.ForecastParameterDetails)
                .WithRequired(e => e.ForecastSegmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForecastType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVerticalDetail>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVerticalDetail>()
                .Property(e => e.Quarter)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVerticalDetail>()
                .Property(e => e.Pdp)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVerticalDetail>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVerticalDetail>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVertical>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVertical>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVertical>()
                .Property(e => e.IsApproved)
                .IsFixedLength();

            modelBuilder.Entity<ForecastVertical>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVertical>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastVertical>()
                .HasMany(e => e.ForecastVerticalDetails)
                .WithRequired(e => e.ForecastVertical)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForecastWellRisk>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ForecastWellRisk>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TypeCurveRisking>()
                .Property(e => e.Geo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TypeCurveRisking>()
                .Property(e => e.Oil)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TypeCurveRisking>()
                .Property(e => e.Gas)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TypeCurveRisking>()
                .Property(e => e.Water)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TypeCurveRisking>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TypeCurveRisking>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);
        }
    }
}
