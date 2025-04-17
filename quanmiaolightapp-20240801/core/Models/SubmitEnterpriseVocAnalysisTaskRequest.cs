// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class SubmitEnterpriseVocAnalysisTaskRequest : TeaModel {
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("contents")]
        [Validation(Required=false)]
        public List<SubmitEnterpriseVocAnalysisTaskRequestContents> Contents { get; set; }
        public class SubmitEnterpriseVocAnalysisTaskRequestContents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>id-xxxxx</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://default/aimiaobi-service-prod/aimiaobi/temp/public/government_service_experience_feedback_summary.txt</para>
        /// </summary>
        [NameInMap("fileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        [NameInMap("filterTags")]
        [Validation(Required=false)]
        public List<SubmitEnterpriseVocAnalysisTaskRequestFilterTags> FilterTags { get; set; }
        public class SubmitEnterpriseVocAnalysisTaskRequestFilterTags : TeaModel {
            [NameInMap("tagDefinePrompt")]
            [Validation(Required=false)]
            public string TagDefinePrompt { get; set; }

            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("outputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<SubmitEnterpriseVocAnalysisTaskRequestTags> Tags { get; set; }
        public class SubmitEnterpriseVocAnalysisTaskRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("tagDefinePrompt")]
            [Validation(Required=false)]
            public string TagDefinePrompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/xxxx.txt">http://www.example.com/xxxx.txt</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
