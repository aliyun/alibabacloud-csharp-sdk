// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateMediaConvertTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>When performing media concatenation, the index of the primary media file (which provides the default transcoding parameters for <c>Video</c> and <c>Audio</c>, including resolution, frame rate, etc.) in the concatenation list. The default value is 0 (aligning with the first media file in the concatenation list).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AlignmentIndex")]
        [Validation(Required=false)]
        public int? AlignmentIndex { get; set; }

        /// <summary>
        /// <para><b>If there are no special requirements, please leave this blank.</b></para>
        /// <para>Chain authorization configuration. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Using Chain Authorization to Access Other Entity Resources</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>Notification configuration. For details, click Notification. The format of asynchronous notification messages can be found in <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous Notification Message Format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The name of the project. For how to obtain it, see <a href="https://help.aliyun.com/document_detail/478153.html">Creating a Project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>A list of media files. If the list contains more than one element, it indicates that the Concat (concatenation) function is enabled. The Concat order follows the sequence of the input video file URIs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string SourcesShrink { get; set; }

        /// <summary>
        /// <para>Custom tags used for searching and filtering asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>List of media processing tasks, supporting multiple task configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public string TargetsShrink { get; set; }

        /// <summary>
        /// <para>User-defined information that will be returned in asynchronous message notifications, used for convenient association and processing within your system. The maximum length is 2048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;testuid&quot;,&quot;Name&quot;: &quot;test-user&quot;,&quot;Avatar&quot;: &quot;<a href="http://test.com/testuid%22%7D">http://test.com/testuid&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
