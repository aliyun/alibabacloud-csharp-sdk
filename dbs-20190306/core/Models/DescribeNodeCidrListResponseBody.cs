// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeNodeCidrListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InternetIPs")]
        [Validation(Required=false)]
        public DescribeNodeCidrListResponseBodyInternetIPs InternetIPs { get; set; }
        public class DescribeNodeCidrListResponseBodyInternetIPs : TeaModel {
            [NameInMap("InternetIP")]
            [Validation(Required=false)]
            public List<string> InternetIP { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("IntranetIPs")]
        [Validation(Required=false)]
        public DescribeNodeCidrListResponseBodyIntranetIPs IntranetIPs { get; set; }
        public class DescribeNodeCidrListResponseBodyIntranetIPs : TeaModel {
            [NameInMap("IntranetIP")]
            [Validation(Required=false)]
            public List<string> IntranetIP { get; set; }
        };

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

    }

}
