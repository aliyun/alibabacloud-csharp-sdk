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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持状态为<c>Running（正常）</c>状态的数据流动添加自动更新配置。</description></item>
        /// <item><description>一个数据流动最多可以添加5个自动更新配置。</description></item>
        /// <item><description>创建自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
        /// <item><description>自动更新依赖EventBridge收集源端OSS存储的对象修改事件。需要先<a href="https://help.aliyun.com/document_detail/182246.html">开通EventBridge服务</a>。<remarks>
        /// <para>CPFS在EventBridge创建的事件总线、事件规则带有<c>Create for cpfs auto refresh</c>的描述，事件总线、事件规则都不能修改和删除，否则自动更新无法正常工作。</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>自动更新的作用对象是prefix，由参数RefreshPath指定。在CPFS数据流动对prefix配置自动更新时，会在用户侧创建事件总线，并创建源端OSS Bucket的prefix的事件规则。当源端OSS Bucket的prefix内发生对象修改后，会在EventBridge中产生OSS事件，由CPFS数据流动处理。</description></item>
        /// <item><description>配置自动更新（AutoRefresh）后，当源端存储数据发生变化时，变化的元数据会自动同步到CPFS文件系统，变化的数据会在用户访问文件时按需加载，或者启动数据流动任务加载数据。</description></item>
        /// <item><description>自动更新间隔（AutoRefreshInterval）指CPFS每隔该时间间隔，检查源端OSS Bucket该prefix内是否存在数据更新，如果有数据更新则启动自动更新任务。当OSS源端的对象修改事件频率超过CPFS数据流动处理能力时，自动更新任务会堆积，元数据更新会延迟，数据流动的状态为Misconfigured，您可以提升数据流动规格，或者降低OSS修改频率来解决。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持状态为<c>Running（正常）</c>状态的数据流动添加自动更新配置。</description></item>
        /// <item><description>一个数据流动最多可以添加5个自动更新配置。</description></item>
        /// <item><description>创建自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
        /// <item><description>自动更新依赖EventBridge收集源端OSS存储的对象修改事件。需要先<a href="https://help.aliyun.com/document_detail/182246.html">开通EventBridge服务</a>。<remarks>
        /// <para>CPFS在EventBridge创建的事件总线、事件规则带有<c>Create for cpfs auto refresh</c>的描述，事件总线、事件规则都不能修改和删除，否则自动更新无法正常工作。</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>自动更新的作用对象是prefix，由参数RefreshPath指定。在CPFS数据流动对prefix配置自动更新时，会在用户侧创建事件总线，并创建源端OSS Bucket的prefix的事件规则。当源端OSS Bucket的prefix内发生对象修改后，会在EventBridge中产生OSS事件，由CPFS数据流动处理。</description></item>
        /// <item><description>配置自动更新（AutoRefresh）后，当源端存储数据发生变化时，变化的元数据会自动同步到CPFS文件系统，变化的数据会在用户访问文件时按需加载，或者启动数据流动任务加载数据。</description></item>
        /// <item><description>自动更新间隔（AutoRefreshInterval）指CPFS每隔该时间间隔，检查源端OSS Bucket该prefix内是否存在数据更新，如果有数据更新则启动自动更新任务。当OSS源端的对象修改事件频率超过CPFS数据流动处理能力时，自动更新任务会堆积，元数据更新会延迟，数据流动的状态为Misconfigured，您可以提升数据流动规格，或者降低OSS修改频率来解决。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持状态为<c>Running（正常）</c>状态的数据流动添加自动更新配置。</description></item>
        /// <item><description>一个数据流动最多可以添加5个自动更新配置。</description></item>
        /// <item><description>创建自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
        /// <item><description>自动更新依赖EventBridge收集源端OSS存储的对象修改事件。需要先<a href="https://help.aliyun.com/document_detail/182246.html">开通EventBridge服务</a>。<remarks>
        /// <para>CPFS在EventBridge创建的事件总线、事件规则带有<c>Create for cpfs auto refresh</c>的描述，事件总线、事件规则都不能修改和删除，否则自动更新无法正常工作。</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>自动更新的作用对象是prefix，由参数RefreshPath指定。在CPFS数据流动对prefix配置自动更新时，会在用户侧创建事件总线，并创建源端OSS Bucket的prefix的事件规则。当源端OSS Bucket的prefix内发生对象修改后，会在EventBridge中产生OSS事件，由CPFS数据流动处理。</description></item>
        /// <item><description>配置自动更新（AutoRefresh）后，当源端存储数据发生变化时，变化的元数据会自动同步到CPFS文件系统，变化的数据会在用户访问文件时按需加载，或者启动数据流动任务加载数据。</description></item>
        /// <item><description>自动更新间隔（AutoRefreshInterval）指CPFS每隔该时间间隔，检查源端OSS Bucket该prefix内是否存在数据更新，如果有数据更新则启动自动更新任务。当OSS源端的对象修改事件频率超过CPFS数据流动处理能力时，自动更新任务会堆积，元数据更新会延迟，数据流动的状态为Misconfigured，您可以提升数据流动规格，或者降低OSS修改频率来解决。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持状态为<c>Running（正常）</c>状态的数据流动添加自动更新配置。</description></item>
        /// <item><description>一个数据流动最多可以添加5个自动更新配置。</description></item>
        /// <item><description>创建自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
        /// <item><description>自动更新依赖EventBridge收集源端OSS存储的对象修改事件。需要先<a href="https://help.aliyun.com/document_detail/182246.html">开通EventBridge服务</a>。<remarks>
        /// <para>CPFS在EventBridge创建的事件总线、事件规则带有<c>Create for cpfs auto refresh</c>的描述，事件总线、事件规则都不能修改和删除，否则自动更新无法正常工作。</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>自动更新的作用对象是prefix，由参数RefreshPath指定。在CPFS数据流动对prefix配置自动更新时，会在用户侧创建事件总线，并创建源端OSS Bucket的prefix的事件规则。当源端OSS Bucket的prefix内发生对象修改后，会在EventBridge中产生OSS事件，由CPFS数据流动处理。</description></item>
        /// <item><description>配置自动更新（AutoRefresh）后，当源端存储数据发生变化时，变化的元数据会自动同步到CPFS文件系统，变化的数据会在用户访问文件时按需加载，或者启动数据流动任务加载数据。</description></item>
        /// <item><description>自动更新间隔（AutoRefreshInterval）指CPFS每隔该时间间隔，检查源端OSS Bucket该prefix内是否存在数据更新，如果有数据更新则启动自动更新任务。当OSS源端的对象修改事件频率超过CPFS数据流动处理能力时，自动更新任务会堆积，元数据更新会延迟，数据流动的状态为Misconfigured，您可以提升数据流动规格，或者降低OSS修改频率来解决。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleChain))
            {
                query["RoleChain"] = request.RoleChain;
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleChain))
            {
                query["RoleChain"] = request.RoleChain;
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持取消<c>Running（正常）</c>、<c>Stopped（停止）</c>状态数据流动的自动更新配置。</description></item>
        /// <item><description>取消自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询取消自动更新任务的状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持取消<c>Running（正常）</c>、<c>Stopped（停止）</c>状态数据流动的自动更新配置。</description></item>
        /// <item><description>取消自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询取消自动更新任务的状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持取消<c>Running（正常）</c>、<c>Stopped（停止）</c>状态数据流动的自动更新配置。</description></item>
        /// <item><description>取消自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询取消自动更新任务的状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持取消<c>Running（正常）</c>、<c>Stopped（停止）</c>状态数据流动的自动更新配置。</description></item>
        /// <item><description>取消自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询取消自动更新任务的状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持在 CREATED和RUNNING状态下取消数据流动流式任务。</description></item>
        /// <item><description>数据流动流式任务是异步执行的，您可通过DescribeDataFlowSubTasks查询流式任务执行状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持在 CREATED和RUNNING状态下取消数据流动流式任务。</description></item>
        /// <item><description>数据流动流式任务是异步执行的，您可通过DescribeDataFlowSubTasks查询流式任务执行状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持在 CREATED和RUNNING状态下取消数据流动流式任务。</description></item>
        /// <item><description>数据流动流式任务是异步执行的，您可通过DescribeDataFlowSubTasks查询流式任务执行状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持在 CREATED和RUNNING状态下取消数据流动流式任务。</description></item>
        /// <item><description>数据流动流式任务是异步执行的，您可通过DescribeDataFlowSubTasks查询流式任务执行状态。</description></item>
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
        /// <para>Cancels a batch or streaming data flow task that is in the Pending or Executing state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Data flow tasks are supported only by CPFS 2.2.0 or later and CPFS for AI Computing 2.4.0 or later. The file system details page in the console displays the version information.</description></item>
        /// <item><description>A data flow task can be canceled only if it is in the <c>Pending or Executing</c> state.</description></item>
        /// <item><description>Canceling a data flow task typically takes 5 to 10 minutes. Call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status.</description></item>
        /// <item><description>You cannot cancel a streaming task if it has running streaming subtasks. Otherwise, the system returns an InvalidStatus.ResourceMismatch error.</description></item>
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
        /// <para>Cancels a batch or streaming data flow task that is in the Pending or Executing state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Data flow tasks are supported only by CPFS 2.2.0 or later and CPFS for AI Computing 2.4.0 or later. The file system details page in the console displays the version information.</description></item>
        /// <item><description>A data flow task can be canceled only if it is in the <c>Pending or Executing</c> state.</description></item>
        /// <item><description>Canceling a data flow task typically takes 5 to 10 minutes. Call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status.</description></item>
        /// <item><description>You cannot cancel a streaming task if it has running streaming subtasks. Otherwise, the system returns an InvalidStatus.ResourceMismatch error.</description></item>
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
        /// <para>Cancels a batch or streaming data flow task that is in the Pending or Executing state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Data flow tasks are supported only by CPFS 2.2.0 or later and CPFS for AI Computing 2.4.0 or later. The file system details page in the console displays the version information.</description></item>
        /// <item><description>A data flow task can be canceled only if it is in the <c>Pending or Executing</c> state.</description></item>
        /// <item><description>Canceling a data flow task typically takes 5 to 10 minutes. Call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status.</description></item>
        /// <item><description>You cannot cancel a streaming task if it has running streaming subtasks. Otherwise, the system returns an InvalidStatus.ResourceMismatch error.</description></item>
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
        /// <para>Cancels a batch or streaming data flow task that is in the Pending or Executing state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Data flow tasks are supported only by CPFS 2.2.0 or later and CPFS for AI Computing 2.4.0 or later. The file system details page in the console displays the version information.</description></item>
        /// <item><description>A data flow task can be canceled only if it is in the <c>Pending or Executing</c> state.</description></item>
        /// <item><description>Canceling a data flow task typically takes 5 to 10 minutes. Call the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation to query the task execution status.</description></item>
        /// <item><description>You cannot cancel a streaming task if it has running streaming subtasks. Otherwise, the system returns an InvalidStatus.ResourceMismatch error.</description></item>
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
        /// <para>仅CPFS智算版2.7.0及以上版本支持取消配额。</para>
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
        /// <para>仅CPFS智算版2.7.0及以上版本支持取消配额。</para>
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
        /// <para>仅CPFS智算版2.7.0及以上版本支持取消配额。</para>
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
        /// <para>仅CPFS智算版2.7.0及以上版本支持取消配额。</para>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>一个阿里云账号在单个地域内最多可以创建20个权限组。</description></item>
        /// <item><description>一个权限组最多支持添加300个规则。</description></item>
        /// <item><description>仅支持创建专有网络类型的权限组。</description></item>
        /// </list>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>一个阿里云账号在单个地域内最多可以创建20个权限组。</description></item>
        /// <item><description>一个权限组最多支持添加300个规则。</description></item>
        /// <item><description>仅支持创建专有网络类型的权限组。</description></item>
        /// </list>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>一个阿里云账号在单个地域内最多可以创建20个权限组。</description></item>
        /// <item><description>一个权限组最多支持添加300个规则。</description></item>
        /// <item><description>仅支持创建专有网络类型的权限组。</description></item>
        /// </list>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>一个阿里云账号在单个地域内最多可以创建20个权限组。</description></item>
        /// <item><description>一个权限组最多支持添加300个规则。</description></item>
        /// <item><description>仅支持创建专有网络类型的权限组。</description></item>
        /// </list>
        /// </description>
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
        /// <list type="bullet">
        /// <item><description>在使用CreateAccessPoint接口创建接入点时部分资源的生成是异步完成的。因此在执行CreateAccessPoint接口成功后，请先调用<a href="https://help.aliyun.com/document_detail/2712239.html">DescribeAccessPoints</a>或者<a href="https://help.aliyun.com/document_detail/2712240.html">DescribeAccessPoint</a>接口查询接入点状态，当接入点状态为<b>Active</b>后再执行挂载文件系统操作，否则可能会挂载失败。</description></item>
        /// <item><description>仅通用型NAS NFS协议文件系统支持该功能。</description></item>
        /// <item><description>如果开启RAM策略（EnabledRam），需要配置对应的RAM权限，具体请参考<a href="https://help.aliyun.com/document_detail/2545998.html">管理接入点</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>在使用CreateAccessPoint接口创建接入点时部分资源的生成是异步完成的。因此在执行CreateAccessPoint接口成功后，请先调用<a href="https://help.aliyun.com/document_detail/2712239.html">DescribeAccessPoints</a>或者<a href="https://help.aliyun.com/document_detail/2712240.html">DescribeAccessPoint</a>接口查询接入点状态，当接入点状态为<b>Active</b>后再执行挂载文件系统操作，否则可能会挂载失败。</description></item>
        /// <item><description>仅通用型NAS NFS协议文件系统支持该功能。</description></item>
        /// <item><description>如果开启RAM策略（EnabledRam），需要配置对应的RAM权限，具体请参考<a href="https://help.aliyun.com/document_detail/2545998.html">管理接入点</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>在使用CreateAccessPoint接口创建接入点时部分资源的生成是异步完成的。因此在执行CreateAccessPoint接口成功后，请先调用<a href="https://help.aliyun.com/document_detail/2712239.html">DescribeAccessPoints</a>或者<a href="https://help.aliyun.com/document_detail/2712240.html">DescribeAccessPoint</a>接口查询接入点状态，当接入点状态为<b>Active</b>后再执行挂载文件系统操作，否则可能会挂载失败。</description></item>
        /// <item><description>仅通用型NAS NFS协议文件系统支持该功能。</description></item>
        /// <item><description>如果开启RAM策略（EnabledRam），需要配置对应的RAM权限，具体请参考<a href="https://help.aliyun.com/document_detail/2545998.html">管理接入点</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>在使用CreateAccessPoint接口创建接入点时部分资源的生成是异步完成的。因此在执行CreateAccessPoint接口成功后，请先调用<a href="https://help.aliyun.com/document_detail/2712239.html">DescribeAccessPoints</a>或者<a href="https://help.aliyun.com/document_detail/2712240.html">DescribeAccessPoint</a>接口查询接入点状态，当接入点状态为<b>Active</b>后再执行挂载文件系统操作，否则可能会挂载失败。</description></item>
        /// <item><description>仅通用型NAS NFS协议文件系统支持该功能。</description></item>
        /// <item><description>如果开启RAM策略（EnabledRam），需要配置对应的RAM权限，具体请参考<a href="https://help.aliyun.com/document_detail/2545998.html">管理接入点</a>。</description></item>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>一个权限组最多支持添加300个规则。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>一个权限组最多支持添加300个规则。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>一个权限组最多支持添加300个规则。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>一个权限组最多支持添加300个规则。</para>
        /// </description>
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
        /// <list type="bullet">
        /// <item><description>本接口适用于以下产品：<table>
        /// <thead>
        /// <tr>
        /// <th>产品</th>
        /// <th>文件系统ID格式</th>
        /// <th>支持数据流动的最低版本</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><b>CPFS通用版</b></td>
        /// <td>以 <c>cpfs-</c> 开头，例如 cpfs-125487****</td>
        /// <td>2.2.0 及以上</td>
        /// </tr>
        /// <tr>
        /// <td><b>CPFS智算版</b></td>
        /// <td>以 <c>bmcpfs-</c> 开头，例如 bmcpfs-0015****</td>
        /// <td>2.4.0 及以上</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>：CPFS通用版和CPFS智算版共用同一套API，但在参数取值和功能支持上有所区别。请根据您使用的产品类型参考相应章节。</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>基础操作<list type="bullet">
        /// <item><description>CPFS通用版、CPFS智算版文件系统状态为运行中时，才能创建数据流动。</description></item>
        /// <item><description>一个CPFS通用版或CPFS智算版文件系统最多允许创建 <b>10 个</b>数据流动。</description></item>
        /// <item><description>创建数据流动一般耗时 2～5 分钟，您可通过 <a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a> 检查数据流动创建是否完成。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>权限
        ///   创建数据流动时，文件存储CPFS会获取<c>AliyunServiceRoleForNasOssDataflow</c>和<c>AliyunServiceRoleForNasEventNotification</c>两个服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/185138.html">CPFS服务关联角色</a>。</description></item>
        /// <item><description>CPFS通用版使用说明
        ///    本章节适用于文件系统ID以 <c>cpfs-</c> 开头的CPFS通用版。<list type="bullet">
        /// <item><description>计费<list type="bullet">
        /// <item><description>创建数据流动将按照数据流动带宽计费。更多信息，请参见<a href="https://help.aliyun.com/document_detail/111858.html">CPFS通用版计费说明</a>。</description></item>
        /// <item><description>使用自动更新（AutoRefresh）时，需要通过EventBridge收集源端OSS存储的对象修改事件，事件将产生费用。更多信息，请参见<a href="https://help.aliyun.com/document_detail/163752.html">EventBridge计费说明</a>。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动规格<list type="bullet">
        /// <item><description>数据流动带宽（Throughput）支持600 MB/s、1200 MB/s和1500 MB/s三种规格。数据流动带宽是指该数据流动进行导入或导出数据时能达到的最大传输带宽。</description></item>
        /// <item><description>创建一个数据流动，会消耗1个文件存储CPFS通用版挂载点使用的vSwitch IP地址，请您确保该vSwitch IP资源充足。</description></item>
        /// <item><description>库存查询：当设置DryRun为true时，可校验创建该规格的数据流动的资源是否满足。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Fileset<list type="bullet">
        /// <item><description>数据流动的目的端是CPFS通用版文件系统中的Fileset。Fileset是CPFS通用版文件系统中一种新的目录树结构，是在父文件系统中的一个小型文件系统，拥有独立的inode空间和管理能力。</description></item>
        /// <item><description>创建数据流动时该Fileset必须已存在，且不能与其他Fileset嵌套。一个Fileset上只能创建一个数据流动，对应一个源端存储。</description></item>
        /// <item><description>Fileset内的文件数量上限是100万，如果从OSS Bucket导入的文件数量超过上限，创建新文件会报错<c>no space</c>。<remarks>
        /// <para>如果Fileset中已存在数据，创建数据流动后，Fileset内的已有数据会被清空，替换为OSS端同步过来的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>自动更新<list type="bullet">
        /// <item><description>配置自动更新（AutoRefresh）后，当源端存储数据发生变化时，变化的元数据会自动同步到CPFS通用版文件系统，变化的数据会在用户访问文件时按需加载，或者启动数据流动任务加载数据。</description></item>
        /// <item><description>自动更新依赖EventBridge收集源端OSS存储的对象修改事件。需要先<a href="https://help.aliyun.com/document_detail/182246.html">开通EventBridge服务</a>。</description></item>
        /// <item><description>自动更新的作用范围是prefix，由参数RefreshPath指定。一个数据流动最多可配置5个自动更新目录。</description></item>
        /// <item><description>自动更新间隔（AutoRefreshInterval）指CPFS通用版设置的自动更新时间，检查源端OSS Bucket该prefix内是否存在数据更新，如果有数据更新则启动自动更新任务。当OSS源端的对象修改事件频率超过CPFS通用版数据流动处理能力时，自动更新任务会堆积，元数据更新会延迟，数据流动的状态为<c>Misconfigured</c>，您可以提升数据流动规格，或者降低OSS修改频率来解决。</description></item>
        /// <item><description>在文件存储CPFS通用版数据流动对prefix配置自动更新时，会在用户侧创建事件总线，并创建源端OSS Bucket的prefix的事件规则。当源端OSS Bucket的prefix内发生对象修改后，会在EventBridge中产生OSS事件，由CPFS通用版数据流动处理。<remarks>
        /// <para>文件存储CPFS通用版在EventBridge创建的事件总线、事件规则带有<c>Create for cpfs auto refresh</c>的描述，事件总线、事件规则都不能修改或删除，否则自动更新无法正常工作。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>源端存储<list type="bullet">
        /// <item><description>源端存储仅支持OSS。数据流动的源端存储（SourceStorage）必须是OSS Bucket。</description></item>
        /// <item><description>CPFS通用版数据流动支持加密和非加密两种方式访问OSS。选择加密（SSL）方式访问OSS时，需确认OSS Bucket的传输加密支持加密访问方式。</description></item>
        /// <item><description>如果多个CPFS通用版的数据流动、或者同一个文件存储CPFS通用版的多个数据流动的源端存储是同一个OSS Bucket，为了防止多个文件存储CPFS通用版向同一个源导出数据产生数据冲突，需要该OSS Bucket开启版本控制。</description></item>
        /// <item><description>不支持跨地域的OSS数据流动，OSS Bucket必须与CPFS通用版文件系统在同一个地域。<remarks>
        /// <para>创建数据流动前，您需要先给源端OSS Bucket设置标签（key: cpfs-dataflow, value: true），以便CPFS通用版数据流动访问该Bucket的数据。在数据流动的使用过程中，不能删除和修改该标签，否则CPFS通用版数据流动无法访问Bucket的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS智算版使用说明
        ///    本章节适用于文件系统ID以 <c>bmcpfs-</c> 开头的CPFS智算版。<list type="bullet">
        /// <item><description>源端存储<list type="bullet">
        /// <item><description>源端存储仅支持OSS。数据流动的源端存储（SourceStorage）必须是OSS Bucket。</description></item>
        /// <item><description>CPFS智算版数据流动支持加密和非加密两种方式访问OSS。选择加密（SSL）方式访问OSS时，需确认OSS Bucket的传输加密支持加密访问方式。</description></item>
        /// <item><description>如果多个CPFS智算版的数据流动、或者同一个CPFS智算版的多个数据流动的源端存储是同一个OSS Bucket，为了防止多个CPFS智算版向同一个源导出数据产生数据冲突，需要该OSS Bucket开启版本控制。</description></item>
        /// <item><description>不支持跨地域的OSS数据流动，OSS Bucket必须与CPFS智算版文件系统在同一个地域。</description></item>
        /// <item><description>CPFS智算版2.6.0及以上版本支持使用跨账号OSS进行数据流动的创建。</description></item>
        /// <item><description>只有在使用跨账号的OSS时，需要设置account id参数。</description></item>
        /// <item><description>使用跨账号的OSS时，需要先进行账号授权。具体授权请参考<a href="https://help.aliyun.com/document_detail/2713462.html">跨账号数据流动授权</a>。<remarks>
        /// <para>创建数据流动前，您需要先给源端OSS Bucket设置标签（key: cpfs-dataflow, value: true），以便CPFS智算版数据流动访问该Bucket的数据。在数据流动的使用过程中，不能删除和修改该标签，否则CPFS智算版数据流动无法访问Bucket的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动对文件系统的限制<list type="bullet">
        /// <item><description>在数据流动关联的文件系统路径中，不可对非空目录执行重命名操作，否则报错Permission Denied或者目录非空。</description></item>
        /// <item><description>目录、文件名中的特殊字符需要谨慎使用，支持大小写字母、数字、感叹号（！）、短划线（-）、下划线（_）、半角句号（.）、星号（*）和半角圆括号（()）。</description></item>
        /// <item><description>不支持超长路径，数据流动支持的路径最大长度是1023字符。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动导入限制<list type="bullet">
        /// <item><description>Symlink类型的文件导入到CPFS智算版后，会转变为包含数据的普通文件，并丢失Symlink信息。</description></item>
        /// <item><description>如果OSS Bucket存在多个版本，则只复制最新的版本。</description></item>
        /// <item><description>不支持长度大于255字节的文件名或子目录名。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动导出限制<list type="bullet">
        /// <item><description>Symlink类型的文件在同步到OSS后，不会同步Symlink所指向的文件，而是会变成一个普通的无数据空白对象。</description></item>
        /// <item><description>Hardlink类型的文件仅作为普通文件同步到OSS。</description></item>
        /// <item><description>Socket、Device、Pipe类型的文件导出到OSS Bucket时，会变成一个普通的无数据空白对象。</description></item>
        /// <item><description>不支持长度大于1023字符的目录路径。</description></item>
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
        /// <list type="bullet">
        /// <item><description>本接口适用于以下产品：<table>
        /// <thead>
        /// <tr>
        /// <th>产品</th>
        /// <th>文件系统ID格式</th>
        /// <th>支持数据流动的最低版本</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><b>CPFS通用版</b></td>
        /// <td>以 <c>cpfs-</c> 开头，例如 cpfs-125487****</td>
        /// <td>2.2.0 及以上</td>
        /// </tr>
        /// <tr>
        /// <td><b>CPFS智算版</b></td>
        /// <td>以 <c>bmcpfs-</c> 开头，例如 bmcpfs-0015****</td>
        /// <td>2.4.0 及以上</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>：CPFS通用版和CPFS智算版共用同一套API，但在参数取值和功能支持上有所区别。请根据您使用的产品类型参考相应章节。</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>基础操作<list type="bullet">
        /// <item><description>CPFS通用版、CPFS智算版文件系统状态为运行中时，才能创建数据流动。</description></item>
        /// <item><description>一个CPFS通用版或CPFS智算版文件系统最多允许创建 <b>10 个</b>数据流动。</description></item>
        /// <item><description>创建数据流动一般耗时 2～5 分钟，您可通过 <a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a> 检查数据流动创建是否完成。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>权限
        ///   创建数据流动时，文件存储CPFS会获取<c>AliyunServiceRoleForNasOssDataflow</c>和<c>AliyunServiceRoleForNasEventNotification</c>两个服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/185138.html">CPFS服务关联角色</a>。</description></item>
        /// <item><description>CPFS通用版使用说明
        ///    本章节适用于文件系统ID以 <c>cpfs-</c> 开头的CPFS通用版。<list type="bullet">
        /// <item><description>计费<list type="bullet">
        /// <item><description>创建数据流动将按照数据流动带宽计费。更多信息，请参见<a href="https://help.aliyun.com/document_detail/111858.html">CPFS通用版计费说明</a>。</description></item>
        /// <item><description>使用自动更新（AutoRefresh）时，需要通过EventBridge收集源端OSS存储的对象修改事件，事件将产生费用。更多信息，请参见<a href="https://help.aliyun.com/document_detail/163752.html">EventBridge计费说明</a>。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动规格<list type="bullet">
        /// <item><description>数据流动带宽（Throughput）支持600 MB/s、1200 MB/s和1500 MB/s三种规格。数据流动带宽是指该数据流动进行导入或导出数据时能达到的最大传输带宽。</description></item>
        /// <item><description>创建一个数据流动，会消耗1个文件存储CPFS通用版挂载点使用的vSwitch IP地址，请您确保该vSwitch IP资源充足。</description></item>
        /// <item><description>库存查询：当设置DryRun为true时，可校验创建该规格的数据流动的资源是否满足。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Fileset<list type="bullet">
        /// <item><description>数据流动的目的端是CPFS通用版文件系统中的Fileset。Fileset是CPFS通用版文件系统中一种新的目录树结构，是在父文件系统中的一个小型文件系统，拥有独立的inode空间和管理能力。</description></item>
        /// <item><description>创建数据流动时该Fileset必须已存在，且不能与其他Fileset嵌套。一个Fileset上只能创建一个数据流动，对应一个源端存储。</description></item>
        /// <item><description>Fileset内的文件数量上限是100万，如果从OSS Bucket导入的文件数量超过上限，创建新文件会报错<c>no space</c>。<remarks>
        /// <para>如果Fileset中已存在数据，创建数据流动后，Fileset内的已有数据会被清空，替换为OSS端同步过来的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>自动更新<list type="bullet">
        /// <item><description>配置自动更新（AutoRefresh）后，当源端存储数据发生变化时，变化的元数据会自动同步到CPFS通用版文件系统，变化的数据会在用户访问文件时按需加载，或者启动数据流动任务加载数据。</description></item>
        /// <item><description>自动更新依赖EventBridge收集源端OSS存储的对象修改事件。需要先<a href="https://help.aliyun.com/document_detail/182246.html">开通EventBridge服务</a>。</description></item>
        /// <item><description>自动更新的作用范围是prefix，由参数RefreshPath指定。一个数据流动最多可配置5个自动更新目录。</description></item>
        /// <item><description>自动更新间隔（AutoRefreshInterval）指CPFS通用版设置的自动更新时间，检查源端OSS Bucket该prefix内是否存在数据更新，如果有数据更新则启动自动更新任务。当OSS源端的对象修改事件频率超过CPFS通用版数据流动处理能力时，自动更新任务会堆积，元数据更新会延迟，数据流动的状态为<c>Misconfigured</c>，您可以提升数据流动规格，或者降低OSS修改频率来解决。</description></item>
        /// <item><description>在文件存储CPFS通用版数据流动对prefix配置自动更新时，会在用户侧创建事件总线，并创建源端OSS Bucket的prefix的事件规则。当源端OSS Bucket的prefix内发生对象修改后，会在EventBridge中产生OSS事件，由CPFS通用版数据流动处理。<remarks>
        /// <para>文件存储CPFS通用版在EventBridge创建的事件总线、事件规则带有<c>Create for cpfs auto refresh</c>的描述，事件总线、事件规则都不能修改或删除，否则自动更新无法正常工作。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>源端存储<list type="bullet">
        /// <item><description>源端存储仅支持OSS。数据流动的源端存储（SourceStorage）必须是OSS Bucket。</description></item>
        /// <item><description>CPFS通用版数据流动支持加密和非加密两种方式访问OSS。选择加密（SSL）方式访问OSS时，需确认OSS Bucket的传输加密支持加密访问方式。</description></item>
        /// <item><description>如果多个CPFS通用版的数据流动、或者同一个文件存储CPFS通用版的多个数据流动的源端存储是同一个OSS Bucket，为了防止多个文件存储CPFS通用版向同一个源导出数据产生数据冲突，需要该OSS Bucket开启版本控制。</description></item>
        /// <item><description>不支持跨地域的OSS数据流动，OSS Bucket必须与CPFS通用版文件系统在同一个地域。<remarks>
        /// <para>创建数据流动前，您需要先给源端OSS Bucket设置标签（key: cpfs-dataflow, value: true），以便CPFS通用版数据流动访问该Bucket的数据。在数据流动的使用过程中，不能删除和修改该标签，否则CPFS通用版数据流动无法访问Bucket的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS智算版使用说明
        ///    本章节适用于文件系统ID以 <c>bmcpfs-</c> 开头的CPFS智算版。<list type="bullet">
        /// <item><description>源端存储<list type="bullet">
        /// <item><description>源端存储仅支持OSS。数据流动的源端存储（SourceStorage）必须是OSS Bucket。</description></item>
        /// <item><description>CPFS智算版数据流动支持加密和非加密两种方式访问OSS。选择加密（SSL）方式访问OSS时，需确认OSS Bucket的传输加密支持加密访问方式。</description></item>
        /// <item><description>如果多个CPFS智算版的数据流动、或者同一个CPFS智算版的多个数据流动的源端存储是同一个OSS Bucket，为了防止多个CPFS智算版向同一个源导出数据产生数据冲突，需要该OSS Bucket开启版本控制。</description></item>
        /// <item><description>不支持跨地域的OSS数据流动，OSS Bucket必须与CPFS智算版文件系统在同一个地域。</description></item>
        /// <item><description>CPFS智算版2.6.0及以上版本支持使用跨账号OSS进行数据流动的创建。</description></item>
        /// <item><description>只有在使用跨账号的OSS时，需要设置account id参数。</description></item>
        /// <item><description>使用跨账号的OSS时，需要先进行账号授权。具体授权请参考<a href="https://help.aliyun.com/document_detail/2713462.html">跨账号数据流动授权</a>。<remarks>
        /// <para>创建数据流动前，您需要先给源端OSS Bucket设置标签（key: cpfs-dataflow, value: true），以便CPFS智算版数据流动访问该Bucket的数据。在数据流动的使用过程中，不能删除和修改该标签，否则CPFS智算版数据流动无法访问Bucket的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动对文件系统的限制<list type="bullet">
        /// <item><description>在数据流动关联的文件系统路径中，不可对非空目录执行重命名操作，否则报错Permission Denied或者目录非空。</description></item>
        /// <item><description>目录、文件名中的特殊字符需要谨慎使用，支持大小写字母、数字、感叹号（！）、短划线（-）、下划线（_）、半角句号（.）、星号（*）和半角圆括号（()）。</description></item>
        /// <item><description>不支持超长路径，数据流动支持的路径最大长度是1023字符。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动导入限制<list type="bullet">
        /// <item><description>Symlink类型的文件导入到CPFS智算版后，会转变为包含数据的普通文件，并丢失Symlink信息。</description></item>
        /// <item><description>如果OSS Bucket存在多个版本，则只复制最新的版本。</description></item>
        /// <item><description>不支持长度大于255字节的文件名或子目录名。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动导出限制<list type="bullet">
        /// <item><description>Symlink类型的文件在同步到OSS后，不会同步Symlink所指向的文件，而是会变成一个普通的无数据空白对象。</description></item>
        /// <item><description>Hardlink类型的文件仅作为普通文件同步到OSS。</description></item>
        /// <item><description>Socket、Device、Pipe类型的文件导出到OSS Bucket时，会变成一个普通的无数据空白对象。</description></item>
        /// <item><description>不支持长度大于1023字符的目录路径。</description></item>
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
        /// <list type="bullet">
        /// <item><description>本接口适用于以下产品：<table>
        /// <thead>
        /// <tr>
        /// <th>产品</th>
        /// <th>文件系统ID格式</th>
        /// <th>支持数据流动的最低版本</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><b>CPFS通用版</b></td>
        /// <td>以 <c>cpfs-</c> 开头，例如 cpfs-125487****</td>
        /// <td>2.2.0 及以上</td>
        /// </tr>
        /// <tr>
        /// <td><b>CPFS智算版</b></td>
        /// <td>以 <c>bmcpfs-</c> 开头，例如 bmcpfs-0015****</td>
        /// <td>2.4.0 及以上</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>：CPFS通用版和CPFS智算版共用同一套API，但在参数取值和功能支持上有所区别。请根据您使用的产品类型参考相应章节。</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>基础操作<list type="bullet">
        /// <item><description>CPFS通用版、CPFS智算版文件系统状态为运行中时，才能创建数据流动。</description></item>
        /// <item><description>一个CPFS通用版或CPFS智算版文件系统最多允许创建 <b>10 个</b>数据流动。</description></item>
        /// <item><description>创建数据流动一般耗时 2～5 分钟，您可通过 <a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a> 检查数据流动创建是否完成。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>权限
        ///   创建数据流动时，文件存储CPFS会获取<c>AliyunServiceRoleForNasOssDataflow</c>和<c>AliyunServiceRoleForNasEventNotification</c>两个服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/185138.html">CPFS服务关联角色</a>。</description></item>
        /// <item><description>CPFS通用版使用说明
        ///    本章节适用于文件系统ID以 <c>cpfs-</c> 开头的CPFS通用版。<list type="bullet">
        /// <item><description>计费<list type="bullet">
        /// <item><description>创建数据流动将按照数据流动带宽计费。更多信息，请参见<a href="https://help.aliyun.com/document_detail/111858.html">CPFS通用版计费说明</a>。</description></item>
        /// <item><description>使用自动更新（AutoRefresh）时，需要通过EventBridge收集源端OSS存储的对象修改事件，事件将产生费用。更多信息，请参见<a href="https://help.aliyun.com/document_detail/163752.html">EventBridge计费说明</a>。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动规格<list type="bullet">
        /// <item><description>数据流动带宽（Throughput）支持600 MB/s、1200 MB/s和1500 MB/s三种规格。数据流动带宽是指该数据流动进行导入或导出数据时能达到的最大传输带宽。</description></item>
        /// <item><description>创建一个数据流动，会消耗1个文件存储CPFS通用版挂载点使用的vSwitch IP地址，请您确保该vSwitch IP资源充足。</description></item>
        /// <item><description>库存查询：当设置DryRun为true时，可校验创建该规格的数据流动的资源是否满足。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Fileset<list type="bullet">
        /// <item><description>数据流动的目的端是CPFS通用版文件系统中的Fileset。Fileset是CPFS通用版文件系统中一种新的目录树结构，是在父文件系统中的一个小型文件系统，拥有独立的inode空间和管理能力。</description></item>
        /// <item><description>创建数据流动时该Fileset必须已存在，且不能与其他Fileset嵌套。一个Fileset上只能创建一个数据流动，对应一个源端存储。</description></item>
        /// <item><description>Fileset内的文件数量上限是100万，如果从OSS Bucket导入的文件数量超过上限，创建新文件会报错<c>no space</c>。<remarks>
        /// <para>如果Fileset中已存在数据，创建数据流动后，Fileset内的已有数据会被清空，替换为OSS端同步过来的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>自动更新<list type="bullet">
        /// <item><description>配置自动更新（AutoRefresh）后，当源端存储数据发生变化时，变化的元数据会自动同步到CPFS通用版文件系统，变化的数据会在用户访问文件时按需加载，或者启动数据流动任务加载数据。</description></item>
        /// <item><description>自动更新依赖EventBridge收集源端OSS存储的对象修改事件。需要先<a href="https://help.aliyun.com/document_detail/182246.html">开通EventBridge服务</a>。</description></item>
        /// <item><description>自动更新的作用范围是prefix，由参数RefreshPath指定。一个数据流动最多可配置5个自动更新目录。</description></item>
        /// <item><description>自动更新间隔（AutoRefreshInterval）指CPFS通用版设置的自动更新时间，检查源端OSS Bucket该prefix内是否存在数据更新，如果有数据更新则启动自动更新任务。当OSS源端的对象修改事件频率超过CPFS通用版数据流动处理能力时，自动更新任务会堆积，元数据更新会延迟，数据流动的状态为<c>Misconfigured</c>，您可以提升数据流动规格，或者降低OSS修改频率来解决。</description></item>
        /// <item><description>在文件存储CPFS通用版数据流动对prefix配置自动更新时，会在用户侧创建事件总线，并创建源端OSS Bucket的prefix的事件规则。当源端OSS Bucket的prefix内发生对象修改后，会在EventBridge中产生OSS事件，由CPFS通用版数据流动处理。<remarks>
        /// <para>文件存储CPFS通用版在EventBridge创建的事件总线、事件规则带有<c>Create for cpfs auto refresh</c>的描述，事件总线、事件规则都不能修改或删除，否则自动更新无法正常工作。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>源端存储<list type="bullet">
        /// <item><description>源端存储仅支持OSS。数据流动的源端存储（SourceStorage）必须是OSS Bucket。</description></item>
        /// <item><description>CPFS通用版数据流动支持加密和非加密两种方式访问OSS。选择加密（SSL）方式访问OSS时，需确认OSS Bucket的传输加密支持加密访问方式。</description></item>
        /// <item><description>如果多个CPFS通用版的数据流动、或者同一个文件存储CPFS通用版的多个数据流动的源端存储是同一个OSS Bucket，为了防止多个文件存储CPFS通用版向同一个源导出数据产生数据冲突，需要该OSS Bucket开启版本控制。</description></item>
        /// <item><description>不支持跨地域的OSS数据流动，OSS Bucket必须与CPFS通用版文件系统在同一个地域。<remarks>
        /// <para>创建数据流动前，您需要先给源端OSS Bucket设置标签（key: cpfs-dataflow, value: true），以便CPFS通用版数据流动访问该Bucket的数据。在数据流动的使用过程中，不能删除和修改该标签，否则CPFS通用版数据流动无法访问Bucket的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS智算版使用说明
        ///    本章节适用于文件系统ID以 <c>bmcpfs-</c> 开头的CPFS智算版。<list type="bullet">
        /// <item><description>源端存储<list type="bullet">
        /// <item><description>源端存储仅支持OSS。数据流动的源端存储（SourceStorage）必须是OSS Bucket。</description></item>
        /// <item><description>CPFS智算版数据流动支持加密和非加密两种方式访问OSS。选择加密（SSL）方式访问OSS时，需确认OSS Bucket的传输加密支持加密访问方式。</description></item>
        /// <item><description>如果多个CPFS智算版的数据流动、或者同一个CPFS智算版的多个数据流动的源端存储是同一个OSS Bucket，为了防止多个CPFS智算版向同一个源导出数据产生数据冲突，需要该OSS Bucket开启版本控制。</description></item>
        /// <item><description>不支持跨地域的OSS数据流动，OSS Bucket必须与CPFS智算版文件系统在同一个地域。</description></item>
        /// <item><description>CPFS智算版2.6.0及以上版本支持使用跨账号OSS进行数据流动的创建。</description></item>
        /// <item><description>只有在使用跨账号的OSS时，需要设置account id参数。</description></item>
        /// <item><description>使用跨账号的OSS时，需要先进行账号授权。具体授权请参考<a href="https://help.aliyun.com/document_detail/2713462.html">跨账号数据流动授权</a>。<remarks>
        /// <para>创建数据流动前，您需要先给源端OSS Bucket设置标签（key: cpfs-dataflow, value: true），以便CPFS智算版数据流动访问该Bucket的数据。在数据流动的使用过程中，不能删除和修改该标签，否则CPFS智算版数据流动无法访问Bucket的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动对文件系统的限制<list type="bullet">
        /// <item><description>在数据流动关联的文件系统路径中，不可对非空目录执行重命名操作，否则报错Permission Denied或者目录非空。</description></item>
        /// <item><description>目录、文件名中的特殊字符需要谨慎使用，支持大小写字母、数字、感叹号（！）、短划线（-）、下划线（_）、半角句号（.）、星号（*）和半角圆括号（()）。</description></item>
        /// <item><description>不支持超长路径，数据流动支持的路径最大长度是1023字符。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动导入限制<list type="bullet">
        /// <item><description>Symlink类型的文件导入到CPFS智算版后，会转变为包含数据的普通文件，并丢失Symlink信息。</description></item>
        /// <item><description>如果OSS Bucket存在多个版本，则只复制最新的版本。</description></item>
        /// <item><description>不支持长度大于255字节的文件名或子目录名。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动导出限制<list type="bullet">
        /// <item><description>Symlink类型的文件在同步到OSS后，不会同步Symlink所指向的文件，而是会变成一个普通的无数据空白对象。</description></item>
        /// <item><description>Hardlink类型的文件仅作为普通文件同步到OSS。</description></item>
        /// <item><description>Socket、Device、Pipe类型的文件导出到OSS Bucket时，会变成一个普通的无数据空白对象。</description></item>
        /// <item><description>不支持长度大于1023字符的目录路径。</description></item>
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
        /// <list type="bullet">
        /// <item><description>本接口适用于以下产品：<table>
        /// <thead>
        /// <tr>
        /// <th>产品</th>
        /// <th>文件系统ID格式</th>
        /// <th>支持数据流动的最低版本</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><b>CPFS通用版</b></td>
        /// <td>以 <c>cpfs-</c> 开头，例如 cpfs-125487****</td>
        /// <td>2.2.0 及以上</td>
        /// </tr>
        /// <tr>
        /// <td><b>CPFS智算版</b></td>
        /// <td>以 <c>bmcpfs-</c> 开头，例如 bmcpfs-0015****</td>
        /// <td>2.4.0 及以上</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>：CPFS通用版和CPFS智算版共用同一套API，但在参数取值和功能支持上有所区别。请根据您使用的产品类型参考相应章节。</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>基础操作<list type="bullet">
        /// <item><description>CPFS通用版、CPFS智算版文件系统状态为运行中时，才能创建数据流动。</description></item>
        /// <item><description>一个CPFS通用版或CPFS智算版文件系统最多允许创建 <b>10 个</b>数据流动。</description></item>
        /// <item><description>创建数据流动一般耗时 2～5 分钟，您可通过 <a href="https://help.aliyun.com/document_detail/336901.html">DescribeDataFlows</a> 检查数据流动创建是否完成。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>权限
        ///   创建数据流动时，文件存储CPFS会获取<c>AliyunServiceRoleForNasOssDataflow</c>和<c>AliyunServiceRoleForNasEventNotification</c>两个服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/185138.html">CPFS服务关联角色</a>。</description></item>
        /// <item><description>CPFS通用版使用说明
        ///    本章节适用于文件系统ID以 <c>cpfs-</c> 开头的CPFS通用版。<list type="bullet">
        /// <item><description>计费<list type="bullet">
        /// <item><description>创建数据流动将按照数据流动带宽计费。更多信息，请参见<a href="https://help.aliyun.com/document_detail/111858.html">CPFS通用版计费说明</a>。</description></item>
        /// <item><description>使用自动更新（AutoRefresh）时，需要通过EventBridge收集源端OSS存储的对象修改事件，事件将产生费用。更多信息，请参见<a href="https://help.aliyun.com/document_detail/163752.html">EventBridge计费说明</a>。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动规格<list type="bullet">
        /// <item><description>数据流动带宽（Throughput）支持600 MB/s、1200 MB/s和1500 MB/s三种规格。数据流动带宽是指该数据流动进行导入或导出数据时能达到的最大传输带宽。</description></item>
        /// <item><description>创建一个数据流动，会消耗1个文件存储CPFS通用版挂载点使用的vSwitch IP地址，请您确保该vSwitch IP资源充足。</description></item>
        /// <item><description>库存查询：当设置DryRun为true时，可校验创建该规格的数据流动的资源是否满足。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Fileset<list type="bullet">
        /// <item><description>数据流动的目的端是CPFS通用版文件系统中的Fileset。Fileset是CPFS通用版文件系统中一种新的目录树结构，是在父文件系统中的一个小型文件系统，拥有独立的inode空间和管理能力。</description></item>
        /// <item><description>创建数据流动时该Fileset必须已存在，且不能与其他Fileset嵌套。一个Fileset上只能创建一个数据流动，对应一个源端存储。</description></item>
        /// <item><description>Fileset内的文件数量上限是100万，如果从OSS Bucket导入的文件数量超过上限，创建新文件会报错<c>no space</c>。<remarks>
        /// <para>如果Fileset中已存在数据，创建数据流动后，Fileset内的已有数据会被清空，替换为OSS端同步过来的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>自动更新<list type="bullet">
        /// <item><description>配置自动更新（AutoRefresh）后，当源端存储数据发生变化时，变化的元数据会自动同步到CPFS通用版文件系统，变化的数据会在用户访问文件时按需加载，或者启动数据流动任务加载数据。</description></item>
        /// <item><description>自动更新依赖EventBridge收集源端OSS存储的对象修改事件。需要先<a href="https://help.aliyun.com/document_detail/182246.html">开通EventBridge服务</a>。</description></item>
        /// <item><description>自动更新的作用范围是prefix，由参数RefreshPath指定。一个数据流动最多可配置5个自动更新目录。</description></item>
        /// <item><description>自动更新间隔（AutoRefreshInterval）指CPFS通用版设置的自动更新时间，检查源端OSS Bucket该prefix内是否存在数据更新，如果有数据更新则启动自动更新任务。当OSS源端的对象修改事件频率超过CPFS通用版数据流动处理能力时，自动更新任务会堆积，元数据更新会延迟，数据流动的状态为<c>Misconfigured</c>，您可以提升数据流动规格，或者降低OSS修改频率来解决。</description></item>
        /// <item><description>在文件存储CPFS通用版数据流动对prefix配置自动更新时，会在用户侧创建事件总线，并创建源端OSS Bucket的prefix的事件规则。当源端OSS Bucket的prefix内发生对象修改后，会在EventBridge中产生OSS事件，由CPFS通用版数据流动处理。<remarks>
        /// <para>文件存储CPFS通用版在EventBridge创建的事件总线、事件规则带有<c>Create for cpfs auto refresh</c>的描述，事件总线、事件规则都不能修改或删除，否则自动更新无法正常工作。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>源端存储<list type="bullet">
        /// <item><description>源端存储仅支持OSS。数据流动的源端存储（SourceStorage）必须是OSS Bucket。</description></item>
        /// <item><description>CPFS通用版数据流动支持加密和非加密两种方式访问OSS。选择加密（SSL）方式访问OSS时，需确认OSS Bucket的传输加密支持加密访问方式。</description></item>
        /// <item><description>如果多个CPFS通用版的数据流动、或者同一个文件存储CPFS通用版的多个数据流动的源端存储是同一个OSS Bucket，为了防止多个文件存储CPFS通用版向同一个源导出数据产生数据冲突，需要该OSS Bucket开启版本控制。</description></item>
        /// <item><description>不支持跨地域的OSS数据流动，OSS Bucket必须与CPFS通用版文件系统在同一个地域。<remarks>
        /// <para>创建数据流动前，您需要先给源端OSS Bucket设置标签（key: cpfs-dataflow, value: true），以便CPFS通用版数据流动访问该Bucket的数据。在数据流动的使用过程中，不能删除和修改该标签，否则CPFS通用版数据流动无法访问Bucket的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS智算版使用说明
        ///    本章节适用于文件系统ID以 <c>bmcpfs-</c> 开头的CPFS智算版。<list type="bullet">
        /// <item><description>源端存储<list type="bullet">
        /// <item><description>源端存储仅支持OSS。数据流动的源端存储（SourceStorage）必须是OSS Bucket。</description></item>
        /// <item><description>CPFS智算版数据流动支持加密和非加密两种方式访问OSS。选择加密（SSL）方式访问OSS时，需确认OSS Bucket的传输加密支持加密访问方式。</description></item>
        /// <item><description>如果多个CPFS智算版的数据流动、或者同一个CPFS智算版的多个数据流动的源端存储是同一个OSS Bucket，为了防止多个CPFS智算版向同一个源导出数据产生数据冲突，需要该OSS Bucket开启版本控制。</description></item>
        /// <item><description>不支持跨地域的OSS数据流动，OSS Bucket必须与CPFS智算版文件系统在同一个地域。</description></item>
        /// <item><description>CPFS智算版2.6.0及以上版本支持使用跨账号OSS进行数据流动的创建。</description></item>
        /// <item><description>只有在使用跨账号的OSS时，需要设置account id参数。</description></item>
        /// <item><description>使用跨账号的OSS时，需要先进行账号授权。具体授权请参考<a href="https://help.aliyun.com/document_detail/2713462.html">跨账号数据流动授权</a>。<remarks>
        /// <para>创建数据流动前，您需要先给源端OSS Bucket设置标签（key: cpfs-dataflow, value: true），以便CPFS智算版数据流动访问该Bucket的数据。在数据流动的使用过程中，不能删除和修改该标签，否则CPFS智算版数据流动无法访问Bucket的数据。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动对文件系统的限制<list type="bullet">
        /// <item><description>在数据流动关联的文件系统路径中，不可对非空目录执行重命名操作，否则报错Permission Denied或者目录非空。</description></item>
        /// <item><description>目录、文件名中的特殊字符需要谨慎使用，支持大小写字母、数字、感叹号（！）、短划线（-）、下划线（_）、半角句号（.）、星号（*）和半角圆括号（()）。</description></item>
        /// <item><description>不支持超长路径，数据流动支持的路径最大长度是1023字符。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动导入限制<list type="bullet">
        /// <item><description>Symlink类型的文件导入到CPFS智算版后，会转变为包含数据的普通文件，并丢失Symlink信息。</description></item>
        /// <item><description>如果OSS Bucket存在多个版本，则只复制最新的版本。</description></item>
        /// <item><description>不支持长度大于255字节的文件名或子目录名。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>数据流动导出限制<list type="bullet">
        /// <item><description>Symlink类型的文件在同步到OSS后，不会同步Symlink所指向的文件，而是会变成一个普通的无数据空白对象。</description></item>
        /// <item><description>Hardlink类型的文件仅作为普通文件同步到OSS。</description></item>
        /// <item><description>Socket、Device、Pipe类型的文件导出到OSS Bucket时，会变成一个普通的无数据空白对象。</description></item>
        /// <item><description>不支持长度大于1023字符的目录路径。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持状态为Executing（执行中）的数据流动流式任务创建子任务。</description></item>
        /// <item><description>数据流动流式任务是异步执行的，您可通过DescribeDataFlowSubTasks查询流式任务执行状态。</description></item>
        /// <item><description>当数据流动任务类型为流式任务时，运行中状态仅代表可以创建流式导入任务或流式导出任务（并不代表导入或导出任务运行中）。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持状态为Executing（执行中）的数据流动流式任务创建子任务。</description></item>
        /// <item><description>数据流动流式任务是异步执行的，您可通过DescribeDataFlowSubTasks查询流式任务执行状态。</description></item>
        /// <item><description>当数据流动任务类型为流式任务时，运行中状态仅代表可以创建流式导入任务或流式导出任务（并不代表导入或导出任务运行中）。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持状态为Executing（执行中）的数据流动流式任务创建子任务。</description></item>
        /// <item><description>数据流动流式任务是异步执行的，您可通过DescribeDataFlowSubTasks查询流式任务执行状态。</description></item>
        /// <item><description>当数据流动任务类型为流式任务时，运行中状态仅代表可以创建流式导入任务或流式导出任务（并不代表导入或导出任务运行中）。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持状态为Executing（执行中）的数据流动流式任务创建子任务。</description></item>
        /// <item><description>数据流动流式任务是异步执行的，您可通过DescribeDataFlowSubTasks查询流式任务执行状态。</description></item>
        /// <item><description>当数据流动任务类型为流式任务时，运行中状态仅代表可以创建流式导入任务或流式导出任务（并不代表导入或导出任务运行中）。</description></item>
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
        /// <para>Create a data flow task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>CPFS usage notes<list type="bullet">
        /// <item><description>Data flow is supported only on CPFS 2.2.0 and later. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Data flow tasks execute asynchronously. You can query the task status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation. Task duration depends on the amount of data. For large datasets, split the workload into multiple tasks.</description></item>
        /// <item><description>You can create data flow tasks only on a data flow that is in the Running state.</description></item>
        /// <item><description>Manually running a data flow task pauses the corresponding automatic data update task.</description></item>
        /// <item><description>When you create an export task, ensure that the absolute path of each file to be exported from CPFS does not exceed 1,023 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS AI-Computing Edition usage notes<list type="bullet">
        /// <item><description>Data flow is supported only on CPFS AI-Computing Edition 2.4.0 and later. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Data flow tasks execute asynchronously. You can query the task status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation. Task duration depends on the amount of data. For large datasets, split the workload into multiple tasks.</description></item>
        /// <item><description>You can create data flow tasks only on a data flow that is in the Running state.</description></item>
        /// <item><description>When you create an export task, ensure that the absolute path of each file to be exported from CPFS AI-Computing Edition does not exceed 1,023 characters.</description></item>
        /// <item><description>CPFS AI-Computing Edition supports two task types: batch tasks and streaming tasks. For more information, see <a href="https://help.aliyun.com/document_detail/2845429.html">Task types</a>.</description></item>
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
        /// <para>Create a data flow task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>CPFS usage notes<list type="bullet">
        /// <item><description>Data flow is supported only on CPFS 2.2.0 and later. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Data flow tasks execute asynchronously. You can query the task status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation. Task duration depends on the amount of data. For large datasets, split the workload into multiple tasks.</description></item>
        /// <item><description>You can create data flow tasks only on a data flow that is in the Running state.</description></item>
        /// <item><description>Manually running a data flow task pauses the corresponding automatic data update task.</description></item>
        /// <item><description>When you create an export task, ensure that the absolute path of each file to be exported from CPFS does not exceed 1,023 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS AI-Computing Edition usage notes<list type="bullet">
        /// <item><description>Data flow is supported only on CPFS AI-Computing Edition 2.4.0 and later. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Data flow tasks execute asynchronously. You can query the task status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation. Task duration depends on the amount of data. For large datasets, split the workload into multiple tasks.</description></item>
        /// <item><description>You can create data flow tasks only on a data flow that is in the Running state.</description></item>
        /// <item><description>When you create an export task, ensure that the absolute path of each file to be exported from CPFS AI-Computing Edition does not exceed 1,023 characters.</description></item>
        /// <item><description>CPFS AI-Computing Edition supports two task types: batch tasks and streaming tasks. For more information, see <a href="https://help.aliyun.com/document_detail/2845429.html">Task types</a>.</description></item>
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
        /// <para>Create a data flow task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>CPFS usage notes<list type="bullet">
        /// <item><description>Data flow is supported only on CPFS 2.2.0 and later. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Data flow tasks execute asynchronously. You can query the task status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation. Task duration depends on the amount of data. For large datasets, split the workload into multiple tasks.</description></item>
        /// <item><description>You can create data flow tasks only on a data flow that is in the Running state.</description></item>
        /// <item><description>Manually running a data flow task pauses the corresponding automatic data update task.</description></item>
        /// <item><description>When you create an export task, ensure that the absolute path of each file to be exported from CPFS does not exceed 1,023 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS AI-Computing Edition usage notes<list type="bullet">
        /// <item><description>Data flow is supported only on CPFS AI-Computing Edition 2.4.0 and later. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Data flow tasks execute asynchronously. You can query the task status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation. Task duration depends on the amount of data. For large datasets, split the workload into multiple tasks.</description></item>
        /// <item><description>You can create data flow tasks only on a data flow that is in the Running state.</description></item>
        /// <item><description>When you create an export task, ensure that the absolute path of each file to be exported from CPFS AI-Computing Edition does not exceed 1,023 characters.</description></item>
        /// <item><description>CPFS AI-Computing Edition supports two task types: batch tasks and streaming tasks. For more information, see <a href="https://help.aliyun.com/document_detail/2845429.html">Task types</a>.</description></item>
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
        /// <para>Create a data flow task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>CPFS usage notes<list type="bullet">
        /// <item><description>Data flow is supported only on CPFS 2.2.0 and later. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Data flow tasks execute asynchronously. You can query the task status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation. Task duration depends on the amount of data. For large datasets, split the workload into multiple tasks.</description></item>
        /// <item><description>You can create data flow tasks only on a data flow that is in the Running state.</description></item>
        /// <item><description>Manually running a data flow task pauses the corresponding automatic data update task.</description></item>
        /// <item><description>When you create an export task, ensure that the absolute path of each file to be exported from CPFS does not exceed 1,023 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS AI-Computing Edition usage notes<list type="bullet">
        /// <item><description>Data flow is supported only on CPFS AI-Computing Edition 2.4.0 and later. You can view the version information on the file system details page in the console.</description></item>
        /// <item><description>Data flow tasks execute asynchronously. You can query the task status by calling the <a href="https://help.aliyun.com/document_detail/2402275.html">DescribeDataFlowTasks</a> operation. Task duration depends on the amount of data. For large datasets, split the workload into multiple tasks.</description></item>
        /// <item><description>You can create data flow tasks only on a data flow that is in the Running state.</description></item>
        /// <item><description>When you create an export task, ensure that the absolute path of each file to be exported from CPFS AI-Computing Edition does not exceed 1,023 characters.</description></item>
        /// <item><description>CPFS AI-Computing Edition supports two task types: batch tasks and streaming tasks. For more information, see <a href="https://help.aliyun.com/document_detail/2845429.html">Task types</a>.</description></item>
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
        /// <list type="bullet">
        /// <item><description>请确保在使用该接口前，已充分了解NAS产品的计费说明和价格。更多信息，请参见<a href="https://help.aliyun.com/document_detail/178365.html">计费说明</a>和<a href="https://www.aliyun.com/price/product?#/nas/detail">价格</a>。</description></item>
        /// <item><description>创建文件系统实例需要通过实名认证。具体操作，请参见<a href="https://help.aliyun.com/document_detail/48263.html">账号实名认证</a>。</description></item>
        /// <item><description>调用此接口将自动创建操作所需的NAS服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/208530.html">管理NAS服务关联角色</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>请确保在使用该接口前，已充分了解NAS产品的计费说明和价格。更多信息，请参见<a href="https://help.aliyun.com/document_detail/178365.html">计费说明</a>和<a href="https://www.aliyun.com/price/product?#/nas/detail">价格</a>。</description></item>
        /// <item><description>创建文件系统实例需要通过实名认证。具体操作，请参见<a href="https://help.aliyun.com/document_detail/48263.html">账号实名认证</a>。</description></item>
        /// <item><description>调用此接口将自动创建操作所需的NAS服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/208530.html">管理NAS服务关联角色</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>请确保在使用该接口前，已充分了解NAS产品的计费说明和价格。更多信息，请参见<a href="https://help.aliyun.com/document_detail/178365.html">计费说明</a>和<a href="https://www.aliyun.com/price/product?#/nas/detail">价格</a>。</description></item>
        /// <item><description>创建文件系统实例需要通过实名认证。具体操作，请参见<a href="https://help.aliyun.com/document_detail/48263.html">账号实名认证</a>。</description></item>
        /// <item><description>调用此接口将自动创建操作所需的NAS服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/208530.html">管理NAS服务关联角色</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>请确保在使用该接口前，已充分了解NAS产品的计费说明和价格。更多信息，请参见<a href="https://help.aliyun.com/document_detail/178365.html">计费说明</a>和<a href="https://www.aliyun.com/price/product?#/nas/detail">价格</a>。</description></item>
        /// <item><description>创建文件系统实例需要通过实名认证。具体操作，请参见<a href="https://help.aliyun.com/document_detail/48263.html">账号实名认证</a>。</description></item>
        /// <item><description>调用此接口将自动创建操作所需的NAS服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/208530.html">管理NAS服务关联角色</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>CPFS使用说明<list type="bullet">
        /// <item><description>仅支持CPFS 2.2.0及以上版本创建Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>单个CPFS文件系统最多支持创建10个Fileset。</description></item>
        /// <item><description>父目录必须是已存在的目录。</description></item>
        /// <item><description>Fileset路径支持的最大深度为8层，根目录/为0层。例如，Fileset路径为/test/aaa/ccc/，则表示路径深度为3层。</description></item>
        /// <item><description>不支持Fileset中嵌套Fileset。即当父目录已指定为Fileset，其子目录不支持指定为Fileset。</description></item>
        /// <item><description>Fileset最多支持100万个文件，如果文件数量超过此上限，添加新文件会返回<c>no space</c>错误信息。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS智算版使用说明<list type="bullet">
        /// <item><description>仅支持CPFS智算版 2.7.0及以上版本创建Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>单个CPFS文件系统最多支持创建500个Fileset。</description></item>
        /// <item><description>Fileset路径必须为新路径，不能为已存在路径，Fileset 路径不支持重命名，不支持路径为软链接。</description></item>
        /// <item><description>Fileset路径支持的最大深度为8层，根目录/为0层。例如，Fileset路径为/test/aaa/ccc/，则表示路径深度为3层。</description></item>
        /// <item><description>Fileset路径为多层目录时，父目录必须是已存在的目录。</description></item>
        /// <item><description>不支持在 Fileset 中嵌套 Fileset，即当父目录已指定为Fileset，其子目录不支持指定为Fileset。一个 Fileset 路径只支持一个配额。</description></item>
        /// <item><description>Fileset容量配额，最小起步10 GiB，扩容单位为1 GiB。</description></item>
        /// <item><description>Fileset最多支持100亿个文件或目录，最小起步10000，扩容单位为1。</description></item>
        /// <item><description>修改目录配额时，设置的配额容量或文件数必须高于已使用容量或文件数。</description></item>
        /// <item><description>配额的统计有15分钟的延迟，当前的实际使用量15分钟之后才会生效。</description></item>
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
        /// <list type="bullet">
        /// <item><description>CPFS使用说明<list type="bullet">
        /// <item><description>仅支持CPFS 2.2.0及以上版本创建Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>单个CPFS文件系统最多支持创建10个Fileset。</description></item>
        /// <item><description>父目录必须是已存在的目录。</description></item>
        /// <item><description>Fileset路径支持的最大深度为8层，根目录/为0层。例如，Fileset路径为/test/aaa/ccc/，则表示路径深度为3层。</description></item>
        /// <item><description>不支持Fileset中嵌套Fileset。即当父目录已指定为Fileset，其子目录不支持指定为Fileset。</description></item>
        /// <item><description>Fileset最多支持100万个文件，如果文件数量超过此上限，添加新文件会返回<c>no space</c>错误信息。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS智算版使用说明<list type="bullet">
        /// <item><description>仅支持CPFS智算版 2.7.0及以上版本创建Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>单个CPFS文件系统最多支持创建500个Fileset。</description></item>
        /// <item><description>Fileset路径必须为新路径，不能为已存在路径，Fileset 路径不支持重命名，不支持路径为软链接。</description></item>
        /// <item><description>Fileset路径支持的最大深度为8层，根目录/为0层。例如，Fileset路径为/test/aaa/ccc/，则表示路径深度为3层。</description></item>
        /// <item><description>Fileset路径为多层目录时，父目录必须是已存在的目录。</description></item>
        /// <item><description>不支持在 Fileset 中嵌套 Fileset，即当父目录已指定为Fileset，其子目录不支持指定为Fileset。一个 Fileset 路径只支持一个配额。</description></item>
        /// <item><description>Fileset容量配额，最小起步10 GiB，扩容单位为1 GiB。</description></item>
        /// <item><description>Fileset最多支持100亿个文件或目录，最小起步10000，扩容单位为1。</description></item>
        /// <item><description>修改目录配额时，设置的配额容量或文件数必须高于已使用容量或文件数。</description></item>
        /// <item><description>配额的统计有15分钟的延迟，当前的实际使用量15分钟之后才会生效。</description></item>
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
        /// <list type="bullet">
        /// <item><description>CPFS使用说明<list type="bullet">
        /// <item><description>仅支持CPFS 2.2.0及以上版本创建Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>单个CPFS文件系统最多支持创建10个Fileset。</description></item>
        /// <item><description>父目录必须是已存在的目录。</description></item>
        /// <item><description>Fileset路径支持的最大深度为8层，根目录/为0层。例如，Fileset路径为/test/aaa/ccc/，则表示路径深度为3层。</description></item>
        /// <item><description>不支持Fileset中嵌套Fileset。即当父目录已指定为Fileset，其子目录不支持指定为Fileset。</description></item>
        /// <item><description>Fileset最多支持100万个文件，如果文件数量超过此上限，添加新文件会返回<c>no space</c>错误信息。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS智算版使用说明<list type="bullet">
        /// <item><description>仅支持CPFS智算版 2.7.0及以上版本创建Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>单个CPFS文件系统最多支持创建500个Fileset。</description></item>
        /// <item><description>Fileset路径必须为新路径，不能为已存在路径，Fileset 路径不支持重命名，不支持路径为软链接。</description></item>
        /// <item><description>Fileset路径支持的最大深度为8层，根目录/为0层。例如，Fileset路径为/test/aaa/ccc/，则表示路径深度为3层。</description></item>
        /// <item><description>Fileset路径为多层目录时，父目录必须是已存在的目录。</description></item>
        /// <item><description>不支持在 Fileset 中嵌套 Fileset，即当父目录已指定为Fileset，其子目录不支持指定为Fileset。一个 Fileset 路径只支持一个配额。</description></item>
        /// <item><description>Fileset容量配额，最小起步10 GiB，扩容单位为1 GiB。</description></item>
        /// <item><description>Fileset最多支持100亿个文件或目录，最小起步10000，扩容单位为1。</description></item>
        /// <item><description>修改目录配额时，设置的配额容量或文件数必须高于已使用容量或文件数。</description></item>
        /// <item><description>配额的统计有15分钟的延迟，当前的实际使用量15分钟之后才会生效。</description></item>
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
        /// <list type="bullet">
        /// <item><description>CPFS使用说明<list type="bullet">
        /// <item><description>仅支持CPFS 2.2.0及以上版本创建Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>单个CPFS文件系统最多支持创建10个Fileset。</description></item>
        /// <item><description>父目录必须是已存在的目录。</description></item>
        /// <item><description>Fileset路径支持的最大深度为8层，根目录/为0层。例如，Fileset路径为/test/aaa/ccc/，则表示路径深度为3层。</description></item>
        /// <item><description>不支持Fileset中嵌套Fileset。即当父目录已指定为Fileset，其子目录不支持指定为Fileset。</description></item>
        /// <item><description>Fileset最多支持100万个文件，如果文件数量超过此上限，添加新文件会返回<c>no space</c>错误信息。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS智算版使用说明<list type="bullet">
        /// <item><description>仅支持CPFS智算版 2.7.0及以上版本创建Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>单个CPFS文件系统最多支持创建500个Fileset。</description></item>
        /// <item><description>Fileset路径必须为新路径，不能为已存在路径，Fileset 路径不支持重命名，不支持路径为软链接。</description></item>
        /// <item><description>Fileset路径支持的最大深度为8层，根目录/为0层。例如，Fileset路径为/test/aaa/ccc/，则表示路径深度为3层。</description></item>
        /// <item><description>Fileset路径为多层目录时，父目录必须是已存在的目录。</description></item>
        /// <item><description>不支持在 Fileset 中嵌套 Fileset，即当父目录已指定为Fileset，其子目录不支持指定为Fileset。一个 Fileset 路径只支持一个配额。</description></item>
        /// <item><description>Fileset容量配额，最小起步10 GiB，扩容单位为1 GiB。</description></item>
        /// <item><description>Fileset最多支持100亿个文件或目录，最小起步10000，扩容单位为1。</description></item>
        /// <item><description>修改目录配额时，设置的配额容量或文件数必须高于已使用容量或文件数。</description></item>
        /// <item><description>配额的统计有15分钟的延迟，当前的实际使用量15分钟之后才会生效。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统和CPFS智算版支持创建生命周期管理策略。</description></item>
        /// <item><description>每个 CPFS 智算版文件系统最多创建 10 个 Auto 类型 和 100 个 OnDemand 类型的生命周期管理策略。</description></item>
        /// <item><description>每个地域可以创建 20 个通用型 NAS 的生命周期管理策略。</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyName))
            {
                query["LifecyclePolicyName"] = request.LifecyclePolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyType))
            {
                query["LifecyclePolicyType"] = request.LifecyclePolicyType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrieveRules))
            {
                query["RetrieveRules"] = request.RetrieveRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRules))
            {
                query["TransitRules"] = request.TransitRules;
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统和CPFS智算版支持创建生命周期管理策略。</description></item>
        /// <item><description>每个 CPFS 智算版文件系统最多创建 10 个 Auto 类型 和 100 个 OnDemand 类型的生命周期管理策略。</description></item>
        /// <item><description>每个地域可以创建 20 个通用型 NAS 的生命周期管理策略。</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyName))
            {
                query["LifecyclePolicyName"] = request.LifecyclePolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyType))
            {
                query["LifecyclePolicyType"] = request.LifecyclePolicyType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrieveRules))
            {
                query["RetrieveRules"] = request.RetrieveRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRules))
            {
                query["TransitRules"] = request.TransitRules;
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统和CPFS智算版支持创建生命周期管理策略。</description></item>
        /// <item><description>每个 CPFS 智算版文件系统最多创建 10 个 Auto 类型 和 100 个 OnDemand 类型的生命周期管理策略。</description></item>
        /// <item><description>每个地域可以创建 20 个通用型 NAS 的生命周期管理策略。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统和CPFS智算版支持创建生命周期管理策略。</description></item>
        /// <item><description>每个 CPFS 智算版文件系统最多创建 10 个 Auto 类型 和 100 个 OnDemand 类型的生命周期管理策略。</description></item>
        /// <item><description>每个地域可以创建 20 个通用型 NAS 的生命周期管理策略。</description></item>
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
        /// <list type="bullet">
        /// <item><description>在使用CreateMountTarget接口创建挂载点时部分资源的生成是异步完成的。因此在执行CreateMountTarget接口成功后，请先调用DescribeMountTargets接口查询挂载点状态，当挂载点状态为<b>Active</b>后再执行挂载文件系统操作，否则可能会挂载失败。</description></item>
        /// <item><description>调用此接口将自动创建操作所需的NAS服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/208530.html">管理NAS服务关联角色</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>在使用CreateMountTarget接口创建挂载点时部分资源的生成是异步完成的。因此在执行CreateMountTarget接口成功后，请先调用DescribeMountTargets接口查询挂载点状态，当挂载点状态为<b>Active</b>后再执行挂载文件系统操作，否则可能会挂载失败。</description></item>
        /// <item><description>调用此接口将自动创建操作所需的NAS服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/208530.html">管理NAS服务关联角色</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>在使用CreateMountTarget接口创建挂载点时部分资源的生成是异步完成的。因此在执行CreateMountTarget接口成功后，请先调用DescribeMountTargets接口查询挂载点状态，当挂载点状态为<b>Active</b>后再执行挂载文件系统操作，否则可能会挂载失败。</description></item>
        /// <item><description>调用此接口将自动创建操作所需的NAS服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/208530.html">管理NAS服务关联角色</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>在使用CreateMountTarget接口创建挂载点时部分资源的生成是异步完成的。因此在执行CreateMountTarget接口成功后，请先调用DescribeMountTargets接口查询挂载点状态，当挂载点状态为<b>Active</b>后再执行挂载文件系统操作，否则可能会挂载失败。</description></item>
        /// <item><description>调用此接口将自动创建操作所需的NAS服务关联角色。更多信息，请参见<a href="https://help.aliyun.com/document_detail/208530.html">管理NAS服务关联角色</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>该接口仅适用于CPFS文件系统。</para>
        /// </description></item>
        /// <item><description><para>前提条件</para>
        /// <para>已创建协议服务。</para>
        /// </description></item>
        /// <item><description><para>其它</para>
        /// <list type="bullet">
        /// <item><description>协议服务的导出VPC网段不可与文件系统VPC网段重叠。</description></item>
        /// <item><description>一个协议服务上的多个导出VPC之间网段不可重叠。</description></item>
        /// <item><description>同一个协议服务最多可以创建10个导出目录。</description></item>
        /// <item><description>创建协议服务导出目录会消耗指定vSwitch上的IP地址（最多消耗32个IP地址），请确保目标vSwitch IP资源充足。</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>该接口仅适用于CPFS文件系统。</para>
        /// </description></item>
        /// <item><description><para>前提条件</para>
        /// <para>已创建协议服务。</para>
        /// </description></item>
        /// <item><description><para>其它</para>
        /// <list type="bullet">
        /// <item><description>协议服务的导出VPC网段不可与文件系统VPC网段重叠。</description></item>
        /// <item><description>一个协议服务上的多个导出VPC之间网段不可重叠。</description></item>
        /// <item><description>同一个协议服务最多可以创建10个导出目录。</description></item>
        /// <item><description>创建协议服务导出目录会消耗指定vSwitch上的IP地址（最多消耗32个IP地址），请确保目标vSwitch IP资源充足。</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>该接口仅适用于CPFS文件系统。</para>
        /// </description></item>
        /// <item><description><para>前提条件</para>
        /// <para>已创建协议服务。</para>
        /// </description></item>
        /// <item><description><para>其它</para>
        /// <list type="bullet">
        /// <item><description>协议服务的导出VPC网段不可与文件系统VPC网段重叠。</description></item>
        /// <item><description>一个协议服务上的多个导出VPC之间网段不可重叠。</description></item>
        /// <item><description>同一个协议服务最多可以创建10个导出目录。</description></item>
        /// <item><description>创建协议服务导出目录会消耗指定vSwitch上的IP地址（最多消耗32个IP地址），请确保目标vSwitch IP资源充足。</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>该接口仅适用于CPFS文件系统。</para>
        /// </description></item>
        /// <item><description><para>前提条件</para>
        /// <para>已创建协议服务。</para>
        /// </description></item>
        /// <item><description><para>其它</para>
        /// <list type="bullet">
        /// <item><description>协议服务的导出VPC网段不可与文件系统VPC网段重叠。</description></item>
        /// <item><description>一个协议服务上的多个导出VPC之间网段不可重叠。</description></item>
        /// <item><description>同一个协议服务最多可以创建10个导出目录。</description></item>
        /// <item><description>创建协议服务导出目录会消耗指定vSwitch上的IP地址（最多消耗32个IP地址），请确保目标vSwitch IP资源充足。</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>该接口仅适用于CPFS文件系统。</para>
        /// </description></item>
        /// <item><description><para>仅CPFS 2.3.0及以上版本支持协议服务。您可以通过调用<a href="https://help.aliyun.com/document_detail/163314.html">DescribeFileSystems</a>接口查询目标文件系统的版本号。</para>
        /// </description></item>
        /// <item><description><para>协议服务规格
        /// 协议服务包括两种协议类型：通用型和缓存型。缓存型相比通用型，提供热点数据缓存能力。在命中缓存的情况下，缓存型协议服务的带宽可超过CPFS文件系统的带宽，达到协议服务设定的最大带宽值。</para>
        /// <list type="bullet">
        /// <item><description>通用型：为CPFS提供NFS协议访问能力和<a href="https://help.aliyun.com/document_detail/427175.html">目录级挂载点</a>，用户无需配置POSIX客户端管理集群。该功能免费。</description></item>
        /// <item><description>缓存型：在通用型基础上提供基于LRU策略的服务端内存缓存。当数据缓存于内存中时，CPFS可提供更高的内网带宽。缓存型协议服务分为缓存1型和缓存2型两种协议服务规格，差异点为内网带宽大小和内存缓存大小。<remarks>
        /// <para> 缓存型协议服务为收费服务，正在邀测。有关缓存型协议服务的付费方式，请参见<a href="https://help.aliyun.com/document_detail/111858.html">计费项</a>。如果您有任何反馈或疑问，欢迎加入钉钉用户群（钉钉群号：31045006299）与CPFS工程师进行交流讨论。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>协议类型
        /// 仅支持NFSv3协议。</para>
        /// </description></item>
        /// <item><description><para>其它</para>
        /// <list type="bullet">
        /// <item><description>一个CPFS文件系统只能创建一个协议服务。</description></item>
        /// <item><description>创建协议服务会消耗指定vSwitch上的IP地址（最多消耗32个IP地址），请确保目标vSwitch IP资源充足。</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>该接口仅适用于CPFS文件系统。</para>
        /// </description></item>
        /// <item><description><para>仅CPFS 2.3.0及以上版本支持协议服务。您可以通过调用<a href="https://help.aliyun.com/document_detail/163314.html">DescribeFileSystems</a>接口查询目标文件系统的版本号。</para>
        /// </description></item>
        /// <item><description><para>协议服务规格
        /// 协议服务包括两种协议类型：通用型和缓存型。缓存型相比通用型，提供热点数据缓存能力。在命中缓存的情况下，缓存型协议服务的带宽可超过CPFS文件系统的带宽，达到协议服务设定的最大带宽值。</para>
        /// <list type="bullet">
        /// <item><description>通用型：为CPFS提供NFS协议访问能力和<a href="https://help.aliyun.com/document_detail/427175.html">目录级挂载点</a>，用户无需配置POSIX客户端管理集群。该功能免费。</description></item>
        /// <item><description>缓存型：在通用型基础上提供基于LRU策略的服务端内存缓存。当数据缓存于内存中时，CPFS可提供更高的内网带宽。缓存型协议服务分为缓存1型和缓存2型两种协议服务规格，差异点为内网带宽大小和内存缓存大小。<remarks>
        /// <para> 缓存型协议服务为收费服务，正在邀测。有关缓存型协议服务的付费方式，请参见<a href="https://help.aliyun.com/document_detail/111858.html">计费项</a>。如果您有任何反馈或疑问，欢迎加入钉钉用户群（钉钉群号：31045006299）与CPFS工程师进行交流讨论。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>协议类型
        /// 仅支持NFSv3协议。</para>
        /// </description></item>
        /// <item><description><para>其它</para>
        /// <list type="bullet">
        /// <item><description>一个CPFS文件系统只能创建一个协议服务。</description></item>
        /// <item><description>创建协议服务会消耗指定vSwitch上的IP地址（最多消耗32个IP地址），请确保目标vSwitch IP资源充足。</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>该接口仅适用于CPFS文件系统。</para>
        /// </description></item>
        /// <item><description><para>仅CPFS 2.3.0及以上版本支持协议服务。您可以通过调用<a href="https://help.aliyun.com/document_detail/163314.html">DescribeFileSystems</a>接口查询目标文件系统的版本号。</para>
        /// </description></item>
        /// <item><description><para>协议服务规格
        /// 协议服务包括两种协议类型：通用型和缓存型。缓存型相比通用型，提供热点数据缓存能力。在命中缓存的情况下，缓存型协议服务的带宽可超过CPFS文件系统的带宽，达到协议服务设定的最大带宽值。</para>
        /// <list type="bullet">
        /// <item><description>通用型：为CPFS提供NFS协议访问能力和<a href="https://help.aliyun.com/document_detail/427175.html">目录级挂载点</a>，用户无需配置POSIX客户端管理集群。该功能免费。</description></item>
        /// <item><description>缓存型：在通用型基础上提供基于LRU策略的服务端内存缓存。当数据缓存于内存中时，CPFS可提供更高的内网带宽。缓存型协议服务分为缓存1型和缓存2型两种协议服务规格，差异点为内网带宽大小和内存缓存大小。<remarks>
        /// <para> 缓存型协议服务为收费服务，正在邀测。有关缓存型协议服务的付费方式，请参见<a href="https://help.aliyun.com/document_detail/111858.html">计费项</a>。如果您有任何反馈或疑问，欢迎加入钉钉用户群（钉钉群号：31045006299）与CPFS工程师进行交流讨论。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>协议类型
        /// 仅支持NFSv3协议。</para>
        /// </description></item>
        /// <item><description><para>其它</para>
        /// <list type="bullet">
        /// <item><description>一个CPFS文件系统只能创建一个协议服务。</description></item>
        /// <item><description>创建协议服务会消耗指定vSwitch上的IP地址（最多消耗32个IP地址），请确保目标vSwitch IP资源充足。</description></item>
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
        /// <list type="bullet">
        /// <item><description><para>该接口仅适用于CPFS文件系统。</para>
        /// </description></item>
        /// <item><description><para>仅CPFS 2.3.0及以上版本支持协议服务。您可以通过调用<a href="https://help.aliyun.com/document_detail/163314.html">DescribeFileSystems</a>接口查询目标文件系统的版本号。</para>
        /// </description></item>
        /// <item><description><para>协议服务规格
        /// 协议服务包括两种协议类型：通用型和缓存型。缓存型相比通用型，提供热点数据缓存能力。在命中缓存的情况下，缓存型协议服务的带宽可超过CPFS文件系统的带宽，达到协议服务设定的最大带宽值。</para>
        /// <list type="bullet">
        /// <item><description>通用型：为CPFS提供NFS协议访问能力和<a href="https://help.aliyun.com/document_detail/427175.html">目录级挂载点</a>，用户无需配置POSIX客户端管理集群。该功能免费。</description></item>
        /// <item><description>缓存型：在通用型基础上提供基于LRU策略的服务端内存缓存。当数据缓存于内存中时，CPFS可提供更高的内网带宽。缓存型协议服务分为缓存1型和缓存2型两种协议服务规格，差异点为内网带宽大小和内存缓存大小。<remarks>
        /// <para> 缓存型协议服务为收费服务，正在邀测。有关缓存型协议服务的付费方式，请参见<a href="https://help.aliyun.com/document_detail/111858.html">计费项</a>。如果您有任何反馈或疑问，欢迎加入钉钉用户群（钉钉群号：31045006299）与CPFS工程师进行交流讨论。</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>协议类型
        /// 仅支持NFSv3协议。</para>
        /// </description></item>
        /// <item><description><para>其它</para>
        /// <list type="bullet">
        /// <item><description>一个CPFS文件系统只能创建一个协议服务。</description></item>
        /// <item><description>创建协议服务会消耗指定vSwitch上的IP地址（最多消耗32个IP地址），请确保目标vSwitch IP资源充足。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统支持该功能。</description></item>
        /// <item><description>彻底删除目录时，目录中的内容会被递归清理。</description></item>
        /// <item><description>单个文件系统一次只能执行一个彻底删除任务。正在彻底删除文件或目录时，无法发起新的恢复或清理任务。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统支持该功能。</description></item>
        /// <item><description>彻底删除目录时，目录中的内容会被递归清理。</description></item>
        /// <item><description>单个文件系统一次只能执行一个彻底删除任务。正在彻底删除文件或目录时，无法发起新的恢复或清理任务。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统支持该功能。</description></item>
        /// <item><description>彻底删除目录时，目录中的内容会被递归清理。</description></item>
        /// <item><description>单个文件系统一次只能执行一个彻底删除任务。正在彻底删除文件或目录时，无法发起新的恢复或清理任务。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统支持该功能。</description></item>
        /// <item><description>彻底删除目录时，目录中的内容会被递归清理。</description></item>
        /// <item><description>单个文件系统一次只能执行一个彻底删除任务。正在彻底删除文件或目录时，无法发起新的恢复或清理任务。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统支持该功能。</description></item>
        /// <item><description>单个文件系统一次只能执行一个文件恢复或清理任务。正在恢复文件时，无法发起新的文件恢复或清理任务。</description></item>
        /// <item><description>单个恢复任务只能恢复一个文件或目录，恢复指定目录会递归恢复目录下的所有文件。</description></item>
        /// <item><description>文件被恢复后会进行数据整理，数据整理期间读请求性能稍有下降。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统支持该功能。</description></item>
        /// <item><description>单个文件系统一次只能执行一个文件恢复或清理任务。正在恢复文件时，无法发起新的文件恢复或清理任务。</description></item>
        /// <item><description>单个恢复任务只能恢复一个文件或目录，恢复指定目录会递归恢复目录下的所有文件。</description></item>
        /// <item><description>文件被恢复后会进行数据整理，数据整理期间读请求性能稍有下降。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统支持该功能。</description></item>
        /// <item><description>单个文件系统一次只能执行一个文件恢复或清理任务。正在恢复文件时，无法发起新的文件恢复或清理任务。</description></item>
        /// <item><description>单个恢复任务只能恢复一个文件或目录，恢复指定目录会递归恢复目录下的所有文件。</description></item>
        /// <item><description>文件被恢复后会进行数据整理，数据整理期间读请求性能稍有下降。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS文件系统支持该功能。</description></item>
        /// <item><description>单个文件系统一次只能执行一个文件恢复或清理任务。正在恢复文件时，无法发起新的文件恢复或清理任务。</description></item>
        /// <item><description>单个恢复任务只能恢复一个文件或目录，恢复指定目录会递归恢复目录下的所有文件。</description></item>
        /// <item><description>文件被恢复后会进行数据整理，数据整理期间读请求性能稍有下降。</description></item>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）不支持删除。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）不支持删除。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）不支持删除。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）不支持删除。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）中的规则不支持删除。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）中的规则不支持删除。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）中的规则不支持删除。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）中的规则不支持删除。</para>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0及以上版本、智算CPFS 2.4.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持删除<c>Running</c>、<c>Stopped</c>状态的数据流动。</description></item>
        /// <item><description>删除后，数据流动相关的资源会被释放，且无法恢复。如需数据流动，请您重新创建。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0及以上版本、智算CPFS 2.4.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持删除<c>Running</c>、<c>Stopped</c>状态的数据流动。</description></item>
        /// <item><description>删除后，数据流动相关的资源会被释放，且无法恢复。如需数据流动，请您重新创建。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0及以上版本、智算CPFS 2.4.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持删除<c>Running</c>、<c>Stopped</c>状态的数据流动。</description></item>
        /// <item><description>删除后，数据流动相关的资源会被释放，且无法恢复。如需数据流动，请您重新创建。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0及以上版本、智算CPFS 2.4.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持删除<c>Running</c>、<c>Stopped</c>状态的数据流动。</description></item>
        /// <item><description>删除后，数据流动相关的资源会被释放，且无法恢复。如需数据流动，请您重新创建。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅当文件系统的挂载点数目为0时，支持删除文件系统实例。</description></item>
        /// <item><description>当文件系统未创建生命周期策略时，支持删除文件系统实例。</description></item>
        /// <item><description>文件系统实例一旦删除，数据将不可恢复，请谨慎操作。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅当文件系统的挂载点数目为0时，支持删除文件系统实例。</description></item>
        /// <item><description>当文件系统未创建生命周期策略时，支持删除文件系统实例。</description></item>
        /// <item><description>文件系统实例一旦删除，数据将不可恢复，请谨慎操作。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅当文件系统的挂载点数目为0时，支持删除文件系统实例。</description></item>
        /// <item><description>当文件系统未创建生命周期策略时，支持删除文件系统实例。</description></item>
        /// <item><description>文件系统实例一旦删除，数据将不可恢复，请谨慎操作。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅当文件系统的挂载点数目为0时，支持删除文件系统实例。</description></item>
        /// <item><description>当文件系统未创建生命周期策略时，支持删除文件系统实例。</description></item>
        /// <item><description>文件系统实例一旦删除，数据将不可恢复，请谨慎操作。</description></item>
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
        /// <list type="bullet">
        /// <item><description>This operation is supported only for CPFS file systems of version 2.2.0 or later and CPFS for AI and HPC file systems of version 2.7.0 or later. Deleting a fileset permanently removes all data in the associated directory. Use this operation with caution.</description></item>
        /// <item><description>If deletion protection is enabled, you must disable it before you can delete the fileset.</description></item>
        /// <item><description>When you delete a fileset from a CPFS file system, the disk space is released immediately. When you delete a fileset from a CPFS for AI and HPC file system, the disk space is released gradually.</description></item>
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
        /// <list type="bullet">
        /// <item><description>This operation is supported only for CPFS file systems of version 2.2.0 or later and CPFS for AI and HPC file systems of version 2.7.0 or later. Deleting a fileset permanently removes all data in the associated directory. Use this operation with caution.</description></item>
        /// <item><description>If deletion protection is enabled, you must disable it before you can delete the fileset.</description></item>
        /// <item><description>When you delete a fileset from a CPFS file system, the disk space is released immediately. When you delete a fileset from a CPFS for AI and HPC file system, the disk space is released gradually.</description></item>
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
        /// <list type="bullet">
        /// <item><description>This operation is supported only for CPFS file systems of version 2.2.0 or later and CPFS for AI and HPC file systems of version 2.7.0 or later. Deleting a fileset permanently removes all data in the associated directory. Use this operation with caution.</description></item>
        /// <item><description>If deletion protection is enabled, you must disable it before you can delete the fileset.</description></item>
        /// <item><description>When you delete a fileset from a CPFS file system, the disk space is released immediately. When you delete a fileset from a CPFS for AI and HPC file system, the disk space is released gradually.</description></item>
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
        /// <list type="bullet">
        /// <item><description>This operation is supported only for CPFS file systems of version 2.2.0 or later and CPFS for AI and HPC file systems of version 2.7.0 or later. Deleting a fileset permanently removes all data in the associated directory. Use this operation with caution.</description></item>
        /// <item><description>If deletion protection is enabled, you must disable it before you can delete the fileset.</description></item>
        /// <item><description>When you delete a fileset from a CPFS file system, the disk space is released immediately. When you delete a fileset from a CPFS for AI and HPC file system, the disk space is released gradually.</description></item>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>说明</h1>
        /// <para>本接口只支持CPFS并行文件系统。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>说明</h1>
        /// <para>本接口只支持CPFS并行文件系统。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>说明</h1>
        /// <para>本接口只支持CPFS并行文件系统。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>说明</h1>
        /// <para>本接口只支持CPFS并行文件系统。</para>
        /// </description>
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
        /// <para>仅通用型NAS文件系统和CPFS智算版支持该功能。</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
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
        /// <para>仅通用型NAS文件系统和CPFS智算版支持该功能。</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
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
        /// <para>仅通用型NAS文件系统和CPFS智算版支持该功能。</para>
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
        /// <para>仅通用型NAS文件系统和CPFS智算版支持该功能。</para>
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
        /// <para>删除挂载点后，无法恢复，请谨慎操作。</para>
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
        /// <para>删除挂载点后，无法恢复，请谨慎操作。</para>
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
        /// <para>删除挂载点后，无法恢复，请谨慎操作。</para>
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
        /// <para>删除挂载点后，无法恢复，请谨慎操作。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>删除协议服务时，会同时删除协议服务中的导出目录。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>删除协议服务时，会同时删除协议服务中的导出目录。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>删除协议服务时，会同时删除协议服务中的导出目录。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>删除协议服务时，会同时删除协议服务中的导出目录。</description></item>
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
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
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
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
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
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
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
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
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
        /// <para>Queries a list of access points.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
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
        /// <para>Queries a list of access points.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
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
        /// <para>Queries a list of access points.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
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
        /// <para>Queries a list of access points.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
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
        /// <para>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</para>
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
        /// <para>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</para>
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
        /// <para>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</para>
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
        /// <para>仅CPFS智算版2.6.0 及以上版本支持。您可以在控制台文件系统详情页面查看版本信息。</para>
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
        /// <para>Retrieves data flow task details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Querying data flow tasks is supported only on CPFS 2.2.0 or later and CPFS AI Computing Edition 2.4.0 or later. You can find the version information on the file system details page in the console.</para>
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
        /// <para>Retrieves data flow task details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Querying data flow tasks is supported only on CPFS 2.2.0 or later and CPFS AI Computing Edition 2.4.0 or later. You can find the version information on the file system details page in the console.</para>
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
        /// <para>Retrieves data flow task details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Querying data flow tasks is supported only on CPFS 2.2.0 or later and CPFS AI Computing Edition 2.4.0 or later. You can find the version information on the file system details page in the console.</para>
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
        /// <para>Retrieves data flow task details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Querying data flow tasks is supported only on CPFS 2.2.0 or later and CPFS AI Computing Edition 2.4.0 or later. You can find the version information on the file system details page in the console.</para>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0及以上版本、CPFS智算版2.4.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>筛选键（Filters）中，FsetIds、DataFlowlds、SourceStorage、ThroughputList、Status需要做全字匹配，FileSystemPath、Description、SourceStoragePath支持模糊匹配。</description></item>
        /// <item><description>支持组合查询。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0及以上版本、CPFS智算版2.4.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>筛选键（Filters）中，FsetIds、DataFlowlds、SourceStorage、ThroughputList、Status需要做全字匹配，FileSystemPath、Description、SourceStoragePath支持模糊匹配。</description></item>
        /// <item><description>支持组合查询。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0及以上版本、CPFS智算版2.4.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>筛选键（Filters）中，FsetIds、DataFlowlds、SourceStorage、ThroughputList、Status需要做全字匹配，FileSystemPath、Description、SourceStoragePath支持模糊匹配。</description></item>
        /// <item><description>支持组合查询。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0及以上版本、CPFS智算版2.4.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>筛选键（Filters）中，FsetIds、DataFlowlds、SourceStorage、ThroughputList、Status需要做全字匹配，FileSystemPath、Description、SourceStoragePath支持模糊匹配。</description></item>
        /// <item><description>支持组合查询。</description></item>
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
        /// <para>This operation retrieves information about file systems.</para>
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
        /// <para>This operation retrieves information about file systems.</para>
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
        /// <para>This operation retrieves information about file systems.</para>
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
        /// <para>This operation retrieves information about file systems.</para>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0和CPFS智算版2.7.0及以上版本支持Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>筛选键（Filters）中，FsetIds需要做全字匹配，FileSystemPath、Description支持模糊匹配。</description></item>
        /// <item><description>支持组合查询。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0和CPFS智算版2.7.0及以上版本支持Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>筛选键（Filters）中，FsetIds需要做全字匹配，FileSystemPath、Description支持模糊匹配。</description></item>
        /// <item><description>支持组合查询。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0和CPFS智算版2.7.0及以上版本支持Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>筛选键（Filters）中，FsetIds需要做全字匹配，FileSystemPath、Description支持模糊匹配。</description></item>
        /// <item><description>支持组合查询。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS 2.2.0和CPFS智算版2.7.0及以上版本支持Fileset。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>筛选键（Filters）中，FsetIds需要做全字匹配，FileSystemPath、Description支持模糊匹配。</description></item>
        /// <item><description>支持组合查询。</description></item>
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
        /// <para>Retrieves the list of HpnZones for a file system. Access performance is optimal when compute nodes are located in one of the associated HpnZones.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅支持CPFS智算版文件系统。</description></item>
        /// <item><description>此接口为批量接口，每次最多允许查询 20 个文件系统。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribeFilesystemsAssociatedHpnZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesystemsAssociatedHpnZonesResponse
        /// </returns>
        public DescribeFilesystemsAssociatedHpnZonesResponse DescribeFilesystemsAssociatedHpnZonesWithOptions(DescribeFilesystemsAssociatedHpnZonesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeFilesystemsAssociatedHpnZonesShrinkRequest request = new DescribeFilesystemsAssociatedHpnZonesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filesystems))
            {
                request.FilesystemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filesystems, "Filesystems", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesystemsShrink))
            {
                query["Filesystems"] = request.FilesystemsShrink;
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
                Action = "DescribeFilesystemsAssociatedHpnZones",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilesystemsAssociatedHpnZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of HpnZones for a file system. Access performance is optimal when compute nodes are located in one of the associated HpnZones.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅支持CPFS智算版文件系统。</description></item>
        /// <item><description>此接口为批量接口，每次最多允许查询 20 个文件系统。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribeFilesystemsAssociatedHpnZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesystemsAssociatedHpnZonesResponse
        /// </returns>
        public async Task<DescribeFilesystemsAssociatedHpnZonesResponse> DescribeFilesystemsAssociatedHpnZonesWithOptionsAsync(DescribeFilesystemsAssociatedHpnZonesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeFilesystemsAssociatedHpnZonesShrinkRequest request = new DescribeFilesystemsAssociatedHpnZonesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filesystems))
            {
                request.FilesystemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filesystems, "Filesystems", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesystemsShrink))
            {
                query["Filesystems"] = request.FilesystemsShrink;
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
                Action = "DescribeFilesystemsAssociatedHpnZones",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilesystemsAssociatedHpnZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of HpnZones for a file system. Access performance is optimal when compute nodes are located in one of the associated HpnZones.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅支持CPFS智算版文件系统。</description></item>
        /// <item><description>此接口为批量接口，每次最多允许查询 20 个文件系统。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesystemsAssociatedHpnZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesystemsAssociatedHpnZonesResponse
        /// </returns>
        public DescribeFilesystemsAssociatedHpnZonesResponse DescribeFilesystemsAssociatedHpnZones(DescribeFilesystemsAssociatedHpnZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFilesystemsAssociatedHpnZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of HpnZones for a file system. Access performance is optimal when compute nodes are located in one of the associated HpnZones.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅支持CPFS智算版文件系统。</description></item>
        /// <item><description>此接口为批量接口，每次最多允许查询 20 个文件系统。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFilesystemsAssociatedHpnZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilesystemsAssociatedHpnZonesResponse
        /// </returns>
        public async Task<DescribeFilesystemsAssociatedHpnZonesResponse> DescribeFilesystemsAssociatedHpnZonesAsync(DescribeFilesystemsAssociatedHpnZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFilesystemsAssociatedHpnZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual storage channels associated with a file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleChain))
            {
                query["RoleChain"] = request.RoleChain;
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleChain))
            {
                query["RoleChain"] = request.RoleChain;
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
        /// <para>仅通用型NAS文件系统和 CPFS 智算版支持该功能。</para>
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
        /// <para>仅通用型NAS文件系统和 CPFS 智算版支持该功能。</para>
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
        /// <para>仅通用型NAS文件系统和 CPFS 智算版支持该功能。</para>
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
        /// <para>仅通用型NAS文件系统和 CPFS 智算版支持该功能。</para>
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
        /// <para>Queries the execution logs of a lifecycle policy, returning up to 1,000 entries from the last 90 days. This feature is only available for CPFS AI Computing Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the execution logs of a lifecycle policy. You can query up to 1,000 log entries from the last 90 days. Only CPFS (AI Computing Edition) supports this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLifecyclePolicyLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLifecyclePolicyLogsResponse
        /// </returns>
        public DescribeLifecyclePolicyLogsResponse DescribeLifecyclePolicyLogsWithOptions(DescribeLifecyclePolicyLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
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
                Action = "DescribeLifecyclePolicyLogs",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLifecyclePolicyLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution logs of a lifecycle policy, returning up to 1,000 entries from the last 90 days. This feature is only available for CPFS AI Computing Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the execution logs of a lifecycle policy. You can query up to 1,000 log entries from the last 90 days. Only CPFS (AI Computing Edition) supports this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLifecyclePolicyLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLifecyclePolicyLogsResponse
        /// </returns>
        public async Task<DescribeLifecyclePolicyLogsResponse> DescribeLifecyclePolicyLogsWithOptionsAsync(DescribeLifecyclePolicyLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
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
                Action = "DescribeLifecyclePolicyLogs",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLifecyclePolicyLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution logs of a lifecycle policy, returning up to 1,000 entries from the last 90 days. This feature is only available for CPFS AI Computing Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the execution logs of a lifecycle policy. You can query up to 1,000 log entries from the last 90 days. Only CPFS (AI Computing Edition) supports this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLifecyclePolicyLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLifecyclePolicyLogsResponse
        /// </returns>
        public DescribeLifecyclePolicyLogsResponse DescribeLifecyclePolicyLogs(DescribeLifecyclePolicyLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLifecyclePolicyLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution logs of a lifecycle policy, returning up to 1,000 entries from the last 90 days. This feature is only available for CPFS AI Computing Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the execution logs of a lifecycle policy. You can query up to 1,000 log entries from the last 90 days. Only CPFS (AI Computing Edition) supports this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLifecyclePolicyLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLifecyclePolicyLogsResponse
        /// </returns>
        public async Task<DescribeLifecyclePolicyLogsResponse> DescribeLifecyclePolicyLogsAsync(DescribeLifecyclePolicyLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLifecyclePolicyLogsWithOptionsAsync(request, runtime);
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
        /// <para>Retrieves information about mount targets.</para>
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
        /// <para>Retrieves information about mount targets.</para>
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
        /// <para>Retrieves information about mount targets.</para>
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
        /// <para>Retrieves information about mount targets.</para>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS支持该接口。</description></item>
        /// <item><description>客户端列表显示近一分钟对文件系统有读写访问的客户端IP，部分已挂载而没有访问文件系统的客户端IP可能不在此列表中显示。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS支持该接口。</description></item>
        /// <item><description>客户端列表显示近一分钟对文件系统有读写访问的客户端IP，部分已挂载而没有访问文件系统的客户端IP可能不在此列表中显示。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS支持该接口。</description></item>
        /// <item><description>客户端列表显示近一分钟对文件系统有读写访问的客户端IP，部分已挂载而没有访问文件系统的客户端IP可能不在此列表中显示。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅通用型NAS支持该接口。</description></item>
        /// <item><description>客户端列表显示近一分钟对文件系统有读写访问的客户端IP，部分已挂载而没有访问文件系统的客户端IP可能不在此列表中显示。</description></item>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleChain))
            {
                query["RoleChain"] = request.RoleChain;
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleChain))
            {
                query["RoleChain"] = request.RoleChain;
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版支持该功能。</description></item>
        /// <item><description>支持批量执行，批量执行情况下，目前仅支持1个VscId关联到多个FileSystemId，即ResourceIds.VscId需相等。</description></item>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅通用型NAS NFS协议文件系统支持该功能。</para>
        /// </description>
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
        /// <para>Checks if a specified directory contains infrequent access or archive storage files, or if a specified file is an infrequent access or archive storage file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only for general-purpose NAS file systems.</para>
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
        /// <para>Checks if a specified directory contains infrequent access or archive storage files, or if a specified file is an infrequent access or archive storage file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only for general-purpose NAS file systems.</para>
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
        /// <para>Checks if a specified directory contains infrequent access or archive storage files, or if a specified file is an infrequent access or archive storage file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only for general-purpose NAS file systems.</para>
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
        /// <para>Checks if a specified directory contains infrequent access or archive storage files, or if a specified file is an infrequent access or archive storage file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only for general-purpose NAS file systems.</para>
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
        /// <para>Queries the information about the created fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅CPFS 2.2.0和CPFS智算版2.7.0及以上版本支持Fileset。您可以在控制台文件系统详情页面查看版本信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFilesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFilesetResponse
        /// </returns>
        public GetFilesetResponse GetFilesetWithOptions(GetFilesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetFileset",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFilesetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the created fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅CPFS 2.2.0和CPFS智算版2.7.0及以上版本支持Fileset。您可以在控制台文件系统详情页面查看版本信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFilesetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFilesetResponse
        /// </returns>
        public async Task<GetFilesetResponse> GetFilesetWithOptionsAsync(GetFilesetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetFileset",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFilesetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the created fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅CPFS 2.2.0和CPFS智算版2.7.0及以上版本支持Fileset。您可以在控制台文件系统详情页面查看版本信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFilesetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFilesetResponse
        /// </returns>
        public GetFilesetResponse GetFileset(GetFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFilesetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the created fileset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅CPFS 2.2.0和CPFS智算版2.7.0及以上版本支持Fileset。您可以在控制台文件系统详情页面查看版本信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFilesetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFilesetResponse
        /// </returns>
        public async Task<GetFilesetResponse> GetFilesetAsync(GetFilesetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFilesetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the export directory information of the protocol service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProtocolMountTargetResponse
        /// </returns>
        public GetProtocolMountTargetResponse GetProtocolMountTargetWithOptions(GetProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                query["ExportId"] = request.ExportId;
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
                Action = "GetProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProtocolMountTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the export directory information of the protocol service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProtocolMountTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProtocolMountTargetResponse
        /// </returns>
        public async Task<GetProtocolMountTargetResponse> GetProtocolMountTargetWithOptionsAsync(GetProtocolMountTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                query["ExportId"] = request.ExportId;
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
                Action = "GetProtocolMountTarget",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProtocolMountTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the export directory information of the protocol service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProtocolMountTargetResponse
        /// </returns>
        public GetProtocolMountTargetResponse GetProtocolMountTarget(GetProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProtocolMountTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the export directory information of the protocol service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProtocolMountTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProtocolMountTargetResponse
        /// </returns>
        public async Task<GetProtocolMountTargetResponse> GetProtocolMountTargetAsync(GetProtocolMountTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProtocolMountTargetWithOptionsAsync(request, runtime);
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
        /// <para>Lists Infrequent Access files and the subdirectories that contain them from a specified directory on a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only general-purpose NAS file systems support this feature.</para>
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
        /// <para>Lists Infrequent Access files and the subdirectories that contain them from a specified directory on a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only general-purpose NAS file systems support this feature.</para>
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
        /// <para>Lists Infrequent Access files and the subdirectories that contain them from a specified directory on a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only general-purpose NAS file systems support this feature.</para>
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
        /// <para>Lists Infrequent Access files and the subdirectories that contain them from a specified directory on a General-purpose NAS file system.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only general-purpose NAS file systems support this feature.</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）不支持修改。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）不支持修改。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）不支持修改。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）不支持修改。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）中的规则不支持修改。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）中的规则不支持修改。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）中的规则不支持修改。</para>
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
        /// <para>默认权限组（DEFAULT_VPC_GROUP_NAME）中的规则不支持修改。</para>
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
        /// <list type="bullet">
        /// <item><description>CPFS 2.2.0及以上版本、CPFS智算版 2.4.0及以上版本支持数据流动。</description></item>
        /// <item><description>仅支持状态为<c>Running（正常）</c>状态的数据流动修改属性。</description></item>
        /// <item><description>修改数据流动一般耗时2~5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询修改数据流动的状态。</description></item>
        /// <item><description>CPFS数据流动规格：<list type="bullet">
        /// <item><description>数据流动带宽（Throughput）支持600 MB/s、1200 MB/s和1500 MB/s三种规格。数据流动带宽是指该数据流动进行导入或导出数据时能达到的最大传输带宽。</description></item>
        /// <item><description>库存查询：当设置DryRun为true时，可校验修改该规格的数据流动的资源是否满足。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS计费
        /// 修改数据流动带宽（Throughput）涉及数据流动带宽计费，建议您提前了解CPFS的计费方式。更多详情，请参见<a href="https://help.aliyun.com/document_detail/111858.html">CPFS计费说明</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>CPFS 2.2.0及以上版本、CPFS智算版 2.4.0及以上版本支持数据流动。</description></item>
        /// <item><description>仅支持状态为<c>Running（正常）</c>状态的数据流动修改属性。</description></item>
        /// <item><description>修改数据流动一般耗时2~5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询修改数据流动的状态。</description></item>
        /// <item><description>CPFS数据流动规格：<list type="bullet">
        /// <item><description>数据流动带宽（Throughput）支持600 MB/s、1200 MB/s和1500 MB/s三种规格。数据流动带宽是指该数据流动进行导入或导出数据时能达到的最大传输带宽。</description></item>
        /// <item><description>库存查询：当设置DryRun为true时，可校验修改该规格的数据流动的资源是否满足。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS计费
        /// 修改数据流动带宽（Throughput）涉及数据流动带宽计费，建议您提前了解CPFS的计费方式。更多详情，请参见<a href="https://help.aliyun.com/document_detail/111858.html">CPFS计费说明</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>CPFS 2.2.0及以上版本、CPFS智算版 2.4.0及以上版本支持数据流动。</description></item>
        /// <item><description>仅支持状态为<c>Running（正常）</c>状态的数据流动修改属性。</description></item>
        /// <item><description>修改数据流动一般耗时2~5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询修改数据流动的状态。</description></item>
        /// <item><description>CPFS数据流动规格：<list type="bullet">
        /// <item><description>数据流动带宽（Throughput）支持600 MB/s、1200 MB/s和1500 MB/s三种规格。数据流动带宽是指该数据流动进行导入或导出数据时能达到的最大传输带宽。</description></item>
        /// <item><description>库存查询：当设置DryRun为true时，可校验修改该规格的数据流动的资源是否满足。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS计费
        /// 修改数据流动带宽（Throughput）涉及数据流动带宽计费，建议您提前了解CPFS的计费方式。更多详情，请参见<a href="https://help.aliyun.com/document_detail/111858.html">CPFS计费说明</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>CPFS 2.2.0及以上版本、CPFS智算版 2.4.0及以上版本支持数据流动。</description></item>
        /// <item><description>仅支持状态为<c>Running（正常）</c>状态的数据流动修改属性。</description></item>
        /// <item><description>修改数据流动一般耗时2~5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询修改数据流动的状态。</description></item>
        /// <item><description>CPFS数据流动规格：<list type="bullet">
        /// <item><description>数据流动带宽（Throughput）支持600 MB/s、1200 MB/s和1500 MB/s三种规格。数据流动带宽是指该数据流动进行导入或导出数据时能达到的最大传输带宽。</description></item>
        /// <item><description>库存查询：当设置DryRun为true时，可校验修改该规格的数据流动的资源是否满足。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>CPFS计费
        /// 修改数据流动带宽（Throughput）涉及数据流动带宽计费，建议您提前了解CPFS的计费方式。更多详情，请参见<a href="https://help.aliyun.com/document_detail/111858.html">CPFS计费说明</a>。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持修改<c>Running（正常</c>）、<c>Stopped（停止）</c>状态数据流动的自动更新配置。</description></item>
        /// <item><description>修改自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询修改自动更新任务的状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持修改<c>Running（正常</c>）、<c>Stopped（停止）</c>状态数据流动的自动更新配置。</description></item>
        /// <item><description>修改自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询修改自动更新任务的状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持修改<c>Running（正常</c>）、<c>Stopped（停止）</c>状态数据流动的自动更新配置。</description></item>
        /// <item><description>修改自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询修改自动更新任务的状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>仅支持修改<c>Running（正常</c>）、<c>Stopped（停止）</c>状态数据流动的自动更新配置。</description></item>
        /// <item><description>修改自动更新配置一般耗时2～5分钟，您可以通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询修改自动更新任务的状态。</description></item>
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
        /// <para>仅支持CPFS 2.2.0和CPFS智算版2.7.0及以上版本修改Fileset信息。</para>
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
        /// <para>仅支持CPFS 2.2.0和CPFS智算版2.7.0及以上版本修改Fileset信息。</para>
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
        /// <para>仅支持CPFS 2.2.0和CPFS智算版2.7.0及以上版本修改Fileset信息。</para>
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
        /// <para>仅支持CPFS 2.2.0和CPFS智算版2.7.0及以上版本修改Fileset信息。</para>
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
        /// <para>仅通用型NAS文件系统支持该功能。</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
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
        /// <para>仅通用型NAS文件系统支持该功能。</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
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
        /// <para>仅通用型NAS文件系统支持该功能。</para>
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
        /// <para>仅通用型NAS文件系统支持该功能。</para>
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
        /// <para>Modifies the properties of a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation applies only to mount targets on General-purpose NAS and Extreme NAS file systems.</para>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointAccessOnly))
            {
                query["AccessPointAccessOnly"] = request.AccessPointAccessOnly;
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
        /// <para>Modifies the properties of a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation applies only to mount targets on General-purpose NAS and Extreme NAS file systems.</para>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPointAccessOnly))
            {
                query["AccessPointAccessOnly"] = request.AccessPointAccessOnly;
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
        /// <para>Modifies the properties of a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation applies only to mount targets on General-purpose NAS and Extreme NAS file systems.</para>
        /// </description>
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
        /// <para>Modifies the properties of a mount target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation applies only to mount targets on General-purpose NAS and Extreme NAS file systems.</para>
        /// </description>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>该接口仅适用于CPFS文件系统。</para>
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
        /// <para>Activates the NAS service.</para>
        /// </summary>
        /// 
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
        /// <para>Activates the NAS service.</para>
        /// </summary>
        /// 
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
        /// <para>Activates the NAS service.</para>
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
        /// <para>Activates the NAS service.</para>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.7.0及以上版本支持为文件集设置配额。</description></item>
        /// <item><description>Fileset容量配额，最小起步10 GiB，扩容单位为1 GiB。</description></item>
        /// <item><description>Fileset最多支持100亿个文件或目录，最小起步10000，扩容单位为1。</description></item>
        /// <item><description>修改目录配额时，设置的配额容量或文件数必须高于已使用容量或文件数。</description></item>
        /// <item><description>容量限制和文件数限制至少填写其中一项。</description></item>
        /// <item><description>配额的统计有15分钟的延迟，当前的实际使用量15分钟之后才会生效。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.7.0及以上版本支持为文件集设置配额。</description></item>
        /// <item><description>Fileset容量配额，最小起步10 GiB，扩容单位为1 GiB。</description></item>
        /// <item><description>Fileset最多支持100亿个文件或目录，最小起步10000，扩容单位为1。</description></item>
        /// <item><description>修改目录配额时，设置的配额容量或文件数必须高于已使用容量或文件数。</description></item>
        /// <item><description>容量限制和文件数限制至少填写其中一项。</description></item>
        /// <item><description>配额的统计有15分钟的延迟，当前的实际使用量15分钟之后才会生效。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.7.0及以上版本支持为文件集设置配额。</description></item>
        /// <item><description>Fileset容量配额，最小起步10 GiB，扩容单位为1 GiB。</description></item>
        /// <item><description>Fileset最多支持100亿个文件或目录，最小起步10000，扩容单位为1。</description></item>
        /// <item><description>修改目录配额时，设置的配额容量或文件数必须高于已使用容量或文件数。</description></item>
        /// <item><description>容量限制和文件数限制至少填写其中一项。</description></item>
        /// <item><description>配额的统计有15分钟的延迟，当前的实际使用量15分钟之后才会生效。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅CPFS智算版2.7.0及以上版本支持为文件集设置配额。</description></item>
        /// <item><description>Fileset容量配额，最小起步10 GiB，扩容单位为1 GiB。</description></item>
        /// <item><description>Fileset最多支持100亿个文件或目录，最小起步10000，扩容单位为1。</description></item>
        /// <item><description>修改目录配额时，设置的配额容量或文件数必须高于已使用容量或文件数。</description></item>
        /// <item><description>容量限制和文件数限制至少填写其中一项。</description></item>
        /// <item><description>配额的统计有15分钟的延迟，当前的实际使用量15分钟之后才会生效。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>只能启动<c>Stopped（停止）</c>状态的数据流动。</description></item>
        /// <item><description>当DryRun为<c>true</c>时，可校验启动该规格的数据流动的资源是否充足。如果库存资源不足，数据流动则无法启动。</description></item>
        /// <item><description>启动数据流动一般耗时2～5分钟，您可通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>只能启动<c>Stopped（停止）</c>状态的数据流动。</description></item>
        /// <item><description>当DryRun为<c>true</c>时，可校验启动该规格的数据流动的资源是否充足。如果库存资源不足，数据流动则无法启动。</description></item>
        /// <item><description>启动数据流动一般耗时2～5分钟，您可通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>只能启动<c>Stopped（停止）</c>状态的数据流动。</description></item>
        /// <item><description>当DryRun为<c>true</c>时，可校验启动该规格的数据流动的资源是否充足。如果库存资源不足，数据流动则无法启动。</description></item>
        /// <item><description>启动数据流动一般耗时2～5分钟，您可通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>只能启动<c>Stopped（停止）</c>状态的数据流动。</description></item>
        /// <item><description>当DryRun为<c>true</c>时，可校验启动该规格的数据流动的资源是否充足。如果库存资源不足，数据流动则无法启动。</description></item>
        /// <item><description>启动数据流动一般耗时2～5分钟，您可通过<a href="https://help.aliyun.com/document_detail/2402270.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
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
        /// <para>Starts the execution of a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only when the <c>LifecyclePolicyType</c> of a lifecycle policy is set to <c>OnDemand</c> for a CPFS AI-Computing Edition file system.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLifecyclePolicyExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartLifecyclePolicyExecutionResponse
        /// </returns>
        public StartLifecyclePolicyExecutionResponse StartLifecyclePolicyExecutionWithOptions(StartLifecyclePolicyExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartLifecyclePolicyExecution",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartLifecyclePolicyExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the execution of a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only when the <c>LifecyclePolicyType</c> of a lifecycle policy is set to <c>OnDemand</c> for a CPFS AI-Computing Edition file system.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLifecyclePolicyExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartLifecyclePolicyExecutionResponse
        /// </returns>
        public async Task<StartLifecyclePolicyExecutionResponse> StartLifecyclePolicyExecutionWithOptionsAsync(StartLifecyclePolicyExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartLifecyclePolicyExecution",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartLifecyclePolicyExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the execution of a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only when the <c>LifecyclePolicyType</c> of a lifecycle policy is set to <c>OnDemand</c> for a CPFS AI-Computing Edition file system.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLifecyclePolicyExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartLifecyclePolicyExecutionResponse
        /// </returns>
        public StartLifecyclePolicyExecutionResponse StartLifecyclePolicyExecution(StartLifecyclePolicyExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLifecyclePolicyExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts the execution of a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only when the <c>LifecyclePolicyType</c> of a lifecycle policy is set to <c>OnDemand</c> for a CPFS AI-Computing Edition file system.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLifecyclePolicyExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartLifecyclePolicyExecutionResponse
        /// </returns>
        public async Task<StartLifecyclePolicyExecutionResponse> StartLifecyclePolicyExecutionAsync(StartLifecyclePolicyExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLifecyclePolicyExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a dataflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>只能停用<c>Running（正常）</c>状态的数据流动。</description></item>
        /// <item><description>停用后，不可在数据流动上创建数据流动任务。如果配置了自动更新，源端发生的数据更新也不会同步到CPFS上。</description></item>
        /// <item><description>停用后，由于资源被回收，数据流动带宽将不再计费，但重新启动数据流动可能因为库存不足导致启动失败。</description></item>
        /// <item><description>停用数据流动一般耗时2～5分钟，您可通过<a href="https://help.aliyun.com/document_detail/2402271.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>只能停用<c>Running（正常）</c>状态的数据流动。</description></item>
        /// <item><description>停用后，不可在数据流动上创建数据流动任务。如果配置了自动更新，源端发生的数据更新也不会同步到CPFS上。</description></item>
        /// <item><description>停用后，由于资源被回收，数据流动带宽将不再计费，但重新启动数据流动可能因为库存不足导致启动失败。</description></item>
        /// <item><description>停用数据流动一般耗时2～5分钟，您可通过<a href="https://help.aliyun.com/document_detail/2402271.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>只能停用<c>Running（正常）</c>状态的数据流动。</description></item>
        /// <item><description>停用后，不可在数据流动上创建数据流动任务。如果配置了自动更新，源端发生的数据更新也不会同步到CPFS上。</description></item>
        /// <item><description>停用后，由于资源被回收，数据流动带宽将不再计费，但重新启动数据流动可能因为库存不足导致启动失败。</description></item>
        /// <item><description>停用数据流动一般耗时2～5分钟，您可通过<a href="https://help.aliyun.com/document_detail/2402271.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
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
        /// <list type="bullet">
        /// <item><description>该接口仅适用于CPFS文件系统。</description></item>
        /// <item><description>仅CPFS 2.2.0及以上版本支持数据流动。您可以在控制台文件系统详情页面查看版本信息。</description></item>
        /// <item><description>只能停用<c>Running（正常）</c>状态的数据流动。</description></item>
        /// <item><description>停用后，不可在数据流动上创建数据流动任务。如果配置了自动更新，源端发生的数据更新也不会同步到CPFS上。</description></item>
        /// <item><description>停用后，由于资源被回收，数据流动带宽将不再计费，但重新启动数据流动可能因为库存不足导致启动失败。</description></item>
        /// <item><description>停用数据流动一般耗时2～5分钟，您可通过<a href="https://help.aliyun.com/document_detail/2402271.html">DescribeDataFlows</a>查询数据流动状态。</description></item>
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
        /// <para>Stops the execution of a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation applies only when the LifecyclePolicyType parameter of a lifecycle management policy for a CPFS file system is set to OnDemand.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLifecyclePolicyExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopLifecyclePolicyExecutionResponse
        /// </returns>
        public StopLifecyclePolicyExecutionResponse StopLifecyclePolicyExecutionWithOptions(StopLifecyclePolicyExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLifecyclePolicyExecution",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLifecyclePolicyExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the execution of a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation applies only when the LifecyclePolicyType parameter of a lifecycle management policy for a CPFS file system is set to OnDemand.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLifecyclePolicyExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopLifecyclePolicyExecutionResponse
        /// </returns>
        public async Task<StopLifecyclePolicyExecutionResponse> StopLifecyclePolicyExecutionWithOptionsAsync(StopLifecyclePolicyExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLifecyclePolicyExecution",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLifecyclePolicyExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the execution of a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation applies only when the LifecyclePolicyType parameter of a lifecycle management policy for a CPFS file system is set to OnDemand.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLifecyclePolicyExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StopLifecyclePolicyExecutionResponse
        /// </returns>
        public StopLifecyclePolicyExecutionResponse StopLifecyclePolicyExecution(StopLifecyclePolicyExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLifecyclePolicyExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the execution of a lifecycle policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation applies only when the LifecyclePolicyType parameter of a lifecycle management policy for a CPFS file system is set to OnDemand.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLifecyclePolicyExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StopLifecyclePolicyExecutionResponse
        /// </returns>
        public async Task<StopLifecyclePolicyExecutionResponse> StopLifecyclePolicyExecutionAsync(StopLifecyclePolicyExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLifecyclePolicyExecutionWithOptionsAsync(request, runtime);
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
        /// <para>Updates the rules of a lifecycle policy. This operation is supported only for CPFS for AI file systems. The <c>UpdateLifecyclePolicy</c> operation overwrites the entire policy. Omitting an optional parameter deletes its corresponding configuration. To add a rule to an existing policy, call the <c>DescribeLifecyclePolicies</c> operation to retrieve the current policy, append the new rule, and then call <c>UpdateLifecyclePolicy</c> with the updated configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLifecyclePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLifecyclePolicyResponse
        /// </returns>
        public UpdateLifecyclePolicyResponse UpdateLifecyclePolicyWithOptions(UpdateLifecyclePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paths))
            {
                query["Paths"] = request.Paths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrieveRules))
            {
                query["RetrieveRules"] = request.RetrieveRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRules))
            {
                query["TransitRules"] = request.TransitRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLifecyclePolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLifecyclePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the rules of a lifecycle policy. This operation is supported only for CPFS for AI file systems. The <c>UpdateLifecyclePolicy</c> operation overwrites the entire policy. Omitting an optional parameter deletes its corresponding configuration. To add a rule to an existing policy, call the <c>DescribeLifecyclePolicies</c> operation to retrieve the current policy, append the new rule, and then call <c>UpdateLifecyclePolicy</c> with the updated configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLifecyclePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLifecyclePolicyResponse
        /// </returns>
        public async Task<UpdateLifecyclePolicyResponse> UpdateLifecyclePolicyWithOptionsAsync(UpdateLifecyclePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecyclePolicyId))
            {
                query["LifecyclePolicyId"] = request.LifecyclePolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paths))
            {
                query["Paths"] = request.Paths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrieveRules))
            {
                query["RetrieveRules"] = request.RetrieveRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRules))
            {
                query["TransitRules"] = request.TransitRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLifecyclePolicy",
                Version = "2017-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLifecyclePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the rules of a lifecycle policy. This operation is supported only for CPFS for AI file systems. The <c>UpdateLifecyclePolicy</c> operation overwrites the entire policy. Omitting an optional parameter deletes its corresponding configuration. To add a rule to an existing policy, call the <c>DescribeLifecyclePolicies</c> operation to retrieve the current policy, append the new rule, and then call <c>UpdateLifecyclePolicy</c> with the updated configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLifecyclePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLifecyclePolicyResponse
        /// </returns>
        public UpdateLifecyclePolicyResponse UpdateLifecyclePolicy(UpdateLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLifecyclePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the rules of a lifecycle policy. This operation is supported only for CPFS for AI file systems. The <c>UpdateLifecyclePolicy</c> operation overwrites the entire policy. Omitting an optional parameter deletes its corresponding configuration. To add a rule to an existing policy, call the <c>DescribeLifecyclePolicies</c> operation to retrieve the current policy, append the new rule, and then call <c>UpdateLifecyclePolicy</c> with the updated configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLifecyclePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLifecyclePolicyResponse
        /// </returns>
        public async Task<UpdateLifecyclePolicyResponse> UpdateLifecyclePolicyAsync(UpdateLifecyclePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLifecyclePolicyWithOptionsAsync(request, runtime);
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
        /// <list type="bullet">
        /// <item><description>仅支持极速型NAS文件系统和CPFS文件系统扩容。</description></item>
        /// <item><description>通用型NAS按需自动扩容，无须使用本API。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅支持极速型NAS文件系统和CPFS文件系统扩容。</description></item>
        /// <item><description>通用型NAS按需自动扩容，无须使用本API。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅支持极速型NAS文件系统和CPFS文件系统扩容。</description></item>
        /// <item><description>通用型NAS按需自动扩容，无须使用本API。</description></item>
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
        /// <list type="bullet">
        /// <item><description>仅支持极速型NAS文件系统和CPFS文件系统扩容。</description></item>
        /// <item><description>通用型NAS按需自动扩容，无须使用本API。</description></item>
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
