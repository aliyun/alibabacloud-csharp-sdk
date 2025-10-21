// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class SubmitVideoDetectShotTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deduplicationId")]
        [Validation(Required=false)]
        public string DeduplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("intelliSimpPrompt")]
        [Validation(Required=false)]
        public string IntelliSimpPrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>intelliSimpShowPrompt</para>
        /// </summary>
        [NameInMap("intelliSimpPromptTemplateId")]
        [Validation(Required=false)]
        public string IntelliSimpPromptTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chinese</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>videoDetectShotShowPrompt</para>
        /// </summary>
        [NameInMap("modelCustomPromptTemplateId")]
        [Validation(Required=false)]
        public string ModelCustomPromptTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>deepseek-r1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>videoDetectShotVlShowPrompt</para>
        /// </summary>
        [NameInMap("modelVlCustomPromptTemplateId")]
        [Validation(Required=false)]
        public string ModelVlCustomPromptTemplateId { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a3d1c2ac-f086-4a21-9069-f5631542f5ax</para>
        /// </summary>
        [NameInMap("originalSessionId")]
        [Validation(Required=false)]
        public string OriginalSessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>deepseek-v3.1</para>
        /// </summary>
        [NameInMap("preModelId")]
        [Validation(Required=false)]
        public string PreModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("recognitionOptions")]
        [Validation(Required=false)]
        public List<string> RecognitionOptions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a3d1c2ac-f086-4a21-9069-f5631542f5a2</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.mp4">https://xxx.mp4</a></para>
        /// </summary>
        [NameInMap("videoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("vlPrompt")]
        [Validation(Required=false)]
        public string VlPrompt { get; set; }

    }

}
