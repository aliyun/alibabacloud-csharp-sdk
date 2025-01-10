// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryRoomStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FAFCD152-4791-5F2F-B0BE-2DC06FD4F05B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryRoomStatusResponseBodyResult Result { get; set; }
        public class QueryRoomStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cf2446fc9d144c85aaee4f9ae20a96e7</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1211</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            [NameInMap("SceneList")]
            [Validation(Required=false)]
            public List<QueryRoomStatusResponseBodyResultSceneList> SceneList { get; set; }
            public class QueryRoomStatusResponseBodyResultSceneList : TeaModel {
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

            }

            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<QueryRoomStatusResponseBodyResultStatusList> StatusList { get; set; }
            public class QueryRoomStatusResponseBodyResultStatusList : TeaModel {
                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

                [NameInMap("StatusValue")]
                [Validation(Required=false)]
                public string StatusValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Thu Jan 09 13:56:51 CST 2025</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
