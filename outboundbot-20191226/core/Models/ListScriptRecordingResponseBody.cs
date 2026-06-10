// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptRecordingResponseBody : TeaModel {
        /// <summary>
        /// <para>API status</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Recording list</para>
        /// </summary>
        [NameInMap("ScriptRecordings")]
        [Validation(Required=false)]
        public List<ListScriptRecordingResponseBodyScriptRecordings> ScriptRecordings { get; set; }
        public class ListScriptRecordingResponseBodyScriptRecordings : TeaModel {
            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1744963749000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1654601332000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Recording upload time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1654601332000</para>
            /// </summary>
            [NameInMap("GmtUpload")]
            [Validation(Required=false)]
            public long? GmtUpload { get; set; }

            /// <summary>
            /// <para>The ID of the recording file within the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>000003</para>
            /// </summary>
            [NameInMap("InnerId")]
            [Validation(Required=false)]
            public string InnerId { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ff0fb845-9f90-46d3-9716-d36b8a1e753a</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Recording content</para>
            /// 
            /// <b>Example:</b>
            /// <para>您好！</para>
            /// </summary>
            [NameInMap("RecordingContent")]
            [Validation(Required=false)]
            public string RecordingContent { get; set; }

            /// <summary>
            /// <para>Recording duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>Recording name</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello.wav</para>
            /// </summary>
            [NameInMap("RecordingName")]
            [Validation(Required=false)]
            public string RecordingName { get; set; }

            /// <summary>
            /// <para>The unique ID of the recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0a77386e-6402-8d23-4adf-6ec13b3f404d</para>
            /// </summary>
            [NameInMap("RefId")]
            [Validation(Required=false)]
            public string RefId { get; set; }

            /// <summary>
            /// <para>Scenario ID of the recording</para>
            /// 
            /// <b>Example:</b>
            /// <para>6019b692-fd9e-4adb-8877-cef6a297b234</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Recording status</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// <para>State extension</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("StateExtend")]
            [Validation(Required=false)]
            public string StateExtend { get; set; }

            /// <summary>
            /// <para>Storage UUID</para>
            /// 
            /// <b>Example:</b>
            /// <para>393674ed-3b5d-db44-0fda-615d05210178</para>
            /// </summary>
            [NameInMap("StorageUuid")]
            [Validation(Required=false)]
            public string StorageUuid { get; set; }

            /// <summary>
            /// <para>Unique ID of the recording</para>
            /// 
            /// <b>Example:</b>
            /// <para>0a77386e-6402-8d23-4adf-6ec13b3f404d</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>Success</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
