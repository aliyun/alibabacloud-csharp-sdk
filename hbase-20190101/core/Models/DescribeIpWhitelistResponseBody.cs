// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeIpWhitelistResponseBody : TeaModel {
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public DescribeIpWhitelistResponseBodyGroups Groups { get; set; }
        public class DescribeIpWhitelistResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<DescribeIpWhitelistResponseBodyGroupsGroup> Group { get; set; }
            public class DescribeIpWhitelistResponseBodyGroupsGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("IpList")]
                [Validation(Required=false)]
                public DescribeIpWhitelistResponseBodyGroupsGroupIpList IpList { get; set; }
                public class DescribeIpWhitelistResponseBodyGroupsGroupIpList : TeaModel {
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public int? IpVersion { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AFAA617B-3268-5883-982B-DB8EC8CC1F1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
