// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListQueryRaspAppInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListQueryRaspAppInfoResponseBodyData> Data { get; set; }
        public class ListQueryRaspAppInfoResponseBodyData : TeaModel {
            [NameInMap("RaspAppName")]
            [Validation(Required=false)]
            public string RaspAppName { get; set; }

            [NameInMap("RaspOnlineStatus")]
            [Validation(Required=false)]
            public int? RaspOnlineStatus { get; set; }

            [NameInMap("RaspStatus")]
            [Validation(Required=false)]
            public string RaspStatus { get; set; }

            /// <summary>
            /// 推送失败结果
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
