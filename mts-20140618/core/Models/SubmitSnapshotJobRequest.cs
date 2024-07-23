// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitSnapshotJobRequest : TeaModel {
        /// <summary>
        /// <para>The information about the job input. The value must be a JSON object. You must add the Object Storage Service (OSS) bucket that stores the OSS object to be used as the job input as a media bucket in the MPS console. To add an OSS bucket as a media bucket, you can log on to the MPS console, choose Workflows &gt; Media Buckets in the left-side navigation pane, and then click Add Bucket. After the OSS bucket is added as a media bucket, you must perform URL encoding for the OSS object. Example: <c>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;example-location&quot;,&quot;Object&quot;:&quot;example%2Ftest.flv&quot;}</c>. This example indicates the <c>&quot;example-bucket.example-location.aliyuncs.com/example/test.flv&quot;</c> object.</para>
        /// <remarks>
        /// <para>The OSS bucket must reside in the same region as your MPS service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;example-location&quot;,&quot;Object&quot;:&quot;example%2Ftest.flv&quot;}</para>
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
        /// <para>The ID of the MPS queue to which you want to submit the snapshot job. To obtain the ID, you can log on to the <b>MPS console</b> and choose <b>Global Settings</b> &gt; <b>Pipelines</b> in the left-side navigation pane.</para>
        /// <remarks>
        /// <para>Make sure that an available Message Service (MNS) topic is bound to the specified MPS queue. Otherwise, the relevant messages may fail to be sent as expected.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dd3dae411e704030b921e52698e5****</para>
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
        /// <para>The snapshot configurations. For more information, see the &quot;AliyunSnapshotConfig&quot; section of the <a href="https://help.aliyun.com/document_detail/29253.html">Data types</a> topic.</para>
        /// <remarks>
        /// <para>If you set the Interval parameter that is nested under SnapshotConfig, snapshots are captured at the specified intervals. The default value of the Interval parameter is 10, in seconds. If an input video is short but you specify large values for both the Num and Interval parameters, the actual number of snapshots captured may be smaller than the specified number. For example, if you set the Num parameter to 5 and the Interval parameter to 3 for a video of 10 seconds, the number of snapshots captured cannot reach 5.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OutputFile&quot;:{&quot;Bucket&quot;:&quot;example-001&quot;,&quot;Location&quot;:&quot;example-location&quot;,&quot;Object&quot;:&quot;{Count}.jpg&quot;},&quot;Time&quot;:&quot;5&quot;,&quot;Num&quot;:&quot;10&quot;,&quot;Interval&quot;:&quot;20&quot;}</para>
        /// </summary>
        [NameInMap("SnapshotConfig")]
        [Validation(Required=false)]
        public string SnapshotConfig { get; set; }

        /// <summary>
        /// <para>The custom data. The custom data can contain letters, digits, and hyphens (-) and be up to 1,024 bytes in size. The custom data cannot start with a special character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid-001</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
