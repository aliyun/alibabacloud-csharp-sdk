// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDBNodeDirectVipInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The virtual IP addresses (VIPs) of shards in an ApsaraDB for Redis cluster instance.</para>
        /// </summary>
        [NameInMap("DirectVipInfo")]
        [Validation(Required=false)]
        public DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfo DirectVipInfo { get; set; }
        public class DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfo : TeaModel {
            [NameInMap("VipInfo")]
            [Validation(Required=false)]
            public List<DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfoVipInfo> VipInfo { get; set; }
            public class DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfoVipInfo : TeaModel {
                /// <summary>
                /// <para>The network type of the security group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>vpc</b>: Virtual Private Cloud (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The shard ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-8vb3679b04551444-db-2</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The port number. Valid values: <b>1024</b> to <b>65535</b>. Default value: <b>6379</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6379</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The VIP of the shard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.115.61.8</para>
                /// </summary>
                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABAF95F6-35C1-4177-AF3A-70969EBD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
