// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GatewayBlackWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The code that synchronizes with the Success parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GatewayBlackWhiteListResponseBodyData Data { get; set; }
        public class GatewayBlackWhiteListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the instance list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned result set.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GatewayBlackWhiteListResponseBodyDataResult> Result { get; set; }
            public class GatewayBlackWhiteListResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The content of the blacklist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique identifier of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-5017305290e14centbrveca****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-02T02:43:40.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-02T02:43:40.000+0000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the blacklists and whitelists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>549</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether it is a whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsWhite")]
                [Validation(Required=false)]
                public bool? IsWhite { get; set; }

                /// <summary>
                /// <para>The name of the blacklist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The note.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Blocked IP list</para>
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>549</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public long? ResourceId { get; set; }

                /// <summary>
                /// <para>The JSON string of the resource ID list.</para>
                /// <list type="bullet">
                /// <item><description><para>If ResourceType is set to ROUTE, this parameter is a list of route IDs.</para>
                /// </description></item>
                /// <item><description><para>If ResourceType is set to DOMAIN, this parameter is a list of domain name IDs.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[234]</para>
                /// </summary>
                [NameInMap("ResourceIdJsonList")]
                [Validation(Required=false)]
                public string ResourceIdJsonList { get; set; }

                /// <summary>
                /// <para>The resource name description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ResourceIdNameJson")]
                [Validation(Required=false)]
                public string ResourceIdNameJson { get; set; }

                /// <summary>
                /// <para>The effective granularity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GATEWAY: global gateway level.</description></item>
                /// <item><description>DOMAIN: domain name level.</description></item>
                /// <item><description>ROUTE: route level.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GATEWAY</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The status of the blacklists and whitelists. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>on: enabled.</para>
                /// </description></item>
                /// <item><description><para>off: shutdown.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the blacklists and whitelists. The value is fixed to IP blacklists and whitelists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of queried instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The placeholder in the dynamic error message. This parameter is not used and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message. This parameter is not used and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58E06A0A-BD2C-47A0-99C2-B100F353****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
