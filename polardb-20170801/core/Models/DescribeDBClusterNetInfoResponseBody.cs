// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        [NameInMap("DBClusterNetInfos")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoResponseBodyDBClusterNetInfos DBClusterNetInfos { get; set; }
        public class DescribeDBClusterNetInfoResponseBodyDBClusterNetInfos : TeaModel {
            [NameInMap("DBClusterNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoResponseBodyDBClusterNetInfosDBClusterNetInfo> DBClusterNetInfo { get; set; }
            public class DescribeDBClusterNetInfoResponseBodyDBClusterNetInfosDBClusterNetInfo : TeaModel {
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("ConnectionStringType")]
                [Validation(Required=false)]
                public string ConnectionStringType { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        [NameInMap("DBNodeNetInfos")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoResponseBodyDBNodeNetInfos DBNodeNetInfos { get; set; }
        public class DescribeDBClusterNetInfoResponseBodyDBNodeNetInfos : TeaModel {
            [NameInMap("DBNodeNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoResponseBodyDBNodeNetInfosDBNodeNetInfo> DBNodeNetInfo { get; set; }
            public class DescribeDBClusterNetInfoResponseBodyDBNodeNetInfosDBNodeNetInfo : TeaModel {
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DBNodeRole")]
                [Validation(Required=false)]
                public string DBNodeRole { get; set; }

                [NameInMap("NetInfos")]
                [Validation(Required=false)]
                public DescribeDBClusterNetInfoResponseBodyDBNodeNetInfosDBNodeNetInfoNetInfos NetInfos { get; set; }
                public class DescribeDBClusterNetInfoResponseBodyDBNodeNetInfosDBNodeNetInfoNetInfos : TeaModel {
                    [NameInMap("NetInfo")]
                    [Validation(Required=false)]
                    public List<DescribeDBClusterNetInfoResponseBodyDBNodeNetInfosDBNodeNetInfoNetInfosNetInfo> NetInfo { get; set; }
                    public class DescribeDBClusterNetInfoResponseBodyDBNodeNetInfosDBNodeNetInfoNetInfosNetInfo : TeaModel {
                        [NameInMap("ConnectionString")]
                        [Validation(Required=false)]
                        public string ConnectionString { get; set; }

                        [NameInMap("IPAddress")]
                        [Validation(Required=false)]
                        public string IPAddress { get; set; }

                        [NameInMap("IPType")]
                        [Validation(Required=false)]
                        public string IPType { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        [NameInMap("VPCId")]
                        [Validation(Required=false)]
                        public string VPCId { get; set; }

                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72D99256-ACF1-5F86-831F-8CB53E9C23ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
