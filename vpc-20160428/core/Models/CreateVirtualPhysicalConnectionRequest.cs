// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVirtualPhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The description of the hosted connection.</para>
        /// <para>The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run, without performing the actual request. Default value: 45104. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the request for potential issues, including required parameters, request syntax, and instance status. If the request fails the dry run, an error code is returned. If the request passes the dry run, <c>DRYRUN.SUCCESS</c> is returned.</description></item>
        /// <item><description><b>false</b>: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The name of the hosted connection.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The payer for the hosted connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByPhysicalConnectionOwner</b>: The partner pays for the hosted connection.</description></item>
        /// <item><description><b>PayByVirtualPhysicalConnectionOwner</b>: The tenant pays for the hosted connection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByVirtualPhysicalConnectionOwner</para>
        /// </summary>
        [NameInMap("OrderMode")]
        [Validation(Required=false)]
        public string OrderMode { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit over which the hosted connection is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1ciz7ekd2grn1as****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the hosted connection.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the hosted connection belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzjty2chzuqky</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The bandwidth value of the hosted connection.</para>
        /// <para>Valid values: <b>50M</b>, <b>100M</b>, <b>200M</b>, <b>300M</b>, <b>400M</b>, <b>500M</b>, <b>1G</b>, <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b>.</para>
        /// <remarks>
        /// <para> <b>2G</b>, <b>5G</b>, <b>8G</b>, and <b>10G</b> are unavailable by default. If you want to use these bandwidth values, contact your account manager.</para>
        /// </remarks>
        /// <para><b>M</b> indicates Mbit/s and <b>G</b> indicates Gbit/s.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50M</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVirtualPhysicalConnectionRequestTag> Tag { get; set; }
        public class CreateVirtualPhysicalConnectionRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The key can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The key must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The value can be up to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CBCE910E-D396-4944-8****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The virtual local area network (VLAN) ID of the hosted connection. Valid values: <b>0</b> to <b>2999</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the VLAN ID is set to <b>0</b>, it indicates that the switch port of the virtual border router (VBR) is a Layer 3 router interface instead of a VLAN interface. When a Layer 3 router interface is used, each Express Connect circuit corresponds to a VBR.</description></item>
        /// <item><description>If the VLAN ID is set to a value from <b>1</b> to <b>2999</b>, the switch port of the VBR is a Layer 3 VLAN subinterface. When a Layer 3 VLAN subinterface is used, each VLAN ID corresponds to one VBR. In this case, the Express Connect circuit with which the VBR is associated can be used to connect to virtual private clouds (VPCs) that belong to different Alibaba Cloud accounts. VBRs in different VLANs are isolated from each other at Layer 2.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public long? VlanId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("VpconnAliUid")]
        [Validation(Required=false)]
        public long? VpconnAliUid { get; set; }

    }

}
