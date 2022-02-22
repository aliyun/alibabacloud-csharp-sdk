// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListSlbAPsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSlbAPsResponseBodyData> Data { get; set; }
        public class ListSlbAPsResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("CookieTimeout")]
            [Validation(Required=false)]
            public int? CookieTimeout { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public long? EnvId { get; set; }

            [NameInMap("EstablishedTimeout")]
            [Validation(Required=false)]
            public int? EstablishedTimeout { get; set; }

            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NetworkMode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RealServerPort")]
            [Validation(Required=false)]
            public int? RealServerPort { get; set; }

            [NameInMap("SlbAPId")]
            [Validation(Required=false)]
            public long? SlbAPId { get; set; }

            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            [NameInMap("SslCertId")]
            [Validation(Required=false)]
            public string SslCertId { get; set; }

            [NameInMap("StickySession")]
            [Validation(Required=false)]
            public int? StickySession { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
