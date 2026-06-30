// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateSyncQualityCheckDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The Result code. A value of 200 indicates Succeeded. Any other value indicates failed. The API caller can determine the cause of failure based on this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The complete response Content.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateSyncQualityCheckDataResponseBodyData Data { get; set; }
        public class UpdateSyncQualityCheckDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123D8C-5BD9-42A7-B527-1235F8**</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The UUID of the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20210101-1212121***</para>
            /// </summary>
            [NameInMap("Tid")]
            [Validation(Required=false)]
            public string Tid { get; set; }

        }

        /// <summary>
        /// <para>Details of the error when an error occurs; &quot;successful&quot; when the operation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is the UUID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76DB5D8C-5BD9-42A7-B527-5AF3A5F8***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the Request succeeded. The API caller can use this field to determine whether the Request succeeded: true indicates success; false or null indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
