// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveRecordJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the recording job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live stream record 1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/imsnotify">https://example.com/imsnotify</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The storage address of the recording.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordOutput")]
        [Validation(Required=false)]
        public SubmitLiveRecordJobRequestRecordOutput RecordOutput { get; set; }
        public class SubmitLiveRecordJobRequestRecordOutput : TeaModel {
            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imsbucket1</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The endpoint of the storage service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The type of the storage address.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The URL of the live stream.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public SubmitLiveRecordJobRequestStreamInput StreamInput { get; set; }
        public class SubmitLiveRecordJobRequestStreamInput : TeaModel {
            /// <summary>
            /// <para>The type of the live stream URL. The value can only be rtmp.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://example.com/live/stream1</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The ID of the recording template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
