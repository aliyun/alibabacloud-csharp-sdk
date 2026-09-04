// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListOperatingObjectFavoritesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The graph name. Call listGraphs to retrieve available graphs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>Indicates whether more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The MCP card list.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListOperatingObjectFavoritesResponseBodyItems> Items { get; set; }
        public class ListOperatingObjectFavoritesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The to-do card type description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The follow time. The value is a Unix timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1787822400</para>
            /// </summary>
            [NameInMap("followedAt")]
            [Validation(Required=false)]
            public long? FollowedAt { get; set; }

            /// <summary>
            /// <para>The graph name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("graphName")]
            [Validation(Required=false)]
            public string GraphName { get; set; }

            /// <summary>
            /// <para>The ID of the recommended item. The value can be a <b>feedId</b> or a micro-application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2676</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The object name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>469ac312-403c-41fb-aae3-de5260e30906</para>
            /// </summary>
            [NameInMap("objectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

            /// <summary>
            /// <para>The bound object type, such as customer or project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ2IjoxLCJpZCI6OTAyfQ.c2lnbmF0dXJlX2V4YW1wbGU</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The object type, such as customer. This parameter has a value when type is set to mention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>contract</para>
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The digital employee name (operating object name).</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer_assistant</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
