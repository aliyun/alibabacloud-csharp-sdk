// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GenerateAlgorithmCustomizationScriptRequest : TeaModel {
        /// <summary>
        /// <para>The deployment mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>EasyDeploy</b>: Performs a one-click deployment.</para>
        /// </description></item>
        /// <item><description><para><b>GenerateScript</b>: Generates a deployment script.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EasyDeploy</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// <para>The ID of the instance. To obtain this ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The data types of fields in the JSON configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;item_table&quot;:&quot;array&quot;}</para>
        /// </summary>
        [NameInMap("ModuleFieldTypes")]
        [Validation(Required=false)]
        public Dictionary<string, object> ModuleFieldTypes { get; set; }

    }

}
