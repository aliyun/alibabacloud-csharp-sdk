// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DialogueRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>broadcast</para>
        /// </summary>
        [NameInMap("ActionKey")]
        [Validation(Required=false)]
        public string ActionKey { get; set; }

        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1528189846043</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Outbound</para>
        /// </summary>
        [NameInMap("CallType")]
        [Validation(Required=false)]
        public string CallType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135****4353</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1***6</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6cea9bed-63e6-439e-ae4c-b3333efff53d</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <para>场景id</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5c5d8c0-c0f1-48a7-be2b-dc46006d888a</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ff44709e-39a6-43ba-959b-20fcabe3e496</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
