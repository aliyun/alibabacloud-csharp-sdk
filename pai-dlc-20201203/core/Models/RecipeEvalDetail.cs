// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RecipeEvalDetail : TeaModel {
        /// <summary>
        /// <para>The evaluation startup command in argv format. This parameter is optional. If left empty, the template does not specify a command, and the caller must provide it when creating the job. The string-type pai.entrypoint parameter at the parameter level takes precedence over this field. In this case, the command is stored but does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python -m verl.trainer.main_ppo val_only=true</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The template environment variables, in the format of map&lt;string,string&gt;. Evaluation jobs use the values from this child table, which are independent of the training child table because the images on both sides are different. When creating a job, these variables are merged with the environment variables in the request by key. If a key exists in both, the value in the request takes precedence. Do not include credentials. Names starting with <em>PAI_PRIVATE_ENV</em> are rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PYTHONPATH&quot;:&quot;/opt/eval/verl&quot;}</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>The evaluation image. This parameter is optional. If left empty, the template does not specify an image, and the caller must provide it when creating the job. If specified, the value must be pinned to a SHA-256 digest in the format of name@sha256:&lt;64-character hexadecimal string&gt; or an explicit tag in the format of name:tag. Bare image names with an implicit :latest tag are rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/rls/verl@sha256:0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>Only platform callers can set this parameter to true, and they must still pass Resource Access Management (RAM) authentication for the current workspace ID. Defaults published by custom recipes are limited to their workspaces. Defaults published by official preset recipes are not bound to a user workspace and serve as a public official fallback. The inheritance mechanism first checks the default of the current workspace and then falls back to the public official default. If set to false, the record is a normal detail and does not participate in default inheritance. However, it can still be referenced by ID after passing the read authentication of the source recipe. Details in other empty workspaces are not automatically made public.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefaultDetail")]
        [Validation(Required=false)]
        public bool? IsDefaultDetail { get; set; }

        /// <summary>
        /// <para>The name of the model to which the child table belongs. If left empty, the model of the main row is inherited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The framework default parameter layer, which is a raw JSON object. As the default value layer, reserved key validation is not performed during creation. If specified, the value must be valid JSON.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;data.val_files&quot;:[&quot;/mnt/input/gsm8k/test.parquet&quot;]}</para>
        /// </summary>
        [NameInMap("ParamsJson")]
        [Validation(Required=false)]
        public Dictionary<string, object> ParamsJson { get; set; }

        /// <summary>
        /// <para>The configuration renderer. Valid values: hydra. In the first phase, only hydra is implemented. If left empty, the default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hydra</para>
        /// </summary>
        [NameInMap("Renderer")]
        [Validation(Required=false)]
        public string Renderer { get; set; }

        /// <summary>
        /// <para>The inline resource pool. This parameter and ResourceId are mutually exclusive. The inline resource must be of the eval type. When referencing an existing pool, the workspace scope and read permissions of the source recipe must be met.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public RecipeResource Resource { get; set; }

        /// <summary>
        /// <para>The ID of the existing evaluation resource pool row to reference. This parameter and Resource are mutually exclusive. If the specified row does not exist, the Recipe.InvalidParameter (400) error is returned, and the original resource type validation is retained. The row must be reachable from the source recipe of the current tenant and workspace or a public official source recipe. It must also pass the current paidlc:CreateRecipe and source paidlc:GetRecipe authentication. Any readable source for the same row is sufficient, and SourceRecipeId is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public long? ResourceId { get; set; }

        /// <summary>
        /// <para>The estimated runtime in minutes. The value must be greater than or equal to 0. A value of 0 or the default value indicates that the template does not specify a runtime, and no upper limit is set for the job runtime. The platform does not provide a default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RuntimeMinutes")]
        [Validation(Required=false)]
        public int? RuntimeMinutes { get; set; }

    }

}
