// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyResponseBody : TeaModel {
        [NameInMap("DBProxyConnectStringItems")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDBProxyConnectStringItems DBProxyConnectStringItems { get; set; }
        public class DescribeDBProxyResponseBodyDBProxyConnectStringItems : TeaModel {
            [NameInMap("DBProxyConnectStringItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDBProxyConnectStringItemsDBProxyConnectStringItems> DBProxyConnectStringItems { get; set; }
            public class DescribeDBProxyResponseBodyDBProxyConnectStringItemsDBProxyConnectStringItems : TeaModel {
                [NameInMap("DBProxyConnectString")]
                [Validation(Required=false)]
                public string DBProxyConnectString { get; set; }

                [NameInMap("DBProxyConnectStringNetType")]
                [Validation(Required=false)]
                public string DBProxyConnectStringNetType { get; set; }

                [NameInMap("DBProxyConnectStringNetWorkType")]
                [Validation(Required=false)]
                public string DBProxyConnectStringNetWorkType { get; set; }

                [NameInMap("DBProxyConnectStringPort")]
                [Validation(Required=false)]
                public string DBProxyConnectStringPort { get; set; }

                [NameInMap("DBProxyEndpointId")]
                [Validation(Required=false)]
                public string DBProxyEndpointId { get; set; }

                [NameInMap("DBProxyEndpointName")]
                [Validation(Required=false)]
                public string DBProxyEndpointName { get; set; }

                [NameInMap("DBProxyVpcInstanceId")]
                [Validation(Required=false)]
                public string DBProxyVpcInstanceId { get; set; }

            }

        }

        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        [NameInMap("DBProxyInstanceCurrentMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceCurrentMinorVersion { get; set; }

        [NameInMap("DBProxyInstanceLatestMinorVersion")]
        [Validation(Required=false)]
        public string DBProxyInstanceLatestMinorVersion { get; set; }

        [NameInMap("DBProxyInstanceName")]
        [Validation(Required=false)]
        public string DBProxyInstanceName { get; set; }

        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public int? DBProxyInstanceNum { get; set; }

        [NameInMap("DBProxyInstanceSize")]
        [Validation(Required=false)]
        public string DBProxyInstanceSize { get; set; }

        [NameInMap("DBProxyInstanceStatus")]
        [Validation(Required=false)]
        public string DBProxyInstanceStatus { get; set; }

        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        [NameInMap("DBProxyServiceStatus")]
        [Validation(Required=false)]
        public string DBProxyServiceStatus { get; set; }

        [NameInMap("DbProxyEndpointItems")]
        [Validation(Required=false)]
        public DescribeDBProxyResponseBodyDbProxyEndpointItems DbProxyEndpointItems { get; set; }
        public class DescribeDBProxyResponseBodyDbProxyEndpointItems : TeaModel {
            [NameInMap("DbProxyEndpointItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyResponseBodyDbProxyEndpointItemsDbProxyEndpointItems> DbProxyEndpointItems { get; set; }
            public class DescribeDBProxyResponseBodyDbProxyEndpointItemsDbProxyEndpointItems : TeaModel {
                [NameInMap("DbProxyEndpointAliases")]
                [Validation(Required=false)]
                public string DbProxyEndpointAliases { get; set; }

                [NameInMap("DbProxyEndpointName")]
                [Validation(Required=false)]
                public string DbProxyEndpointName { get; set; }

                [NameInMap("DbProxyEndpointType")]
                [Validation(Required=false)]
                public string DbProxyEndpointType { get; set; }

                [NameInMap("DbProxyReadWriteMode")]
                [Validation(Required=false)]
                public string DbProxyReadWriteMode { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
