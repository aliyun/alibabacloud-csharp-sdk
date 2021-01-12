// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBProxyServiceStatus")]
        [Validation(Required=false)]
        public string DBProxyServiceStatus { get; set; }

        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public int? DBProxyInstanceNum { get; set; }

        [NameInMap("DBProxyInstanceStatus")]
        [Validation(Required=false)]
        public string DBProxyInstanceStatus { get; set; }

        [NameInMap("DBProxyInstanceCurrentMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceCurrentMinorVersion { get; set; }

        [NameInMap("DBProxyInstanceLatestMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceLatestMinorVersion { get; set; }

        [NameInMap("DBProxyInstanceName")]
        [Validation(Required=false)]
        public string DBProxyInstanceName { get; set; }

        [NameInMap("DBProxyConnectStringItems")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyConnectStringItems DBProxyConnectStringItems { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyConnectStringItems : TeaModel {
            [NameInMap("DBProxyConnectStringItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDBProxyConnectStringItemsDBProxyConnectStringItems> DBProxyConnectStringItems { get; set; }
            public class DescribeDBProxyResponseBodyDBProxyConnectStringItemsDBProxyConnectStringItems : TeaModel {
                public string DBProxyEndpointId { get; set; }
                public string DBProxyConnectString { get; set; }
                public string DBProxyConnectStringPort { get; set; }
                public string DBProxyConnectStringNetType { get; set; }
                public string DBProxyVpcInstanceId { get; set; }
                public string DBProxyEndpointName { get; set; }
                public string DBProxyConnectStringNetWorkType { get; set; }
            }
        };

    }

}
