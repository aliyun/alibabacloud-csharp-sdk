// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCommentGenerationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowEmoji")]
        [Validation(Required=false)]
        public bool? AllowEmoji { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;short&quot;:&quot;50&quot;,&quot;long&quot;:“50”}</para>
        /// </summary>
        [NameInMap("LengthRange")]
        [Validation(Required=false)]
        public Dictionary<string, object> LengthRange { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NumComments")]
        [Validation(Required=false)]
        public string NumComments { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;positive&quot;:&quot;50&quot;,&quot;negative&quot;:&quot;50&quot;}</para>
        /// </summary>
        [NameInMap("Sentiment")]
        [Validation(Required=false)]
        public Dictionary<string, object> Sentiment { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceMaterial")]
        [Validation(Required=false)]
        public string SourceMaterial { get; set; }

        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;emotion&quot;:&quot;50&quot;,&quot;opinion&quot;:&quot;50&quot;}</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public Dictionary<string, object> Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-3kcs1w3lltrtbfkr</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
