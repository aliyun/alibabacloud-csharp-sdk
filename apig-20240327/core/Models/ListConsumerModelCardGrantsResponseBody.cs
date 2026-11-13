// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListConsumerModelCardGrantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned if the request is successful. A specific business error code is returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned by the consumer operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerModelCardGrantsResponseBodyData Data { get; set; }
        public class ListConsumerModelCardGrantsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The projection state of the model entitlement in the gateway domain.</para>
            /// </summary>
            [NameInMap("entitlementState")]
            [Validation(Required=false)]
            public ListConsumerModelCardGrantsResponseBodyDataEntitlementState EntitlementState { get; set; }
            public class ListConsumerModelCardGrantsResponseBodyDataEntitlementState : TeaModel {
                /// <summary>
                /// <para>The applied revision number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("appliedRevision")]
                [Validation(Required=false)]
                public long? AppliedRevision { get; set; }

                /// <summary>
                /// <para>The desired revision number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("desiredRevision")]
                [Validation(Required=false)]
                public long? DesiredRevision { get; set; }

                /// <summary>
                /// <para>The error message returned when the projection fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Configuration delivery failed</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The projection status. Valid values: Pending, Applying, Committed, and Failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Committed</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The paginated list of model entitlements.</para>
            /// </summary>
            [NameInMap("grants")]
            [Validation(Required=false)]
            public ListConsumerModelCardGrantsResponseBodyDataGrants Grants { get; set; }
            public class ListConsumerModelCardGrantsResponseBodyDataGrants : TeaModel {
                /// <summary>
                /// <para>The list of model entitlement facts.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<ListConsumerModelCardGrantsResponseBodyDataGrantsItems> Items { get; set; }
                public class ListConsumerModelCardGrantsResponseBodyDataGrantsItems : TeaModel {
                    /// <summary>
                    /// <para>The timestamp when the authorization was granted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1719386834548</para>
                    /// </summary>
                    [NameInMap("grantTimestamp")]
                    [Validation(Required=false)]
                    public long? GrantTimestamp { get; set; }

                    /// <summary>
                    /// <para>The ID of the Model API to which the authorization belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>api-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("httpApiId")]
                    [Validation(Required=false)]
                    public string HttpApiId { get; set; }

                    /// <summary>
                    /// <para>The ID of the model card.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>msc-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelCardId")]
                    [Validation(Required=false)]
                    public string ModelCardId { get; set; }

                    /// <summary>
                    /// <para>The ID of the authorized principal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cs-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("principalId")]
                    [Validation(Required=false)]
                    public string PrincipalId { get; set; }

                    /// <summary>
                    /// <para>The type of the authorized principal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Consumer</para>
                    /// </summary>
                    [NameInMap("principalType")]
                    [Validation(Required=false)]
                    public string PrincipalType { get; set; }

                    /// <summary>
                    /// <para>The target type. Valid values: MODEL and MODEL_GROUP. If omitted, the value defaults to MODEL. For MODEL_GROUP rows, the modelCardId carries the group ID, and direct entitlements are not expanded or forged.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MODEL</para>
                    /// </summary>
                    [NameInMap("targetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// <para>The page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                /// <summary>
                /// <para>The number of entries per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("pageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("totalSize")]
                [Validation(Required=false)]
                public int? TotalSize { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message that describes the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by the system to trace the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
