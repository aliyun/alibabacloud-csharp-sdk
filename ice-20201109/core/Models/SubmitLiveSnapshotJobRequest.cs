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
        /// <item><description>Maximum length: 255.</description></item>
        /// <item><description>HTTP and HTTPS are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/snapshot/callback">http://www.aliyun.com/snapshot/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <list type="bullet">
        /// <item><description>Maximum length: 128.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Screenshot task1</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The snapshot output information.</para>
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
            /// <para>The snapshot output endpoint.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The snapshot storage type. Currently, only oss is supported.</para>
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
        /// <para>The stream input information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public SubmitLiveSnapshotJobRequestStreamInput StreamInput { get; set; }
        public class SubmitLiveSnapshotJobRequestStreamInput : TeaModel {
            /// <summary>
            /// <para>The stream input type. Currently, only rtmp is supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The stream input URL.</para>
            /// <list type="bullet">
            /// <item><description>Maximum length: 255.</description></item>
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
