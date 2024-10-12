// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SaveMaterialDocumentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c160c841c8e54295bf2f441432785944_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BothSavePrivateAndShare")]
        [Validation(Required=false)]
        public bool? BothSavePrivateAndShare { get; set; }

        [NameInMap("DocKeywords")]
        [Validation(Required=false)]
        public List<string> DocKeywords { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>excel</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxxxx/xxx">http://xxxxx/xxx</a></para>
        /// </summary>
        [NameInMap("ExternalUrl")]
        [Validation(Required=false)]
        public string ExternalUrl { get; set; }

        [NameInMap("HtmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-11 06:14:07</para>
        /// </summary>
        [NameInMap("PubTime")]
        [Validation(Required=false)]
        public string PubTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShareAttr")]
        [Validation(Required=false)]
        public int? ShareAttr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IntellijSearch</para>
        /// </summary>
        [NameInMap("SrcFrom")]
        [Validation(Required=false)]
        public string SrcFrom { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("TextContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxxxx/xxx">http://xxxxx/xxx</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
