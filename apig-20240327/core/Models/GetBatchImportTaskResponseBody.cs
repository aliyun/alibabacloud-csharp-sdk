// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetBatchImportTaskResponseBody : TeaModel {
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
        public GetBatchImportTaskResponseBodyData Data { get; set; }
        public class GetBatchImportTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time is in UTC and follows the RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>some apis import failed</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The number of processed items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("processedCount")]
            [Validation(Required=false)]
            public int? ProcessedCount { get; set; }

            /// <summary>
            /// <para>The task result details.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public GetBatchImportTaskResponseBodyDataResult Result { get; set; }
            public class GetBatchImportTaskResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The API type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Http</para>
                /// </summary>
                [NameInMap("apiType")]
                [Validation(Required=false)]
                public string ApiType { get; set; }

                /// <summary>
                /// <para>Indicates whether the task is in dry run mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("dryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <para>The list of dry run results.</para>
                /// </summary>
                [NameInMap("dryRunResults")]
                [Validation(Required=false)]
                public List<GetBatchImportTaskResponseBodyDataResultDryRunResults> DryRunResults { get; set; }
                public class GetBatchImportTaskResponseBodyDataResultDryRunResults : TeaModel {
                    /// <summary>
                    /// <para>The API name. The value unknown is returned if the name cannot be identified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>petstore</para>
                    /// </summary>
                    [NameInMap("apiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <para>The dry run details, including the operations, routes, components, and error or warning messages planned for creation or update in this file.</para>
                    /// </summary>
                    [NameInMap("dryRunInfo")]
                    [Validation(Required=false)]
                    public GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfo DryRunInfo { get; set; }
                    public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfo : TeaModel {
                        /// <summary>
                        /// <para>The list of dry run error messages.</para>
                        /// </summary>
                        [NameInMap("errorMessages")]
                        [Validation(Required=false)]
                        public List<string> ErrorMessages { get; set; }

                        /// <summary>
                        /// <para>The basic information about the existing HTTP API matched during import.</para>
                        /// </summary>
                        [NameInMap("existHttpApiInfo")]
                        [Validation(Required=false)]
                        public GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoExistHttpApiInfo ExistHttpApiInfo { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoExistHttpApiInfo : TeaModel {
                            /// <summary>
                            /// <para>The base path of the API.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/v1</para>
                            /// </summary>
                            [NameInMap("basePath")]
                            [Validation(Required=false)]
                            public string BasePath { get; set; }

                            /// <summary>
                            /// <para>The gateway instance ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>gw-xxx</para>
                            /// </summary>
                            [NameInMap("gatewayId")]
                            [Validation(Required=false)]
                            public string GatewayId { get; set; }

                            /// <summary>
                            /// <para>The ID of the HTTP API.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>api-xxx</para>
                            /// </summary>
                            [NameInMap("httpApiId")]
                            [Validation(Required=false)]
                            public string HttpApiId { get; set; }

                            /// <summary>
                            /// <para>The name of the API.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>petstore</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The API type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Rest</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The API versioning information.</para>
                            /// </summary>
                            [NameInMap("versionInfo")]
                            [Validation(Required=false)]
                            public GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoExistHttpApiInfoVersionInfo VersionInfo { get; set; }
                            public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoExistHttpApiInfoVersionInfo : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether versioning is enabled.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("enable")]
                                [Validation(Required=false)]
                                public bool? Enable { get; set; }

                                /// <summary>
                                /// <para>The key in the specified header parameter when the header versioning scheme is used.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>my-version</para>
                                /// </summary>
                                [NameInMap("headerName")]
                                [Validation(Required=false)]
                                public string HeaderName { get; set; }

                                /// <summary>
                                /// <para>The key in the specified query parameter when the query versioning scheme is used.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>myVersion</para>
                                /// </summary>
                                [NameInMap("queryName")]
                                [Validation(Required=false)]
                                public string QueryName { get; set; }

                                /// <summary>
                                /// <para>The versioning scheme.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Query</para>
                                /// </summary>
                                [NameInMap("scheme")]
                                [Validation(Required=false)]
                                public string Scheme { get; set; }

                                /// <summary>
                                /// <para>The version number.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>v1</para>
                                /// </summary>
                                [NameInMap("version")]
                                [Validation(Required=false)]
                                public string Version { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The list of data structures that failed the dry run.</para>
                        /// </summary>
                        [NameInMap("failureComponents")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureComponents> FailureComponents { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureComponents : TeaModel {
                            /// <summary>
                            /// <para>The reason why the dry run failed.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>invalid schema</para>
                            /// </summary>
                            [NameInMap("errorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <para>The name of the data structure.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Pet</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The list of REST API operations that failed the dry run.</para>
                        /// </summary>
                        [NameInMap("failureOperations")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureOperations> FailureOperations { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureOperations : TeaModel {
                            /// <summary>
                            /// <para>The reason why the dry run failed.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>unsupported operation</para>
                            /// </summary>
                            [NameInMap("errorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <para>The HTTP method of the REST API operation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>GET</para>
                            /// </summary>
                            [NameInMap("method")]
                            [Validation(Required=false)]
                            public string Method { get; set; }

                            /// <summary>
                            /// <para>The path of the REST API operation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/pets/{petId}</para>
                            /// </summary>
                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                        }

                        /// <summary>
                        /// <para>The list of routes that failed the dry run.</para>
                        /// </summary>
                        [NameInMap("failureRoutes")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureRoutes> FailureRoutes { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoFailureRoutes : TeaModel {
                            /// <summary>
                            /// <para>The reason why the dry run failed.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>domain not found</para>
                            /// </summary>
                            [NameInMap("errorMessage")]
                            [Validation(Required=false)]
                            public string ErrorMessage { get; set; }

                            /// <summary>
                            /// <para>The name of the route.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>route-pets</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The list of data structures that passed the dry run.</para>
                        /// </summary>
                        [NameInMap("successComponents")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessComponents> SuccessComponents { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessComponents : TeaModel {
                            /// <summary>
                            /// <para>The action type to be performed after the dry run.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Create</para>
                            /// </summary>
                            [NameInMap("action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            /// <summary>
                            /// <para>The name of the data structure.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Pet</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The list of REST API operations that passed the dry run.</para>
                        /// </summary>
                        [NameInMap("successOperations")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessOperations> SuccessOperations { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessOperations : TeaModel {
                            /// <summary>
                            /// <para>The action type to be performed after the dry run.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Create</para>
                            /// </summary>
                            [NameInMap("action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            /// <summary>
                            /// <para>The HTTP method of the REST API operation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>GET</para>
                            /// </summary>
                            [NameInMap("method")]
                            [Validation(Required=false)]
                            public string Method { get; set; }

                            /// <summary>
                            /// <para>The name of the REST API operation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>getPetById</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The path of the REST API operation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/pets/{petId}</para>
                            /// </summary>
                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                        }

                        /// <summary>
                        /// <para>The list of routes that passed the dry run.</para>
                        /// </summary>
                        [NameInMap("successRoutes")]
                        [Validation(Required=false)]
                        public List<GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessRoutes> SuccessRoutes { get; set; }
                        public class GetBatchImportTaskResponseBodyDataResultDryRunResultsDryRunInfoSuccessRoutes : TeaModel {
                            /// <summary>
                            /// <para>The action type to be performed after the dry run.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Create</para>
                            /// </summary>
                            [NameInMap("action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            /// <summary>
                            /// <para>The name of the route.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>route-pets</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The list of dry run warning messages.</para>
                        /// </summary>
                        [NameInMap("warningMessages")]
                        [Validation(Required=false)]
                        public List<string> WarningMessages { get; set; }

                    }

                    /// <summary>
                    /// <para>The dry run error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>unsupported oas version</para>
                    /// </summary>
                    [NameInMap("error")]
                    [Validation(Required=false)]
                    public string Error { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>petstore.yaml</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// <para>The list of APIs that failed to be processed.</para>
                /// </summary>
                [NameInMap("failureItems")]
                [Validation(Required=false)]
                public List<GetBatchImportTaskResponseBodyDataResultFailureItems> FailureItems { get; set; }
                public class GetBatchImportTaskResponseBodyDataResultFailureItems : TeaModel {
                    /// <summary>
                    /// <para>The ID of the API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>api-xxx</para>
                    /// </summary>
                    [NameInMap("apiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <para>The API name. The value unknown is returned if the name cannot be identified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>petstore</para>
                    /// </summary>
                    [NameInMap("apiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>invalid oas format</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>petstore.yaml</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// <para>The gateway instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The formal import request body. This field is returned only for dry run tasks and can be resubmitted as the request body of BatchImportHttpApis. The dryRun parameter is fixed to false. Temporary specFileUrl values are still subject to URL expiration constraints.</para>
                /// </summary>
                [NameInMap("importRequest")]
                [Validation(Required=false)]
                public GetBatchImportTaskResponseBodyDataResultImportRequest ImportRequest { get; set; }
                public class GetBatchImportTaskResponseBodyDataResultImportRequest : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow overwriting existing APIs.</para>
                    /// </summary>
                    [NameInMap("allowUpdate")]
                    [Validation(Required=false)]
                    public bool? AllowUpdate { get; set; }

                    /// <summary>
                    /// <para>The API type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Http</para>
                    /// </summary>
                    [NameInMap("apiType")]
                    [Validation(Required=false)]
                    public string ApiType { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the request is in dry run mode. This parameter is fixed to false in the formal import request body.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("dryRun")]
                    [Validation(Required=false)]
                    public bool? DryRun { get; set; }

                    /// <summary>
                    /// <para>The gateway instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gw-xxx</para>
                    /// </summary>
                    [NameInMap("gatewayId")]
                    [Validation(Required=false)]
                    public string GatewayId { get; set; }

                    /// <summary>
                    /// <para>The resource group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rg-xxx</para>
                    /// </summary>
                    [NameInMap("resourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    /// <summary>
                    /// <para>The download URL of the OAS ZIP file, which is consistent with the dry run request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com/my-bucket/imports/batch.zip">https://oss-cn-hangzhou.aliyuncs.com/my-bucket/imports/batch.zip</a></para>
                    /// </summary>
                    [NameInMap("specFileUrl")]
                    [Validation(Required=false)]
                    public string SpecFileUrl { get; set; }

                    /// <summary>
                    /// <para>The OSS configuration of the OAS file, which is consistent with the dry run request.</para>
                    /// </summary>
                    [NameInMap("specOssConfig")]
                    [Validation(Required=false)]
                    public GetBatchImportTaskResponseBodyDataResultImportRequestSpecOssConfig SpecOssConfig { get; set; }
                    public class GetBatchImportTaskResponseBodyDataResultImportRequestSpecOssConfig : TeaModel {
                        /// <summary>
                        /// <para>The name of the OSS bucket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my-bucket</para>
                        /// </summary>
                        [NameInMap("bucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }

                        /// <summary>
                        /// <para>The object key of the specification file in the OSS bucket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>imports/batch.zip</para>
                        /// </summary>
                        [NameInMap("objectKey")]
                        [Validation(Required=false)]
                        public string ObjectKey { get; set; }

                        /// <summary>
                        /// <para>The region ID of the OSS bucket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("regionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <para>The conflict merge strategy used during import.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ExistFirst</para>
                    /// </summary>
                    [NameInMap("strategy")]
                    [Validation(Required=false)]
                    public string Strategy { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to import with gateway extension configurations.</para>
                    /// </summary>
                    [NameInMap("withGatewayExtension")]
                    [Validation(Required=false)]
                    public bool? WithGatewayExtension { get; set; }

                }

                /// <summary>
                /// <para>The list of successfully processed APIs.</para>
                /// </summary>
                [NameInMap("successItems")]
                [Validation(Required=false)]
                public List<GetBatchImportTaskResponseBodyDataResultSuccessItems> SuccessItems { get; set; }
                public class GetBatchImportTaskResponseBodyDataResultSuccessItems : TeaModel {
                    /// <summary>
                    /// <para>The ID of the API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>api-xxx</para>
                    /// </summary>
                    [NameInMap("apiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// <para>The API name. The value unknown is returned if the name cannot be identified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>petstore</para>
                    /// </summary>
                    [NameInMap("apiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>invalid oas format</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>petstore.yaml</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

            }

            /// <summary>
            /// <para>The task status. Valid values: Pending, Running, Success, PartialSuccess, and Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async-task-xxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BatchImport</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>CE534E1D-FCE4-5930-B784-E055EC1AEE6F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
