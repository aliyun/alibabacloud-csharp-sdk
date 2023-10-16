// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class ListNotaryInfosResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNotaryInfosResponseBodyData Data { get; set; }
        public class ListNotaryInfosResponseBodyData : TeaModel {
            [NameInMap("NotaryInfo")]
            [Validation(Required=false)]
            public List<ListNotaryInfosResponseBodyDataNotaryInfo> NotaryInfo { get; set; }
            public class ListNotaryInfosResponseBodyDataNotaryInfo : TeaModel {
                [NameInMap("BizOrderNo")]
                [Validation(Required=false)]
                public string BizOrderNo { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("NotaryFailedReason")]
                [Validation(Required=false)]
                public string NotaryFailedReason { get; set; }

                [NameInMap("NotaryStatus")]
                [Validation(Required=false)]
                public int? NotaryStatus { get; set; }

                [NameInMap("TmClassification")]
                [Validation(Required=false)]
                public string TmClassification { get; set; }

                [NameInMap("TmRegisterNo")]
                [Validation(Required=false)]
                public string TmRegisterNo { get; set; }

                /// <summary>
                /// token
                /// </summary>
                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }

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
