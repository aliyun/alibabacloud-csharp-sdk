// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetBatchImportTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetBatchImportTaskResponseBodyData Data { get; set; }
        public class GetBatchImportTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>some apis import failed</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("processedCount")]
            [Validation(Required=false)]
            public int? ProcessedCount { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public GetBatchImportTaskResponseBodyDataResult Result { get; set; }
            public class GetBatchImportTaskResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Http</para>
                /// </summary>
                [NameInMap("apiType")]
                [Validation(Required=false)]
                public string ApiType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("dryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                [NameInMap("dryRunResults")]
                [Validation(Required=false)]
                public List<GetBatchImportTaskResponseBodyDataResultDryRunResults> DryRunResults { get; set; }
                public class GetBatchImportTaskResponseBodyDataResultDryRunResults : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>petstore</para>
                    /// </summary>
                    [NameInMap("apiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    [NameInMap("dryRunInfo")]
                    [Validation(Required=false)]
                    public GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfo DryRunInfo { get; set; }
                    public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfo : TeaModel {
                        [NameInMap("errorMessages")]
                        [Validation(Required=false)]
                        public List<string> ErrorMessages { get; set; }

                        [NameInMap("existHttpApiInfo")]
                        [Validation(Required=false)]
                        public GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoExistHttpApiInfo ExistHttpApiInfo { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoExistHttpApiInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>/v1</para>
                            /// </summary>
                            [NameInMap("basePath")]
                            [Validation(Required=false)]
                            public string BasePath { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>gw-xxx</para>
                            /// </summary>
                            [NameInMap("gatewayId")]
                            [Validation(Required=false)]
                            public string GatewayId { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>api-xxx</para>
                            /// </summary>
                            [NameInMap("httpApiId")]
                            [Validation(Required=false)]
                            public string HttpApiId { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>petstore</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Rest</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("versionInfo")]
                            [Validation(Required=false)]
                            public GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoExistHttpApiInfoVersionInfo VersionInfo { get; set; }
                            public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoExistHttpApiInfoVersionInfo : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("enable")]
                                [Validation(Required=false)]
                                public bool? Enable { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>my-version</para>
                                /// </summary>
                                [NameInMap("headerName")]
                                [Validation(Required=false)]
                                public string HeaderName { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>myVersion</para>
                                /// </summary>
                                [NameInMap("queryName")]
                                [Validation(Required=false)]
                                public string QueryName { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>Query</para>
                                /// </summary>
                                [NameInMap("scheme")]
                                [Validation(Required=false)]
                                public string Scheme { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>v1</para>
                                /// </summary>
                                [NameInMap("version")]
                                [Validation(Required=false)]
                                public string Version { get; set; }

                            }

                        }

                        [NameInMap("failureComponents")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureComponents> FailureComponents { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureComponents : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>invalid schema</para>
                            /// </summary>
                            [NameInMap("errorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Pet</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("failureOperations")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureOperations> FailureOperations { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureOperations : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>unsupported operation</para>
                            /// </summary>
                            [NameInMap("errorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>GET</para>
                            /// </summary>
                            [NameInMap("method")]
                            [Validation(Required=false)]
                            public string Method { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>/pets/{petId}</para>
                            /// </summary>
                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                        }

                        [NameInMap("failureRoutes")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureRoutes> FailureRoutes { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureRoutes : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>domain not found</para>
                            /// </summary>
                            [NameInMap("errorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>route-pets</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("successComponents")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessComponents> SuccessComponents { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessComponents : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Create</para>
                            /// </summary>
                            [NameInMap("action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Pet</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("successOperations")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessOperations> SuccessOperations { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessOperations : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Create</para>
                            /// </summary>
                            [NameInMap("action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>GET</para>
                            /// </summary>
                            [NameInMap("method")]
                            [Validation(Required=false)]
                            public string Method { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>getPetById</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>/pets/{petId}</para>
                            /// </summary>
                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                        }

                        [NameInMap("successRoutes")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessRoutes> SuccessRoutes { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessRoutes : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Create</para>
                            /// </summary>
                            [NameInMap("action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>route-pets</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("warningMessages")]
                        [Validation(Required=false)]
                        public List<string> WarningMessages { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>unsupported oas version</para>
                    /// </summary>
                    [NameInMap("error")]
                    [Validation(Required=false)]
                    public string Error { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>petstore.yaml</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                [NameInMap("failureItems")]
                [Validation(Required=false)]
                public List<GetBatchImportTaskResponseBodyDataResultFailureItems> FailureItems { get; set; }
                public class GetBatchImportTaskResponseBodyDataResultFailureItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>api-xxx</para>
                    /// </summary>
                    [NameInMap("apiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>petstore</para>
                    /// </summary>
                    [NameInMap("apiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>invalid oas format</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>petstore.yaml</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("importRequest")]
                [Validation(Required=false)]
                public GetBatchImportTaskResponseBodyDataResultImportRequest ImportRequest { get; set; }
                public class GetBatchImportTaskResponseBodyDataResultImportRequest : TeaModel {
                    [NameInMap("allowUpdate")]
                    [Validation(Required=false)]
                    public bool? AllowUpdate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Http</para>
                    /// </summary>
                    [NameInMap("apiType")]
                    [Validation(Required=false)]
                    public string ApiType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("dryRun")]
                    [Validation(Required=false)]
                    public bool? DryRun { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>gw-xxx</para>
                    /// </summary>
                    [NameInMap("gatewayId")]
                    [Validation(Required=false)]
                    public string GatewayId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rg-xxx</para>
                    /// </summary>
                    [NameInMap("resourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com/my-bucket/imports/batch.zip">https://oss-cn-hangzhou.aliyuncs.com/my-bucket/imports/batch.zip</a></para>
                    /// </summary>
                    [NameInMap("specFileUrl")]
                    [Validation(Required=false)]
                    public string SpecFileUrl { get; set; }

                    [NameInMap("specOssConfig")]
                    [Validation(Required=false)]
                    public GetBatchImportTaskResponseBodyDataResultImportRequestSpecOssConfig SpecOssConfig { get; set; }
                    public class GetBatchImportTaskResponseBodyDataResultImportRequestSpecOssConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>my-bucket</para>
                        /// </summary>
                        [NameInMap("bucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>imports/batch.zip</para>
                        /// </summary>
                        [NameInMap("objectKey")]
                        [Validation(Required=false)]
                        public string ObjectKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("regionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ExistFirst</para>
                    /// </summary>
                    [NameInMap("strategy")]
                    [Validation(Required=false)]
                    public string Strategy { get; set; }

                    [NameInMap("withGatewayExtension")]
                    [Validation(Required=false)]
                    public bool? WithGatewayExtension { get; set; }

                }

                [NameInMap("successItems")]
                [Validation(Required=false)]
                public List<GetBatchImportTaskResponseBodyDataResultSuccessItems> SuccessItems { get; set; }
                public class GetBatchImportTaskResponseBodyDataResultSuccessItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>api-xxx</para>
                    /// </summary>
                    [NameInMap("apiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>petstore</para>
                    /// </summary>
                    [NameInMap("apiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>invalid oas format</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>petstore.yaml</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>async-task-xxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BatchImport</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>CE534E1D-FCE4-5930-B784-E055EC1AEE6F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
