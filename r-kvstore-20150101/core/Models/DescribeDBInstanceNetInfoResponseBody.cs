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

        /// <summary>
        /// <para>The network information about the instance.</para>
        /// </summary>
        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyNetInfoItems : TeaModel {
            [NameInMap("InstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyNetInfoItemsInstanceNetInfo> InstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyNetInfoItemsInstanceNetInfo : TeaModel {
                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1zxszhcgatnx****.redis.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Internet</description></item>
                /// <item><description><b>1</b>: classic network</description></item>
                /// <item><description><b>2</b>: Virtual Private Cloud (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// <para>Indicates whether the address is a private endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The address is not a private endpoint.</description></item>
                /// <item><description><b>1</b>: The address is a private endpoint.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectConnection")]
                [Validation(Required=false)]
                public int? DirectConnection { get; set; }

                /// <summary>
                /// <para>The expiration time of the classic network endpoint. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5183779</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.49.***</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The network type of the IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b>: Internet</description></item>
                /// <item><description><b>Inner</b>: classic network</description></item>
                /// <item><description><b>Private</b>: VPC</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Inner</para>
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                /// <summary>
                /// <para>Indicates whether the address is the endpoint for the secondary zone. Valid values: 1 and 0. A value of 1 indicates that the address is the endpoint for the secondary zone.</para>
                /// <remarks>
                /// <para> This parameter is returned only after you enable the multi-zone read/write splitting architecture for the instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsSlaveProxy")]
                [Validation(Required=false)]
                public int? IsSlaveProxy { get; set; }

                /// <summary>
                /// <para>The service port of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6379</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The remaining validity period of the classic network endpoint. Unit: seconds.</para>
                /// <remarks>
                /// <para> **A value of 0 indicates that the endpoint never expires.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Upgradeable")]
                [Validation(Required=false)]
                public string Upgradeable { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1nme44gek34slfc****</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1ky7j6qc7umk****</para>
                /// </summary>
                [NameInMap("VPCInstanceId")]
                [Validation(Required=false)]
                public string VPCInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1e7clcw529l773d****</para>
                /// </summary>
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
