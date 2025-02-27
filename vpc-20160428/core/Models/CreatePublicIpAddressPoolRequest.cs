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
        /// <item><description><b>CloudBox</b> Only cloud box users can select this type.</description></item>
        /// <item><description><b>Default</b>: This is the default value.</description></item>
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
        /// <para>You can use the client to generate a value, and you must make sure that each request has a unique token value. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the value of <b>RequestId</b> as the value of <b>ClientToken</b>. The value of <b>RequestId</b> for each API request is different.</para>
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
        /// <para>Specifies whether to precheck only this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating an IP address pool. The system checks the required parameters, request format, and service limits. If the request fails to pass the precheck, an error code is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: sends the request. This is the default value. If the request passes the precheck, a 2xx HTTP status code is returned and the IP address pool is created.</description></item>
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
        /// <item><description><b>BGP</b> (default)</description></item>
        /// <item><description><b>BGP_PRO</b></description></item>
        /// </list>
        /// <para>For more information about BGP (Multi-ISP) lines and BGP (Multi-ISP) Pro lines, see the &quot;Line types&quot; section in the <a href="https://help.aliyun.com/document_detail/32321.html">What is EIP?</a> topic.</para>
        /// <list type="bullet">
        /// <item><description><para>If you are allowed to use single-ISP bandwidth, you can also use one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b></description></item>
        /// <item><description><b>ChinaUnicom</b></description></item>
        /// <item><description><b>ChinaMobile</b></description></item>
        /// <item><description><b>ChinaTelecom_L2</b></description></item>
        /// <item><description><b>ChinaUnicom_L2</b></description></item>
        /// <item><description><b>ChinaMobile_L2</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to <b>BGP_FinanceCloud</b>.</para>
        /// </description></item>
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
        /// <para>The ID of the region where you want to create the IP address pool.</para>
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
        /// <para>The editions of Anti-DDoS.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, Anti-DDoS Origin Basic is used.</description></item>
        /// <item><description>If you set the parameter to AntiDDoS_Enhanced, Anti-DDoS Pro/Premium is used.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// <para>The tag of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePublicIpAddressPoolRequestTag> Tag { get; set; }
        public class CreatePublicIpAddressPoolRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone of the IP address pool. If you set <b>BizType</b> to <b>CloudBox</b>, this parameter is required.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<string> Zones { get; set; }

    }

}
