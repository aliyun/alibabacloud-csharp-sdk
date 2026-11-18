// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayWebsocketEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewayWebsocketEventsResponseBodyData Data { get; set; }
        public class ListGatewayWebsocketEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data basis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>observed</para>
            /// </summary>
            [NameInMap("basis")]
            [Validation(Required=false)]
            public string Basis { get; set; }

            /// <summary>
            /// <para>Indicates whether there is a next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The observability events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Items { get; set; }

            /// <summary>
            /// <para>The actual number of entries per page used for the current request. The default value is 50 and the maximum value is 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The encrypted cursor returned when there is a next page. This parameter is empty for the last page. The cursor is valid for 10 minutes and is bound to the user, gateway, time range, and filters. You can adjust maxResults for subsequent pages. SLS snapshot isolation is not guaranteed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opaque-token-from-previous-page</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified gateway does not exist.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0A6A1A0-8793-4C10-AB1A-2C03E770A912</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
