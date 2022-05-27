// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        [NameInMap("DBInstanceNetInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos DBInstanceNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos : TeaModel {
            [NameInMap("DBInstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfo> DBInstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfo : TeaModel {
                public string BabelfishPort { get; set; }
                public string ConnectionString { get; set; }
                public string ConnectionStringType { get; set; }
                public DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeights DBInstanceWeights { get; set; }
                public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeights : TeaModel {
                    [NameInMap("DBInstanceWeight")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeightsDBInstanceWeight> DBInstanceWeight { get; set; }
                    public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeightsDBInstanceWeight : TeaModel {
                        [NameInMap("Availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                        [NameInMap("DBInstanceType")]
                        [Validation(Required=false)]
                        public string DBInstanceType { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }
                public string DistributionType { get; set; }
                public string ExpiredTime { get; set; }
                public string IPAddress { get; set; }
                public string IPType { get; set; }
                public string MaxDelayTime { get; set; }
                public string Port { get; set; }
                public DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroups SecurityIPGroups { get; set; }
                public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroups : TeaModel {
                    [NameInMap("securityIPGroup")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroupsSecurityIPGroup> SecurityIPGroup { get; set; }
                    public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroupsSecurityIPGroup : TeaModel {
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
            }
        };

        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityIPMode")]
        [Validation(Required=false)]
        public string SecurityIPMode { get; set; }

    }

}
