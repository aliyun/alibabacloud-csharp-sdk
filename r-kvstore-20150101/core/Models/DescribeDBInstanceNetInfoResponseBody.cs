// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLASSIC</b>: The instance runs in a classic network.</description></item>
        /// <item><description><b>VPC</b>: The instance runs in a virtual private cloud (VPC).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLASSIC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyNetInfoItems : TeaModel {
            [NameInMap("InstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyNetInfoItemsInstanceNetInfo> InstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyNetInfoItemsInstanceNetInfo : TeaModel {
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                [NameInMap("DirectConnection")]
                [Validation(Required=false)]
                public int? DirectConnection { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                [NameInMap("IsSlaveProxy")]
                [Validation(Required=false)]
                public int? IsSlaveProxy { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Upgradeable")]
                [Validation(Required=false)]
                public string Upgradeable { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VPCInstanceId")]
                [Validation(Required=false)]
                public string VPCInstanceId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC77D4E1-2A7C-4F0B-A4CC-CE0B9C314B9B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
