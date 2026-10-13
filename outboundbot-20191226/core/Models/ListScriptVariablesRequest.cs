// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptVariablesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID (also known as the business ID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e55ad0f-7a07-420e-a9b0-62d66ba7278a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the environment is a test environment.</para>
        /// <list type="bullet">
        /// <item><description>true: Test environment.</description></item>
        /// <item><description>false: Production environment after release.</description></item>
        /// <item><description>Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Sandbox")]
        [Validation(Required=false)]
        public bool? Sandbox { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62318d71-1128-4fd7-af15-c852cbe26b93</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
