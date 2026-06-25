// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PRIVATE: The model is visible only to you and administrators in the workspace.</para>
        /// </description></item>
        /// <item><description><para>PUBLIC: The model is visible to everyone in the workspace.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The domain. This indicates the domain of the problem that the model is designed to solve, such as natural language processing (NLP) and computer vision (CV).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cv</para>
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
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfo { get; set; }

        /// <summary>
        /// <para>The UTC time when the model was created. The time is in the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the latest version was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtLatestVersionModifiedTime")]
        [Validation(Required=false)]
        public string GmtLatestVersionModifiedTime { get; set; }

        /// <summary>
        /// <para>The UTC time when the model was last updated. The time is in the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The list of labels for the model.</para>
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
        /// <para>General sentiment analysis.</para>
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
        /// <para>model-rbvg5wzljz****ks92</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sentiment analysis</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Checkpoint</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The ordinal number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public long? OrderNumber { get; set; }

        /// <summary>
        /// <para>The source of the model. This indicates the community or organization to which the source model belongs, such as ModelScope and HuggingFace.</para>
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
        /// <para>1234567890******</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

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
        /// <para>The provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task. This indicates the specific problem that the model is designed to solve, such as text classification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-classification</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890******</para>
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
