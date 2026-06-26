// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ModifyUnrecognizingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The rejection action performed after the final rejection prompt is played.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TransferToAgent</para>
        /// </summary>
        [NameInMap("FinalAction")]
        [Validation(Required=false)]
        public string FinalAction { get; set; }

        /// <summary>
        /// <para>The action parameters for the rejection action, in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("FinalActionParams")]
        [Validation(Required=false)]
        public string FinalActionParams { get; set; }

        /// <summary>
        /// <para>The final rejection prompt. The service plays this prompt when the rejection threshold is met.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>再见</para>
        /// </summary>
        [NameInMap("FinalPrompt")]
        [Validation(Required=false)]
        public string FinalPrompt { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12f407b22cbe4890ac595f09985848d5</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The rejection prompt played when the service fails to recognize user input.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我不理解您的意思，请再说一遍</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The rejection threshold. The maximum number of consecutive rejections before the service triggers the rejection action.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

    }

}
