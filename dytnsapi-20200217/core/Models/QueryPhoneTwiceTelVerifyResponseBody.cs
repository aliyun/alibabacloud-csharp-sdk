// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryPhoneTwiceTelVerifyResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPhoneTwiceTelVerifyResponseBodyData Data { get; set; }
        public class QueryPhoneTwiceTelVerifyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("CarrierCode")]
            [Validation(Required=false)]
            public string CarrierCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>73</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public long? VerifyResult { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
