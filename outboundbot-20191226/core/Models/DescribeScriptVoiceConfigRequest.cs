// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeScriptVoiceConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8fa1953f-4a84-46d8-b80c-8ce9cf684fb3</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28c4bcaf-5ab1-495e-8966-3206bf9ee733</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2a07b634-e15d-445f-bbcb-fc4ea2df7b87</para>
        /// </summary>
        [NameInMap("ScriptVoiceConfigId")]
        [Validation(Required=false)]
        public string ScriptVoiceConfigId { get; set; }

    }

}
