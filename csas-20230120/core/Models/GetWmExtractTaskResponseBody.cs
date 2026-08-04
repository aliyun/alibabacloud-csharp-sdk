// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetWmExtractTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The task result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWmExtractTaskResponseBodyData Data { get; set; }
        public class GetWmExtractTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 11:22:33</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the file that was provided when the extraction task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-****.pdf</para>
            /// </summary>
            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Running</b>: The task is running.</para>
            /// </description></item>
            /// <item><description><para><b>Success</b>: The task is successful.</para>
            /// </description></item>
            /// <item><description><para><b>Failed</b>: The task failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wmt-9648c22d2eb2cb57bb855dcae7898464********</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The extracted watermark information as a Base64-encoded string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aGVsbG8gc2Fz****</para>
            /// </summary>
            [NameInMap("WmInfoBytesB64")]
            [Validation(Required=false)]
            public string WmInfoBytesB64 { get; set; }

            /// <summary>
            /// <para>The size of the watermark information, which was provided when the extraction task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("WmInfoSize")]
            [Validation(Required=false)]
            public long? WmInfoSize { get; set; }

            /// <summary>
            /// <para>The extracted watermark information in decimal format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123**</para>
            /// </summary>
            [NameInMap("WmInfoUint")]
            [Validation(Required=false)]
            public long? WmInfoUint { get; set; }

            /// <summary>
            /// <para>The watermark type that was provided when the extraction task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PureDocument</para>
            /// </summary>
            [NameInMap("WmType")]
            [Validation(Required=false)]
            public string WmType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
