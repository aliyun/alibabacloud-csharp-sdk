// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RecipeTrainDetailView : TeaModel {
        /// <summary>
        /// <para>The training start command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python -m verl.trainer.main_ppo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The ID of the training detail row, which is always the specifically resolved row.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001</para>
        /// </summary>
        [NameInMap("DetailId")]
        [Validation(Required=false)]
        public long? DetailId { get; set; }

        /// <summary>
        /// <para>The template environment variables of the training detail table, in map&lt;string,string&gt; format. Values are fully echoed without desensitization, so credentials must not be stored in the template. An empty value indicates that the template does not set environment variables. When creating a job, it is merged with the requested Envs by key, and the requested values take precedence for identical keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PYTHONPATH&quot;:&quot;/workspace/verl&quot;}</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>The training image with a fixed digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/rls/verl@sha256:0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The inference-side rollout image with a fixed digest. It is consumed by created jobs only when TrainerMode is set to SeparateAsync. An empty value indicates that the template does not provide an inference-side image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/rls/sglang@sha256:0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("InferenceImage")]
        [Validation(Required=false)]
        public string InferenceImage { get; set; }

        /// <summary>
        /// <para>The default parameter layer of the inference-side framework, which echoes the original JSON object. It participates in merging and overrides TrainingParamsJson only when TrainerMode is set to SeparateAsync. In other modes, it is echoed but does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;actor_rollout_ref.rollout.name&quot;:&quot;sglang&quot;,&quot;trainer.disaggregated.enable&quot;:true}</para>
        /// </summary>
        [NameInMap("InferenceParamsJson")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceParamsJson { get; set; }

        /// <summary>
        /// <para>The resolved inference-side resource pool of the inference type. It is consumed by created jobs only when TrainerMode is set to SeparateAsync. An empty value indicates that the template does not provide inference-side resources.</para>
        /// </summary>
        [NameInMap("InferenceResource")]
        [Validation(Required=false)]
        public RecipeResourceView InferenceResource { get; set; }

        /// <summary>
        /// <para>Specifies whether the detail table is explicitly published by the platform as a shared default training detail table. The resolution first checks the default of the current workspace, and then falls back to the public default published by official presets. A value of false indicates a private detail. Details in other empty workspaces are not automatically used as public defaults. Inheritance still requires RAM permissions for the current operating workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefaultDetail")]
        [Validation(Required=false)]
        public bool? IsDefaultDetail { get; set; }

        /// <summary>
        /// <para>The name of the model to which the detail table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

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
        /// <para>The estimated runtime in minutes. A value of 0 indicates that the template does not specify a duration, and the job does not have a runtime limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("RuntimeMinutes")]
        [Validation(Required=false)]
        public int? RuntimeMinutes { get; set; }

        /// <summary>
        /// <para>The default checkpoint save interval in steps. A value of -1 indicates that checkpoints are not saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SaveIntervalStepsDefault")]
        [Validation(Required=false)]
        public int? SaveIntervalStepsDefault { get; set; }

        /// <summary>
        /// <para>The resolved training-side resource pool.</para>
        /// </summary>
        [NameInMap("TrainResource")]
        [Validation(Required=false)]
        public RecipeResourceView TrainResource { get; set; }

        /// <summary>
        /// <para>The training and inference execution mode. Valid values: Sync, ColocateAsync, and SeparateAsync.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sync</para>
        /// </summary>
        [NameInMap("TrainerMode")]
        [Validation(Required=false)]
        public string TrainerMode { get; set; }

        /// <summary>
        /// <para>The default parameter layer of the training-side framework, which echoes the original JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;algorithm.adv_estimator&quot;:&quot;gae&quot;}</para>
        /// </summary>
        [NameInMap("TrainingParamsJson")]
        [Validation(Required=false)]
        public Dictionary<string, object> TrainingParamsJson { get; set; }

    }

}
