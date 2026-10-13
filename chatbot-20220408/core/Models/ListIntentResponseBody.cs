// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListIntentResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of intents.</para>
        /// </summary>
        [NameInMap("Intents")]
        [Validation(Required=false)]
        public List<ListIntentResponseBodyIntents> Intents { get; set; }
        public class ListIntentResponseBodyIntents : TeaModel {
            /// <summary>
            /// <para>The alias of the intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CheckWeatherIntent</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The creation time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123231</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The intent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234234234234</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <para>The intent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CheckWeatherIntent</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            /// <summary>
            /// <para>The modification time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the user who last modified the intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123231</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public string ModifyUserId { get; set; }

            /// <summary>
            /// <para>The name of the user who last modified the intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <para>The slot information associated with the intent.</para>
            /// </summary>
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<ListIntentResponseBodyIntentsSlotInfos> SlotInfos { get; set; }
            public class ListIntentResponseBodyIntentsSlotInfos : TeaModel {
                /// <summary>
                /// <para>Indicates whether the slot is an array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                /// <summary>
                /// <para>Indicates whether the slot is sensitive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public bool? Encrypt { get; set; }

                /// <summary>
                /// <para>Indicates whether the slot is collected interactively.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Interactive")]
                [Validation(Required=false)]
                public bool? Interactive { get; set; }

                /// <summary>
                /// <para>The slot name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Weather</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The slot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12134223</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <para>The slot value (entity name).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Weather</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
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
        /// <para>23dsfa34r2s2s2sd12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
