// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetScheduledBackupConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScheduledBackupConfigResponseBodyData Data { get; set; }
        public class GetScheduledBackupConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the backup configuration is enabled. Valid values: <b>1</b> (enabled) and <b>0</b> (disabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public long? Enabled { get; set; }

            /// <summary>
            /// <para>The task parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;schedule&quot;:&quot;0 10 * * 1,2&quot;,&quot;instance_id&quot;:&quot;hgprecn-cn-lbj3dfgog004&quot;,&quot;week&quot;:&quot;1,2&quot;,&quot;hour&quot;:10,&quot;data_keep_quantity&quot;:3,&quot;type&quot;:&quot;periodical&quot;,&quot;enabled&quot;:true}</para>
            /// </summary>
            [NameInMap("TaskParameter")]
            [Validation(Required=false)]
            public string TaskParameter { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>623EF0B6-A6C1-5764-82CC-0BC176654CB9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
