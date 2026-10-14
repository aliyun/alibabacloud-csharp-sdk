// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateVSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the VSwitch. The following requirements apply:</para>
        /// <list type="bullet">
        /// <item><description><para>The prefix length must be an integer from 16 to 29.</para>
        /// </description></item>
        /// <item><description><para>The CIDR block of the VSwitch must be a subset of the CIDR block of the VPC to which the VSwitch belongs.</para>
        /// </description></item>
        /// <item><description><para>The CIDR block of the VSwitch cannot be the same as the destination CIDR block of an existing route in the VPC, but it can be a subset of the destination CIDR block.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The description of the VSwitch.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my vswitch.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the ENS node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xian-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/110</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the network to which the VSwitch belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-257gqcdfvx6n****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The tags of the resource. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVSwitchRequestTag> Tag { get; set; }
        public class CreateVSwitchRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <list type="bullet">
            /// <item><description><para>The tag key cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 64 characters long.</para>
            /// </description></item>
            /// <item><description><para>The tag key cannot be an empty string.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. It can be up to 128 characters long, can be an empty string, and cannot start with <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deep</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the VSwitch. The following requirements apply:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 2 to 128 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test vSwitch</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

    }

}
