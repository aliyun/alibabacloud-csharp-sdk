// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RecipeEvalDetailView : TeaModel {
        /// <summary>
        /// <para>The startup command for the evaluation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python -m verl.trainer.main_ppo val_only=true</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The ID of the evaluation child table row, which is always the specifically parsed row.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3001</para>
        /// </summary>
        [NameInMap("DetailId")]
        [Validation(Required=false)]
        public long? DetailId { get; set; }

        /// <summary>
        /// <para>The template environment variables of the evaluation child table. The data type is map&lt;string,string&gt;. The values are fully echoed without masking. Therefore, credentials must not be stored in the template. Jobs with Mode=Eval use the values from this child table, which are independent of the training child table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PYTHONPATH&quot;:&quot;/opt/eval/verl&quot;}</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>The evaluation image with a fixed digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/rls/verl@sha256:0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>Indicates whether the child table is explicitly published by the platform as a shared default evaluation child table. The parsing process first checks the default of the current workspace and then falls back to the public default officially preset and published. A value of false indicates a private detail. Details in other empty workspaces are not automatically used as the public default. Inheritance still requires Resource Access Management (RAM) permissions for the current workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefaultDetail")]
        [Validation(Required=false)]
        public bool? IsDefaultDetail { get; set; }

        /// <summary>
        /// <para>The name of the model to which the child table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The framework default parameter layer, which echoes the original JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;data.val_files&quot;:[&quot;/mnt/input/gsm8k/test.parquet&quot;]}</para>
        /// </summary>
        [NameInMap("ParamsJson")]
        [Validation(Required=false)]
        public Dictionary<string, object> ParamsJson { get; set; }

        /// <summary>
        /// <para>The configuration renderer. Valid values: hydra.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hydra</para>
        /// </summary>
        [NameInMap("Renderer")]
        [Validation(Required=false)]
        public string Renderer { get; set; }

        /// <summary>
        /// <para>The parsed evaluation resource pool.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public RecipeResourceView Resource { get; set; }

        /// <summary>
        /// <para>The estimated runtime in minutes. A value of 0 indicates that the template does not specify a limit, and no upper limit is set for the job runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RuntimeMinutes")]
        [Validation(Required=false)]
        public int? RuntimeMinutes { get; set; }

    }

}
