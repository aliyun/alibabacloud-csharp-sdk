// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveSnapshotJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The snapshot callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/snapshot/callback">http://www.aliyun.com/snapshot/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The time when the file was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T22:22:22Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The time when the file was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T22:22:22Z</para>
        /// </summary>
        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// <para>The naming format of the snapshot captured in overwrite mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}.jpg</para>
        /// </summary>
        [NameInMap("OverwriteFormat")]
        [Validation(Required=false)]
        public string OverwriteFormat { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The naming format of the snapshot captured in time series mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot/{JobId}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("SequenceFormat")]
        [Validation(Required=false)]
        public string SequenceFormat { get; set; }

        /// <summary>
        /// <para>The output information.</para>
        /// </summary>
        [NameInMap("SnapshotOutput")]
        [Validation(Required=false)]
        public GetLiveSnapshotJobResponseBodySnapshotOutput SnapshotOutput { get; set; }
        public class GetLiveSnapshotJobResponseBodySnapshotOutput : TeaModel {
            /// <summary>
            /// <para>The bucket of the output endpoint. If the storage type is set to oss, the OSS bucket is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testbucket</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The output endpoint. If the storage type is set to oss, the Object Storage Service (OSS) domain name is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The storage type. The value can only be oss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The state of the job.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>init: The job is not started.</description></item>
        /// <item><description>paused: The job is paused.</description></item>
        /// <item><description>started: The job is in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>started</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The input information.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public GetLiveSnapshotJobResponseBodyStreamInput StreamInput { get; set; }
        public class GetLiveSnapshotJobResponseBodyStreamInput : TeaModel {
            /// <summary>
            /// <para>The type of the input stream. The value can only be rtmp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the input stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://<a href="http://www.aliyun.com/stream">www.aliyun.com/stream</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287666</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The interval between two adjacent snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TimeInterval")]
        [Validation(Required=false)]
        public int? TimeInterval { get; set; }

    }

}
