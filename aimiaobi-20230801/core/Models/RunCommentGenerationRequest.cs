// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCommentGenerationRequest : TeaModel {
        /// <summary>
        /// <para>Set to true to allow emoji in comments. Default is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowEmoji")]
        [Validation(Required=false)]
        public bool? AllowEmoji { get; set; }

        /// <summary>
        /// <para>Additional instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>不要输出额外其他信息</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>Length of each comment in characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>Length distribution.</para>
        /// <para>Valid keys:</para>
        /// <list type="bullet">
        /// <item><description><para>short (up to 20 characters)</para>
        /// </description></item>
        /// <item><description><para>medium (20–50 characters)</para>
        /// </description></item>
        /// <item><description><para>long (50–100 characters)</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;short&quot;:&quot;50&quot;,&quot;long&quot;:“50”}</para>
        /// </summary>
        [NameInMap("LengthRange")]
        [Validation(Required=false)]
        public Dictionary<string, object> LengthRange { get; set; }

        /// <summary>
        /// <para>ID of the model to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max、quanmiao-plus</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>Number of comments to generate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NumComments")]
        [Validation(Required=false)]
        public string NumComments { get; set; }

        /// <summary>
        /// <para>Sentiment distribution.</para>
        /// <para>Valid keys:</para>
        /// <list type="bullet">
        /// <item><description><para>positive</para>
        /// </description></item>
        /// <item><description><para>neutral</para>
        /// </description></item>
        /// <item><description><para>negative</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;positive&quot;:&quot;50&quot;,&quot;negative&quot;:&quot;50&quot;}</para>
        /// </summary>
        [NameInMap("Sentiment")]
        [Validation(Required=false)]
        public Dictionary<string, object> Sentiment { get; set; }

        /// <summary>
        /// <para>Session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Article to comment on.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ps5是sony新一代的游戏机，他创新性的...</para>
        /// </summary>
        [NameInMap("SourceMaterial")]
        [Validation(Required=false)]
        public string SourceMaterial { get; set; }

        /// <summary>
        /// <para>Tone of the comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>积极正面</para>
        /// </summary>
        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        /// <summary>
        /// <para>Comment type.</para>
        /// <para>Valid keys:</para>
        /// <list type="bullet">
        /// <item><description><para>emotion (expresses emotion)</para>
        /// </description></item>
        /// <item><description><para>opinion (states an opinion)</para>
        /// </description></item>
        /// <item><description><para>interaction (encourages interaction)</para>
        /// </description></item>
        /// <item><description><para>experience (shares experience)</para>
        /// </description></item>
        /// <item><description><para>humor (uses humor)</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;emotion&quot;:&quot;50&quot;,&quot;opinion&quot;:&quot;50&quot;}</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public Dictionary<string, object> Type { get; set; }

        /// <summary>
        /// <para>Path parameter. The unique identifier of your Alibaba Cloud Model Studio workspace. To get this ID, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get the workspace ID</a>.</para>
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
