// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CreateScriptRequest : TeaModel {
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
        /// <para>The script type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>BOOTSTRAP: an ECS instance bootstrap script.</para>
        /// </description></item>
        /// <item><description><para>NORMAL: a normal script.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BOOTSTRAP</para>
        /// </summary>
        [NameInMap("ScriptType")]
        [Validation(Required=false)]
        public string ScriptType { get; set; }

        /// <summary>
        /// <para>The list of scripts.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public List<Script> Scripts { get; set; }

        /// <summary>
        /// <para>The timeout period for manually executing the script. This parameter is not supported for bootstrap scripts.</para>
        /// </summary>
        [NameInMap("TimeoutSecs")]
        [Validation(Required=false)]
        public string TimeoutSecs { get; set; }

    }

}
