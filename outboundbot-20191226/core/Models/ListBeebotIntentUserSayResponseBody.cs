// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListBeebotIntentUserSayResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7BBFCDF-59B0-1ADA-BCA3-4B77F642DDFB</para>
        /// </summary>
        [NameInMap("BeebotRequestId")]
        [Validation(Required=false)]
        public string BeebotRequestId { get; set; }

        /// <summary>
        /// <para>The status code of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries displayed per page.</para>
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
        /// <para>0956D5DA-0978-5DC9-94B0-C68527DA7475</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of user utterances.</para>
        /// </summary>
        [NameInMap("UserSays")]
        [Validation(Required=false)]
        public List<ListBeebotIntentUserSayResponseBodyUserSays> UserSays { get; set; }
        public class ListBeebotIntentUserSayResponseBodyUserSays : TeaModel {
            /// <summary>
            /// <para>The content of the utterance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你知道xxxx么？</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The time when the utterance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-21 14:16:05.+0800</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The intent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10717802</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <para>The time when the utterance was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-21 14:16:05.+0800</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The utterance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17448458</para>
            /// </summary>
            [NameInMap("UserSayId")]
            [Validation(Required=false)]
            public string UserSayId { get; set; }

        }

    }

}
