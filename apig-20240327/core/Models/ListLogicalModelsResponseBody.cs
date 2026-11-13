// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListLogicalModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListLogicalModelsResponseBodyData Data { get; set; }
        public class ListLogicalModelsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of logical models.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListLogicalModelsResponseBodyDataItems> Items { get; set; }
            public class ListLogicalModelsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The list of call paths commonly supported by all primary targets.</para>
                /// </summary>
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<ListLogicalModelsResponseBodyDataItemsAvailablePaths> AvailablePaths { get; set; }
                public class ListLogicalModelsResponseBodyDataItemsAvailablePaths : TeaModel {
                    /// <summary>
                    /// <para>The call path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/chat/completions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The path type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>type-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The call strategy. This field is returned only for Auto. Valid values: balanced, cheap, fast, and quality. This field can be omitted. If omitted, the default strategy is balanced. This field is not returned for Mapping and Weighted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>balanced</para>
                /// </summary>
                [NameInMap("callStrategy")]
                [Validation(Required=false)]
                public string CallStrategy { get; set; }

                /// <summary>
                /// <para>The configuration delivery record. A successful API response only indicates that the request is accepted, not that the configuration has taken effect.</para>
                /// </summary>
                [NameInMap("deployment")]
                [Validation(Required=false)]
                public ListLogicalModelsResponseBodyDataItemsDeployment Deployment { get; set; }
                public class ListLogicalModelsResponseBodyDataItemsDeployment : TeaModel {
                    /// <summary>
                    /// <para>The ID of the current configuration delivery operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>op-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("operationId")]
                    [Validation(Required=false)]
                    public string OperationId { get; set; }

                    /// <summary>
                    /// <para>The object configuration version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("revision")]
                    [Validation(Required=false)]
                    public long? Revision { get; set; }

                    /// <summary>
                    /// <para>The configuration delivery status. Valid values: Pending, Running, Succeeded, PartiallyFailed, and Failed. This status is independent of the API release status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Succeeded</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The ordered fallback targets. A maximum of 5 fallback targets are supported. They are deduplicated by the actual card ID and can be an empty array.</para>
                /// </summary>
                [NameInMap("fallbackTargets")]
                [Validation(Required=false)]
                public List<ListLogicalModelsResponseBodyDataItemsFallbackTargets> FallbackTargets { get; set; }
                public class ListLogicalModelsResponseBodyDataItemsFallbackTargets : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source model card within the same instance.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>msc-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("modelCardId")]
                    [Validation(Required=false)]
                    public string ModelCardId { get; set; }

                }

                /// <summary>
                /// <para>The intersection of the Boolean capabilities of all primary targets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;nativeStreaming&quot;:true}</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <para>The ID of the gateway instance to which the logical model belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxxxxxxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The logical model ID. The ID starts with vm-.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vm-xxxxxxxx</para>
                /// </summary>
                [NameInMap("logicalModelId")]
                [Validation(Required=false)]
                public string LogicalModelId { get; set; }

                /// <summary>
                /// <para>The aggregated information about the capabilities of the primary targets.</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public ListLogicalModelsResponseBodyDataItemsMeta Meta { get; set; }
                public class ListLogicalModelsResponseBodyDataItemsMeta : TeaModel {
                    /// <summary>
                    /// <para>The minimum input token limit when all primary targets declare this limit. This field is not returned if any target\&quot;s limit is unknown.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>128000</para>
                    /// </summary>
                    [NameInMap("maxInputTokens")]
                    [Validation(Required=false)]
                    public long? MaxInputTokens { get; set; }

                    /// <summary>
                    /// <para>The minimum output token limit when all primary targets declare this limit. This field is not returned if any target\&quot;s limit is unknown.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16384</para>
                    /// </summary>
                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public long? MaxOutputTokens { get; set; }

                    /// <summary>
                    /// <para>The minimum total token limit when all primary targets declare this limit. This field is not returned if any target\&quot;s limit is unknown.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16384</para>
                    /// </summary>
                    [NameInMap("maxTokens")]
                    [Validation(Required=false)]
                    public long? MaxTokens { get; set; }

                    /// <summary>
                    /// <para>The input modalities commonly supported by all primary targets.</para>
                    /// </summary>
                    [NameInMap("supportedInputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedInputModalities { get; set; }

                    /// <summary>
                    /// <para>The output modalities commonly supported by all primary targets.</para>
                    /// </summary>
                    [NameInMap("supportedOutputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedOutputModalities { get; set; }

                }

                /// <summary>
                /// <para>The client logical call name. It supports up to 256 bytes in UTF-8, must not contain spaces or slashes, and must not start with auto.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chat-entry</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether activation is required. This field is returned only for Auto. If the AI Credits Router commodity is not activated, the value is true. If it is activated, the value is false. This field is omitted if the read operation fails or the status is unknown. This field is omitted for Mapping and Weighted.</para>
                /// </summary>
                [NameInMap("requiresActivation")]
                [Validation(Required=false)]
                public bool? RequiresActivation { get; set; }

                /// <summary>
                /// <para>The response model type. If Actual is specified, the public name of the actual model is returned. If Logical is specified, the entry name of the logical model is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Logical</para>
                /// </summary>
                [NameInMap("responseModel")]
                [Validation(Required=false)]
                public string ResponseModel { get; set; }

                /// <summary>
                /// <para>The object version number. The initial value is 1 upon creation and increments with each successful update.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("revision")]
                [Validation(Required=false)]
                public long? Revision { get; set; }

                /// <summary>
                /// <para>The routing policy. Valid values: Mapping, Weighted, and Auto. If Auto is specified, targets must be an empty array and slots is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mapping</para>
                /// </summary>
                [NameInMap("routingPolicy")]
                [Validation(Required=false)]
                public string RoutingPolicy { get; set; }

                /// <summary>
                /// <para>The slots. This field is returned only for Auto. Each of the simple, standard, and complex slots contains 1 to 3 source cards. The three slots are globally deduplicated by modelCardId. This field is omitted for Mapping and Weighted.</para>
                /// </summary>
                [NameInMap("slots")]
                [Validation(Required=false)]
                public ListLogicalModelsResponseBodyDataItemsSlots Slots { get; set; }
                public class ListLogicalModelsResponseBodyDataItemsSlots : TeaModel {
                    /// <summary>
                    /// <para>The complex slot, which contains 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("complex")]
                    [Validation(Required=false)]
                    public List<ListLogicalModelsResponseBodyDataItemsSlotsComplex> Complex { get; set; }
                    public class ListLogicalModelsResponseBodyDataItemsSlotsComplex : TeaModel {
                        /// <summary>
                        /// <para>The ID of the actual source model card within the same instance. The ID starts with msc-. VM or service overrides are not supported.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>msc-xxxxxxxx</para>
                        /// </summary>
                        [NameInMap("modelCardId")]
                        [Validation(Required=false)]
                        public string ModelCardId { get; set; }

                    }

                    /// <summary>
                    /// <para>The simple slot, which contains 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("simple")]
                    [Validation(Required=false)]
                    public List<ListLogicalModelsResponseBodyDataItemsSlotsSimple> Simple { get; set; }
                    public class ListLogicalModelsResponseBodyDataItemsSlotsSimple : TeaModel {
                        /// <summary>
                        /// <para>The ID of the actual source model card within the same instance. The ID starts with msc-. VM or service overrides are not supported.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>msc-xxxxxxxx</para>
                        /// </summary>
                        [NameInMap("modelCardId")]
                        [Validation(Required=false)]
                        public string ModelCardId { get; set; }

                    }

                    /// <summary>
                    /// <para>The standard slot, which contains 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("standard")]
                    [Validation(Required=false)]
                    public List<ListLogicalModelsResponseBodyDataItemsSlotsStandard> Standard { get; set; }
                    public class ListLogicalModelsResponseBodyDataItemsSlotsStandard : TeaModel {
                        /// <summary>
                        /// <para>The ID of the actual source model card within the same instance. The ID starts with msc-. VM or service overrides are not supported.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>msc-xxxxxxxx</para>
                        /// </summary>
                        [NameInMap("modelCardId")]
                        [Validation(Required=false)]
                        public string ModelCardId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The primary targets. For Mapping, exactly one target is allowed. For Weighted, the sum of original relative weights must be greater than 0. For Auto, this must be an empty array.</para>
                /// </summary>
                [NameInMap("targets")]
                [Validation(Required=false)]
                public List<ListLogicalModelsResponseBodyDataItemsTargets> Targets { get; set; }
                public class ListLogicalModelsResponseBodyDataItemsTargets : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source model card within the same instance. The ID starts with msc-. VM or service overrides are not supported.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>msc-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("modelCardId")]
                    [Validation(Required=false)]
                    public string ModelCardId { get; set; }

                    /// <summary>
                    /// <para>The weight. It is an integer from 0 to 10000 and is saved as the original value. A value of 0 is allowed for Mapping.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                /// <summary>
                /// <para>The last modification time in ISO 8601 (RFC 3339) format in the UTC time zone, such as 2026-05-15T10:00:00Z.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-15T10:00:00Z</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The cursor token for querying the next page. This field is not returned if no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>next-token-xxxxxxxx</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
