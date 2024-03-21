// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class DescribeTrademarkDetailForInnerResponseBody : TeaModel {
        [NameInMap("Agency")]
        [Validation(Required=false)]
        public string Agency { get; set; }

        [NameInMap("ApplyDate")]
        [Validation(Required=false)]
        public string ApplyDate { get; set; }

        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        [NameInMap("ExclusiveDateLimit")]
        [Validation(Required=false)]
        public string ExclusiveDateLimit { get; set; }

        [NameInMap("FlowList")]
        [Validation(Required=false)]
        public List<DescribeTrademarkDetailForInnerResponseBodyFlowList> FlowList { get; set; }
        public class DescribeTrademarkDetailForInnerResponseBodyFlowList : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

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

            [NameInMap("RegistrationNumber")]
            [Validation(Required=false)]
            public string RegistrationNumber { get; set; }

        }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("ImageElement")]
        [Validation(Required=false)]
        public string ImageElement { get; set; }

        [NameInMap("IntlRegDate")]
        [Validation(Required=false)]
        public string IntlRegDate { get; set; }

        [NameInMap("LastProcedureStatus")]
        [Validation(Required=false)]
        public string LastProcedureStatus { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NoticeList")]
        [Validation(Required=false)]
        public List<DescribeTrademarkDetailForInnerResponseBodyNoticeList> NoticeList { get; set; }
        public class DescribeTrademarkDetailForInnerResponseBodyNoticeList : TeaModel {
            [NameInMap("AnnDate")]
            [Validation(Required=false)]
            public string AnnDate { get; set; }

            [NameInMap("AnnId")]
            [Validation(Required=false)]
            public string AnnId { get; set; }

            [NameInMap("AnnNum")]
            [Validation(Required=false)]
            public string AnnNum { get; set; }

            [NameInMap("AnnTypeCode")]
            [Validation(Required=false)]
            public string AnnTypeCode { get; set; }

            [NameInMap("AnnTypeName")]
            [Validation(Required=false)]
            public string AnnTypeName { get; set; }

            [NameInMap("Applicant")]
            [Validation(Required=false)]
            public string Applicant { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("OriginalImageUrl")]
            [Validation(Required=false)]
            public string OriginalImageUrl { get; set; }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public string PageNo { get; set; }

            [NameInMap("ReactNum")]
            [Validation(Required=false)]
            public string ReactNum { get; set; }

            [NameInMap("RegistrationNumber")]
            [Validation(Required=false)]
            public string RegistrationNumber { get; set; }

            [NameInMap("TrademarkName")]
            [Validation(Required=false)]
            public string TrademarkName { get; set; }

        }

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

        [NameInMap("PreAnnNum")]
        [Validation(Required=false)]
        public string PreAnnNum { get; set; }

        [NameInMap("PriorityDate")]
        [Validation(Required=false)]
        public string PriorityDate { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("ProductDescription")]
        [Validation(Required=false)]
        public string ProductDescription { get; set; }

        [NameInMap("RegAnnDate")]
        [Validation(Required=false)]
        public string RegAnnDate { get; set; }

        [NameInMap("RegAnnNum")]
        [Validation(Required=false)]
        public int? RegAnnNum { get; set; }

        [NameInMap("RegistrationNumber")]
        [Validation(Required=false)]
        public string RegistrationNumber { get; set; }

        [NameInMap("RegistrationType")]
        [Validation(Required=false)]
        public string RegistrationType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
