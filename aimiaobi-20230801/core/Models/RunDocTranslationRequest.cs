// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocTranslationRequest : TeaModel {
        /// <summary>
        /// <para>Clear the current cache?</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CleanCache")]
        [Validation(Required=false)]
        public bool? CleanCache { get; set; }

        /// <summary>
        /// <para>Document ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>User-defined model name</para>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max、quanmiao-plus</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Content to be translated</para>
        /// 
        /// <b>Example:</b>
        /// <para>要翻译的内容</para>
        /// </summary>
        [NameInMap("RecommendContent")]
        [Validation(Required=false)]
        public string RecommendContent { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e6b3987-f743-4d4c-8326-d9c41a6af3ee</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Translation type</para>
        /// 
        /// <b>Example:</b>
        /// <para>toChinese
        /// toEnglish
        /// toJapenese
        /// toRussian
        /// toFrench
        /// toGerman
        /// toItalian
        /// toKorean
        /// toSpanish
        /// toPortuguese</para>
        /// </summary>
        [NameInMap("TransType")]
        [Validation(Required=false)]
        public string TransType { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud Model Studio workspace unique identifier. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get the Workspace ID</a>.</para>
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
