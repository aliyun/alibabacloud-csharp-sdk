// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceNetInfoForChannelResponseBody : TeaModel {
        [NameInMap("DBInstanceNetInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfos DBInstanceNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfos : TeaModel {
            [NameInMap("DBInstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfo> DBInstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfo : TeaModel {
                [NameInMap("Availability")]
                [Validation(Required=false)]
                public string Availability { get; set; }

                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("ConnectionStringType")]
                [Validation(Required=false)]
                public string ConnectionStringType { get; set; }

                [NameInMap("DBInstanceWeights")]
                [Validation(Required=false)]
                public DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeights DBInstanceWeights { get; set; }
                public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeights : TeaModel {
                    [NameInMap("DBInstanceWeight")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeightsDBInstanceWeight> DBInstanceWeight { get; set; }
                    public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeightsDBInstanceWeight : TeaModel {
                        [NameInMap("Availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                        [NameInMap("DBInstanceType")]
                        [Validation(Required=false)]
                        public string DBInstanceType { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                [NameInMap("DistributionType")]
                [Validation(Required=false)]
                public string DistributionType { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                [NameInMap("MaxDelayTime")]
                [Validation(Required=false)]
                public string MaxDelayTime { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("SecurityIPGroups")]
                [Validation(Required=false)]
                public DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroups SecurityIPGroups { get; set; }
                public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroups : TeaModel {
                    [NameInMap("securityIPGroup")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroupsSecurityIPGroup> SecurityIPGroup { get; set; }
                    public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroupsSecurityIPGroup : TeaModel {
                        [NameInMap("SecurityIPGroupName")]
                        [Validation(Required=false)]
                        public string SecurityIPGroupName { get; set; }

                        [NameInMap("SecurityIPs")]
                        [Validation(Required=false)]
                        public string SecurityIPs { get; set; }

                    }

                }

                [NameInMap("Upgradeable")]
                [Validation(Required=false)]
                public string Upgradeable { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("expiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: a virtual private cloud (VPC)</description></item>
        /// <item><description><b>Classic</b>: classic network</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61DF1F28-F409-50C0-B90A-CCE82D44****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
