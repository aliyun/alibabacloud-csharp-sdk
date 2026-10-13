// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAnnotationMissionSessionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SaveAnnotationMissionSessionListResponseBodyData Data { get; set; }
        public class SaveAnnotationMissionSessionListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message returned by the API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Execution failed: element not found or operation timed out, outTaskId:trademark_regnew_public_cn-zz4310rp1lb, flowId:null, nodeUUID:541b6c71-8cce-4ab0-af84-713ca9741821</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The message list.</para>
            /// </summary>
            [NameInMap("MessageList")]
            [Validation(Required=false)]
            public List<string> MessageList { get; set; }

            /// <summary>
            /// <para>The request result.</para>
            /// </summary>
            [NameInMap("SaveAnnotationMissionSessionListRequest")]
            [Validation(Required=false)]
            public SaveAnnotationMissionSessionListResponseBodyDataSaveAnnotationMissionSessionListRequest SaveAnnotationMissionSessionListRequest { get; set; }
            public class SaveAnnotationMissionSessionListResponseBodyDataSaveAnnotationMissionSessionListRequest : TeaModel {
                /// <summary>
                /// <para>The script content of the approval application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("AnnotationMissionSessionListJsonString")]
                [Validation(Required=false)]
                public string AnnotationMissionSessionListJsonString { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the request is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The additional information. If the request is successful, success is returned. If the request fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Execution failed: element not found or operation timed out, outTaskId:trademark_regnew_public_cn-zz4310rp1lb, flowId:null, nodeUUID:541b6c71-8cce-4ab0-af84-713ca9741821</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76E93048-F90F-57B7-BD46-6097611A706D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
