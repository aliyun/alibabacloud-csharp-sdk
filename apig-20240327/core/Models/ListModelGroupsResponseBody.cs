// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListModelGroupsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListModelGroupsResponseBodyData Data { get; set; }
        public class ListModelGroupsResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListModelGroupsResponseBodyDataItems> Items { get; set; }
            public class ListModelGroupsResponseBodyDataItems : TeaModel {
                [NameInMap("configurationDeployment")]
                [Validation(Required=false)]
                public ListModelGroupsResponseBodyDataItemsConfigurationDeployment ConfigurationDeployment { get; set; }
                public class ListModelGroupsResponseBodyDataItemsConfigurationDeployment : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>op-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("operationId")]
                    [Validation(Required=false)]
                    public string OperationId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("revision")]
                    [Validation(Required=false)]
                    public long? Revision { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Succeeded</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>用于业务接入的模型组。</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("entitlementState")]
                [Validation(Required=false)]
                public ListModelGroupsResponseBodyDataItemsEntitlementState EntitlementState { get; set; }
                public class ListModelGroupsResponseBodyDataItemsEntitlementState : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("appliedRevision")]
                    [Validation(Required=false)]
                    public long? AppliedRevision { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("desiredRevision")]
                    [Validation(Required=false)]
                    public long? DesiredRevision { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>配置下发失败。</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Committed</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-d00000000000000000000</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("modelCardIds")]
                [Validation(Required=false)]
                public List<string> ModelCardIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mg-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelGroupId")]
                [Validation(Required=false)]
                public string ModelGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>beta-model-group</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-11-12T00:00:00Z</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ==</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
