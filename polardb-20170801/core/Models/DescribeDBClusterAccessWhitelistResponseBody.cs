// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAccessWhitelistResponseBody : TeaModel {
        [NameInMap("DBClusterSecurityGroups")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroups DBClusterSecurityGroups { get; set; }
        public class DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroups : TeaModel {
            [NameInMap("DBClusterSecurityGroup")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroupsDBClusterSecurityGroup> DBClusterSecurityGroup { get; set; }
            public class DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroupsDBClusterSecurityGroup : TeaModel {
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

            }

        }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhitelistResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAccessWhitelistResponseBodyItems : TeaModel {
            [NameInMap("DBClusterIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhitelistResponseBodyItemsDBClusterIPArray> DBClusterIPArray { get; set; }
            public class DescribeDBClusterAccessWhitelistResponseBodyItemsDBClusterIPArray : TeaModel {
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                [NameInMap("SecurityIps")]
                [Validation(Required=false)]
                public string SecurityIps { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///       &quot;ProjectId&quot;: &quot;proj-xxxxxxxxxxxxxxxxxxxxxxxxxx&quot;,
        ///       &quot;SecurityIps&quot;: &quot;192.168.1.1,192.168.2.0/24&quot;,
        ///       &quot;DefaultOpen&quot;: false,
        ///       &quot;Revision&quot;: 3
        ///     }
        ///   ]</para>
        /// </summary>
        [NameInMap("ProjectItems")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhitelistResponseBodyProjectItems ProjectItems { get; set; }
        public class DescribeDBClusterAccessWhitelistResponseBodyProjectItems : TeaModel {
            [NameInMap("DBClusterProjectIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhitelistResponseBodyProjectItemsDBClusterProjectIPArray> DBClusterProjectIPArray { get; set; }
            public class DescribeDBClusterAccessWhitelistResponseBodyProjectItemsDBClusterProjectIPArray : TeaModel {
                [NameInMap("DefaultOpen")]
                [Validation(Required=false)]
                public bool? DefaultOpen { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("Revision")]
                [Validation(Required=false)]
                public long? Revision { get; set; }

                [NameInMap("SecurityIps")]
                [Validation(Required=false)]
                public string SecurityIps { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>559E91A2-CDA3-4E9F-808B-29D738******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
