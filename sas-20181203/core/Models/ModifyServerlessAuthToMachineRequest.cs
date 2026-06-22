// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyServerlessAuthToMachineRequest : TeaModel {
        /// <summary>
        /// <para>The application query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**7ad7e3a</para>
        /// </summary>
        [NameInMap("AppCriteria")]
        [Validation(Required=false)]
        public string AppCriteria { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SERVERLESS</b>: Serverless asset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SERVERLESS</para>
        /// </summary>
        [NameInMap("AuthItem")]
        [Validation(Required=false)]
        public string AuthItem { get; set; }

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
        /// <para>Specifies whether to bind all assets. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Bind all assets.</description></item>
        /// <item><description><b>false</b>: Do not bind all assets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BindAll")]
        [Validation(Required=false)]
        public bool? BindAll { get; set; }

        /// <summary>
        /// <para>The list of application IDs to bind.</para>
        /// <remarks>
        /// <para>Retrieve the IDs by calling the <a href="~~ListMachineApps~~">ListMachineApps</a> operation.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("BindAppList")]
        [Validation(Required=false)]
        public List<string> BindAppList { get; set; }

        /// <summary>
        /// <para>The Asset Type for the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTANCE</b>: instance.</description></item>
        /// <item><description><b>APP</b>: application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("BindAssetType")]
        [Validation(Required=false)]
        public string BindAssetType { get; set; }

        /// <summary>
        /// <para>The list of asset UUIDs to bind.</para>
        /// </summary>
        [NameInMap("BindUuidList")]
        [Validation(Required=false)]
        public List<string> BindUuidList { get; set; }

        /// <summary>
        /// <para>The search conditions for assets. This parameter is in JSON format. Pay attention to letter case when specifying this parameter.</para>
        /// <remarks>
        /// <para>You can search for assets by instance ID, instance name, VPC ID, region, public IP address, and other conditions. Call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;vulStatus&quot;,&quot;value&quot;:&quot;YES&quot;,&quot;logicalExp&quot;:&quot;AND&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The logical relationship among multiple search conditions. Valid values:</para>
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
        /// <para>The NTM version code for pre-binding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>level2</para>
        /// </summary>
        [NameInMap("NtmVersion")]
        [Validation(Required=false)]
        public string NtmVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a pre-binding operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After pre-binding is enabled, the corresponding edition authorization quota is automatically bound to the specified servers after the purchase is completed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PreBind")]
        [Validation(Required=false)]
        public int? PreBind { get; set; }

        /// <summary>
        /// <para>The pre-binding order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233016**0482</para>
        /// </summary>
        [NameInMap("PreBindOrderId")]
        [Validation(Required=false)]
        public long? PreBindOrderId { get; set; }

        /// <summary>
        /// <para>The UID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ResourceDirectoryUid")]
        [Validation(Required=false)]
        public long? ResourceDirectoryUid { get; set; }

        /// <summary>
        /// <para>The list of application IDs to unbind.</para>
        /// <remarks>
        /// <para>Retrieve the IDs by calling the <a href="~~ListMachineApps~~">ListMachineApps</a> operation.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnBindAppList")]
        [Validation(Required=false)]
        public List<string> UnBindAppList { get; set; }

        /// <summary>
        /// <para>The list of asset UUIDs to unbind.</para>
        /// </summary>
        [NameInMap("UnBindUuidList")]
        [Validation(Required=false)]
        public List<string> UnBindUuidList { get; set; }

    }

}
