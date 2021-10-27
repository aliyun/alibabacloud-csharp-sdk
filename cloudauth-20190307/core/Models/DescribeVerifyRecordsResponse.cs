// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyRecordsResponse : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("QueryId")]
        [Validation(Required=true)]
        public string QueryId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("RecordsList")]
        [Validation(Required=true)]
        public List<DescribeVerifyRecordsResponseRecordsList> RecordsList { get; set; }
        public class DescribeVerifyRecordsResponseRecordsList : TeaModel {
            [NameInMap("AuthorityComparisonScore")]
            [Validation(Required=true)]
            public float? AuthorityComparisonScore { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=true)]
            public string BizId { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=true)]
            public string BizType { get; set; }

            [NameInMap("DataStats")]
            [Validation(Required=true)]
            public string DataStats { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=true)]
            public long? FinishTime { get; set; }

            [NameInMap("IdCardFaceComparisonScore")]
            [Validation(Required=true)]
            public float? IdCardFaceComparisonScore { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }

            [NameInMap("VerifyId")]
            [Validation(Required=true)]
            public string VerifyId { get; set; }

            [NameInMap("Material")]
            [Validation(Required=true)]
            public DescribeVerifyRecordsResponseRecordsListMaterial Material { get; set; }
            public class DescribeVerifyRecordsResponseRecordsListMaterial : TeaModel {
                [NameInMap("FaceImageUrl")]
                [Validation(Required=true)]
                public string FaceImageUrl { get; set; }
                [NameInMap("IdCardName")]
                [Validation(Required=true)]
                public string IdCardName { get; set; }
                [NameInMap("IdCardNumber")]
                [Validation(Required=true)]
                public string IdCardNumber { get; set; }
                [NameInMap("IdCardInfo")]
                [Validation(Required=true)]
                public DescribeVerifyRecordsResponseRecordsListMaterialIdCardInfo IdCardInfo { get; set; }
                public class DescribeVerifyRecordsResponseRecordsListMaterialIdCardInfo : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=true)]
                    public string Address { get; set; }

                    [NameInMap("Authority")]
                    [Validation(Required=true)]
                    public string Authority { get; set; }

                    [NameInMap("BackImageUrl")]
                    [Validation(Required=true)]
                    public string BackImageUrl { get; set; }

                    [NameInMap("Birth")]
                    [Validation(Required=true)]
                    public string Birth { get; set; }

                    [NameInMap("EndDate")]
                    [Validation(Required=true)]
                    public string EndDate { get; set; }

                    [NameInMap("FrontImageUrl")]
                    [Validation(Required=true)]
                    public string FrontImageUrl { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Nationality")]
                    [Validation(Required=true)]
                    public string Nationality { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=true)]
                    public string Number { get; set; }

                    [NameInMap("Sex")]
                    [Validation(Required=true)]
                    public string Sex { get; set; }

                    [NameInMap("StartDate")]
                    [Validation(Required=true)]
                    public string StartDate { get; set; }

                }
            };

        }

    }

}
