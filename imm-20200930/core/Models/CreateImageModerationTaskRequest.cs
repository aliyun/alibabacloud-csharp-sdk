// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateImageModerationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The authorization chain settings. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The time interval between two consecutive frames in a GIF or long image. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The maximum number of frames that can be captured in a GIF or long image. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxFrames")]
        [Validation(Required=false)]
        public long? MaxFrames { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The scenarios in which you want to apply the image moderation task.</para>
        /// </summary>
        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public List<string> Scenes { get; set; }

        /// <summary>
        /// <para>The URI of the Object Storage Service (OSS) bucket in which you store the image.</para>
        /// <para>Specify the value in the <c>oss://&lt;Bucket&gt;/&lt;Object&gt;</c> format. <c>&lt;Bucket&gt;</c> specifies the name of the OSS bucket that resides in the same region as the current project. <c>&lt;Object&gt;</c> specifies the complete path to the image file that has an extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The custom tags. You can search for or filter asynchronous tasks by custom tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;: &quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The user data, which is returned in an asynchronous notification and facilitates notification management. The maximum length of the user data is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
