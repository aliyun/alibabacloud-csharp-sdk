// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCSecurityGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic information about the security groups.</para>
        /// </summary>
        [NameInMap("RCSecurityGroups")]
        [Validation(Required=false)]
        public List<DescribeRCSecurityGroupListResponseBodyRCSecurityGroups> RCSecurityGroups { get; set; }
        public class DescribeRCSecurityGroupListResponseBodyRCSecurityGroups : TeaModel {
            /// <summary>
            /// <para>The number of instances that can be added to the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("AvailableInstanceAmount")]
            [Validation(Required=false)]
            public int? AvailableInstanceAmount { get; set; }

            /// <summary>
            /// <para>The time when the security group was created. The time follows the ISO 8601 standard and is in the <c>yyyy-MM-ddThh:mmZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-31T03:12:29Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of instances that are added to the security group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2ze27hs990o2hn9****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The type of the security group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: a normal security group.</description></item>
            /// <item><description><b>enterprise</b>: an advanced security group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("SecurityGroupType")]
            [Validation(Required=false)]
            public string SecurityGroupType { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the security group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1opxu1zkhn****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A41C147-C8D0-4DAE-A1A2-17EBCD60DFA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
