// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The alias of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-test</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-23T07:24:33Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description of the test instance.</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The type of the instance.</para>
        /// <list type="bullet">
        /// <item><description>SSD: high-performance instance</description></item>
        /// <item><description>HYBRID: capacity instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SSD</para>
        /// </summary>
        [NameInMap("InstanceSpecification")]
        [Validation(Required=false)]
        public string InstanceSpecification { get; set; }

        /// <summary>
        /// <para>The status of the instance.</para>
        /// <list type="bullet">
        /// <item><description>normal: The instance works as expected.</description></item>
        /// <item><description>forbidden: The instance is disabled.</description></item>
        /// <item><description>Deleting: The instance is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("IsMultiAZ")]
        [Validation(Required=false)]
        public bool? IsMultiAZ { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VPC: The instance can be accessed only over the bound virtual private clouds (VPCs).</description></item>
        /// <item><description>VPC_CONSOLE: The instance can be accessed from the Tablestore console or over the bound VPCs.</description></item>
        /// <item><description>NORMAL: The instance can be accessed from networks of the custom types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The sources of the network from which access is allowed. Valid value:</para>
        /// <para>TRUST_PROXY: console</para>
        /// </summary>
        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        /// <summary>
        /// <para>The types of the network from which access is allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CLASSIC: the classic network</description></item>
        /// <item><description>INTERNET: the Internet</description></item>
        /// <item><description>VPC: VPCs</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The instance policy.</para>
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
        /// <para>The version of the instance policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public long? PolicyVersion { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>757E172A-F94B-5E78-8A23-D9068E42F2E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxh4em5jncda</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ots_standard_public_cn-9lb34u7u5001</para>
        /// </summary>
        [NameInMap("SPInstanceId")]
        [Validation(Required=false)]
        public string SPInstanceId { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// <list type="bullet">
        /// <item><description>SSD: high-performance</description></item>
        /// <item><description>HYBRID: capacity</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HYBRID</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The total number of tables in the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TableQuota")]
        [Validation(Required=false)]
        public int? TableQuota { get; set; }

        /// <summary>
        /// <para>The tags of the instance.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyTags> Tags { get; set; }
        public class GetInstanceResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>(Deprecated) The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keyTestA</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>(Deprecated) The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00004a20240452b0</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>333</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16542312566</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The VCU quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("VCUQuota")]
        [Validation(Required=false)]
        public int? VCUQuota { get; set; }

    }

}
