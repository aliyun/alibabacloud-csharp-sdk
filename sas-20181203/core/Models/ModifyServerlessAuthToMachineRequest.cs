// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyServerlessAuthToMachineRequest : TeaModel {
        /// <summary>
        /// <para>Application query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**7ad7e3a</para>
        /// </summary>
        [NameInMap("AppCriteria")]
        [Validation(Required=false)]
        public string AppCriteria { get; set; }

        /// <summary>
        /// <para>Instance type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>SERVERLESS</b>: Serverless asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SERVERLESS</para>
        /// </summary>
        [NameInMap("AuthItem")]
        [Validation(Required=false)]
        public string AuthItem { get; set; }

        /// <summary>
        /// <para>Enable auto-binding. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Off</description></item>
        /// <item><description><b>1</b>: On</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <para>Whether to bind all. Default is <b>false</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BindAll")]
        [Validation(Required=false)]
        public bool? BindAll { get; set; }

        /// <summary>
        /// <para>List of application IDs to be bound.</para>
        /// <remarks>
        /// <para>Obtained through the <a href="~~ListMachineApps~~">ListMachineApps</a> interface.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("BindAppList")]
        [Validation(Required=false)]
        public List<string> BindAppList { get; set; }

        /// <summary>
        /// <para>Type of asset to operate on. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTANCE</b>: Instance</description></item>
        /// <item><description><b>APP</b>: Application</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("BindAssetType")]
        [Validation(Required=false)]
        public string BindAssetType { get; set; }

        /// <summary>
        /// <para>List of asset UUIDs to be bound.</para>
        /// </summary>
        [NameInMap("BindUuidList")]
        [Validation(Required=false)]
        public List<string> BindUuidList { get; set; }

        /// <summary>
        /// <para>Set the conditions for searching assets. This parameter is in JSON format, and case sensitivity should be noted when entering parameters.</para>
        /// <remarks>
        /// <para>Supports searching assets using instance ID, instance name, VPC ID, region, public IP address, etc. You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> interface to query supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;vulStatus&quot;,&quot;value&quot;:&quot;YES&quot;,&quot;logicalExp&quot;:&quot;AND&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>Set the logical relationship between multiple search conditions. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: Indicates an <b>or</b> relationship between multiple conditions.</description></item>
        /// <item><description><b>AND</b>: Indicates an <b>and</b> relationship between multiple conditions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>NTM version code, used for pre-binding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>level2</para>
        /// </summary>
        [NameInMap("NtmVersion")]
        [Validation(Required=false)]
        public string NtmVersion { get; set; }

        /// <summary>
        /// <para>Whether it is a pre-bind operation. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No</description></item>
        /// <item><description><b>1</b>: Yes</description></item>
        /// </list>
        /// <remarks>
        /// <para>After enabling pre-binding, the specified server will automatically bind the corresponding version\&quot;s authorization count after the purchase is completed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PreBind")]
        [Validation(Required=false)]
        public int? PreBind { get; set; }

        /// <summary>
        /// <para>Pre-bind order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233016**0482</para>
        /// </summary>
        [NameInMap("PreBindOrderId")]
        [Validation(Required=false)]
        public long? PreBindOrderId { get; set; }

        /// <summary>
        /// <para>UID of the associated resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ResourceDirectoryUid")]
        [Validation(Required=false)]
        public long? ResourceDirectoryUid { get; set; }

        /// <summary>
        /// <para>List of application IDs to be unbound.</para>
        /// <remarks>
        /// <para>Obtained through the <a href="~~ListMachineApps~~">ListMachineApps</a> interface.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnBindAppList")]
        [Validation(Required=false)]
        public List<string> UnBindAppList { get; set; }

        /// <summary>
        /// <para>List of asset UUIDs to be unbound.</para>
        /// </summary>
        [NameInMap("UnBindUuidList")]
        [Validation(Required=false)]
        public List<string> UnBindUuidList { get; set; }

    }

}
