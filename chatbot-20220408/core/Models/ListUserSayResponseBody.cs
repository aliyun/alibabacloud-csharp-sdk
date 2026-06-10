// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListUserSayResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fs1fg4512v43572v23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matching entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of user says.</para>
        /// </summary>
        [NameInMap("UserSays")]
        [Validation(Required=false)]
        public List<ListUserSayResponseBodyUserSays> UserSays { get; set; }
        public class ListUserSayResponseBodyUserSays : TeaModel {
            /// <summary>
            /// <para>The content of the user say.</para>
            /// 
            /// <b>Example:</b>
            /// <para>您做核酸了嘛</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The time when the user say was created. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235564564</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <para>The time when the user say was last modified. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>A list of associated slots.</para>
            /// </summary>
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<ListUserSayResponseBodyUserSaysSlotInfos> SlotInfos { get; set; }
            public class ListUserSayResponseBodyUserSaysSlotInfos : TeaModel {
                /// <summary>
                /// <para>The zero-based end index of the slot in the user say. This value is exclusive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EndIndex")]
                [Validation(Required=false)]
                public int? EndIndex { get; set; }

                /// <summary>
                /// <para>The ID of the intent slot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3456sdfg3tu</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <para>The zero-based start index of the slot in the user say. This value is inclusive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("StartIndex")]
                [Validation(Required=false)]
                public int? StartIndex { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user say.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3453452138</para>
            /// </summary>
            [NameInMap("UserSayId")]
            [Validation(Required=false)]
            public long? UserSayId { get; set; }

        }

    }

}
