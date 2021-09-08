// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyRecordsResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        [NameInMap("RecordsList")]
        [Validation(Required=false)]
        public List<DescribeVerifyRecordsResponseBodyRecordsList> RecordsList { get; set; }
        public class DescribeVerifyRecordsResponseBodyRecordsList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            [NameInMap("IdCardFaceComparisonScore")]
            [Validation(Required=false)]
            public float? IdCardFaceComparisonScore { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("VerifyId")]
            [Validation(Required=false)]
            public string VerifyId { get; set; }

            [NameInMap("AuthorityComparisonScore")]
            [Validation(Required=false)]
            public float? AuthorityComparisonScore { get; set; }

            [NameInMap("DataStats")]
            [Validation(Required=false)]
            public string DataStats { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("Material")]
            [Validation(Required=false)]
            public DescribeVerifyRecordsResponseBodyRecordsListMaterial Material { get; set; }
            public class DescribeVerifyRecordsResponseBodyRecordsListMaterial : TeaModel {
                [NameInMap("IdCardNumber")]
                [Validation(Required=false)]
                public string IdCardNumber { get; set; }
                [NameInMap("FaceImageUrl")]
                [Validation(Required=false)]
                public string FaceImageUrl { get; set; }
                [NameInMap("IdCardName")]
                [Validation(Required=false)]
                public string IdCardName { get; set; }
                [NameInMap("IdCardInfo")]
                [Validation(Required=false)]
                public DescribeVerifyRecordsResponseBodyRecordsListMaterialIdCardInfo IdCardInfo { get; set; }
                public class DescribeVerifyRecordsResponseBodyRecordsListMaterialIdCardInfo : TeaModel {
                    [NameInMap("EndDate")]
                    [Validation(Required=false)]
                    public string EndDate { get; set; }

                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }

                    [NameInMap("Authority")]
                    [Validation(Required=false)]
                    public string Authority { get; set; }

                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("StartDate")]
                    [Validation(Required=false)]
                    public string StartDate { get; set; }

                    [NameInMap("Nationality")]
                    [Validation(Required=false)]
                    public string Nationality { get; set; }

                    [NameInMap("BackImageUrl")]
                    [Validation(Required=false)]
                    public string BackImageUrl { get; set; }

                    [NameInMap("Birth")]
                    [Validation(Required=false)]
                    public string Birth { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("FrontImageUrl")]
                    [Validation(Required=false)]
                    public string FrontImageUrl { get; set; }

                }
            };

        }

    }

}
