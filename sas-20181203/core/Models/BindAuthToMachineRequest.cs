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
        /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
        /// <item><description><b>5</b>: Premium Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// <item><description><b>10</b>: Value-added service Edition.</description></item>
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
        /// <item><description><b>0</b>: Disable automatic binding.</description></item>
        /// <item><description><b>1</b>: Enable automatic binding.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <para>The collection of UUIDs to bind.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. Use a different token for each request. The token supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The conditions for searching assets. This parameter is in JSON format. Pay attention to letter case when you specify this parameter.</para>
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
        /// <item><description><b>OR</b>: The search conditions are evaluated using a logical OR.</description></item>
        /// <item><description><b>AND</b>: The search conditions are evaluated using a logical AND.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The order version associated with the pre-binding operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>level7</b>: Anti-virus Edition.</description></item>
        /// <item><description><b>level3</b>: Premium Edition.</description></item>
        /// <item><description><b>level2</b>: Enterprise Edition.</description></item>
        /// <item><description><b>level8</b>: Ultimate Edition.</description></item>
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
        /// <para>The order ID associated with the pre-binding operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233016**0482</para>
        /// </summary>
        [NameInMap("PreBindOrderId")]
        [Validation(Required=false)]
        public long? PreBindOrderId { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts (Alibaba Cloud account) in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The collection of UUIDs to unbind.</para>
        /// <remarks>
        /// <para><b>Bind</b> and <b>UnBind</b> cannot both be empty.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnBind")]
        [Validation(Required=false)]
        public List<string> UnBind { get; set; }

    }

}
