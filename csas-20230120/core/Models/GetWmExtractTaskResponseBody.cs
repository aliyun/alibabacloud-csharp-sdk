// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetWmExtractTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWmExtractTaskResponseBodyData Data { get; set; }
        public class GetWmExtractTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01 11:22:33</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-****.pdf</para>
            /// </summary>
            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wmt-9648c22d2eb2cb57bb855dcae7898464********</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aGVsbG8gc2Fz****</para>
            /// </summary>
            [NameInMap("WmInfoBytesB64")]
            [Validation(Required=false)]
            public string WmInfoBytesB64 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("WmInfoSize")]
            [Validation(Required=false)]
            public long? WmInfoSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123**</para>
            /// </summary>
            [NameInMap("WmInfoUint")]
            [Validation(Required=false)]
            public long? WmInfoUint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PureDocument</para>
            /// </summary>
            [NameInMap("WmType")]
            [Validation(Required=false)]
            public string WmType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
