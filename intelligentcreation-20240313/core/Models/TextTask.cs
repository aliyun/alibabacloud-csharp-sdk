// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class TextTask : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>九寨沟三日游攻略</para>
        /// </summary>
        [NameInMap("contentRequirement")]
        [Validation(Required=false)]
        public string ContentRequirement { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nums")]
        [Validation(Required=false)]
        public int? Nums { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        [NameInMap("referenceTag")]
        [Validation(Required=false)]
        public ReferenceTag ReferenceTag { get; set; }

        [NameInMap("relatedRagIds")]
        [Validation(Required=false)]
        public List<long?> RelatedRagIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        [NameInMap("textIds")]
        [Validation(Required=false)]
        public List<long?> TextIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("textModeType")]
        [Validation(Required=false)]
        public string TextModeType { get; set; }

        [NameInMap("textTaskId")]
        [Validation(Required=false)]
        public long? TextTaskId { get; set; }

        [NameInMap("textTaskStatus")]
        [Validation(Required=false)]
        public string TextTaskStatus { get; set; }

        [NameInMap("texts")]
        [Validation(Required=false)]
        public List<Text> Texts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>旅游路线</para>
        /// </summary>
        [NameInMap("theme")]
        [Validation(Required=false)]
        public string Theme { get; set; }

        [NameInMap("themeDesc")]
        [Validation(Required=false)]
        public string ThemeDesc { get; set; }

    }

}
