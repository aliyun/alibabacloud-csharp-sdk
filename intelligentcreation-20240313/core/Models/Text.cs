// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class Text : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("illustrationTaskIdList")]
        [Validation(Required=false)]
        public List<long?> IllustrationTaskIdList { get; set; }

        [NameInMap("publishStatus")]
        [Validation(Required=false)]
        public string PublishStatus { get; set; }

        [NameInMap("textContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("textId")]
        [Validation(Required=false)]
        public long? TextId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("textIllustrationTag")]
        [Validation(Required=false)]
        public bool? TextIllustrationTag { get; set; }

        [NameInMap("textModeType")]
        [Validation(Required=false)]
        public string TextModeType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Generating</para>
        /// </summary>
        [NameInMap("textStatus")]
        [Validation(Required=false)]
        public string TextStatus { get; set; }

        [NameInMap("textStyleType")]
        [Validation(Required=false)]
        public string TextStyleType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("textTaskId")]
        [Validation(Required=false)]
        public long? TextTaskId { get; set; }

        [NameInMap("textThemes")]
        [Validation(Required=false)]
        public List<string> TextThemes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("userNameCreate")]
        [Validation(Required=false)]
        public string UserNameCreate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("userNameModified")]
        [Validation(Required=false)]
        public string UserNameModified { get; set; }

    }

}
