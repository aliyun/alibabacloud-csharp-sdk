// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationSlbsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationSlbsResponseBodyData Data { get; set; }
        public class DescribeApplicationSlbsResponseBodyData : TeaModel {
            [NameInMap("Internet")]
            [Validation(Required=false)]
            public List<DescribeApplicationSlbsResponseBodyDataInternet> Internet { get; set; }
            public class DescribeApplicationSlbsResponseBodyDataInternet : TeaModel {
                public string HttpsCertId { get; set; }
                public int? Port { get; set; }
                public string Protocol { get; set; }
                public int? TargetPort { get; set; }
            }
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }
            [NameInMap("InternetSlbId")]
            [Validation(Required=false)]
            public string InternetSlbId { get; set; }
            [NameInMap("Intranet")]
            [Validation(Required=false)]
            public List<DescribeApplicationSlbsResponseBodyDataIntranet> Intranet { get; set; }
            public class DescribeApplicationSlbsResponseBodyDataIntranet : TeaModel {
                public string HttpsCertId { get; set; }
                public int? Port { get; set; }
                public string Protocol { get; set; }
                public int? TargetPort { get; set; }
            }
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }
            [NameInMap("IntranetSlbId")]
            [Validation(Required=false)]
            public string IntranetSlbId { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
