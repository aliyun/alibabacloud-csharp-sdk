// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateModelRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the model in the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PRIVATE (default): The model is visible only to you and administrators in the workspace.</para>
        /// </description></item>
        /// <item><description><para>PUBLIC: The model is visible to everyone in the workspace.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The domain. This describes the field that the model is designed for, such as nlp (Natural Language Processing) or cv (computer vision).</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlp</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Other information about the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;RatingCount&quot;: 2866,
        ///     &quot;Rating&quot;: 4.94,
        ///     &quot;FavoriteCount&quot;: 34992,
        ///     &quot;CommentCount&quot;: 754,
        ///     &quot;CoverUris&quot;: [&quot;<a href="https://e***u.oss-cn-hangzhou.aliyuncs.com/drea***w.png%22%5D">https://e***u.oss-cn-hangzhou.aliyuncs.com/drea***w.png&quot;]</a>,
        ///     &quot;TippedAmountCount&quot;: 32,
        ///     &quot;DownloadCount&quot;: 606056
        /// }</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfo { get; set; }

        /// <summary>
        /// <para>A list of labels. This parameter is deprecated and is replaced by the Tag parameter.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The description of the model. Use this to distinguish different models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>News classification.</para>
        /// </summary>
        [NameInMap("ModelDescription")]
        [Validation(Required=false)]
        public string ModelDescription { get; set; }

        /// <summary>
        /// <para>The model documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://*.md</para>
        /// </summary>
        [NameInMap("ModelDoc")]
        [Validation(Required=false)]
        public string ModelDoc { get; set; }

        /// <summary>
        /// <para>The name of the model. The name must be 1 to 127 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>News classification</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model type, such as Checkpoint or LoRA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Checkpoint</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The ordinal number of the model. You can use this for custom sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public long? OrderNumber { get; set; }

        /// <summary>
        /// <para>The source of the model. This specifies the community or organization that the source model belongs to, such as ModelScope and HuggingFace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModelScope</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The number of parameters, in millions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("ParameterSize")]
        [Validation(Required=false)]
        public long? ParameterSize { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<Label> Tag { get; set; }

        /// <summary>
        /// <para>The task. This describes the specific problem that the model solves, such as text-classification (text classification).</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-classification</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

        /// <summary>
        /// <para>The ID of the workspace. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>796**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
