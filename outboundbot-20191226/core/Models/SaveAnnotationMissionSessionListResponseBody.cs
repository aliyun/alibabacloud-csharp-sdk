// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAnnotationMissionSessionListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SaveAnnotationMissionSessionListResponseBodyData Data { get; set; }
        public class SaveAnnotationMissionSessionListResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageList")]
            [Validation(Required=false)]
            public List<string> MessageList { get; set; }

            [NameInMap("SaveAnnotationMissionSessionListRequest")]
            [Validation(Required=false)]
            public SaveAnnotationMissionSessionListResponseBodyDataSaveAnnotationMissionSessionListRequest SaveAnnotationMissionSessionListRequest { get; set; }
            public class SaveAnnotationMissionSessionListResponseBodyDataSaveAnnotationMissionSessionListRequest : TeaModel {
                [NameInMap("AnnotationMissionSessionListJsonString")]
                [Validation(Required=false)]
                public string AnnotationMissionSessionListJsonString { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>76E93048-F90F-57B7-BD46-6097611A706D</para>
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
        public bool? Success { get; set; }

    }

}
