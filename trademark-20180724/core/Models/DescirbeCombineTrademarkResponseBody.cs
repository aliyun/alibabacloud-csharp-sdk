// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class DescirbeCombineTrademarkResponseBody : TeaModel {
        [NameInMap("CurrentPageNumber")]
        [Validation(Required=false)]
        public int? CurrentPageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescirbeCombineTrademarkResponseBodyData> Data { get; set; }
        public class DescirbeCombineTrademarkResponseBodyData : TeaModel {
            [NameInMap("Agency")]
            [Validation(Required=false)]
            public string Agency { get; set; }

            [NameInMap("AnnouncementList")]
            [Validation(Required=false)]
            public List<DescirbeCombineTrademarkResponseBodyDataAnnouncementList> AnnouncementList { get; set; }
            public class DescirbeCombineTrademarkResponseBodyDataAnnouncementList : TeaModel {
                [NameInMap("AnnDate")]
                [Validation(Required=false)]
                public string AnnDate { get; set; }

                [NameInMap("AnnNumber")]
                [Validation(Required=false)]
                public string AnnNumber { get; set; }

                [NameInMap("AnnTypeCode")]
                [Validation(Required=false)]
                public string AnnTypeCode { get; set; }

                [NameInMap("AnnTypeName")]
                [Validation(Required=false)]
                public string AnnTypeName { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("OriginalImageUrl")]
                [Validation(Required=false)]
                public string OriginalImageUrl { get; set; }

            }

            [NameInMap("ApplyDate")]
            [Validation(Required=false)]
            public string ApplyDate { get; set; }

            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            [NameInMap("ExclusiveDateLimit")]
            [Validation(Required=false)]
            public string ExclusiveDateLimit { get; set; }

            [NameInMap("FirstAnnoNumber")]
            [Validation(Required=false)]
            public string FirstAnnoNumber { get; set; }

            [NameInMap("FirstAnnoType")]
            [Validation(Required=false)]
            public string FirstAnnoType { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("IndexId")]
            [Validation(Required=false)]
            public string IndexId { get; set; }

            [NameInMap("IntlRegDate")]
            [Validation(Required=false)]
            public string IntlRegDate { get; set; }

            [NameInMap("LastProcedureStatus")]
            [Validation(Required=false)]
            public string LastProcedureStatus { get; set; }

            [NameInMap("LawFinalStatus")]
            [Validation(Required=false)]
            public string LawFinalStatus { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OnSale")]
            [Validation(Required=false)]
            public int? OnSale { get; set; }

            [NameInMap("OwnerAddress")]
            [Validation(Required=false)]
            public string OwnerAddress { get; set; }

            [NameInMap("OwnerEnAddress")]
            [Validation(Required=false)]
            public string OwnerEnAddress { get; set; }

            [NameInMap("OwnerEnName")]
            [Validation(Required=false)]
            public string OwnerEnName { get; set; }

            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("PreAnnDate")]
            [Validation(Required=false)]
            public string PreAnnDate { get; set; }

            [NameInMap("PreAnnNumber")]
            [Validation(Required=false)]
            public string PreAnnNumber { get; set; }

            [NameInMap("PriorityDate")]
            [Validation(Required=false)]
            public string PriorityDate { get; set; }

            [NameInMap("Procedures")]
            [Validation(Required=false)]
            public List<DescirbeCombineTrademarkResponseBodyDataProcedures> Procedures { get; set; }
            public class DescirbeCombineTrademarkResponseBodyDataProcedures : TeaModel {
                [NameInMap("ProcedureCode")]
                [Validation(Required=false)]
                public string ProcedureCode { get; set; }

                [NameInMap("ProcedureDate")]
                [Validation(Required=false)]
                public string ProcedureDate { get; set; }

                [NameInMap("ProcedureName")]
                [Validation(Required=false)]
                public string ProcedureName { get; set; }

                [NameInMap("ProcedureResult")]
                [Validation(Required=false)]
                public string ProcedureResult { get; set; }

                [NameInMap("ProcedureStep")]
                [Validation(Required=false)]
                public string ProcedureStep { get; set; }

            }

            [NameInMap("ProductDescription")]
            [Validation(Required=false)]
            public string ProductDescription { get; set; }

            [NameInMap("RegAnnDate")]
            [Validation(Required=false)]
            public string RegAnnDate { get; set; }

            [NameInMap("RegAnnNumber")]
            [Validation(Required=false)]
            public string RegAnnNumber { get; set; }

            [NameInMap("RegistrationNumber")]
            [Validation(Required=false)]
            public string RegistrationNumber { get; set; }

            [NameInMap("RegistrationType")]
            [Validation(Required=false)]
            public string RegistrationType { get; set; }

            [NameInMap("SecondAnnoNumber")]
            [Validation(Required=false)]
            public string SecondAnnoNumber { get; set; }

            [NameInMap("SecondAnnoType")]
            [Validation(Required=false)]
            public string SecondAnnoType { get; set; }

            [NameInMap("Share")]
            [Validation(Required=false)]
            public string Share { get; set; }

            [NameInMap("SimilarGroup")]
            [Validation(Required=false)]
            public string SimilarGroup { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubsequentDesignationDate")]
            [Validation(Required=false)]
            public string SubsequentDesignationDate { get; set; }

        }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNumber")]
        [Validation(Required=false)]
        public int? TotalItemNumber { get; set; }

        [NameInMap("TotalPageNumber")]
        [Validation(Required=false)]
        public int? TotalPageNumber { get; set; }

    }

}
