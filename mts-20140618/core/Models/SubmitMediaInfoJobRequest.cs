// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitMediaInfoJobRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the asynchronous mode for the job. We recommend that you set this parameter to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the asynchronous mode.</description></item>
        /// <item><description><b>false</b>: does not enable the asynchronous mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The information about the input media file. The value is a JSON string. You must perform the following operations to add the OSS bucket in which the input media file is stored as a media bucket: Log on to the <b>MPS console</b>, choose <b>Workflows</b> &gt; <b>Media Buckets</b> in the left-side navigation pane, and then click <b>Add Bucket</b>. After you add the OSS bucket as a media bucket, you must perform URL encoding for the OSS object. For example, <c>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;example-location&quot;,&quot;Object&quot;:&quot;example%2Fexample.flv&quot;}</c> indicates the <c>example-bucket.example-location.aliyuncs.com/example/example.flv</c> file.</para>
        /// <remarks>
        /// <para>The OSS bucket must reside in the same region as your MPS service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;example-location&quot;,&quot;Object&quot;:&quot;example%2Fexample.flv&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the MPS queue to which the job was submitted. For more information, see <a href="https://help.aliyun.com/document_detail/29197.html">Terms</a>.</para>
        /// <list type="bullet">
        /// <item><description>To view the ID of the MPS queue, log on to the <a href="https://mps.console.aliyun.com/overview">MPS console</a> and choose <b>Global Settings</b> &gt; <b>MPS queue and Callback</b> in the left-side navigation pane. On the MPS queue and Callback page, you can view the ID of an MPS queue or create an MPS queue.</description></item>
        /// <item><description>If you want to receive asynchronous message notifications, associate an MNS queue or topic with the MPS queue. For more information, see <a href="https://www.alibabacloud.com/help/en/mps/receive-message-notifications/?spm=a2c63.p38356.0.0.b48576d2jxNSca">Receive message notifications</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e432bbf5b665e2a15****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The custom data. The custom data can contain letters, digits, and hyphens (-), and can be up to 1,024 bytes in length. The custom data cannot start with a special character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid-001</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
