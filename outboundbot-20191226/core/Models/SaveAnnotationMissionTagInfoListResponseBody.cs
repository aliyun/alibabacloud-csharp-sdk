// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAnnotationMissionTagInfoListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the API call.</para>
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
        public SaveAnnotationMissionTagInfoListResponseBodyData Data { get; set; }
        public class SaveAnnotationMissionTagInfoListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of successful operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecCount")]
            [Validation(Required=false)]
            public int? ExecCount { get; set; }

            /// <summary>
            /// <para>The message returned for the API call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>执行失败：查找元素或操作超时，outTaskId：trademark_regnew_public_cn-uax33hol2uu，flowId：null，nodeUUID：541b6c71-8cce-4ab0-af84-713ca9741821</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

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
        /// <para>The message returned for the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>执行失败：查找元素或操作超时，outTaskId：trademark_regnew_public_cn-uax33hol2uu,flowId：null，nodeUUID：541b6c71-8cce-4ab0-af84-713ca9741821</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B356EDC-F69A-53B0-B4AF-2AC42200684E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates that the call was successful. A value of false indicates that the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
