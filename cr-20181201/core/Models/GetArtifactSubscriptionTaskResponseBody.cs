// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactSubscriptionTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The artifact type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The end time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1691979202000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The API call was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The API call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ACR namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>The ACR repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-repo</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12589EF7-96E2-4554-AAD7-F7209E88CAD3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>library</para>
        /// </summary>
        [NameInMap("SourceNamespaceName")]
        [Validation(Required=false)]
        public string SourceNamespaceName { get; set; }

        /// <summary>
        /// <para>The artifact source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOCKER_HUB</para>
        /// </summary>
        [NameInMap("SourceProvider")]
        [Validation(Required=false)]
        public string SourceProvider { get; set; }

        /// <summary>
        /// <para>The source repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx</para>
        /// </summary>
        [NameInMap("SourceRepoName")]
        [Validation(Required=false)]
        public string SourceRepoName { get; set; }

        /// <summary>
        /// <para>The source artifact type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("SourceRepoType")]
        [Validation(Required=false)]
        public string SourceRepoType { get; set; }

        /// <summary>
        /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1568718468000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The number of subscribed tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TagSubscriptionCount")]
        [Validation(Required=false)]
        public long? TagSubscriptionCount { get; set; }

        /// <summary>
        /// <para>The total number of tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TagTotalCount")]
        [Validation(Required=false)]
        public long? TagTotalCount { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crast-40le4es9yh0p****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("TaskResult")]
        [Validation(Required=false)]
        public string TaskResult { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
