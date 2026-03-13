// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Slb20130221.Models;

namespace AlibabaCloud.SDK.Slb20130221
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "slb.aliyuncs.com"},
                {"cn-beijing", "slb.aliyuncs.com"},
                {"cn-hangzhou", "slb.aliyuncs.com"},
                {"cn-shanghai", "slb.aliyuncs.com"},
                {"cn-shenzhen", "slb.aliyuncs.com"},
                {"cn-hongkong", "slb.aliyuncs.com"},
                {"ap-southeast-1", "slb.aliyuncs.com"},
                {"us-east-1", "slb.aliyuncs.com"},
                {"us-west-1", "slb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "slb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "slb.aliyuncs.com"},
                {"cn-north-2-gov-1", "slb.aliyuncs.com"},
                {"ap-northeast-2-pop", "slb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "slb.aliyuncs.com"},
                {"cn-beijing-gov-1", "slb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "slb.aliyuncs.com"},
                {"cn-edge-1", "slb.aliyuncs.com"},
                {"cn-fujian", "slb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "slb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "slb.aliyuncs.com"},
                {"cn-hangzhou-finance", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "slb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "slb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "slb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "slb-api.cn-qingdao-nebula.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "slb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "slb.aliyuncs.com"},
                {"cn-shanghai-inner", "slb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "slb.aliyuncs.com"},
                {"cn-shenzhen-inner", "slb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "slb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "slb.aliyuncs.com"},
                {"cn-wuhan", "slb.aliyuncs.com"},
                {"cn-yushanfang", "slb.aliyuncs.com"},
                {"cn-zhangbei", "slb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "slb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "slb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "slb.aliyuncs.com"},
                {"eu-west-1-oxs", "slb.aliyuncs.com"},
                {"rus-west-1-pop", "slb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("slb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBackendServersResponse
        /// </returns>
        public AddBackendServersResponse AddBackendServersWithOptions(AddBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBackendServers",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBackendServersResponse
        /// </returns>
        public async Task<AddBackendServersResponse> AddBackendServersWithOptionsAsync(AddBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBackendServers",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBackendServersResponse
        /// </returns>
        public AddBackendServersResponse AddBackendServers(AddBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBackendServersResponse
        /// </returns>
        public async Task<AddBackendServersResponse> AddBackendServersAsync(AddBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerResponse
        /// </returns>
        public CreateLoadBalancerResponse CreateLoadBalancerWithOptions(CreateLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPublicAddress))
            {
                query["IsPublicAddress"] = request.IsPublicAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerMode))
            {
                query["LoadBalancerMode"] = request.LoadBalancerMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancer",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerResponse
        /// </returns>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerWithOptionsAsync(CreateLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPublicAddress))
            {
                query["IsPublicAddress"] = request.IsPublicAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerMode))
            {
                query["LoadBalancerMode"] = request.LoadBalancerMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancer",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerResponse
        /// </returns>
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerResponse
        /// </returns>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建HTTP监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPListenerResponse
        /// </returns>
        public CreateLoadBalancerHTTPListenerResponse CreateLoadBalancerHTTPListenerWithOptions(CreateLoadBalancerHTTPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostId))
            {
                query["HostId"] = request.HostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerStatus))
            {
                query["ListenerStatus"] = request.ListenerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerHTTPListener",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建HTTP监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerHTTPListenerResponse> CreateLoadBalancerHTTPListenerWithOptionsAsync(CreateLoadBalancerHTTPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostId))
            {
                query["HostId"] = request.HostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerStatus))
            {
                query["ListenerStatus"] = request.ListenerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerHTTPListener",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建HTTP监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPListenerResponse
        /// </returns>
        public CreateLoadBalancerHTTPListenerResponse CreateLoadBalancerHTTPListener(CreateLoadBalancerHTTPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerHTTPListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建HTTP监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerHTTPListenerResponse> CreateLoadBalancerHTTPListenerAsync(CreateLoadBalancerHTTPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerHTTPListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建TCP监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerTCPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerTCPListenerResponse
        /// </returns>
        public CreateLoadBalancerTCPListenerResponse CreateLoadBalancerTCPListenerWithOptions(CreateLoadBalancerTCPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectPort))
            {
                query["ConnectPort"] = request.ConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectTimeout))
            {
                query["ConnectTimeout"] = request.ConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstablishedTimeout))
            {
                query["EstablishedTimeout"] = request.EstablishedTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerStatus))
            {
                query["ListenerStatus"] = request.ListenerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConnection))
            {
                query["MaxConnection"] = request.MaxConnection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersistenceTimeout))
            {
                query["PersistenceTimeout"] = request.PersistenceTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerTCPListener",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerTCPListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建TCP监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerTCPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerTCPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerTCPListenerResponse> CreateLoadBalancerTCPListenerWithOptionsAsync(CreateLoadBalancerTCPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectPort))
            {
                query["ConnectPort"] = request.ConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectTimeout))
            {
                query["ConnectTimeout"] = request.ConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstablishedTimeout))
            {
                query["EstablishedTimeout"] = request.EstablishedTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerStatus))
            {
                query["ListenerStatus"] = request.ListenerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConnection))
            {
                query["MaxConnection"] = request.MaxConnection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersistenceTimeout))
            {
                query["PersistenceTimeout"] = request.PersistenceTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerTCPListener",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerTCPListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建TCP监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerTCPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerTCPListenerResponse
        /// </returns>
        public CreateLoadBalancerTCPListenerResponse CreateLoadBalancerTCPListener(CreateLoadBalancerTCPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerTCPListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建TCP监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerTCPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerTCPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerTCPListenerResponse> CreateLoadBalancerTCPListenerAsync(CreateLoadBalancerTCPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerTCPListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerResponse
        /// </returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerWithOptions(DeleteLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancer",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoadBalancerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerResponse
        /// </returns>
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerWithOptionsAsync(DeleteLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancer",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoadBalancerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerResponse
        /// </returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoadBalancerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerResponse
        /// </returns>
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoadBalancerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerListenerResponse
        /// </returns>
        public DeleteLoadBalancerListenerResponse DeleteLoadBalancerListenerWithOptions(DeleteLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancerListener",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoadBalancerListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerListenerResponse
        /// </returns>
        public async Task<DeleteLoadBalancerListenerResponse> DeleteLoadBalancerListenerWithOptionsAsync(DeleteLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancerListener",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoadBalancerListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerListenerResponse
        /// </returns>
        public DeleteLoadBalancerListenerResponse DeleteLoadBalancerListener(DeleteLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoadBalancerListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerListenerResponse
        /// </returns>
        public async Task<DeleteLoadBalancerListenerResponse> DeleteLoadBalancerListenerAsync(DeleteLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackendServersResponse
        /// </returns>
        public DescribeBackendServersResponse DescribeBackendServersWithOptions(DescribeBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackendServers",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackendServersResponse
        /// </returns>
        public async Task<DescribeBackendServersResponse> DescribeBackendServersWithOptionsAsync(DescribeBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackendServers",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackendServersResponse
        /// </returns>
        public DescribeBackendServersResponse DescribeBackendServers(DescribeBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackendServersResponse
        /// </returns>
        public async Task<DescribeBackendServersResponse> DescribeBackendServersAsync(DescribeBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerAttributeResponse DescribeLoadBalancerAttributeWithOptions(DescribeLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerAttributeResponse> DescribeLoadBalancerAttributeWithOptionsAsync(DescribeLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerAttributeResponse DescribeLoadBalancerAttribute(DescribeLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerAttributeResponse> DescribeLoadBalancerAttributeAsync(DescribeLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP监听配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerHTTPListenerAttributeResponse DescribeLoadBalancerHTTPListenerAttributeWithOptions(DescribeLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerHTTPListenerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP监听配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerHTTPListenerAttributeResponse> DescribeLoadBalancerHTTPListenerAttributeWithOptionsAsync(DescribeLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerHTTPListenerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP监听配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerHTTPListenerAttributeResponse DescribeLoadBalancerHTTPListenerAttribute(DescribeLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerHTTPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询HTTP监听配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerHTTPListenerAttributeResponse> DescribeLoadBalancerHTTPListenerAttributeAsync(DescribeLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerHTTPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询TCP监听配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerTCPListenerAttributeResponse DescribeLoadBalancerTCPListenerAttributeWithOptions(DescribeLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerTCPListenerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerTCPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询TCP监听配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerTCPListenerAttributeResponse> DescribeLoadBalancerTCPListenerAttributeWithOptionsAsync(DescribeLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerTCPListenerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerTCPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询TCP监听配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerTCPListenerAttributeResponse DescribeLoadBalancerTCPListenerAttribute(DescribeLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerTCPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询TCP监听配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerTCPListenerAttributeResponse> DescribeLoadBalancerTCPListenerAttributeAsync(DescribeLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerTCPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>slb实例批量查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancersResponse
        /// </returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersWithOptions(DescribeLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                query["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIntranetAddress))
            {
                query["ServerIntranetAddress"] = request.ServerIntranetAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlaveZoneId))
            {
                query["SlaveZoneId"] = request.SlaveZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancers",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>slb实例批量查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancersResponse
        /// </returns>
        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancersWithOptionsAsync(DescribeLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                query["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIntranetAddress))
            {
                query["ServerIntranetAddress"] = request.ServerIntranetAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlaveZoneId))
            {
                query["SlaveZoneId"] = request.SlaveZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancers",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>slb实例批量查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancersResponse
        /// </returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>slb实例批量查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancersResponse
        /// </returns>
        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询可用地域</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2013-02-21",
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
        /// <para>查询可用地域</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2013-02-21",
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
        /// <para>查询可用地域</para>
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
        /// <para>查询可用地域</para>
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
        /// <para>删除默认服务器组的后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveBackendServersResponse
        /// </returns>
        public RemoveBackendServersResponse RemoveBackendServersWithOptions(RemoveBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveBackendServers",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除默认服务器组的后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveBackendServersResponse
        /// </returns>
        public async Task<RemoveBackendServersResponse> RemoveBackendServersWithOptionsAsync(RemoveBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveBackendServers",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除默认服务器组的后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveBackendServersResponse
        /// </returns>
        public RemoveBackendServersResponse RemoveBackendServers(RemoveBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除默认服务器组的后端服务器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveBackendServersResponse
        /// </returns>
        public async Task<RemoveBackendServersResponse> RemoveBackendServersAsync(RemoveBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新http监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerHTTPListenerAttributeResponse SetLoadBalancerHTTPListenerAttributeWithOptions(SetLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostId))
            {
                query["HostId"] = request.HostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerHTTPListenerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新http监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerHTTPListenerAttributeResponse> SetLoadBalancerHTTPListenerAttributeWithOptionsAsync(SetLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostId))
            {
                query["HostId"] = request.HostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerHTTPListenerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新http监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerHTTPListenerAttributeResponse SetLoadBalancerHTTPListenerAttribute(SetLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerHTTPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新http监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerHTTPListenerAttributeResponse> SetLoadBalancerHTTPListenerAttributeAsync(SetLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerHTTPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改监听状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerListenerStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerListenerStatusResponse
        /// </returns>
        public SetLoadBalancerListenerStatusResponse SetLoadBalancerListenerStatusWithOptions(SetLoadBalancerListenerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostId))
            {
                query["HostId"] = request.HostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerStatus))
            {
                query["ListenerStatus"] = request.ListenerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerListenerStatus",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerListenerStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改监听状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerListenerStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerListenerStatusResponse
        /// </returns>
        public async Task<SetLoadBalancerListenerStatusResponse> SetLoadBalancerListenerStatusWithOptionsAsync(SetLoadBalancerListenerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostId))
            {
                query["HostId"] = request.HostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerStatus))
            {
                query["ListenerStatus"] = request.ListenerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerListenerStatus",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerListenerStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改监听状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerListenerStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerListenerStatusResponse
        /// </returns>
        public SetLoadBalancerListenerStatusResponse SetLoadBalancerListenerStatus(SetLoadBalancerListenerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerListenerStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改监听状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerListenerStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerListenerStatusResponse
        /// </returns>
        public async Task<SetLoadBalancerListenerStatusResponse> SetLoadBalancerListenerStatusAsync(SetLoadBalancerListenerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerListenerStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerNameResponse
        /// </returns>
        public SetLoadBalancerNameResponse SetLoadBalancerNameWithOptions(SetLoadBalancerNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerName",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerNameResponse
        /// </returns>
        public async Task<SetLoadBalancerNameResponse> SetLoadBalancerNameWithOptionsAsync(SetLoadBalancerNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerName",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerNameResponse
        /// </returns>
        public SetLoadBalancerNameResponse SetLoadBalancerName(SetLoadBalancerNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerNameResponse
        /// </returns>
        public async Task<SetLoadBalancerNameResponse> SetLoadBalancerNameAsync(SetLoadBalancerNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerStatusResponse
        /// </returns>
        public SetLoadBalancerStatusResponse SetLoadBalancerStatusWithOptions(SetLoadBalancerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                query["LoadBalancerStatus"] = request.LoadBalancerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerStatus",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerStatusResponse
        /// </returns>
        public async Task<SetLoadBalancerStatusResponse> SetLoadBalancerStatusWithOptionsAsync(SetLoadBalancerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                query["LoadBalancerStatus"] = request.LoadBalancerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerStatus",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerStatusResponse
        /// </returns>
        public SetLoadBalancerStatusResponse SetLoadBalancerStatus(SetLoadBalancerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerStatusResponse
        /// </returns>
        public async Task<SetLoadBalancerStatusResponse> SetLoadBalancerStatusAsync(SetLoadBalancerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新tcp监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerTCPListenerAttributeResponse SetLoadBalancerTCPListenerAttributeWithOptions(SetLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectPort))
            {
                query["ConnectPort"] = request.ConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectTimeout))
            {
                query["ConnectTimeout"] = request.ConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostId))
            {
                query["HostId"] = request.HostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersistenceTimeout))
            {
                query["PersistenceTimeout"] = request.PersistenceTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerTCPListenerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerTCPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新tcp监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerTCPListenerAttributeResponse> SetLoadBalancerTCPListenerAttributeWithOptionsAsync(SetLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectPort))
            {
                query["ConnectPort"] = request.ConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectTimeout))
            {
                query["ConnectTimeout"] = request.ConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostId))
            {
                query["HostId"] = request.HostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersistenceTimeout))
            {
                query["PersistenceTimeout"] = request.PersistenceTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerTCPListenerAttribute",
                Version = "2013-02-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerTCPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新tcp监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerTCPListenerAttributeResponse SetLoadBalancerTCPListenerAttribute(SetLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerTCPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新tcp监听</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerTCPListenerAttributeResponse> SetLoadBalancerTCPListenerAttributeAsync(SetLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerTCPListenerAttributeWithOptionsAsync(request, runtime);
        }

    }
}
