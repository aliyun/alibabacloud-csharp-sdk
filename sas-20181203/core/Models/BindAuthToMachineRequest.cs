// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BindAuthToMachineRequest : TeaModel {
        /// <summary>
        /// <para>The authorization version of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// <item><description><b>10</b>: Value-added Service Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("AuthVersion")]
        [Validation(Required=false)]
        public int? AuthVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic binding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers to bind.</para>
        /// <remarks>
        /// <para><b>Bind</b> and <b>UnBind</b> cannot both be empty.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Bind")]
        [Validation(Required=false)]
        public List<string> Bind { get; set; }

        /// <summary>
        /// <para>Specifies whether to bind all assets. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Bind all assets.</description></item>
        /// <item><description><b>false</b>: Do not bind all assets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BindAll")]
        [Validation(Required=false)]
        public bool? BindAll { get; set; }

        /// <summary>
        /// <para>The search conditions for assets. This parameter is in JSON format. Note that the parameter values are case-sensitive.</para>
        /// <remarks>
        /// <para>You can search for assets by instance ID, instance name, VPC ID, region, or public IP address. Call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;internetIp&quot;,&quot;value&quot;:&quot;1.2.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>Specifies whether this is a pre-binding operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After pre-binding is enabled, the corresponding authorization quota is automatically bound to the specified servers after the purchase is completed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsPreBind")]
        [Validation(Required=false)]
        public int? IsPreBind { get; set; }

        /// <summary>
        /// <para>The logical relationship among multiple search conditions. Default value: <b>OR</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The search conditions are evaluated with a logical OR.</description></item>
        /// <item><description><b>AND</b>: The search conditions are evaluated with a logical AND.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The order version associated with the pre-binding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>level7</b>: Anti-virus Edition</description></item>
        /// <item><description><b>level3</b>: Advanced Edition</description></item>
        /// <item><description><b>level2</b>: Enterprise Edition</description></item>
        /// <item><description><b>level8</b>: Ultimate Edition</description></item>
        /// <item><description><b>level10</b>: Value-added service only.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>level2</para>
        /// </summary>
        [NameInMap("NtmVersion")]
        [Validation(Required=false)]
        public string NtmVersion { get; set; }

        /// <summary>
        /// <para>The order ID associated with the pre-binding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233016**0482</para>
        /// </summary>
        [NameInMap("PreBindOrderId")]
        [Validation(Required=false)]
        public long? PreBindOrderId { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts in the resource folder (Alibaba Cloud account).</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers to unbind.</para>
        /// <remarks>
        /// <para><b>Bind</b> and <b>UnBind</b> cannot both be empty.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnBind")]
        [Validation(Required=false)]
        public List<string> UnBind { get; set; }

    }

}
