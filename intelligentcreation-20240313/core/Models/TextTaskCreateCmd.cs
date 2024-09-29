// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class TextTaskCreateCmd : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>极氪007新车上市</para>
        /// </summary>
        [NameInMap("contentRequirement")]
        [Validation(Required=false)]
        public string ContentRequirement { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>28274623764834</para>
        /// </summary>
        [NameInMap("idempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>超强续航</para>
        /// </summary>
        [NameInMap("point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        [NameInMap("referenceTag")]
        [Validation(Required=false)]
        public ReferenceTag ReferenceTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("relatedRagIds")]
        [Validation(Required=false)]
        public List<long?> RelatedRagIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("streamApi")]
        [Validation(Required=false)]
        public bool? StreamApi { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("textModeType")]
        [Validation(Required=false)]
        public string TextModeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>旅游路线</para>
        /// </summary>
        [NameInMap("theme")]
        [Validation(Required=false)]
        public string Theme { get; set; }

        [NameInMap("themes")]
        [Validation(Required=false)]
        public List<string> Themes { get; set; }

    }

}
