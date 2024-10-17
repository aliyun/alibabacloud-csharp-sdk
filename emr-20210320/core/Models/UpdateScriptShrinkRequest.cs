// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateScriptShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The script.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string ScriptShrink { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-da7476a7679a4d4c9cede62ebe09****</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The type of the script. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BOOTSTRAP: indicates a bootstrap action of the Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description>NORMAL: indicates a common script.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BOOTSTRAP</para>
        /// </summary>
        [NameInMap("ScriptType")]
        [Validation(Required=false)]
        public string ScriptType { get; set; }

    }

}
