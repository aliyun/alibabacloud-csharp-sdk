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
                public string Availability { get; set; }
                public string ConnectionString { get; set; }
                public string ConnectionStringType { get; set; }
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
                public string DistributionType { get; set; }
                public string IPAddress { get; set; }
                public string IPType { get; set; }
                public string MaxDelayTime { get; set; }
                public string Port { get; set; }
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
                public string Upgradeable { get; set; }
                public string VPCId { get; set; }
                public string VSwitchId { get; set; }
                public string ExpiredTime { get; set; }
            }
        };

        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
