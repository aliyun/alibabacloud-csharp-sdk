// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePublicIpAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The service type of the IP address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CloudBox</b>: CloudBox. Only CloudBox users can select this type.</description></item>
        /// <item><description><b>Default</b> (default): default, which indicates no special type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the IP address pool.</para>
        /// <para>The description must be 0 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AddressPoolDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the IP address pool. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The line type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BGP</b> (default): BGP (multi-ISP) line.</para>
        /// </description></item>
        /// <item><description><para><b>BGP_PRO</b>: BGP (multi-ISP) Pro line.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about BGP (multi-ISP) and BGP (multi-ISP) Pro lines, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you are added to the whitelist for single-ISP bandwidth, you can also select the following types:<list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you are a Finance Cloud user in the China (Hangzhou) region, this parameter is required. Set the value to <b>BGP_FinanceCloud</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The name of the IP address pool.</para>
        /// <para>The name must be 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AddressPoolName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the IP address pool is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the IP address pool belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4pcdvf****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The security protection level.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is left empty, Anti-DDoS Basic is used by default.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set to <b>AntiDDoS_Enhanced</b>, Anti-DDoS (Enhanced) is used.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePublicIpAddressPoolRequestTag> Tag { get; set; }
        public class CreatePublicIpAddressPoolRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. If you specify this parameter, you cannot enter an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, you can enter an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone of the IP address pool.
        /// This parameter is required only when <b>BizType</b> is set to <b>CloudBox</b>, which indicates that the service type of the IP address pool is CloudBox.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<string> Zones { get; set; }

    }

}
