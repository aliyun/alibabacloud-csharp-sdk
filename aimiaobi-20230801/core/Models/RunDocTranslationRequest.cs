// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocTranslationRequest : TeaModel {
        [NameInMap("CleanCache")]
        [Validation(Required=false)]
        public bool? CleanCache { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("RecommendContent")]
        [Validation(Required=false)]
        public string RecommendContent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e6b3987-f743-4d4c-8326-d9c41a6af3ee</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>toChinese
        /// toEnglish</para>
        /// </summary>
        [NameInMap("TransType")]
        [Validation(Required=false)]
        public string TransType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
