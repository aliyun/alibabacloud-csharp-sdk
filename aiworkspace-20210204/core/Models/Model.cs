// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Model : TeaModel {
        /// <summary>
        /// <para>The workspace visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE (default): visible only to yourself and administrators within the workspace.</description></item>
        /// <item><description>PUBLIC: visible to all users in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The domain. Describes the domain of the problem that the model solves, such as nlp (natural language processing) or cv (computer vision).</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlp</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
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
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfo { get; set; }

        /// <summary>
        /// <para>The UTC time of model creation, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the latest version was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtLatestVersionModifiedTime")]
        [Validation(Required=false)]
        public string GmtLatestVersionModifiedTime { get; set; }

        /// <summary>
        /// <para>The time when the model was last updated in UTC, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The label list. This parameter will be deprecated and replaced by Tag.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The latest version of the model.</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public ModelVersion LatestVersion { get; set; }

        /// <summary>
        /// <para>The model description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sentiment analysis</para>
        /// </summary>
        [NameInMap("ModelDescription")]
        [Validation(Required=false)]
        public string ModelDescription { get; set; }

        /// <summary>
        /// <para>The model documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***.md</para>
        /// </summary>
        [NameInMap("ModelDoc")]
        [Validation(Required=false)]
        public string ModelDoc { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-1123*****</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sentiment Analysis</para>
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
        /// <para>The model sequence number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public long? OrderNumber { get; set; }

        /// <summary>
        /// <para>The model origin. Describes the community or organization to which the source model belongs, such as ModelScope or HuggingFace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModelScope</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1557702098******</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The number of parameters, in millions (M).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("ParameterSize")]
        [Validation(Required=false)]
        public long? ParameterSize { get; set; }

        /// <summary>
        /// <para>The model provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Label> Tags { get; set; }

        /// <summary>
        /// <para>The task. Describes the specific problem that the model solves, such as text-classification (text categorization).</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-classifiaction</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1557702098******</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
