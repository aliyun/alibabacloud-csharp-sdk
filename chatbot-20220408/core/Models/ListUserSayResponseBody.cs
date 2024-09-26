// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListUserSayResponseBody : TeaModel {
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
        /// <para>fs1fg4512v43572v23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("UserSays")]
        [Validation(Required=false)]
        public List<ListUserSayResponseBodyUserSays> UserSays { get; set; }
        public class ListUserSayResponseBodyUserSays : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>235564564</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<ListUserSayResponseBodyUserSaysSlotInfos> SlotInfos { get; set; }
            public class ListUserSayResponseBodyUserSaysSlotInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EndIndex")]
                [Validation(Required=false)]
                public int? EndIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3456sdfg3tu</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("StartIndex")]
                [Validation(Required=false)]
                public int? StartIndex { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3453452138</para>
            /// </summary>
            [NameInMap("UserSayId")]
            [Validation(Required=false)]
            public long? UserSayId { get; set; }

        }

    }

}
