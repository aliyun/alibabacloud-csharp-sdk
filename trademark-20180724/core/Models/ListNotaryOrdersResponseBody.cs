// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class ListNotaryOrdersResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNotaryOrdersResponseBodyData Data { get; set; }
        public class ListNotaryOrdersResponseBodyData : TeaModel {
            [NameInMap("NotaryOrder")]
            [Validation(Required=false)]
            public List<ListNotaryOrdersResponseBodyDataNotaryOrder> NotaryOrder { get; set; }
            public class ListNotaryOrdersResponseBodyDataNotaryOrder : TeaModel {
                [NameInMap("AliyunOrderId")]
                [Validation(Required=false)]
                public string AliyunOrderId { get; set; }

                [NameInMap("ApplyPostStatus")]
                [Validation(Required=false)]
                public string ApplyPostStatus { get; set; }

                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("NotaryCertificate")]
                [Validation(Required=false)]
                public string NotaryCertificate { get; set; }

                [NameInMap("NotaryOrderId")]
                [Validation(Required=false)]
                public long? NotaryOrderId { get; set; }

                [NameInMap("NotaryPlatformName")]
                [Validation(Required=false)]
                public string NotaryPlatformName { get; set; }

                [NameInMap("NotaryStatus")]
                [Validation(Required=false)]
                public int? NotaryStatus { get; set; }

                [NameInMap("NotaryType")]
                [Validation(Required=false)]
                public int? NotaryType { get; set; }

                [NameInMap("OrderDate")]
                [Validation(Required=false)]
                public long? OrderDate { get; set; }

                [NameInMap("OrderPrice")]
                [Validation(Required=false)]
                public float? OrderPrice { get; set; }

                [NameInMap("TmClassification")]
                [Validation(Required=false)]
                public string TmClassification { get; set; }

                [NameInMap("TmImage")]
                [Validation(Required=false)]
                public string TmImage { get; set; }

                [NameInMap("TmName")]
                [Validation(Required=false)]
                public string TmName { get; set; }

                [NameInMap("TmRegisterNo")]
                [Validation(Required=false)]
                public string TmRegisterNo { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
