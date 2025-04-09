// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptRecordingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScriptRecordings")]
        [Validation(Required=false)]
        public List<ListScriptRecordingResponseBodyScriptRecordings> ScriptRecordings { get; set; }
        public class ListScriptRecordingResponseBodyScriptRecordings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-11T07:51:49.000+0000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1654601332000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1654601332000</para>
            /// </summary>
            [NameInMap("GmtUpload")]
            [Validation(Required=false)]
            public long? GmtUpload { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InnerId")]
            [Validation(Required=false)]
            public string InnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ff0fb845-9f90-46d3-9716-d36b8a1e753a</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RecordingContent")]
            [Validation(Required=false)]
            public string RecordingContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hello.wav</para>
            /// </summary>
            [NameInMap("RecordingName")]
            [Validation(Required=false)]
            public string RecordingName { get; set; }

            [NameInMap("RefId")]
            [Validation(Required=false)]
            public string RefId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6019b692-fd9e-4adb-8877-cef6a297b234</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            [NameInMap("StateExtend")]
            [Validation(Required=false)]
            public string StateExtend { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>393674ed-3b5d-db44-0fda-615d05210178</para>
            /// </summary>
            [NameInMap("StorageUuid")]
            [Validation(Required=false)]
            public string StorageUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0a77386e-6402-8d23-4adf-6ec13b3f404d</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
