// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UpdateMaterialDocumentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67c520d1fa43455ea44fb69fa402d54d_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        [NameInMap("DocKeywords")]
        [Validation(Required=false)]
        public string DocKeywordsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-11 06:14:07</para>
        /// </summary>
        [NameInMap("PubTime")]
        [Validation(Required=false)]
        public string PubTime { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShareAttr")]
        [Validation(Required=false)]
        public int? ShareAttr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UserUpload</para>
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
