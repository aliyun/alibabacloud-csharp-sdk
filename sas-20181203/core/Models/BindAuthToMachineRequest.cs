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
        /// <item><description><b>10</b>: Value-added Service Edition</description></item>
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
        /// <item><description><b>0</b>: Disabled</description></item>
        /// <item><description><b>1</b>: Enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <para>The set of UUIDs to be bound.</para>
        /// <remarks>
        /// <para><b>Bind</b> and <b>UnBind</b> cannot be empty at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Bind")]
        [Validation(Required=false)]
        public List<string> Bind { get; set; }

        /// <summary>
        /// <para>Specifies whether to bind all assets. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BindAll")]
        [Validation(Required=false)]
        public bool? BindAll { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You must use different tokens for different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Sets the conditions for searching assets. This parameter is in JSON format. Pay attention to the case sensitivity when you specify this parameter.</para>
        /// <remarks>
        /// <para>You can search for assets by using conditions such as the instance ID, instance name, VPC ID, region, and public IP address of the asset. You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;internetIp&quot;,&quot;value&quot;:&quot;1.2.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. true: only prechecks the request and does not perform the actual operation. false: performs the request normally. Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the operation is a pre-binding operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No</description></item>
        /// <item><description><b>1</b>: Yes</description></item>
        /// </list>
        /// <remarks>
        /// <para>After pre-binding is enabled, the system automatically binds the corresponding number of licenses of the specified version to the specified servers after the purchase is completed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsPreBind")]
        [Validation(Required=false)]
        public int? IsPreBind { get; set; }

        /// <summary>
        /// <para>Specifies the logical relationship among multiple search conditions. Default value: <b>OR</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: Specifies the <b>OR</b> logical relationship among multiple conditions.</description></item>
        /// <item><description><b>AND</b>: Specifies the <b>AND</b> logical relationship among multiple conditions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The version of the order associated with the pre-binding operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>level7</b>: Anti-virus Edition</description></item>
        /// <item><description><b>level3</b>: Advanced Edition</description></item>
        /// <item><description><b>level2</b>: Enterprise Edition</description></item>
        /// <item><description><b>level8</b>: Ultimate Edition</description></item>
        /// <item><description><b>level10</b>: Value-added services only</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>level2</para>
        /// </summary>
        [NameInMap("NtmVersion")]
        [Validation(Required=false)]
        public string NtmVersion { get; set; }

        /// <summary>
        /// <para>The ID of the order associated with the pre-binding operation.</para>
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
        /// <para>The ID of the member accounts in the resource folder. The ID is an Alibaba Cloud account ID.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The set of UUIDs to be unbound.</para>
        /// <remarks>
        /// <para><b>Bind</b> and <b>UnBind</b> cannot be empty at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnBind")]
        [Validation(Required=false)]
        public List<string> UnBind { get; set; }

    }

}
