// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeSecurityGroupConfigurationResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSecurityGroupConfigurationResponseBodyItems Items { get; set; }
        public class DescribeSecurityGroupConfigurationResponseBodyItems : TeaModel {
            [NameInMap("RdsEcsSecurityGroupRel")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupConfigurationResponseBodyItemsRdsEcsSecurityGroupRel> RdsEcsSecurityGroupRel { get; set; }
            public class DescribeSecurityGroupConfigurationResponseBodyItemsRdsEcsSecurityGroupRel : TeaModel {
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C4A2494-85C4-45C5-93CF-548DB3375193</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
