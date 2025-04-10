// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class SubmitTagMiningAnalysisTaskRequest : TeaModel {
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>clueMining</para>
        /// </summary>
        [NameInMap("businessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("contents")]
        [Validation(Required=false)]
        public List<string> Contents { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>额外信息</para>
        /// </summary>
        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请返回如下JSON格式，{&quot;key1&quot;:&quot;&quot;,&quot;key2&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("outputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<SubmitTagMiningAnalysisTaskRequestTags> Tags { get; set; }
        public class SubmitTagMiningAnalysisTaskRequestTags : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>给你一条待分析文本数据，请你按照标签体系来对数据进行打标。</para>
        /// </summary>
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
