// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The type of the instance.</para>
        /// <list type="bullet">
        /// <item><description>SSD: high-performance instance</description></item>
        /// <item><description>HYBRID: capacity instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSD</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>(Deprecated) Specifies whether to enable disaster recovery for the instance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableReplication")]
        [Validation(Required=false)]
        public bool? DisableReplication { get; set; }

        /// <summary>
        /// <para>The description of the instance. The instance description must be 3 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>the test instance</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The name of the instance. Instance naming conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only letters, digits, and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>The name cannot end with a hyphen (-).</description></item>
        /// <item><description>The name is case-insensitive.</description></item>
        /// <item><description>The name must be 3 to 16 characters in length.</description></item>
        /// <item><description>The name cannot contain the following words: ali, ay, ots, taobao, and admin.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>(Deprecated) The network type of the instance. Valid values: NORMAL and VPC_CONSOLE. Default value: NORMAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The types of the source from which access is allowed. By default, the following source type is allowed:</para>
        /// <para>TRUST_PROXY: console</para>
        /// </summary>
        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        /// <summary>
        /// <para>The types of the network from which access is allowed. By default, the following network types are allowed:</para>
        /// <list type="bullet">
        /// <item><description>INTERNET: Internet</description></item>
        /// <item><description>VPC: virtual private cloud (VPC)</description></item>
        /// <item><description>CLASSIC: classic network</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

        /// <summary>
        /// <para>The instance policy in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;Version&quot;: &quot;1&quot;,
        ///     &quot;Statement&quot;: [
        ///         {
        ///             &quot;Action&quot;: [
        ///                 &quot;ots:<em>&quot;
        ///             ],
        ///             &quot;Resource&quot;: [
        ///                 &quot;acs:ots:</em>:13791xxxxxxxxxxx:instance/myinstance*&quot;
        ///             ],
        ///             &quot;Principal&quot;: [
        ///                 &quot;*&quot;
        ///             ],
        ///             &quot;Effect&quot;: &quot;Allow&quot;,
        ///             &quot;Condition&quot;: {
        ///                 &quot;StringEquals&quot;: {
        ///                     &quot;ots:TLSVersion&quot;: [
        ///                         &quot;1.2&quot;
        ///                     ]
        ///                 },
        ///                 &quot;IpAddress&quot;: {
        ///                     &quot;acs:SourceIp&quot;: [
        ///                         &quot;192.168.0.1&quot;,
        ///                         &quot;198.51.100.1&quot;
        ///                     ]
        ///                 }
        ///             }
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxh4em5jnbcd</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTags> Tags { get; set; }
        public class CreateInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p_instance</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0woauavextilfqr61</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
