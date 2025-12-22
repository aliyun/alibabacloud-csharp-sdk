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
                {"cn-hangzhou-finance", "nas.cn-hangzhou-dg-a01.aliyuncs.com"},
                {"ap-northeast-2-pop", "nas.aliyuncs.com"},
                {"ap-southeast-2", "nas.aliyuncs.com"},
                {"cn-beijing-finance-pop", "nas.aliyuncs.com"},
                {"cn-beijing-gov-1", "nas.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "nas.aliyuncs.com"},
                {"cn-edge-1", "nas.aliyuncs.com"},
                {"cn-fujian", "nas.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "nas.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "nas.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "nas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "nas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "nas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "nas.aliyuncs.com"},
                {"cn-hangzhou-test-306", "nas.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "nas.aliyuncs.com"},
                {"cn-qingdao-nebula", "nas.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "nas.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "nas.aliyuncs.com"},
                {"cn-shanghai-inner", "nas.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "nas.aliyuncs.com"},
                {"cn-shenzhen-inner", "nas.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "nas.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "nas.aliyuncs.com"},
                {"cn-wuhan", "nas.aliyuncs.com"},
                {"cn-yushanfang", "nas.aliyuncs.com"},
                {"cn-zhangbei", "nas.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "nas.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "nas.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "nas.aliyuncs.com"},
                {"eu-west-1-oxs", "nas.aliyuncs.com"},
                {"rus-west-1-pop", "nas.aliyuncs.com"},
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AddClientToBlackList is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a client to the blacklist of a Cloud Parallel File Storage (CPFS) file system and revokes the write access from the client. The blacklist serves as an I/O fence.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddClientToBlackListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddClientToBlackListResponse
        /// </returns>
        [Obsolete("OpenAPI AddClientToBlackList is deprecated")]
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AddClientToBlackList is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a client to the blacklist of a Cloud Parallel File Storage (CPFS) file system and revokes the write access from the client. The blacklist serves as an I/O fence.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddClientToBlackListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddClientToBlackListResponse
        /// </returns>
        [Obsolete("OpenAPI AddClientToBlackList is deprecated")]
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AddClientToBlackList is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a client to the blacklist of a Cloud Parallel File Storage (CPFS) file system and revokes the write access from the client. The blacklist serves as an I/O fence.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddClientToBlackListRequest
        /// </param>
        /// 
        /// <returns>
        /// AddClientToBlackListResponse
        /// </returns>
        [Obsolete("OpenAPI AddClientToBlackList is deprecated")]
        // Deprecated
        public AddClientToBlackListResponse AddClientToBlackList(AddClientToBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddClientToBlackListWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AddClientToBlackList is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a client to the blacklist of a Cloud Parallel File Storage (CPFS) file system and revokes the write access from the client. The blacklist serves as an I/O fence.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddClientToBlackListRequest
        /// </param>
        /// 
        /// <returns>
        /// AddClientToBlackListResponse
        /// </returns>
        [Obsolete("OpenAPI AddClientToBlackList is deprecated")]
        // Deprecated
        public async Task<AddClientToBlackListResponse> AddClientToBlackListAsync(AddClientToBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddClientToBlackListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies an automatic snapshot policy to one or more file systems.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// <item><description>You can apply only one automatic snapshot policy to each file system.</description></item>
        /// <item><description>Each automatic snapshot policy can be applied to multiple file systems.</description></item>
        /// <item><description>If an automatic snapshot policy is applied to a file system, you can call the ApplyAutoSnapshotPolicy operation to change the automatic snapshot policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies an automatic snapshot policy to one or more file systems.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// <item><description>You can apply only one automatic snapshot policy to each file system.</description></item>
        /// <item><description>Each automatic snapshot policy can be applied to multiple file systems.</description></item>
        /// <item><description>If an automatic snapshot policy is applied to a file system, you can call the ApplyAutoSnapshotPolicy operation to change the automatic snapshot policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies an automatic snapshot policy to one or more file systems.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// <item><description>You can apply only one automatic snapshot policy to each file system.</description></item>
        /// <item><description>Each automatic snapshot policy can be applied to multiple file systems.</description></item>
        /// <item><description>If an automatic snapshot policy is applied to a file system, you can call the ApplyAutoSnapshotPolicy operation to change the automatic snapshot policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyAutoSnapshotPolicyResponse
        /// </returns>
        public ApplyAutoSnapshotPolicyResponse ApplyAutoSnapshotPolicy(ApplyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies an automatic snapshot policy to one or more file systems.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// <item><description>You can apply only one automatic snapshot policy to each file system.</description></item>
        /// <item><description>Each automatic snapshot policy can be applied to multiple file systems.</description></item>
        /// <item><description>If an automatic snapshot policy is applied to a file system, you can call the ApplyAutoSnapshotPolicy operation to change the automatic snapshot policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<ApplyAutoSnapshotPolicyResponse> ApplyAutoSnapshotPolicyAsync(ApplyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds AutoRefresh configurations to a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can add AutoRefresh configurations only to the dataflows that are in the <c>Running</c> state.</description></item>
        /// <item><description>You can add a maximum of five AutoRefresh configurations to a dataflow.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to create an AutoRefresh configuration. You can call the <a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a> operation to query the dataflow status.</description></item>
        /// <item><description>AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first <a href="https://help.aliyun.com/document_detail/182246.html">activate EventBridge</a>.
        /// **
        /// <b>Note</b> The event buses and event rules created for CPFS in the EventBridge console contain the <c>Create for cpfs auto refresh</c> description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.</description></item>
        /// <item><description>The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. When you add an AutoRefresh configuration to the prefix for a CPFS dataflow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.</description></item>
        /// <item><description>After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.</description></item>
        /// <item><description>AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes Misconfigured. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyDataFlowAutoRefreshRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyDataFlowAutoRefreshResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds AutoRefresh configurations to a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can add AutoRefresh configurations only to the dataflows that are in the <c>Running</c> state.</description></item>
        /// <item><description>You can add a maximum of five AutoRefresh configurations to a dataflow.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to create an AutoRefresh configuration. You can call the <a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a> operation to query the dataflow status.</description></item>
        /// <item><description>AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first <a href="https://help.aliyun.com/document_detail/182246.html">activate EventBridge</a>.
        /// **
        /// <b>Note</b> The event buses and event rules created for CPFS in the EventBridge console contain the <c>Create for cpfs auto refresh</c> description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.</description></item>
        /// <item><description>The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. When you add an AutoRefresh configuration to the prefix for a CPFS dataflow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.</description></item>
        /// <item><description>After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.</description></item>
        /// <item><description>AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes Misconfigured. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyDataFlowAutoRefreshRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyDataFlowAutoRefreshResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds AutoRefresh configurations to a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can add AutoRefresh configurations only to the dataflows that are in the <c>Running</c> state.</description></item>
        /// <item><description>You can add a maximum of five AutoRefresh configurations to a dataflow.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to create an AutoRefresh configuration. You can call the <a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a> operation to query the dataflow status.</description></item>
        /// <item><description>AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first <a href="https://help.aliyun.com/document_detail/182246.html">activate EventBridge</a>.
        /// **
        /// <b>Note</b> The event buses and event rules created for CPFS in the EventBridge console contain the <c>Create for cpfs auto refresh</c> description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.</description></item>
        /// <item><description>The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. When you add an AutoRefresh configuration to the prefix for a CPFS dataflow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.</description></item>
        /// <item><description>After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.</description></item>
        /// <item><description>AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes Misconfigured. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyDataFlowAutoRefreshRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyDataFlowAutoRefreshResponse
        /// </returns>
        public ApplyDataFlowAutoRefreshResponse ApplyDataFlowAutoRefresh(ApplyDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyDataFlowAutoRefreshWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds AutoRefresh configurations to a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can add AutoRefresh configurations only to the dataflows that are in the <c>Running</c> state.</description></item>
        /// <item><description>You can add a maximum of five AutoRefresh configurations to a dataflow.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to create an AutoRefresh configuration. You can call the <a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a> operation to query the dataflow status.</description></item>
        /// <item><description>AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first <a href="https://help.aliyun.com/document_detail/182246.html">activate EventBridge</a>.
        /// **
        /// <b>Note</b> The event buses and event rules created for CPFS in the EventBridge console contain the <c>Create for cpfs auto refresh</c> description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.</description></item>
        /// <item><description>The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. When you add an AutoRefresh configuration to the prefix for a CPFS dataflow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.</description></item>
        /// <item><description>After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.</description></item>
        /// <item><description>AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes Misconfigured. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyDataFlowAutoRefreshRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyDataFlowAutoRefreshResponse
        /// </returns>
        public async Task<ApplyDataFlowAutoRefreshResponse> ApplyDataFlowAutoRefreshAsync(ApplyDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyDataFlowAutoRefreshWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates the VSC device with the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachVscToFilesystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachVscToFilesystemsResponse
        /// </returns>
        public AttachVscToFilesystemsResponse AttachVscToFilesystemsWithOptions(AttachVscToFilesystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVscToFilesystems",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVscToFilesystemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates the VSC device with the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachVscToFilesystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachVscToFilesystemsResponse
        /// </returns>
        public async Task<AttachVscToFilesystemsResponse> AttachVscToFilesystemsWithOptionsAsync(AttachVscToFilesystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVscToFilesystems",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVscToFilesystemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates the VSC device with the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachVscToFilesystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachVscToFilesystemsResponse
        /// </returns>
        public AttachVscToFilesystemsResponse AttachVscToFilesystems(AttachVscToFilesystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachVscToFilesystemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates the VSC device with the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachVscToFilesystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachVscToFilesystemsResponse
        /// </returns>
        public async Task<AttachVscToFilesystemsResponse> AttachVscToFilesystemsAsync(AttachVscToFilesystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachVscToFilesystemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes automatic snapshot policies from one or more file systems.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes automatic snapshot policies from one or more file systems.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes automatic snapshot policies from one or more file systems.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAutoSnapshotPolicyResponse
        /// </returns>
        public CancelAutoSnapshotPolicyResponse CancelAutoSnapshotPolicy(CancelAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes automatic snapshot policies from one or more file systems.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<CancelAutoSnapshotPolicyResponse> CancelAutoSnapshotPolicyAsync(CancelAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the AutoRefresh configuration for a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can cancel AutoRefresh configurations only for the dataflows that are in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to cancel the AutoRefresh configurations. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the status of the AutoRefresh tasks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowAutoRefreshRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowAutoRefreshResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the AutoRefresh configuration for a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can cancel AutoRefresh configurations only for the dataflows that are in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to cancel the AutoRefresh configurations. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the status of the AutoRefresh tasks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowAutoRefreshRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowAutoRefreshResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the AutoRefresh configuration for a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can cancel AutoRefresh configurations only for the dataflows that are in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to cancel the AutoRefresh configurations. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the status of the AutoRefresh tasks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowAutoRefreshRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowAutoRefreshResponse
        /// </returns>
        public CancelDataFlowAutoRefreshResponse CancelDataFlowAutoRefresh(CancelDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDataFlowAutoRefreshWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the AutoRefresh configuration for a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can cancel AutoRefresh configurations only for the dataflows that are in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to cancel the AutoRefresh configurations. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the status of the AutoRefresh tasks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowAutoRefreshRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowAutoRefreshResponse
        /// </returns>
        public async Task<CancelDataFlowAutoRefreshResponse> CancelDataFlowAutoRefreshAsync(CancelDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDataFlowAutoRefreshWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a data streaming task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel a data streaming task only when the task is in the CREATED or RUNNING state.</description></item>
        /// <item><description>Data streaming tasks are executed asynchronously. You can call the DescribeDataFlowSubTasks operation to query the task execution status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowSubTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowSubTaskResponse
        /// </returns>
        public CancelDataFlowSubTaskResponse CancelDataFlowSubTaskWithOptions(CancelDataFlowSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowSubTaskId))
            {
                query["DataFlowSubTaskId"] = request.DataFlowSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowTaskId))
            {
                query["DataFlowTaskId"] = request.DataFlowTaskId;
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
                Action = "CancelDataFlowSubTask",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDataFlowSubTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a data streaming task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel a data streaming task only when the task is in the CREATED or RUNNING state.</description></item>
        /// <item><description>Data streaming tasks are executed asynchronously. You can call the DescribeDataFlowSubTasks operation to query the task execution status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowSubTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowSubTaskResponse
        /// </returns>
        public async Task<CancelDataFlowSubTaskResponse> CancelDataFlowSubTaskWithOptionsAsync(CancelDataFlowSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowSubTaskId))
            {
                query["DataFlowSubTaskId"] = request.DataFlowSubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowTaskId))
            {
                query["DataFlowTaskId"] = request.DataFlowTaskId;
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
                Action = "CancelDataFlowSubTask",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDataFlowSubTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a data streaming task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel a data streaming task only when the task is in the CREATED or RUNNING state.</description></item>
        /// <item><description>Data streaming tasks are executed asynchronously. You can call the DescribeDataFlowSubTasks operation to query the task execution status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowSubTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowSubTaskResponse
        /// </returns>
        public CancelDataFlowSubTaskResponse CancelDataFlowSubTask(CancelDataFlowSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDataFlowSubTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a data streaming task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel a data streaming task only when the task is in the CREATED or RUNNING state.</description></item>
        /// <item><description>Data streaming tasks are executed asynchronously. You can call the DescribeDataFlowSubTasks operation to query the task execution status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowSubTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowSubTaskResponse
        /// </returns>
        public async Task<CancelDataFlowSubTaskResponse> CancelDataFlowSubTaskAsync(CancelDataFlowSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDataFlowSubTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a batch or streaming task that is in the Pending or Execute state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel only the data flow tasks that are in the <c>Pending</c> and <c>Executing</c> states.</description></item>
        /// <item><description>It generally takes 5 to 10 minutes to cancel a data flow task. You can query the task execution status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation.</description></item>
        /// <item><description>If a data streaming task contains running subtasks, you cannot cancel the streaming task. Otherwise, an InvalidStatus.ResourceMismatch error message is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a batch or streaming task that is in the Pending or Execute state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel only the data flow tasks that are in the <c>Pending</c> and <c>Executing</c> states.</description></item>
        /// <item><description>It generally takes 5 to 10 minutes to cancel a data flow task. You can query the task execution status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation.</description></item>
        /// <item><description>If a data streaming task contains running subtasks, you cannot cancel the streaming task. Otherwise, an InvalidStatus.ResourceMismatch error message is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a batch or streaming task that is in the Pending or Execute state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel only the data flow tasks that are in the <c>Pending</c> and <c>Executing</c> states.</description></item>
        /// <item><description>It generally takes 5 to 10 minutes to cancel a data flow task. You can query the task execution status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation.</description></item>
        /// <item><description>If a data streaming task contains running subtasks, you cannot cancel the streaming task. Otherwise, an InvalidStatus.ResourceMismatch error message is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowTaskResponse
        /// </returns>
        public CancelDataFlowTaskResponse CancelDataFlowTask(CancelDataFlowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDataFlowTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a batch or streaming task that is in the Pending or Execute state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel only the data flow tasks that are in the <c>Pending</c> and <c>Executing</c> states.</description></item>
        /// <item><description>It generally takes 5 to 10 minutes to cancel a data flow task. You can query the task execution status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation.</description></item>
        /// <item><description>If a data streaming task contains running subtasks, you cannot cancel the streaming task. Otherwise, an InvalidStatus.ResourceMismatch error message is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDataFlowTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDataFlowTaskResponse
        /// </returns>
        public async Task<CancelDataFlowTaskResponse> CancelDataFlowTaskAsync(CancelDataFlowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDataFlowTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the directory quota of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDirQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDirQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the directory quota of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDirQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDirQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the directory quota of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDirQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDirQuotaResponse
        /// </returns>
        public CancelDirQuotaResponse CancelDirQuota(CancelDirQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDirQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the directory quota of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelDirQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDirQuotaResponse
        /// </returns>
        public async Task<CancelDirQuotaResponse> CancelDirQuotaAsync(CancelDirQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDirQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the quota set for a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.7.0 and later support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelFilesetQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelFilesetQuotaResponse
        /// </returns>
        public CancelFilesetQuotaResponse CancelFilesetQuotaWithOptions(CancelFilesetQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelFilesetQuota",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelFilesetQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the quota set for a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.7.0 and later support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelFilesetQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelFilesetQuotaResponse
        /// </returns>
        public async Task<CancelFilesetQuotaResponse> CancelFilesetQuotaWithOptionsAsync(CancelFilesetQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelFilesetQuota",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelFilesetQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the quota set for a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.7.0 and later support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelFilesetQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelFilesetQuotaResponse
        /// </returns>
        public CancelFilesetQuotaResponse CancelFilesetQuota(CancelFilesetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelFilesetQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the quota set for a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.7.0 and later support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelFilesetQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelFilesetQuotaResponse
        /// </returns>
        public async Task<CancelFilesetQuotaResponse> CancelFilesetQuotaAsync(CancelFilesetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelFilesetQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a running data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelLifecycleRetrieveJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelLifecycleRetrieveJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a running data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelLifecycleRetrieveJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelLifecycleRetrieveJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a running data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelLifecycleRetrieveJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelLifecycleRetrieveJobResponse
        /// </returns>
        public CancelLifecycleRetrieveJobResponse CancelLifecycleRetrieveJob(CancelLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelLifecycleRetrieveJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a running data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelLifecycleRetrieveJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelLifecycleRetrieveJobResponse
        /// </returns>
        public async Task<CancelLifecycleRetrieveJobResponse> CancelLifecycleRetrieveJobAsync(CancelLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelLifecycleRetrieveJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a running job of the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel only jobs that are in the Running state. You cannot cancel jobs that are in the PartialSuccess, Success, Fail, or Cancelled state.</description></item>
        /// <item><description>If you cancel a running job that permanently deletes files, you cannot restore the files that are already permanently deleted.</description></item>
        /// <item><description>If you cancel a running job that restores files, you can query the restored files from the file system, and query the unrestored files from the recycle bin.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRecycleBinJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRecycleBinJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a running job of the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel only jobs that are in the Running state. You cannot cancel jobs that are in the PartialSuccess, Success, Fail, or Cancelled state.</description></item>
        /// <item><description>If you cancel a running job that permanently deletes files, you cannot restore the files that are already permanently deleted.</description></item>
        /// <item><description>If you cancel a running job that restores files, you can query the restored files from the file system, and query the unrestored files from the recycle bin.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRecycleBinJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRecycleBinJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a running job of the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel only jobs that are in the Running state. You cannot cancel jobs that are in the PartialSuccess, Success, Fail, or Cancelled state.</description></item>
        /// <item><description>If you cancel a running job that permanently deletes files, you cannot restore the files that are already permanently deleted.</description></item>
        /// <item><description>If you cancel a running job that restores files, you can query the restored files from the file system, and query the unrestored files from the recycle bin.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRecycleBinJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRecycleBinJobResponse
        /// </returns>
        public CancelRecycleBinJobResponse CancelRecycleBinJob(CancelRecycleBinJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRecycleBinJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a running job of the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can cancel only jobs that are in the Running state. You cannot cancel jobs that are in the PartialSuccess, Success, Fail, or Cancelled state.</description></item>
        /// <item><description>If you cancel a running job that permanently deletes files, you cannot restore the files that are already permanently deleted.</description></item>
        /// <item><description>If you cancel a running job that restores files, you can query the restored files from the file system, and query the unrestored files from the recycle bin.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRecycleBinJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRecycleBinJobResponse
        /// </returns>
        public async Task<CancelRecycleBinJobResponse> CancelRecycleBinJobAsync(CancelRecycleBinJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRecycleBinJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a file system belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a file system belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a file system belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a file system belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessGroupResponse
        /// </returns>
        public CreateAccessGroupResponse CreateAccessGroup(CreateAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessGroupResponse
        /// </returns>
        public async Task<CreateAccessGroupResponse> CreateAccessGroupAsync(CreateAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you call the CreateAccessPoint operation, an access point is not immediately created. Therefore, after you call the CreateAccessPoint operation successfully, call the <a href="https://help.aliyun.com/document_detail/2712239.html">DescribeAccessPoints</a> or <a href="https://help.aliyun.com/document_detail/2712240.html">DescribeAccessPoint</a> operation to query the status of the access point. If the status is <b>Active</b>, mount the file system. Otherwise, the file system may fail to be mounted.</para>
        /// <list type="bullet">
        /// <item><description>Only General-purpose Network File System (NFS) file systems support access points.</description></item>
        /// <item><description>If you want to call the EnabledRam operation to enable a Resource Access Management (RAM) policy, you must configure the corresponding RAM permissions. For more information, see <a href="https://help.aliyun.com/document_detail/2545998.html">Manage endpoints</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessPointResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you call the CreateAccessPoint operation, an access point is not immediately created. Therefore, after you call the CreateAccessPoint operation successfully, call the <a href="https://help.aliyun.com/document_detail/2712239.html">DescribeAccessPoints</a> or <a href="https://help.aliyun.com/document_detail/2712240.html">DescribeAccessPoint</a> operation to query the status of the access point. If the status is <b>Active</b>, mount the file system. Otherwise, the file system may fail to be mounted.</para>
        /// <list type="bullet">
        /// <item><description>Only General-purpose Network File System (NFS) file systems support access points.</description></item>
        /// <item><description>If you want to call the EnabledRam operation to enable a Resource Access Management (RAM) policy, you must configure the corresponding RAM permissions. For more information, see <a href="https://help.aliyun.com/document_detail/2545998.html">Manage endpoints</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessPointResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you call the CreateAccessPoint operation, an access point is not immediately created. Therefore, after you call the CreateAccessPoint operation successfully, call the <a href="https://help.aliyun.com/document_detail/2712239.html">DescribeAccessPoints</a> or <a href="https://help.aliyun.com/document_detail/2712240.html">DescribeAccessPoint</a> operation to query the status of the access point. If the status is <b>Active</b>, mount the file system. Otherwise, the file system may fail to be mounted.</para>
        /// <list type="bullet">
        /// <item><description>Only General-purpose Network File System (NFS) file systems support access points.</description></item>
        /// <item><description>If you want to call the EnabledRam operation to enable a Resource Access Management (RAM) policy, you must configure the corresponding RAM permissions. For more information, see <a href="https://help.aliyun.com/document_detail/2545998.html">Manage endpoints</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessPointResponse
        /// </returns>
        public CreateAccessPointResponse CreateAccessPoint(CreateAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you call the CreateAccessPoint operation, an access point is not immediately created. Therefore, after you call the CreateAccessPoint operation successfully, call the <a href="https://help.aliyun.com/document_detail/2712239.html">DescribeAccessPoints</a> or <a href="https://help.aliyun.com/document_detail/2712240.html">DescribeAccessPoint</a> operation to query the status of the access point. If the status is <b>Active</b>, mount the file system. Otherwise, the file system may fail to be mounted.</para>
        /// <list type="bullet">
        /// <item><description>Only General-purpose Network File System (NFS) file systems support access points.</description></item>
        /// <item><description>If you want to call the EnabledRam operation to enable a Resource Access Management (RAM) policy, you must configure the corresponding RAM permissions. For more information, see <a href="https://help.aliyun.com/document_detail/2545998.html">Manage endpoints</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessPointResponse
        /// </returns>
        public async Task<CreateAccessPointResponse> CreateAccessPointAsync(CreateAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule for a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessRuleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule for a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessRuleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule for a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessRuleResponse
        /// </returns>
        public CreateAccessRuleResponse CreateAccessRule(CreateAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule for a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessRuleResponse
        /// </returns>
        public async Task<CreateAccessRuleResponse> CreateAccessRuleAsync(CreateAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an automatic snapshot policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>You can create a maximum of 100 automatic snapshot policies in each region for an Alibaba Cloud account.</description></item>
        /// <item><description>If an auto snapshot is being created when the scheduled time for a new auto snapshot arrives, the creation of the new snapshot is skipped. This occurs if the file system stores a large volume of data. For example, you have scheduled auto snapshots to be created at 09:00:00, 10:00:00, 11:00:00, and 12:00:00 for a file system. The system starts to create an auto snapshot at 09:00:00 and does not complete the process until 10:20:00. The process takes 80 minutes because the file system has a large volume of data. In this case, the system does not create an auto snapshot at 10:00:00, but creates an auto snapshot at 11:00:00.</description></item>
        /// <item><description>A maximum of 128 auto snapshots can be created for a file system. If the upper limit is reached, the earliest auto snapshot is deleted. This rule does not apply to manual snapshots.</description></item>
        /// <item><description>If you modify the retention period of an automatic snapshot policy, the modification applies only to subsequent snapshots, but not to the existing snapshots.</description></item>
        /// <item><description>If an auto snapshot is being created for a file system, you cannot create a manual snapshot for the file system. You must wait after the auto snapshot is created.</description></item>
        /// <item><description>You can only apply automatic snapshot policies to a file system that is in the Running state.</description></item>
        /// <item><description>All auto snapshots are named in the <c>auto_yyyyMMdd_X</c> format, where: <c>auto</c> indicates that the snapshot is created based on an automatic snapshot policy. <c>yyyyMMdd</c> indicates the date on which the snapshot is created. <c>y</c> indicates the year. <c>M</c> indicates the month. <c>d</c> indicates the day. <c>X</c> indicates the ordinal number of the snapshot on the current day. For example, <c>auto_20201018_1</c> indicates the first auto snapshot that was created on October 18, 2020.</description></item>
        /// <item><description>After an automatic snapshot policy is created, you can call the ApplyAutoSnapshotPolicy operation to apply the policy to a file system and call the ModifyAutoSnapshotPolicy operation to modify the policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an automatic snapshot policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>You can create a maximum of 100 automatic snapshot policies in each region for an Alibaba Cloud account.</description></item>
        /// <item><description>If an auto snapshot is being created when the scheduled time for a new auto snapshot arrives, the creation of the new snapshot is skipped. This occurs if the file system stores a large volume of data. For example, you have scheduled auto snapshots to be created at 09:00:00, 10:00:00, 11:00:00, and 12:00:00 for a file system. The system starts to create an auto snapshot at 09:00:00 and does not complete the process until 10:20:00. The process takes 80 minutes because the file system has a large volume of data. In this case, the system does not create an auto snapshot at 10:00:00, but creates an auto snapshot at 11:00:00.</description></item>
        /// <item><description>A maximum of 128 auto snapshots can be created for a file system. If the upper limit is reached, the earliest auto snapshot is deleted. This rule does not apply to manual snapshots.</description></item>
        /// <item><description>If you modify the retention period of an automatic snapshot policy, the modification applies only to subsequent snapshots, but not to the existing snapshots.</description></item>
        /// <item><description>If an auto snapshot is being created for a file system, you cannot create a manual snapshot for the file system. You must wait after the auto snapshot is created.</description></item>
        /// <item><description>You can only apply automatic snapshot policies to a file system that is in the Running state.</description></item>
        /// <item><description>All auto snapshots are named in the <c>auto_yyyyMMdd_X</c> format, where: <c>auto</c> indicates that the snapshot is created based on an automatic snapshot policy. <c>yyyyMMdd</c> indicates the date on which the snapshot is created. <c>y</c> indicates the year. <c>M</c> indicates the month. <c>d</c> indicates the day. <c>X</c> indicates the ordinal number of the snapshot on the current day. For example, <c>auto_20201018_1</c> indicates the first auto snapshot that was created on October 18, 2020.</description></item>
        /// <item><description>After an automatic snapshot policy is created, you can call the ApplyAutoSnapshotPolicy operation to apply the policy to a file system and call the ModifyAutoSnapshotPolicy operation to modify the policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an automatic snapshot policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>You can create a maximum of 100 automatic snapshot policies in each region for an Alibaba Cloud account.</description></item>
        /// <item><description>If an auto snapshot is being created when the scheduled time for a new auto snapshot arrives, the creation of the new snapshot is skipped. This occurs if the file system stores a large volume of data. For example, you have scheduled auto snapshots to be created at 09:00:00, 10:00:00, 11:00:00, and 12:00:00 for a file system. The system starts to create an auto snapshot at 09:00:00 and does not complete the process until 10:20:00. The process takes 80 minutes because the file system has a large volume of data. In this case, the system does not create an auto snapshot at 10:00:00, but creates an auto snapshot at 11:00:00.</description></item>
        /// <item><description>A maximum of 128 auto snapshots can be created for a file system. If the upper limit is reached, the earliest auto snapshot is deleted. This rule does not apply to manual snapshots.</description></item>
        /// <item><description>If you modify the retention period of an automatic snapshot policy, the modification applies only to subsequent snapshots, but not to the existing snapshots.</description></item>
        /// <item><description>If an auto snapshot is being created for a file system, you cannot create a manual snapshot for the file system. You must wait after the auto snapshot is created.</description></item>
        /// <item><description>You can only apply automatic snapshot policies to a file system that is in the Running state.</description></item>
        /// <item><description>All auto snapshots are named in the <c>auto_yyyyMMdd_X</c> format, where: <c>auto</c> indicates that the snapshot is created based on an automatic snapshot policy. <c>yyyyMMdd</c> indicates the date on which the snapshot is created. <c>y</c> indicates the year. <c>M</c> indicates the month. <c>d</c> indicates the day. <c>X</c> indicates the ordinal number of the snapshot on the current day. For example, <c>auto_20201018_1</c> indicates the first auto snapshot that was created on October 18, 2020.</description></item>
        /// <item><description>After an automatic snapshot policy is created, you can call the ApplyAutoSnapshotPolicy operation to apply the policy to a file system and call the ModifyAutoSnapshotPolicy operation to modify the policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoSnapshotPolicyResponse
        /// </returns>
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an automatic snapshot policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>You can create a maximum of 100 automatic snapshot policies in each region for an Alibaba Cloud account.</description></item>
        /// <item><description>If an auto snapshot is being created when the scheduled time for a new auto snapshot arrives, the creation of the new snapshot is skipped. This occurs if the file system stores a large volume of data. For example, you have scheduled auto snapshots to be created at 09:00:00, 10:00:00, 11:00:00, and 12:00:00 for a file system. The system starts to create an auto snapshot at 09:00:00 and does not complete the process until 10:20:00. The process takes 80 minutes because the file system has a large volume of data. In this case, the system does not create an auto snapshot at 10:00:00, but creates an auto snapshot at 11:00:00.</description></item>
        /// <item><description>A maximum of 128 auto snapshots can be created for a file system. If the upper limit is reached, the earliest auto snapshot is deleted. This rule does not apply to manual snapshots.</description></item>
        /// <item><description>If you modify the retention period of an automatic snapshot policy, the modification applies only to subsequent snapshots, but not to the existing snapshots.</description></item>
        /// <item><description>If an auto snapshot is being created for a file system, you cannot create a manual snapshot for the file system. You must wait after the auto snapshot is created.</description></item>
        /// <item><description>You can only apply automatic snapshot policies to a file system that is in the Running state.</description></item>
        /// <item><description>All auto snapshots are named in the <c>auto_yyyyMMdd_X</c> format, where: <c>auto</c> indicates that the snapshot is created based on an automatic snapshot policy. <c>yyyyMMdd</c> indicates the date on which the snapshot is created. <c>y</c> indicates the year. <c>M</c> indicates the month. <c>d</c> indicates the day. <c>X</c> indicates the ordinal number of the snapshot on the current day. For example, <c>auto_20201018_1</c> indicates the first auto snapshot that was created on October 18, 2020.</description></item>
        /// <item><description>After an automatic snapshot policy is created, you can call the ApplyAutoSnapshotPolicy operation to apply the policy to a file system and call the ModifyAutoSnapshotPolicy operation to modify the policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicyAsync(CreateAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataflow for a Cloud Parallel File Storage (CPFS) file system and source storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Basic operations
        ///     *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows.
        ///     *   You can create a data flow only when a CPFS or CPFS for Lingjun file system is in the Running state.
        ///     *   A maximum of 10 data flows can be created for a CPFS or CPFS for Lingjun file system.
        ///     *   It generally takes 2 to 5 minutes to create a data flow. You can call the DescribeDataFlows operation to check whether the data flow has been created.</para>
        /// <list type="bullet">
        /// <item><description>Permission
        /// When you create a data flow, CPFS obtains the following two service-linked roles: <c>AliyunServiceRoleForNasOssDataflow</c> and <c>AliyunServiceRoleForNasEventNotification</c>. For more information, see <a href="https://help.aliyun.com/document_detail/185138.html">CPFS service-linked roles</a>.</description></item>
        /// <item><description>CPFS usage notes<list type="bullet">
        /// <item><description>Billing<list type="bullet">
        /// <item><description>If you create a data flow, you are charged for using the data flow throughput. For more information, see <a href="https://help.aliyun.com/document_detail/111858.html">Billing of CPFS</a>.</description></item>
        /// <item><description>When you configure the AutoRefresh feature for a data flow, CPFS must use EventBridge to collect object modification events from the source Object Storage Service (OSS) bucket. Event fees are incurred. For more information, see <a href="https://help.aliyun.com/document_detail/163752.html">Billing of EventBridge</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Data flow specifications<list type="bullet">
        /// <item><description>The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.</description></item>
        /// <item><description>When you create a data flow, the vSwitch IP addresses used by a CPFS mount target are consumed. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// <item><description>Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the data flow whose throughput is changed meet the requirements.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Fileset<list type="bullet">
        /// <item><description>The destination for a data flow is a fileset in the CPFS file system. A fileset is a new directory tree structure (a small file directory) in a CPFS file system. Each fileset independently manages an inode space.</description></item>
        /// <item><description>When you create a data flow for a CPFS file system, the related fileset must already exist and cannot be nested with other filesets. Only one data flow can be created in a fileset, which corresponds to one source storage.</description></item>
        /// <item><description>A fileset supports a maximum of one million files. If the number of files imported from an OSS bucket into the fileset exceeds the upper limit, the <c>no space</c> error message is returned when you add new files.
        /// **
        /// **Note **If data already exists in the fileset, after you create a data flow, the existing data in the fileset is cleared and replaced with the data synchronized from the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AutoRefresh<list type="bullet">
        /// <item><description>After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.</description></item>
        /// <item><description>AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first <a href="https://help.aliyun.com/document_detail/182246.html">activate EventBridge</a>.</description></item>
        /// <item><description>The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. You can configure a maximum of five AutoRefresh directories for a data flow.</description></item>
        /// <item><description>AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes <c>Misconfigured</c>. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.</description></item>
        /// <item><description>When you add an AutoRefresh configuration to the prefix for a CPFS data flow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.
        /// **
        /// **Note **The event buses and event rules created for CPFS in the EventBridge console contain the <c>Create for cpfs auto refresh</c> description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Source storage<list type="bullet">
        /// <item><description>The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.</description></item>
        /// <item><description>CPFS data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.</description></item>
        /// <item><description>If data flows for multiple CPFS file systems or multiple data flows for the same CPFS file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS file systems to one OSS bucket.</description></item>
        /// <item><description>Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
        /// **
        /// **Note **Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS cannot access the data in the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Source storage<list type="bullet">
        /// <item><description>The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.</description></item>
        /// <item><description>CPFS for Lingjun data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.</description></item>
        /// <item><description>If data flows for multiple CPFS for Lingjun file systems or multiple data flows for the same CPFS for Lingjun file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS for Lingjun file systems to one OSS bucket.</description></item>
        /// <item><description>Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.</description></item>
        /// <item><description>CPFS for Lingjun V2.6.0 and later allow you to create data flows for OSS buckets across accounts.</description></item>
        /// <item><description>The account id parameter is required only when you use OSS buckets across accounts.</description></item>
        /// <item><description>To use OSS buckets across accounts, you must first grant permissions to the related accounts. For more information, see <a href="https://help.aliyun.com/document_detail/2713462.html">Cross-account authorization on data flows</a>.
        /// **
        /// **Note **Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS for Lingjun cannot access the data in the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on file systems<list type="bullet">
        /// <item><description>You cannot rename a non-empty directory in a path that is associated with a data flow. Otherwise, the Permission Denied error message or an error message indicating that the directory is not empty is returned.</description></item>
        /// <item><description>Proceed with caution when you use special characters in the names of directories and files. The following characters are supported: letters, digits, exclamation points (!), hyphens (-), underscores (_), periods (.), asterisks (\*), and parentheses (()).</description></item>
        /// <item><description>The path can be up to 1,023 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on import<list type="bullet">
        /// <item><description>After a symbolic link is imported to CPFS for Lingjun, the symbolic link is converted into a common data file that contains no symbolic link information.</description></item>
        /// <item><description>If an OSS bucket has multiple versions, only data of the latest version is used.</description></item>
        /// <item><description>The name of a file or a subdirectory can be up to 255 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on export<list type="bullet">
        /// <item><description>After a symbolic link is synchronized to OSS, the file that the symbolic link points to is not synchronized to OSS. In this case, the symbolic link is converted into a common object that contains no data.</description></item>
        /// <item><description>Hard links can be synchronized to OSS only as common files that contain no link information.</description></item>
        /// <item><description>After a file of the Socket, Device, or Pipe type is exported to an OSS bucket, the file is converted into a common object that contains no data.</description></item>
        /// <item><description>The directory path can be up to 1,023 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataflow for a Cloud Parallel File Storage (CPFS) file system and source storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Basic operations
        ///     *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows.
        ///     *   You can create a data flow only when a CPFS or CPFS for Lingjun file system is in the Running state.
        ///     *   A maximum of 10 data flows can be created for a CPFS or CPFS for Lingjun file system.
        ///     *   It generally takes 2 to 5 minutes to create a data flow. You can call the DescribeDataFlows operation to check whether the data flow has been created.</para>
        /// <list type="bullet">
        /// <item><description>Permission
        /// When you create a data flow, CPFS obtains the following two service-linked roles: <c>AliyunServiceRoleForNasOssDataflow</c> and <c>AliyunServiceRoleForNasEventNotification</c>. For more information, see <a href="https://help.aliyun.com/document_detail/185138.html">CPFS service-linked roles</a>.</description></item>
        /// <item><description>CPFS usage notes<list type="bullet">
        /// <item><description>Billing<list type="bullet">
        /// <item><description>If you create a data flow, you are charged for using the data flow throughput. For more information, see <a href="https://help.aliyun.com/document_detail/111858.html">Billing of CPFS</a>.</description></item>
        /// <item><description>When you configure the AutoRefresh feature for a data flow, CPFS must use EventBridge to collect object modification events from the source Object Storage Service (OSS) bucket. Event fees are incurred. For more information, see <a href="https://help.aliyun.com/document_detail/163752.html">Billing of EventBridge</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Data flow specifications<list type="bullet">
        /// <item><description>The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.</description></item>
        /// <item><description>When you create a data flow, the vSwitch IP addresses used by a CPFS mount target are consumed. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// <item><description>Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the data flow whose throughput is changed meet the requirements.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Fileset<list type="bullet">
        /// <item><description>The destination for a data flow is a fileset in the CPFS file system. A fileset is a new directory tree structure (a small file directory) in a CPFS file system. Each fileset independently manages an inode space.</description></item>
        /// <item><description>When you create a data flow for a CPFS file system, the related fileset must already exist and cannot be nested with other filesets. Only one data flow can be created in a fileset, which corresponds to one source storage.</description></item>
        /// <item><description>A fileset supports a maximum of one million files. If the number of files imported from an OSS bucket into the fileset exceeds the upper limit, the <c>no space</c> error message is returned when you add new files.
        /// **
        /// **Note **If data already exists in the fileset, after you create a data flow, the existing data in the fileset is cleared and replaced with the data synchronized from the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AutoRefresh<list type="bullet">
        /// <item><description>After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.</description></item>
        /// <item><description>AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first <a href="https://help.aliyun.com/document_detail/182246.html">activate EventBridge</a>.</description></item>
        /// <item><description>The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. You can configure a maximum of five AutoRefresh directories for a data flow.</description></item>
        /// <item><description>AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes <c>Misconfigured</c>. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.</description></item>
        /// <item><description>When you add an AutoRefresh configuration to the prefix for a CPFS data flow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.
        /// **
        /// **Note **The event buses and event rules created for CPFS in the EventBridge console contain the <c>Create for cpfs auto refresh</c> description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Source storage<list type="bullet">
        /// <item><description>The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.</description></item>
        /// <item><description>CPFS data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.</description></item>
        /// <item><description>If data flows for multiple CPFS file systems or multiple data flows for the same CPFS file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS file systems to one OSS bucket.</description></item>
        /// <item><description>Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
        /// **
        /// **Note **Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS cannot access the data in the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Source storage<list type="bullet">
        /// <item><description>The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.</description></item>
        /// <item><description>CPFS for Lingjun data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.</description></item>
        /// <item><description>If data flows for multiple CPFS for Lingjun file systems or multiple data flows for the same CPFS for Lingjun file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS for Lingjun file systems to one OSS bucket.</description></item>
        /// <item><description>Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.</description></item>
        /// <item><description>CPFS for Lingjun V2.6.0 and later allow you to create data flows for OSS buckets across accounts.</description></item>
        /// <item><description>The account id parameter is required only when you use OSS buckets across accounts.</description></item>
        /// <item><description>To use OSS buckets across accounts, you must first grant permissions to the related accounts. For more information, see <a href="https://help.aliyun.com/document_detail/2713462.html">Cross-account authorization on data flows</a>.
        /// **
        /// **Note **Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS for Lingjun cannot access the data in the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on file systems<list type="bullet">
        /// <item><description>You cannot rename a non-empty directory in a path that is associated with a data flow. Otherwise, the Permission Denied error message or an error message indicating that the directory is not empty is returned.</description></item>
        /// <item><description>Proceed with caution when you use special characters in the names of directories and files. The following characters are supported: letters, digits, exclamation points (!), hyphens (-), underscores (_), periods (.), asterisks (\*), and parentheses (()).</description></item>
        /// <item><description>The path can be up to 1,023 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on import<list type="bullet">
        /// <item><description>After a symbolic link is imported to CPFS for Lingjun, the symbolic link is converted into a common data file that contains no symbolic link information.</description></item>
        /// <item><description>If an OSS bucket has multiple versions, only data of the latest version is used.</description></item>
        /// <item><description>The name of a file or a subdirectory can be up to 255 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on export<list type="bullet">
        /// <item><description>After a symbolic link is synchronized to OSS, the file that the symbolic link points to is not synchronized to OSS. In this case, the symbolic link is converted into a common object that contains no data.</description></item>
        /// <item><description>Hard links can be synchronized to OSS only as common files that contain no link information.</description></item>
        /// <item><description>After a file of the Socket, Device, or Pipe type is exported to an OSS bucket, the file is converted into a common object that contains no data.</description></item>
        /// <item><description>The directory path can be up to 1,023 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataflow for a Cloud Parallel File Storage (CPFS) file system and source storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Basic operations
        ///     *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows.
        ///     *   You can create a data flow only when a CPFS or CPFS for Lingjun file system is in the Running state.
        ///     *   A maximum of 10 data flows can be created for a CPFS or CPFS for Lingjun file system.
        ///     *   It generally takes 2 to 5 minutes to create a data flow. You can call the DescribeDataFlows operation to check whether the data flow has been created.</para>
        /// <list type="bullet">
        /// <item><description>Permission
        /// When you create a data flow, CPFS obtains the following two service-linked roles: <c>AliyunServiceRoleForNasOssDataflow</c> and <c>AliyunServiceRoleForNasEventNotification</c>. For more information, see <a href="https://help.aliyun.com/document_detail/185138.html">CPFS service-linked roles</a>.</description></item>
        /// <item><description>CPFS usage notes<list type="bullet">
        /// <item><description>Billing<list type="bullet">
        /// <item><description>If you create a data flow, you are charged for using the data flow throughput. For more information, see <a href="https://help.aliyun.com/document_detail/111858.html">Billing of CPFS</a>.</description></item>
        /// <item><description>When you configure the AutoRefresh feature for a data flow, CPFS must use EventBridge to collect object modification events from the source Object Storage Service (OSS) bucket. Event fees are incurred. For more information, see <a href="https://help.aliyun.com/document_detail/163752.html">Billing of EventBridge</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Data flow specifications<list type="bullet">
        /// <item><description>The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.</description></item>
        /// <item><description>When you create a data flow, the vSwitch IP addresses used by a CPFS mount target are consumed. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// <item><description>Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the data flow whose throughput is changed meet the requirements.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Fileset<list type="bullet">
        /// <item><description>The destination for a data flow is a fileset in the CPFS file system. A fileset is a new directory tree structure (a small file directory) in a CPFS file system. Each fileset independently manages an inode space.</description></item>
        /// <item><description>When you create a data flow for a CPFS file system, the related fileset must already exist and cannot be nested with other filesets. Only one data flow can be created in a fileset, which corresponds to one source storage.</description></item>
        /// <item><description>A fileset supports a maximum of one million files. If the number of files imported from an OSS bucket into the fileset exceeds the upper limit, the <c>no space</c> error message is returned when you add new files.
        /// **
        /// **Note **If data already exists in the fileset, after you create a data flow, the existing data in the fileset is cleared and replaced with the data synchronized from the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AutoRefresh<list type="bullet">
        /// <item><description>After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.</description></item>
        /// <item><description>AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first <a href="https://help.aliyun.com/document_detail/182246.html">activate EventBridge</a>.</description></item>
        /// <item><description>The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. You can configure a maximum of five AutoRefresh directories for a data flow.</description></item>
        /// <item><description>AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes <c>Misconfigured</c>. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.</description></item>
        /// <item><description>When you add an AutoRefresh configuration to the prefix for a CPFS data flow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.
        /// **
        /// **Note **The event buses and event rules created for CPFS in the EventBridge console contain the <c>Create for cpfs auto refresh</c> description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Source storage<list type="bullet">
        /// <item><description>The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.</description></item>
        /// <item><description>CPFS data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.</description></item>
        /// <item><description>If data flows for multiple CPFS file systems or multiple data flows for the same CPFS file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS file systems to one OSS bucket.</description></item>
        /// <item><description>Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
        /// **
        /// **Note **Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS cannot access the data in the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Source storage<list type="bullet">
        /// <item><description>The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.</description></item>
        /// <item><description>CPFS for Lingjun data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.</description></item>
        /// <item><description>If data flows for multiple CPFS for Lingjun file systems or multiple data flows for the same CPFS for Lingjun file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS for Lingjun file systems to one OSS bucket.</description></item>
        /// <item><description>Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.</description></item>
        /// <item><description>CPFS for Lingjun V2.6.0 and later allow you to create data flows for OSS buckets across accounts.</description></item>
        /// <item><description>The account id parameter is required only when you use OSS buckets across accounts.</description></item>
        /// <item><description>To use OSS buckets across accounts, you must first grant permissions to the related accounts. For more information, see <a href="https://help.aliyun.com/document_detail/2713462.html">Cross-account authorization on data flows</a>.
        /// **
        /// **Note **Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS for Lingjun cannot access the data in the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on file systems<list type="bullet">
        /// <item><description>You cannot rename a non-empty directory in a path that is associated with a data flow. Otherwise, the Permission Denied error message or an error message indicating that the directory is not empty is returned.</description></item>
        /// <item><description>Proceed with caution when you use special characters in the names of directories and files. The following characters are supported: letters, digits, exclamation points (!), hyphens (-), underscores (_), periods (.), asterisks (\*), and parentheses (()).</description></item>
        /// <item><description>The path can be up to 1,023 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on import<list type="bullet">
        /// <item><description>After a symbolic link is imported to CPFS for Lingjun, the symbolic link is converted into a common data file that contains no symbolic link information.</description></item>
        /// <item><description>If an OSS bucket has multiple versions, only data of the latest version is used.</description></item>
        /// <item><description>The name of a file or a subdirectory can be up to 255 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on export<list type="bullet">
        /// <item><description>After a symbolic link is synchronized to OSS, the file that the symbolic link points to is not synchronized to OSS. In this case, the symbolic link is converted into a common object that contains no data.</description></item>
        /// <item><description>Hard links can be synchronized to OSS only as common files that contain no link information.</description></item>
        /// <item><description>After a file of the Socket, Device, or Pipe type is exported to an OSS bucket, the file is converted into a common object that contains no data.</description></item>
        /// <item><description>The directory path can be up to 1,023 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowResponse
        /// </returns>
        public CreateDataFlowResponse CreateDataFlow(CreateDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataflow for a Cloud Parallel File Storage (CPFS) file system and source storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Basic operations
        ///     *   Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows.
        ///     *   You can create a data flow only when a CPFS or CPFS for Lingjun file system is in the Running state.
        ///     *   A maximum of 10 data flows can be created for a CPFS or CPFS for Lingjun file system.
        ///     *   It generally takes 2 to 5 minutes to create a data flow. You can call the DescribeDataFlows operation to check whether the data flow has been created.</para>
        /// <list type="bullet">
        /// <item><description>Permission
        /// When you create a data flow, CPFS obtains the following two service-linked roles: <c>AliyunServiceRoleForNasOssDataflow</c> and <c>AliyunServiceRoleForNasEventNotification</c>. For more information, see <a href="https://help.aliyun.com/document_detail/185138.html">CPFS service-linked roles</a>.</description></item>
        /// <item><description>CPFS usage notes<list type="bullet">
        /// <item><description>Billing<list type="bullet">
        /// <item><description>If you create a data flow, you are charged for using the data flow throughput. For more information, see <a href="https://help.aliyun.com/document_detail/111858.html">Billing of CPFS</a>.</description></item>
        /// <item><description>When you configure the AutoRefresh feature for a data flow, CPFS must use EventBridge to collect object modification events from the source Object Storage Service (OSS) bucket. Event fees are incurred. For more information, see <a href="https://help.aliyun.com/document_detail/163752.html">Billing of EventBridge</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Data flow specifications<list type="bullet">
        /// <item><description>The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.</description></item>
        /// <item><description>When you create a data flow, the vSwitch IP addresses used by a CPFS mount target are consumed. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// <item><description>Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the data flow whose throughput is changed meet the requirements.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Fileset<list type="bullet">
        /// <item><description>The destination for a data flow is a fileset in the CPFS file system. A fileset is a new directory tree structure (a small file directory) in a CPFS file system. Each fileset independently manages an inode space.</description></item>
        /// <item><description>When you create a data flow for a CPFS file system, the related fileset must already exist and cannot be nested with other filesets. Only one data flow can be created in a fileset, which corresponds to one source storage.</description></item>
        /// <item><description>A fileset supports a maximum of one million files. If the number of files imported from an OSS bucket into the fileset exceeds the upper limit, the <c>no space</c> error message is returned when you add new files.
        /// **
        /// **Note **If data already exists in the fileset, after you create a data flow, the existing data in the fileset is cleared and replaced with the data synchronized from the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AutoRefresh<list type="bullet">
        /// <item><description>After AutoRefresh is configured, if the data in the source OSS bucket is updated, the updated metadata is automatically synchronized to the CPFS file system. You can load the updated data when you access files, or run a data flow task to load the updated data.</description></item>
        /// <item><description>AutoRefresh depends on the object modification events collected by EventBridge from the source OSS bucket. You must first <a href="https://help.aliyun.com/document_detail/182246.html">activate EventBridge</a>.</description></item>
        /// <item><description>The AutoRefresh configuration applies only to the prefix and is specified by the RefreshPath parameter. You can configure a maximum of five AutoRefresh directories for a data flow.</description></item>
        /// <item><description>AutoRefreshInterval refers to the interval at which CPFS checks whether data is updated in the prefix of the source OSS bucket. If data is updated, CPFS runs an AutoRefresh task. If the frequency of triggering the object modification event in the source OSS bucket exceeds the processing capability of the CPFS data flow, AutoRefresh tasks are accumulated, metadata updates are delayed, and the data flow status becomes <c>Misconfigured</c>. To resolve these issues, you can increase the data flow specifications or reduce the frequency of triggering the object modification event.</description></item>
        /// <item><description>When you add an AutoRefresh configuration to the prefix for a CPFS data flow, an event bus is created at the user side and an event rule is created for the prefix of the source OSS bucket. When an object is modified in the prefix of the source OSS bucket, an OSS event is generated in the EventBridge console. The event is processed by the CPFS data flow.
        /// **
        /// **Note **The event buses and event rules created for CPFS in the EventBridge console contain the <c>Create for cpfs auto refresh</c> description. The event buses and event rules cannot be modified or deleted. Otherwise, AutoRefresh cannot work properly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Source storage<list type="bullet">
        /// <item><description>The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.</description></item>
        /// <item><description>CPFS data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.</description></item>
        /// <item><description>If data flows for multiple CPFS file systems or multiple data flows for the same CPFS file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS file systems to one OSS bucket.</description></item>
        /// <item><description>Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.
        /// **
        /// **Note **Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS cannot access the data in the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Source storage<list type="bullet">
        /// <item><description>The source storage is an OSS bucket. SourceStorage for a data flow must be an OSS bucket.</description></item>
        /// <item><description>CPFS for Lingjun data flows support both encrypted and unencrypted access to OSS. If you select SSL-encrypted access to OSS, make sure that encryption in transit for OSS buckets supports encrypted access.</description></item>
        /// <item><description>If data flows for multiple CPFS for Lingjun file systems or multiple data flows for the same CPFS for Lingjun file system are stored in the same OSS bucket, you must enable versioning for the OSS bucket to prevent data conflicts caused by data export from multiple CPFS for Lingjun file systems to one OSS bucket.</description></item>
        /// <item><description>Data flows are not supported for OSS buckets across regions. The OSS bucket must reside in the same region as the CPFS file system.</description></item>
        /// <item><description>CPFS for Lingjun V2.6.0 and later allow you to create data flows for OSS buckets across accounts.</description></item>
        /// <item><description>The account id parameter is required only when you use OSS buckets across accounts.</description></item>
        /// <item><description>To use OSS buckets across accounts, you must first grant permissions to the related accounts. For more information, see <a href="https://help.aliyun.com/document_detail/2713462.html">Cross-account authorization on data flows</a>.
        /// **
        /// **Note **Before you create a data flow, you must configure a tag (key: cpfs-dataflow, value: true) for the source OSS bucket. This way, the created data flow can access the data in the OSS bucket. When a data flow is being used, do not delete or modify the tag. Otherwise, the data flow for CPFS for Lingjun cannot access the data in the OSS bucket.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on file systems<list type="bullet">
        /// <item><description>You cannot rename a non-empty directory in a path that is associated with a data flow. Otherwise, the Permission Denied error message or an error message indicating that the directory is not empty is returned.</description></item>
        /// <item><description>Proceed with caution when you use special characters in the names of directories and files. The following characters are supported: letters, digits, exclamation points (!), hyphens (-), underscores (_), periods (.), asterisks (\*), and parentheses (()).</description></item>
        /// <item><description>The path can be up to 1,023 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on import<list type="bullet">
        /// <item><description>After a symbolic link is imported to CPFS for Lingjun, the symbolic link is converted into a common data file that contains no symbolic link information.</description></item>
        /// <item><description>If an OSS bucket has multiple versions, only data of the latest version is used.</description></item>
        /// <item><description>The name of a file or a subdirectory can be up to 255 bytes in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Limits of data flows on export<list type="bullet">
        /// <item><description>After a symbolic link is synchronized to OSS, the file that the symbolic link points to is not synchronized to OSS. In this case, the symbolic link is converted into a common object that contains no data.</description></item>
        /// <item><description>Hard links can be synchronized to OSS only as common files that contain no link information.</description></item>
        /// <item><description>After a file of the Socket, Device, or Pipe type is exported to an OSS bucket, the file is converted into a common object that contains no data.</description></item>
        /// <item><description>The directory path can be up to 1,023 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowResponse
        /// </returns>
        public async Task<CreateDataFlowResponse> CreateDataFlowAsync(CreateDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data streaming subtask.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can create subtasks only for a data streaming subtask in the Executing state.</description></item>
        /// <item><description>Data streaming tasks are executed asynchronously. You can call the DescribeDataFlowSubTasks operation to query the task execution status.</description></item>
        /// <item><description>When the type of data flow task is streaming, the running status only indicates that a streaming import or export task can be created. It does not indicate that the import or export task is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowSubTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowSubTaskResponse
        /// </returns>
        public CreateDataFlowSubTaskResponse CreateDataFlowSubTaskWithOptions(CreateDataFlowSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowTaskId))
            {
                query["DataFlowTaskId"] = request.DataFlowTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstFilePath))
            {
                query["DstFilePath"] = request.DstFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcFilePath))
            {
                query["SrcFilePath"] = request.SrcFilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataFlowSubTask",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataFlowSubTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data streaming subtask.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can create subtasks only for a data streaming subtask in the Executing state.</description></item>
        /// <item><description>Data streaming tasks are executed asynchronously. You can call the DescribeDataFlowSubTasks operation to query the task execution status.</description></item>
        /// <item><description>When the type of data flow task is streaming, the running status only indicates that a streaming import or export task can be created. It does not indicate that the import or export task is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowSubTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowSubTaskResponse
        /// </returns>
        public async Task<CreateDataFlowSubTaskResponse> CreateDataFlowSubTaskWithOptionsAsync(CreateDataFlowSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowId))
            {
                query["DataFlowId"] = request.DataFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFlowTaskId))
            {
                query["DataFlowTaskId"] = request.DataFlowTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstFilePath))
            {
                query["DstFilePath"] = request.DstFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcFilePath))
            {
                query["SrcFilePath"] = request.SrcFilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataFlowSubTask",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataFlowSubTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data streaming subtask.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can create subtasks only for a data streaming subtask in the Executing state.</description></item>
        /// <item><description>Data streaming tasks are executed asynchronously. You can call the DescribeDataFlowSubTasks operation to query the task execution status.</description></item>
        /// <item><description>When the type of data flow task is streaming, the running status only indicates that a streaming import or export task can be created. It does not indicate that the import or export task is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowSubTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowSubTaskResponse
        /// </returns>
        public CreateDataFlowSubTaskResponse CreateDataFlowSubTask(CreateDataFlowSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataFlowSubTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data streaming subtask.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can create subtasks only for a data streaming subtask in the Executing state.</description></item>
        /// <item><description>Data streaming tasks are executed asynchronously. You can call the DescribeDataFlowSubTasks operation to query the task execution status.</description></item>
        /// <item><description>When the type of data flow task is streaming, the running status only indicates that a streaming import or export task can be created. It does not indicate that the import or export task is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowSubTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowSubTaskResponse
        /// </returns>
        public async Task<CreateDataFlowSubTaskResponse> CreateDataFlowSubTaskAsync(CreateDataFlowSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataFlowSubTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataflow task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  CPFS usage notes
        ///     *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
        ///     *   Dataflow tasks are executed asynchronously. You can call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.
        ///     *   You can create a dataflow task only for a dataflow that is in the Running state.
        ///     *   When you manually run a dataflow task, the automatic data update task for the dataflow is interrupted and enters the pending state.
        ///     *   When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS file system does not exceed 1,023 characters.</para>
        /// <list type="bullet">
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Only CPFS for Lingjun V2.4.0 and later support dataflow. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Dataflow tasks are executed asynchronously. You can call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.</description></item>
        /// <item><description>You can create a dataflow task only for a dataflow that is in the Running state.</description></item>
        /// <item><description>When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS for Lingjun file system does not exceed 1,023 characters.</description></item>
        /// <item><description>CPFS for Lingjun supports two types of tasks: batch tasks and streaming tasks. For more information, see <a href="https://help.aliyun.com/document_detail/2845429.html">Task types</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowTaskResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Includes))
            {
                query["Includes"] = request.Includes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTaskId))
            {
                query["SrcTaskId"] = request.SrcTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAction))
            {
                query["TaskAction"] = request.TaskAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferFileListPath))
            {
                query["TransferFileListPath"] = request.TransferFileListPath;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataflow task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  CPFS usage notes
        ///     *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
        ///     *   Dataflow tasks are executed asynchronously. You can call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.
        ///     *   You can create a dataflow task only for a dataflow that is in the Running state.
        ///     *   When you manually run a dataflow task, the automatic data update task for the dataflow is interrupted and enters the pending state.
        ///     *   When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS file system does not exceed 1,023 characters.</para>
        /// <list type="bullet">
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Only CPFS for Lingjun V2.4.0 and later support dataflow. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Dataflow tasks are executed asynchronously. You can call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.</description></item>
        /// <item><description>You can create a dataflow task only for a dataflow that is in the Running state.</description></item>
        /// <item><description>When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS for Lingjun file system does not exceed 1,023 characters.</description></item>
        /// <item><description>CPFS for Lingjun supports two types of tasks: batch tasks and streaming tasks. For more information, see <a href="https://help.aliyun.com/document_detail/2845429.html">Task types</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowTaskResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Includes))
            {
                query["Includes"] = request.Includes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTaskId))
            {
                query["SrcTaskId"] = request.SrcTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAction))
            {
                query["TaskAction"] = request.TaskAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferFileListPath))
            {
                query["TransferFileListPath"] = request.TransferFileListPath;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataflow task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  CPFS usage notes
        ///     *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
        ///     *   Dataflow tasks are executed asynchronously. You can call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.
        ///     *   You can create a dataflow task only for a dataflow that is in the Running state.
        ///     *   When you manually run a dataflow task, the automatic data update task for the dataflow is interrupted and enters the pending state.
        ///     *   When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS file system does not exceed 1,023 characters.</para>
        /// <list type="bullet">
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Only CPFS for Lingjun V2.4.0 and later support dataflow. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Dataflow tasks are executed asynchronously. You can call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.</description></item>
        /// <item><description>You can create a dataflow task only for a dataflow that is in the Running state.</description></item>
        /// <item><description>When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS for Lingjun file system does not exceed 1,023 characters.</description></item>
        /// <item><description>CPFS for Lingjun supports two types of tasks: batch tasks and streaming tasks. For more information, see <a href="https://help.aliyun.com/document_detail/2845429.html">Task types</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowTaskResponse
        /// </returns>
        public CreateDataFlowTaskResponse CreateDataFlowTask(CreateDataFlowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataFlowTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataflow task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  CPFS usage notes
        ///     *   Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.
        ///     *   Dataflow tasks are executed asynchronously. You can call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.
        ///     *   You can create a dataflow task only for a dataflow that is in the Running state.
        ///     *   When you manually run a dataflow task, the automatic data update task for the dataflow is interrupted and enters the pending state.
        ///     *   When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS file system does not exceed 1,023 characters.</para>
        /// <list type="bullet">
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Only CPFS for Lingjun V2.4.0 and later support dataflow. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Dataflow tasks are executed asynchronously. You can call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status. The task duration depends on the amount of data to be imported and exported. If a large amount of data exists, we recommend that you create multiple tasks.</description></item>
        /// <item><description>You can create a dataflow task only for a dataflow that is in the Running state.</description></item>
        /// <item><description>When you create an export task, make sure that the total length of the absolute path of the files to be exported from a CPFS for Lingjun file system does not exceed 1,023 characters.</description></item>
        /// <item><description>CPFS for Lingjun supports two types of tasks: batch tasks and streaming tasks. For more information, see <a href="https://help.aliyun.com/document_detail/2845429.html">Task types</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataFlowTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataFlowTaskResponse
        /// </returns>
        public async Task<CreateDataFlowTaskResponse> CreateDataFlowTaskAsync(CreateDataFlowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataFlowTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory in a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDirRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDirResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory in a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDirRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDirResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory in a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDirRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDirResponse
        /// </returns>
        public CreateDirResponse CreateDir(CreateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDirWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory in a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDirRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDirResponse
        /// </returns>
        public async Task<CreateDirResponse> CreateDirAsync(CreateDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDirWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory or file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is only available to some users.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports only General-purpose NAS file systems that use the Server Message Block (SMB) protocol and have Resource Access Management (RAM) enabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory or file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is only available to some users.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports only General-purpose NAS file systems that use the Server Message Block (SMB) protocol and have Resource Access Management (RAM) enabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory or file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is only available to some users.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports only General-purpose NAS file systems that use the Server Message Block (SMB) protocol and have Resource Access Management (RAM) enabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFileResponse
        /// </returns>
        public CreateFileResponse CreateFile(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory or file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is only available to some users.</para>
        /// <list type="bullet">
        /// <item><description>This operation supports only General-purpose NAS file systems that use the Server Message Block (SMB) protocol and have Resource Access Management (RAM) enabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFileResponse
        /// </returns>
        public async Task<CreateFileResponse> CreateFileAsync(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, you must understand the billing and pricing of Apsara File Storage NAS. For more information, see <a href="https://help.aliyun.com/document_detail/178365.html">Billing</a> and <a href="https://www.aliyun.com/price/product?#/nas/detail">Pricing</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you create a file system, you must complete real-name verification. For more information, see <a href="https://help.aliyun.com/document_detail/48263.html">Real-name verification</a>.</description></item>
        /// <item><description>When you call this operation, a service-linked role of NAS is automatically created. For more information, see <a href="https://help.aliyun.com/document_detail/208530.html">Manage the service-linked roles of NAS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFileSystemResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedundancyType))
            {
                query["RedundancyType"] = request.RedundancyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedundancyVSwitchIds))
            {
                query["RedundancyVSwitchIds"] = request.RedundancyVSwitchIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, you must understand the billing and pricing of Apsara File Storage NAS. For more information, see <a href="https://help.aliyun.com/document_detail/178365.html">Billing</a> and <a href="https://www.aliyun.com/price/product?#/nas/detail">Pricing</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you create a file system, you must complete real-name verification. For more information, see <a href="https://help.aliyun.com/document_detail/48263.html">Real-name verification</a>.</description></item>
        /// <item><description>When you call this operation, a service-linked role of NAS is automatically created. For more information, see <a href="https://help.aliyun.com/document_detail/208530.html">Manage the service-linked roles of NAS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFileSystemResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedundancyType))
            {
                query["RedundancyType"] = request.RedundancyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedundancyVSwitchIds))
            {
                query["RedundancyVSwitchIds"] = request.RedundancyVSwitchIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, you must understand the billing and pricing of Apsara File Storage NAS. For more information, see <a href="https://help.aliyun.com/document_detail/178365.html">Billing</a> and <a href="https://www.aliyun.com/price/product?#/nas/detail">Pricing</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you create a file system, you must complete real-name verification. For more information, see <a href="https://help.aliyun.com/document_detail/48263.html">Real-name verification</a>.</description></item>
        /// <item><description>When you call this operation, a service-linked role of NAS is automatically created. For more information, see <a href="https://help.aliyun.com/document_detail/208530.html">Manage the service-linked roles of NAS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFileSystemResponse
        /// </returns>
        public CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileSystemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, you must understand the billing and pricing of Apsara File Storage NAS. For more information, see <a href="https://help.aliyun.com/document_detail/178365.html">Billing</a> and <a href="https://www.aliyun.com/price/product?#/nas/detail">Pricing</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you create a file system, you must complete real-name verification. For more information, see <a href="https://help.aliyun.com/document_detail/48263.html">Real-name verification</a>.</description></item>
        /// <item><description>When you call this operation, a service-linked role of NAS is automatically created. For more information, see <a href="https://help.aliyun.com/document_detail/208530.html">Manage the service-linked roles of NAS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFileSystemResponse
        /// </returns>
        public async Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileSystemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  CPFS usage notes
        ///     *   Only CPFS V2.2.0 and later support fileset creation. You can view the version information on the file system details page in the console.
        ///     *   A maximum of 10 filesets can be created for a CPFS file system.
        ///     *   The parent directory must be an existing directory.
        ///     *   The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.
        ///     *   Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset.
        ///     *   A fileset supports a maximum of one million files. If the number of files exceeds the upper limit, the <c>no space</c> error message is returned when you add new files.</para>
        /// <list type="bullet">
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Only CPFS for Lingjun V2.7.0 and later support this operation. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>A maximum of 500 filesets can be created for a CPFS file system.</description></item>
        /// <item><description>The fileset path must be a new path and cannot be an existing path. Fileset paths cannot be renamed and cannot be symbolic links.</description></item>
        /// <item><description>The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.</description></item>
        /// <item><description>If the fileset path is a multi-level path, the parent directory must be an existing directory.</description></item>
        /// <item><description>Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset. A fileset path supports only one quota.</description></item>
        /// <item><description>The minimum capacity quota of a fileset is 10 GiB. The scaling step size is 1 GiB.</description></item>
        /// <item><description>A fileset supports a minimum of 10,000 files or directories and a maximum of 10 billion files or directories. The scaling step size is 1.</description></item>
        /// <item><description>When you modify a directory quota, you must set the quota capacity or the number of files to be greater than the capacity or file quantity that has been used.</description></item>
        /// <item><description>The quota statistics have a 15-minute latency. The actual usage takes effect after 15 minutes.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFilesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFilesetResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["Quota"] = request.Quota;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  CPFS usage notes
        ///     *   Only CPFS V2.2.0 and later support fileset creation. You can view the version information on the file system details page in the console.
        ///     *   A maximum of 10 filesets can be created for a CPFS file system.
        ///     *   The parent directory must be an existing directory.
        ///     *   The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.
        ///     *   Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset.
        ///     *   A fileset supports a maximum of one million files. If the number of files exceeds the upper limit, the <c>no space</c> error message is returned when you add new files.</para>
        /// <list type="bullet">
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Only CPFS for Lingjun V2.7.0 and later support this operation. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>A maximum of 500 filesets can be created for a CPFS file system.</description></item>
        /// <item><description>The fileset path must be a new path and cannot be an existing path. Fileset paths cannot be renamed and cannot be symbolic links.</description></item>
        /// <item><description>The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.</description></item>
        /// <item><description>If the fileset path is a multi-level path, the parent directory must be an existing directory.</description></item>
        /// <item><description>Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset. A fileset path supports only one quota.</description></item>
        /// <item><description>The minimum capacity quota of a fileset is 10 GiB. The scaling step size is 1 GiB.</description></item>
        /// <item><description>A fileset supports a minimum of 10,000 files or directories and a maximum of 10 billion files or directories. The scaling step size is 1.</description></item>
        /// <item><description>When you modify a directory quota, you must set the quota capacity or the number of files to be greater than the capacity or file quantity that has been used.</description></item>
        /// <item><description>The quota statistics have a 15-minute latency. The actual usage takes effect after 15 minutes.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFilesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFilesetResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["Quota"] = request.Quota;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  CPFS usage notes
        ///     *   Only CPFS V2.2.0 and later support fileset creation. You can view the version information on the file system details page in the console.
        ///     *   A maximum of 10 filesets can be created for a CPFS file system.
        ///     *   The parent directory must be an existing directory.
        ///     *   The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.
        ///     *   Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset.
        ///     *   A fileset supports a maximum of one million files. If the number of files exceeds the upper limit, the <c>no space</c> error message is returned when you add new files.</para>
        /// <list type="bullet">
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Only CPFS for Lingjun V2.7.0 and later support this operation. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>A maximum of 500 filesets can be created for a CPFS file system.</description></item>
        /// <item><description>The fileset path must be a new path and cannot be an existing path. Fileset paths cannot be renamed and cannot be symbolic links.</description></item>
        /// <item><description>The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.</description></item>
        /// <item><description>If the fileset path is a multi-level path, the parent directory must be an existing directory.</description></item>
        /// <item><description>Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset. A fileset path supports only one quota.</description></item>
        /// <item><description>The minimum capacity quota of a fileset is 10 GiB. The scaling step size is 1 GiB.</description></item>
        /// <item><description>A fileset supports a minimum of 10,000 files or directories and a maximum of 10 billion files or directories. The scaling step size is 1.</description></item>
        /// <item><description>When you modify a directory quota, you must set the quota capacity or the number of files to be greater than the capacity or file quantity that has been used.</description></item>
        /// <item><description>The quota statistics have a 15-minute latency. The actual usage takes effect after 15 minutes.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFilesetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFilesetResponse
        /// </returns>
        public CreateFilesetResponse CreateFileset(CreateFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFilesetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  CPFS usage notes
        ///     *   Only CPFS V2.2.0 and later support fileset creation. You can view the version information on the file system details page in the console.
        ///     *   A maximum of 10 filesets can be created for a CPFS file system.
        ///     *   The parent directory must be an existing directory.
        ///     *   The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.
        ///     *   Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset.
        ///     *   A fileset supports a maximum of one million files. If the number of files exceeds the upper limit, the <c>no space</c> error message is returned when you add new files.</para>
        /// <list type="bullet">
        /// <item><description>CPFS for Lingjun usage notes<list type="bullet">
        /// <item><description>Only CPFS for Lingjun V2.7.0 and later support this operation. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>A maximum of 500 filesets can be created for a CPFS file system.</description></item>
        /// <item><description>The fileset path must be a new path and cannot be an existing path. Fileset paths cannot be renamed and cannot be symbolic links.</description></item>
        /// <item><description>The maximum depth supported by a fileset path is eight levels. The depth of the root directory / is 0 levels. For example, the fileset path /test/aaa/ccc/ has three levels.</description></item>
        /// <item><description>If the fileset path is a multi-level path, the parent directory must be an existing directory.</description></item>
        /// <item><description>Nested filesets are not supported. If a fileset is specified as a parent directory, its subdirectory cannot be a fileset. A fileset path supports only one quota.</description></item>
        /// <item><description>The minimum capacity quota of a fileset is 10 GiB. The scaling step size is 1 GiB.</description></item>
        /// <item><description>A fileset supports a minimum of 10,000 files or directories and a maximum of 10 billion files or directories. The scaling step size is 1.</description></item>
        /// <item><description>When you modify a directory quota, you must set the quota capacity or the number of files to be greater than the capacity or file quantity that has been used.</description></item>
        /// <item><description>The quota statistics have a 15-minute latency. The actual usage takes effect after 15 minutes.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFilesetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFilesetResponse
        /// </returns>
        public async Task<CreateFilesetResponse> CreateFilesetAsync(CreateFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFilesetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates LDAP configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLDAPConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI CreateLDAPConfig is deprecated")]
        // Deprecated
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates LDAP configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLDAPConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI CreateLDAPConfig is deprecated")]
        // Deprecated
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates LDAP configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLDAPConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI CreateLDAPConfig is deprecated")]
        // Deprecated
        public CreateLDAPConfigResponse CreateLDAPConfig(CreateLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLDAPConfigWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates LDAP configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLDAPConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI CreateLDAPConfig is deprecated")]
        // Deprecated
        public async Task<CreateLDAPConfigResponse> CreateLDAPConfigAsync(CreateLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLDAPConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can create lifecycle policies only for General-purpose NAS file systems.</para>
        /// <list type="bullet">
        /// <item><description>You can create up to 20 lifecycle policies in each region within an Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLifecyclePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLifecyclePolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can create lifecycle policies only for General-purpose NAS file systems.</para>
        /// <list type="bullet">
        /// <item><description>You can create up to 20 lifecycle policies in each region within an Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLifecyclePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLifecyclePolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can create lifecycle policies only for General-purpose NAS file systems.</para>
        /// <list type="bullet">
        /// <item><description>You can create up to 20 lifecycle policies in each region within an Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLifecyclePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLifecyclePolicyResponse
        /// </returns>
        public CreateLifecyclePolicyResponse CreateLifecyclePolicy(CreateLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLifecyclePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can create lifecycle policies only for General-purpose NAS file systems.</para>
        /// <list type="bullet">
        /// <item><description>You can create up to 20 lifecycle policies in each region within an Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLifecyclePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLifecyclePolicyResponse
        /// </returns>
        public async Task<CreateLifecyclePolicyResponse> CreateLifecyclePolicyAsync(CreateLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLifecyclePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can run a maximum of 20 data retrieval tasks in each region within an Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLifecycleRetrieveJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLifecycleRetrieveJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can run a maximum of 20 data retrieval tasks in each region within an Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLifecycleRetrieveJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLifecycleRetrieveJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can run a maximum of 20 data retrieval tasks in each region within an Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLifecycleRetrieveJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLifecycleRetrieveJobResponse
        /// </returns>
        public CreateLifecycleRetrieveJobResponse CreateLifecycleRetrieveJob(CreateLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLifecycleRetrieveJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can run a maximum of 20 data retrieval tasks in each region within an Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLifecycleRetrieveJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLifecycleRetrieveJobResponse
        /// </returns>
        public async Task<CreateLifecycleRetrieveJobResponse> CreateLifecycleRetrieveJobAsync(CreateLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLifecycleRetrieveJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Dumps the logs of a General-purpose NAS file system to Simple Log Service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLogAnalysisResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Dumps the logs of a General-purpose NAS file system to Simple Log Service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLogAnalysisResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Dumps the logs of a General-purpose NAS file system to Simple Log Service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLogAnalysisResponse
        /// </returns>
        public CreateLogAnalysisResponse CreateLogAnalysis(CreateLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLogAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Dumps the logs of a General-purpose NAS file system to Simple Log Service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLogAnalysisResponse
        /// </returns>
        public async Task<CreateLogAnalysisResponse> CreateLogAnalysisAsync(CreateLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLogAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you call the CreateMountTarget operation, a mount target is not immediately created. Therefore, we recommend that you call the DescribeMountTargets operation to query the status of the mount target. If the mount target is in the <b>Active</b> state, you can then mount the file system. Otherwise, the file system may fail to be mounted.</para>
        /// <list type="bullet">
        /// <item><description>When you call this operation, a service-linked role of NAS is automatically created. For more information, see <a href="https://help.aliyun.com/document_detail/208530.html">Manage the service-linked roles of NAS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you call the CreateMountTarget operation, a mount target is not immediately created. Therefore, we recommend that you call the DescribeMountTargets operation to query the status of the mount target. If the mount target is in the <b>Active</b> state, you can then mount the file system. Otherwise, the file system may fail to be mounted.</para>
        /// <list type="bullet">
        /// <item><description>When you call this operation, a service-linked role of NAS is automatically created. For more information, see <a href="https://help.aliyun.com/document_detail/208530.html">Manage the service-linked roles of NAS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you call the CreateMountTarget operation, a mount target is not immediately created. Therefore, we recommend that you call the DescribeMountTargets operation to query the status of the mount target. If the mount target is in the <b>Active</b> state, you can then mount the file system. Otherwise, the file system may fail to be mounted.</para>
        /// <list type="bullet">
        /// <item><description>When you call this operation, a service-linked role of NAS is automatically created. For more information, see <a href="https://help.aliyun.com/document_detail/208530.html">Manage the service-linked roles of NAS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMountTargetResponse
        /// </returns>
        public CreateMountTargetResponse CreateMountTarget(CreateMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMountTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you call the CreateMountTarget operation, a mount target is not immediately created. Therefore, we recommend that you call the DescribeMountTargets operation to query the status of the mount target. If the mount target is in the <b>Active</b> state, you can then mount the file system. Otherwise, the file system may fail to be mounted.</para>
        /// <list type="bullet">
        /// <item><description>When you call this operation, a service-linked role of NAS is automatically created. For more information, see <a href="https://help.aliyun.com/document_detail/208530.html">Manage the service-linked roles of NAS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMountTargetResponse
        /// </returns>
        public async Task<CreateMountTargetResponse> CreateMountTargetAsync(CreateMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMountTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an export directory for a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Prerequisites
        /// A protocol service is created.</description></item>
        /// <item><description>Others<list type="bullet">
        /// <item><description>The virtual private cloud (VPC) CIDR block of the export directory for the protocol service cannot overlap with the VPC CIDR block of the file system.</description></item>
        /// <item><description>The VPC CIDR blocks of multiple export directories of a protocol service cannot overlap.</description></item>
        /// <item><description>You can create a maximum of 10 export directories for a protocol service.</description></item>
        /// <item><description>A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProtocolMountTargetResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an export directory for a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Prerequisites
        /// A protocol service is created.</description></item>
        /// <item><description>Others<list type="bullet">
        /// <item><description>The virtual private cloud (VPC) CIDR block of the export directory for the protocol service cannot overlap with the VPC CIDR block of the file system.</description></item>
        /// <item><description>The VPC CIDR blocks of multiple export directories of a protocol service cannot overlap.</description></item>
        /// <item><description>You can create a maximum of 10 export directories for a protocol service.</description></item>
        /// <item><description>A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProtocolMountTargetResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an export directory for a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Prerequisites
        /// A protocol service is created.</description></item>
        /// <item><description>Others<list type="bullet">
        /// <item><description>The virtual private cloud (VPC) CIDR block of the export directory for the protocol service cannot overlap with the VPC CIDR block of the file system.</description></item>
        /// <item><description>The VPC CIDR blocks of multiple export directories of a protocol service cannot overlap.</description></item>
        /// <item><description>You can create a maximum of 10 export directories for a protocol service.</description></item>
        /// <item><description>A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProtocolMountTargetResponse
        /// </returns>
        public CreateProtocolMountTargetResponse CreateProtocolMountTarget(CreateProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProtocolMountTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an export directory for a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Prerequisites
        /// A protocol service is created.</description></item>
        /// <item><description>Others<list type="bullet">
        /// <item><description>The virtual private cloud (VPC) CIDR block of the export directory for the protocol service cannot overlap with the VPC CIDR block of the file system.</description></item>
        /// <item><description>The VPC CIDR blocks of multiple export directories of a protocol service cannot overlap.</description></item>
        /// <item><description>You can create a maximum of 10 export directories for a protocol service.</description></item>
        /// <item><description>A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProtocolMountTargetResponse
        /// </returns>
        public async Task<CreateProtocolMountTargetResponse> CreateProtocolMountTargetAsync(CreateProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProtocolMountTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a protocol service for a Cloud Parallel File Storage (CPFS) file system. The creation takes about 5 to 10 minutes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.3.0 and later support protocol services. You can query the version information of the file system by calling the <a href="https://help.aliyun.com/document_detail/163314.html">DescribeFileSystems</a> operation.</description></item>
        /// <item><description>Protocol service types
        /// Protocol services are classified into general-purpose protocol services and cache protocol services. Different from general-purpose protocol services, cache protocol services can cache hot data. If data exists in the cache, the bandwidth of the cache protocol service may exceed the bandwidth of the CPFS file system, reaching the maximum bandwidth specified for the protocol service.<list type="bullet">
        /// <item><description>General-purpose protocol services: provide NFS access and <a href="https://help.aliyun.com/document_detail/427175.html">directory-level mount targets</a> for CPFS file systems. You do not need to configure a POSIX client to manage clusters. The compliance package check feature is free of charge.</description></item>
        /// <item><description>Cache protocol services: provide the server memory cache based on the least recently used (LRU) policy. When data is cached in the memory, CPFS provides higher internal bandwidth. Cache protocol services are divided into Cache L1 and Cache L2 specifications. The differences are the internal bandwidth size and memory cache size.
        /// **
        /// <b>Note</b> You are charged for using cache protocol services, which are in invitational preview. For more information about the billing method of cache protocol services, see <a href="https://help.aliyun.com/document_detail/111858.html">Billable items</a>. If you have any feedback or questions, you can join the DingTalk group (group number: 31045006299).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Protocol Type
        /// Only NFSv3 is supported.</description></item>
        /// <item><description>Others<list type="bullet">
        /// <item><description>Only one protocol service can be created for a CPFS file system.</description></item>
        /// <item><description>A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProtocolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProtocolServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a protocol service for a Cloud Parallel File Storage (CPFS) file system. The creation takes about 5 to 10 minutes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.3.0 and later support protocol services. You can query the version information of the file system by calling the <a href="https://help.aliyun.com/document_detail/163314.html">DescribeFileSystems</a> operation.</description></item>
        /// <item><description>Protocol service types
        /// Protocol services are classified into general-purpose protocol services and cache protocol services. Different from general-purpose protocol services, cache protocol services can cache hot data. If data exists in the cache, the bandwidth of the cache protocol service may exceed the bandwidth of the CPFS file system, reaching the maximum bandwidth specified for the protocol service.<list type="bullet">
        /// <item><description>General-purpose protocol services: provide NFS access and <a href="https://help.aliyun.com/document_detail/427175.html">directory-level mount targets</a> for CPFS file systems. You do not need to configure a POSIX client to manage clusters. The compliance package check feature is free of charge.</description></item>
        /// <item><description>Cache protocol services: provide the server memory cache based on the least recently used (LRU) policy. When data is cached in the memory, CPFS provides higher internal bandwidth. Cache protocol services are divided into Cache L1 and Cache L2 specifications. The differences are the internal bandwidth size and memory cache size.
        /// **
        /// <b>Note</b> You are charged for using cache protocol services, which are in invitational preview. For more information about the billing method of cache protocol services, see <a href="https://help.aliyun.com/document_detail/111858.html">Billable items</a>. If you have any feedback or questions, you can join the DingTalk group (group number: 31045006299).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Protocol Type
        /// Only NFSv3 is supported.</description></item>
        /// <item><description>Others<list type="bullet">
        /// <item><description>Only one protocol service can be created for a CPFS file system.</description></item>
        /// <item><description>A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProtocolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProtocolServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a protocol service for a Cloud Parallel File Storage (CPFS) file system. The creation takes about 5 to 10 minutes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.3.0 and later support protocol services. You can query the version information of the file system by calling the <a href="https://help.aliyun.com/document_detail/163314.html">DescribeFileSystems</a> operation.</description></item>
        /// <item><description>Protocol service types
        /// Protocol services are classified into general-purpose protocol services and cache protocol services. Different from general-purpose protocol services, cache protocol services can cache hot data. If data exists in the cache, the bandwidth of the cache protocol service may exceed the bandwidth of the CPFS file system, reaching the maximum bandwidth specified for the protocol service.<list type="bullet">
        /// <item><description>General-purpose protocol services: provide NFS access and <a href="https://help.aliyun.com/document_detail/427175.html">directory-level mount targets</a> for CPFS file systems. You do not need to configure a POSIX client to manage clusters. The compliance package check feature is free of charge.</description></item>
        /// <item><description>Cache protocol services: provide the server memory cache based on the least recently used (LRU) policy. When data is cached in the memory, CPFS provides higher internal bandwidth. Cache protocol services are divided into Cache L1 and Cache L2 specifications. The differences are the internal bandwidth size and memory cache size.
        /// **
        /// <b>Note</b> You are charged for using cache protocol services, which are in invitational preview. For more information about the billing method of cache protocol services, see <a href="https://help.aliyun.com/document_detail/111858.html">Billable items</a>. If you have any feedback or questions, you can join the DingTalk group (group number: 31045006299).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Protocol Type
        /// Only NFSv3 is supported.</description></item>
        /// <item><description>Others<list type="bullet">
        /// <item><description>Only one protocol service can be created for a CPFS file system.</description></item>
        /// <item><description>A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProtocolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProtocolServiceResponse
        /// </returns>
        public CreateProtocolServiceResponse CreateProtocolService(CreateProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProtocolServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a protocol service for a Cloud Parallel File Storage (CPFS) file system. The creation takes about 5 to 10 minutes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.3.0 and later support protocol services. You can query the version information of the file system by calling the <a href="https://help.aliyun.com/document_detail/163314.html">DescribeFileSystems</a> operation.</description></item>
        /// <item><description>Protocol service types
        /// Protocol services are classified into general-purpose protocol services and cache protocol services. Different from general-purpose protocol services, cache protocol services can cache hot data. If data exists in the cache, the bandwidth of the cache protocol service may exceed the bandwidth of the CPFS file system, reaching the maximum bandwidth specified for the protocol service.<list type="bullet">
        /// <item><description>General-purpose protocol services: provide NFS access and <a href="https://help.aliyun.com/document_detail/427175.html">directory-level mount targets</a> for CPFS file systems. You do not need to configure a POSIX client to manage clusters. The compliance package check feature is free of charge.</description></item>
        /// <item><description>Cache protocol services: provide the server memory cache based on the least recently used (LRU) policy. When data is cached in the memory, CPFS provides higher internal bandwidth. Cache protocol services are divided into Cache L1 and Cache L2 specifications. The differences are the internal bandwidth size and memory cache size.
        /// **
        /// <b>Note</b> You are charged for using cache protocol services, which are in invitational preview. For more information about the billing method of cache protocol services, see <a href="https://help.aliyun.com/document_detail/111858.html">Billable items</a>. If you have any feedback or questions, you can join the DingTalk group (group number: 31045006299).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Protocol Type
        /// Only NFSv3 is supported.</description></item>
        /// <item><description>Others<list type="bullet">
        /// <item><description>Only one protocol service can be created for a CPFS file system.</description></item>
        /// <item><description>A protocol service can use a maximum of 32 IP addresses that are allocated by a specified vSwitch. Make sure that the vSwitch can provide sufficient IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProtocolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProtocolServiceResponse
        /// </returns>
        public async Task<CreateProtocolServiceResponse> CreateProtocolServiceAsync(CreateProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProtocolServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job to permanently delete a file or directory from the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>If you permanently delete a directory, the files in the directory are recursively cleared.</description></item>
        /// <item><description>You can run only one job at a time for a single file system to permanently delete the files from the file system. You cannot create a restoration or deletion job when a file or directory is being deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRecycleBinDeleteJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRecycleBinDeleteJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job to permanently delete a file or directory from the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>If you permanently delete a directory, the files in the directory are recursively cleared.</description></item>
        /// <item><description>You can run only one job at a time for a single file system to permanently delete the files from the file system. You cannot create a restoration or deletion job when a file or directory is being deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRecycleBinDeleteJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRecycleBinDeleteJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job to permanently delete a file or directory from the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>If you permanently delete a directory, the files in the directory are recursively cleared.</description></item>
        /// <item><description>You can run only one job at a time for a single file system to permanently delete the files from the file system. You cannot create a restoration or deletion job when a file or directory is being deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRecycleBinDeleteJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRecycleBinDeleteJobResponse
        /// </returns>
        public CreateRecycleBinDeleteJobResponse CreateRecycleBinDeleteJob(CreateRecycleBinDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecycleBinDeleteJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job to permanently delete a file or directory from the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>If you permanently delete a directory, the files in the directory are recursively cleared.</description></item>
        /// <item><description>You can run only one job at a time for a single file system to permanently delete the files from the file system. You cannot create a restoration or deletion job when a file or directory is being deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRecycleBinDeleteJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRecycleBinDeleteJobResponse
        /// </returns>
        public async Task<CreateRecycleBinDeleteJobResponse> CreateRecycleBinDeleteJobAsync(CreateRecycleBinDeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecycleBinDeleteJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a file or directory from the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can run only one job at a time for a single file system to restore files to or clear files from the file system. You cannot create a restore or cleanup job when files are being restored from the recycle bin.</description></item>
        /// <item><description>You can restore only one file or directory in a single restore job. If you restore a specified directory, all files in the directory are recursively restored.</description></item>
        /// <item><description>After files are restored, the data of the files is defragmented. When the data is being defragmented, the read performance is slightly degraded.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRecycleBinRestoreJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRecycleBinRestoreJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a file or directory from the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can run only one job at a time for a single file system to restore files to or clear files from the file system. You cannot create a restore or cleanup job when files are being restored from the recycle bin.</description></item>
        /// <item><description>You can restore only one file or directory in a single restore job. If you restore a specified directory, all files in the directory are recursively restored.</description></item>
        /// <item><description>After files are restored, the data of the files is defragmented. When the data is being defragmented, the read performance is slightly degraded.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRecycleBinRestoreJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRecycleBinRestoreJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a file or directory from the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can run only one job at a time for a single file system to restore files to or clear files from the file system. You cannot create a restore or cleanup job when files are being restored from the recycle bin.</description></item>
        /// <item><description>You can restore only one file or directory in a single restore job. If you restore a specified directory, all files in the directory are recursively restored.</description></item>
        /// <item><description>After files are restored, the data of the files is defragmented. When the data is being defragmented, the read performance is slightly degraded.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRecycleBinRestoreJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRecycleBinRestoreJobResponse
        /// </returns>
        public CreateRecycleBinRestoreJobResponse CreateRecycleBinRestoreJob(CreateRecycleBinRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecycleBinRestoreJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a file or directory from the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can run only one job at a time for a single file system to restore files to or clear files from the file system. You cannot create a restore or cleanup job when files are being restored from the recycle bin.</description></item>
        /// <item><description>You can restore only one file or directory in a single restore job. If you restore a specified directory, all files in the directory are recursively restored.</description></item>
        /// <item><description>After files are restored, the data of the files is defragmented. When the data is being defragmented, the read performance is slightly degraded.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRecycleBinRestoreJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRecycleBinRestoreJobResponse
        /// </returns>
        public async Task<CreateRecycleBinRestoreJobResponse> CreateRecycleBinRestoreJobAsync(CreateRecycleBinRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecycleBinRestoreJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a snapshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>You can create a maximum of 128 snapshots for a file system.</description></item>
        /// <item><description>The compute node on which a file system is mounted must function as expected. Otherwise, you cannot create a snapshot for the file system.</description></item>
        /// <item><description>You can create only one snapshot for a file system at a time.</description></item>
        /// <item><description>If the file system expires when a snapshot is being created, the file system is released and the snapshot is deleted.</description></item>
        /// <item><description>When you create a snapshot for a file system, the I/O performance of the file system may be degraded for a short period of time. We recommend that you create snapshots during off-peak hours.</description></item>
        /// <item><description>A snapshot is a backup of a file system at a specific point in time. After you create a snapshot, incremental data that is generated in the file system will not be synchronized to the snapshot.</description></item>
        /// <item><description>Manually created snapshots will not be deleted until 15 days after the service is suspended due to overdue payments. We recommend that you delete unnecessary snapshots at regular intervals to prevent extra fees incurred by the snapshots.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a snapshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>You can create a maximum of 128 snapshots for a file system.</description></item>
        /// <item><description>The compute node on which a file system is mounted must function as expected. Otherwise, you cannot create a snapshot for the file system.</description></item>
        /// <item><description>You can create only one snapshot for a file system at a time.</description></item>
        /// <item><description>If the file system expires when a snapshot is being created, the file system is released and the snapshot is deleted.</description></item>
        /// <item><description>When you create a snapshot for a file system, the I/O performance of the file system may be degraded for a short period of time. We recommend that you create snapshots during off-peak hours.</description></item>
        /// <item><description>A snapshot is a backup of a file system at a specific point in time. After you create a snapshot, incremental data that is generated in the file system will not be synchronized to the snapshot.</description></item>
        /// <item><description>Manually created snapshots will not be deleted until 15 days after the service is suspended due to overdue payments. We recommend that you delete unnecessary snapshots at regular intervals to prevent extra fees incurred by the snapshots.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a snapshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>You can create a maximum of 128 snapshots for a file system.</description></item>
        /// <item><description>The compute node on which a file system is mounted must function as expected. Otherwise, you cannot create a snapshot for the file system.</description></item>
        /// <item><description>You can create only one snapshot for a file system at a time.</description></item>
        /// <item><description>If the file system expires when a snapshot is being created, the file system is released and the snapshot is deleted.</description></item>
        /// <item><description>When you create a snapshot for a file system, the I/O performance of the file system may be degraded for a short period of time. We recommend that you create snapshots during off-peak hours.</description></item>
        /// <item><description>A snapshot is a backup of a file system at a specific point in time. After you create a snapshot, incremental data that is generated in the file system will not be synchronized to the snapshot.</description></item>
        /// <item><description>Manually created snapshots will not be deleted until 15 days after the service is suspended due to overdue payments. We recommend that you delete unnecessary snapshots at regular intervals to prevent extra fees incurred by the snapshots.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSnapshotWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a snapshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>You can create a maximum of 128 snapshots for a file system.</description></item>
        /// <item><description>The compute node on which a file system is mounted must function as expected. Otherwise, you cannot create a snapshot for the file system.</description></item>
        /// <item><description>You can create only one snapshot for a file system at a time.</description></item>
        /// <item><description>If the file system expires when a snapshot is being created, the file system is released and the snapshot is deleted.</description></item>
        /// <item><description>When you create a snapshot for a file system, the I/O performance of the file system may be degraded for a short period of time. We recommend that you create snapshots during off-peak hours.</description></item>
        /// <item><description>A snapshot is a backup of a file system at a specific point in time. After you create a snapshot, incremental data that is generated in the file system will not be synchronized to the snapshot.</description></item>
        /// <item><description>Manually created snapshots will not be deleted until 15 days after the service is suspended due to overdue payments. We recommend that you delete unnecessary snapshots at regular intervals to prevent extra fees incurred by the snapshots.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSnapshotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessGroupResponse
        /// </returns>
        public DeleteAccessGroupResponse DeleteAccessGroup(DeleteAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessGroupResponse
        /// </returns>
        public async Task<DeleteAccessGroupResponse> DeleteAccessGroupAsync(DeleteAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose Network File System (NFS) file systems support access points.</para>
        /// <list type="bullet">
        /// <item><description>After an access point is deleted, all I/O operations that are being performed on the directory accessed over the access point are interrupted immediately. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessPointResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose Network File System (NFS) file systems support access points.</para>
        /// <list type="bullet">
        /// <item><description>After an access point is deleted, all I/O operations that are being performed on the directory accessed over the access point are interrupted immediately. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessPointResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose Network File System (NFS) file systems support access points.</para>
        /// <list type="bullet">
        /// <item><description>After an access point is deleted, all I/O operations that are being performed on the directory accessed over the access point are interrupted immediately. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessPointResponse
        /// </returns>
        public DeleteAccessPointResponse DeleteAccessPoint(DeleteAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose Network File System (NFS) file systems support access points.</para>
        /// <list type="bullet">
        /// <item><description>After an access point is deleted, all I/O operations that are being performed on the directory accessed over the access point are interrupted immediately. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessPointResponse
        /// </returns>
        public async Task<DeleteAccessPointResponse> DeleteAccessPointAsync(DeleteAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule from a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessRuleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule from a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessRuleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule from a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessRuleResponse
        /// </returns>
        public DeleteAccessRuleResponse DeleteAccessRule(DeleteAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule from a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessRuleResponse
        /// </returns>
        public async Task<DeleteAccessRuleResponse> DeleteAccessRuleAsync(DeleteAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an automatic snapshot policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>If you delete an automatic snapshot policy that is applied to a file system, snapshots for the file system are no longer created based on the policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an automatic snapshot policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>If you delete an automatic snapshot policy that is applied to a file system, snapshots for the file system are no longer created based on the policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an automatic snapshot policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>If you delete an automatic snapshot policy that is applied to a file system, snapshots for the file system are no longer created based on the policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoSnapshotPolicyResponse
        /// </returns>
        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicy(DeleteAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an automatic snapshot policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// <item><description>If you delete an automatic snapshot policy that is applied to a file system, snapshots for the file system are no longer created based on the policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicyAsync(DeleteAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can delete the data flows that are only in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>After a data flow is deleted, the resources related to the data flow are released and cannot be restored. You must create a data flow again if required.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can delete the data flows that are only in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>After a data flow is deleted, the resources related to the data flow are released and cannot be restored. You must create a data flow again if required.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can delete the data flows that are only in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>After a data flow is deleted, the resources related to the data flow are released and cannot be restored. You must create a data flow again if required.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataFlowResponse
        /// </returns>
        public DeleteDataFlowResponse DeleteDataFlow(DeleteDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>You can delete the data flows that are only in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>After a data flow is deleted, the resources related to the data flow are released and cannot be restored. You must create a data flow again if required.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataFlowResponse
        /// </returns>
        public async Task<DeleteDataFlowResponse> DeleteDataFlowAsync(DeleteDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete a file system, you must delete all mount targets of the file system.</para>
        /// <list type="bullet">
        /// <item><description>Before you delete a file system, you must make sure that no lifecycle policy is created for the file system.</description></item>
        /// <item><description>After a file system is deleted, the data on the file system cannot be restored. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete a file system, you must delete all mount targets of the file system.</para>
        /// <list type="bullet">
        /// <item><description>Before you delete a file system, you must make sure that no lifecycle policy is created for the file system.</description></item>
        /// <item><description>After a file system is deleted, the data on the file system cannot be restored. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete a file system, you must delete all mount targets of the file system.</para>
        /// <list type="bullet">
        /// <item><description>Before you delete a file system, you must make sure that no lifecycle policy is created for the file system.</description></item>
        /// <item><description>After a file system is deleted, the data on the file system cannot be restored. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileSystemResponse
        /// </returns>
        public DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileSystemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete a file system, you must delete all mount targets of the file system.</para>
        /// <list type="bullet">
        /// <item><description>Before you delete a file system, you must make sure that no lifecycle policy is created for the file system.</description></item>
        /// <item><description>After a file system is deleted, the data on the file system cannot be restored. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileSystemResponse
        /// </returns>
        public async Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileSystemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation. After you delete a fileset, all data in the fileset is deleted and cannot be restored. Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description>If deletion protection is enabled for the fileset, you must disable deletion protection before you delete the fileset.</description></item>
        /// <item><description>After you delete a fileset of CPFS for Lingjun, the storage space is not immediately released and will be recycled within 24 hours. If you want to release storage space immediately, you can clear the data in the fileset and then delete the fileset. Deleted data cannot be restored. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFilesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilesetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation. After you delete a fileset, all data in the fileset is deleted and cannot be restored. Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description>If deletion protection is enabled for the fileset, you must disable deletion protection before you delete the fileset.</description></item>
        /// <item><description>After you delete a fileset of CPFS for Lingjun, the storage space is not immediately released and will be recycled within 24 hours. If you want to release storage space immediately, you can clear the data in the fileset and then delete the fileset. Deleted data cannot be restored. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFilesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilesetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation. After you delete a fileset, all data in the fileset is deleted and cannot be restored. Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description>If deletion protection is enabled for the fileset, you must disable deletion protection before you delete the fileset.</description></item>
        /// <item><description>After you delete a fileset of CPFS for Lingjun, the storage space is not immediately released and will be recycled within 24 hours. If you want to release storage space immediately, you can clear the data in the fileset and then delete the fileset. Deleted data cannot be restored. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFilesetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilesetResponse
        /// </returns>
        public DeleteFilesetResponse DeleteFileset(DeleteFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFilesetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation. After you delete a fileset, all data in the fileset is deleted and cannot be restored. Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description>If deletion protection is enabled for the fileset, you must disable deletion protection before you delete the fileset.</description></item>
        /// <item><description>After you delete a fileset of CPFS for Lingjun, the storage space is not immediately released and will be recycled within 24 hours. If you want to release storage space immediately, you can clear the data in the fileset and then delete the fileset. Deleted data cannot be restored. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFilesetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilesetResponse
        /// </returns>
        public async Task<DeleteFilesetResponse> DeleteFilesetAsync(DeleteFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFilesetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>{&quot;summary1&quot;:&quot;&quot;}</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLDAPConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteLDAPConfig is deprecated")]
        // Deprecated
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>{&quot;summary1&quot;:&quot;&quot;}</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLDAPConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteLDAPConfig is deprecated")]
        // Deprecated
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>{&quot;summary1&quot;:&quot;&quot;}</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLDAPConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteLDAPConfig is deprecated")]
        // Deprecated
        public DeleteLDAPConfigResponse DeleteLDAPConfig(DeleteLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLDAPConfigWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>{&quot;summary1&quot;:&quot;&quot;}</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLDAPConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteLDAPConfig is deprecated")]
        // Deprecated
        public async Task<DeleteLDAPConfigResponse> DeleteLDAPConfigAsync(DeleteLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLDAPConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLifecyclePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLifecyclePolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLifecyclePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLifecyclePolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLifecyclePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLifecyclePolicyResponse
        /// </returns>
        public DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLifecyclePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLifecyclePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLifecyclePolicyResponse
        /// </returns>
        public async Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLifecyclePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables log dumping for a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLogAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLogAnalysisResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables log dumping for a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLogAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLogAnalysisResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables log dumping for a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLogAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLogAnalysisResponse
        /// </returns>
        public DeleteLogAnalysisResponse DeleteLogAnalysis(DeleteLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLogAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables log dumping for a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLogAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLogAnalysisResponse
        /// </returns>
        public async Task<DeleteLogAnalysisResponse> DeleteLogAnalysisAsync(DeleteLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLogAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you delete a mount target, the mount target cannot be restored. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you delete a mount target, the mount target cannot be restored. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you delete a mount target, the mount target cannot be restored. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMountTargetResponse
        /// </returns>
        public DeleteMountTargetResponse DeleteMountTarget(DeleteMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMountTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you delete a mount target, the mount target cannot be restored. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMountTargetResponse
        /// </returns>
        public async Task<DeleteMountTargetResponse> DeleteMountTargetAsync(DeleteMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMountTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an export directory of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProtocolMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an export directory of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProtocolMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an export directory of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProtocolMountTargetResponse
        /// </returns>
        public DeleteProtocolMountTargetResponse DeleteProtocolMountTarget(DeleteProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProtocolMountTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an export directory of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProtocolMountTargetResponse
        /// </returns>
        public async Task<DeleteProtocolMountTargetResponse> DeleteProtocolMountTargetAsync(DeleteProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProtocolMountTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a protocol service of a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>When you delete a protocol service, the export directories in the protocol service are also deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProtocolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProtocolServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a protocol service of a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>When you delete a protocol service, the export directories in the protocol service are also deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProtocolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProtocolServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a protocol service of a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>When you delete a protocol service, the export directories in the protocol service are also deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProtocolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProtocolServiceResponse
        /// </returns>
        public DeleteProtocolServiceResponse DeleteProtocolService(DeleteProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProtocolServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a protocol service of a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>When you delete a protocol service, the export directories in the protocol service are also deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProtocolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProtocolServiceResponse
        /// </returns>
        public async Task<DeleteProtocolServiceResponse> DeleteProtocolServiceAsync(DeleteProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProtocolServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a snapshot or cancels a snapshot that is being created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a snapshot or cancels a snapshot that is being created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a snapshot or cancels a snapshot that is being created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a snapshot or cancels a snapshot that is being created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries permission groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries permission groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries permission groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessGroupsResponse
        /// </returns>
        public DescribeAccessGroupsResponse DescribeAccessGroups(DescribeAccessGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries permission groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessGroupsResponse
        /// </returns>
        public async Task<DescribeAccessGroupsResponse> DescribeAccessGroupsAsync(DescribeAccessGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessPointResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessPointResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessPointResponse
        /// </returns>
        public DescribeAccessPointResponse DescribeAccessPoint(DescribeAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessPointResponse
        /// </returns>
        public async Task<DescribeAccessPointResponse> DescribeAccessPointAsync(DescribeAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAccessPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessPointsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAccessPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessPointsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAccessPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessPointsResponse
        /// </returns>
        public DescribeAccessPointsResponse DescribeAccessPoints(DescribeAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessPointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAccessPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessPointsResponse
        /// </returns>
        public async Task<DescribeAccessPointsResponse> DescribeAccessPointsAsync(DescribeAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessPointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about rules in a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessRulesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about rules in a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessRulesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about rules in a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessRulesResponse
        /// </returns>
        public DescribeAccessRulesResponse DescribeAccessRules(DescribeAccessRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about rules in a permission group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessRulesResponse
        /// </returns>
        public async Task<DescribeAccessRulesResponse> DescribeAccessRulesAsync(DescribeAccessRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automatic snapshot policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoSnapshotPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoSnapshotPoliciesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automatic snapshot policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoSnapshotPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoSnapshotPoliciesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automatic snapshot policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoSnapshotPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoSnapshotPoliciesResponse
        /// </returns>
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPolicies(DescribeAutoSnapshotPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoSnapshotPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automatic snapshot policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoSnapshotPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoSnapshotPoliciesResponse
        /// </returns>
        public async Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPoliciesAsync(DescribeAutoSnapshotPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoSnapshotPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automatic snapshot tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoSnapshotTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoSnapshotTasksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automatic snapshot tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoSnapshotTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoSnapshotTasksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automatic snapshot tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoSnapshotTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoSnapshotTasksResponse
        /// </returns>
        public DescribeAutoSnapshotTasksResponse DescribeAutoSnapshotTasks(DescribeAutoSnapshotTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoSnapshotTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automatic snapshot tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support the snapshot feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoSnapshotTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoSnapshotTasksResponse
        /// </returns>
        public async Task<DescribeAutoSnapshotTasksResponse> DescribeAutoSnapshotTasksAsync(DescribeAutoSnapshotTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoSnapshotTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeBlackListClients is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of clients in the blacklist of a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBlackListClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBlackListClientsResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeBlackListClients is deprecated")]
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeBlackListClients is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of clients in the blacklist of a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBlackListClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBlackListClientsResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeBlackListClients is deprecated")]
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeBlackListClients is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of clients in the blacklist of a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBlackListClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBlackListClientsResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeBlackListClients is deprecated")]
        // Deprecated
        public DescribeBlackListClientsResponse DescribeBlackListClients(DescribeBlackListClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBlackListClientsWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeBlackListClients is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of clients in the blacklist of a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBlackListClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBlackListClientsResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeBlackListClients is deprecated")]
        // Deprecated
        public async Task<DescribeBlackListClientsResponse> DescribeBlackListClientsAsync(DescribeBlackListClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBlackListClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data flow subtasks in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowSubTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowSubTasksResponse
        /// </returns>
        public DescribeDataFlowSubTasksResponse DescribeDataFlowSubTasksWithOptions(DescribeDataFlowSubTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDataFlowSubTasks",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataFlowSubTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data flow subtasks in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowSubTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowSubTasksResponse
        /// </returns>
        public async Task<DescribeDataFlowSubTasksResponse> DescribeDataFlowSubTasksWithOptionsAsync(DescribeDataFlowSubTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDataFlowSubTasks",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataFlowSubTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data flow subtasks in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowSubTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowSubTasksResponse
        /// </returns>
        public DescribeDataFlowSubTasksResponse DescribeDataFlowSubTasks(DescribeDataFlowSubTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataFlowSubTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data flow subtasks in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) for LINGJUN V2.6.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowSubTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowSubTasksResponse
        /// </returns>
        public async Task<DescribeDataFlowSubTasksResponse> DescribeDataFlowSubTasksAsync(DescribeDataFlowSubTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataFlowSubTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of dataflow tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only CPFS V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowTasksResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithReports))
            {
                query["WithReports"] = request.WithReports;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of dataflow tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only CPFS V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowTasksResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithReports))
            {
                query["WithReports"] = request.WithReports;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of dataflow tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only CPFS V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowTasksResponse
        /// </returns>
        public DescribeDataFlowTasksResponse DescribeDataFlowTasks(DescribeDataFlowTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataFlowTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of dataflow tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only CPFS V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowTasksResponse
        /// </returns>
        public async Task<DescribeDataFlowTasksResponse> DescribeDataFlowTasksAsync(DescribeDataFlowTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataFlowTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dataflows of a CPFS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support dataflows. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>In Filters, FsetIds, DataFlowlds, SourceStorage, ThroughputList, and Status support exact match only. FileSystemPath, Description, and SourceStoragePath support fuzzy match.</description></item>
        /// <item><description>Combined query is supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dataflows of a CPFS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support dataflows. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>In Filters, FsetIds, DataFlowlds, SourceStorage, ThroughputList, and Status support exact match only. FileSystemPath, Description, and SourceStoragePath support fuzzy match.</description></item>
        /// <item><description>Combined query is supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dataflows of a CPFS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support dataflows. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>In Filters, FsetIds, DataFlowlds, SourceStorage, ThroughputList, and Status support exact match only. FileSystemPath, Description, and SourceStoragePath support fuzzy match.</description></item>
        /// <item><description>Combined query is supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowsResponse
        /// </returns>
        public DescribeDataFlowsResponse DescribeDataFlows(DescribeDataFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataFlowsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dataflows of a CPFS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support dataflows. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>In Filters, FsetIds, DataFlowlds, SourceStorage, ThroughputList, and Status support exact match only. FileSystemPath, Description, and SourceStoragePath support fuzzy match.</description></item>
        /// <item><description>Combined query is supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDataFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataFlowsResponse
        /// </returns>
        public async Task<DescribeDataFlowsResponse> DescribeDataFlowsAsync(DescribeDataFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataFlowsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the directory quotas of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDirQuotasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDirQuotasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the directory quotas of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDirQuotasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDirQuotasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the directory quotas of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDirQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDirQuotasResponse
        /// </returns>
        public DescribeDirQuotasResponse DescribeDirQuotas(DescribeDirQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDirQuotasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the directory quotas of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDirQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDirQuotasResponse
        /// </returns>
        public async Task<DescribeDirQuotasResponse> DescribeDirQuotasAsync(DescribeDirQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDirQuotasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeFileSystemStatistics is deprecated, please use NAS::2017-06-26::DescribeResourceStatistics instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of file systems that are owned by the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileSystemStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileSystemStatisticsResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeFileSystemStatistics is deprecated, please use NAS::2017-06-26::DescribeResourceStatistics instead.")]
        // Deprecated
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeFileSystemStatistics is deprecated, please use NAS::2017-06-26::DescribeResourceStatistics instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of file systems that are owned by the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileSystemStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileSystemStatisticsResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeFileSystemStatistics is deprecated, please use NAS::2017-06-26::DescribeResourceStatistics instead.")]
        // Deprecated
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeFileSystemStatistics is deprecated, please use NAS::2017-06-26::DescribeResourceStatistics instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of file systems that are owned by the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileSystemStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileSystemStatisticsResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeFileSystemStatistics is deprecated, please use NAS::2017-06-26::DescribeResourceStatistics instead.")]
        // Deprecated
        public DescribeFileSystemStatisticsResponse DescribeFileSystemStatistics(DescribeFileSystemStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileSystemStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeFileSystemStatistics is deprecated, please use NAS::2017-06-26::DescribeResourceStatistics instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of file systems that are owned by the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileSystemStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileSystemStatisticsResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeFileSystemStatistics is deprecated, please use NAS::2017-06-26::DescribeResourceStatistics instead.")]
        // Deprecated
        public async Task<DescribeFileSystemStatisticsResponse> DescribeFileSystemStatisticsAsync(DescribeFileSystemStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileSystemStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries file systems.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileSystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileSystemsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries file systems.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileSystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileSystemsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries file systems.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileSystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileSystemsResponse
        /// </returns>
        public DescribeFileSystemsResponse DescribeFileSystems(DescribeFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileSystemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries file systems.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileSystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileSystemsResponse
        /// </returns>
        public async Task<DescribeFileSystemsResponse> DescribeFileSystemsAsync(DescribeFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileSystemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about created filesets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>In Filters, FsetIds supports exact match only. FileSystemPath and Description support fuzzy match.</description></item>
        /// <item><description>Combined query is supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesetsResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByField))
            {
                query["OrderByField"] = request.OrderByField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about created filesets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>In Filters, FsetIds supports exact match only. FileSystemPath and Description support fuzzy match.</description></item>
        /// <item><description>Combined query is supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesetsResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByField))
            {
                query["OrderByField"] = request.OrderByField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about created filesets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>In Filters, FsetIds supports exact match only. FileSystemPath and Description support fuzzy match.</description></item>
        /// <item><description>Combined query is supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesetsResponse
        /// </returns>
        public DescribeFilesetsResponse DescribeFilesets(DescribeFilesetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFilesetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about created filesets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation. You can view the version information on the file system details page in the console.</para>
        /// <list type="bullet">
        /// <item><description>In Filters, FsetIds supports exact match only. FileSystemPath and Description support fuzzy match.</description></item>
        /// <item><description>Combined query is supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesetsResponse
        /// </returns>
        public async Task<DescribeFilesetsResponse> DescribeFilesetsAsync(DescribeFilesetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFilesetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual storage channels associated with a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesystemsVscAttachInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesystemsVscAttachInfoResponse
        /// </returns>
        public DescribeFilesystemsVscAttachInfoResponse DescribeFilesystemsVscAttachInfoWithOptions(DescribeFilesystemsVscAttachInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFilesystemsVscAttachInfo",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilesystemsVscAttachInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual storage channels associated with a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesystemsVscAttachInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesystemsVscAttachInfoResponse
        /// </returns>
        public async Task<DescribeFilesystemsVscAttachInfoResponse> DescribeFilesystemsVscAttachInfoWithOptionsAsync(DescribeFilesystemsVscAttachInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFilesystemsVscAttachInfo",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilesystemsVscAttachInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual storage channels associated with a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesystemsVscAttachInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesystemsVscAttachInfoResponse
        /// </returns>
        public DescribeFilesystemsVscAttachInfoResponse DescribeFilesystemsVscAttachInfo(DescribeFilesystemsVscAttachInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFilesystemsVscAttachInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual storage channels associated with a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesystemsVscAttachInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesystemsVscAttachInfoResponse
        /// </returns>
        public async Task<DescribeFilesystemsVscAttachInfoResponse> DescribeFilesystemsVscAttachInfoAsync(DescribeFilesystemsVscAttachInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFilesystemsVscAttachInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries lifecycle policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLifecyclePoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLifecyclePoliciesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries lifecycle policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLifecyclePoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLifecyclePoliciesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries lifecycle policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLifecyclePoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLifecyclePoliciesResponse
        /// </returns>
        public DescribeLifecyclePoliciesResponse DescribeLifecyclePolicies(DescribeLifecyclePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLifecyclePoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries lifecycle policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLifecyclePoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLifecyclePoliciesResponse
        /// </returns>
        public async Task<DescribeLifecyclePoliciesResponse> DescribeLifecyclePoliciesAsync(DescribeLifecyclePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLifecyclePoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log dump information configured in log analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogAnalysisResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log dump information configured in log analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogAnalysisResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log dump information configured in log analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogAnalysisResponse
        /// </returns>
        public DescribeLogAnalysisResponse DescribeLogAnalysis(DescribeLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log dump information configured in log analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogAnalysisResponse
        /// </returns>
        public async Task<DescribeLogAnalysisResponse> DescribeLogAnalysisAsync(DescribeLogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries mount targets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMountTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountTargetsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries mount targets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMountTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountTargetsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries mount targets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMountTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountTargetsResponse
        /// </returns>
        public DescribeMountTargetsResponse DescribeMountTargets(DescribeMountTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMountTargetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries mount targets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMountTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountTargetsResponse
        /// </returns>
        public async Task<DescribeMountTargetsResponse> DescribeMountTargetsAsync(DescribeMountTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMountTargetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the clients on which a file system is mounted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>This operation returns the clients that have accessed the specified file system within the last minute. If the file system is mounted on a client but the client did not access the file system within the last minute, the client is not included in the returned information.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMountedClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountedClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the clients on which a file system is mounted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>This operation returns the clients that have accessed the specified file system within the last minute. If the file system is mounted on a client but the client did not access the file system within the last minute, the client is not included in the returned information.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMountedClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountedClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the clients on which a file system is mounted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>This operation returns the clients that have accessed the specified file system within the last minute. If the file system is mounted on a client but the client did not access the file system within the last minute, the client is not included in the returned information.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMountedClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountedClientsResponse
        /// </returns>
        public DescribeMountedClientsResponse DescribeMountedClients(DescribeMountedClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMountedClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the clients on which a file system is mounted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>This operation returns the clients that have accessed the specified file system within the last minute. If the file system is mounted on a client but the client did not access the file system within the last minute, the client is not included in the returned information.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMountedClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountedClientsResponse
        /// </returns>
        public async Task<DescribeMountedClientsResponse> DescribeMountedClientsAsync(DescribeMountedClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMountedClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the NFS ACL feature is enabled for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNfsAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNfsAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the NFS ACL feature is enabled for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNfsAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNfsAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the NFS ACL feature is enabled for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNfsAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNfsAclResponse
        /// </returns>
        public DescribeNfsAclResponse DescribeNfsAcl(DescribeNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNfsAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the NFS ACL feature is enabled for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNfsAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNfsAclResponse
        /// </returns>
        public async Task<DescribeNfsAclResponse> DescribeNfsAclAsync(DescribeNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNfsAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the export directories of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProtocolMountTargetResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceIds))
            {
                query["ProtocolServiceIds"] = request.ProtocolServiceIds;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the export directories of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProtocolMountTargetResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolServiceIds))
            {
                query["ProtocolServiceIds"] = request.ProtocolServiceIds;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the export directories of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProtocolMountTargetResponse
        /// </returns>
        public DescribeProtocolMountTargetResponse DescribeProtocolMountTarget(DescribeProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtocolMountTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the export directories of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProtocolMountTargetResponse
        /// </returns>
        public async Task<DescribeProtocolMountTargetResponse> DescribeProtocolMountTargetAsync(DescribeProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtocolMountTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about protocol services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProtocolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProtocolServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about protocol services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProtocolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProtocolServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about protocol services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProtocolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProtocolServiceResponse
        /// </returns>
        public DescribeProtocolServiceResponse DescribeProtocolService(DescribeProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtocolServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about protocol services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProtocolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProtocolServiceResponse
        /// </returns>
        public async Task<DescribeProtocolServiceResponse> DescribeProtocolServiceAsync(DescribeProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtocolServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions in which File Storage NAS is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions in which File Storage NAS is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions in which File Storage NAS is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions in which File Storage NAS is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSmbAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSmbAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSmbAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSmbAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSmbAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSmbAclResponse
        /// </returns>
        public DescribeSmbAclResponse DescribeSmbAcl(DescribeSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmbAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSmbAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSmbAclResponse
        /// </returns>
        public async Task<DescribeSmbAclResponse> DescribeSmbAclAsync(DescribeSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmbAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more snapshots of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSnapshotsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more snapshots of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSnapshotsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more snapshots of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSnapshotsResponse
        /// </returns>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more snapshots of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSnapshotsResponse
        /// </returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the DescribeStoragePackages operation to query the list of storage plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStoragePackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStoragePackagesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the DescribeStoragePackages operation to query the list of storage plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStoragePackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStoragePackagesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the DescribeStoragePackages operation to query the list of storage plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStoragePackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStoragePackagesResponse
        /// </returns>
        public DescribeStoragePackagesResponse DescribeStoragePackages(DescribeStoragePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStoragePackagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the DescribeStoragePackages operation to query the list of storage plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStoragePackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStoragePackagesResponse
        /// </returns>
        public async Task<DescribeStoragePackagesResponse> DescribeStoragePackagesAsync(DescribeStoragePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStoragePackagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all zones in a region and the file system types that are supported in each zone.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all zones in a region and the file system types that are supported in each zone.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all zones in a region and the file system types that are supported in each zone.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all zones in a region and the file system types that are supported in each zone.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unassociates a VSC device from a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachVscFromFilesystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachVscFromFilesystemsResponse
        /// </returns>
        public DetachVscFromFilesystemsResponse DetachVscFromFilesystemsWithOptions(DetachVscFromFilesystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachVscFromFilesystems",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachVscFromFilesystemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unassociates a VSC device from a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachVscFromFilesystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachVscFromFilesystemsResponse
        /// </returns>
        public async Task<DetachVscFromFilesystemsResponse> DetachVscFromFilesystemsWithOptionsAsync(DetachVscFromFilesystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachVscFromFilesystems",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachVscFromFilesystemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unassociates a VSC device from a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachVscFromFilesystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachVscFromFilesystemsResponse
        /// </returns>
        public DetachVscFromFilesystemsResponse DetachVscFromFilesystems(DetachVscFromFilesystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachVscFromFilesystemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unassociates a VSC device from a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only CPFS for Lingjun supports this operation.</para>
        /// <list type="bullet">
        /// <item><description>Batch execution is supported. In batch execution, only one VscId can be associated with multiple FileSystemIDs, meaning the VscId in the ResourceIds must be the same.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachVscFromFilesystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachVscFromFilesystemsResponse
        /// </returns>
        public async Task<DetachVscFromFilesystemsResponse> DetachVscFromFilesystemsAsync(DetachVscFromFilesystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachVscFromFilesystemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables and empties the recycle bin of a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>If you disable the recycle bin, all files in the recycle bin are permanently deleted.</description></item>
        /// <item><description>If you disable and then enable the recycle bin, the recycle bin is empty. You cannot retrieve the deleted files.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAndCleanRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAndCleanRecycleBinResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables and empties the recycle bin of a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>If you disable the recycle bin, all files in the recycle bin are permanently deleted.</description></item>
        /// <item><description>If you disable and then enable the recycle bin, the recycle bin is empty. You cannot retrieve the deleted files.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAndCleanRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAndCleanRecycleBinResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables and empties the recycle bin of a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>If you disable the recycle bin, all files in the recycle bin are permanently deleted.</description></item>
        /// <item><description>If you disable and then enable the recycle bin, the recycle bin is empty. You cannot retrieve the deleted files.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAndCleanRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAndCleanRecycleBinResponse
        /// </returns>
        public DisableAndCleanRecycleBinResponse DisableAndCleanRecycleBin(DisableAndCleanRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAndCleanRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables and empties the recycle bin of a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>If you disable the recycle bin, all files in the recycle bin are permanently deleted.</description></item>
        /// <item><description>If you disable and then enable the recycle bin, the recycle bin is empty. You cannot retrieve the deleted files.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAndCleanRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAndCleanRecycleBinResponse
        /// </returns>
        public async Task<DisableAndCleanRecycleBinResponse> DisableAndCleanRecycleBinAsync(DisableAndCleanRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAndCleanRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the NFS ACL feature for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableNfsAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableNfsAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the NFS ACL feature for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableNfsAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableNfsAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the NFS ACL feature for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableNfsAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableNfsAclResponse
        /// </returns>
        public DisableNfsAclResponse DisableNfsAcl(DisableNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableNfsAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the NFS ACL feature for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableNfsAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableNfsAclResponse
        /// </returns>
        public async Task<DisableNfsAclResponse> DisableNfsAclAsync(DisableNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableNfsAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSmbAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableSmbAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSmbAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableSmbAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSmbAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableSmbAclResponse
        /// </returns>
        public DisableSmbAclResponse DisableSmbAcl(DisableSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSmbAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSmbAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableSmbAclResponse
        /// </returns>
        public async Task<DisableSmbAclResponse> DisableSmbAclAsync(DisableSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSmbAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the NFS ACL feature for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableNfsAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableNfsAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the NFS ACL feature for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableNfsAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableNfsAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the NFS ACL feature for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableNfsAclRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableNfsAclResponse
        /// </returns>
        public EnableNfsAclResponse EnableNfsAcl(EnableNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableNfsAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the NFS ACL feature for a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableNfsAclRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableNfsAclResponse
        /// </returns>
        public async Task<EnableNfsAclResponse> EnableNfsAclAsync(EnableNfsAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableNfsAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the recycle bin feature for a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableRecycleBinResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the recycle bin feature for a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableRecycleBinResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the recycle bin feature for a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableRecycleBinResponse
        /// </returns>
        public EnableRecycleBinResponse EnableRecycleBin(EnableRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the recycle bin feature for a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableRecycleBinResponse
        /// </returns>
        public async Task<EnableRecycleBinResponse> EnableRecycleBinAsync(EnableRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableSmbAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableSmbAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableSmbAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableSmbAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableSmbAclRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableSmbAclResponse
        /// </returns>
        public EnableSmbAclResponse EnableSmbAcl(EnableSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSmbAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the access control list (ACL) feature for a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableSmbAclRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableSmbAclResponse
        /// </returns>
        public async Task<EnableSmbAclResponse> EnableSmbAclAsync(EnableSmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSmbAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether a directory contains files that are stored in the Infrequent Access (IA) or Archive storage class, or whether a file is stored in the IA or Archive storage class.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryOrFilePropertiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryOrFilePropertiesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether a directory contains files that are stored in the Infrequent Access (IA) or Archive storage class, or whether a file is stored in the IA or Archive storage class.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryOrFilePropertiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryOrFilePropertiesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether a directory contains files that are stored in the Infrequent Access (IA) or Archive storage class, or whether a file is stored in the IA or Archive storage class.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryOrFilePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryOrFilePropertiesResponse
        /// </returns>
        public GetDirectoryOrFilePropertiesResponse GetDirectoryOrFileProperties(GetDirectoryOrFilePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDirectoryOrFilePropertiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether a directory contains files that are stored in the Infrequent Access (IA) or Archive storage class, or whether a file is stored in the IA or Archive storage class.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryOrFilePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryOrFilePropertiesResponse
        /// </returns>
        public async Task<GetDirectoryOrFilePropertiesResponse> GetDirectoryOrFilePropertiesAsync(GetDirectoryOrFilePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDirectoryOrFilePropertiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the recycle bin configurations of a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose File Storage NAS (NAS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRecycleBinAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleBinAttributeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the recycle bin configurations of a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose File Storage NAS (NAS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRecycleBinAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleBinAttributeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the recycle bin configurations of a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose File Storage NAS (NAS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRecycleBinAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleBinAttributeResponse
        /// </returns>
        public GetRecycleBinAttributeResponse GetRecycleBinAttribute(GetRecycleBinAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRecycleBinAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the recycle bin configurations of a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose File Storage NAS (NAS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRecycleBinAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecycleBinAttributeResponse
        /// </returns>
        public async Task<GetRecycleBinAttributeResponse> GetRecycleBinAttributeAsync(GetRecycleBinAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRecycleBinAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the infrequently-accessed files in a specified directory of a General-purpose NAS file system and the subdirectories that contain the files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDirectoriesAndFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDirectoriesAndFilesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the infrequently-accessed files in a specified directory of a General-purpose NAS file system and the subdirectories that contain the files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDirectoriesAndFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDirectoriesAndFilesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the infrequently-accessed files in a specified directory of a General-purpose NAS file system and the subdirectories that contain the files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDirectoriesAndFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDirectoriesAndFilesResponse
        /// </returns>
        public ListDirectoriesAndFilesResponse ListDirectoriesAndFiles(ListDirectoriesAndFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDirectoriesAndFilesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the infrequently-accessed files in a specified directory of a General-purpose NAS file system and the subdirectories that contain the files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDirectoriesAndFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDirectoriesAndFilesResponse
        /// </returns>
        public async Task<ListDirectoriesAndFilesResponse> ListDirectoriesAndFilesAsync(ListDirectoriesAndFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDirectoriesAndFilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data retrieval tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLifecycleRetrieveJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLifecycleRetrieveJobsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data retrieval tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLifecycleRetrieveJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLifecycleRetrieveJobsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data retrieval tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLifecycleRetrieveJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLifecycleRetrieveJobsResponse
        /// </returns>
        public ListLifecycleRetrieveJobsResponse ListLifecycleRetrieveJobs(ListLifecycleRetrieveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLifecycleRetrieveJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data retrieval tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLifecycleRetrieveJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLifecycleRetrieveJobsResponse
        /// </returns>
        public async Task<ListLifecycleRetrieveJobsResponse> ListLifecycleRetrieveJobsAsync(ListLifecycleRetrieveJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLifecycleRetrieveJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the directories that are recently deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecentlyRecycledDirectoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecentlyRecycledDirectoriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the directories that are recently deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecentlyRecycledDirectoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecentlyRecycledDirectoriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the directories that are recently deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecentlyRecycledDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecentlyRecycledDirectoriesResponse
        /// </returns>
        public ListRecentlyRecycledDirectoriesResponse ListRecentlyRecycledDirectories(ListRecentlyRecycledDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecentlyRecycledDirectoriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the directories that are recently deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecentlyRecycledDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecentlyRecycledDirectoriesResponse
        /// </returns>
        public async Task<ListRecentlyRecycledDirectoriesResponse> ListRecentlyRecycledDirectoriesAsync(ListRecentlyRecycledDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecentlyRecycledDirectoriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the jobs of the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can query a maximum of 50 jobs that are recently executed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecycleBinJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecycleBinJobsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the jobs of the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can query a maximum of 50 jobs that are recently executed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecycleBinJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecycleBinJobsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the jobs of the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can query a maximum of 50 jobs that are recently executed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecycleBinJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecycleBinJobsResponse
        /// </returns>
        public ListRecycleBinJobsResponse ListRecycleBinJobs(ListRecycleBinJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecycleBinJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the jobs of the recycle bin.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only General-purpose NAS file systems support this operation.</para>
        /// <list type="bullet">
        /// <item><description>You can query a maximum of 50 jobs that are recently executed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecycleBinJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecycleBinJobsResponse
        /// </returns>
        public async Task<ListRecycleBinJobsResponse> ListRecycleBinJobsAsync(ListRecycleBinJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecycleBinJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deleted files or directories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecycledDirectoriesAndFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecycledDirectoriesAndFilesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deleted files or directories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecycledDirectoriesAndFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecycledDirectoriesAndFilesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deleted files or directories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecycledDirectoriesAndFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecycledDirectoriesAndFilesResponse
        /// </returns>
        public ListRecycledDirectoriesAndFilesResponse ListRecycledDirectoriesAndFiles(ListRecycledDirectoriesAndFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecycledDirectoriesAndFilesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deleted files or directories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRecycledDirectoriesAndFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecycledDirectoriesAndFilesResponse
        /// </returns>
        public async Task<ListRecycledDirectoriesAndFilesResponse> ListRecycledDirectoriesAndFilesAsync(ListRecycledDirectoriesAndFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecycledDirectoriesAndFilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessGroupResponse
        /// </returns>
        public ModifyAccessGroupResponse ModifyAccessGroup(ModifyAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessGroupResponse
        /// </returns>
        public async Task<ModifyAccessGroupResponse> ModifyAccessGroupAsync(ModifyAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessPointResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessPointResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessPointResponse
        /// </returns>
        public ModifyAccessPointResponse ModifyAccessPoint(ModifyAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about an access point.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose Network File System (NFS) file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessPointResponse
        /// </returns>
        public async Task<ModifyAccessPointResponse> ModifyAccessPointAsync(ModifyAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a rule in a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessRuleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a rule in a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessRuleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a rule in a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessRuleResponse
        /// </returns>
        public ModifyAccessRuleResponse ModifyAccessRule(ModifyAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a rule in a permission group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The rules in the default permission group (DEFAULT_VPC_GROUP_NAME) cannot be modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessRuleResponse
        /// </returns>
        public async Task<ModifyAccessRuleResponse> ModifyAccessRuleAsync(ModifyAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An automatic snapshot policy is modified. After you modify an automatic snapshot policy that is applied to a file system, the modification immediately applies to subsequent snapshots that are created for the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An automatic snapshot policy is modified. After you modify an automatic snapshot policy that is applied to a file system, the modification immediately applies to subsequent snapshots that are created for the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoSnapshotPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An automatic snapshot policy is modified. After you modify an automatic snapshot policy that is applied to a file system, the modification immediately applies to subsequent snapshots that are created for the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoSnapshotPolicyResponse
        /// </returns>
        public ModifyAutoSnapshotPolicyResponse ModifyAutoSnapshotPolicy(ModifyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An automatic snapshot policy is modified. After you modify an automatic snapshot policy that is applied to a file system, the modification immediately applies to subsequent snapshots that are created for the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<ModifyAutoSnapshotPolicyResponse> ModifyAutoSnapshotPolicyAsync(ModifyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows.</para>
        /// <list type="bullet">
        /// <item><description>You can modify the attributes only of the data flows that are in the <c>Running</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to modify the attributes of a data flow. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the status of the data flow to be modified.</description></item>
        /// <item><description>CPFS data flow specifications:<list type="bullet">
        /// <item><description>The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.</description></item>
        /// <item><description>Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the dataflow whose throughput is changed meet the requirements.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Billing of CPFS file systems
        /// Changing the dataflow throughput involves the billing of dataflow bandwidth. We recommend that you understand CPFS billing methods in advance. For more information, see <a href="https://help.aliyun.com/document_detail/111858.html">Billing methods and billable items of CPFS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows.</para>
        /// <list type="bullet">
        /// <item><description>You can modify the attributes only of the data flows that are in the <c>Running</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to modify the attributes of a data flow. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the status of the data flow to be modified.</description></item>
        /// <item><description>CPFS data flow specifications:<list type="bullet">
        /// <item><description>The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.</description></item>
        /// <item><description>Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the dataflow whose throughput is changed meet the requirements.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Billing of CPFS file systems
        /// Changing the dataflow throughput involves the billing of dataflow bandwidth. We recommend that you understand CPFS billing methods in advance. For more information, see <a href="https://help.aliyun.com/document_detail/111858.html">Billing methods and billable items of CPFS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows.</para>
        /// <list type="bullet">
        /// <item><description>You can modify the attributes only of the data flows that are in the <c>Running</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to modify the attributes of a data flow. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the status of the data flow to be modified.</description></item>
        /// <item><description>CPFS data flow specifications:<list type="bullet">
        /// <item><description>The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.</description></item>
        /// <item><description>Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the dataflow whose throughput is changed meet the requirements.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Billing of CPFS file systems
        /// Changing the dataflow throughput involves the billing of dataflow bandwidth. We recommend that you understand CPFS billing methods in advance. For more information, see <a href="https://help.aliyun.com/document_detail/111858.html">Billing methods and billable items of CPFS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataFlowResponse
        /// </returns>
        public ModifyDataFlowResponse ModifyDataFlow(ModifyDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) V2.2.0 and later and CPFS for Lingjun V2.4.0 and later support data flows.</para>
        /// <list type="bullet">
        /// <item><description>You can modify the attributes only of the data flows that are in the <c>Running</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to modify the attributes of a data flow. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the status of the data flow to be modified.</description></item>
        /// <item><description>CPFS data flow specifications:<list type="bullet">
        /// <item><description>The data flow throughput supports the following specifications: 600 MB/s, 1,200 MB/s, and 1,500 MB/s. The data flow throughput is the maximum transmission bandwidth that can be reached when data is imported or exported for a data flow.</description></item>
        /// <item><description>Inventory query: If you set the DryRun parameter to true, you can check whether the resources for the dataflow whose throughput is changed meet the requirements.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Billing of CPFS file systems
        /// Changing the dataflow throughput involves the billing of dataflow bandwidth. We recommend that you understand CPFS billing methods in advance. For more information, see <a href="https://help.aliyun.com/document_detail/111858.html">Billing methods and billable items of CPFS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataFlowResponse
        /// </returns>
        public async Task<ModifyDataFlowResponse> ModifyDataFlowAsync(ModifyDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an AutoRefresh configuration of a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to CPFS file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can modify the AutoRefresh configurations only for the dataflows that are in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to modify an AutoRefresh configuration. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the task of modifying an AutoRefresh configuration.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDataFlowAutoRefreshRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataFlowAutoRefreshResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an AutoRefresh configuration of a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to CPFS file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can modify the AutoRefresh configurations only for the dataflows that are in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to modify an AutoRefresh configuration. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the task of modifying an AutoRefresh configuration.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDataFlowAutoRefreshRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataFlowAutoRefreshResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an AutoRefresh configuration of a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to CPFS file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can modify the AutoRefresh configurations only for the dataflows that are in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to modify an AutoRefresh configuration. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the task of modifying an AutoRefresh configuration.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDataFlowAutoRefreshRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataFlowAutoRefreshResponse
        /// </returns>
        public ModifyDataFlowAutoRefreshResponse ModifyDataFlowAutoRefresh(ModifyDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataFlowAutoRefreshWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an AutoRefresh configuration of a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to CPFS file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can modify the AutoRefresh configurations only for the dataflows that are in the <c>Running</c> or <c>Stopped</c> state.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to modify an AutoRefresh configuration. You can call the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation to query the task of modifying an AutoRefresh configuration.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDataFlowAutoRefreshRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataFlowAutoRefreshResponse
        /// </returns>
        public async Task<ModifyDataFlowAutoRefreshResponse> ModifyDataFlowAutoRefreshAsync(ModifyDataFlowAutoRefreshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataFlowAutoRefreshWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a file system.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a file system.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileSystemResponse
        /// </returns>
        public ModifyFileSystemResponse ModifyFileSystem(ModifyFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFileSystemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileSystemResponse
        /// </returns>
        public async Task<ModifyFileSystemResponse> ModifyFileSystemAsync(ModifyFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFileSystemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFilesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFilesetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFilesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFilesetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFilesetRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFilesetResponse
        /// </returns>
        public ModifyFilesetResponse ModifyFileset(ModifyFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFilesetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only Cloud Parallel File Storage (CPFS) V2.2.0 and CPFS for Lingjun V2.7.0 and later support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFilesetRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFilesetResponse
        /// </returns>
        public async Task<ModifyFilesetResponse> ModifyFilesetAsync(ModifyFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFilesetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to modify LDAP configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLDAPConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyLDAPConfig is deprecated")]
        // Deprecated
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to modify LDAP configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLDAPConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyLDAPConfig is deprecated")]
        // Deprecated
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to modify LDAP configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLDAPConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyLDAPConfig is deprecated")]
        // Deprecated
        public ModifyLDAPConfigResponse ModifyLDAPConfig(ModifyLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLDAPConfigWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyLDAPConfig is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to modify LDAP configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLDAPConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLDAPConfigResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyLDAPConfig is deprecated")]
        // Deprecated
        public async Task<ModifyLDAPConfigResponse> ModifyLDAPConfigAsync(ModifyLDAPConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLDAPConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLifecyclePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLifecyclePolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLifecyclePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLifecyclePolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLifecyclePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLifecyclePolicyResponse
        /// </returns>
        public ModifyLifecyclePolicyResponse ModifyLifecyclePolicy(ModifyLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLifecyclePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLifecyclePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLifecyclePolicyResponse
        /// </returns>
        public async Task<ModifyLifecyclePolicyResponse> ModifyLifecyclePolicyAsync(ModifyLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLifecyclePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a mount target.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a mount target.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a mount target.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMountTargetResponse
        /// </returns>
        public ModifyMountTargetResponse ModifyMountTarget(ModifyMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMountTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a mount target.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMountTargetResponse
        /// </returns>
        public async Task<ModifyMountTargetResponse> ModifyMountTargetAsync(ModifyMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMountTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the export directory parameters of a protocol service. Only the description can be modified. The virtual private cloud (VPC) ID and vSwitch ID cannot be changed. To change these IDs, you must delete the export directory and create a new one.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyProtocolMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the export directory parameters of a protocol service. Only the description can be modified. The virtual private cloud (VPC) ID and vSwitch ID cannot be changed. To change these IDs, you must delete the export directory and create a new one.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyProtocolMountTargetResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the export directory parameters of a protocol service. Only the description can be modified. The virtual private cloud (VPC) ID and vSwitch ID cannot be changed. To change these IDs, you must delete the export directory and create a new one.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyProtocolMountTargetResponse
        /// </returns>
        public ModifyProtocolMountTargetResponse ModifyProtocolMountTarget(ModifyProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtocolMountTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the export directory parameters of a protocol service. Only the description can be modified. The virtual private cloud (VPC) ID and vSwitch ID cannot be changed. To change these IDs, you must delete the export directory and create a new one.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyProtocolMountTargetResponse
        /// </returns>
        public async Task<ModifyProtocolMountTargetResponse> ModifyProtocolMountTargetAsync(ModifyProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtocolMountTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a protocol service. You can modify the description of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyProtocolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyProtocolServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a protocol service. You can modify the description of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyProtocolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyProtocolServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a protocol service. You can modify the description of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyProtocolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyProtocolServiceResponse
        /// </returns>
        public ModifyProtocolServiceResponse ModifyProtocolService(ModifyProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtocolServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a protocol service. You can modify the description of a protocol service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only to Cloud Parallel File Storage (CPFS) file systems on the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyProtocolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyProtocolServiceResponse
        /// </returns>
        public async Task<ModifyProtocolServiceResponse> ModifyProtocolServiceAsync(ModifyProtocolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtocolServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySmbAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySmbAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySmbAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySmbAclResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySmbAclRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySmbAclResponse
        /// </returns>
        public ModifySmbAclResponse ModifySmbAcl(ModifySmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmbAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about the access control list (ACL) feature of a Server Message Block (SMB) file system that resides in an Active Directory (AD) domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySmbAclRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySmbAclResponse
        /// </returns>
        public async Task<ModifySmbAclResponse> ModifySmbAclAsync(ModifySmbAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmbAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates File Storage NAS.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenNASServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenNASServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates File Storage NAS.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenNASServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenNASServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates File Storage NAS.</para>
        /// </summary>
        /// 
        /// <returns>
        /// OpenNASServiceResponse
        /// </returns>
        public OpenNASServiceResponse OpenNASService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenNASServiceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates File Storage NAS.</para>
        /// </summary>
        /// 
        /// <returns>
        /// OpenNASServiceResponse
        /// </returns>
        public async Task<OpenNASServiceResponse> OpenNASServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenNASServiceWithOptionsAsync(runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI RemoveClientFromBlackList is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Remove the client from the blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveClientFromBlackListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveClientFromBlackListResponse
        /// </returns>
        [Obsolete("OpenAPI RemoveClientFromBlackList is deprecated")]
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI RemoveClientFromBlackList is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Remove the client from the blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveClientFromBlackListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveClientFromBlackListResponse
        /// </returns>
        [Obsolete("OpenAPI RemoveClientFromBlackList is deprecated")]
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI RemoveClientFromBlackList is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Remove the client from the blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveClientFromBlackListRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveClientFromBlackListResponse
        /// </returns>
        [Obsolete("OpenAPI RemoveClientFromBlackList is deprecated")]
        // Deprecated
        public RemoveClientFromBlackListResponse RemoveClientFromBlackList(RemoveClientFromBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveClientFromBlackListWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI RemoveClientFromBlackList is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Remove the client from the blacklist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API operation is available only for CPFS file systems.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveClientFromBlackListRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveClientFromBlackListResponse
        /// </returns>
        [Obsolete("OpenAPI RemoveClientFromBlackList is deprecated")]
        // Deprecated
        public async Task<RemoveClientFromBlackListResponse> RemoveClientFromBlackListAsync(RemoveClientFromBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveClientFromBlackListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a file system to a snapshot of the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// <item><description>The file system must be in the Running state.</description></item>
        /// <item><description>To roll back a file system to a snapshot, you must specify the ID of the snapshot that is created from the file system.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a file system to a snapshot of the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// <item><description>The file system must be in the Running state.</description></item>
        /// <item><description>To roll back a file system to a snapshot, you must specify the ID of the snapshot that is created from the file system.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a file system to a snapshot of the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// <item><description>The file system must be in the Running state.</description></item>
        /// <item><description>To roll back a file system to a snapshot, you must specify the ID of the snapshot that is created from the file system.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetFileSystemResponse
        /// </returns>
        public ResetFileSystemResponse ResetFileSystem(ResetFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetFileSystemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a file system to a snapshot of the file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The snapshot feature is in public preview and is provided free of charge. <a href="https://www.alibabacloud.com/help/legal/latest/network-attached-storage-service-level-agreement">File Storage NAS Service Level Agreement (SLA)</a> is not guaranteed in public preview.</para>
        /// <list type="bullet">
        /// <item><description>Only advanced Extreme NAS file systems support this feature.</description></item>
        /// <item><description>The file system must be in the Running state.</description></item>
        /// <item><description>To roll back a file system to a snapshot, you must specify the ID of the snapshot that is created from the file system.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetFileSystemResponse
        /// </returns>
        public async Task<ResetFileSystemResponse> ResetFileSystemAsync(ResetFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetFileSystemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retries failed a data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryLifecycleRetrieveJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryLifecycleRetrieveJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retries failed a data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryLifecycleRetrieveJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryLifecycleRetrieveJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retries failed a data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryLifecycleRetrieveJobRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryLifecycleRetrieveJobResponse
        /// </returns>
        public RetryLifecycleRetrieveJobResponse RetryLifecycleRetrieveJob(RetryLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryLifecycleRetrieveJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retries failed a data retrieval task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryLifecycleRetrieveJobRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryLifecycleRetrieveJobResponse
        /// </returns>
        public async Task<RetryLifecycleRetrieveJobResponse> RetryLifecycleRetrieveJobAsync(RetryLifecycleRetrieveJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryLifecycleRetrieveJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory quota for a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose File Storage NAS (NAS) file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDirQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDirQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory quota for a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose File Storage NAS (NAS) file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDirQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDirQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory quota for a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose File Storage NAS (NAS) file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDirQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDirQuotaResponse
        /// </returns>
        public SetDirQuotaResponse SetDirQuota(SetDirQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDirQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory quota for a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose File Storage NAS (NAS) file systems support the directory quota feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDirQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDirQuotaResponse
        /// </returns>
        public async Task<SetDirQuotaResponse> SetDirQuotaAsync(SetDirQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDirQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the quota for a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for Lingjun V2.7.0 and later support this operation.</para>
        /// <list type="bullet">
        /// <item><description>The minimum capacity quota of a fileset is 10 GiB. The scaling step size is 1 GiB.</description></item>
        /// <item><description>A fileset supports a minimum of 10,000 files or directories and a maximum of 10 billion files or directories. The scaling step size is 1.</description></item>
        /// <item><description>When modifying a directory quota, you must set the new capacity or file quantity higher than what is currently used.</description></item>
        /// <item><description>You must configure at least one of the Capacity Limit (GiB) and File Limit parameters.</description></item>
        /// <item><description>The quota statistics have a 15-minute latency. The actual usage takes effect after 15 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetFilesetQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFilesetQuotaResponse
        /// </returns>
        public SetFilesetQuotaResponse SetFilesetQuotaWithOptions(SetFilesetQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCountLimit))
            {
                query["FileCountLimit"] = request.FileCountLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeLimit))
            {
                query["SizeLimit"] = request.SizeLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFilesetQuota",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetFilesetQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the quota for a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for Lingjun V2.7.0 and later support this operation.</para>
        /// <list type="bullet">
        /// <item><description>The minimum capacity quota of a fileset is 10 GiB. The scaling step size is 1 GiB.</description></item>
        /// <item><description>A fileset supports a minimum of 10,000 files or directories and a maximum of 10 billion files or directories. The scaling step size is 1.</description></item>
        /// <item><description>When modifying a directory quota, you must set the new capacity or file quantity higher than what is currently used.</description></item>
        /// <item><description>You must configure at least one of the Capacity Limit (GiB) and File Limit parameters.</description></item>
        /// <item><description>The quota statistics have a 15-minute latency. The actual usage takes effect after 15 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetFilesetQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFilesetQuotaResponse
        /// </returns>
        public async Task<SetFilesetQuotaResponse> SetFilesetQuotaWithOptionsAsync(SetFilesetQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCountLimit))
            {
                query["FileCountLimit"] = request.FileCountLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsetId))
            {
                query["FsetId"] = request.FsetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeLimit))
            {
                query["SizeLimit"] = request.SizeLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFilesetQuota",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetFilesetQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the quota for a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for Lingjun V2.7.0 and later support this operation.</para>
        /// <list type="bullet">
        /// <item><description>The minimum capacity quota of a fileset is 10 GiB. The scaling step size is 1 GiB.</description></item>
        /// <item><description>A fileset supports a minimum of 10,000 files or directories and a maximum of 10 billion files or directories. The scaling step size is 1.</description></item>
        /// <item><description>When modifying a directory quota, you must set the new capacity or file quantity higher than what is currently used.</description></item>
        /// <item><description>You must configure at least one of the Capacity Limit (GiB) and File Limit parameters.</description></item>
        /// <item><description>The quota statistics have a 15-minute latency. The actual usage takes effect after 15 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetFilesetQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFilesetQuotaResponse
        /// </returns>
        public SetFilesetQuotaResponse SetFilesetQuota(SetFilesetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetFilesetQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the quota for a fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Cloud Parallel File Storage (CPFS) for Lingjun V2.7.0 and later support this operation.</para>
        /// <list type="bullet">
        /// <item><description>The minimum capacity quota of a fileset is 10 GiB. The scaling step size is 1 GiB.</description></item>
        /// <item><description>A fileset supports a minimum of 10,000 files or directories and a maximum of 10 billion files or directories. The scaling step size is 1.</description></item>
        /// <item><description>When modifying a directory quota, you must set the new capacity or file quantity higher than what is currently used.</description></item>
        /// <item><description>You must configure at least one of the Capacity Limit (GiB) and File Limit parameters.</description></item>
        /// <item><description>The quota statistics have a 15-minute latency. The actual usage takes effect after 15 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetFilesetQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFilesetQuotaResponse
        /// </returns>
        public async Task<SetFilesetQuotaResponse> SetFilesetQuotaAsync(SetFilesetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetFilesetQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can enable the data flows that are only in the <c>Stopped</c> state.</description></item>
        /// <item><description>If the value of DryRun is <c>true</c>, you can check whether sufficient resources are available to enable the specified data flow. If the resources are insufficient, the data flow cannot be enabled.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to enable a data flow. You can query the data flow status by calling the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can enable the data flows that are only in the <c>Stopped</c> state.</description></item>
        /// <item><description>If the value of DryRun is <c>true</c>, you can check whether sufficient resources are available to enable the specified data flow. If the resources are insufficient, the data flow cannot be enabled.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to enable a data flow. You can query the data flow status by calling the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can enable the data flows that are only in the <c>Stopped</c> state.</description></item>
        /// <item><description>If the value of DryRun is <c>true</c>, you can check whether sufficient resources are available to enable the specified data flow. If the resources are insufficient, the data flow cannot be enabled.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to enable a data flow. You can query the data flow status by calling the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDataFlowResponse
        /// </returns>
        public StartDataFlowResponse StartDataFlow(StartDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDataFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to Cloud Parallel File Storage (CPFS) file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support data flows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can enable the data flows that are only in the <c>Stopped</c> state.</description></item>
        /// <item><description>If the value of DryRun is <c>true</c>, you can check whether sufficient resources are available to enable the specified data flow. If the resources are insufficient, the data flow cannot be enabled.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to enable a data flow. You can query the data flow status by calling the <a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDataFlowResponse
        /// </returns>
        public async Task<StartDataFlowResponse> StartDataFlowAsync(StartDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDataFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to CPFS file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can disable only the dataflows that are in the <c>Running</c> state.</description></item>
        /// <item><description>After a dataflow is disabled, you cannot create a dataflow task for the dataflow. If AutoRefresh is configured, source data updates are not synchronized to CPFS.</description></item>
        /// <item><description>After a dataflow is disabled, the dataflow throughput is no longer billed because resources are reclaimed. However, the dataflow may fail to be restarted due to insufficient resources.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to disable a dataflow. You can call the <a href="https://help.aliyun.com/document_detail/2402271.html">DescribeDataFlows</a> operation to query the dataflow status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to CPFS file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can disable only the dataflows that are in the <c>Running</c> state.</description></item>
        /// <item><description>After a dataflow is disabled, you cannot create a dataflow task for the dataflow. If AutoRefresh is configured, source data updates are not synchronized to CPFS.</description></item>
        /// <item><description>After a dataflow is disabled, the dataflow throughput is no longer billed because resources are reclaimed. However, the dataflow may fail to be restarted due to insufficient resources.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to disable a dataflow. You can call the <a href="https://help.aliyun.com/document_detail/2402271.html">DescribeDataFlows</a> operation to query the dataflow status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDataFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDataFlowResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to CPFS file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can disable only the dataflows that are in the <c>Running</c> state.</description></item>
        /// <item><description>After a dataflow is disabled, you cannot create a dataflow task for the dataflow. If AutoRefresh is configured, source data updates are not synchronized to CPFS.</description></item>
        /// <item><description>After a dataflow is disabled, the dataflow throughput is no longer billed because resources are reclaimed. However, the dataflow may fail to be restarted due to insufficient resources.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to disable a dataflow. You can call the <a href="https://help.aliyun.com/document_detail/2402271.html">DescribeDataFlows</a> operation to query the dataflow status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDataFlowResponse
        /// </returns>
        public StopDataFlowResponse StopDataFlow(StopDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDataFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is available only to CPFS file systems.</para>
        /// <list type="bullet">
        /// <item><description>Only CPFS V2.2.0 and later support dataflows. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>You can disable only the dataflows that are in the <c>Running</c> state.</description></item>
        /// <item><description>After a dataflow is disabled, you cannot create a dataflow task for the dataflow. If AutoRefresh is configured, source data updates are not synchronized to CPFS.</description></item>
        /// <item><description>After a dataflow is disabled, the dataflow throughput is no longer billed because resources are reclaimed. However, the dataflow may fail to be restarted due to insufficient resources.</description></item>
        /// <item><description>It generally takes 2 to 5 minutes to disable a dataflow. You can call the <a href="https://help.aliyun.com/document_detail/2402271.html">DescribeDataFlows</a> operation to query the dataflow status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDataFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDataFlowResponse
        /// </returns>
        public async Task<StopDataFlowResponse> StopDataFlowAsync(StopDataFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDataFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and binds the tags to file systems.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and binds the tags to file systems.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and binds the tags to file systems.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and binds the tags to file systems.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a file system.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the retention period of data in the recycle bin of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRecycleBinAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecycleBinAttributeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the retention period of data in the recycle bin of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRecycleBinAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecycleBinAttributeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the retention period of data in the recycle bin of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRecycleBinAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecycleBinAttributeResponse
        /// </returns>
        public UpdateRecycleBinAttributeResponse UpdateRecycleBinAttribute(UpdateRecycleBinAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecycleBinAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the retention period of data in the recycle bin of a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only General-purpose NAS file systems support this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRecycleBinAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecycleBinAttributeResponse
        /// </returns>
        public async Task<UpdateRecycleBinAttributeResponse> UpdateRecycleBinAttributeAsync(UpdateRecycleBinAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecycleBinAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up an Extreme NAS file system or a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Extreme NAS file systems and CPFS file systems can be scaled up. CPFS file systems are available only on the China site (aliyun.com).</para>
        /// <list type="bullet">
        /// <item><description>A General-purpose NAS file system is automatically scaled up. You do not need to call this operation to scale up a General-purpose NAS file system.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up an Extreme NAS file system or a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Extreme NAS file systems and CPFS file systems can be scaled up. CPFS file systems are available only on the China site (aliyun.com).</para>
        /// <list type="bullet">
        /// <item><description>A General-purpose NAS file system is automatically scaled up. You do not need to call this operation to scale up a General-purpose NAS file system.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up an Extreme NAS file system or a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Extreme NAS file systems and CPFS file systems can be scaled up. CPFS file systems are available only on the China site (aliyun.com).</para>
        /// <list type="bullet">
        /// <item><description>A General-purpose NAS file system is automatically scaled up. You do not need to call this operation to scale up a General-purpose NAS file system.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeFileSystemResponse
        /// </returns>
        public UpgradeFileSystemResponse UpgradeFileSystem(UpgradeFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeFileSystemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up an Extreme NAS file system or a Cloud Parallel File Storage (CPFS) file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only Extreme NAS file systems and CPFS file systems can be scaled up. CPFS file systems are available only on the China site (aliyun.com).</para>
        /// <list type="bullet">
        /// <item><description>A General-purpose NAS file system is automatically scaled up. You do not need to call this operation to scale up a General-purpose NAS file system.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeFileSystemResponse
        /// </returns>
        public async Task<UpgradeFileSystemResponse> UpgradeFileSystemAsync(UpgradeFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeFileSystemWithOptionsAsync(request, runtime);
        }

    }
}
