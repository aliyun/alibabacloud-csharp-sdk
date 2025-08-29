// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GenerateAlgorithmCustomizationScriptRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EasyDeploy</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pairec-test-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;item_table&quot;:&quot;array&quot;}</para>
        /// </summary>
        [NameInMap("ModuleFieldTypes")]
        [Validation(Required=false)]
        public Dictionary<string, object> ModuleFieldTypes { get; set; }

    }

}
