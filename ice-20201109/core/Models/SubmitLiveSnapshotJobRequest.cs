// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveSnapshotJobRequest : TeaModel {
        /// <summary>
        /// <para>The snapshot callback URL.</para>
        /// <list type="bullet">
        /// <item><description>It cannot exceed 255 characters in length.</description></item>
        /// <item><description>Both HTTP and HTTPS URLs are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/snapshot/callback">http://www.aliyun.com/snapshot/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// <list type="bullet">
        /// <item><description>It cannot exceed 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The information about the output snapshot.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SnapshotOutput")]
        [Validation(Required=false)]
        public SubmitLiveSnapshotJobRequestSnapshotOutput SnapshotOutput { get; set; }
        public class SubmitLiveSnapshotJobRequestSnapshotOutput : TeaModel {
            /// <summary>
            /// <para>The bucket of the snapshot output endpoint.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testbucket</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The output endpoint of the snapshot.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The storage type of the snapshot. The value can only be oss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The information about the input stream.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public SubmitLiveSnapshotJobRequestStreamInput StreamInput { get; set; }
        public class SubmitLiveSnapshotJobRequestStreamInput : TeaModel {
            /// <summary>
            /// <para>The type of the input stream. The value can only be rtmp.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the input stream.</para>
            /// <list type="bullet">
            /// <item><description>It cannot exceed 255 characters in length.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
