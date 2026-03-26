// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Model : TeaModel {
        /// <summary>
        /// <para>The workspace accessibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE (default): The model is accessible only to you and the administrator of the workspace.</description></item>
        /// <item><description>PUBLIC: The model is accessible to all members of the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The domain where the model is applied, such as nlp (Natural Language Processing) and cv (Computer Vision).</para>
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
        /// <para>The time when the model was created, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtLatestVersionModifiedTime")]
        [Validation(Required=false)]
        public string GmtLatestVersionModifiedTime { get; set; }

        /// <summary>
        /// <para>The time when the model was last modified, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The labels.</para>
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
        /// </summary>
        [NameInMap("ModelDescription")]
        [Validation(Required=false)]
        public string ModelDescription { get; set; }

        /// <summary>
        /// <para>The model document.</para>
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
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model type, such as checkpoint and LoRA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Checkpoint</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The sequence number of the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public long? OrderNumber { get; set; }

        /// <summary>
        /// <para>The community or organization to which the source model belongs, such as ModelScope or Hugging Face.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModelScope</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1557702098******</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
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

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Label> Tags { get; set; }

        /// <summary>
        /// <para>The task. The specific issue that the model resolves, such as text-classification.</para>
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
