// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RecipeTrainDetail : TeaModel {
        /// <summary>
        /// <para>The training startup command in argv format. This parameter is optional. If left empty, the template does not specify a command, and the command is provided by the pai.entrypoint of TrainingConfig or the string-type pai.entrypoint in TrainingParamsJson (module format) when the job is created. If all are missing, the job creation returns a 400 error with the message &quot;configuration.pai.entrypoint: nonempty argv required&quot;. If specified, it serves as the source of the job&quot;s pai.entrypoint. However, the string-type pai.entrypoint at the parameter level takes precedence (module format). In this case, the command is stored but does not take effect. Templates in module format should be left empty instead of filling in a placeholder command that is never executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python -m verl.trainer.main_ppo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The template environment variables, represented as a map&lt;string,string&gt;. When a job is created, these variables are merged with the Envs in the request by key. If a key exists in both, the value in the request takes precedence. Credentials are prohibited. Names starting with <em>PAI_PRIVATE_ENV</em> are rejected. Both the default value and an empty object indicate that the template does not set environment variables. Names reserved by the platform, such as HF_HOME, TMPDIR, and prefixes starting with RLS_, are not blocked during creation but are rejected during job creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PYTHONPATH&quot;:&quot;/workspace/verl&quot;}</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>The training image. This parameter is optional. If left empty, the template does not specify an image, and the image is provided by JobSpecs[].Image when the job is created. If both are missing, the job creation returns a 400 error with the message &quot;JobSpecs.Image: must not be blank&quot;. If specified, the image must be pinned to a sha256 digest (name@sha256:&lt;64-character hexadecimal&gt;) or an explicit tag (name:tag). Bare image names with an implicit :latest tag are rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/rls/verl@sha256:0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The inference rollout image. If specified, the image must be pinned to a sha256 digest (name@sha256:&lt;64-character hexadecimal&gt;) or an explicit tag (name:tag). This image is consumed only when TrainerMode is set to DisaggregateAsync to build the rollout pool. In other modes, it is stored but does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/rls/sglang@sha256:0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("InferenceImage")]
        [Validation(Required=false)]
        public string InferenceImage { get; set; }

        /// <summary>
        /// <para>The default parameter layer for the inference framework, represented as a raw JSON object. It always participates in merging in all Train modes, although the rollout pool itself is built only in DisaggregateAsync mode. Keys with the same name override those in TrainingParamsJson, which is consistent with the priority of TrainingConfig &lt; RolloutConfig on the request side. In other modes, it is stored but does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;actor_rollout_ref.rollout.name&quot;:&quot;sglang&quot;,&quot;trainer.disaggregated.enable&quot;:true,&quot;trainer.disaggregated.mode&quot;:&quot;full&quot;,&quot;trainer.train_mode&quot;:&quot;rl_training&quot;}</para>
        /// </summary>
        [NameInMap("InferenceParamsJson")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceParamsJson { get; set; }

        /// <summary>
        /// <para>The inline resource pool for inference. You must specify either this parameter or InferenceResourceId. The resource must be of the inference type and is consumed only when TrainerMode is set to SeparateAsync. The specification shape is consistent with the training side, where the pod_count in Specs represents the number of rollout replicas. It must not contain a quota_id. The quota is provided by CreateRLJob.ResourceId. When referencing an existing pool, the workspace scope and read permissions of the source recipe must be met.</para>
        /// </summary>
        [NameInMap("InferenceResource")]
        [Validation(Required=false)]
        public RecipeResource InferenceResource { get; set; }

        /// <summary>
        /// <para>The ID of the row in an existing inference resource pool. You must specify either this parameter or InferenceResource. It is consumed only when TrainerMode is set to SeparateAsync. If the ID does not exist, a Recipe.InvalidParameter (400) error is returned, and the original resource type validation is maintained. The row must be reachable from the source recipe of the current tenant and workspace or a public official source recipe. It must also pass the current paidlc:CreateRecipe and source paidlc:GetRecipe authentication. Any readable source for the same row is sufficient, and SourceRecipeId is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002</para>
        /// </summary>
        [NameInMap("InferenceResourceId")]
        [Validation(Required=false)]
        public long? InferenceResourceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to publish the child table as the shared default training child table for the model. Only platform callers can set this parameter to true, and they must still pass the RAM authentication for the current WorkspaceId. Defaults published by custom recipes are limited to their workspaces. Defaults published by official preset recipes are not bound to user workspaces and serve as public official fallbacks. Inheritance first checks the default of the current workspace, and then falls back to the public official default. If set to false, the child table is a regular detail and does not participate in default inheritance, but can still be referenced by ID after passing the read authentication of the source recipe. Details in other empty workspaces are not automatically made public.</para>
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
        /// <para>The configuration renderer. Valid values: hydra. Only hydra is implemented in the first phase. If left empty, the default value is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hydra</para>
        /// </summary>
        [NameInMap("Renderer")]
        [Validation(Required=false)]
        public string Renderer { get; set; }

        /// <summary>
        /// <para>The estimated runtime in minutes. The value must be greater than or equal to 0. Both 0 and the default value indicate that the template does not specify a runtime, and the job does not have a runtime limit. The platform does not provide a default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("RuntimeMinutes")]
        [Validation(Required=false)]
        public int? RuntimeMinutes { get; set; }

        /// <summary>
        /// <para>The default checkpoint save interval in steps. The value must be greater than or equal to -1. A value of -1 indicates that checkpoints are not saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SaveIntervalStepsDefault")]
        [Validation(Required=false)]
        public int? SaveIntervalStepsDefault { get; set; }

        /// <summary>
        /// <para>The inline resource pool for training. You must specify either this parameter or TrainResourceId. The inline resource must be of the train type. When referencing an existing pool, the workspace scope and read permissions of the source recipe must be met.</para>
        /// </summary>
        [NameInMap("TrainResource")]
        [Validation(Required=false)]
        public RecipeResource TrainResource { get; set; }

        /// <summary>
        /// <para>The ID of the row in an existing training resource pool. You must specify either this parameter or TrainResource. If the ID does not exist, a Recipe.InvalidParameter (400) error is returned, and the original resource type validation is maintained. The row must be reachable from the source recipe of the current tenant and workspace or a public official source recipe. It must also pass the current paidlc:CreateRecipe and source paidlc:GetRecipe authentication. Any readable source for the same row is sufficient, and SourceRecipeId is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("TrainResourceId")]
        [Validation(Required=false)]
        public long? TrainResourceId { get; set; }

        /// <summary>
        /// <para>The training and inference execution mode. Valid values: ColocateSync and DisaggregateAsync. The legacy spellings Sync and ColocateAsync are normalized to ColocateSync, and SeparateAsync is normalized to DisaggregateAsync. For DisaggregateAsync, the rollout side is provided by InferenceImage and InferenceResource. This parameter is not mandatory when creating a template. If missing, the error is attributed to RecipeId or JobSpecs based on actionability during job creation. This parameter is specified by the caller and is not overridden by the platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ColocateSync</para>
        /// </summary>
        [NameInMap("TrainerMode")]
        [Validation(Required=false)]
        public string TrainerMode { get; set; }

        /// <summary>
        /// <para>The default parameter layer for the training framework, represented as a raw JSON object. It serves as the default value layer. Reserved key validation is not performed during creation. If specified, it must be a valid JSON object. If it does not contain the path and experiment name, the job creation request must include these keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;algorithm.adv_estimator&quot;:&quot;gae&quot;,&quot;data.train_files&quot;:[&quot;/mnt/input/gsm8k/train.parquet&quot;]}</para>
        /// </summary>
        [NameInMap("TrainingParamsJson")]
        [Validation(Required=false)]
        public Dictionary<string, object> TrainingParamsJson { get; set; }

    }

}
