// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAnnotationMissionSessionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SaveAnnotationMissionSessionListResponseBodyData Data { get; set; }
        public class SaveAnnotationMissionSessionListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message returned for the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>执行失败：查找元素或操作超时,outTaskId:trademark_regnew_public_cn-zz4310rp1lb,flowId:null,nodeUUID:541b6c71-8cce-4ab0-af84-713ca9741821</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The list of messages.</para>
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
                /// <para>The content of the script for the approval requests</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("AnnotationMissionSessionListJsonString")]
                [Validation(Required=false)]
                public string AnnotationMissionSessionListJsonString { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the operation was successful.</para>
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
        /// <para>The returned message. If the request is successful, success is returned. If the request fails, an error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>执行失败：查找元素或操作超时,outTaskId:trademark_regnew_public_cn-zz4310rp1lb,flowId:null,nodeUUID:541b6c71-8cce-4ab0-af84-713ca9741821</para>
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
        /// <para>Indicates whether the call was successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
