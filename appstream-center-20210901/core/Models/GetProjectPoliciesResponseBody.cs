// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetProjectPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProjectPoliciesResponseBodyData Data { get; set; }
        public class GetProjectPoliciesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public int? Clipboard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FileTransfer")]
            [Validation(Required=false)]
            public int? FileTransfer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public string FrameRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("KeepAliveDuration")]
            [Validation(Required=false)]
            public int? KeepAliveDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxHours")]
            [Validation(Required=false)]
            public int? MaxHours { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("MaxSessions")]
            [Validation(Required=false)]
            public int? MaxSessions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

            [NameInMap("SessionSpec")]
            [Validation(Required=false)]
            public string SessionSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mix</para>
            /// </summary>
            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TerminalResolutionAdaptation")]
            [Validation(Required=false)]
            public bool? TerminalResolutionAdaptation { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The parameter ProductType is invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
