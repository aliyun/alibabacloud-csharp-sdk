// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.NAS20170626.Models;

namespace AlibabaCloud.SDK.NAS20170626
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-chengdu", "nas.aliyuncs.com"},
                {"me-east-1", "nas.ap-northeast-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "nas.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("nas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        /**
         * @deprecated OpenAPI AddClientToBlackList is deprecated
         *
         * @summary 将客户端加入黑名单
         *
         * @description The API operation is available only for CPFS file systems.
         *
         * @param request AddClientToBlackListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddClientToBlackListResponse
         */
        // Deprecated
        public AddClientToBlackListResponse AddClientToBlackListWithOptions(AddClientToBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIP))
            {
                query["ClientIP"] = request.ClientIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddClientToBlackList",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddClientToBlackListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI AddClientToBlackList is deprecated
         *
         * @summary 将客户端加入黑名单
         *
         * @description The API operation is available only for CPFS file systems.
         *
         * @param request AddClientToBlackListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddClientToBlackListResponse
         */
        // Deprecated
        public async Task<AddClientToBlackListResponse> AddClientToBlackListWithOptionsAsync(AddClientToBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIP))
            {
                query["ClientIP"] = request.ClientIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddClientToBlackList",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddClientToBlackListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI AddClientToBlackList is deprecated
         *
         * @summary 将客户端加入黑名单
         *
         * @description The API operation is available only for CPFS file systems.
         *
         * @param request AddClientToBlackListRequest
         * @return AddClientToBlackListResponse
         */
        // Deprecated
        public AddClientToBlackListResponse AddClientToBlackList(AddClientToBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddClientToBlackListWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI AddClientToBlackList is deprecated
         *
         * @summary 将客户端加入黑名单
         *
         * @description The API operation is available only for CPFS file systems.
         *
         * @param request AddClientToBlackListRequest
         * @return AddClientToBlackListResponse
         */
        // Deprecated
        public async Task<AddClientToBlackListResponse> AddClientToBlackListAsync(AddClientToBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddClientToBlackListWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI AddTags is deprecated, please use NAS::2017-06-26::TagResources instead.
         *
         * @summary Adds one or more tags to a file system or overwrites one or more tags of a file system.
         *
         * @description >  The tag feature has been upgraded and this document will be unpublished. For more information, see TagResources.
         * *   Each tag consists of a tag key (TagKey) and a tag value (TagValue).
         * *   Placeholders at the start and end of each TagKey and TagValue are automatically removed. Placeholders include the spacebar ( ), tab (\\t), line break (\\n), and carriage return (\\r).
         * *   You must specify a tag key. You can leave a tag value empty.
         * *   The tag key and tag value are not case-sensitive.
         * *   A tag key can be up to 64 characters in length and a tag value can be up to 128 characters in length.
         * *   You can add a maximum of 10 tags to a file system. If you add two tags with the same tag key, the newly added tag will overwrite the existing tag.
         * *   If you remove a tag from all linked file systems, the tag is automatically deleted.
         *
         * @param request AddTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTagsResponse
         */
        // Deprecated
        public AddTagsResponse AddTagsWithOptions(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTags",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI AddTags is deprecated, please use NAS::2017-06-26::TagResources instead.
         *
         * @summary Adds one or more tags to a file system or overwrites one or more tags of a file system.
         *
         * @description >  The tag feature has been upgraded and this document will be unpublished. For more information, see TagResources.
         * *   Each tag consists of a tag key (TagKey) and a tag value (TagValue).
         * *   Placeholders at the start and end of each TagKey and TagValue are automatically removed. Placeholders include the spacebar ( ), tab (\\t), line break (\\n), and carriage return (\\r).
         * *   You must specify a tag key. You can leave a tag value empty.
         * *   The tag key and tag value are not case-sensitive.
         * *   A tag key can be up to 64 characters in length and a tag value can be up to 128 characters in length.
         * *   You can add a maximum of 10 tags to a file system. If you add two tags with the same tag key, the newly added tag will overwrite the existing tag.
         * *   If you remove a tag from all linked file systems, the tag is automatically deleted.
         *
         * @param request AddTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTagsResponse
         */
        // Deprecated
        public async Task<AddTagsResponse> AddTagsWithOptionsAsync(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTags",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI AddTags is deprecated, please use NAS::2017-06-26::TagResources instead.
         *
         * @summary Adds one or more tags to a file system or overwrites one or more tags of a file system.
         *
         * @description >  The tag feature has been upgraded and this document will be unpublished. For more information, see TagResources.
         * *   Each tag consists of a tag key (TagKey) and a tag value (TagValue).
         * *   Placeholders at the start and end of each TagKey and TagValue are automatically removed. Placeholders include the spacebar ( ), tab (\\t), line break (\\n), and carriage return (\\r).
         * *   You must specify a tag key. You can leave a tag value empty.
         * *   The tag key and tag value are not case-sensitive.
         * *   A tag key can be up to 64 characters in length and a tag value can be up to 128 characters in length.
         * *   You can add a maximum of 10 tags to a file system. If you add two tags with the same tag key, the newly added tag will overwrite the existing tag.
         * *   If you remove a tag from all linked file systems, the tag is automatically deleted.
         *
         * @param request AddTagsRequest
         * @return AddTagsResponse
         */
        // Deprecated
        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI AddTags is deprecated, please use NAS::2017-06-26::TagResources instead.
         *
         * @summary Adds one or more tags to a file system or overwrites one or more tags of a file system.
         *
         * @description >  The tag feature has been upgraded and this document will be unpublished. For more information, see TagResources.
         * *   Each tag consists of a tag key (TagKey) and a tag value (TagValue).
         * *   Placeholders at the start and end of each TagKey and TagValue are automatically removed. Placeholders include the spacebar ( ), tab (\\t), line break (\\n), and carriage return (\\r).
         * *   You must specify a tag key. You can leave a tag value empty.
         * *   The tag key and tag value are not case-sensitive.
         * *   A tag key can be up to 64 characters in length and a tag value can be up to 128 characters in length.
         * *   You can add a maximum of 10 tags to a file system. If you add two tags with the same tag key, the newly added tag will overwrite the existing tag.
         * *   If you remove a tag from all linked file systems, the tag is automatically deleted.
         *
         * @param request AddTagsRequest
         * @return AddTagsResponse
         */
        // Deprecated
        public async Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Applies an automatic snapshot policy to one or more file systems.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         * *   You can apply only one automatic snapshot policy to each file system.
         * *   Each automatic snapshot policy can be applied to multiple file systems.
         * *   If an automatic snapshot policy is applied to a file system, you can call the ApplyAutoSnapshotPolicy operation to change the automatic snapshot policy.
         *
         * @param request ApplyAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyAutoSnapshotPolicyResponse
         */
        public ApplyAutoSnapshotPolicyResponse ApplyAutoSnapshotPolicyWithOptions(ApplyAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyId))
            {
                query["AutoSnapshotPolicyId"] = request.AutoSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemIds))
            {
                query["FileSystemIds"] = request.FileSystemIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Applies an automatic snapshot policy to one or more file systems.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         * *   You can apply only one automatic snapshot policy to each file system.
         * *   Each automatic snapshot policy can be applied to multiple file systems.
         * *   If an automatic snapshot policy is applied to a file system, you can call the ApplyAutoSnapshotPolicy operation to change the automatic snapshot policy.
         *
         * @param request ApplyAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyAutoSnapshotPolicyResponse
         */
        public async Task<ApplyAutoSnapshotPolicyResponse> ApplyAutoSnapshotPolicyWithOptionsAsync(ApplyAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyId))
            {
                query["AutoSnapshotPolicyId"] = request.AutoSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemIds))
            {
                query["FileSystemIds"] = request.FileSystemIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Applies an automatic snapshot policy to one or more file systems.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         * *   You can apply only one automatic snapshot policy to each file system.
         * *   Each automatic snapshot policy can be applied to multiple file systems.
         * *   If an automatic snapshot policy is applied to a file system, you can call the ApplyAutoSnapshotPolicy operation to change the automatic snapshot policy.
         *
         * @param request ApplyAutoSnapshotPolicyRequest
         * @return ApplyAutoSnapshotPolicyResponse
         */
        public ApplyAutoSnapshotPolicyResponse ApplyAutoSnapshotPolicy(ApplyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Applies an automatic snapshot policy to one or more file systems.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         * *   You can apply only one automatic snapshot policy to each file system.
         * *   Each automatic snapshot policy can be applied to multiple file systems.
         * *   If an automatic snapshot policy is applied to a file system, you can call the ApplyAutoSnapshotPolicy operation to change the automatic snapshot policy.
         *
         * @param request ApplyAutoSnapshotPolicyRequest
         * @return ApplyAutoSnapshotPolicyResponse
         */
        public async Task<ApplyAutoSnapshotPolicyResponse> ApplyAutoSnapshotPolicyAsync(ApplyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds AutoRefresh configurations to a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can add AutoRefresh configurations only to the dataflows that are in the `Running` state.
         * *   You can add a maximum of five AutoRefresh configurations to a dataflow.
         * *   It generally takes 2 to 5 minutes to create an AutoRefresh configuration. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the dataflow status.
         * *   AutoRefresh depends on the object modification events collected by EventBridge from the source Object Storage Service (OSS) bucket. You must first [activate EventBridge](https://help.aliyun.com/document_detail/182246.html).
         *     **
         *     **Note** The event buses and event rules created for CPFS in the EventBridge console contain the `Create for cpfs auto refresh` description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.
         * *   The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. When you add an AutoRefresh configuration to the prefix for a CPFS dataflow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS dataflow.
         * *   After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a dataflow task to load the updated data.
         * *   AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS dataflow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the dataflow status becomes Misconfigured. To resolve these issues, you can increase the dataflow specifications or reduce the frequency of triggering the object modification event.
         *
         * @param request ApplyDataFlowAutoRefreshRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyDataFlowAutoRefreshResponse
         */
        public ApplyDataFlowAutoRefreshResponse ApplyDataFlowAutoRefreshWithOptions(ApplyDataFlowAutoRefreshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshInterval))
            {
                query["AutoRefreshInterval"] = request.AutoRefreshInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshPolicy))
            {
                query["AutoRefreshPolicy"] = request.AutoRefreshPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshs))
            {
                query["AutoRefreshs"] = request.AutoRefreshs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyDataFlowAutoRefresh",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyDataFlowAutoRefreshResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds AutoRefresh configurations to a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can add AutoRefresh configurations only to the dataflows that are in the `Running` state.
         * *   You can add a maximum of five AutoRefresh configurations to a dataflow.
         * *   It generally takes 2 to 5 minutes to create an AutoRefresh configuration. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the dataflow status.
         * *   AutoRefresh depends on the object modification events collected by EventBridge from the source Object Storage Service (OSS) bucket. You must first [activate EventBridge](https://help.aliyun.com/document_detail/182246.html).
         *     **
         *     **Note** The event buses and event rules created for CPFS in the EventBridge console contain the `Create for cpfs auto refresh` description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.
         * *   The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. When you add an AutoRefresh configuration to the prefix for a CPFS dataflow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS dataflow.
         * *   After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a dataflow task to load the updated data.
         * *   AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS dataflow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the dataflow status becomes Misconfigured. To resolve these issues, you can increase the dataflow specifications or reduce the frequency of triggering the object modification event.
         *
         * @param request ApplyDataFlowAutoRefreshRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyDataFlowAutoRefreshResponse
         */
        public async Task<ApplyDataFlowAutoRefreshResponse> ApplyDataFlowAutoRefreshWithOptionsAsync(ApplyDataFlowAutoRefreshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshInterval))
            {
                query["AutoRefreshInterval"] = request.AutoRefreshInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshPolicy))
            {
                query["AutoRefreshPolicy"] = request.AutoRefreshPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshs))
            {
                query["AutoRefreshs"] = request.AutoRefreshs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyDataFlowAutoRefresh",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyDataFlowAutoRefreshResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds AutoRefresh configurations to a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can add AutoRefresh configurations only to the dataflows that are in the `Running` state.
         * *   You can add a maximum of five AutoRefresh configurations to a dataflow.
         * *   It generally takes 2 to 5 minutes to create an AutoRefresh configuration. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the dataflow status.
         * *   AutoRefresh depends on the object modification events collected by EventBridge from the source Object Storage Service (OSS) bucket. You must first [activate EventBridge](https://help.aliyun.com/document_detail/182246.html).
         *     **
         *     **Note** The event buses and event rules created for CPFS in the EventBridge console contain the `Create for cpfs auto refresh` description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.
         * *   The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. When you add an AutoRefresh configuration to the prefix for a CPFS dataflow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS dataflow.
         * *   After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a dataflow task to load the updated data.
         * *   AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS dataflow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the dataflow status becomes Misconfigured. To resolve these issues, you can increase the dataflow specifications or reduce the frequency of triggering the object modification event.
         *
         * @param request ApplyDataFlowAutoRefreshRequest
         * @return ApplyDataFlowAutoRefreshResponse
         */
        public ApplyDataFlowAutoRefreshResponse ApplyDataFlowAutoRefresh(ApplyDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyDataFlowAutoRefreshWithOptions(request, runtime);
        }

        /**
         * @summary Adds AutoRefresh configurations to a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can add AutoRefresh configurations only to the dataflows that are in the `Running` state.
         * *   You can add a maximum of five AutoRefresh configurations to a dataflow.
         * *   It generally takes 2 to 5 minutes to create an AutoRefresh configuration. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the dataflow status.
         * *   AutoRefresh depends on the object modification events collected by EventBridge from the source Object Storage Service (OSS) bucket. You must first [activate EventBridge](https://help.aliyun.com/document_detail/182246.html).
         *     **
         *     **Note** The event buses and event rules created for CPFS in the EventBridge console contain the `Create for cpfs auto refresh` description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.
         * *   The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. When you add an AutoRefresh configuration to the prefix for a CPFS dataflow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS dataflow.
         * *   After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a dataflow task to load the updated data.
         * *   AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS dataflow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the dataflow status becomes Misconfigured. To resolve these issues, you can increase the dataflow specifications or reduce the frequency of triggering the object modification event.
         *
         * @param request ApplyDataFlowAutoRefreshRequest
         * @return ApplyDataFlowAutoRefreshResponse
         */
        public async Task<ApplyDataFlowAutoRefreshResponse> ApplyDataFlowAutoRefreshAsync(ApplyDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyDataFlowAutoRefreshWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes automatic snapshot policies from one or more file systems.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request CancelAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelAutoSnapshotPolicyResponse
         */
        public CancelAutoSnapshotPolicyResponse CancelAutoSnapshotPolicyWithOptions(CancelAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemIds))
            {
                query["FileSystemIds"] = request.FileSystemIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes automatic snapshot policies from one or more file systems.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request CancelAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelAutoSnapshotPolicyResponse
         */
        public async Task<CancelAutoSnapshotPolicyResponse> CancelAutoSnapshotPolicyWithOptionsAsync(CancelAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemIds))
            {
                query["FileSystemIds"] = request.FileSystemIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes automatic snapshot policies from one or more file systems.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request CancelAutoSnapshotPolicyRequest
         * @return CancelAutoSnapshotPolicyResponse
         */
        public CancelAutoSnapshotPolicyResponse CancelAutoSnapshotPolicy(CancelAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Removes automatic snapshot policies from one or more file systems.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request CancelAutoSnapshotPolicyRequest
         * @return CancelAutoSnapshotPolicyResponse
         */
        public async Task<CancelAutoSnapshotPolicyResponse> CancelAutoSnapshotPolicyAsync(CancelAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels the AutoRefresh configuration for a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can cancel AutoRefresh configurations only for the dataflows that are in the `Running` or `Stopped` state.
         * *   It generally takes 2 to 5 minutes to cancel the AutoRefresh configurations. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the status of the AutoRefresh tasks.
         *
         * @param request CancelDataFlowAutoRefreshRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDataFlowAutoRefreshResponse
         */
        public CancelDataFlowAutoRefreshResponse CancelDataFlowAutoRefreshWithOptions(CancelDataFlowAutoRefreshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshPath))
            {
                query["RefreshPath"] = request.RefreshPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDataFlowAutoRefresh",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDataFlowAutoRefreshResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels the AutoRefresh configuration for a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can cancel AutoRefresh configurations only for the dataflows that are in the `Running` or `Stopped` state.
         * *   It generally takes 2 to 5 minutes to cancel the AutoRefresh configurations. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the status of the AutoRefresh tasks.
         *
         * @param request CancelDataFlowAutoRefreshRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDataFlowAutoRefreshResponse
         */
        public async Task<CancelDataFlowAutoRefreshResponse> CancelDataFlowAutoRefreshWithOptionsAsync(CancelDataFlowAutoRefreshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshPath))
            {
                query["RefreshPath"] = request.RefreshPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDataFlowAutoRefresh",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDataFlowAutoRefreshResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels the AutoRefresh configuration for a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can cancel AutoRefresh configurations only for the dataflows that are in the `Running` or `Stopped` state.
         * *   It generally takes 2 to 5 minutes to cancel the AutoRefresh configurations. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the status of the AutoRefresh tasks.
         *
         * @param request CancelDataFlowAutoRefreshRequest
         * @return CancelDataFlowAutoRefreshResponse
         */
        public CancelDataFlowAutoRefreshResponse CancelDataFlowAutoRefresh(CancelDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDataFlowAutoRefreshWithOptions(request, runtime);
        }

        /**
         * @summary Cancels the AutoRefresh configuration for a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can cancel AutoRefresh configurations only for the dataflows that are in the `Running` or `Stopped` state.
         * *   It generally takes 2 to 5 minutes to cancel the AutoRefresh configurations. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the status of the AutoRefresh tasks.
         *
         * @param request CancelDataFlowAutoRefreshRequest
         * @return CancelDataFlowAutoRefreshResponse
         */
        public async Task<CancelDataFlowAutoRefreshResponse> CancelDataFlowAutoRefreshAsync(CancelDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDataFlowAutoRefreshWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels a dataflow task that is not running.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflow tasks. You can view the version information on the file system details page in the console.
         * *   You can cancel only the dataflow tasks that are in the `Pending` and `Executing` states.
         * *   It generally takes 5 to 10 minutes to cancel a dataflow task. You can query the task execution status by calling the [DescribeDataFlowTasks](https://help.aliyun.com/document_detail/2402275.html) operation.
         *
         * @param request CancelDataFlowTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDataFlowTaskResponse
         */
        public CancelDataFlowTaskResponse CancelDataFlowTaskWithOptions(CancelDataFlowTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDataFlowTask",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDataFlowTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels a dataflow task that is not running.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflow tasks. You can view the version information on the file system details page in the console.
         * *   You can cancel only the dataflow tasks that are in the `Pending` and `Executing` states.
         * *   It generally takes 5 to 10 minutes to cancel a dataflow task. You can query the task execution status by calling the [DescribeDataFlowTasks](https://help.aliyun.com/document_detail/2402275.html) operation.
         *
         * @param request CancelDataFlowTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDataFlowTaskResponse
         */
        public async Task<CancelDataFlowTaskResponse> CancelDataFlowTaskWithOptionsAsync(CancelDataFlowTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDataFlowTask",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDataFlowTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels a dataflow task that is not running.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflow tasks. You can view the version information on the file system details page in the console.
         * *   You can cancel only the dataflow tasks that are in the `Pending` and `Executing` states.
         * *   It generally takes 5 to 10 minutes to cancel a dataflow task. You can query the task execution status by calling the [DescribeDataFlowTasks](https://help.aliyun.com/document_detail/2402275.html) operation.
         *
         * @param request CancelDataFlowTaskRequest
         * @return CancelDataFlowTaskResponse
         */
        public CancelDataFlowTaskResponse CancelDataFlowTask(CancelDataFlowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDataFlowTaskWithOptions(request, runtime);
        }

        /**
         * @summary Cancels a dataflow task that is not running.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflow tasks. You can view the version information on the file system details page in the console.
         * *   You can cancel only the dataflow tasks that are in the `Pending` and `Executing` states.
         * *   It generally takes 5 to 10 minutes to cancel a dataflow task. You can query the task execution status by calling the [DescribeDataFlowTasks](https://help.aliyun.com/document_detail/2402275.html) operation.
         *
         * @param request CancelDataFlowTaskRequest
         * @return CancelDataFlowTaskResponse
         */
        public async Task<CancelDataFlowTaskResponse> CancelDataFlowTaskAsync(CancelDataFlowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDataFlowTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels the directory quota of a file system.
         *
         * @description Only General-purpose file systems support the directory quota feature.
         *
         * @param request CancelDirQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDirQuotaResponse
         */
        public CancelDirQuotaResponse CancelDirQuotaWithOptions(CancelDirQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDirQuota",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDirQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels the directory quota of a file system.
         *
         * @description Only General-purpose file systems support the directory quota feature.
         *
         * @param request CancelDirQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDirQuotaResponse
         */
        public async Task<CancelDirQuotaResponse> CancelDirQuotaWithOptionsAsync(CancelDirQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDirQuota",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDirQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels the directory quota of a file system.
         *
         * @description Only General-purpose file systems support the directory quota feature.
         *
         * @param request CancelDirQuotaRequest
         * @return CancelDirQuotaResponse
         */
        public CancelDirQuotaResponse CancelDirQuota(CancelDirQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDirQuotaWithOptions(request, runtime);
        }

        /**
         * @summary Cancels the directory quota of a file system.
         *
         * @description Only General-purpose file systems support the directory quota feature.
         *
         * @param request CancelDirQuotaRequest
         * @return CancelDirQuotaResponse
         */
        public async Task<CancelDirQuotaResponse> CancelDirQuotaAsync(CancelDirQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDirQuotaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels a running data retrieval task.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request CancelLifecycleRetrieveJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelLifecycleRetrieveJobResponse
         */
        public CancelLifecycleRetrieveJobResponse CancelLifecycleRetrieveJobWithOptions(CancelLifecycleRetrieveJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelLifecycleRetrieveJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelLifecycleRetrieveJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels a running data retrieval task.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request CancelLifecycleRetrieveJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelLifecycleRetrieveJobResponse
         */
        public async Task<CancelLifecycleRetrieveJobResponse> CancelLifecycleRetrieveJobWithOptionsAsync(CancelLifecycleRetrieveJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelLifecycleRetrieveJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelLifecycleRetrieveJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels a running data retrieval task.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request CancelLifecycleRetrieveJobRequest
         * @return CancelLifecycleRetrieveJobResponse
         */
        public CancelLifecycleRetrieveJobResponse CancelLifecycleRetrieveJob(CancelLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelLifecycleRetrieveJobWithOptions(request, runtime);
        }

        /**
         * @summary Cancels a running data retrieval task.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request CancelLifecycleRetrieveJobRequest
         * @return CancelLifecycleRetrieveJobResponse
         */
        public async Task<CancelLifecycleRetrieveJobResponse> CancelLifecycleRetrieveJobAsync(CancelLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelLifecycleRetrieveJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels a running job of the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can cancel only jobs that are in the Running state. You cannot cancel jobs that are in the PartialSuccess, Success, Fail, or Cancelled state.
         * *   If you cancel a running job that permanently deletes files, you cannot restore the files that are already permanently deleted.
         * *   If you cancel a running job that restores files, you can query the restored files from the file system, and query the unrestored files from the recycle bin.
         *
         * @param request CancelRecycleBinJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelRecycleBinJobResponse
         */
        public CancelRecycleBinJobResponse CancelRecycleBinJobWithOptions(CancelRecycleBinJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRecycleBinJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRecycleBinJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels a running job of the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can cancel only jobs that are in the Running state. You cannot cancel jobs that are in the PartialSuccess, Success, Fail, or Cancelled state.
         * *   If you cancel a running job that permanently deletes files, you cannot restore the files that are already permanently deleted.
         * *   If you cancel a running job that restores files, you can query the restored files from the file system, and query the unrestored files from the recycle bin.
         *
         * @param request CancelRecycleBinJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelRecycleBinJobResponse
         */
        public async Task<CancelRecycleBinJobResponse> CancelRecycleBinJobWithOptionsAsync(CancelRecycleBinJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRecycleBinJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRecycleBinJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels a running job of the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can cancel only jobs that are in the Running state. You cannot cancel jobs that are in the PartialSuccess, Success, Fail, or Cancelled state.
         * *   If you cancel a running job that permanently deletes files, you cannot restore the files that are already permanently deleted.
         * *   If you cancel a running job that restores files, you can query the restored files from the file system, and query the unrestored files from the recycle bin.
         *
         * @param request CancelRecycleBinJobRequest
         * @return CancelRecycleBinJobResponse
         */
        public CancelRecycleBinJobResponse CancelRecycleBinJob(CancelRecycleBinJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRecycleBinJobWithOptions(request, runtime);
        }

        /**
         * @summary Cancels a running job of the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can cancel only jobs that are in the Running state. You cannot cancel jobs that are in the PartialSuccess, Success, Fail, or Cancelled state.
         * *   If you cancel a running job that permanently deletes files, you cannot restore the files that are already permanently deleted.
         * *   If you cancel a running job that restores files, you can query the restored files from the file system, and query the unrestored files from the recycle bin.
         *
         * @param request CancelRecycleBinJobRequest
         * @return CancelRecycleBinJobResponse
         */
        public async Task<CancelRecycleBinJobResponse> CancelRecycleBinJobAsync(CancelRecycleBinJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRecycleBinJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the resource group to which a file system belongs.
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the resource group to which a file system belongs.
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the resource group to which a file system belongs.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Changes the resource group to which a file system belongs.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a permission group.
         *
         * @param request CreateAccessGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessGroupResponse
         */
        public CreateAccessGroupResponse CreateAccessGroupWithOptions(CreateAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupType))
            {
                query["AccessGroupType"] = request.AccessGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessGroup",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a permission group.
         *
         * @param request CreateAccessGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessGroupResponse
         */
        public async Task<CreateAccessGroupResponse> CreateAccessGroupWithOptionsAsync(CreateAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupType))
            {
                query["AccessGroupType"] = request.AccessGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessGroup",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a permission group.
         *
         * @param request CreateAccessGroupRequest
         * @return CreateAccessGroupResponse
         */
        public CreateAccessGroupResponse CreateAccessGroup(CreateAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a permission group.
         *
         * @param request CreateAccessGroupRequest
         * @return CreateAccessGroupResponse
         */
        public async Task<CreateAccessGroupResponse> CreateAccessGroupAsync(CreateAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an access point.
         *
         * @description *   After you call the CreateAccessPoint operation, an access point is not immediately created. Therefore, after you perform the CreateAccessPoint operation successfully, call the DescribeAccessPoints or DescribeAccessPoint operation to query the status of the access point. If the status is **Active**, mount the file system. Otherwise, the file system may fail to be mounted.
         * *   Only General-purpose Network File System (NFS) file systems support this operation.
         * *   If you want to perform the EnabledRam operation to enable a Resource Access Management (RAM) policy, you must configure the corresponding RAM permissions. For more information, see [Manage endpoints](https://help.aliyun.com/document_detail/2545998.html).
         *
         * @param request CreateAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessPointResponse
         */
        public CreateAccessPointResponse CreateAccessPointWithOptions(CreateAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroup))
            {
                query["AccessGroup"] = request.AccessGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointName))
            {
                query["AccessPointName"] = request.AccessPointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnabledRam))
            {
                query["EnabledRam"] = request.EnabledRam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerGroupId))
            {
                query["OwnerGroupId"] = request.OwnerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                query["Permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PosixGroupId))
            {
                query["PosixGroupId"] = request.PosixGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PosixSecondaryGroupIds))
            {
                query["PosixSecondaryGroupIds"] = request.PosixSecondaryGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PosixUserId))
            {
                query["PosixUserId"] = request.PosixUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootDirectory))
            {
                query["RootDirectory"] = request.RootDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswId))
            {
                query["VswId"] = request.VswId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessPoint",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessPointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an access point.
         *
         * @description *   After you call the CreateAccessPoint operation, an access point is not immediately created. Therefore, after you perform the CreateAccessPoint operation successfully, call the DescribeAccessPoints or DescribeAccessPoint operation to query the status of the access point. If the status is **Active**, mount the file system. Otherwise, the file system may fail to be mounted.
         * *   Only General-purpose Network File System (NFS) file systems support this operation.
         * *   If you want to perform the EnabledRam operation to enable a Resource Access Management (RAM) policy, you must configure the corresponding RAM permissions. For more information, see [Manage endpoints](https://help.aliyun.com/document_detail/2545998.html).
         *
         * @param request CreateAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessPointResponse
         */
        public async Task<CreateAccessPointResponse> CreateAccessPointWithOptionsAsync(CreateAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroup))
            {
                query["AccessGroup"] = request.AccessGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointName))
            {
                query["AccessPointName"] = request.AccessPointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnabledRam))
            {
                query["EnabledRam"] = request.EnabledRam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerGroupId))
            {
                query["OwnerGroupId"] = request.OwnerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                query["Permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PosixGroupId))
            {
                query["PosixGroupId"] = request.PosixGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PosixSecondaryGroupIds))
            {
                query["PosixSecondaryGroupIds"] = request.PosixSecondaryGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PosixUserId))
            {
                query["PosixUserId"] = request.PosixUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootDirectory))
            {
                query["RootDirectory"] = request.RootDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswId))
            {
                query["VswId"] = request.VswId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessPoint",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an access point.
         *
         * @description *   After you call the CreateAccessPoint operation, an access point is not immediately created. Therefore, after you perform the CreateAccessPoint operation successfully, call the DescribeAccessPoints or DescribeAccessPoint operation to query the status of the access point. If the status is **Active**, mount the file system. Otherwise, the file system may fail to be mounted.
         * *   Only General-purpose Network File System (NFS) file systems support this operation.
         * *   If you want to perform the EnabledRam operation to enable a Resource Access Management (RAM) policy, you must configure the corresponding RAM permissions. For more information, see [Manage endpoints](https://help.aliyun.com/document_detail/2545998.html).
         *
         * @param request CreateAccessPointRequest
         * @return CreateAccessPointResponse
         */
        public CreateAccessPointResponse CreateAccessPoint(CreateAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessPointWithOptions(request, runtime);
        }

        /**
         * @summary Creates an access point.
         *
         * @description *   After you call the CreateAccessPoint operation, an access point is not immediately created. Therefore, after you perform the CreateAccessPoint operation successfully, call the DescribeAccessPoints or DescribeAccessPoint operation to query the status of the access point. If the status is **Active**, mount the file system. Otherwise, the file system may fail to be mounted.
         * *   Only General-purpose Network File System (NFS) file systems support this operation.
         * *   If you want to perform the EnabledRam operation to enable a Resource Access Management (RAM) policy, you must configure the corresponding RAM permissions. For more information, see [Manage endpoints](https://help.aliyun.com/document_detail/2545998.html).
         *
         * @param request CreateAccessPointRequest
         * @return CreateAccessPointResponse
         */
        public async Task<CreateAccessPointResponse> CreateAccessPointAsync(CreateAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessPointWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a rule for a permission group.
         *
         * @param request CreateAccessRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessRuleResponse
         */
        public CreateAccessRuleResponse CreateAccessRuleWithOptions(CreateAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6SourceCidrIp))
            {
                query["Ipv6SourceCidrIp"] = request.Ipv6SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RWAccessType))
            {
                query["RWAccessType"] = request.RWAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                query["SourceCidrIp"] = request.SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessType))
            {
                query["UserAccessType"] = request.UserAccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessRule",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a rule for a permission group.
         *
         * @param request CreateAccessRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessRuleResponse
         */
        public async Task<CreateAccessRuleResponse> CreateAccessRuleWithOptionsAsync(CreateAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6SourceCidrIp))
            {
                query["Ipv6SourceCidrIp"] = request.Ipv6SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RWAccessType))
            {
                query["RWAccessType"] = request.RWAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                query["SourceCidrIp"] = request.SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessType))
            {
                query["UserAccessType"] = request.UserAccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessRule",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a rule for a permission group.
         *
         * @param request CreateAccessRuleRequest
         * @return CreateAccessRuleResponse
         */
        public CreateAccessRuleResponse CreateAccessRule(CreateAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessRuleWithOptions(request, runtime);
        }

        /**
         * @summary Creates a rule for a permission group.
         *
         * @param request CreateAccessRuleRequest
         * @return CreateAccessRuleResponse
         */
        public async Task<CreateAccessRuleResponse> CreateAccessRuleAsync(CreateAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an automatic snapshot policy.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   You can create a maximum of 100 automatic snapshot policies in each region for an Alibaba Cloud account.
         * *   If an auto snapshot is being created when the scheduled time for a new auto snapshot arrives, the creation of the new snapshot is skipped. This occurs if the file system stores a large volume of data. For example, you have scheduled auto snapshots to be created at 09:00:00, 10:00:00, 11:00:00, and 12:00:00 for a file system. The system starts to create an auto snapshot at 09:00:00 and does not complete the process until 10:20:00. The process takes 80 minutes because the file system has a large volume of data. In this case, the system does not create an auto snapshot at 10:00:00, but creates an auto snapshot at 11:00:00.
         * *   A maximum of 128 auto snapshots can be created for a file system. If the upper limit is reached, the earliest auto snapshot is deleted. This rule does not apply to manual snapshots.
         * *   If you modify the retention period of an automatic snapshot policy, the modification applies only to subsequent snapshots, but not to the existing snapshots.
         * *   If an auto snapshot is being created for a file system, you cannot create a manual snapshot for the file system. You must wait after the auto snapshot is created.
         * *   You can only apply automatic snapshot policies to a file system that is in the Running state.
         * *   All auto snapshots are named in the `auto_yyyyMMdd_X` format, where: `auto` indicates that the snapshot is created based on an automatic snapshot policy. `yyyyMMdd` indicates the date on which the snapshot is created. `y` indicates the year. `M` indicates the month. `d` indicates the day. `X` indicates the ordinal number of the snapshot on the current day. For example, `auto_20201018_1` indicates the first auto snapshot that was created on October 18, 2020.
         * *   After an automatic snapshot policy is created, you can call the ApplyAutoSnapshotPolicy operation to apply the policy to a file system and call the ModifyAutoSnapshotPolicy operation to modify the policy.
         *
         * @param request CreateAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAutoSnapshotPolicyResponse
         */
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicyWithOptions(CreateAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyName))
            {
                query["AutoSnapshotPolicyName"] = request.AutoSnapshotPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatWeekdays))
            {
                query["RepeatWeekdays"] = request.RepeatWeekdays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoints))
            {
                query["TimePoints"] = request.TimePoints;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an automatic snapshot policy.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   You can create a maximum of 100 automatic snapshot policies in each region for an Alibaba Cloud account.
         * *   If an auto snapshot is being created when the scheduled time for a new auto snapshot arrives, the creation of the new snapshot is skipped. This occurs if the file system stores a large volume of data. For example, you have scheduled auto snapshots to be created at 09:00:00, 10:00:00, 11:00:00, and 12:00:00 for a file system. The system starts to create an auto snapshot at 09:00:00 and does not complete the process until 10:20:00. The process takes 80 minutes because the file system has a large volume of data. In this case, the system does not create an auto snapshot at 10:00:00, but creates an auto snapshot at 11:00:00.
         * *   A maximum of 128 auto snapshots can be created for a file system. If the upper limit is reached, the earliest auto snapshot is deleted. This rule does not apply to manual snapshots.
         * *   If you modify the retention period of an automatic snapshot policy, the modification applies only to subsequent snapshots, but not to the existing snapshots.
         * *   If an auto snapshot is being created for a file system, you cannot create a manual snapshot for the file system. You must wait after the auto snapshot is created.
         * *   You can only apply automatic snapshot policies to a file system that is in the Running state.
         * *   All auto snapshots are named in the `auto_yyyyMMdd_X` format, where: `auto` indicates that the snapshot is created based on an automatic snapshot policy. `yyyyMMdd` indicates the date on which the snapshot is created. `y` indicates the year. `M` indicates the month. `d` indicates the day. `X` indicates the ordinal number of the snapshot on the current day. For example, `auto_20201018_1` indicates the first auto snapshot that was created on October 18, 2020.
         * *   After an automatic snapshot policy is created, you can call the ApplyAutoSnapshotPolicy operation to apply the policy to a file system and call the ModifyAutoSnapshotPolicy operation to modify the policy.
         *
         * @param request CreateAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAutoSnapshotPolicyResponse
         */
        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicyWithOptionsAsync(CreateAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyName))
            {
                query["AutoSnapshotPolicyName"] = request.AutoSnapshotPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatWeekdays))
            {
                query["RepeatWeekdays"] = request.RepeatWeekdays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoints))
            {
                query["TimePoints"] = request.TimePoints;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an automatic snapshot policy.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   You can create a maximum of 100 automatic snapshot policies in each region for an Alibaba Cloud account.
         * *   If an auto snapshot is being created when the scheduled time for a new auto snapshot arrives, the creation of the new snapshot is skipped. This occurs if the file system stores a large volume of data. For example, you have scheduled auto snapshots to be created at 09:00:00, 10:00:00, 11:00:00, and 12:00:00 for a file system. The system starts to create an auto snapshot at 09:00:00 and does not complete the process until 10:20:00. The process takes 80 minutes because the file system has a large volume of data. In this case, the system does not create an auto snapshot at 10:00:00, but creates an auto snapshot at 11:00:00.
         * *   A maximum of 128 auto snapshots can be created for a file system. If the upper limit is reached, the earliest auto snapshot is deleted. This rule does not apply to manual snapshots.
         * *   If you modify the retention period of an automatic snapshot policy, the modification applies only to subsequent snapshots, but not to the existing snapshots.
         * *   If an auto snapshot is being created for a file system, you cannot create a manual snapshot for the file system. You must wait after the auto snapshot is created.
         * *   You can only apply automatic snapshot policies to a file system that is in the Running state.
         * *   All auto snapshots are named in the `auto_yyyyMMdd_X` format, where: `auto` indicates that the snapshot is created based on an automatic snapshot policy. `yyyyMMdd` indicates the date on which the snapshot is created. `y` indicates the year. `M` indicates the month. `d` indicates the day. `X` indicates the ordinal number of the snapshot on the current day. For example, `auto_20201018_1` indicates the first auto snapshot that was created on October 18, 2020.
         * *   After an automatic snapshot policy is created, you can call the ApplyAutoSnapshotPolicy operation to apply the policy to a file system and call the ModifyAutoSnapshotPolicy operation to modify the policy.
         *
         * @param request CreateAutoSnapshotPolicyRequest
         * @return CreateAutoSnapshotPolicyResponse
         */
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates an automatic snapshot policy.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   You can create a maximum of 100 automatic snapshot policies in each region for an Alibaba Cloud account.
         * *   If an auto snapshot is being created when the scheduled time for a new auto snapshot arrives, the creation of the new snapshot is skipped. This occurs if the file system stores a large volume of data. For example, you have scheduled auto snapshots to be created at 09:00:00, 10:00:00, 11:00:00, and 12:00:00 for a file system. The system starts to create an auto snapshot at 09:00:00 and does not complete the process until 10:20:00. The process takes 80 minutes because the file system has a large volume of data. In this case, the system does not create an auto snapshot at 10:00:00, but creates an auto snapshot at 11:00:00.
         * *   A maximum of 128 auto snapshots can be created for a file system. If the upper limit is reached, the earliest auto snapshot is deleted. This rule does not apply to manual snapshots.
         * *   If you modify the retention period of an automatic snapshot policy, the modification applies only to subsequent snapshots, but not to the existing snapshots.
         * *   If an auto snapshot is being created for a file system, you cannot create a manual snapshot for the file system. You must wait after the auto snapshot is created.
         * *   You can only apply automatic snapshot policies to a file system that is in the Running state.
         * *   All auto snapshots are named in the `auto_yyyyMMdd_X` format, where: `auto` indicates that the snapshot is created based on an automatic snapshot policy. `yyyyMMdd` indicates the date on which the snapshot is created. `y` indicates the year. `M` indicates the month. `d` indicates the day. `X` indicates the ordinal number of the snapshot on the current day. For example, `auto_20201018_1` indicates the first auto snapshot that was created on October 18, 2020.
         * *   After an automatic snapshot policy is created, you can call the ApplyAutoSnapshotPolicy operation to apply the policy to a file system and call the ModifyAutoSnapshotPolicy operation to modify the policy.
         *
         * @param request CreateAutoSnapshotPolicyRequest
         * @return CreateAutoSnapshotPolicyResponse
         */
        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicyAsync(CreateAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a dataflow for a Cloud Parallel File Storage (CPFS) file system and source storage.
         *
         * @description *   Basic operations
         *     *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.4.0 and later support data flows.
         *     *   You can create a data flow only when a CPFS or CPFS for LINGJUN file system is in the Running state.
         *     *   A maximum of 10 data flows can be created for a CPFS or CPFS for LINGJUN file system.
         *     *   It generally takes 2 to 5 minutes to create a data flow. You can call the DescribeDataFlows operation to check whether the data flow has been created.
         * *   Permissions
         *     When you create a data flow, CPFS obtains the following two service-linked roles: `AliyunServiceRoleForNasOssDataflow` and `AliyunServiceRoleForNasEventNotification`. For more information, see [CPFS service-linked roles](https://help.aliyun.com/document_detail/185138.html).
         * *   CPFS usage notes
         *     *   Billing
         *         *   If you create a data flow, you are charged for using the data flow throughput. For more information, see [Billing of CPFS](https://help.aliyun.com/document_detail/111858.html).
         *         *   When you configure the AutoRefresh feature for a data flow, CPFS must use EventBridge to collect object modification events from the source Object Storage Service (OSS) bucket. Event fees are incurred. For more information, see [Billing of EventBridge](https://help.aliyun.com/document_detail/163752.html).
         *     *   Data flow specifications
         *         *   The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.
         *         *   When you create a data flow, the vSwitch IP addresses used by a CPFS mount target are consumed. Make sure that the vSwitch can provide sufficient IP addresses.
         *         *   Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the data flow whose throughput is changed meet the requirements.
         *     *   Fileset
         *         *   The destination for a data flow is a fileset in the CPFS file system. A fileset is a new directory tree structure (a small file directory) in a CPFS file system. Each fileset independently manages an inode space.
         *         *   When you create a data flow for a CPFS file system, the related fileset must already exist and cannot be nested with other filesets. Only one data flow can be created in a fileset, which corresponds to one source storage.
         *         *   A fileset supports a maximum of one million files. If the number of files imported from an OSS bucket into the fileset exceeds the upper limit, the `no space` error message is returned when you add new files.
         *      >   If data already exists in the fileset, after you create a data flow, the existing data in the fileset is cleared and replaced with the data synchronized from the OSS bucket.
         *     *   AutoRefresh
         *         *   After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.
         *         *   AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first [activate EventBridge](https://help.aliyun.com/document_detail/182246.html).
         *         *   The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. You can configure a maximum of five AutoRefresh directories for a data flow.
         *         *   AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes `Misconfigured`. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.
         *         *   When you add an AutoRefresh configuration to the prefix for a CPFS data flow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.
         *         > The event buses and event rules created for CPFS in the EventBridge console contain the `Create for cpfs auto refresh` description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.
         *     *   Source storage
         *         *   The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.
         *         *   CPFS data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.
         *         *   If data flows for multiple CPFS file systems or multiple data flows for the same CPFS file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS file systems to one OSS bucket.
         *         *   Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
         *          >  Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS cannot access the data in the OSS bucket.
         * *   CPFS for LINGJUN usage notes
         *     *   Source storage
         *         *   The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.
         *         *   CPFS for LINGJUN data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.
         *         *   If data flows for multiple CPFS for LINGJUN file systems or multiple data flows for the same CPFS for LINGJUN file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS for LINGJUN file systems to one OSS bucket.
         *         *   Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
         *         > Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS for LINGJUN cannot access the data in the OSS bucket.
         *     *   Limits of data flows on file systems
         *         *   You cannot rename a non-empty directory in a path that is associated with a data flow. Otherwise, the Permission Denied error message or an error message indicating that the directory is not empty is returned.
         *         *   Proceed with caution when you use special characters in the names of directories and files. The following characters are supported: letters, digits, exclamation points (!), hyphens (-), underscores (_), periods (.), asterisks (\\*), and parentheses (()).
         *         *   The path can be up to 1,023 characters in length.
         *     *   Limits of data flows on import
         *         *   After a symbolic link is imported to CPFS for LINGJUN, the symbolic link is converted into a common data file that contains no symbolic link information.
         *         *   If an OSS bucket has multiple versions, only data of the latest version is used.
         *         *   The name of a file or a subdirectory can be up to 255 bytes in length.
         *     *   Limits of data flows on export
         *         *   After a symbolic link is synchronized to OSS, the file that the symbolic link points to is not synchronized to OSS. In this case, the symbolic link is converted into a common object that contains no data.
         *         *   Hard links can be synchronized to OSS only as common files that contain no link information.
         *         *   After a file of the Socket, Device, or Pipe type is exported to an OSS bucket, the file is converted into a common object that contains no data.
         *         *   The directory path can be up to 1,023 characters in length.
         *
         * @param request CreateDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataFlowResponse
         */
        public CreateDataFlowResponse CreateDataFlowWithOptions(CreateDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshInterval))
            {
                query["AutoRefreshInterval"] = request.AutoRefreshInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshPolicy))
            {
                query["AutoRefreshPolicy"] = request.AutoRefreshPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshs))
            {
                query["AutoRefreshs"] = request.AutoRefreshs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemPath))
            {
                query["FileSystemPath"] = request.FileSystemPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSecurityType))
            {
                query["SourceSecurityType"] = request.SourceSecurityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceStorage))
            {
                query["SourceStorage"] = request.SourceStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceStoragePath))
            {
                query["SourceStoragePath"] = request.SourceStoragePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Throughput))
            {
                query["Throughput"] = request.Throughput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a dataflow for a Cloud Parallel File Storage (CPFS) file system and source storage.
         *
         * @description *   Basic operations
         *     *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.4.0 and later support data flows.
         *     *   You can create a data flow only when a CPFS or CPFS for LINGJUN file system is in the Running state.
         *     *   A maximum of 10 data flows can be created for a CPFS or CPFS for LINGJUN file system.
         *     *   It generally takes 2 to 5 minutes to create a data flow. You can call the DescribeDataFlows operation to check whether the data flow has been created.
         * *   Permissions
         *     When you create a data flow, CPFS obtains the following two service-linked roles: `AliyunServiceRoleForNasOssDataflow` and `AliyunServiceRoleForNasEventNotification`. For more information, see [CPFS service-linked roles](https://help.aliyun.com/document_detail/185138.html).
         * *   CPFS usage notes
         *     *   Billing
         *         *   If you create a data flow, you are charged for using the data flow throughput. For more information, see [Billing of CPFS](https://help.aliyun.com/document_detail/111858.html).
         *         *   When you configure the AutoRefresh feature for a data flow, CPFS must use EventBridge to collect object modification events from the source Object Storage Service (OSS) bucket. Event fees are incurred. For more information, see [Billing of EventBridge](https://help.aliyun.com/document_detail/163752.html).
         *     *   Data flow specifications
         *         *   The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.
         *         *   When you create a data flow, the vSwitch IP addresses used by a CPFS mount target are consumed. Make sure that the vSwitch can provide sufficient IP addresses.
         *         *   Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the data flow whose throughput is changed meet the requirements.
         *     *   Fileset
         *         *   The destination for a data flow is a fileset in the CPFS file system. A fileset is a new directory tree structure (a small file directory) in a CPFS file system. Each fileset independently manages an inode space.
         *         *   When you create a data flow for a CPFS file system, the related fileset must already exist and cannot be nested with other filesets. Only one data flow can be created in a fileset, which corresponds to one source storage.
         *         *   A fileset supports a maximum of one million files. If the number of files imported from an OSS bucket into the fileset exceeds the upper limit, the `no space` error message is returned when you add new files.
         *      >   If data already exists in the fileset, after you create a data flow, the existing data in the fileset is cleared and replaced with the data synchronized from the OSS bucket.
         *     *   AutoRefresh
         *         *   After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.
         *         *   AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first [activate EventBridge](https://help.aliyun.com/document_detail/182246.html).
         *         *   The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. You can configure a maximum of five AutoRefresh directories for a data flow.
         *         *   AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes `Misconfigured`. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.
         *         *   When you add an AutoRefresh configuration to the prefix for a CPFS data flow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.
         *         > The event buses and event rules created for CPFS in the EventBridge console contain the `Create for cpfs auto refresh` description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.
         *     *   Source storage
         *         *   The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.
         *         *   CPFS data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.
         *         *   If data flows for multiple CPFS file systems or multiple data flows for the same CPFS file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS file systems to one OSS bucket.
         *         *   Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
         *          >  Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS cannot access the data in the OSS bucket.
         * *   CPFS for LINGJUN usage notes
         *     *   Source storage
         *         *   The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.
         *         *   CPFS for LINGJUN data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.
         *         *   If data flows for multiple CPFS for LINGJUN file systems or multiple data flows for the same CPFS for LINGJUN file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS for LINGJUN file systems to one OSS bucket.
         *         *   Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
         *         > Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS for LINGJUN cannot access the data in the OSS bucket.
         *     *   Limits of data flows on file systems
         *         *   You cannot rename a non-empty directory in a path that is associated with a data flow. Otherwise, the Permission Denied error message or an error message indicating that the directory is not empty is returned.
         *         *   Proceed with caution when you use special characters in the names of directories and files. The following characters are supported: letters, digits, exclamation points (!), hyphens (-), underscores (_), periods (.), asterisks (\\*), and parentheses (()).
         *         *   The path can be up to 1,023 characters in length.
         *     *   Limits of data flows on import
         *         *   After a symbolic link is imported to CPFS for LINGJUN, the symbolic link is converted into a common data file that contains no symbolic link information.
         *         *   If an OSS bucket has multiple versions, only data of the latest version is used.
         *         *   The name of a file or a subdirectory can be up to 255 bytes in length.
         *     *   Limits of data flows on export
         *         *   After a symbolic link is synchronized to OSS, the file that the symbolic link points to is not synchronized to OSS. In this case, the symbolic link is converted into a common object that contains no data.
         *         *   Hard links can be synchronized to OSS only as common files that contain no link information.
         *         *   After a file of the Socket, Device, or Pipe type is exported to an OSS bucket, the file is converted into a common object that contains no data.
         *         *   The directory path can be up to 1,023 characters in length.
         *
         * @param request CreateDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataFlowResponse
         */
        public async Task<CreateDataFlowResponse> CreateDataFlowWithOptionsAsync(CreateDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshInterval))
            {
                query["AutoRefreshInterval"] = request.AutoRefreshInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshPolicy))
            {
                query["AutoRefreshPolicy"] = request.AutoRefreshPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshs))
            {
                query["AutoRefreshs"] = request.AutoRefreshs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemPath))
            {
                query["FileSystemPath"] = request.FileSystemPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSecurityType))
            {
                query["SourceSecurityType"] = request.SourceSecurityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceStorage))
            {
                query["SourceStorage"] = request.SourceStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceStoragePath))
            {
                query["SourceStoragePath"] = request.SourceStoragePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Throughput))
            {
                query["Throughput"] = request.Throughput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a dataflow for a Cloud Parallel File Storage (CPFS) file system and source storage.
         *
         * @description *   Basic operations
         *     *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.4.0 and later support data flows.
         *     *   You can create a data flow only when a CPFS or CPFS for LINGJUN file system is in the Running state.
         *     *   A maximum of 10 data flows can be created for a CPFS or CPFS for LINGJUN file system.
         *     *   It generally takes 2 to 5 minutes to create a data flow. You can call the DescribeDataFlows operation to check whether the data flow has been created.
         * *   Permissions
         *     When you create a data flow, CPFS obtains the following two service-linked roles: `AliyunServiceRoleForNasOssDataflow` and `AliyunServiceRoleForNasEventNotification`. For more information, see [CPFS service-linked roles](https://help.aliyun.com/document_detail/185138.html).
         * *   CPFS usage notes
         *     *   Billing
         *         *   If you create a data flow, you are charged for using the data flow throughput. For more information, see [Billing of CPFS](https://help.aliyun.com/document_detail/111858.html).
         *         *   When you configure the AutoRefresh feature for a data flow, CPFS must use EventBridge to collect object modification events from the source Object Storage Service (OSS) bucket. Event fees are incurred. For more information, see [Billing of EventBridge](https://help.aliyun.com/document_detail/163752.html).
         *     *   Data flow specifications
         *         *   The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.
         *         *   When you create a data flow, the vSwitch IP addresses used by a CPFS mount target are consumed. Make sure that the vSwitch can provide sufficient IP addresses.
         *         *   Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the data flow whose throughput is changed meet the requirements.
         *     *   Fileset
         *         *   The destination for a data flow is a fileset in the CPFS file system. A fileset is a new directory tree structure (a small file directory) in a CPFS file system. Each fileset independently manages an inode space.
         *         *   When you create a data flow for a CPFS file system, the related fileset must already exist and cannot be nested with other filesets. Only one data flow can be created in a fileset, which corresponds to one source storage.
         *         *   A fileset supports a maximum of one million files. If the number of files imported from an OSS bucket into the fileset exceeds the upper limit, the `no space` error message is returned when you add new files.
         *      >   If data already exists in the fileset, after you create a data flow, the existing data in the fileset is cleared and replaced with the data synchronized from the OSS bucket.
         *     *   AutoRefresh
         *         *   After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.
         *         *   AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first [activate EventBridge](https://help.aliyun.com/document_detail/182246.html).
         *         *   The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. You can configure a maximum of five AutoRefresh directories for a data flow.
         *         *   AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes `Misconfigured`. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.
         *         *   When you add an AutoRefresh configuration to the prefix for a CPFS data flow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.
         *         > The event buses and event rules created for CPFS in the EventBridge console contain the `Create for cpfs auto refresh` description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.
         *     *   Source storage
         *         *   The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.
         *         *   CPFS data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.
         *         *   If data flows for multiple CPFS file systems or multiple data flows for the same CPFS file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS file systems to one OSS bucket.
         *         *   Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
         *          >  Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS cannot access the data in the OSS bucket.
         * *   CPFS for LINGJUN usage notes
         *     *   Source storage
         *         *   The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.
         *         *   CPFS for LINGJUN data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.
         *         *   If data flows for multiple CPFS for LINGJUN file systems or multiple data flows for the same CPFS for LINGJUN file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS for LINGJUN file systems to one OSS bucket.
         *         *   Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
         *         > Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS for LINGJUN cannot access the data in the OSS bucket.
         *     *   Limits of data flows on file systems
         *         *   You cannot rename a non-empty directory in a path that is associated with a data flow. Otherwise, the Permission Denied error message or an error message indicating that the directory is not empty is returned.
         *         *   Proceed with caution when you use special characters in the names of directories and files. The following characters are supported: letters, digits, exclamation points (!), hyphens (-), underscores (_), periods (.), asterisks (\\*), and parentheses (()).
         *         *   The path can be up to 1,023 characters in length.
         *     *   Limits of data flows on import
         *         *   After a symbolic link is imported to CPFS for LINGJUN, the symbolic link is converted into a common data file that contains no symbolic link information.
         *         *   If an OSS bucket has multiple versions, only data of the latest version is used.
         *         *   The name of a file or a subdirectory can be up to 255 bytes in length.
         *     *   Limits of data flows on export
         *         *   After a symbolic link is synchronized to OSS, the file that the symbolic link points to is not synchronized to OSS. In this case, the symbolic link is converted into a common object that contains no data.
         *         *   Hard links can be synchronized to OSS only as common files that contain no link information.
         *         *   After a file of the Socket, Device, or Pipe type is exported to an OSS bucket, the file is converted into a common object that contains no data.
         *         *   The directory path can be up to 1,023 characters in length.
         *
         * @param request CreateDataFlowRequest
         * @return CreateDataFlowResponse
         */
        public CreateDataFlowResponse CreateDataFlow(CreateDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataFlowWithOptions(request, runtime);
        }

        /**
         * @summary Creates a dataflow for a Cloud Parallel File Storage (CPFS) file system and source storage.
         *
         * @description *   Basic operations
         *     *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.4.0 and later support data flows.
         *     *   You can create a data flow only when a CPFS or CPFS for LINGJUN file system is in the Running state.
         *     *   A maximum of 10 data flows can be created for a CPFS or CPFS for LINGJUN file system.
         *     *   It generally takes 2 to 5 minutes to create a data flow. You can call the DescribeDataFlows operation to check whether the data flow has been created.
         * *   Permissions
         *     When you create a data flow, CPFS obtains the following two service-linked roles: `AliyunServiceRoleForNasOssDataflow` and `AliyunServiceRoleForNasEventNotification`. For more information, see [CPFS service-linked roles](https://help.aliyun.com/document_detail/185138.html).
         * *   CPFS usage notes
         *     *   Billing
         *         *   If you create a data flow, you are charged for using the data flow throughput. For more information, see [Billing of CPFS](https://help.aliyun.com/document_detail/111858.html).
         *         *   When you configure the AutoRefresh feature for a data flow, CPFS must use EventBridge to collect object modification events from the source Object Storage Service (OSS) bucket. Event fees are incurred. For more information, see [Billing of EventBridge](https://help.aliyun.com/document_detail/163752.html).
         *     *   Data flow specifications
         *         *   The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.
         *         *   When you create a data flow, the vSwitch IP addresses used by a CPFS mount target are consumed. Make sure that the vSwitch can provide sufficient IP addresses.
         *         *   Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the data flow whose throughput is changed meet the requirements.
         *     *   Fileset
         *         *   The destination for a data flow is a fileset in the CPFS file system. A fileset is a new directory tree structure (a small file directory) in a CPFS file system. Each fileset independently manages an inode space.
         *         *   When you create a data flow for a CPFS file system, the related fileset must already exist and cannot be nested with other filesets. Only one data flow can be created in a fileset, which corresponds to one source storage.
         *         *   A fileset supports a maximum of one million files. If the number of files imported from an OSS bucket into the fileset exceeds the upper limit, the `no space` error message is returned when you add new files.
         *      >   If data already exists in the fileset, after you create a data flow, the existing data in the fileset is cleared and replaced with the data synchronized from the OSS bucket.
         *     *   AutoRefresh
         *         *   After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.
         *         *   AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first [activate EventBridge](https://help.aliyun.com/document_detail/182246.html).
         *         *   The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. You can configure a maximum of five AutoRefresh directories for a data flow.
         *         *   AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes `Misconfigured`. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.
         *         *   When you add an AutoRefresh configuration to the prefix for a CPFS data flow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.
         *         > The event buses and event rules created for CPFS in the EventBridge console contain the `Create for cpfs auto refresh` description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.
         *     *   Source storage
         *         *   The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.
         *         *   CPFS data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.
         *         *   If data flows for multiple CPFS file systems or multiple data flows for the same CPFS file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS file systems to one OSS bucket.
         *         *   Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
         *          >  Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS cannot access the data in the OSS bucket.
         * *   CPFS for LINGJUN usage notes
         *     *   Source storage
         *         *   The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.
         *         *   CPFS for LINGJUN data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.
         *         *   If data flows for multiple CPFS for LINGJUN file systems or multiple data flows for the same CPFS for LINGJUN file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS for LINGJUN file systems to one OSS bucket.
         *         *   Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
         *         > Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS for LINGJUN cannot access the data in the OSS bucket.
         *     *   Limits of data flows on file systems
         *         *   You cannot rename a non-empty directory in a path that is associated with a data flow. Otherwise, the Permission Denied error message or an error message indicating that the directory is not empty is returned.
         *         *   Proceed with caution when you use special characters in the names of directories and files. The following characters are supported: letters, digits, exclamation points (!), hyphens (-), underscores (_), periods (.), asterisks (\\*), and parentheses (()).
         *         *   The path can be up to 1,023 characters in length.
         *     *   Limits of data flows on import
         *         *   After a symbolic link is imported to CPFS for LINGJUN, the symbolic link is converted into a common data file that contains no symbolic link information.
         *         *   If an OSS bucket has multiple versions, only data of the latest version is used.
         *         *   The name of a file or a subdirectory can be up to 255 bytes in length.
         *     *   Limits of data flows on export
         *         *   After a symbolic link is synchronized to OSS, the file that the symbolic link points to is not synchronized to OSS. In this case, the symbolic link is converted into a common object that contains no data.
         *         *   Hard links can be synchronized to OSS only as common files that contain no link information.
         *         *   After a file of the Socket, Device, or Pipe type is exported to an OSS bucket, the file is converted into a common object that contains no data.
         *         *   The directory path can be up to 1,023 characters in length.
         *
         * @param request CreateDataFlowRequest
         * @return CreateDataFlowResponse
         */
        public async Task<CreateDataFlowResponse> CreateDataFlowAsync(CreateDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a dataflow task.
         *
         * @description *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.3.4 and later support data flows. You can view the version information on the file system details page in the console.
         * *   You can create a data flow task only for a data flow that is in the Running state.
         * *   Data flow tasks are executed asynchronously. You can call the [DescribeDataFlowTasks](https://help.aliyun.com/document_detail/336914.html) operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.
         * *   When you manually run a data flow task, the automatic data update task for the data flow is interrupted and enters the pending state.
         * *   When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS or CPFS for LINGJUN file system does not exceed 1,023 characters.
         *
         * @param request CreateDataFlowTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataFlowTaskResponse
         */
        public CreateDataFlowTaskResponse CreateDataFlowTaskWithOptions(CreateDataFlowTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConflictPolicy))
            {
                query["ConflictPolicy"] = request.ConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateDirIfNotExist))
            {
                query["CreateDirIfNotExist"] = request.CreateDirIfNotExist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Directory))
            {
                query["Directory"] = request.Directory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDirectory))
            {
                query["DstDirectory"] = request.DstDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryList))
            {
                query["EntryList"] = request.EntryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTaskId))
            {
                query["SrcTaskId"] = request.SrcTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAction))
            {
                query["TaskAction"] = request.TaskAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataFlowTask",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataFlowTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a dataflow task.
         *
         * @description *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.3.4 and later support data flows. You can view the version information on the file system details page in the console.
         * *   You can create a data flow task only for a data flow that is in the Running state.
         * *   Data flow tasks are executed asynchronously. You can call the [DescribeDataFlowTasks](https://help.aliyun.com/document_detail/336914.html) operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.
         * *   When you manually run a data flow task, the automatic data update task for the data flow is interrupted and enters the pending state.
         * *   When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS or CPFS for LINGJUN file system does not exceed 1,023 characters.
         *
         * @param request CreateDataFlowTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataFlowTaskResponse
         */
        public async Task<CreateDataFlowTaskResponse> CreateDataFlowTaskWithOptionsAsync(CreateDataFlowTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConflictPolicy))
            {
                query["ConflictPolicy"] = request.ConflictPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateDirIfNotExist))
            {
                query["CreateDirIfNotExist"] = request.CreateDirIfNotExist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Directory))
            {
                query["Directory"] = request.Directory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDirectory))
            {
                query["DstDirectory"] = request.DstDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryList))
            {
                query["EntryList"] = request.EntryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTaskId))
            {
                query["SrcTaskId"] = request.SrcTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAction))
            {
                query["TaskAction"] = request.TaskAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataFlowTask",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataFlowTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a dataflow task.
         *
         * @description *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.3.4 and later support data flows. You can view the version information on the file system details page in the console.
         * *   You can create a data flow task only for a data flow that is in the Running state.
         * *   Data flow tasks are executed asynchronously. You can call the [DescribeDataFlowTasks](https://help.aliyun.com/document_detail/336914.html) operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.
         * *   When you manually run a data flow task, the automatic data update task for the data flow is interrupted and enters the pending state.
         * *   When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS or CPFS for LINGJUN file system does not exceed 1,023 characters.
         *
         * @param request CreateDataFlowTaskRequest
         * @return CreateDataFlowTaskResponse
         */
        public CreateDataFlowTaskResponse CreateDataFlowTask(CreateDataFlowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataFlowTaskWithOptions(request, runtime);
        }

        /**
         * @summary Creates a dataflow task.
         *
         * @description *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.3.4 and later support data flows. You can view the version information on the file system details page in the console.
         * *   You can create a data flow task only for a data flow that is in the Running state.
         * *   Data flow tasks are executed asynchronously. You can call the [DescribeDataFlowTasks](https://help.aliyun.com/document_detail/336914.html) operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.
         * *   When you manually run a data flow task, the automatic data update task for the data flow is interrupted and enters the pending state.
         * *   When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS or CPFS for LINGJUN file system does not exceed 1,023 characters.
         *
         * @param request CreateDataFlowTaskRequest
         * @return CreateDataFlowTaskResponse
         */
        public async Task<CreateDataFlowTaskResponse> CreateDataFlowTaskAsync(CreateDataFlowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataFlowTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a directory in a file system.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request CreateDirRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDirResponse
         */
        public CreateDirResponse CreateDirWithOptions(CreateDirRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerGroupId))
            {
                query["OwnerGroupId"] = request.OwnerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                query["Permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursion))
            {
                query["Recursion"] = request.Recursion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootDirectory))
            {
                query["RootDirectory"] = request.RootDirectory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDir",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDirResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a directory in a file system.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request CreateDirRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDirResponse
         */
        public async Task<CreateDirResponse> CreateDirWithOptionsAsync(CreateDirRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerGroupId))
            {
                query["OwnerGroupId"] = request.OwnerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                query["Permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursion))
            {
                query["Recursion"] = request.Recursion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootDirectory))
            {
                query["RootDirectory"] = request.RootDirectory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDir",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDirResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a directory in a file system.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request CreateDirRequest
         * @return CreateDirResponse
         */
        public CreateDirResponse CreateDir(CreateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDirWithOptions(request, runtime);
        }

        /**
         * @summary Creates a directory in a file system.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request CreateDirRequest
         * @return CreateDirResponse
         */
        public async Task<CreateDirResponse> CreateDirAsync(CreateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDirWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a directory or file.
         *
         * @description *   This operation is only available to some users.
         * *   This operation supports only General-purpose NAS file systems that use the Server Message Block (SMB) protocol and have Resource Access Management (RAM) enabled.
         *
         * @param request CreateFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileResponse
         */
        public CreateFileResponse CreateFileWithOptions(CreateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccessInheritable))
            {
                query["OwnerAccessInheritable"] = request.OwnerAccessInheritable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFile",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a directory or file.
         *
         * @description *   This operation is only available to some users.
         * *   This operation supports only General-purpose NAS file systems that use the Server Message Block (SMB) protocol and have Resource Access Management (RAM) enabled.
         *
         * @param request CreateFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileResponse
         */
        public async Task<CreateFileResponse> CreateFileWithOptionsAsync(CreateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccessInheritable))
            {
                query["OwnerAccessInheritable"] = request.OwnerAccessInheritable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFile",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a directory or file.
         *
         * @description *   This operation is only available to some users.
         * *   This operation supports only General-purpose NAS file systems that use the Server Message Block (SMB) protocol and have Resource Access Management (RAM) enabled.
         *
         * @param request CreateFileRequest
         * @return CreateFileResponse
         */
        public CreateFileResponse CreateFile(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileWithOptions(request, runtime);
        }

        /**
         * @summary Creates a directory or file.
         *
         * @description *   This operation is only available to some users.
         * *   This operation supports only General-purpose NAS file systems that use the Server Message Block (SMB) protocol and have Resource Access Management (RAM) enabled.
         *
         * @param request CreateFileRequest
         * @return CreateFileResponse
         */
        public async Task<CreateFileResponse> CreateFileAsync(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a file system.
         *
         * @description *   Before you call this operation, you must understand the billing and pricing of Apsara File Storage NAS. For more information, see [Billing](https://help.aliyun.com/document_detail/178365.html) and [Pricing](https://www.alibabacloud.com/product/nas/pricing).
         * *   Before you create a file system, you must complete real-name verification.
         * *   When you call this operation, a service-linked role of NAS is automatically created. For more information, see [Manage the service-linked roles of NAS](https://help.aliyun.com/document_detail/208530.html).
         *
         * @param request CreateFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileSystemResponse
         */
        public CreateFileSystemResponse CreateFileSystemWithOptions(CreateFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                query["KmsKeyId"] = request.KmsKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a file system.
         *
         * @description *   Before you call this operation, you must understand the billing and pricing of Apsara File Storage NAS. For more information, see [Billing](https://help.aliyun.com/document_detail/178365.html) and [Pricing](https://www.alibabacloud.com/product/nas/pricing).
         * *   Before you create a file system, you must complete real-name verification.
         * *   When you call this operation, a service-linked role of NAS is automatically created. For more information, see [Manage the service-linked roles of NAS](https://help.aliyun.com/document_detail/208530.html).
         *
         * @param request CreateFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileSystemResponse
         */
        public async Task<CreateFileSystemResponse> CreateFileSystemWithOptionsAsync(CreateFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                query["KmsKeyId"] = request.KmsKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a file system.
         *
         * @description *   Before you call this operation, you must understand the billing and pricing of Apsara File Storage NAS. For more information, see [Billing](https://help.aliyun.com/document_detail/178365.html) and [Pricing](https://www.alibabacloud.com/product/nas/pricing).
         * *   Before you create a file system, you must complete real-name verification.
         * *   When you call this operation, a service-linked role of NAS is automatically created. For more information, see [Manage the service-linked roles of NAS](https://help.aliyun.com/document_detail/208530.html).
         *
         * @param request CreateFileSystemRequest
         * @return CreateFileSystemResponse
         */
        public CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileSystemWithOptions(request, runtime);
        }

        /**
         * @summary Creates a file system.
         *
         * @description *   Before you call this operation, you must understand the billing and pricing of Apsara File Storage NAS. For more information, see [Billing](https://help.aliyun.com/document_detail/178365.html) and [Pricing](https://www.alibabacloud.com/product/nas/pricing).
         * *   Before you create a file system, you must complete real-name verification.
         * *   When you call this operation, a service-linked role of NAS is automatically created. For more information, see [Manage the service-linked roles of NAS](https://help.aliyun.com/document_detail/208530.html).
         *
         * @param request CreateFileSystemRequest
         * @return CreateFileSystemResponse
         */
        public async Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileSystemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset creation. You can view the version information on the file system details page in the console.
         * *   A maximum of 10 filesets can be created for a CPFS file system.
         * *   The maximum depth supported by a fileset is eight levels. The depth of the root directory / is 0 levels. For example, the /test/aaa/ccc/ fileset has three levels.
         * *   Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset.
         * *   A fileset supports a maximum of one million files. If the number of files exceeds the upper limit, the `no space` error message is returned when you add new files.
         *
         * @param request CreateFilesetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFilesetResponse
         */
        public CreateFilesetResponse CreateFilesetWithOptions(CreateFilesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemPath))
            {
                query["FileSystemPath"] = request.FileSystemPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileset",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFilesetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset creation. You can view the version information on the file system details page in the console.
         * *   A maximum of 10 filesets can be created for a CPFS file system.
         * *   The maximum depth supported by a fileset is eight levels. The depth of the root directory / is 0 levels. For example, the /test/aaa/ccc/ fileset has three levels.
         * *   Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset.
         * *   A fileset supports a maximum of one million files. If the number of files exceeds the upper limit, the `no space` error message is returned when you add new files.
         *
         * @param request CreateFilesetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFilesetResponse
         */
        public async Task<CreateFilesetResponse> CreateFilesetWithOptionsAsync(CreateFilesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemPath))
            {
                query["FileSystemPath"] = request.FileSystemPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileset",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFilesetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset creation. You can view the version information on the file system details page in the console.
         * *   A maximum of 10 filesets can be created for a CPFS file system.
         * *   The maximum depth supported by a fileset is eight levels. The depth of the root directory / is 0 levels. For example, the /test/aaa/ccc/ fileset has three levels.
         * *   Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset.
         * *   A fileset supports a maximum of one million files. If the number of files exceeds the upper limit, the `no space` error message is returned when you add new files.
         *
         * @param request CreateFilesetRequest
         * @return CreateFilesetResponse
         */
        public CreateFilesetResponse CreateFileset(CreateFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFilesetWithOptions(request, runtime);
        }

        /**
         * @summary Creates a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset creation. You can view the version information on the file system details page in the console.
         * *   A maximum of 10 filesets can be created for a CPFS file system.
         * *   The maximum depth supported by a fileset is eight levels. The depth of the root directory / is 0 levels. For example, the /test/aaa/ccc/ fileset has three levels.
         * *   Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset.
         * *   A fileset supports a maximum of one million files. If the number of files exceeds the upper limit, the `no space` error message is returned when you add new files.
         *
         * @param request CreateFilesetRequest
         * @return CreateFilesetResponse
         */
        public async Task<CreateFilesetResponse> CreateFilesetAsync(CreateFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFilesetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates LDAP configurations.
         *
         * @param request CreateLDAPConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLDAPConfigResponse
         */
        public CreateLDAPConfigResponse CreateLDAPConfigWithOptions(CreateLDAPConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindDN))
            {
                query["BindDN"] = request.BindDN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchBase))
            {
                query["SearchBase"] = request.SearchBase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLDAPConfig",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLDAPConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates LDAP configurations.
         *
         * @param request CreateLDAPConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLDAPConfigResponse
         */
        public async Task<CreateLDAPConfigResponse> CreateLDAPConfigWithOptionsAsync(CreateLDAPConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindDN))
            {
                query["BindDN"] = request.BindDN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchBase))
            {
                query["SearchBase"] = request.SearchBase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLDAPConfig",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLDAPConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates LDAP configurations.
         *
         * @param request CreateLDAPConfigRequest
         * @return CreateLDAPConfigResponse
         */
        public CreateLDAPConfigResponse CreateLDAPConfig(CreateLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLDAPConfigWithOptions(request, runtime);
        }

        /**
         * @summary Creates LDAP configurations.
         *
         * @param request CreateLDAPConfigRequest
         * @return CreateLDAPConfigResponse
         */
        public async Task<CreateLDAPConfigResponse> CreateLDAPConfigAsync(CreateLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLDAPConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a lifecycle policy.
         *
         * @description *   You can create lifecycle policies only for General-purpose NAS file systems.
         * *   You can create up to 20 lifecycle policies in each region within an Alibaba Cloud account.
         *
         * @param request CreateLifecyclePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLifecyclePolicyResponse
         */
        public CreateLifecyclePolicyResponse CreateLifecyclePolicyWithOptions(CreateLifecyclePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyName))
            {
                query["LifecyclePolicyName"] = request.LifecyclePolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleRuleName))
            {
                query["LifecycleRuleName"] = request.LifecycleRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paths))
            {
                query["Paths"] = request.Paths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLifecyclePolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLifecyclePolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a lifecycle policy.
         *
         * @description *   You can create lifecycle policies only for General-purpose NAS file systems.
         * *   You can create up to 20 lifecycle policies in each region within an Alibaba Cloud account.
         *
         * @param request CreateLifecyclePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLifecyclePolicyResponse
         */
        public async Task<CreateLifecyclePolicyResponse> CreateLifecyclePolicyWithOptionsAsync(CreateLifecyclePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyName))
            {
                query["LifecyclePolicyName"] = request.LifecyclePolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleRuleName))
            {
                query["LifecycleRuleName"] = request.LifecycleRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paths))
            {
                query["Paths"] = request.Paths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLifecyclePolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLifecyclePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a lifecycle policy.
         *
         * @description *   You can create lifecycle policies only for General-purpose NAS file systems.
         * *   You can create up to 20 lifecycle policies in each region within an Alibaba Cloud account.
         *
         * @param request CreateLifecyclePolicyRequest
         * @return CreateLifecyclePolicyResponse
         */
        public CreateLifecyclePolicyResponse CreateLifecyclePolicy(CreateLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLifecyclePolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a lifecycle policy.
         *
         * @description *   You can create lifecycle policies only for General-purpose NAS file systems.
         * *   You can create up to 20 lifecycle policies in each region within an Alibaba Cloud account.
         *
         * @param request CreateLifecyclePolicyRequest
         * @return CreateLifecyclePolicyResponse
         */
        public async Task<CreateLifecyclePolicyResponse> CreateLifecyclePolicyAsync(CreateLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLifecyclePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a data retrieval task.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can run a maximum of 20 data retrieval tasks in each region within an Alibaba Cloud account.
         *
         * @param request CreateLifecycleRetrieveJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLifecycleRetrieveJobResponse
         */
        public CreateLifecycleRetrieveJobResponse CreateLifecycleRetrieveJobWithOptions(CreateLifecycleRetrieveJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paths))
            {
                query["Paths"] = request.Paths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLifecycleRetrieveJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLifecycleRetrieveJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a data retrieval task.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can run a maximum of 20 data retrieval tasks in each region within an Alibaba Cloud account.
         *
         * @param request CreateLifecycleRetrieveJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLifecycleRetrieveJobResponse
         */
        public async Task<CreateLifecycleRetrieveJobResponse> CreateLifecycleRetrieveJobWithOptionsAsync(CreateLifecycleRetrieveJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paths))
            {
                query["Paths"] = request.Paths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLifecycleRetrieveJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLifecycleRetrieveJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a data retrieval task.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can run a maximum of 20 data retrieval tasks in each region within an Alibaba Cloud account.
         *
         * @param request CreateLifecycleRetrieveJobRequest
         * @return CreateLifecycleRetrieveJobResponse
         */
        public CreateLifecycleRetrieveJobResponse CreateLifecycleRetrieveJob(CreateLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLifecycleRetrieveJobWithOptions(request, runtime);
        }

        /**
         * @summary Creates a data retrieval task.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can run a maximum of 20 data retrieval tasks in each region within an Alibaba Cloud account.
         *
         * @param request CreateLifecycleRetrieveJobRequest
         * @return CreateLifecycleRetrieveJobResponse
         */
        public async Task<CreateLifecycleRetrieveJobResponse> CreateLifecycleRetrieveJobAsync(CreateLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLifecycleRetrieveJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Dumps the logs of a General-purpose NAS file system to Simple Log Service.
         *
         * @param request CreateLogAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLogAnalysisResponse
         */
        public CreateLogAnalysisResponse CreateLogAnalysisWithOptions(CreateLogAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogAnalysis",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLogAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Dumps the logs of a General-purpose NAS file system to Simple Log Service.
         *
         * @param request CreateLogAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLogAnalysisResponse
         */
        public async Task<CreateLogAnalysisResponse> CreateLogAnalysisWithOptionsAsync(CreateLogAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogAnalysis",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLogAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Dumps the logs of a General-purpose NAS file system to Simple Log Service.
         *
         * @param request CreateLogAnalysisRequest
         * @return CreateLogAnalysisResponse
         */
        public CreateLogAnalysisResponse CreateLogAnalysis(CreateLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLogAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary Dumps the logs of a General-purpose NAS file system to Simple Log Service.
         *
         * @param request CreateLogAnalysisRequest
         * @return CreateLogAnalysisResponse
         */
        public async Task<CreateLogAnalysisResponse> CreateLogAnalysisAsync(CreateLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLogAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a mount target.
         *
         * @description *   After you call the CreateMountTarget operation, a mount target is not immediately created. Therefore, we recommend that you call the DescribeMountTargets operation to query the status of the mount target. If the mount target is in the **Active** state, you can then mount the file system. Otherwise, the file system may fail to be mounted.
         * *   When you call this operation, a service-linked role of NAS is automatically created. For more information, see [Manage the service-linked roles of NAS](https://help.aliyun.com/document_detail/208530.html).
         *
         * @param request CreateMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMountTargetResponse
         */
        public CreateMountTargetResponse CreateMountTargetWithOptions(CreateMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIpv6))
            {
                query["EnableIpv6"] = request.EnableIpv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMountTargetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a mount target.
         *
         * @description *   After you call the CreateMountTarget operation, a mount target is not immediately created. Therefore, we recommend that you call the DescribeMountTargets operation to query the status of the mount target. If the mount target is in the **Active** state, you can then mount the file system. Otherwise, the file system may fail to be mounted.
         * *   When you call this operation, a service-linked role of NAS is automatically created. For more information, see [Manage the service-linked roles of NAS](https://help.aliyun.com/document_detail/208530.html).
         *
         * @param request CreateMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMountTargetResponse
         */
        public async Task<CreateMountTargetResponse> CreateMountTargetWithOptionsAsync(CreateMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIpv6))
            {
                query["EnableIpv6"] = request.EnableIpv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMountTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a mount target.
         *
         * @description *   After you call the CreateMountTarget operation, a mount target is not immediately created. Therefore, we recommend that you call the DescribeMountTargets operation to query the status of the mount target. If the mount target is in the **Active** state, you can then mount the file system. Otherwise, the file system may fail to be mounted.
         * *   When you call this operation, a service-linked role of NAS is automatically created. For more information, see [Manage the service-linked roles of NAS](https://help.aliyun.com/document_detail/208530.html).
         *
         * @param request CreateMountTargetRequest
         * @return CreateMountTargetResponse
         */
        public CreateMountTargetResponse CreateMountTarget(CreateMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMountTargetWithOptions(request, runtime);
        }

        /**
         * @summary Creates a mount target.
         *
         * @description *   After you call the CreateMountTarget operation, a mount target is not immediately created. Therefore, we recommend that you call the DescribeMountTargets operation to query the status of the mount target. If the mount target is in the **Active** state, you can then mount the file system. Otherwise, the file system may fail to be mounted.
         * *   When you call this operation, a service-linked role of NAS is automatically created. For more information, see [Manage the service-linked roles of NAS](https://help.aliyun.com/document_detail/208530.html).
         *
         * @param request CreateMountTargetRequest
         * @return CreateMountTargetResponse
         */
        public async Task<CreateMountTargetResponse> CreateMountTargetAsync(CreateMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMountTargetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an export directory for a protocol service.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Prerequisites
         *     A protocol service is created.
         * *   Others
         *     *   The virtual private cloud (VPC) CIDR block of the export directory for the protocol service cannot overlap with the VPC CIDR block of the file system.
         *     *   The VPC CIDR blocks of multiple export directories of a protocol service cannot overlap.
         *     *   You can create a maximum of 10 export directories for a protocol service.
         *     *   When you create export directories for a protocol service, a maximum of 32 IP addresses that are allocated by the specified vSwitch are used. Make sure that the vSwitch can provide sufficient IP addresses.
         *
         * @param request CreateProtocolMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProtocolMountTargetResponse
         */
        public CreateProtocolMountTargetResponse CreateProtocolMountTargetWithOptions(CreateProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProtocolMountTargetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an export directory for a protocol service.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Prerequisites
         *     A protocol service is created.
         * *   Others
         *     *   The virtual private cloud (VPC) CIDR block of the export directory for the protocol service cannot overlap with the VPC CIDR block of the file system.
         *     *   The VPC CIDR blocks of multiple export directories of a protocol service cannot overlap.
         *     *   You can create a maximum of 10 export directories for a protocol service.
         *     *   When you create export directories for a protocol service, a maximum of 32 IP addresses that are allocated by the specified vSwitch are used. Make sure that the vSwitch can provide sufficient IP addresses.
         *
         * @param request CreateProtocolMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProtocolMountTargetResponse
         */
        public async Task<CreateProtocolMountTargetResponse> CreateProtocolMountTargetWithOptionsAsync(CreateProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProtocolMountTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an export directory for a protocol service.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Prerequisites
         *     A protocol service is created.
         * *   Others
         *     *   The virtual private cloud (VPC) CIDR block of the export directory for the protocol service cannot overlap with the VPC CIDR block of the file system.
         *     *   The VPC CIDR blocks of multiple export directories of a protocol service cannot overlap.
         *     *   You can create a maximum of 10 export directories for a protocol service.
         *     *   When you create export directories for a protocol service, a maximum of 32 IP addresses that are allocated by the specified vSwitch are used. Make sure that the vSwitch can provide sufficient IP addresses.
         *
         * @param request CreateProtocolMountTargetRequest
         * @return CreateProtocolMountTargetResponse
         */
        public CreateProtocolMountTargetResponse CreateProtocolMountTarget(CreateProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProtocolMountTargetWithOptions(request, runtime);
        }

        /**
         * @summary Creates an export directory for a protocol service.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Prerequisites
         *     A protocol service is created.
         * *   Others
         *     *   The virtual private cloud (VPC) CIDR block of the export directory for the protocol service cannot overlap with the VPC CIDR block of the file system.
         *     *   The VPC CIDR blocks of multiple export directories of a protocol service cannot overlap.
         *     *   You can create a maximum of 10 export directories for a protocol service.
         *     *   When you create export directories for a protocol service, a maximum of 32 IP addresses that are allocated by the specified vSwitch are used. Make sure that the vSwitch can provide sufficient IP addresses.
         *
         * @param request CreateProtocolMountTargetRequest
         * @return CreateProtocolMountTargetResponse
         */
        public async Task<CreateProtocolMountTargetResponse> CreateProtocolMountTargetAsync(CreateProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProtocolMountTargetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a protocol service for a Cloud Parallel File Storage (CPFS) file system. The creation takes about 5 to 10 minutes.
         *
         * @description *   This operation is available only to CPFS file systems on the China site (aliyun.com).
         * *   Only CPFS V2.3.0 and later support protocol services. You can query the version information of the file system by calling the [DescribeFileSystems](~~2402188.~~) operation.
         * *   Protocol service types
         *     Protocol services are classified into general-purpose protocol services and cache protocol services. Different from general-purpose protocol services, cache protocol services can cache hot data. If data exists in the cache, the bandwidth of the cache protocol service may exceed the bandwidth of the CPFS file system, reaching the maximum bandwidth specified for the protocol service.
         *     *   General-purpose protocol services: provide NFS access and [directory-level mount targets](https://help.aliyun.com/document_detail/427175.html) for CPFS file systems. You do not need to configure a POSIX client to manage clusters. General-purpose protocol services are provided free of charge.
         *     *   Cache protocol services: provide the server memory cache based on the least recently used (LRU) policy. When data is cached in the memory, CPFS provides higher internal bandwidth. Cache protocol services are divided into Cache L1 and Cache L2 specifications. The differences are the internal bandwidth size and memory cache size.
         *        >   Note You are charged for using cache protocol services, which are in invitational preview. For more information about the billing method of cache protocol services, see [Billable items](https://help.aliyun.com/document_detail/111858.html). If you have any feedback or questions, you can join the DingTalk group (group number: 31045006299).
         * *   Protocol type
         *     Only NFSv3 is supported.
         * *   Others
         *     *   Only one protocol service can be created for a CPFS file system.
         *     *   A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.
         *
         * @param request CreateProtocolServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProtocolServiceResponse
         */
        public CreateProtocolServiceResponse CreateProtocolServiceWithOptions(CreateProtocolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolSpec))
            {
                query["ProtocolSpec"] = request.ProtocolSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Throughput))
            {
                query["Throughput"] = request.Throughput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProtocolService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProtocolServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a protocol service for a Cloud Parallel File Storage (CPFS) file system. The creation takes about 5 to 10 minutes.
         *
         * @description *   This operation is available only to CPFS file systems on the China site (aliyun.com).
         * *   Only CPFS V2.3.0 and later support protocol services. You can query the version information of the file system by calling the [DescribeFileSystems](~~2402188.~~) operation.
         * *   Protocol service types
         *     Protocol services are classified into general-purpose protocol services and cache protocol services. Different from general-purpose protocol services, cache protocol services can cache hot data. If data exists in the cache, the bandwidth of the cache protocol service may exceed the bandwidth of the CPFS file system, reaching the maximum bandwidth specified for the protocol service.
         *     *   General-purpose protocol services: provide NFS access and [directory-level mount targets](https://help.aliyun.com/document_detail/427175.html) for CPFS file systems. You do not need to configure a POSIX client to manage clusters. General-purpose protocol services are provided free of charge.
         *     *   Cache protocol services: provide the server memory cache based on the least recently used (LRU) policy. When data is cached in the memory, CPFS provides higher internal bandwidth. Cache protocol services are divided into Cache L1 and Cache L2 specifications. The differences are the internal bandwidth size and memory cache size.
         *        >   Note You are charged for using cache protocol services, which are in invitational preview. For more information about the billing method of cache protocol services, see [Billable items](https://help.aliyun.com/document_detail/111858.html). If you have any feedback or questions, you can join the DingTalk group (group number: 31045006299).
         * *   Protocol type
         *     Only NFSv3 is supported.
         * *   Others
         *     *   Only one protocol service can be created for a CPFS file system.
         *     *   A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.
         *
         * @param request CreateProtocolServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProtocolServiceResponse
         */
        public async Task<CreateProtocolServiceResponse> CreateProtocolServiceWithOptionsAsync(CreateProtocolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolSpec))
            {
                query["ProtocolSpec"] = request.ProtocolSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Throughput))
            {
                query["Throughput"] = request.Throughput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProtocolService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProtocolServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a protocol service for a Cloud Parallel File Storage (CPFS) file system. The creation takes about 5 to 10 minutes.
         *
         * @description *   This operation is available only to CPFS file systems on the China site (aliyun.com).
         * *   Only CPFS V2.3.0 and later support protocol services. You can query the version information of the file system by calling the [DescribeFileSystems](~~2402188.~~) operation.
         * *   Protocol service types
         *     Protocol services are classified into general-purpose protocol services and cache protocol services. Different from general-purpose protocol services, cache protocol services can cache hot data. If data exists in the cache, the bandwidth of the cache protocol service may exceed the bandwidth of the CPFS file system, reaching the maximum bandwidth specified for the protocol service.
         *     *   General-purpose protocol services: provide NFS access and [directory-level mount targets](https://help.aliyun.com/document_detail/427175.html) for CPFS file systems. You do not need to configure a POSIX client to manage clusters. General-purpose protocol services are provided free of charge.
         *     *   Cache protocol services: provide the server memory cache based on the least recently used (LRU) policy. When data is cached in the memory, CPFS provides higher internal bandwidth. Cache protocol services are divided into Cache L1 and Cache L2 specifications. The differences are the internal bandwidth size and memory cache size.
         *        >   Note You are charged for using cache protocol services, which are in invitational preview. For more information about the billing method of cache protocol services, see [Billable items](https://help.aliyun.com/document_detail/111858.html). If you have any feedback or questions, you can join the DingTalk group (group number: 31045006299).
         * *   Protocol type
         *     Only NFSv3 is supported.
         * *   Others
         *     *   Only one protocol service can be created for a CPFS file system.
         *     *   A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.
         *
         * @param request CreateProtocolServiceRequest
         * @return CreateProtocolServiceResponse
         */
        public CreateProtocolServiceResponse CreateProtocolService(CreateProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProtocolServiceWithOptions(request, runtime);
        }

        /**
         * @summary Creates a protocol service for a Cloud Parallel File Storage (CPFS) file system. The creation takes about 5 to 10 minutes.
         *
         * @description *   This operation is available only to CPFS file systems on the China site (aliyun.com).
         * *   Only CPFS V2.3.0 and later support protocol services. You can query the version information of the file system by calling the [DescribeFileSystems](~~2402188.~~) operation.
         * *   Protocol service types
         *     Protocol services are classified into general-purpose protocol services and cache protocol services. Different from general-purpose protocol services, cache protocol services can cache hot data. If data exists in the cache, the bandwidth of the cache protocol service may exceed the bandwidth of the CPFS file system, reaching the maximum bandwidth specified for the protocol service.
         *     *   General-purpose protocol services: provide NFS access and [directory-level mount targets](https://help.aliyun.com/document_detail/427175.html) for CPFS file systems. You do not need to configure a POSIX client to manage clusters. General-purpose protocol services are provided free of charge.
         *     *   Cache protocol services: provide the server memory cache based on the least recently used (LRU) policy. When data is cached in the memory, CPFS provides higher internal bandwidth. Cache protocol services are divided into Cache L1 and Cache L2 specifications. The differences are the internal bandwidth size and memory cache size.
         *        >   Note You are charged for using cache protocol services, which are in invitational preview. For more information about the billing method of cache protocol services, see [Billable items](https://help.aliyun.com/document_detail/111858.html). If you have any feedback or questions, you can join the DingTalk group (group number: 31045006299).
         * *   Protocol type
         *     Only NFSv3 is supported.
         * *   Others
         *     *   Only one protocol service can be created for a CPFS file system.
         *     *   A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.
         *
         * @param request CreateProtocolServiceRequest
         * @return CreateProtocolServiceResponse
         */
        public async Task<CreateProtocolServiceResponse> CreateProtocolServiceAsync(CreateProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProtocolServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a job to permanently delete a file or directory from the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   If you permanently delete a directory, the files in the directory are recursively cleared.
         * *   You can run only one job at a time for a single file system to permanently delete the files from the file system. You cannot create a restoration or deletion job when a file or directory is being deleted.
         *
         * @param request CreateRecycleBinDeleteJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRecycleBinDeleteJobResponse
         */
        public CreateRecycleBinDeleteJobResponse CreateRecycleBinDeleteJobWithOptions(CreateRecycleBinDeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecycleBinDeleteJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecycleBinDeleteJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a job to permanently delete a file or directory from the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   If you permanently delete a directory, the files in the directory are recursively cleared.
         * *   You can run only one job at a time for a single file system to permanently delete the files from the file system. You cannot create a restoration or deletion job when a file or directory is being deleted.
         *
         * @param request CreateRecycleBinDeleteJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRecycleBinDeleteJobResponse
         */
        public async Task<CreateRecycleBinDeleteJobResponse> CreateRecycleBinDeleteJobWithOptionsAsync(CreateRecycleBinDeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecycleBinDeleteJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecycleBinDeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a job to permanently delete a file or directory from the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   If you permanently delete a directory, the files in the directory are recursively cleared.
         * *   You can run only one job at a time for a single file system to permanently delete the files from the file system. You cannot create a restoration or deletion job when a file or directory is being deleted.
         *
         * @param request CreateRecycleBinDeleteJobRequest
         * @return CreateRecycleBinDeleteJobResponse
         */
        public CreateRecycleBinDeleteJobResponse CreateRecycleBinDeleteJob(CreateRecycleBinDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecycleBinDeleteJobWithOptions(request, runtime);
        }

        /**
         * @summary Creates a job to permanently delete a file or directory from the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   If you permanently delete a directory, the files in the directory are recursively cleared.
         * *   You can run only one job at a time for a single file system to permanently delete the files from the file system. You cannot create a restoration or deletion job when a file or directory is being deleted.
         *
         * @param request CreateRecycleBinDeleteJobRequest
         * @return CreateRecycleBinDeleteJobResponse
         */
        public async Task<CreateRecycleBinDeleteJobResponse> CreateRecycleBinDeleteJobAsync(CreateRecycleBinDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecycleBinDeleteJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Restores a file or directory from the recycle bin.
         *
         * @description ### Usage notes
         * *   Only General-purpose NAS file systems support this operation.
         * *   You can run only one job at a time for a single file system to restore files to or clear files from the file system. You cannot create a restore or cleanup job when files are being restored from the recycle bin.
         * *   You can restore only one file or directory in a single restore job. If you restore a specified directory, all files in the directory are recursively restored.
         * *   After files are restored, the data of the files is defragmented. When the data is being defragmented, the read performance is slightly degraded.
         *
         * @param request CreateRecycleBinRestoreJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRecycleBinRestoreJobResponse
         */
        public CreateRecycleBinRestoreJobResponse CreateRecycleBinRestoreJobWithOptions(CreateRecycleBinRestoreJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecycleBinRestoreJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecycleBinRestoreJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Restores a file or directory from the recycle bin.
         *
         * @description ### Usage notes
         * *   Only General-purpose NAS file systems support this operation.
         * *   You can run only one job at a time for a single file system to restore files to or clear files from the file system. You cannot create a restore or cleanup job when files are being restored from the recycle bin.
         * *   You can restore only one file or directory in a single restore job. If you restore a specified directory, all files in the directory are recursively restored.
         * *   After files are restored, the data of the files is defragmented. When the data is being defragmented, the read performance is slightly degraded.
         *
         * @param request CreateRecycleBinRestoreJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRecycleBinRestoreJobResponse
         */
        public async Task<CreateRecycleBinRestoreJobResponse> CreateRecycleBinRestoreJobWithOptionsAsync(CreateRecycleBinRestoreJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecycleBinRestoreJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecycleBinRestoreJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Restores a file or directory from the recycle bin.
         *
         * @description ### Usage notes
         * *   Only General-purpose NAS file systems support this operation.
         * *   You can run only one job at a time for a single file system to restore files to or clear files from the file system. You cannot create a restore or cleanup job when files are being restored from the recycle bin.
         * *   You can restore only one file or directory in a single restore job. If you restore a specified directory, all files in the directory are recursively restored.
         * *   After files are restored, the data of the files is defragmented. When the data is being defragmented, the read performance is slightly degraded.
         *
         * @param request CreateRecycleBinRestoreJobRequest
         * @return CreateRecycleBinRestoreJobResponse
         */
        public CreateRecycleBinRestoreJobResponse CreateRecycleBinRestoreJob(CreateRecycleBinRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecycleBinRestoreJobWithOptions(request, runtime);
        }

        /**
         * @summary Restores a file or directory from the recycle bin.
         *
         * @description ### Usage notes
         * *   Only General-purpose NAS file systems support this operation.
         * *   You can run only one job at a time for a single file system to restore files to or clear files from the file system. You cannot create a restore or cleanup job when files are being restored from the recycle bin.
         * *   You can restore only one file or directory in a single restore job. If you restore a specified directory, all files in the directory are recursively restored.
         * *   After files are restored, the data of the files is defragmented. When the data is being defragmented, the read performance is slightly degraded.
         *
         * @param request CreateRecycleBinRestoreJobRequest
         * @return CreateRecycleBinRestoreJobResponse
         */
        public async Task<CreateRecycleBinRestoreJobResponse> CreateRecycleBinRestoreJobAsync(CreateRecycleBinRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecycleBinRestoreJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a snapshot.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   You can create a maximum of 128 snapshots for a file system.
         * *   The compute node on which a file system is mounted must function as expected. Otherwise, you cannot create a snapshot for the file system.
         * *   You can create only one snapshot for a file system at a time.
         * *   If the file system expires when a snapshot is being created, the file system is released and the snapshot is deleted.
         * *   When you create a snapshot for a file system, the I/O performance of the file system may be degraded for a short period of time. We recommend that you create snapshots during off-peak hours.
         * *   A snapshot is a backup of a file system at a specific point in time. After you create a snapshot, incremental data that is generated in the file system will not be synchronized to the snapshot.
         * *   Manually created snapshots will not be deleted until 15 days after the service is suspended due to overdue payments. We recommend that you delete unnecessary snapshots at regular intervals to prevent extra fees incurred by the snapshots.
         *
         * @param request CreateSnapshotRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSnapshotResponse
         */
        public CreateSnapshotResponse CreateSnapshotWithOptions(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSnapshot",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a snapshot.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   You can create a maximum of 128 snapshots for a file system.
         * *   The compute node on which a file system is mounted must function as expected. Otherwise, you cannot create a snapshot for the file system.
         * *   You can create only one snapshot for a file system at a time.
         * *   If the file system expires when a snapshot is being created, the file system is released and the snapshot is deleted.
         * *   When you create a snapshot for a file system, the I/O performance of the file system may be degraded for a short period of time. We recommend that you create snapshots during off-peak hours.
         * *   A snapshot is a backup of a file system at a specific point in time. After you create a snapshot, incremental data that is generated in the file system will not be synchronized to the snapshot.
         * *   Manually created snapshots will not be deleted until 15 days after the service is suspended due to overdue payments. We recommend that you delete unnecessary snapshots at regular intervals to prevent extra fees incurred by the snapshots.
         *
         * @param request CreateSnapshotRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSnapshotResponse
         */
        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSnapshot",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a snapshot.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   You can create a maximum of 128 snapshots for a file system.
         * *   The compute node on which a file system is mounted must function as expected. Otherwise, you cannot create a snapshot for the file system.
         * *   You can create only one snapshot for a file system at a time.
         * *   If the file system expires when a snapshot is being created, the file system is released and the snapshot is deleted.
         * *   When you create a snapshot for a file system, the I/O performance of the file system may be degraded for a short period of time. We recommend that you create snapshots during off-peak hours.
         * *   A snapshot is a backup of a file system at a specific point in time. After you create a snapshot, incremental data that is generated in the file system will not be synchronized to the snapshot.
         * *   Manually created snapshots will not be deleted until 15 days after the service is suspended due to overdue payments. We recommend that you delete unnecessary snapshots at regular intervals to prevent extra fees incurred by the snapshots.
         *
         * @param request CreateSnapshotRequest
         * @return CreateSnapshotResponse
         */
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSnapshotWithOptions(request, runtime);
        }

        /**
         * @summary Creates a snapshot.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   You can create a maximum of 128 snapshots for a file system.
         * *   The compute node on which a file system is mounted must function as expected. Otherwise, you cannot create a snapshot for the file system.
         * *   You can create only one snapshot for a file system at a time.
         * *   If the file system expires when a snapshot is being created, the file system is released and the snapshot is deleted.
         * *   When you create a snapshot for a file system, the I/O performance of the file system may be degraded for a short period of time. We recommend that you create snapshots during off-peak hours.
         * *   A snapshot is a backup of a file system at a specific point in time. After you create a snapshot, incremental data that is generated in the file system will not be synchronized to the snapshot.
         * *   Manually created snapshots will not be deleted until 15 days after the service is suspended due to overdue payments. We recommend that you delete unnecessary snapshots at regular intervals to prevent extra fees incurred by the snapshots.
         *
         * @param request CreateSnapshotRequest
         * @return CreateSnapshotResponse
         */
        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSnapshotWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a permission group.
         *
         * @description The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.
         *
         * @param request DeleteAccessGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessGroupResponse
         */
        public DeleteAccessGroupResponse DeleteAccessGroupWithOptions(DeleteAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessGroup",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a permission group.
         *
         * @description The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.
         *
         * @param request DeleteAccessGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessGroupResponse
         */
        public async Task<DeleteAccessGroupResponse> DeleteAccessGroupWithOptionsAsync(DeleteAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessGroup",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a permission group.
         *
         * @description The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.
         *
         * @param request DeleteAccessGroupRequest
         * @return DeleteAccessGroupResponse
         */
        public DeleteAccessGroupResponse DeleteAccessGroup(DeleteAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a permission group.
         *
         * @description The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.
         *
         * @param request DeleteAccessGroupRequest
         * @return DeleteAccessGroupResponse
         */
        public async Task<DeleteAccessGroupResponse> DeleteAccessGroupAsync(DeleteAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an access point.
         *
         * @description *   Only General-purpose Network File System (NFS) file systems support access points.
         * *   After an access point is deleted, all I/O operations that are being performed on the directory accessed over the access point are interrupted immediately. Exercise caution when you perform this operation.
         *
         * @param request DeleteAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessPointResponse
         */
        public DeleteAccessPointResponse DeleteAccessPointWithOptions(DeleteAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointId))
            {
                query["AccessPointId"] = request.AccessPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessPoint",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessPointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an access point.
         *
         * @description *   Only General-purpose Network File System (NFS) file systems support access points.
         * *   After an access point is deleted, all I/O operations that are being performed on the directory accessed over the access point are interrupted immediately. Exercise caution when you perform this operation.
         *
         * @param request DeleteAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessPointResponse
         */
        public async Task<DeleteAccessPointResponse> DeleteAccessPointWithOptionsAsync(DeleteAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointId))
            {
                query["AccessPointId"] = request.AccessPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessPoint",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an access point.
         *
         * @description *   Only General-purpose Network File System (NFS) file systems support access points.
         * *   After an access point is deleted, all I/O operations that are being performed on the directory accessed over the access point are interrupted immediately. Exercise caution when you perform this operation.
         *
         * @param request DeleteAccessPointRequest
         * @return DeleteAccessPointResponse
         */
        public DeleteAccessPointResponse DeleteAccessPoint(DeleteAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessPointWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an access point.
         *
         * @description *   Only General-purpose Network File System (NFS) file systems support access points.
         * *   After an access point is deleted, all I/O operations that are being performed on the directory accessed over the access point are interrupted immediately. Exercise caution when you perform this operation.
         *
         * @param request DeleteAccessPointRequest
         * @return DeleteAccessPointResponse
         */
        public async Task<DeleteAccessPointResponse> DeleteAccessPointAsync(DeleteAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessPointWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a rule from a permission group.
         *
         * @description Rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.
         *
         * @param request DeleteAccessRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessRuleResponse
         */
        public DeleteAccessRuleResponse DeleteAccessRuleWithOptions(DeleteAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessRule",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a rule from a permission group.
         *
         * @description Rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.
         *
         * @param request DeleteAccessRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessRuleResponse
         */
        public async Task<DeleteAccessRuleResponse> DeleteAccessRuleWithOptionsAsync(DeleteAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessRule",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a rule from a permission group.
         *
         * @description Rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.
         *
         * @param request DeleteAccessRuleRequest
         * @return DeleteAccessRuleResponse
         */
        public DeleteAccessRuleResponse DeleteAccessRule(DeleteAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessRuleWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a rule from a permission group.
         *
         * @description Rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.
         *
         * @param request DeleteAccessRuleRequest
         * @return DeleteAccessRuleResponse
         */
        public async Task<DeleteAccessRuleResponse> DeleteAccessRuleAsync(DeleteAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an automatic snapshot policy.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   If you delete an automatic snapshot policy that is applied to a file system, snapshots for the file system are no longer created based on the policy.
         *
         * @param request DeleteAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAutoSnapshotPolicyResponse
         */
        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicyWithOptions(DeleteAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyId))
            {
                query["AutoSnapshotPolicyId"] = request.AutoSnapshotPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an automatic snapshot policy.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   If you delete an automatic snapshot policy that is applied to a file system, snapshots for the file system are no longer created based on the policy.
         *
         * @param request DeleteAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAutoSnapshotPolicyResponse
         */
        public async Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicyWithOptionsAsync(DeleteAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyId))
            {
                query["AutoSnapshotPolicyId"] = request.AutoSnapshotPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an automatic snapshot policy.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   If you delete an automatic snapshot policy that is applied to a file system, snapshots for the file system are no longer created based on the policy.
         *
         * @param request DeleteAutoSnapshotPolicyRequest
         * @return DeleteAutoSnapshotPolicyResponse
         */
        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicy(DeleteAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an automatic snapshot policy.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         * *   If you delete an automatic snapshot policy that is applied to a file system, snapshots for the file system are no longer created based on the policy.
         *
         * @param request DeleteAutoSnapshotPolicyRequest
         * @return DeleteAutoSnapshotPolicyResponse
         */
        public async Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicyAsync(DeleteAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   You can create filesets only in CPFS V2.2.0 and later. You can view the version information on the file system details page in the console.
         * *   You can delete the dataflows that are only in the `Running` or `Stopped` state.
         * *   After a dataflow is deleted, the resources related to the dataflow are released and cannot be restored. You must create a dataflow again if required.
         *
         * @param request DeleteDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataFlowResponse
         */
        public DeleteDataFlowResponse DeleteDataFlowWithOptions(DeleteDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   You can create filesets only in CPFS V2.2.0 and later. You can view the version information on the file system details page in the console.
         * *   You can delete the dataflows that are only in the `Running` or `Stopped` state.
         * *   After a dataflow is deleted, the resources related to the dataflow are released and cannot be restored. You must create a dataflow again if required.
         *
         * @param request DeleteDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataFlowResponse
         */
        public async Task<DeleteDataFlowResponse> DeleteDataFlowWithOptionsAsync(DeleteDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   You can create filesets only in CPFS V2.2.0 and later. You can view the version information on the file system details page in the console.
         * *   You can delete the dataflows that are only in the `Running` or `Stopped` state.
         * *   After a dataflow is deleted, the resources related to the dataflow are released and cannot be restored. You must create a dataflow again if required.
         *
         * @param request DeleteDataFlowRequest
         * @return DeleteDataFlowResponse
         */
        public DeleteDataFlowResponse DeleteDataFlow(DeleteDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataFlowWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   You can create filesets only in CPFS V2.2.0 and later. You can view the version information on the file system details page in the console.
         * *   You can delete the dataflows that are only in the `Running` or `Stopped` state.
         * *   After a dataflow is deleted, the resources related to the dataflow are released and cannot be restored. You must create a dataflow again if required.
         *
         * @param request DeleteDataFlowRequest
         * @return DeleteDataFlowResponse
         */
        public async Task<DeleteDataFlowResponse> DeleteDataFlowAsync(DeleteDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a file system.
         *
         * @description *   Before you delete a file system, you must delete all mount targets of the file system.
         * *   Before you delete a file system, you must make sure that no lifecycle policy is created for the file system.
         * *   After a file system is deleted, the data on the file system cannot be restored. Proceed with caution.
         *
         * @param request DeleteFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileSystemResponse
         */
        public DeleteFileSystemResponse DeleteFileSystemWithOptions(DeleteFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a file system.
         *
         * @description *   Before you delete a file system, you must delete all mount targets of the file system.
         * *   Before you delete a file system, you must make sure that no lifecycle policy is created for the file system.
         * *   After a file system is deleted, the data on the file system cannot be restored. Proceed with caution.
         *
         * @param request DeleteFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileSystemResponse
         */
        public async Task<DeleteFileSystemResponse> DeleteFileSystemWithOptionsAsync(DeleteFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a file system.
         *
         * @description *   Before you delete a file system, you must delete all mount targets of the file system.
         * *   Before you delete a file system, you must make sure that no lifecycle policy is created for the file system.
         * *   After a file system is deleted, the data on the file system cannot be restored. Proceed with caution.
         *
         * @param request DeleteFileSystemRequest
         * @return DeleteFileSystemResponse
         */
        public DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileSystemWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a file system.
         *
         * @description *   Before you delete a file system, you must delete all mount targets of the file system.
         * *   Before you delete a file system, you must make sure that no lifecycle policy is created for the file system.
         * *   After a file system is deleted, the data on the file system cannot be restored. Proceed with caution.
         *
         * @param request DeleteFileSystemRequest
         * @return DeleteFileSystemResponse
         */
        public async Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileSystemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset deletion. After you delete a fileset, all data in the fileset is deleted and cannot be restored. Proceed with caution.
         *
         * @param request DeleteFilesetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFilesetResponse
         */
        public DeleteFilesetResponse DeleteFilesetWithOptions(DeleteFilesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileset",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFilesetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset deletion. After you delete a fileset, all data in the fileset is deleted and cannot be restored. Proceed with caution.
         *
         * @param request DeleteFilesetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFilesetResponse
         */
        public async Task<DeleteFilesetResponse> DeleteFilesetWithOptionsAsync(DeleteFilesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileset",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFilesetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset deletion. After you delete a fileset, all data in the fileset is deleted and cannot be restored. Proceed with caution.
         *
         * @param request DeleteFilesetRequest
         * @return DeleteFilesetResponse
         */
        public DeleteFilesetResponse DeleteFileset(DeleteFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFilesetWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset deletion. After you delete a fileset, all data in the fileset is deleted and cannot be restored. Proceed with caution.
         *
         * @param request DeleteFilesetRequest
         * @return DeleteFilesetResponse
         */
        public async Task<DeleteFilesetResponse> DeleteFilesetAsync(DeleteFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFilesetWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteLDAPConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLDAPConfigResponse
         */
        public DeleteLDAPConfigResponse DeleteLDAPConfigWithOptions(DeleteLDAPConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLDAPConfig",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLDAPConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteLDAPConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLDAPConfigResponse
         */
        public async Task<DeleteLDAPConfigResponse> DeleteLDAPConfigWithOptionsAsync(DeleteLDAPConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLDAPConfig",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLDAPConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteLDAPConfigRequest
         * @return DeleteLDAPConfigResponse
         */
        public DeleteLDAPConfigResponse DeleteLDAPConfig(DeleteLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLDAPConfigWithOptions(request, runtime);
        }

        /**
         * @param request DeleteLDAPConfigRequest
         * @return DeleteLDAPConfigResponse
         */
        public async Task<DeleteLDAPConfigResponse> DeleteLDAPConfigAsync(DeleteLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLDAPConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a lifecycle policy.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request DeleteLifecyclePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLifecyclePolicyResponse
         */
        public DeleteLifecyclePolicyResponse DeleteLifecyclePolicyWithOptions(DeleteLifecyclePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyName))
            {
                query["LifecyclePolicyName"] = request.LifecyclePolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLifecyclePolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLifecyclePolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a lifecycle policy.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request DeleteLifecyclePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLifecyclePolicyResponse
         */
        public async Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyWithOptionsAsync(DeleteLifecyclePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyName))
            {
                query["LifecyclePolicyName"] = request.LifecyclePolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLifecyclePolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLifecyclePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a lifecycle policy.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request DeleteLifecyclePolicyRequest
         * @return DeleteLifecyclePolicyResponse
         */
        public DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLifecyclePolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a lifecycle policy.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request DeleteLifecyclePolicyRequest
         * @return DeleteLifecyclePolicyResponse
         */
        public async Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLifecyclePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables log dumping for a General-purpose NAS file system.
         *
         * @param request DeleteLogAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLogAnalysisResponse
         */
        public DeleteLogAnalysisResponse DeleteLogAnalysisWithOptions(DeleteLogAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogAnalysis",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLogAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables log dumping for a General-purpose NAS file system.
         *
         * @param request DeleteLogAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLogAnalysisResponse
         */
        public async Task<DeleteLogAnalysisResponse> DeleteLogAnalysisWithOptionsAsync(DeleteLogAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogAnalysis",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLogAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables log dumping for a General-purpose NAS file system.
         *
         * @param request DeleteLogAnalysisRequest
         * @return DeleteLogAnalysisResponse
         */
        public DeleteLogAnalysisResponse DeleteLogAnalysis(DeleteLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLogAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary Disables log dumping for a General-purpose NAS file system.
         *
         * @param request DeleteLogAnalysisRequest
         * @return DeleteLogAnalysisResponse
         */
        public async Task<DeleteLogAnalysisResponse> DeleteLogAnalysisAsync(DeleteLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLogAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a mount target.
         *
         * @description After you delete a mount target, the mount target cannot be restored. Proceed with caution.
         *
         * @param request DeleteMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMountTargetResponse
         */
        public DeleteMountTargetResponse DeleteMountTargetWithOptions(DeleteMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountTargetDomain))
            {
                query["MountTargetDomain"] = request.MountTargetDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMountTargetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a mount target.
         *
         * @description After you delete a mount target, the mount target cannot be restored. Proceed with caution.
         *
         * @param request DeleteMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMountTargetResponse
         */
        public async Task<DeleteMountTargetResponse> DeleteMountTargetWithOptionsAsync(DeleteMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountTargetDomain))
            {
                query["MountTargetDomain"] = request.MountTargetDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMountTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a mount target.
         *
         * @description After you delete a mount target, the mount target cannot be restored. Proceed with caution.
         *
         * @param request DeleteMountTargetRequest
         * @return DeleteMountTargetResponse
         */
        public DeleteMountTargetResponse DeleteMountTarget(DeleteMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMountTargetWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a mount target.
         *
         * @description After you delete a mount target, the mount target cannot be restored. Proceed with caution.
         *
         * @param request DeleteMountTargetRequest
         * @return DeleteMountTargetResponse
         */
        public async Task<DeleteMountTargetResponse> DeleteMountTargetAsync(DeleteMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMountTargetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an export directory of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DeleteProtocolMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProtocolMountTargetResponse
         */
        public DeleteProtocolMountTargetResponse DeleteProtocolMountTargetWithOptions(DeleteProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                query["ExportId"] = request.ExportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProtocolMountTargetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an export directory of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DeleteProtocolMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProtocolMountTargetResponse
         */
        public async Task<DeleteProtocolMountTargetResponse> DeleteProtocolMountTargetWithOptionsAsync(DeleteProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                query["ExportId"] = request.ExportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProtocolMountTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an export directory of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DeleteProtocolMountTargetRequest
         * @return DeleteProtocolMountTargetResponse
         */
        public DeleteProtocolMountTargetResponse DeleteProtocolMountTarget(DeleteProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProtocolMountTargetWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an export directory of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DeleteProtocolMountTargetRequest
         * @return DeleteProtocolMountTargetResponse
         */
        public async Task<DeleteProtocolMountTargetResponse> DeleteProtocolMountTargetAsync(DeleteProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProtocolMountTargetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a protocol service of a Cloud Parallel File Storage (CPFS) file system.
         *
         * @description *   This operation is available only to CPFS file systems on the China site (aliyun.com).
         * *   When you delete a protocol service, the export directories in the protocol service are also deleted.
         *
         * @param request DeleteProtocolServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProtocolServiceResponse
         */
        public DeleteProtocolServiceResponse DeleteProtocolServiceWithOptions(DeleteProtocolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProtocolService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProtocolServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a protocol service of a Cloud Parallel File Storage (CPFS) file system.
         *
         * @description *   This operation is available only to CPFS file systems on the China site (aliyun.com).
         * *   When you delete a protocol service, the export directories in the protocol service are also deleted.
         *
         * @param request DeleteProtocolServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProtocolServiceResponse
         */
        public async Task<DeleteProtocolServiceResponse> DeleteProtocolServiceWithOptionsAsync(DeleteProtocolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProtocolService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProtocolServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a protocol service of a Cloud Parallel File Storage (CPFS) file system.
         *
         * @description *   This operation is available only to CPFS file systems on the China site (aliyun.com).
         * *   When you delete a protocol service, the export directories in the protocol service are also deleted.
         *
         * @param request DeleteProtocolServiceRequest
         * @return DeleteProtocolServiceResponse
         */
        public DeleteProtocolServiceResponse DeleteProtocolService(DeleteProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProtocolServiceWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a protocol service of a Cloud Parallel File Storage (CPFS) file system.
         *
         * @description *   This operation is available only to CPFS file systems on the China site (aliyun.com).
         * *   When you delete a protocol service, the export directories in the protocol service are also deleted.
         *
         * @param request DeleteProtocolServiceRequest
         * @return DeleteProtocolServiceResponse
         */
        public async Task<DeleteProtocolServiceResponse> DeleteProtocolServiceAsync(DeleteProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProtocolServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a snapshot or cancels a snapshot that is being created.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DeleteSnapshotRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSnapshotResponse
         */
        public DeleteSnapshotResponse DeleteSnapshotWithOptions(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a snapshot or cancels a snapshot that is being created.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DeleteSnapshotRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSnapshotResponse
         */
        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a snapshot or cancels a snapshot that is being created.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DeleteSnapshotRequest
         * @return DeleteSnapshotResponse
         */
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a snapshot or cancels a snapshot that is being created.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DeleteSnapshotRequest
         * @return DeleteSnapshotResponse
         */
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries permission groups.
         *
         * @param request DescribeAccessGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessGroupsResponse
         */
        public DescribeAccessGroupsResponse DescribeAccessGroupsWithOptions(DescribeAccessGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUTCDateTime))
            {
                query["UseUTCDateTime"] = request.UseUTCDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessGroups",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries permission groups.
         *
         * @param request DescribeAccessGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessGroupsResponse
         */
        public async Task<DescribeAccessGroupsResponse> DescribeAccessGroupsWithOptionsAsync(DescribeAccessGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUTCDateTime))
            {
                query["UseUTCDateTime"] = request.UseUTCDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessGroups",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries permission groups.
         *
         * @param request DescribeAccessGroupsRequest
         * @return DescribeAccessGroupsResponse
         */
        public DescribeAccessGroupsResponse DescribeAccessGroups(DescribeAccessGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries permission groups.
         *
         * @param request DescribeAccessGroupsRequest
         * @return DescribeAccessGroupsResponse
         */
        public async Task<DescribeAccessGroupsResponse> DescribeAccessGroupsAsync(DescribeAccessGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request DescribeAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessPointResponse
         */
        public DescribeAccessPointResponse DescribeAccessPointWithOptions(DescribeAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointId))
            {
                query["AccessPointId"] = request.AccessPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessPoint",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessPointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request DescribeAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessPointResponse
         */
        public async Task<DescribeAccessPointResponse> DescribeAccessPointWithOptionsAsync(DescribeAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointId))
            {
                query["AccessPointId"] = request.AccessPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessPoint",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request DescribeAccessPointRequest
         * @return DescribeAccessPointResponse
         */
        public DescribeAccessPointResponse DescribeAccessPoint(DescribeAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessPointWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request DescribeAccessPointRequest
         * @return DescribeAccessPointResponse
         */
        public async Task<DescribeAccessPointResponse> DescribeAccessPointAsync(DescribeAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessPointWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request DescribeAccessPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessPointsResponse
         */
        public DescribeAccessPointsResponse DescribeAccessPointsWithOptions(DescribeAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroup))
            {
                query["AccessGroup"] = request.AccessGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessPoints",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessPointsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request DescribeAccessPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessPointsResponse
         */
        public async Task<DescribeAccessPointsResponse> DescribeAccessPointsWithOptionsAsync(DescribeAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroup))
            {
                query["AccessGroup"] = request.AccessGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessPoints",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request DescribeAccessPointsRequest
         * @return DescribeAccessPointsResponse
         */
        public DescribeAccessPointsResponse DescribeAccessPoints(DescribeAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessPointsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request DescribeAccessPointsRequest
         * @return DescribeAccessPointsResponse
         */
        public async Task<DescribeAccessPointsResponse> DescribeAccessPointsAsync(DescribeAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessPointsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about rules in a permission group.
         *
         * @param request DescribeAccessRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessRulesResponse
         */
        public DescribeAccessRulesResponse DescribeAccessRulesWithOptions(DescribeAccessRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessRules",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about rules in a permission group.
         *
         * @param request DescribeAccessRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessRulesResponse
         */
        public async Task<DescribeAccessRulesResponse> DescribeAccessRulesWithOptionsAsync(DescribeAccessRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessRules",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about rules in a permission group.
         *
         * @param request DescribeAccessRulesRequest
         * @return DescribeAccessRulesResponse
         */
        public DescribeAccessRulesResponse DescribeAccessRules(DescribeAccessRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessRulesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about rules in a permission group.
         *
         * @param request DescribeAccessRulesRequest
         * @return DescribeAccessRulesResponse
         */
        public async Task<DescribeAccessRulesResponse> DescribeAccessRulesAsync(DescribeAccessRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries automatic snapshot policies.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DescribeAutoSnapshotPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAutoSnapshotPoliciesResponse
         */
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPoliciesWithOptions(DescribeAutoSnapshotPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyId))
            {
                query["AutoSnapshotPolicyId"] = request.AutoSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoSnapshotPolicies",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoSnapshotPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries automatic snapshot policies.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DescribeAutoSnapshotPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAutoSnapshotPoliciesResponse
         */
        public async Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPoliciesWithOptionsAsync(DescribeAutoSnapshotPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyId))
            {
                query["AutoSnapshotPolicyId"] = request.AutoSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoSnapshotPolicies",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoSnapshotPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries automatic snapshot policies.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DescribeAutoSnapshotPoliciesRequest
         * @return DescribeAutoSnapshotPoliciesResponse
         */
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPolicies(DescribeAutoSnapshotPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoSnapshotPoliciesWithOptions(request, runtime);
        }

        /**
         * @summary Queries automatic snapshot policies.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DescribeAutoSnapshotPoliciesRequest
         * @return DescribeAutoSnapshotPoliciesResponse
         */
        public async Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPoliciesAsync(DescribeAutoSnapshotPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoSnapshotPoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries automatic snapshot tasks.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         *
         * @param request DescribeAutoSnapshotTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAutoSnapshotTasksResponse
         */
        public DescribeAutoSnapshotTasksResponse DescribeAutoSnapshotTasksWithOptions(DescribeAutoSnapshotTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyIds))
            {
                query["AutoSnapshotPolicyIds"] = request.AutoSnapshotPolicyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemIds))
            {
                query["FileSystemIds"] = request.FileSystemIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoSnapshotTasks",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoSnapshotTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries automatic snapshot tasks.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         *
         * @param request DescribeAutoSnapshotTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAutoSnapshotTasksResponse
         */
        public async Task<DescribeAutoSnapshotTasksResponse> DescribeAutoSnapshotTasksWithOptionsAsync(DescribeAutoSnapshotTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyIds))
            {
                query["AutoSnapshotPolicyIds"] = request.AutoSnapshotPolicyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemIds))
            {
                query["FileSystemIds"] = request.FileSystemIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoSnapshotTasks",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoSnapshotTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries automatic snapshot tasks.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         *
         * @param request DescribeAutoSnapshotTasksRequest
         * @return DescribeAutoSnapshotTasksResponse
         */
        public DescribeAutoSnapshotTasksResponse DescribeAutoSnapshotTasks(DescribeAutoSnapshotTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoSnapshotTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries automatic snapshot tasks.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support the snapshot feature.
         *
         * @param request DescribeAutoSnapshotTasksRequest
         * @return DescribeAutoSnapshotTasksResponse
         */
        public async Task<DescribeAutoSnapshotTasksResponse> DescribeAutoSnapshotTasksAsync(DescribeAutoSnapshotTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoSnapshotTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeBlackListClients is deprecated
         *
         * @summary 获取CPFS服务中黑名单客户端的状态
         *
         * @description The API operation is available only for CPFS file systems.
         *
         * @param request DescribeBlackListClientsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBlackListClientsResponse
         */
        // Deprecated
        public DescribeBlackListClientsResponse DescribeBlackListClientsWithOptions(DescribeBlackListClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIP))
            {
                query["ClientIP"] = request.ClientIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBlackListClients",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBlackListClientsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeBlackListClients is deprecated
         *
         * @summary 获取CPFS服务中黑名单客户端的状态
         *
         * @description The API operation is available only for CPFS file systems.
         *
         * @param request DescribeBlackListClientsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBlackListClientsResponse
         */
        // Deprecated
        public async Task<DescribeBlackListClientsResponse> DescribeBlackListClientsWithOptionsAsync(DescribeBlackListClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIP))
            {
                query["ClientIP"] = request.ClientIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBlackListClients",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBlackListClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeBlackListClients is deprecated
         *
         * @summary 获取CPFS服务中黑名单客户端的状态
         *
         * @description The API operation is available only for CPFS file systems.
         *
         * @param request DescribeBlackListClientsRequest
         * @return DescribeBlackListClientsResponse
         */
        // Deprecated
        public DescribeBlackListClientsResponse DescribeBlackListClients(DescribeBlackListClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBlackListClientsWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeBlackListClients is deprecated
         *
         * @summary 获取CPFS服务中黑名单客户端的状态
         *
         * @description The API operation is available only for CPFS file systems.
         *
         * @param request DescribeBlackListClientsRequest
         * @return DescribeBlackListClientsResponse
         */
        // Deprecated
        public async Task<DescribeBlackListClientsResponse> DescribeBlackListClientsAsync(DescribeBlackListClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBlackListClientsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数据流动任务
         *
         * @description ###
         * *
         * *
         *
         * @param request DescribeDataFlowTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataFlowTasksResponse
         */
        public DescribeDataFlowTasksResponse DescribeDataFlowTasksWithOptions(DescribeDataFlowTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataFlowTasks",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataFlowTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数据流动任务
         *
         * @description ###
         * *
         * *
         *
         * @param request DescribeDataFlowTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataFlowTasksResponse
         */
        public async Task<DescribeDataFlowTasksResponse> DescribeDataFlowTasksWithOptionsAsync(DescribeDataFlowTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataFlowTasks",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataFlowTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数据流动任务
         *
         * @description ###
         * *
         * *
         *
         * @param request DescribeDataFlowTasksRequest
         * @return DescribeDataFlowTasksResponse
         */
        public DescribeDataFlowTasksResponse DescribeDataFlowTasks(DescribeDataFlowTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataFlowTasksWithOptions(request, runtime);
        }

        /**
         * @summary 查询数据流动任务
         *
         * @description ###
         * *
         * *
         *
         * @param request DescribeDataFlowTasksRequest
         * @return DescribeDataFlowTasksResponse
         */
        public async Task<DescribeDataFlowTasksResponse> DescribeDataFlowTasksAsync(DescribeDataFlowTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataFlowTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the dataflows of a CPFS file system.
         *
         * @description *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.4.0 and later support data flows. You can view the version information on the file system details page in the console.
         * *   In Filters, FsetIds, DataFlowlds, SourceStorage, ThroughputList, and Status support exact match only. FileSystemPath, Description, and SourceStoragePath support fuzzy match.
         * *   Combined query is supported.
         *
         * @param request DescribeDataFlowsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataFlowsResponse
         */
        public DescribeDataFlowsResponse DescribeDataFlowsWithOptions(DescribeDataFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataFlows",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataFlowsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the dataflows of a CPFS file system.
         *
         * @description *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.4.0 and later support data flows. You can view the version information on the file system details page in the console.
         * *   In Filters, FsetIds, DataFlowlds, SourceStorage, ThroughputList, and Status support exact match only. FileSystemPath, Description, and SourceStoragePath support fuzzy match.
         * *   Combined query is supported.
         *
         * @param request DescribeDataFlowsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataFlowsResponse
         */
        public async Task<DescribeDataFlowsResponse> DescribeDataFlowsWithOptionsAsync(DescribeDataFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataFlows",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataFlowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the dataflows of a CPFS file system.
         *
         * @description *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.4.0 and later support data flows. You can view the version information on the file system details page in the console.
         * *   In Filters, FsetIds, DataFlowlds, SourceStorage, ThroughputList, and Status support exact match only. FileSystemPath, Description, and SourceStoragePath support fuzzy match.
         * *   Combined query is supported.
         *
         * @param request DescribeDataFlowsRequest
         * @return DescribeDataFlowsResponse
         */
        public DescribeDataFlowsResponse DescribeDataFlows(DescribeDataFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataFlowsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the dataflows of a CPFS file system.
         *
         * @description *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for LINGJUN V2.4.0 and later support data flows. You can view the version information on the file system details page in the console.
         * *   In Filters, FsetIds, DataFlowlds, SourceStorage, ThroughputList, and Status support exact match only. FileSystemPath, Description, and SourceStoragePath support fuzzy match.
         * *   Combined query is supported.
         *
         * @param request DescribeDataFlowsRequest
         * @return DescribeDataFlowsResponse
         */
        public async Task<DescribeDataFlowsResponse> DescribeDataFlowsAsync(DescribeDataFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataFlowsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the directory quotas of a file system.
         *
         * @description Only General-purpose NAS file systems support the directory quota feature.
         *
         * @param request DescribeDirQuotasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDirQuotasResponse
         */
        public DescribeDirQuotasResponse DescribeDirQuotasWithOptions(DescribeDirQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDirQuotas",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDirQuotasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the directory quotas of a file system.
         *
         * @description Only General-purpose NAS file systems support the directory quota feature.
         *
         * @param request DescribeDirQuotasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDirQuotasResponse
         */
        public async Task<DescribeDirQuotasResponse> DescribeDirQuotasWithOptionsAsync(DescribeDirQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDirQuotas",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDirQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the directory quotas of a file system.
         *
         * @description Only General-purpose NAS file systems support the directory quota feature.
         *
         * @param request DescribeDirQuotasRequest
         * @return DescribeDirQuotasResponse
         */
        public DescribeDirQuotasResponse DescribeDirQuotas(DescribeDirQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDirQuotasWithOptions(request, runtime);
        }

        /**
         * @summary Queries the directory quotas of a file system.
         *
         * @description Only General-purpose NAS file systems support the directory quota feature.
         *
         * @param request DescribeDirQuotasRequest
         * @return DescribeDirQuotasResponse
         */
        public async Task<DescribeDirQuotasResponse> DescribeDirQuotasAsync(DescribeDirQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDirQuotasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the statistics of file systems that are owned by the current account.
         *
         * @param request DescribeFileSystemStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFileSystemStatisticsResponse
         */
        public DescribeFileSystemStatisticsResponse DescribeFileSystemStatisticsWithOptions(DescribeFileSystemStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFileSystemStatistics",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileSystemStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the statistics of file systems that are owned by the current account.
         *
         * @param request DescribeFileSystemStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFileSystemStatisticsResponse
         */
        public async Task<DescribeFileSystemStatisticsResponse> DescribeFileSystemStatisticsWithOptionsAsync(DescribeFileSystemStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFileSystemStatistics",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileSystemStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the statistics of file systems that are owned by the current account.
         *
         * @param request DescribeFileSystemStatisticsRequest
         * @return DescribeFileSystemStatisticsResponse
         */
        public DescribeFileSystemStatisticsResponse DescribeFileSystemStatistics(DescribeFileSystemStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileSystemStatisticsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the statistics of file systems that are owned by the current account.
         *
         * @param request DescribeFileSystemStatisticsRequest
         * @return DescribeFileSystemStatisticsResponse
         */
        public async Task<DescribeFileSystemStatisticsResponse> DescribeFileSystemStatisticsAsync(DescribeFileSystemStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileSystemStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries file systems.
         *
         * @param request DescribeFileSystemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFileSystemsResponse
         */
        public DescribeFileSystemsResponse DescribeFileSystemsWithOptions(DescribeFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFileSystems",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileSystemsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries file systems.
         *
         * @param request DescribeFileSystemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFileSystemsResponse
         */
        public async Task<DescribeFileSystemsResponse> DescribeFileSystemsWithOptionsAsync(DescribeFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFileSystems",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileSystemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries file systems.
         *
         * @param request DescribeFileSystemsRequest
         * @return DescribeFileSystemsResponse
         */
        public DescribeFileSystemsResponse DescribeFileSystems(DescribeFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileSystemsWithOptions(request, runtime);
        }

        /**
         * @summary Queries file systems.
         *
         * @param request DescribeFileSystemsRequest
         * @return DescribeFileSystemsResponse
         */
        public async Task<DescribeFileSystemsResponse> DescribeFileSystemsAsync(DescribeFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileSystemsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about created filesets.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support filesets. You can view the version information on the file system details page in the console.
         * *   In Filters, FsetIds supports exact match only. FileSystemPath and Description support fuzzy match.
         * *   Combined query is supported.
         *
         * @param request DescribeFilesetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFilesetsResponse
         */
        public DescribeFilesetsResponse DescribeFilesetsWithOptions(DescribeFilesetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFilesets",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilesetsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about created filesets.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support filesets. You can view the version information on the file system details page in the console.
         * *   In Filters, FsetIds supports exact match only. FileSystemPath and Description support fuzzy match.
         * *   Combined query is supported.
         *
         * @param request DescribeFilesetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFilesetsResponse
         */
        public async Task<DescribeFilesetsResponse> DescribeFilesetsWithOptionsAsync(DescribeFilesetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFilesets",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilesetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about created filesets.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support filesets. You can view the version information on the file system details page in the console.
         * *   In Filters, FsetIds supports exact match only. FileSystemPath and Description support fuzzy match.
         * *   Combined query is supported.
         *
         * @param request DescribeFilesetsRequest
         * @return DescribeFilesetsResponse
         */
        public DescribeFilesetsResponse DescribeFilesets(DescribeFilesetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFilesetsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about created filesets.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support filesets. You can view the version information on the file system details page in the console.
         * *   In Filters, FsetIds supports exact match only. FileSystemPath and Description support fuzzy match.
         * *   Combined query is supported.
         *
         * @param request DescribeFilesetsRequest
         * @return DescribeFilesetsResponse
         */
        public async Task<DescribeFilesetsResponse> DescribeFilesetsAsync(DescribeFilesetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFilesetsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries lifecycle policies.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request DescribeLifecyclePoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLifecyclePoliciesResponse
         */
        public DescribeLifecyclePoliciesResponse DescribeLifecyclePoliciesWithOptions(DescribeLifecyclePoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLifecyclePolicies",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLifecyclePoliciesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries lifecycle policies.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request DescribeLifecyclePoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLifecyclePoliciesResponse
         */
        public async Task<DescribeLifecyclePoliciesResponse> DescribeLifecyclePoliciesWithOptionsAsync(DescribeLifecyclePoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLifecyclePolicies",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLifecyclePoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries lifecycle policies.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request DescribeLifecyclePoliciesRequest
         * @return DescribeLifecyclePoliciesResponse
         */
        public DescribeLifecyclePoliciesResponse DescribeLifecyclePolicies(DescribeLifecyclePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLifecyclePoliciesWithOptions(request, runtime);
        }

        /**
         * @summary Queries lifecycle policies.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request DescribeLifecyclePoliciesRequest
         * @return DescribeLifecyclePoliciesResponse
         */
        public async Task<DescribeLifecyclePoliciesResponse> DescribeLifecyclePoliciesAsync(DescribeLifecyclePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLifecyclePoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the log dump information configured in log analysis.
         *
         * @param request DescribeLogAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLogAnalysisResponse
         */
        public DescribeLogAnalysisResponse DescribeLogAnalysisWithOptions(DescribeLogAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogAnalysis",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the log dump information configured in log analysis.
         *
         * @param request DescribeLogAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLogAnalysisResponse
         */
        public async Task<DescribeLogAnalysisResponse> DescribeLogAnalysisWithOptionsAsync(DescribeLogAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogAnalysis",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the log dump information configured in log analysis.
         *
         * @param request DescribeLogAnalysisRequest
         * @return DescribeLogAnalysisResponse
         */
        public DescribeLogAnalysisResponse DescribeLogAnalysis(DescribeLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary Queries the log dump information configured in log analysis.
         *
         * @param request DescribeLogAnalysisRequest
         * @return DescribeLogAnalysisResponse
         */
        public async Task<DescribeLogAnalysisResponse> DescribeLogAnalysisAsync(DescribeLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries mount targets.
         *
         * @param request DescribeMountTargetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMountTargetsResponse
         */
        public DescribeMountTargetsResponse DescribeMountTargetsWithOptions(DescribeMountTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DualStackMountTargetDomain))
            {
                query["DualStackMountTargetDomain"] = request.DualStackMountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountTargetDomain))
            {
                query["MountTargetDomain"] = request.MountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMountTargets",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMountTargetsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries mount targets.
         *
         * @param request DescribeMountTargetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMountTargetsResponse
         */
        public async Task<DescribeMountTargetsResponse> DescribeMountTargetsWithOptionsAsync(DescribeMountTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DualStackMountTargetDomain))
            {
                query["DualStackMountTargetDomain"] = request.DualStackMountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountTargetDomain))
            {
                query["MountTargetDomain"] = request.MountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMountTargets",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMountTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries mount targets.
         *
         * @param request DescribeMountTargetsRequest
         * @return DescribeMountTargetsResponse
         */
        public DescribeMountTargetsResponse DescribeMountTargets(DescribeMountTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMountTargetsWithOptions(request, runtime);
        }

        /**
         * @summary Queries mount targets.
         *
         * @param request DescribeMountTargetsRequest
         * @return DescribeMountTargetsResponse
         */
        public async Task<DescribeMountTargetsResponse> DescribeMountTargetsAsync(DescribeMountTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMountTargetsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the clients on which a file system is mounted.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   This operation returns the clients that have accessed the specified file system within the last minute. If the file system is mounted on a client but the client did not access the file system within the last minute, the client is not included in the returned information.
         *
         * @param request DescribeMountedClientsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMountedClientsResponse
         */
        public DescribeMountedClientsResponse DescribeMountedClientsWithOptions(DescribeMountedClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIP))
            {
                query["ClientIP"] = request.ClientIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountTargetDomain))
            {
                query["MountTargetDomain"] = request.MountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMountedClients",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMountedClientsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the clients on which a file system is mounted.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   This operation returns the clients that have accessed the specified file system within the last minute. If the file system is mounted on a client but the client did not access the file system within the last minute, the client is not included in the returned information.
         *
         * @param request DescribeMountedClientsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMountedClientsResponse
         */
        public async Task<DescribeMountedClientsResponse> DescribeMountedClientsWithOptionsAsync(DescribeMountedClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIP))
            {
                query["ClientIP"] = request.ClientIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountTargetDomain))
            {
                query["MountTargetDomain"] = request.MountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMountedClients",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMountedClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the clients on which a file system is mounted.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   This operation returns the clients that have accessed the specified file system within the last minute. If the file system is mounted on a client but the client did not access the file system within the last minute, the client is not included in the returned information.
         *
         * @param request DescribeMountedClientsRequest
         * @return DescribeMountedClientsResponse
         */
        public DescribeMountedClientsResponse DescribeMountedClients(DescribeMountedClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMountedClientsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the clients on which a file system is mounted.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   This operation returns the clients that have accessed the specified file system within the last minute. If the file system is mounted on a client but the client did not access the file system within the last minute, the client is not included in the returned information.
         *
         * @param request DescribeMountedClientsRequest
         * @return DescribeMountedClientsResponse
         */
        public async Task<DescribeMountedClientsResponse> DescribeMountedClientsAsync(DescribeMountedClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMountedClientsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether the NFS ACL feature is enabled for a file system.
         *
         * @param request DescribeNfsAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNfsAclResponse
         */
        public DescribeNfsAclResponse DescribeNfsAclWithOptions(DescribeNfsAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNfsAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNfsAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether the NFS ACL feature is enabled for a file system.
         *
         * @param request DescribeNfsAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNfsAclResponse
         */
        public async Task<DescribeNfsAclResponse> DescribeNfsAclWithOptionsAsync(DescribeNfsAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNfsAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNfsAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether the NFS ACL feature is enabled for a file system.
         *
         * @param request DescribeNfsAclRequest
         * @return DescribeNfsAclResponse
         */
        public DescribeNfsAclResponse DescribeNfsAcl(DescribeNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNfsAclWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether the NFS ACL feature is enabled for a file system.
         *
         * @param request DescribeNfsAclRequest
         * @return DescribeNfsAclResponse
         */
        public async Task<DescribeNfsAclResponse> DescribeNfsAclAsync(DescribeNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNfsAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the export directories of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DescribeProtocolMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtocolMountTargetResponse
         */
        public DescribeProtocolMountTargetResponse DescribeProtocolMountTargetWithOptions(DescribeProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtocolMountTargetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the export directories of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DescribeProtocolMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtocolMountTargetResponse
         */
        public async Task<DescribeProtocolMountTargetResponse> DescribeProtocolMountTargetWithOptionsAsync(DescribeProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtocolMountTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the export directories of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DescribeProtocolMountTargetRequest
         * @return DescribeProtocolMountTargetResponse
         */
        public DescribeProtocolMountTargetResponse DescribeProtocolMountTarget(DescribeProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtocolMountTargetWithOptions(request, runtime);
        }

        /**
         * @summary Queries the export directories of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DescribeProtocolMountTargetRequest
         * @return DescribeProtocolMountTargetResponse
         */
        public async Task<DescribeProtocolMountTargetResponse> DescribeProtocolMountTargetAsync(DescribeProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtocolMountTargetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about protocol services.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DescribeProtocolServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtocolServiceResponse
         */
        public DescribeProtocolServiceResponse DescribeProtocolServiceWithOptions(DescribeProtocolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceIds))
            {
                query["ProtocolServiceIds"] = request.ProtocolServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtocolService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtocolServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about protocol services.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DescribeProtocolServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtocolServiceResponse
         */
        public async Task<DescribeProtocolServiceResponse> DescribeProtocolServiceWithOptionsAsync(DescribeProtocolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceIds))
            {
                query["ProtocolServiceIds"] = request.ProtocolServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtocolService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtocolServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about protocol services.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DescribeProtocolServiceRequest
         * @return DescribeProtocolServiceResponse
         */
        public DescribeProtocolServiceResponse DescribeProtocolService(DescribeProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtocolServiceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about protocol services.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request DescribeProtocolServiceRequest
         * @return DescribeProtocolServiceResponse
         */
        public async Task<DescribeProtocolServiceResponse> DescribeProtocolServiceAsync(DescribeProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtocolServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the regions in which Apsara File Storage NAS is available.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the regions in which Apsara File Storage NAS is available.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the regions in which Apsara File Storage NAS is available.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the regions in which Apsara File Storage NAS is available.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request DescribeSmbAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSmbAclResponse
         */
        public DescribeSmbAclResponse DescribeSmbAclWithOptions(DescribeSmbAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSmbAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSmbAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request DescribeSmbAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSmbAclResponse
         */
        public async Task<DescribeSmbAclResponse> DescribeSmbAclWithOptionsAsync(DescribeSmbAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSmbAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSmbAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request DescribeSmbAclRequest
         * @return DescribeSmbAclResponse
         */
        public DescribeSmbAclResponse DescribeSmbAcl(DescribeSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmbAclWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request DescribeSmbAclRequest
         * @return DescribeSmbAclResponse
         */
        public async Task<DescribeSmbAclResponse> DescribeSmbAclAsync(DescribeSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmbAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about one or more snapshots of a file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DescribeSnapshotsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSnapshotsResponse
         */
        public DescribeSnapshotsResponse DescribeSnapshotsWithOptions(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                query["SnapshotIds"] = request.SnapshotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotType))
            {
                query["SnapshotType"] = request.SnapshotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSnapshots",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about one or more snapshots of a file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DescribeSnapshotsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSnapshotsResponse
         */
        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsWithOptionsAsync(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                query["SnapshotIds"] = request.SnapshotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotType))
            {
                query["SnapshotType"] = request.SnapshotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSnapshots",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about one or more snapshots of a file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DescribeSnapshotsRequest
         * @return DescribeSnapshotsResponse
         */
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about one or more snapshots of a file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request DescribeSnapshotsRequest
         * @return DescribeSnapshotsResponse
         */
        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call the DescribeStoragePackages operation to query the list of storage plans.
         *
         * @param request DescribeStoragePackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStoragePackagesResponse
         */
        public DescribeStoragePackagesResponse DescribeStoragePackagesWithOptions(DescribeStoragePackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUTCDateTime))
            {
                query["UseUTCDateTime"] = request.UseUTCDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStoragePackages",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoragePackagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeStoragePackages operation to query the list of storage plans.
         *
         * @param request DescribeStoragePackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStoragePackagesResponse
         */
        public async Task<DescribeStoragePackagesResponse> DescribeStoragePackagesWithOptionsAsync(DescribeStoragePackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUTCDateTime))
            {
                query["UseUTCDateTime"] = request.UseUTCDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStoragePackages",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoragePackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeStoragePackages operation to query the list of storage plans.
         *
         * @param request DescribeStoragePackagesRequest
         * @return DescribeStoragePackagesResponse
         */
        public DescribeStoragePackagesResponse DescribeStoragePackages(DescribeStoragePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStoragePackagesWithOptions(request, runtime);
        }

        /**
         * @summary You can call the DescribeStoragePackages operation to query the list of storage plans.
         *
         * @param request DescribeStoragePackagesRequest
         * @return DescribeStoragePackagesResponse
         */
        public async Task<DescribeStoragePackagesResponse> DescribeStoragePackagesAsync(DescribeStoragePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStoragePackagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all zones in a region and the file system types that are supported in each zone.
         *
         * @param request DescribeZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeZonesResponse
         */
        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all zones in a region and the file system types that are supported in each zone.
         *
         * @param request DescribeZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeZonesResponse
         */
        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all zones in a region and the file system types that are supported in each zone.
         *
         * @param request DescribeZonesRequest
         * @return DescribeZonesResponse
         */
        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        /**
         * @summary Queries all zones in a region and the file system types that are supported in each zone.
         *
         * @param request DescribeZonesRequest
         * @return DescribeZonesResponse
         */
        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables and empties the recycle bin of a General-purpose NAS file system.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   If you disable the recycle bin, all files in the recycle bin are permanently deleted.
         * *   If you disable and then enable the recycle bin, the recycle bin is empty. You cannot retrieve the deleted files.
         *
         * @param request DisableAndCleanRecycleBinRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableAndCleanRecycleBinResponse
         */
        public DisableAndCleanRecycleBinResponse DisableAndCleanRecycleBinWithOptions(DisableAndCleanRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAndCleanRecycleBin",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAndCleanRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables and empties the recycle bin of a General-purpose NAS file system.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   If you disable the recycle bin, all files in the recycle bin are permanently deleted.
         * *   If you disable and then enable the recycle bin, the recycle bin is empty. You cannot retrieve the deleted files.
         *
         * @param request DisableAndCleanRecycleBinRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableAndCleanRecycleBinResponse
         */
        public async Task<DisableAndCleanRecycleBinResponse> DisableAndCleanRecycleBinWithOptionsAsync(DisableAndCleanRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAndCleanRecycleBin",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAndCleanRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables and empties the recycle bin of a General-purpose NAS file system.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   If you disable the recycle bin, all files in the recycle bin are permanently deleted.
         * *   If you disable and then enable the recycle bin, the recycle bin is empty. You cannot retrieve the deleted files.
         *
         * @param request DisableAndCleanRecycleBinRequest
         * @return DisableAndCleanRecycleBinResponse
         */
        public DisableAndCleanRecycleBinResponse DisableAndCleanRecycleBin(DisableAndCleanRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAndCleanRecycleBinWithOptions(request, runtime);
        }

        /**
         * @summary Disables and empties the recycle bin of a General-purpose NAS file system.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   If you disable the recycle bin, all files in the recycle bin are permanently deleted.
         * *   If you disable and then enable the recycle bin, the recycle bin is empty. You cannot retrieve the deleted files.
         *
         * @param request DisableAndCleanRecycleBinRequest
         * @return DisableAndCleanRecycleBinResponse
         */
        public async Task<DisableAndCleanRecycleBinResponse> DisableAndCleanRecycleBinAsync(DisableAndCleanRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAndCleanRecycleBinWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables the NFS ACL feature for a file system.
         *
         * @param request DisableNfsAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableNfsAclResponse
         */
        public DisableNfsAclResponse DisableNfsAclWithOptions(DisableNfsAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableNfsAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableNfsAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables the NFS ACL feature for a file system.
         *
         * @param request DisableNfsAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableNfsAclResponse
         */
        public async Task<DisableNfsAclResponse> DisableNfsAclWithOptionsAsync(DisableNfsAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableNfsAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableNfsAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables the NFS ACL feature for a file system.
         *
         * @param request DisableNfsAclRequest
         * @return DisableNfsAclResponse
         */
        public DisableNfsAclResponse DisableNfsAcl(DisableNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableNfsAclWithOptions(request, runtime);
        }

        /**
         * @summary Disables the NFS ACL feature for a file system.
         *
         * @param request DisableNfsAclRequest
         * @return DisableNfsAclResponse
         */
        public async Task<DisableNfsAclResponse> DisableNfsAclAsync(DisableNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableNfsAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request DisableSmbAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableSmbAclResponse
         */
        public DisableSmbAclResponse DisableSmbAclWithOptions(DisableSmbAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSmbAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSmbAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request DisableSmbAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableSmbAclResponse
         */
        public async Task<DisableSmbAclResponse> DisableSmbAclWithOptionsAsync(DisableSmbAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSmbAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSmbAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request DisableSmbAclRequest
         * @return DisableSmbAclResponse
         */
        public DisableSmbAclResponse DisableSmbAcl(DisableSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSmbAclWithOptions(request, runtime);
        }

        /**
         * @summary Disables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request DisableSmbAclRequest
         * @return DisableSmbAclResponse
         */
        public async Task<DisableSmbAclResponse> DisableSmbAclAsync(DisableSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSmbAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the NFS ACL feature for a file system.
         *
         * @param request EnableNfsAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableNfsAclResponse
         */
        public EnableNfsAclResponse EnableNfsAclWithOptions(EnableNfsAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableNfsAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableNfsAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables the NFS ACL feature for a file system.
         *
         * @param request EnableNfsAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableNfsAclResponse
         */
        public async Task<EnableNfsAclResponse> EnableNfsAclWithOptionsAsync(EnableNfsAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableNfsAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableNfsAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables the NFS ACL feature for a file system.
         *
         * @param request EnableNfsAclRequest
         * @return EnableNfsAclResponse
         */
        public EnableNfsAclResponse EnableNfsAcl(EnableNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableNfsAclWithOptions(request, runtime);
        }

        /**
         * @summary Enables the NFS ACL feature for a file system.
         *
         * @param request EnableNfsAclRequest
         * @return EnableNfsAclResponse
         */
        public async Task<EnableNfsAclResponse> EnableNfsAclAsync(EnableNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableNfsAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the recycle bin feature for a file system.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request EnableRecycleBinRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableRecycleBinResponse
         */
        public EnableRecycleBinResponse EnableRecycleBinWithOptions(EnableRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedDays))
            {
                query["ReservedDays"] = request.ReservedDays;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRecycleBin",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables the recycle bin feature for a file system.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request EnableRecycleBinRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableRecycleBinResponse
         */
        public async Task<EnableRecycleBinResponse> EnableRecycleBinWithOptionsAsync(EnableRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedDays))
            {
                query["ReservedDays"] = request.ReservedDays;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRecycleBin",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables the recycle bin feature for a file system.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request EnableRecycleBinRequest
         * @return EnableRecycleBinResponse
         */
        public EnableRecycleBinResponse EnableRecycleBin(EnableRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableRecycleBinWithOptions(request, runtime);
        }

        /**
         * @summary Enables the recycle bin feature for a file system.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request EnableRecycleBinRequest
         * @return EnableRecycleBinResponse
         */
        public async Task<EnableRecycleBinResponse> EnableRecycleBinAsync(EnableRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableRecycleBinWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request EnableSmbAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableSmbAclResponse
         */
        public EnableSmbAclResponse EnableSmbAclWithOptions(EnableSmbAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keytab))
            {
                query["Keytab"] = request.Keytab;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeytabMd5))
            {
                query["KeytabMd5"] = request.KeytabMd5;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSmbAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSmbAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request EnableSmbAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableSmbAclResponse
         */
        public async Task<EnableSmbAclResponse> EnableSmbAclWithOptionsAsync(EnableSmbAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keytab))
            {
                query["Keytab"] = request.Keytab;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeytabMd5))
            {
                query["KeytabMd5"] = request.KeytabMd5;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSmbAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSmbAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request EnableSmbAclRequest
         * @return EnableSmbAclResponse
         */
        public EnableSmbAclResponse EnableSmbAcl(EnableSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSmbAclWithOptions(request, runtime);
        }

        /**
         * @summary Enables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request EnableSmbAclRequest
         * @return EnableSmbAclResponse
         */
        public async Task<EnableSmbAclResponse> EnableSmbAclAsync(EnableSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSmbAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether a directory contains files that are stored in the Infrequent Access (IA) or Archive storage class, or whether a file is stored in the IA or Archive storage class.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request GetDirectoryOrFilePropertiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDirectoryOrFilePropertiesResponse
         */
        public GetDirectoryOrFilePropertiesResponse GetDirectoryOrFilePropertiesWithOptions(GetDirectoryOrFilePropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectoryOrFileProperties",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectoryOrFilePropertiesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether a directory contains files that are stored in the Infrequent Access (IA) or Archive storage class, or whether a file is stored in the IA or Archive storage class.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request GetDirectoryOrFilePropertiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDirectoryOrFilePropertiesResponse
         */
        public async Task<GetDirectoryOrFilePropertiesResponse> GetDirectoryOrFilePropertiesWithOptionsAsync(GetDirectoryOrFilePropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectoryOrFileProperties",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectoryOrFilePropertiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether a directory contains files that are stored in the Infrequent Access (IA) or Archive storage class, or whether a file is stored in the IA or Archive storage class.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request GetDirectoryOrFilePropertiesRequest
         * @return GetDirectoryOrFilePropertiesResponse
         */
        public GetDirectoryOrFilePropertiesResponse GetDirectoryOrFileProperties(GetDirectoryOrFilePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDirectoryOrFilePropertiesWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether a directory contains files that are stored in the Infrequent Access (IA) or Archive storage class, or whether a file is stored in the IA or Archive storage class.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request GetDirectoryOrFilePropertiesRequest
         * @return GetDirectoryOrFilePropertiesResponse
         */
        public async Task<GetDirectoryOrFilePropertiesResponse> GetDirectoryOrFilePropertiesAsync(GetDirectoryOrFilePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDirectoryOrFilePropertiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the recycle bin configurations of a General-purpose NAS file system.
         *
         * @param request GetRecycleBinAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRecycleBinAttributeResponse
         */
        public GetRecycleBinAttributeResponse GetRecycleBinAttributeWithOptions(GetRecycleBinAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecycleBinAttribute",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecycleBinAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the recycle bin configurations of a General-purpose NAS file system.
         *
         * @param request GetRecycleBinAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRecycleBinAttributeResponse
         */
        public async Task<GetRecycleBinAttributeResponse> GetRecycleBinAttributeWithOptionsAsync(GetRecycleBinAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecycleBinAttribute",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecycleBinAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the recycle bin configurations of a General-purpose NAS file system.
         *
         * @param request GetRecycleBinAttributeRequest
         * @return GetRecycleBinAttributeResponse
         */
        public GetRecycleBinAttributeResponse GetRecycleBinAttribute(GetRecycleBinAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRecycleBinAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the recycle bin configurations of a General-purpose NAS file system.
         *
         * @param request GetRecycleBinAttributeRequest
         * @return GetRecycleBinAttributeResponse
         */
        public async Task<GetRecycleBinAttributeResponse> GetRecycleBinAttributeAsync(GetRecycleBinAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRecycleBinAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the infrequently-accessed files in a specified directory of a General-purpose NAS file system and the subdirectories that contain the files.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListDirectoriesAndFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDirectoriesAndFilesResponse
         */
        public ListDirectoriesAndFilesResponse ListDirectoriesAndFilesWithOptions(ListDirectoriesAndFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryOnly))
            {
                query["DirectoryOnly"] = request.DirectoryOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDirectoriesAndFiles",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDirectoriesAndFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the infrequently-accessed files in a specified directory of a General-purpose NAS file system and the subdirectories that contain the files.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListDirectoriesAndFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDirectoriesAndFilesResponse
         */
        public async Task<ListDirectoriesAndFilesResponse> ListDirectoriesAndFilesWithOptionsAsync(ListDirectoriesAndFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryOnly))
            {
                query["DirectoryOnly"] = request.DirectoryOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDirectoriesAndFiles",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDirectoriesAndFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the infrequently-accessed files in a specified directory of a General-purpose NAS file system and the subdirectories that contain the files.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListDirectoriesAndFilesRequest
         * @return ListDirectoriesAndFilesResponse
         */
        public ListDirectoriesAndFilesResponse ListDirectoriesAndFiles(ListDirectoriesAndFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDirectoriesAndFilesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the infrequently-accessed files in a specified directory of a General-purpose NAS file system and the subdirectories that contain the files.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListDirectoriesAndFilesRequest
         * @return ListDirectoriesAndFilesResponse
         */
        public async Task<ListDirectoriesAndFilesResponse> ListDirectoriesAndFilesAsync(ListDirectoriesAndFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDirectoriesAndFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries data retrieval tasks.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListLifecycleRetrieveJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLifecycleRetrieveJobsResponse
         */
        public ListLifecycleRetrieveJobsResponse ListLifecycleRetrieveJobsWithOptions(ListLifecycleRetrieveJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLifecycleRetrieveJobs",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLifecycleRetrieveJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries data retrieval tasks.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListLifecycleRetrieveJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLifecycleRetrieveJobsResponse
         */
        public async Task<ListLifecycleRetrieveJobsResponse> ListLifecycleRetrieveJobsWithOptionsAsync(ListLifecycleRetrieveJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLifecycleRetrieveJobs",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLifecycleRetrieveJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries data retrieval tasks.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListLifecycleRetrieveJobsRequest
         * @return ListLifecycleRetrieveJobsResponse
         */
        public ListLifecycleRetrieveJobsResponse ListLifecycleRetrieveJobs(ListLifecycleRetrieveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLifecycleRetrieveJobsWithOptions(request, runtime);
        }

        /**
         * @summary Queries data retrieval tasks.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListLifecycleRetrieveJobsRequest
         * @return ListLifecycleRetrieveJobsResponse
         */
        public async Task<ListLifecycleRetrieveJobsResponse> ListLifecycleRetrieveJobsAsync(ListLifecycleRetrieveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLifecycleRetrieveJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the directories that are recently deleted.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListRecentlyRecycledDirectoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecentlyRecycledDirectoriesResponse
         */
        public ListRecentlyRecycledDirectoriesResponse ListRecentlyRecycledDirectoriesWithOptions(ListRecentlyRecycledDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentlyRecycledDirectories",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentlyRecycledDirectoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the directories that are recently deleted.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListRecentlyRecycledDirectoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecentlyRecycledDirectoriesResponse
         */
        public async Task<ListRecentlyRecycledDirectoriesResponse> ListRecentlyRecycledDirectoriesWithOptionsAsync(ListRecentlyRecycledDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentlyRecycledDirectories",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentlyRecycledDirectoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the directories that are recently deleted.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListRecentlyRecycledDirectoriesRequest
         * @return ListRecentlyRecycledDirectoriesResponse
         */
        public ListRecentlyRecycledDirectoriesResponse ListRecentlyRecycledDirectories(ListRecentlyRecycledDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecentlyRecycledDirectoriesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the directories that are recently deleted.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListRecentlyRecycledDirectoriesRequest
         * @return ListRecentlyRecycledDirectoriesResponse
         */
        public async Task<ListRecentlyRecycledDirectoriesResponse> ListRecentlyRecycledDirectoriesAsync(ListRecentlyRecycledDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecentlyRecycledDirectoriesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the jobs of the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can query a maximum of 50 jobs that are recently executed.
         *
         * @param request ListRecycleBinJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecycleBinJobsResponse
         */
        public ListRecycleBinJobsResponse ListRecycleBinJobsWithOptions(ListRecycleBinJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecycleBinJobs",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecycleBinJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the jobs of the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can query a maximum of 50 jobs that are recently executed.
         *
         * @param request ListRecycleBinJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecycleBinJobsResponse
         */
        public async Task<ListRecycleBinJobsResponse> ListRecycleBinJobsWithOptionsAsync(ListRecycleBinJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecycleBinJobs",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecycleBinJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the jobs of the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can query a maximum of 50 jobs that are recently executed.
         *
         * @param request ListRecycleBinJobsRequest
         * @return ListRecycleBinJobsResponse
         */
        public ListRecycleBinJobsResponse ListRecycleBinJobs(ListRecycleBinJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecycleBinJobsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the jobs of the recycle bin.
         *
         * @description *   Only General-purpose NAS file systems support this operation.
         * *   You can query a maximum of 50 jobs that are recently executed.
         *
         * @param request ListRecycleBinJobsRequest
         * @return ListRecycleBinJobsResponse
         */
        public async Task<ListRecycleBinJobsResponse> ListRecycleBinJobsAsync(ListRecycleBinJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecycleBinJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries deleted files or directories.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListRecycledDirectoriesAndFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecycledDirectoriesAndFilesResponse
         */
        public ListRecycledDirectoriesAndFilesResponse ListRecycledDirectoriesAndFilesWithOptions(ListRecycledDirectoriesAndFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecycledDirectoriesAndFiles",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecycledDirectoriesAndFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries deleted files or directories.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListRecycledDirectoriesAndFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRecycledDirectoriesAndFilesResponse
         */
        public async Task<ListRecycledDirectoriesAndFilesResponse> ListRecycledDirectoriesAndFilesWithOptionsAsync(ListRecycledDirectoriesAndFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecycledDirectoriesAndFiles",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecycledDirectoriesAndFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries deleted files or directories.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListRecycledDirectoriesAndFilesRequest
         * @return ListRecycledDirectoriesAndFilesResponse
         */
        public ListRecycledDirectoriesAndFilesResponse ListRecycledDirectoriesAndFiles(ListRecycledDirectoriesAndFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecycledDirectoriesAndFilesWithOptions(request, runtime);
        }

        /**
         * @summary Queries deleted files or directories.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ListRecycledDirectoriesAndFilesRequest
         * @return ListRecycledDirectoriesAndFilesResponse
         */
        public async Task<ListRecycledDirectoriesAndFilesResponse> ListRecycledDirectoriesAndFilesAsync(ListRecycledDirectoriesAndFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecycledDirectoriesAndFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries tags.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries tags.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries tags.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries tags.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a permission group.
         *
         * @description The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.
         *
         * @param request ModifyAccessGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccessGroupResponse
         */
        public ModifyAccessGroupResponse ModifyAccessGroupWithOptions(ModifyAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessGroup",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a permission group.
         *
         * @description The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.
         *
         * @param request ModifyAccessGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccessGroupResponse
         */
        public async Task<ModifyAccessGroupResponse> ModifyAccessGroupWithOptionsAsync(ModifyAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessGroup",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a permission group.
         *
         * @description The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.
         *
         * @param request ModifyAccessGroupRequest
         * @return ModifyAccessGroupResponse
         */
        public ModifyAccessGroupResponse ModifyAccessGroup(ModifyAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessGroupWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a permission group.
         *
         * @description The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.
         *
         * @param request ModifyAccessGroupRequest
         * @return ModifyAccessGroupResponse
         */
        public async Task<ModifyAccessGroupResponse> ModifyAccessGroupAsync(ModifyAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the information about an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request ModifyAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccessPointResponse
         */
        public ModifyAccessPointResponse ModifyAccessPointWithOptions(ModifyAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroup))
            {
                query["AccessGroup"] = request.AccessGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointId))
            {
                query["AccessPointId"] = request.AccessPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointName))
            {
                query["AccessPointName"] = request.AccessPointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnabledRam))
            {
                query["EnabledRam"] = request.EnabledRam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessPoint",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessPointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request ModifyAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccessPointResponse
         */
        public async Task<ModifyAccessPointResponse> ModifyAccessPointWithOptionsAsync(ModifyAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroup))
            {
                query["AccessGroup"] = request.AccessGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointId))
            {
                query["AccessPointId"] = request.AccessPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointName))
            {
                query["AccessPointName"] = request.AccessPointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnabledRam))
            {
                query["EnabledRam"] = request.EnabledRam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessPoint",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request ModifyAccessPointRequest
         * @return ModifyAccessPointResponse
         */
        public ModifyAccessPointResponse ModifyAccessPoint(ModifyAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessPointWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the information about an access point.
         *
         * @description Only General-purpose Network File System (NFS) file systems support this operation.
         *
         * @param request ModifyAccessPointRequest
         * @return ModifyAccessPointResponse
         */
        public async Task<ModifyAccessPointResponse> ModifyAccessPointAsync(ModifyAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessPointWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a rule in a permission group.
         *
         * @description The rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.
         *
         * @param request ModifyAccessRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccessRuleResponse
         */
        public ModifyAccessRuleResponse ModifyAccessRuleWithOptions(ModifyAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6SourceCidrIp))
            {
                query["Ipv6SourceCidrIp"] = request.Ipv6SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RWAccessType))
            {
                query["RWAccessType"] = request.RWAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                query["SourceCidrIp"] = request.SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessType))
            {
                query["UserAccessType"] = request.UserAccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessRule",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a rule in a permission group.
         *
         * @description The rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.
         *
         * @param request ModifyAccessRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccessRuleResponse
         */
        public async Task<ModifyAccessRuleResponse> ModifyAccessRuleWithOptionsAsync(ModifyAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6SourceCidrIp))
            {
                query["Ipv6SourceCidrIp"] = request.Ipv6SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RWAccessType))
            {
                query["RWAccessType"] = request.RWAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                query["SourceCidrIp"] = request.SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessType))
            {
                query["UserAccessType"] = request.UserAccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessRule",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a rule in a permission group.
         *
         * @description The rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.
         *
         * @param request ModifyAccessRuleRequest
         * @return ModifyAccessRuleResponse
         */
        public ModifyAccessRuleResponse ModifyAccessRule(ModifyAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessRuleWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a rule in a permission group.
         *
         * @description The rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.
         *
         * @param request ModifyAccessRuleRequest
         * @return ModifyAccessRuleResponse
         */
        public async Task<ModifyAccessRuleResponse> ModifyAccessRuleAsync(ModifyAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary An automatic snapshot policy is modified. After you modify an automatic snapshot policy that is applied to a file system, the modification immediately applies to subsequent snapshots that are created for the file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request ModifyAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAutoSnapshotPolicyResponse
         */
        public ModifyAutoSnapshotPolicyResponse ModifyAutoSnapshotPolicyWithOptions(ModifyAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyId))
            {
                query["AutoSnapshotPolicyId"] = request.AutoSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyName))
            {
                query["AutoSnapshotPolicyName"] = request.AutoSnapshotPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatWeekdays))
            {
                query["RepeatWeekdays"] = request.RepeatWeekdays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoints))
            {
                query["TimePoints"] = request.TimePoints;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary An automatic snapshot policy is modified. After you modify an automatic snapshot policy that is applied to a file system, the modification immediately applies to subsequent snapshots that are created for the file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request ModifyAutoSnapshotPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAutoSnapshotPolicyResponse
         */
        public async Task<ModifyAutoSnapshotPolicyResponse> ModifyAutoSnapshotPolicyWithOptionsAsync(ModifyAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyId))
            {
                query["AutoSnapshotPolicyId"] = request.AutoSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSnapshotPolicyName))
            {
                query["AutoSnapshotPolicyName"] = request.AutoSnapshotPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatWeekdays))
            {
                query["RepeatWeekdays"] = request.RepeatWeekdays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoints))
            {
                query["TimePoints"] = request.TimePoints;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAutoSnapshotPolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary An automatic snapshot policy is modified. After you modify an automatic snapshot policy that is applied to a file system, the modification immediately applies to subsequent snapshots that are created for the file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request ModifyAutoSnapshotPolicyRequest
         * @return ModifyAutoSnapshotPolicyResponse
         */
        public ModifyAutoSnapshotPolicyResponse ModifyAutoSnapshotPolicy(ModifyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /**
         * @summary An automatic snapshot policy is modified. After you modify an automatic snapshot policy that is applied to a file system, the modification immediately applies to subsequent snapshots that are created for the file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         *
         * @param request ModifyAutoSnapshotPolicyRequest
         * @return ModifyAutoSnapshotPolicyResponse
         */
        public async Task<ModifyAutoSnapshotPolicyResponse> ModifyAutoSnapshotPolicyAsync(ModifyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the attributes of a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows.
         * *   You can modify the attributes only of the dataflows that are in the `Running` state.
         * *   It generally takes 2 to 5 minutes to modify the attributes of a dataflow. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the status of the dataflow to be modified.
         * *   Data flow specifications:
         *     *   The dataflow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The dataflow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a dataflow.
         *     *   Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the dataflow whose throughput is changed meet the requirements.
         * *   Billing
         *     Changing the dataflow throughput involves the billing of dataflow bandwidth. We recommend that you understand CPFS billing methods in advance. For more information, see [Billing methods and billable items of CPFS](https://help.aliyun.com/document_detail/111858.html).
         *
         * @param request ModifyDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDataFlowResponse
         */
        public ModifyDataFlowResponse ModifyDataFlowWithOptions(ModifyDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Throughput))
            {
                query["Throughput"] = request.Throughput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the attributes of a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows.
         * *   You can modify the attributes only of the dataflows that are in the `Running` state.
         * *   It generally takes 2 to 5 minutes to modify the attributes of a dataflow. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the status of the dataflow to be modified.
         * *   Data flow specifications:
         *     *   The dataflow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The dataflow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a dataflow.
         *     *   Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the dataflow whose throughput is changed meet the requirements.
         * *   Billing
         *     Changing the dataflow throughput involves the billing of dataflow bandwidth. We recommend that you understand CPFS billing methods in advance. For more information, see [Billing methods and billable items of CPFS](https://help.aliyun.com/document_detail/111858.html).
         *
         * @param request ModifyDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDataFlowResponse
         */
        public async Task<ModifyDataFlowResponse> ModifyDataFlowWithOptionsAsync(ModifyDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Throughput))
            {
                query["Throughput"] = request.Throughput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the attributes of a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows.
         * *   You can modify the attributes only of the dataflows that are in the `Running` state.
         * *   It generally takes 2 to 5 minutes to modify the attributes of a dataflow. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the status of the dataflow to be modified.
         * *   Data flow specifications:
         *     *   The dataflow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The dataflow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a dataflow.
         *     *   Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the dataflow whose throughput is changed meet the requirements.
         * *   Billing
         *     Changing the dataflow throughput involves the billing of dataflow bandwidth. We recommend that you understand CPFS billing methods in advance. For more information, see [Billing methods and billable items of CPFS](https://help.aliyun.com/document_detail/111858.html).
         *
         * @param request ModifyDataFlowRequest
         * @return ModifyDataFlowResponse
         */
        public ModifyDataFlowResponse ModifyDataFlow(ModifyDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataFlowWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the attributes of a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows.
         * *   You can modify the attributes only of the dataflows that are in the `Running` state.
         * *   It generally takes 2 to 5 minutes to modify the attributes of a dataflow. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the status of the dataflow to be modified.
         * *   Data flow specifications:
         *     *   The dataflow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The dataflow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a dataflow.
         *     *   Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the dataflow whose throughput is changed meet the requirements.
         * *   Billing
         *     Changing the dataflow throughput involves the billing of dataflow bandwidth. We recommend that you understand CPFS billing methods in advance. For more information, see [Billing methods and billable items of CPFS](https://help.aliyun.com/document_detail/111858.html).
         *
         * @param request ModifyDataFlowRequest
         * @return ModifyDataFlowResponse
         */
        public async Task<ModifyDataFlowResponse> ModifyDataFlowAsync(ModifyDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies an AutoRefresh configuration of a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can modify the AutoRefresh configurations only for the dataflows that are in the `Running` or `Stopped` state.
         * *   It generally takes 2 to 5 minutes to modify an AutoRefresh configuration. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the task of modifying an AutoRefresh configuration.
         *
         * @param request ModifyDataFlowAutoRefreshRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDataFlowAutoRefreshResponse
         */
        public ModifyDataFlowAutoRefreshResponse ModifyDataFlowAutoRefreshWithOptions(ModifyDataFlowAutoRefreshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshInterval))
            {
                query["AutoRefreshInterval"] = request.AutoRefreshInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshPolicy))
            {
                query["AutoRefreshPolicy"] = request.AutoRefreshPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataFlowAutoRefresh",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataFlowAutoRefreshResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies an AutoRefresh configuration of a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can modify the AutoRefresh configurations only for the dataflows that are in the `Running` or `Stopped` state.
         * *   It generally takes 2 to 5 minutes to modify an AutoRefresh configuration. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the task of modifying an AutoRefresh configuration.
         *
         * @param request ModifyDataFlowAutoRefreshRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDataFlowAutoRefreshResponse
         */
        public async Task<ModifyDataFlowAutoRefreshResponse> ModifyDataFlowAutoRefreshWithOptionsAsync(ModifyDataFlowAutoRefreshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshInterval))
            {
                query["AutoRefreshInterval"] = request.AutoRefreshInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRefreshPolicy))
            {
                query["AutoRefreshPolicy"] = request.AutoRefreshPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataFlowAutoRefresh",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataFlowAutoRefreshResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies an AutoRefresh configuration of a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can modify the AutoRefresh configurations only for the dataflows that are in the `Running` or `Stopped` state.
         * *   It generally takes 2 to 5 minutes to modify an AutoRefresh configuration. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the task of modifying an AutoRefresh configuration.
         *
         * @param request ModifyDataFlowAutoRefreshRequest
         * @return ModifyDataFlowAutoRefreshResponse
         */
        public ModifyDataFlowAutoRefreshResponse ModifyDataFlowAutoRefresh(ModifyDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataFlowAutoRefreshWithOptions(request, runtime);
        }

        /**
         * @summary Modifies an AutoRefresh configuration of a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can modify the AutoRefresh configurations only for the dataflows that are in the `Running` or `Stopped` state.
         * *   It generally takes 2 to 5 minutes to modify an AutoRefresh configuration. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/336901.html) operation to query the task of modifying an AutoRefresh configuration.
         *
         * @param request ModifyDataFlowAutoRefreshRequest
         * @return ModifyDataFlowAutoRefreshResponse
         */
        public async Task<ModifyDataFlowAutoRefreshResponse> ModifyDataFlowAutoRefreshAsync(ModifyDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataFlowAutoRefreshWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of a file system.
         *
         * @param tmpReq ModifyFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFileSystemResponse
         */
        public ModifyFileSystemResponse ModifyFileSystemWithOptions(ModifyFileSystemRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyFileSystemShrinkRequest request = new ModifyFileSystemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "Options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["Options"] = request.OptionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a file system.
         *
         * @param tmpReq ModifyFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFileSystemResponse
         */
        public async Task<ModifyFileSystemResponse> ModifyFileSystemWithOptionsAsync(ModifyFileSystemRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyFileSystemShrinkRequest request = new ModifyFileSystemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "Options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["Options"] = request.OptionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a file system.
         *
         * @param request ModifyFileSystemRequest
         * @return ModifyFileSystemResponse
         */
        public ModifyFileSystemResponse ModifyFileSystem(ModifyFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFileSystemWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of a file system.
         *
         * @param request ModifyFileSystemRequest
         * @return ModifyFileSystemResponse
         */
        public async Task<ModifyFileSystemResponse> ModifyFileSystemAsync(ModifyFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFileSystemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset modification.
         *
         * @param request ModifyFilesetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFilesetResponse
         */
        public ModifyFilesetResponse ModifyFilesetWithOptions(ModifyFilesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFileset",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFilesetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset modification.
         *
         * @param request ModifyFilesetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFilesetResponse
         */
        public async Task<ModifyFilesetResponse> ModifyFilesetWithOptionsAsync(ModifyFilesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFileset",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFilesetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset modification.
         *
         * @param request ModifyFilesetRequest
         * @return ModifyFilesetResponse
         */
        public ModifyFilesetResponse ModifyFileset(ModifyFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFilesetWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a fileset.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support fileset modification.
         *
         * @param request ModifyFilesetRequest
         * @return ModifyFilesetResponse
         */
        public async Task<ModifyFilesetResponse> ModifyFilesetAsync(ModifyFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFilesetWithOptionsAsync(request, runtime);
        }

        /**
         * @description The API operation is available only for Cloud Parallel File Storage (CPFS) file systems.
         *
         * @param request ModifyLDAPConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLDAPConfigResponse
         */
        public ModifyLDAPConfigResponse ModifyLDAPConfigWithOptions(ModifyLDAPConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindDN))
            {
                query["BindDN"] = request.BindDN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchBase))
            {
                query["SearchBase"] = request.SearchBase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLDAPConfig",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLDAPConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description The API operation is available only for Cloud Parallel File Storage (CPFS) file systems.
         *
         * @param request ModifyLDAPConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLDAPConfigResponse
         */
        public async Task<ModifyLDAPConfigResponse> ModifyLDAPConfigWithOptionsAsync(ModifyLDAPConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindDN))
            {
                query["BindDN"] = request.BindDN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchBase))
            {
                query["SearchBase"] = request.SearchBase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLDAPConfig",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLDAPConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description The API operation is available only for Cloud Parallel File Storage (CPFS) file systems.
         *
         * @param request ModifyLDAPConfigRequest
         * @return ModifyLDAPConfigResponse
         */
        public ModifyLDAPConfigResponse ModifyLDAPConfig(ModifyLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLDAPConfigWithOptions(request, runtime);
        }

        /**
         * @description The API operation is available only for Cloud Parallel File Storage (CPFS) file systems.
         *
         * @param request ModifyLDAPConfigRequest
         * @return ModifyLDAPConfigResponse
         */
        public async Task<ModifyLDAPConfigResponse> ModifyLDAPConfigAsync(ModifyLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLDAPConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a lifecycle policy.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ModifyLifecyclePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLifecyclePolicyResponse
         */
        public ModifyLifecyclePolicyResponse ModifyLifecyclePolicyWithOptions(ModifyLifecyclePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyName))
            {
                query["LifecyclePolicyName"] = request.LifecyclePolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleRuleName))
            {
                query["LifecycleRuleName"] = request.LifecycleRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLifecyclePolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLifecyclePolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a lifecycle policy.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ModifyLifecyclePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLifecyclePolicyResponse
         */
        public async Task<ModifyLifecyclePolicyResponse> ModifyLifecyclePolicyWithOptionsAsync(ModifyLifecyclePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyName))
            {
                query["LifecyclePolicyName"] = request.LifecyclePolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleRuleName))
            {
                query["LifecycleRuleName"] = request.LifecycleRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLifecyclePolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLifecyclePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a lifecycle policy.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ModifyLifecyclePolicyRequest
         * @return ModifyLifecyclePolicyResponse
         */
        public ModifyLifecyclePolicyResponse ModifyLifecyclePolicy(ModifyLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLifecyclePolicyWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a lifecycle policy.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request ModifyLifecyclePolicyRequest
         * @return ModifyLifecyclePolicyResponse
         */
        public async Task<ModifyLifecyclePolicyResponse> ModifyLifecyclePolicyAsync(ModifyLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLifecyclePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a mount target.
         *
         * @param request ModifyMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMountTargetResponse
         */
        public ModifyMountTargetResponse ModifyMountTargetWithOptions(ModifyMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DualStackMountTargetDomain))
            {
                query["DualStackMountTargetDomain"] = request.DualStackMountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountTargetDomain))
            {
                query["MountTargetDomain"] = request.MountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMountTargetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a mount target.
         *
         * @param request ModifyMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMountTargetResponse
         */
        public async Task<ModifyMountTargetResponse> ModifyMountTargetWithOptionsAsync(ModifyMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DualStackMountTargetDomain))
            {
                query["DualStackMountTargetDomain"] = request.DualStackMountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountTargetDomain))
            {
                query["MountTargetDomain"] = request.MountTargetDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMountTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a mount target.
         *
         * @param request ModifyMountTargetRequest
         * @return ModifyMountTargetResponse
         */
        public ModifyMountTargetResponse ModifyMountTarget(ModifyMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMountTargetWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a mount target.
         *
         * @param request ModifyMountTargetRequest
         * @return ModifyMountTargetResponse
         */
        public async Task<ModifyMountTargetResponse> ModifyMountTargetAsync(ModifyMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMountTargetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the export directory parameters of a protocol service. Only the description can be modified. The virtual private cloud (VPC) ID and vSwitch ID cannot be changed. To change these IDs, you must delete the export directory and create a new one.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request ModifyProtocolMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtocolMountTargetResponse
         */
        public ModifyProtocolMountTargetResponse ModifyProtocolMountTargetWithOptions(ModifyProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                query["ExportId"] = request.ExportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtocolMountTargetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the export directory parameters of a protocol service. Only the description can be modified. The virtual private cloud (VPC) ID and vSwitch ID cannot be changed. To change these IDs, you must delete the export directory and create a new one.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request ModifyProtocolMountTargetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtocolMountTargetResponse
         */
        public async Task<ModifyProtocolMountTargetResponse> ModifyProtocolMountTargetWithOptionsAsync(ModifyProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                query["ExportId"] = request.ExportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtocolMountTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the export directory parameters of a protocol service. Only the description can be modified. The virtual private cloud (VPC) ID and vSwitch ID cannot be changed. To change these IDs, you must delete the export directory and create a new one.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request ModifyProtocolMountTargetRequest
         * @return ModifyProtocolMountTargetResponse
         */
        public ModifyProtocolMountTargetResponse ModifyProtocolMountTarget(ModifyProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtocolMountTargetWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the export directory parameters of a protocol service. Only the description can be modified. The virtual private cloud (VPC) ID and vSwitch ID cannot be changed. To change these IDs, you must delete the export directory and create a new one.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request ModifyProtocolMountTargetRequest
         * @return ModifyProtocolMountTargetResponse
         */
        public async Task<ModifyProtocolMountTargetResponse> ModifyProtocolMountTargetAsync(ModifyProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtocolMountTargetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a protocol service. You can modify the description of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request ModifyProtocolServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtocolServiceResponse
         */
        public ModifyProtocolServiceResponse ModifyProtocolServiceWithOptions(ModifyProtocolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtocolService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtocolServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a protocol service. You can modify the description of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request ModifyProtocolServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtocolServiceResponse
         */
        public async Task<ModifyProtocolServiceResponse> ModifyProtocolServiceWithOptionsAsync(ModifyProtocolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceId))
            {
                query["ProtocolServiceId"] = request.ProtocolServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtocolService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtocolServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a protocol service. You can modify the description of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request ModifyProtocolServiceRequest
         * @return ModifyProtocolServiceResponse
         */
        public ModifyProtocolServiceResponse ModifyProtocolService(ModifyProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtocolServiceWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a protocol service. You can modify the description of a protocol service.
         *
         * @description This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         *
         * @param request ModifyProtocolServiceRequest
         * @return ModifyProtocolServiceResponse
         */
        public async Task<ModifyProtocolServiceResponse> ModifyProtocolServiceAsync(ModifyProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtocolServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request ModifySmbAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySmbAclResponse
         */
        public ModifySmbAclResponse ModifySmbAclWithOptions(ModifySmbAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAnonymousAccess))
            {
                query["EnableAnonymousAccess"] = request.EnableAnonymousAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptData))
            {
                query["EncryptData"] = request.EncryptData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomeDirPath))
            {
                query["HomeDirPath"] = request.HomeDirPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keytab))
            {
                query["Keytab"] = request.Keytab;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeytabMd5))
            {
                query["KeytabMd5"] = request.KeytabMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectUnencryptedAccess))
            {
                query["RejectUnencryptedAccess"] = request.RejectUnencryptedAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperAdminSid))
            {
                query["SuperAdminSid"] = request.SuperAdminSid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySmbAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySmbAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request ModifySmbAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySmbAclResponse
         */
        public async Task<ModifySmbAclResponse> ModifySmbAclWithOptionsAsync(ModifySmbAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAnonymousAccess))
            {
                query["EnableAnonymousAccess"] = request.EnableAnonymousAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptData))
            {
                query["EncryptData"] = request.EncryptData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomeDirPath))
            {
                query["HomeDirPath"] = request.HomeDirPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keytab))
            {
                query["Keytab"] = request.Keytab;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeytabMd5))
            {
                query["KeytabMd5"] = request.KeytabMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectUnencryptedAccess))
            {
                query["RejectUnencryptedAccess"] = request.RejectUnencryptedAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperAdminSid))
            {
                query["SuperAdminSid"] = request.SuperAdminSid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySmbAcl",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySmbAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request ModifySmbAclRequest
         * @return ModifySmbAclResponse
         */
        public ModifySmbAclResponse ModifySmbAcl(ModifySmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmbAclWithOptions(request, runtime);
        }

        /**
         * @summary Updates the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.
         *
         * @param request ModifySmbAclRequest
         * @return ModifySmbAclResponse
         */
        public async Task<ModifySmbAclResponse> ModifySmbAclAsync(ModifySmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmbAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Activates Apsara File Storage NAS.
         *
         * @param request OpenNASServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenNASServiceResponse
         */
        public OpenNASServiceResponse OpenNASServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenNASService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenNASServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Activates Apsara File Storage NAS.
         *
         * @param request OpenNASServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenNASServiceResponse
         */
        public async Task<OpenNASServiceResponse> OpenNASServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenNASService",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenNASServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Activates Apsara File Storage NAS.
         *
         * @return OpenNASServiceResponse
         */
        public OpenNASServiceResponse OpenNASService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenNASServiceWithOptions(runtime);
        }

        /**
         * @summary Activates Apsara File Storage NAS.
         *
         * @return OpenNASServiceResponse
         */
        public async Task<OpenNASServiceResponse> OpenNASServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenNASServiceWithOptionsAsync(runtime);
        }

        /**
         * @deprecated OpenAPI RemoveClientFromBlackList is deprecated
         *
         * @summary 移除黑名单
         *
         * @description The IP address of a client to remove from the blacklist.
         *
         * @param request RemoveClientFromBlackListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveClientFromBlackListResponse
         */
        // Deprecated
        public RemoveClientFromBlackListResponse RemoveClientFromBlackListWithOptions(RemoveClientFromBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIP))
            {
                query["ClientIP"] = request.ClientIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveClientFromBlackList",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveClientFromBlackListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveClientFromBlackList is deprecated
         *
         * @summary 移除黑名单
         *
         * @description The IP address of a client to remove from the blacklist.
         *
         * @param request RemoveClientFromBlackListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveClientFromBlackListResponse
         */
        // Deprecated
        public async Task<RemoveClientFromBlackListResponse> RemoveClientFromBlackListWithOptionsAsync(RemoveClientFromBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIP))
            {
                query["ClientIP"] = request.ClientIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveClientFromBlackList",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveClientFromBlackListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveClientFromBlackList is deprecated
         *
         * @summary 移除黑名单
         *
         * @description The IP address of a client to remove from the blacklist.
         *
         * @param request RemoveClientFromBlackListRequest
         * @return RemoveClientFromBlackListResponse
         */
        // Deprecated
        public RemoveClientFromBlackListResponse RemoveClientFromBlackList(RemoveClientFromBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveClientFromBlackListWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveClientFromBlackList is deprecated
         *
         * @summary 移除黑名单
         *
         * @description The IP address of a client to remove from the blacklist.
         *
         * @param request RemoveClientFromBlackListRequest
         * @return RemoveClientFromBlackListResponse
         */
        // Deprecated
        public async Task<RemoveClientFromBlackListResponse> RemoveClientFromBlackListAsync(RemoveClientFromBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveClientFromBlackListWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveTags is deprecated, please use NAS::2017-06-26::UntagResources instead.
         *
         * @summary Removes one or more tags from a file system.
         *
         * @description >  The tag feature has been upgraded and this document will be unpublished. For more information, see UntagResources.
         * A request ID is returned even if the tag that you want to remove or the associated file system does not exist. For example, if the associated file system does not exist, or the TagKey and TagValue cannot be found, a request ID is still returned.
         *
         * @param request RemoveTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveTagsResponse
         */
        // Deprecated
        public RemoveTagsResponse RemoveTagsWithOptions(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTags",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveTags is deprecated, please use NAS::2017-06-26::UntagResources instead.
         *
         * @summary Removes one or more tags from a file system.
         *
         * @description >  The tag feature has been upgraded and this document will be unpublished. For more information, see UntagResources.
         * A request ID is returned even if the tag that you want to remove or the associated file system does not exist. For example, if the associated file system does not exist, or the TagKey and TagValue cannot be found, a request ID is still returned.
         *
         * @param request RemoveTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveTagsResponse
         */
        // Deprecated
        public async Task<RemoveTagsResponse> RemoveTagsWithOptionsAsync(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTags",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveTags is deprecated, please use NAS::2017-06-26::UntagResources instead.
         *
         * @summary Removes one or more tags from a file system.
         *
         * @description >  The tag feature has been upgraded and this document will be unpublished. For more information, see UntagResources.
         * A request ID is returned even if the tag that you want to remove or the associated file system does not exist. For example, if the associated file system does not exist, or the TagKey and TagValue cannot be found, a request ID is still returned.
         *
         * @param request RemoveTagsRequest
         * @return RemoveTagsResponse
         */
        // Deprecated
        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveTags is deprecated, please use NAS::2017-06-26::UntagResources instead.
         *
         * @summary Removes one or more tags from a file system.
         *
         * @description >  The tag feature has been upgraded and this document will be unpublished. For more information, see UntagResources.
         * A request ID is returned even if the tag that you want to remove or the associated file system does not exist. For example, if the associated file system does not exist, or the TagKey and TagValue cannot be found, a request ID is still returned.
         *
         * @param request RemoveTagsRequest
         * @return RemoveTagsResponse
         */
        // Deprecated
        public async Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Rolls back a file system to a snapshot of the file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         * *   The file system must be in the Running state.
         * *   To roll back a file system to a snapshot, you must specify the ID of the snapshot that is created from the file system.
         *
         * @param request ResetFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetFileSystemResponse
         */
        public ResetFileSystemResponse ResetFileSystemWithOptions(ResetFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Rolls back a file system to a snapshot of the file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         * *   The file system must be in the Running state.
         * *   To roll back a file system to a snapshot, you must specify the ID of the snapshot that is created from the file system.
         *
         * @param request ResetFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetFileSystemResponse
         */
        public async Task<ResetFileSystemResponse> ResetFileSystemWithOptionsAsync(ResetFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Rolls back a file system to a snapshot of the file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         * *   The file system must be in the Running state.
         * *   To roll back a file system to a snapshot, you must specify the ID of the snapshot that is created from the file system.
         *
         * @param request ResetFileSystemRequest
         * @return ResetFileSystemResponse
         */
        public ResetFileSystemResponse ResetFileSystem(ResetFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetFileSystemWithOptions(request, runtime);
        }

        /**
         * @summary Rolls back a file system to a snapshot of the file system.
         *
         * @description *   The snapshot feature is in public preview and is provided free of charge. [Apsara File Storage NAS Service Level Agreement (SLA)](https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement) is not guaranteed in public preview.
         * *   Only advanced Extreme NAS file systems support this feature.
         * *   The file system must be in the Running state.
         * *   To roll back a file system to a snapshot, you must specify the ID of the snapshot that is created from the file system.
         *
         * @param request ResetFileSystemRequest
         * @return ResetFileSystemResponse
         */
        public async Task<ResetFileSystemResponse> ResetFileSystemAsync(ResetFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetFileSystemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Retries failed a data retrieval task.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request RetryLifecycleRetrieveJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryLifecycleRetrieveJobResponse
         */
        public RetryLifecycleRetrieveJobResponse RetryLifecycleRetrieveJobWithOptions(RetryLifecycleRetrieveJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryLifecycleRetrieveJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryLifecycleRetrieveJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Retries failed a data retrieval task.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request RetryLifecycleRetrieveJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryLifecycleRetrieveJobResponse
         */
        public async Task<RetryLifecycleRetrieveJobResponse> RetryLifecycleRetrieveJobWithOptionsAsync(RetryLifecycleRetrieveJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryLifecycleRetrieveJob",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryLifecycleRetrieveJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Retries failed a data retrieval task.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request RetryLifecycleRetrieveJobRequest
         * @return RetryLifecycleRetrieveJobResponse
         */
        public RetryLifecycleRetrieveJobResponse RetryLifecycleRetrieveJob(RetryLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryLifecycleRetrieveJobWithOptions(request, runtime);
        }

        /**
         * @summary Retries failed a data retrieval task.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request RetryLifecycleRetrieveJobRequest
         * @return RetryLifecycleRetrieveJobResponse
         */
        public async Task<RetryLifecycleRetrieveJobResponse> RetryLifecycleRetrieveJobAsync(RetryLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryLifecycleRetrieveJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a directory quota for a file system.
         *
         * @description Only General-purpose Apsara File Storage NAS (NAS) file systems support the directory quota feature.
         *
         * @param request SetDirQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDirQuotaResponse
         */
        public SetDirQuotaResponse SetDirQuotaWithOptions(SetDirQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCountLimit))
            {
                query["FileCountLimit"] = request.FileCountLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaType))
            {
                query["QuotaType"] = request.QuotaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeLimit))
            {
                query["SizeLimit"] = request.SizeLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDirQuota",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDirQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a directory quota for a file system.
         *
         * @description Only General-purpose Apsara File Storage NAS (NAS) file systems support the directory quota feature.
         *
         * @param request SetDirQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDirQuotaResponse
         */
        public async Task<SetDirQuotaResponse> SetDirQuotaWithOptionsAsync(SetDirQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCountLimit))
            {
                query["FileCountLimit"] = request.FileCountLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaType))
            {
                query["QuotaType"] = request.QuotaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeLimit))
            {
                query["SizeLimit"] = request.SizeLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDirQuota",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDirQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a directory quota for a file system.
         *
         * @description Only General-purpose Apsara File Storage NAS (NAS) file systems support the directory quota feature.
         *
         * @param request SetDirQuotaRequest
         * @return SetDirQuotaResponse
         */
        public SetDirQuotaResponse SetDirQuota(SetDirQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDirQuotaWithOptions(request, runtime);
        }

        /**
         * @summary Creates a directory quota for a file system.
         *
         * @description Only General-purpose Apsara File Storage NAS (NAS) file systems support the directory quota feature.
         *
         * @param request SetDirQuotaRequest
         * @return SetDirQuotaResponse
         */
        public async Task<SetDirQuotaResponse> SetDirQuotaAsync(SetDirQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDirQuotaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can enable the dataflows that are only in the `Stopped` state.
         * *   If the value of DryRun is `true`, you can check whether sufficient resources are available to enable the specified dataflow. If the resources are insufficient, the dataflow cannot be enabled.
         * *   It generally takes 2 to 5 minutes to enable a dataflow. You can query the dataflow status by calling the [DescribeDataFlows](https://help.aliyun.com/document_detail/2402270.html) operation.
         *
         * @param request StartDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartDataFlowResponse
         */
        public StartDataFlowResponse StartDataFlowWithOptions(StartDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDataFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can enable the dataflows that are only in the `Stopped` state.
         * *   If the value of DryRun is `true`, you can check whether sufficient resources are available to enable the specified dataflow. If the resources are insufficient, the dataflow cannot be enabled.
         * *   It generally takes 2 to 5 minutes to enable a dataflow. You can query the dataflow status by calling the [DescribeDataFlows](https://help.aliyun.com/document_detail/2402270.html) operation.
         *
         * @param request StartDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartDataFlowResponse
         */
        public async Task<StartDataFlowResponse> StartDataFlowWithOptionsAsync(StartDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDataFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can enable the dataflows that are only in the `Stopped` state.
         * *   If the value of DryRun is `true`, you can check whether sufficient resources are available to enable the specified dataflow. If the resources are insufficient, the dataflow cannot be enabled.
         * *   It generally takes 2 to 5 minutes to enable a dataflow. You can query the dataflow status by calling the [DescribeDataFlows](https://help.aliyun.com/document_detail/2402270.html) operation.
         *
         * @param request StartDataFlowRequest
         * @return StartDataFlowResponse
         */
        public StartDataFlowResponse StartDataFlow(StartDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDataFlowWithOptions(request, runtime);
        }

        /**
         * @summary Enables a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can enable the dataflows that are only in the `Stopped` state.
         * *   If the value of DryRun is `true`, you can check whether sufficient resources are available to enable the specified dataflow. If the resources are insufficient, the dataflow cannot be enabled.
         * *   It generally takes 2 to 5 minutes to enable a dataflow. You can query the dataflow status by calling the [DescribeDataFlows](https://help.aliyun.com/document_detail/2402270.html) operation.
         *
         * @param request StartDataFlowRequest
         * @return StartDataFlowResponse
         */
        public async Task<StartDataFlowResponse> StartDataFlowAsync(StartDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDataFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can disable only the dataflows that are in the `Running` state.
         * *   After a dataflow is disabled, you cannot create a dataflow task for the dataflow. If AutoRefresh is configured, source data updates are not synchronized to CPFS.
         * *   After a dataflow is disabled, the dataflow throughput is no longer billed because resources are reclaimed. However, the dataflow may fail to be restarted due to insufficient resources.
         * *   It generally takes 2 to 5 minutes to disable a dataflow. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/2402271.html) operation to query the dataflow status.
         *
         * @param request StopDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopDataFlowResponse
         */
        public StopDataFlowResponse StopDataFlowWithOptions(StopDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDataFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can disable only the dataflows that are in the `Running` state.
         * *   After a dataflow is disabled, you cannot create a dataflow task for the dataflow. If AutoRefresh is configured, source data updates are not synchronized to CPFS.
         * *   After a dataflow is disabled, the dataflow throughput is no longer billed because resources are reclaimed. However, the dataflow may fail to be restarted due to insufficient resources.
         * *   It generally takes 2 to 5 minutes to disable a dataflow. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/2402271.html) operation to query the dataflow status.
         *
         * @param request StopDataFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopDataFlowResponse
         */
        public async Task<StopDataFlowResponse> StopDataFlowWithOptionsAsync(StopDataFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDataFlow",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDataFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can disable only the dataflows that are in the `Running` state.
         * *   After a dataflow is disabled, you cannot create a dataflow task for the dataflow. If AutoRefresh is configured, source data updates are not synchronized to CPFS.
         * *   After a dataflow is disabled, the dataflow throughput is no longer billed because resources are reclaimed. However, the dataflow may fail to be restarted due to insufficient resources.
         * *   It generally takes 2 to 5 minutes to disable a dataflow. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/2402271.html) operation to query the dataflow status.
         *
         * @param request StopDataFlowRequest
         * @return StopDataFlowResponse
         */
        public StopDataFlowResponse StopDataFlow(StopDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDataFlowWithOptions(request, runtime);
        }

        /**
         * @summary Disables a dataflow.
         *
         * @description *   This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).
         * *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
         * *   You can disable only the dataflows that are in the `Running` state.
         * *   After a dataflow is disabled, you cannot create a dataflow task for the dataflow. If AutoRefresh is configured, source data updates are not synchronized to CPFS.
         * *   After a dataflow is disabled, the dataflow throughput is no longer billed because resources are reclaimed. However, the dataflow may fail to be restarted due to insufficient resources.
         * *   It generally takes 2 to 5 minutes to disable a dataflow. You can call the [DescribeDataFlows](https://help.aliyun.com/document_detail/2402271.html) operation to query the dataflow status.
         *
         * @param request StopDataFlowRequest
         * @return StopDataFlowResponse
         */
        public async Task<StopDataFlowResponse> StopDataFlowAsync(StopDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDataFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates tags and binds the tags to file systems.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates tags and binds the tags to file systems.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates tags and binds the tags to file systems.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Creates tags and binds the tags to file systems.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes tags from a file system.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes tags from a file system.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes tags from a file system.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Removes tags from a file system.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the retention period of data in the recycle bin of a file system.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request UpdateRecycleBinAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRecycleBinAttributeResponse
         */
        public UpdateRecycleBinAttributeResponse UpdateRecycleBinAttributeWithOptions(UpdateRecycleBinAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecycleBinAttribute",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecycleBinAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the retention period of data in the recycle bin of a file system.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request UpdateRecycleBinAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRecycleBinAttributeResponse
         */
        public async Task<UpdateRecycleBinAttributeResponse> UpdateRecycleBinAttributeWithOptionsAsync(UpdateRecycleBinAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecycleBinAttribute",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecycleBinAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the retention period of data in the recycle bin of a file system.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request UpdateRecycleBinAttributeRequest
         * @return UpdateRecycleBinAttributeResponse
         */
        public UpdateRecycleBinAttributeResponse UpdateRecycleBinAttribute(UpdateRecycleBinAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecycleBinAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the retention period of data in the recycle bin of a file system.
         *
         * @description Only General-purpose NAS file systems support this operation.
         *
         * @param request UpdateRecycleBinAttributeRequest
         * @return UpdateRecycleBinAttributeResponse
         */
        public async Task<UpdateRecycleBinAttributeResponse> UpdateRecycleBinAttributeAsync(UpdateRecycleBinAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecycleBinAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Scales up an Extreme NAS file system or a Cloud Parallel File Storage (CPFS) file system.
         *
         * @description *   Only Extreme NAS file systems and CPFS file systems can be scaled up. CPFS file systems are available only on the China site (aliyun.com).
         * *   A General-purpose NAS file system is automatically scaled up. You do not need to call this operation to scale up a General-purpose NAS file system.
         *
         * @param request UpgradeFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeFileSystemResponse
         */
        public UpgradeFileSystemResponse UpgradeFileSystemWithOptions(UpgradeFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Scales up an Extreme NAS file system or a Cloud Parallel File Storage (CPFS) file system.
         *
         * @description *   Only Extreme NAS file systems and CPFS file systems can be scaled up. CPFS file systems are available only on the China site (aliyun.com).
         * *   A General-purpose NAS file system is automatically scaled up. You do not need to call this operation to scale up a General-purpose NAS file system.
         *
         * @param request UpgradeFileSystemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeFileSystemResponse
         */
        public async Task<UpgradeFileSystemResponse> UpgradeFileSystemWithOptionsAsync(UpgradeFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeFileSystem",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Scales up an Extreme NAS file system or a Cloud Parallel File Storage (CPFS) file system.
         *
         * @description *   Only Extreme NAS file systems and CPFS file systems can be scaled up. CPFS file systems are available only on the China site (aliyun.com).
         * *   A General-purpose NAS file system is automatically scaled up. You do not need to call this operation to scale up a General-purpose NAS file system.
         *
         * @param request UpgradeFileSystemRequest
         * @return UpgradeFileSystemResponse
         */
        public UpgradeFileSystemResponse UpgradeFileSystem(UpgradeFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeFileSystemWithOptions(request, runtime);
        }

        /**
         * @summary Scales up an Extreme NAS file system or a Cloud Parallel File Storage (CPFS) file system.
         *
         * @description *   Only Extreme NAS file systems and CPFS file systems can be scaled up. CPFS file systems are available only on the China site (aliyun.com).
         * *   A General-purpose NAS file system is automatically scaled up. You do not need to call this operation to scale up a General-purpose NAS file system.
         *
         * @param request UpgradeFileSystemRequest
         * @return UpgradeFileSystemResponse
         */
        public async Task<UpgradeFileSystemResponse> UpgradeFileSystemAsync(UpgradeFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeFileSystemWithOptionsAsync(request, runtime);
        }

    }
}
