// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyDialogueFlowRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DialogueFlowDefinition")]
        [Validation(Required=false)]
        public string DialogueFlowDefinition { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>390515b5-6115-4ccf-83e2-52d5bfaf2ddf</para>
        /// </summary>
        [NameInMap("DialogueFlowId")]
        [Validation(Required=false)]
        public string DialogueFlowId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>da37319b-6c83-4268-9f19-814aed62e401</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDrafted")]
        [Validation(Required=false)]
        public bool? IsDrafted { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b0f35dd1-0337-402e-9c4f-3a6c2426950a</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
