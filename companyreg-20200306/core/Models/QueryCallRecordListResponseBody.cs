// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class QueryCallRecordListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCallRecordListResponseBodyData> Data { get; set; }
        public class QueryCallRecordListResponseBodyData : TeaModel {
            [NameInMap("ContactDisposition")]
            [Validation(Required=false)]
            public string ContactDisposition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40140</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UPLOADED/SCRIPT/74974566-2b69-4389-9bf9-5d7b432f06ad/fa92ce53-6b5f-4b3d-807c-a46417c08f66_a4cc3a16-e365-42cb-87d8-7776f8b110a1.json</para>
            /// </summary>
            [NameInMap("SignatureUrl")]
            [Validation(Required=false)]
            public string SignatureUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-07T02:08:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NoPermission</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6A603AA0-73BA-52B3-AC7D-0F846ECF7A9D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
