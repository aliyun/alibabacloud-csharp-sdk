// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CS20180418.Models;

namespace AlibabaCloud.SDK.CS20180418
{
    public class Client : AlibabaCloud.ROAClient.Client
    {

        public Client(AlibabaCloud.ROAClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "cs.aliyuncs.com"},
                {"cn-beijing-finance-1", "cs.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cs.aliyuncs.com"},
                {"cn-beijing-gov-1", "cs.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cs.aliyuncs.com"},
                {"cn-edge-1", "cs.aliyuncs.com"},
                {"cn-fujian", "cs.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cs.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cs.aliyuncs.com"},
                {"cn-hangzhou-finance", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cs.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cs.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cs.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "cs.aliyuncs.com"},
                {"cn-qingdao-nebula", "cs.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cs.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cs.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cs.aliyuncs.com"},
                {"cn-shanghai-inner", "cs.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cs.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cs.aliyuncs.com"},
                {"cn-shenzhen-inner", "cs.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cs.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cs.aliyuncs.com"},
                {"cn-wuhan", "cs.aliyuncs.com"},
                {"cn-wulanchabu", "cs.aliyuncs.com"},
                {"cn-yushanfang", "cs.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cs.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cs.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cs.aliyuncs.com"},
                {"eu-west-1-oxs", "cs.aliyuncs.com"},
                {"rus-west-1-pop", "cs.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpointHost = GetEndpoint("cs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpointHost);
        }


        public GetProjectEventsResponse GetProjectEventsWithOptions(string clusterId, string projectId, GetProjectEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetProjectEventsResponse>(DoRequestWithAction("GetProjectEvents", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/projects/" + projectId + "/events", null, request.Headers, null, runtime));
        }

        public async Task<GetProjectEventsResponse> GetProjectEventsWithOptionsAsync(string clusterId, string projectId, GetProjectEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetProjectEventsResponse>(await DoRequestWithActionAsync("GetProjectEvents", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/projects/" + projectId + "/events", null, request.Headers, null, runtime));
        }

        public GetProjectEventsResponse GetProjectEvents(string clusterId, string projectId, GetProjectEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectEventsWithOptions(clusterId, projectId, request, runtime);
        }

        public async Task<GetProjectEventsResponse> GetProjectEventsAsync(string clusterId, string projectId, GetProjectEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectEventsWithOptionsAsync(clusterId, projectId, request, runtime);
        }

        public DescribeKubernetesTemplateResponse DescribeKubernetesTemplateWithOptions(string clusterId, DescribeKubernetesTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeKubernetesTemplateResponse>(DoRequestWithAction("DescribeKubernetesTemplate", "2018-04-18", "HTTPS", "GET", "AK", "/k8s/templates/" + clusterId, null, request.Headers, null, runtime));
        }

        public async Task<DescribeKubernetesTemplateResponse> DescribeKubernetesTemplateWithOptionsAsync(string clusterId, DescribeKubernetesTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeKubernetesTemplateResponse>(await DoRequestWithActionAsync("DescribeKubernetesTemplate", "2018-04-18", "HTTPS", "GET", "AK", "/k8s/templates/" + clusterId, null, request.Headers, null, runtime));
        }

        public DescribeKubernetesTemplateResponse DescribeKubernetesTemplate(string clusterId, DescribeKubernetesTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKubernetesTemplateWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeKubernetesTemplateResponse> DescribeKubernetesTemplateAsync(string clusterId, DescribeKubernetesTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKubernetesTemplateWithOptionsAsync(clusterId, request, runtime);
        }

        public DescribeAgilityTunnelCertsResponse DescribeAgilityTunnelCertsWithOptions(string token, DescribeAgilityTunnelCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAgilityTunnelCertsResponse>(DoRequestWithAction("DescribeAgilityTunnelCerts", "2018-04-18", "HTTPS", "GET", "Anonymous", "/agility/" + token + "/agent_certs", null, request.Headers, null, runtime));
        }

        public async Task<DescribeAgilityTunnelCertsResponse> DescribeAgilityTunnelCertsWithOptionsAsync(string token, DescribeAgilityTunnelCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAgilityTunnelCertsResponse>(await DoRequestWithActionAsync("DescribeAgilityTunnelCerts", "2018-04-18", "HTTPS", "GET", "Anonymous", "/agility/" + token + "/agent_certs", null, request.Headers, null, runtime));
        }

        public DescribeAgilityTunnelCertsResponse DescribeAgilityTunnelCerts(string token, DescribeAgilityTunnelCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAgilityTunnelCertsWithOptions(token, request, runtime);
        }

        public async Task<DescribeAgilityTunnelCertsResponse> DescribeAgilityTunnelCertsAsync(string token, DescribeAgilityTunnelCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAgilityTunnelCertsWithOptionsAsync(token, request, runtime);
        }

        public DescribeClusterTokensResponse DescribeClusterTokensWithOptions(string clusterId, DescribeClusterTokensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterTokensResponse>(DoRequestWithAction("DescribeClusterTokens", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/tokens", null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterTokensResponse> DescribeClusterTokensWithOptionsAsync(string clusterId, DescribeClusterTokensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterTokensResponse>(await DoRequestWithActionAsync("DescribeClusterTokens", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/tokens", null, request.Headers, null, runtime));
        }

        public DescribeClusterTokensResponse DescribeClusterTokens(string clusterId, DescribeClusterTokensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterTokensWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeClusterTokensResponse> DescribeClusterTokensAsync(string clusterId, DescribeClusterTokensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterTokensWithOptionsAsync(clusterId, request, runtime);
        }

        public DownloadClusterNodeCertsResponse DownloadClusterNodeCertsWithOptions(string token, string nodeId, DownloadClusterNodeCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DownloadClusterNodeCertsResponse>(DoRequestWithAction("DownloadClusterNodeCerts", "2018-04-18", "HTTPS", "GET", "Anonymous", "/token/" + token + "/nodes/" + nodeId + "/certs", null, request.Headers, null, runtime));
        }

        public async Task<DownloadClusterNodeCertsResponse> DownloadClusterNodeCertsWithOptionsAsync(string token, string nodeId, DownloadClusterNodeCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DownloadClusterNodeCertsResponse>(await DoRequestWithActionAsync("DownloadClusterNodeCerts", "2018-04-18", "HTTPS", "GET", "Anonymous", "/token/" + token + "/nodes/" + nodeId + "/certs", null, request.Headers, null, runtime));
        }

        public DownloadClusterNodeCertsResponse DownloadClusterNodeCerts(string token, string nodeId, DownloadClusterNodeCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadClusterNodeCertsWithOptions(token, nodeId, request, runtime);
        }

        public async Task<DownloadClusterNodeCertsResponse> DownloadClusterNodeCertsAsync(string token, string nodeId, DownloadClusterNodeCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadClusterNodeCertsWithOptionsAsync(token, nodeId, request, runtime);
        }

        public DescribeServiceContainersResponse DescribeServiceContainersWithOptions(string clusterId, string serviceId, DescribeServiceContainersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServiceContainersResponse>(DoRequestWithAction("DescribeServiceContainers", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/services/" + serviceId + "/containers", null, request.Headers, null, runtime));
        }

        public async Task<DescribeServiceContainersResponse> DescribeServiceContainersWithOptionsAsync(string clusterId, string serviceId, DescribeServiceContainersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeServiceContainersResponse>(await DoRequestWithActionAsync("DescribeServiceContainers", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/services/" + serviceId + "/containers", null, request.Headers, null, runtime));
        }

        public DescribeServiceContainersResponse DescribeServiceContainers(string clusterId, string serviceId, DescribeServiceContainersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceContainersWithOptions(clusterId, serviceId, request, runtime);
        }

        public async Task<DescribeServiceContainersResponse> DescribeServiceContainersAsync(string clusterId, string serviceId, DescribeServiceContainersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceContainersWithOptionsAsync(clusterId, serviceId, request, runtime);
        }

        public GatherLogsTokenResponse GatherLogsTokenWithOptions(string token, GatherLogsTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GatherLogsTokenResponse>(DoRequestWithAction("GatherLogsToken", "2018-04-18", "HTTPS", "POST", "Anonymous", "/token/" + token + "/gather_logs", null, request.Headers, null, runtime));
        }

        public async Task<GatherLogsTokenResponse> GatherLogsTokenWithOptionsAsync(string token, GatherLogsTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GatherLogsTokenResponse>(await DoRequestWithActionAsync("GatherLogsToken", "2018-04-18", "HTTPS", "POST", "Anonymous", "/token/" + token + "/gather_logs", null, request.Headers, null, runtime));
        }

        public GatherLogsTokenResponse GatherLogsToken(string token, GatherLogsTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GatherLogsTokenWithOptions(token, request, runtime);
        }

        public async Task<GatherLogsTokenResponse> GatherLogsTokenAsync(string token, GatherLogsTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GatherLogsTokenWithOptionsAsync(token, request, runtime);
        }

        public GetClusterProjectsResponse GetClusterProjectsWithOptions(string clusterId, GetClusterProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetClusterProjectsResponse>(DoRequestWithAction("GetClusterProjects", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/projects", null, request.Headers, null, runtime));
        }

        public async Task<GetClusterProjectsResponse> GetClusterProjectsWithOptionsAsync(string clusterId, GetClusterProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetClusterProjectsResponse>(await DoRequestWithActionAsync("GetClusterProjects", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/projects", null, request.Headers, null, runtime));
        }

        public GetClusterProjectsResponse GetClusterProjects(string clusterId, GetClusterProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClusterProjectsWithOptions(clusterId, request, runtime);
        }

        public async Task<GetClusterProjectsResponse> GetClusterProjectsAsync(string clusterId, GetClusterProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClusterProjectsWithOptionsAsync(clusterId, request, runtime);
        }

        public DescribeApiVersionResponse DescribeApiVersionWithOptions(DescribeApiVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeApiVersionResponse>(DoRequestWithAction("DescribeApiVersion", "2018-04-18", "HTTPS", "GET", "AK", "/version", null, request.Headers, null, runtime));
        }

        public async Task<DescribeApiVersionResponse> DescribeApiVersionWithOptionsAsync(DescribeApiVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeApiVersionResponse>(await DoRequestWithActionAsync("DescribeApiVersion", "2018-04-18", "HTTPS", "GET", "AK", "/version", null, request.Headers, null, runtime));
        }

        public DescribeApiVersionResponse DescribeApiVersion(DescribeApiVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiVersionWithOptions(request, runtime);
        }

        public async Task<DescribeApiVersionResponse> DescribeApiVersionAsync(DescribeApiVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiVersionWithOptionsAsync(request, runtime);
        }

        public DescribeTaskInfoResponse DescribeTaskInfoWithOptions(string taskId, DescribeTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTaskInfoResponse>(DoRequestWithAction("DescribeTaskInfo", "2018-04-18", "HTTPS", "GET", "AK", "/tasks/" + taskId, null, request.Headers, null, runtime));
        }

        public async Task<DescribeTaskInfoResponse> DescribeTaskInfoWithOptionsAsync(string taskId, DescribeTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTaskInfoResponse>(await DoRequestWithActionAsync("DescribeTaskInfo", "2018-04-18", "HTTPS", "GET", "AK", "/tasks/" + taskId, null, request.Headers, null, runtime));
        }

        public DescribeTaskInfoResponse DescribeTaskInfo(string taskId, DescribeTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTaskInfoWithOptions(taskId, request, runtime);
        }

        public async Task<DescribeTaskInfoResponse> DescribeTaskInfoAsync(string taskId, DescribeTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTaskInfoWithOptionsAsync(taskId, request, runtime);
        }

        public DescribeClusterNodesResponse DescribeClusterNodesWithOptions(string clusterId, DescribeClusterNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterNodesResponse>(DoRequestWithAction("DescribeClusterNodes", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/nodes", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public async Task<DescribeClusterNodesResponse> DescribeClusterNodesWithOptionsAsync(string clusterId, DescribeClusterNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterNodesResponse>(await DoRequestWithActionAsync("DescribeClusterNodes", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/nodes", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public DescribeClusterNodesResponse DescribeClusterNodes(string clusterId, DescribeClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterNodesWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeClusterNodesResponse> DescribeClusterNodesAsync(string clusterId, DescribeClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterNodesWithOptionsAsync(clusterId, request, runtime);
        }

        public DescribeAgilityTunnelAgentInfoResponse DescribeAgilityTunnelAgentInfoWithOptions(string token, DescribeAgilityTunnelAgentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAgilityTunnelAgentInfoResponse>(DoRequestWithAction("DescribeAgilityTunnelAgentInfo", "2018-04-18", "HTTPS", "GET", "Anonymous", "/agility/" + token + "/agent_info", null, request.Headers, null, runtime));
        }

        public async Task<DescribeAgilityTunnelAgentInfoResponse> DescribeAgilityTunnelAgentInfoWithOptionsAsync(string token, DescribeAgilityTunnelAgentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAgilityTunnelAgentInfoResponse>(await DoRequestWithActionAsync("DescribeAgilityTunnelAgentInfo", "2018-04-18", "HTTPS", "GET", "Anonymous", "/agility/" + token + "/agent_info", null, request.Headers, null, runtime));
        }

        public DescribeAgilityTunnelAgentInfoResponse DescribeAgilityTunnelAgentInfo(string token, DescribeAgilityTunnelAgentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAgilityTunnelAgentInfoWithOptions(token, request, runtime);
        }

        public async Task<DescribeAgilityTunnelAgentInfoResponse> DescribeAgilityTunnelAgentInfoAsync(string token, DescribeAgilityTunnelAgentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAgilityTunnelAgentInfoWithOptionsAsync(token, request, runtime);
        }

        public DeleteClusterNodeResponse DeleteClusterNodeWithOptions(string clusterId, string ip, DeleteClusterNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteClusterNodeResponse>(DoRequestWithAction("DeleteClusterNode", "2018-04-18", "HTTPS", "DELETE", "AK", "/clusters/" + clusterId + "/ip/" + ip, AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public async Task<DeleteClusterNodeResponse> DeleteClusterNodeWithOptionsAsync(string clusterId, string ip, DeleteClusterNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteClusterNodeResponse>(await DoRequestWithActionAsync("DeleteClusterNode", "2018-04-18", "HTTPS", "DELETE", "AK", "/clusters/" + clusterId + "/ip/" + ip, AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public DeleteClusterNodeResponse DeleteClusterNode(string clusterId, string ip, DeleteClusterNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterNodeWithOptions(clusterId, ip, request, runtime);
        }

        public async Task<DeleteClusterNodeResponse> DeleteClusterNodeAsync(string clusterId, string ip, DeleteClusterNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterNodeWithOptionsAsync(clusterId, ip, request, runtime);
        }

        public DescribeClusterNodeInfoWithInstanceResponse DescribeClusterNodeInfoWithInstanceWithOptions(string token, string instanceId, DescribeClusterNodeInfoWithInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterNodeInfoWithInstanceResponse>(DoRequestWithAction("DescribeClusterNodeInfoWithInstance", "2018-04-18", "HTTPS", "GET", "Anonymous", "/token/" + token + "/instance/" + instanceId + "/node_info", null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterNodeInfoWithInstanceResponse> DescribeClusterNodeInfoWithInstanceWithOptionsAsync(string token, string instanceId, DescribeClusterNodeInfoWithInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterNodeInfoWithInstanceResponse>(await DoRequestWithActionAsync("DescribeClusterNodeInfoWithInstance", "2018-04-18", "HTTPS", "GET", "Anonymous", "/token/" + token + "/instance/" + instanceId + "/node_info", null, request.Headers, null, runtime));
        }

        public DescribeClusterNodeInfoWithInstanceResponse DescribeClusterNodeInfoWithInstance(string token, string instanceId, DescribeClusterNodeInfoWithInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterNodeInfoWithInstanceWithOptions(token, instanceId, request, runtime);
        }

        public async Task<DescribeClusterNodeInfoWithInstanceResponse> DescribeClusterNodeInfoWithInstanceAsync(string token, string instanceId, DescribeClusterNodeInfoWithInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterNodeInfoWithInstanceWithOptionsAsync(token, instanceId, request, runtime);
        }

        public DescribeUserContainersResponse DescribeUserContainersWithOptions(string regionId, DescribeUserContainersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUserContainersResponse>(DoRequestWithAction("DescribeUserContainers", "2018-04-18", "HTTPS", "GET", "AK", "/region/" + regionId + "/containers", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public async Task<DescribeUserContainersResponse> DescribeUserContainersWithOptionsAsync(string regionId, DescribeUserContainersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUserContainersResponse>(await DoRequestWithActionAsync("DescribeUserContainers", "2018-04-18", "HTTPS", "GET", "AK", "/region/" + regionId + "/containers", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public DescribeUserContainersResponse DescribeUserContainers(string regionId, DescribeUserContainersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserContainersWithOptions(regionId, request, runtime);
        }

        public async Task<DescribeUserContainersResponse> DescribeUserContainersAsync(string regionId, DescribeUserContainersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserContainersWithOptionsAsync(regionId, request, runtime);
        }

        public CreateClusterTokenResponse CreateClusterTokenWithOptions(string clusterId, CreateClusterTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateClusterTokenResponse>(DoRequestWithAction("CreateClusterToken", "2018-04-18", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/token", null, request.Headers, null, runtime));
        }

        public async Task<CreateClusterTokenResponse> CreateClusterTokenWithOptionsAsync(string clusterId, CreateClusterTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateClusterTokenResponse>(await DoRequestWithActionAsync("CreateClusterToken", "2018-04-18", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/token", null, request.Headers, null, runtime));
        }

        public CreateClusterTokenResponse CreateClusterToken(string clusterId, CreateClusterTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterTokenWithOptions(clusterId, request, runtime);
        }

        public async Task<CreateClusterTokenResponse> CreateClusterTokenAsync(string clusterId, CreateClusterTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterTokenWithOptionsAsync(clusterId, request, runtime);
        }

        public DescribeClusterHostsResponse DescribeClusterHostsWithOptions(string clusterId, DescribeClusterHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterHostsResponse>(DoRequestWithAction("DescribeClusterHosts", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/hosts", null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterHostsResponse> DescribeClusterHostsWithOptionsAsync(string clusterId, DescribeClusterHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterHostsResponse>(await DoRequestWithActionAsync("DescribeClusterHosts", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/hosts", null, request.Headers, null, runtime));
        }

        public DescribeClusterHostsResponse DescribeClusterHosts(string clusterId, DescribeClusterHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterHostsWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeClusterHostsResponse> DescribeClusterHostsAsync(string clusterId, DescribeClusterHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterHostsWithOptionsAsync(clusterId, request, runtime);
        }

        public DescribeKubernetesTemplatesResponse DescribeKubernetesTemplatesWithOptions(DescribeKubernetesTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeKubernetesTemplatesResponse>(DoRequestWithAction("DescribeKubernetesTemplates", "2018-04-18", "HTTPS", "GET", "AK", "/k8s/templates", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public async Task<DescribeKubernetesTemplatesResponse> DescribeKubernetesTemplatesWithOptionsAsync(DescribeKubernetesTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeKubernetesTemplatesResponse>(await DoRequestWithActionAsync("DescribeKubernetesTemplates", "2018-04-18", "HTTPS", "GET", "AK", "/k8s/templates", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public DescribeKubernetesTemplatesResponse DescribeKubernetesTemplates(DescribeKubernetesTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKubernetesTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeKubernetesTemplatesResponse> DescribeKubernetesTemplatesAsync(DescribeKubernetesTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKubernetesTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeTemplatesResponse DescribeTemplatesWithOptions(DescribeTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTemplatesResponse>(DoRequestWithAction("DescribeTemplates", "2018-04-18", "HTTPS", "GET", "AK", "/templates", null, request.Headers, null, runtime));
        }

        public async Task<DescribeTemplatesResponse> DescribeTemplatesWithOptionsAsync(DescribeTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTemplatesResponse>(await DoRequestWithActionAsync("DescribeTemplates", "2018-04-18", "HTTPS", "GET", "AK", "/templates", null, request.Headers, null, runtime));
        }

        public DescribeTemplatesResponse DescribeTemplates(DescribeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeTemplatesResponse> DescribeTemplatesAsync(DescribeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeClusterScaledNodeResponse DescribeClusterScaledNodeWithOptions(string clusterId, DescribeClusterScaledNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterScaledNodeResponse>(DoRequestWithAction("DescribeClusterScaledNode", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/scaled_nodes/", null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterScaledNodeResponse> DescribeClusterScaledNodeWithOptionsAsync(string clusterId, DescribeClusterScaledNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterScaledNodeResponse>(await DoRequestWithActionAsync("DescribeClusterScaledNode", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/scaled_nodes/", null, request.Headers, null, runtime));
        }

        public DescribeClusterScaledNodeResponse DescribeClusterScaledNode(string clusterId, DescribeClusterScaledNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterScaledNodeWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeClusterScaledNodeResponse> DescribeClusterScaledNodeAsync(string clusterId, DescribeClusterScaledNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterScaledNodeWithOptionsAsync(clusterId, request, runtime);
        }

        public CallbackClusterTokenResponse CallbackClusterTokenWithOptions(string token, string reqOnce, CallbackClusterTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CallbackClusterTokenResponse>(DoRequestWithAction("CallbackClusterToken", "2018-04-18", "HTTPS", "POST", "Anonymous", "/token/" + token + "/req_once/" + reqOnce + "/callback", null, request.Headers, null, runtime));
        }

        public async Task<CallbackClusterTokenResponse> CallbackClusterTokenWithOptionsAsync(string token, string reqOnce, CallbackClusterTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CallbackClusterTokenResponse>(await DoRequestWithActionAsync("CallbackClusterToken", "2018-04-18", "HTTPS", "POST", "Anonymous", "/token/" + token + "/req_once/" + reqOnce + "/callback", null, request.Headers, null, runtime));
        }

        public CallbackClusterTokenResponse CallbackClusterToken(string token, string reqOnce, CallbackClusterTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CallbackClusterTokenWithOptions(token, reqOnce, request, runtime);
        }

        public async Task<CallbackClusterTokenResponse> CallbackClusterTokenAsync(string token, string reqOnce, CallbackClusterTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CallbackClusterTokenWithOptionsAsync(token, reqOnce, request, runtime);
        }

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(DoRequestWithAction("DescribeImages", "2018-04-18", "HTTPS", "GET", "AK", "/images", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRequestWithActionAsync("DescribeImages", "2018-04-18", "HTTPS", "GET", "AK", "/images", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImagesWithOptions(request, runtime);
        }

        public async Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImagesWithOptionsAsync(request, runtime);
        }

        public DescribeClusterLogsResponse DescribeClusterLogsWithOptions(string clusterId, DescribeClusterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterLogsResponse>(DoRequestWithAction("DescribeClusterLogs", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/logs", null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsWithOptionsAsync(string clusterId, DescribeClusterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterLogsResponse>(await DoRequestWithActionAsync("DescribeClusterLogs", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/logs", null, request.Headers, null, runtime));
        }

        public DescribeClusterLogsResponse DescribeClusterLogs(string clusterId, DescribeClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterLogsWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsAsync(string clusterId, DescribeClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterLogsWithOptionsAsync(clusterId, request, runtime);
        }

        public DescribeClusterServicesResponse DescribeClusterServicesWithOptions(string clusterId, DescribeClusterServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterServicesResponse>(DoRequestWithAction("DescribeClusterServices", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/services", null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterServicesResponse> DescribeClusterServicesWithOptionsAsync(string clusterId, DescribeClusterServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterServicesResponse>(await DoRequestWithActionAsync("DescribeClusterServices", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/services", null, request.Headers, null, runtime));
        }

        public DescribeClusterServicesResponse DescribeClusterServices(string clusterId, DescribeClusterServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServicesWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeClusterServicesResponse> DescribeClusterServicesAsync(string clusterId, DescribeClusterServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServicesWithOptionsAsync(clusterId, request, runtime);
        }

        public GetTriggerHookResponse GetTriggerHookWithOptions(string clusterId, string projectId, GetTriggerHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTriggerHookResponse>(DoRequestWithAction("GetTriggerHook", "2018-04-18", "HTTPS", "GET", "AK", "/hook/trigger/" + clusterId + "/" + projectId, null, request.Headers, null, runtime));
        }

        public async Task<GetTriggerHookResponse> GetTriggerHookWithOptionsAsync(string clusterId, string projectId, GetTriggerHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTriggerHookResponse>(await DoRequestWithActionAsync("GetTriggerHook", "2018-04-18", "HTTPS", "GET", "AK", "/hook/trigger/" + clusterId + "/" + projectId, null, request.Headers, null, runtime));
        }

        public GetTriggerHookResponse GetTriggerHook(string clusterId, string projectId, GetTriggerHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTriggerHookWithOptions(clusterId, projectId, request, runtime);
        }

        public async Task<GetTriggerHookResponse> GetTriggerHookAsync(string clusterId, string projectId, GetTriggerHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTriggerHookWithOptionsAsync(clusterId, projectId, request, runtime);
        }

        public DescribeTemplateAttributeResponse DescribeTemplateAttributeWithOptions(string templateId, DescribeTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(DoRequestWithAction("DescribeTemplateAttribute", "2018-04-18", "HTTPS", "GET", "AK", "/templates/" + templateId, null, request.Headers, null, runtime));
        }

        public async Task<DescribeTemplateAttributeResponse> DescribeTemplateAttributeWithOptionsAsync(string templateId, DescribeTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(await DoRequestWithActionAsync("DescribeTemplateAttribute", "2018-04-18", "HTTPS", "GET", "AK", "/templates/" + templateId, null, request.Headers, null, runtime));
        }

        public DescribeTemplateAttributeResponse DescribeTemplateAttribute(string templateId, DescribeTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTemplateAttributeWithOptions(templateId, request, runtime);
        }

        public async Task<DescribeTemplateAttributeResponse> DescribeTemplateAttributeAsync(string templateId, DescribeTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTemplateAttributeWithOptionsAsync(templateId, request, runtime);
        }

        public DescribeClusterCertsResponse DescribeClusterCertsWithOptions(string clusterId, DescribeClusterCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterCertsResponse>(DoRequestWithAction("DescribeClusterCerts", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/certs", null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterCertsResponse> DescribeClusterCertsWithOptionsAsync(string clusterId, DescribeClusterCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterCertsResponse>(await DoRequestWithActionAsync("DescribeClusterCerts", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/certs", null, request.Headers, null, runtime));
        }

        public DescribeClusterCertsResponse DescribeClusterCerts(string clusterId, DescribeClusterCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterCertsWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeClusterCertsResponse> DescribeClusterCertsAsync(string clusterId, DescribeClusterCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterCertsWithOptionsAsync(clusterId, request, runtime);
        }

        public DescribeClusterNodeInfoResponse DescribeClusterNodeInfoWithOptions(string token, DescribeClusterNodeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterNodeInfoResponse>(DoRequestWithAction("DescribeClusterNodeInfo", "2018-04-18", "HTTPS", "GET", "Anonymous", "/token/" + token + "/node_info", null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterNodeInfoResponse> DescribeClusterNodeInfoWithOptionsAsync(string token, DescribeClusterNodeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterNodeInfoResponse>(await DoRequestWithActionAsync("DescribeClusterNodeInfo", "2018-04-18", "HTTPS", "GET", "Anonymous", "/token/" + token + "/node_info", null, request.Headers, null, runtime));
        }

        public DescribeClusterNodeInfoResponse DescribeClusterNodeInfo(string token, DescribeClusterNodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterNodeInfoWithOptions(token, request, runtime);
        }

        public async Task<DescribeClusterNodeInfoResponse> DescribeClusterNodeInfoAsync(string token, DescribeClusterNodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterNodeInfoWithOptionsAsync(token, request, runtime);
        }

        public DeleteClusterResponse DeleteClusterWithOptions(string clusterId, DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteClusterResponse>(DoRequestWithAction("DeleteCluster", "2018-04-18", "HTTPS", "DELETE", "AK", "/clusters/" + clusterId, null, request.Headers, null, runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(string clusterId, DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteClusterResponse>(await DoRequestWithActionAsync("DeleteCluster", "2018-04-18", "HTTPS", "DELETE", "AK", "/clusters/" + clusterId, null, request.Headers, null, runtime));
        }

        public DeleteClusterResponse DeleteCluster(string clusterId, DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterWithOptions(clusterId, request, runtime);
        }

        public async Task<DeleteClusterResponse> DeleteClusterAsync(string clusterId, DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterWithOptionsAsync(clusterId, request, runtime);
        }

        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateClusterResponse>(DoRequestWithAction("CreateCluster", "2018-04-18", "HTTPS", "POST", "AK", "/clusters", null, request.Headers, null, runtime));
        }

        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateClusterResponse>(await DoRequestWithActionAsync("CreateCluster", "2018-04-18", "HTTPS", "POST", "AK", "/clusters", null, request.Headers, null, runtime));
        }

        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithOptions(request, runtime);
        }

        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithOptionsAsync(request, runtime);
        }

        public DescribeClusterDetailResponse DescribeClusterDetailWithOptions(string clusterId, DescribeClusterDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterDetailResponse>(DoRequestWithAction("DescribeClusterDetail", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId, null, request.Headers, null, runtime));
        }

        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailWithOptionsAsync(string clusterId, DescribeClusterDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterDetailResponse>(await DoRequestWithActionAsync("DescribeClusterDetail", "2018-04-18", "HTTPS", "GET", "AK", "/clusters/" + clusterId, null, request.Headers, null, runtime));
        }

        public DescribeClusterDetailResponse DescribeClusterDetail(string clusterId, DescribeClusterDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterDetailWithOptions(clusterId, request, runtime);
        }

        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailAsync(string clusterId, DescribeClusterDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterDetailWithOptionsAsync(clusterId, request, runtime);
        }

        public DescribeClustersResponse DescribeClustersWithOptions(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClustersResponse>(DoRequestWithAction("DescribeClusters", "2018-04-18", "HTTPS", "GET", "AK", "/clusters", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public async Task<DescribeClustersResponse> DescribeClustersWithOptionsAsync(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClustersResponse>(await DoRequestWithActionAsync("DescribeClusters", "2018-04-18", "HTTPS", "GET", "AK", "/clusters", AlibabaCloud.TeaUtil.Common.StringifyMapValue(request.Query.ToMap()), request.Headers, null, runtime));
        }

        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClustersWithOptions(request, runtime);
        }

        public async Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClustersWithOptionsAsync(request, runtime);
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

    }
}
