// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Adcp20220101.Models;

namespace AlibabaCloud.SDK.Adcp20220101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "adcp.cn-beijing.aliyuncs.com"},
                {"cn-zhangjiakou", "adcp.cn-zhangjiakou.aliyuncs.com"},
                {"cn-hangzhou", "adcp.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "adcp.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "adcp.cn-shenzhen.aliyuncs.com"},
                {"cn-heyuan", "adcp.cn-heyuan.aliyuncs.com"},
                {"cn-hongkong", "adcp.cn-hongkong.aliyuncs.com"},
                {"ap-northeast-1", "adcp.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-1", "adcp.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "adcp.ap-southeast-5.aliyuncs.com"},
                {"ap-south-1", "adcp.ap-south-1.aliyuncs.com"},
                {"ap-southeast-2", "adcp.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "adcp.ap-southeast-3.aliyuncs.com"},
                {"cn-chengdu", "adcp-vpc.cn-chengdu.aliyuncs.com"},
                {"cn-huhehaote", "adcp.cn-huhehaote.aliyuncs.com"},
                {"cn-qingdao", "adcp.cn-qingdao.aliyuncs.com"},
                {"cn-shanghai-finance-1", "adcp-vpc.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-wulanchabu", "adcp.cn-wulanchabu.aliyuncs.com"},
                {"eu-central-1", "adcp.eu-central-1.aliyuncs.com"},
                {"eu-west-1", "adcp-vpc.eu-west-1.aliyuncs.com"},
                {"me-east-1", "adcp.me-east-1.aliyuncs.com"},
                {"us-east-1", "adcp.us-east-1.aliyuncs.com"},
                {"us-west-1", "adcp.us-west-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("adcp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AttachClusterToHubResponse AttachClusterToHubWithOptions(AttachClusterToHubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachToMesh))
            {
                query["AttachToMesh"] = request.AttachToMesh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachClusterToHub",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachClusterToHubResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachClusterToHubResponse> AttachClusterToHubWithOptionsAsync(AttachClusterToHubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachToMesh))
            {
                query["AttachToMesh"] = request.AttachToMesh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachClusterToHub",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachClusterToHubResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachClusterToHubResponse AttachClusterToHub(AttachClusterToHubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachClusterToHubWithOptions(request, runtime);
        }

        public async Task<AttachClusterToHubResponse> AttachClusterToHubAsync(AttachClusterToHubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachClusterToHubWithOptionsAsync(request, runtime);
        }

        public CreateHubClusterResponse CreateHubClusterWithOptions(CreateHubClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateHubClusterShrinkRequest request = new CreateHubClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterConfiguration))
            {
                request.ClusterConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterConfiguration, "ClusterConfiguration", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterConfigurationShrink))
            {
                query["ClusterConfiguration"] = request.ClusterConfigurationShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerPublicEip))
            {
                body["ApiServerPublicEip"] = request.ApiServerPublicEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogEnabled))
            {
                body["AuditLogEnabled"] = request.AuditLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                body["IsEnterpriseSecurityGroup"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                body["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHubCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHubClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateHubClusterResponse> CreateHubClusterWithOptionsAsync(CreateHubClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateHubClusterShrinkRequest request = new CreateHubClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterConfiguration))
            {
                request.ClusterConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterConfiguration, "ClusterConfiguration", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterConfigurationShrink))
            {
                query["ClusterConfiguration"] = request.ClusterConfigurationShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerPublicEip))
            {
                body["ApiServerPublicEip"] = request.ApiServerPublicEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogEnabled))
            {
                body["AuditLogEnabled"] = request.AuditLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                body["IsEnterpriseSecurityGroup"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                body["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHubCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHubClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateHubClusterResponse CreateHubCluster(CreateHubClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHubClusterWithOptions(request, runtime);
        }

        public async Task<CreateHubClusterResponse> CreateHubClusterAsync(CreateHubClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHubClusterWithOptionsAsync(request, runtime);
        }

        public DeleteHubClusterResponse DeleteHubClusterWithOptions(DeleteHubClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteHubClusterShrinkRequest request = new DeleteHubClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainResources))
            {
                request.RetainResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainResources, "RetainResources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResourcesShrink))
            {
                query["RetainResources"] = request.RetainResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHubCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHubClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteHubClusterResponse> DeleteHubClusterWithOptionsAsync(DeleteHubClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteHubClusterShrinkRequest request = new DeleteHubClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainResources))
            {
                request.RetainResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainResources, "RetainResources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResourcesShrink))
            {
                query["RetainResources"] = request.RetainResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHubCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHubClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteHubClusterResponse DeleteHubCluster(DeleteHubClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHubClusterWithOptions(request, runtime);
        }

        public async Task<DeleteHubClusterResponse> DeleteHubClusterAsync(DeleteHubClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHubClusterWithOptionsAsync(request, runtime);
        }

        public DescribeHubClusterDetailsResponse DescribeHubClusterDetailsWithOptions(DescribeHubClusterDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterDetails",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHubClusterDetailsResponse> DescribeHubClusterDetailsWithOptionsAsync(DescribeHubClusterDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterDetails",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHubClusterDetailsResponse DescribeHubClusterDetails(DescribeHubClusterDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHubClusterDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeHubClusterDetailsResponse> DescribeHubClusterDetailsAsync(DescribeHubClusterDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHubClusterDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeHubClusterKubeconfigResponse DescribeHubClusterKubeconfigWithOptions(DescribeHubClusterKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterKubeconfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterKubeconfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHubClusterKubeconfigResponse> DescribeHubClusterKubeconfigWithOptionsAsync(DescribeHubClusterKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterKubeconfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterKubeconfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHubClusterKubeconfigResponse DescribeHubClusterKubeconfig(DescribeHubClusterKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHubClusterKubeconfigWithOptions(request, runtime);
        }

        public async Task<DescribeHubClusterKubeconfigResponse> DescribeHubClusterKubeconfigAsync(DescribeHubClusterKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHubClusterKubeconfigWithOptionsAsync(request, runtime);
        }

        public DescribeHubClusterLogsResponse DescribeHubClusterLogsWithOptions(DescribeHubClusterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterLogs",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHubClusterLogsResponse> DescribeHubClusterLogsWithOptionsAsync(DescribeHubClusterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterLogs",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHubClusterLogsResponse DescribeHubClusterLogs(DescribeHubClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHubClusterLogsWithOptions(request, runtime);
        }

        public async Task<DescribeHubClusterLogsResponse> DescribeHubClusterLogsAsync(DescribeHubClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHubClusterLogsWithOptionsAsync(request, runtime);
        }

        public DescribeHubClustersResponse DescribeHubClustersWithOptions(DescribeHubClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["Profile"] = request.Profile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClustersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHubClustersResponse> DescribeHubClustersWithOptionsAsync(DescribeHubClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["Profile"] = request.Profile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHubClustersResponse DescribeHubClusters(DescribeHubClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHubClustersWithOptions(request, runtime);
        }

        public async Task<DescribeHubClustersResponse> DescribeHubClustersAsync(DescribeHubClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHubClustersWithOptionsAsync(request, runtime);
        }

        public DescribeManagedClustersResponse DescribeManagedClustersWithOptions(DescribeManagedClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeManagedClusters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeManagedClustersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeManagedClustersResponse> DescribeManagedClustersWithOptionsAsync(DescribeManagedClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeManagedClusters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeManagedClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeManagedClustersResponse DescribeManagedClusters(DescribeManagedClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeManagedClustersWithOptions(request, runtime);
        }

        public async Task<DescribeManagedClustersResponse> DescribeManagedClustersAsync(DescribeManagedClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeManagedClustersWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DetachClusterFromHubResponse DetachClusterFromHubWithOptions(DetachClusterFromHubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetachFromMesh))
            {
                query["DetachFromMesh"] = request.DetachFromMesh;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachClusterFromHub",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachClusterFromHubResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachClusterFromHubResponse> DetachClusterFromHubWithOptionsAsync(DetachClusterFromHubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetachFromMesh))
            {
                query["DetachFromMesh"] = request.DetachFromMesh;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachClusterFromHub",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachClusterFromHubResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetachClusterFromHubResponse DetachClusterFromHub(DetachClusterFromHubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachClusterFromHubWithOptions(request, runtime);
        }

        public async Task<DetachClusterFromHubResponse> DetachClusterFromHubAsync(DetachClusterFromHubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachClusterFromHubWithOptionsAsync(request, runtime);
        }

        public UpdateHubClusterFeatureResponse UpdateHubClusterFeatureWithOptions(UpdateHubClusterFeatureRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHubClusterFeatureShrinkRequest request = new UpdateHubClusterFeatureShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Units))
            {
                request.UnitsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Units, "Units", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                query["ApiServerEipId"] = request.ApiServerEipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogEnabled))
            {
                query["AuditLogEnabled"] = request.AuditLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableArgoCD))
            {
                query["EnableArgoCD"] = request.EnableArgoCD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMesh))
            {
                query["EnableMesh"] = request.EnableMesh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceLimit))
            {
                query["PriceLimit"] = request.PriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicApiServerEnabled))
            {
                query["PublicApiServerEnabled"] = request.PublicApiServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMode))
            {
                query["ScheduleMode"] = request.ScheduleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerEnabled))
            {
                query["ServerEnabled"] = request.ServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitsShrink))
            {
                query["Units"] = request.UnitsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHubClusterFeature",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHubClusterFeatureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHubClusterFeatureResponse> UpdateHubClusterFeatureWithOptionsAsync(UpdateHubClusterFeatureRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHubClusterFeatureShrinkRequest request = new UpdateHubClusterFeatureShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Units))
            {
                request.UnitsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Units, "Units", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                query["ApiServerEipId"] = request.ApiServerEipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogEnabled))
            {
                query["AuditLogEnabled"] = request.AuditLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableArgoCD))
            {
                query["EnableArgoCD"] = request.EnableArgoCD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMesh))
            {
                query["EnableMesh"] = request.EnableMesh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceLimit))
            {
                query["PriceLimit"] = request.PriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicApiServerEnabled))
            {
                query["PublicApiServerEnabled"] = request.PublicApiServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMode))
            {
                query["ScheduleMode"] = request.ScheduleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerEnabled))
            {
                query["ServerEnabled"] = request.ServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitsShrink))
            {
                query["Units"] = request.UnitsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHubClusterFeature",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHubClusterFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHubClusterFeatureResponse UpdateHubClusterFeature(UpdateHubClusterFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHubClusterFeatureWithOptions(request, runtime);
        }

        public async Task<UpdateHubClusterFeatureResponse> UpdateHubClusterFeatureAsync(UpdateHubClusterFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHubClusterFeatureWithOptionsAsync(request, runtime);
        }

    }
}
