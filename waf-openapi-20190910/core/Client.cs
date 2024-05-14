// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Waf_openapi20190910.Models;

namespace AlibabaCloud.SDK.Waf_openapi20190910
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-chengdu", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-zhangjiakou", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-huhehaote", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-heyuan", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-wulanchabu", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-north-2-gov-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("waf-openapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request CreateCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateResponse
         */
        public CreateCertificateResponse CreateCertificateWithOptions(CreateCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificate))
            {
                query["Certificate"] = request.Certificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateName))
            {
                query["CertificateName"] = request.CertificateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateResponse
         */
        public async Task<CreateCertificateResponse> CreateCertificateWithOptionsAsync(CreateCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificate))
            {
                query["Certificate"] = request.Certificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateName))
            {
                query["CertificateName"] = request.CertificateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateCertificateRequest
         * @return CreateCertificateResponse
         */
        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateWithOptions(request, runtime);
        }

        /**
         * @param request CreateCertificateRequest
         * @return CreateCertificateResponse
         */
        public async Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateCertificateByCertificateIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateByCertificateIdResponse
         */
        public CreateCertificateByCertificateIdResponse CreateCertificateByCertificateIdWithOptions(CreateCertificateByCertificateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateByCertificateId",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateByCertificateIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateCertificateByCertificateIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateByCertificateIdResponse
         */
        public async Task<CreateCertificateByCertificateIdResponse> CreateCertificateByCertificateIdWithOptionsAsync(CreateCertificateByCertificateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateByCertificateId",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateByCertificateIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateCertificateByCertificateIdRequest
         * @return CreateCertificateByCertificateIdResponse
         */
        public CreateCertificateByCertificateIdResponse CreateCertificateByCertificateId(CreateCertificateByCertificateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateByCertificateIdWithOptions(request, runtime);
        }

        /**
         * @param request CreateCertificateByCertificateIdRequest
         * @return CreateCertificateByCertificateIdResponse
         */
        public async Task<CreateCertificateByCertificateIdResponse> CreateCertificateByCertificateIdAsync(CreateCertificateByCertificateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateByCertificateIdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessHeaderMode))
            {
                query["AccessHeaderMode"] = request.AccessHeaderMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessHeaders))
            {
                query["AccessHeaders"] = request.AccessHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudNativeInstances))
            {
                query["CloudNativeInstances"] = request.CloudNativeInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionTime))
            {
                query["ConnectionTime"] = request.ConnectionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Port))
            {
                query["Http2Port"] = request.Http2Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpPort))
            {
                query["HttpPort"] = request.HttpPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpToUserIp))
            {
                query["HttpToUserIp"] = request.HttpToUserIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpsPort))
            {
                query["HttpsPort"] = request.HttpsPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpsRedirect))
            {
                query["HttpsRedirect"] = request.HttpsRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpFollowStatus))
            {
                query["IpFollowStatus"] = request.IpFollowStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAccessProduct))
            {
                query["IsAccessProduct"] = request.IsAccessProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keepalive))
            {
                query["Keepalive"] = request.Keepalive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepaliveRequests))
            {
                query["KeepaliveRequests"] = request.KeepaliveRequests;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepaliveTimeout))
            {
                query["KeepaliveTimeout"] = request.KeepaliveTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancing))
            {
                query["LoadBalancing"] = request.LoadBalancing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogHeaders))
            {
                query["LogHeaders"] = request.LogHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadTime))
            {
                query["ReadTime"] = request.ReadTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retry))
            {
                query["Retry"] = request.Retry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniHost))
            {
                query["SniHost"] = request.SniHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniStatus))
            {
                query["SniStatus"] = request.SniStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIps))
            {
                query["SourceIps"] = request.SourceIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WriteTime))
            {
                query["WriteTime"] = request.WriteTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessHeaderMode))
            {
                query["AccessHeaderMode"] = request.AccessHeaderMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessHeaders))
            {
                query["AccessHeaders"] = request.AccessHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudNativeInstances))
            {
                query["CloudNativeInstances"] = request.CloudNativeInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionTime))
            {
                query["ConnectionTime"] = request.ConnectionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Port))
            {
                query["Http2Port"] = request.Http2Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpPort))
            {
                query["HttpPort"] = request.HttpPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpToUserIp))
            {
                query["HttpToUserIp"] = request.HttpToUserIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpsPort))
            {
                query["HttpsPort"] = request.HttpsPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpsRedirect))
            {
                query["HttpsRedirect"] = request.HttpsRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpFollowStatus))
            {
                query["IpFollowStatus"] = request.IpFollowStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAccessProduct))
            {
                query["IsAccessProduct"] = request.IsAccessProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keepalive))
            {
                query["Keepalive"] = request.Keepalive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepaliveRequests))
            {
                query["KeepaliveRequests"] = request.KeepaliveRequests;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepaliveTimeout))
            {
                query["KeepaliveTimeout"] = request.KeepaliveTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancing))
            {
                query["LoadBalancing"] = request.LoadBalancing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogHeaders))
            {
                query["LogHeaders"] = request.LogHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadTime))
            {
                query["ReadTime"] = request.ReadTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retry))
            {
                query["Retry"] = request.Retry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniHost))
            {
                query["SniHost"] = request.SniHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniStatus))
            {
                query["SniStatus"] = request.SniStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIps))
            {
                query["SourceIps"] = request.SourceIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WriteTime))
            {
                query["WriteTime"] = request.WriteTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainWithOptions(request, runtime);
        }

        /**
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateProtectionModuleRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProtectionModuleRuleResponse
         */
        public CreateProtectionModuleRuleResponse CreateProtectionModuleRuleWithOptions(CreateProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProtectionModuleRule",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProtectionModuleRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateProtectionModuleRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProtectionModuleRuleResponse
         */
        public async Task<CreateProtectionModuleRuleResponse> CreateProtectionModuleRuleWithOptionsAsync(CreateProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProtectionModuleRule",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProtectionModuleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateProtectionModuleRuleRequest
         * @return CreateProtectionModuleRuleResponse
         */
        public CreateProtectionModuleRuleResponse CreateProtectionModuleRule(CreateProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProtectionModuleRuleWithOptions(request, runtime);
        }

        /**
         * @param request CreateProtectionModuleRuleRequest
         * @return CreateProtectionModuleRuleResponse
         */
        public async Task<CreateProtectionModuleRuleResponse> CreateProtectionModuleRuleAsync(CreateProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProtectionModuleRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        /**
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteProtectionModuleRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProtectionModuleRuleResponse
         */
        public DeleteProtectionModuleRuleResponse DeleteProtectionModuleRuleWithOptions(DeleteProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProtectionModuleRule",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProtectionModuleRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteProtectionModuleRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProtectionModuleRuleResponse
         */
        public async Task<DeleteProtectionModuleRuleResponse> DeleteProtectionModuleRuleWithOptionsAsync(DeleteProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProtectionModuleRule",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProtectionModuleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteProtectionModuleRuleRequest
         * @return DeleteProtectionModuleRuleResponse
         */
        public DeleteProtectionModuleRuleResponse DeleteProtectionModuleRule(DeleteProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProtectionModuleRuleWithOptions(request, runtime);
        }

        /**
         * @param request DeleteProtectionModuleRuleRequest
         * @return DeleteProtectionModuleRuleResponse
         */
        public async Task<DeleteProtectionModuleRuleResponse> DeleteProtectionModuleRuleAsync(DeleteProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProtectionModuleRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeCertMatchStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertMatchStatusResponse
         */
        public DescribeCertMatchStatusResponse DescribeCertMatchStatusWithOptions(DescribeCertMatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificate))
            {
                query["Certificate"] = request.Certificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertMatchStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertMatchStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeCertMatchStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertMatchStatusResponse
         */
        public async Task<DescribeCertMatchStatusResponse> DescribeCertMatchStatusWithOptionsAsync(DescribeCertMatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificate))
            {
                query["Certificate"] = request.Certificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertMatchStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertMatchStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeCertMatchStatusRequest
         * @return DescribeCertMatchStatusResponse
         */
        public DescribeCertMatchStatusResponse DescribeCertMatchStatus(DescribeCertMatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertMatchStatusWithOptions(request, runtime);
        }

        /**
         * @param request DescribeCertMatchStatusRequest
         * @return DescribeCertMatchStatusResponse
         */
        public async Task<DescribeCertMatchStatusResponse> DescribeCertMatchStatusAsync(DescribeCertMatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertMatchStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeCertificatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertificatesResponse
         */
        public DescribeCertificatesResponse DescribeCertificatesWithOptions(DescribeCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertificates",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeCertificatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertificatesResponse
         */
        public async Task<DescribeCertificatesResponse> DescribeCertificatesWithOptionsAsync(DescribeCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertificates",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeCertificatesRequest
         * @return DescribeCertificatesResponse
         */
        public DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificatesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeCertificatesRequest
         * @return DescribeCertificatesResponse
         */
        public async Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificatesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainResponse
         */
        public DescribeDomainResponse DescribeDomainWithOptions(DescribeDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomain",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainResponse
         */
        public async Task<DescribeDomainResponse> DescribeDomainWithOptionsAsync(DescribeDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomain",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainRequest
         * @return DescribeDomainResponse
         */
        public DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDomainRequest
         * @return DescribeDomainResponse
         */
        public async Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDomainAdvanceConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainAdvanceConfigsResponse
         */
        public DescribeDomainAdvanceConfigsResponse DescribeDomainAdvanceConfigsWithOptions(DescribeDomainAdvanceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainList))
            {
                query["DomainList"] = request.DomainList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainAdvanceConfigs",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainAdvanceConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainAdvanceConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainAdvanceConfigsResponse
         */
        public async Task<DescribeDomainAdvanceConfigsResponse> DescribeDomainAdvanceConfigsWithOptionsAsync(DescribeDomainAdvanceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainList))
            {
                query["DomainList"] = request.DomainList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainAdvanceConfigs",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainAdvanceConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainAdvanceConfigsRequest
         * @return DescribeDomainAdvanceConfigsResponse
         */
        public DescribeDomainAdvanceConfigsResponse DescribeDomainAdvanceConfigs(DescribeDomainAdvanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAdvanceConfigsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDomainAdvanceConfigsRequest
         * @return DescribeDomainAdvanceConfigsResponse
         */
        public async Task<DescribeDomainAdvanceConfigsResponse> DescribeDomainAdvanceConfigsAsync(DescribeDomainAdvanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAdvanceConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDomainBasicConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainBasicConfigsResponse
         */
        public DescribeDomainBasicConfigsResponse DescribeDomainBasicConfigsWithOptions(DescribeDomainBasicConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudNativeProductId))
            {
                query["CloudNativeProductId"] = request.CloudNativeProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainKey))
            {
                query["DomainKey"] = request.DomainKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainBasicConfigs",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainBasicConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainBasicConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainBasicConfigsResponse
         */
        public async Task<DescribeDomainBasicConfigsResponse> DescribeDomainBasicConfigsWithOptionsAsync(DescribeDomainBasicConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudNativeProductId))
            {
                query["CloudNativeProductId"] = request.CloudNativeProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainKey))
            {
                query["DomainKey"] = request.DomainKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainBasicConfigs",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainBasicConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainBasicConfigsRequest
         * @return DescribeDomainBasicConfigsResponse
         */
        public DescribeDomainBasicConfigsResponse DescribeDomainBasicConfigs(DescribeDomainBasicConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainBasicConfigsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDomainBasicConfigsRequest
         * @return DescribeDomainBasicConfigsResponse
         */
        public async Task<DescribeDomainBasicConfigsResponse> DescribeDomainBasicConfigsAsync(DescribeDomainBasicConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainBasicConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainListResponse
         */
        public DescribeDomainListResponse DescribeDomainListWithOptions(DescribeDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSub))
            {
                query["IsSub"] = request.IsSub;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainList",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainListResponse
         */
        public async Task<DescribeDomainListResponse> DescribeDomainListWithOptionsAsync(DescribeDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSub))
            {
                query["IsSub"] = request.IsSub;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainList",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainListRequest
         * @return DescribeDomainListResponse
         */
        public DescribeDomainListResponse DescribeDomainList(DescribeDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainListWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDomainListRequest
         * @return DescribeDomainListResponse
         */
        public async Task<DescribeDomainListResponse> DescribeDomainListAsync(DescribeDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDomainNamesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainNamesResponse
         */
        public DescribeDomainNamesResponse DescribeDomainNamesWithOptions(DescribeDomainNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainNames",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainNamesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainNamesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainNamesResponse
         */
        public async Task<DescribeDomainNamesResponse> DescribeDomainNamesWithOptionsAsync(DescribeDomainNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainNames",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainNamesRequest
         * @return DescribeDomainNamesResponse
         */
        public DescribeDomainNamesResponse DescribeDomainNames(DescribeDomainNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainNamesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDomainNamesRequest
         * @return DescribeDomainNamesResponse
         */
        public async Task<DescribeDomainNamesResponse> DescribeDomainNamesAsync(DescribeDomainNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainNamesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDomainRuleGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainRuleGroupResponse
         */
        public DescribeDomainRuleGroupResponse DescribeDomainRuleGroupWithOptions(DescribeDomainRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRuleGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRuleGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainRuleGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainRuleGroupResponse
         */
        public async Task<DescribeDomainRuleGroupResponse> DescribeDomainRuleGroupWithOptionsAsync(DescribeDomainRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRuleGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRuleGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDomainRuleGroupRequest
         * @return DescribeDomainRuleGroupResponse
         */
        public DescribeDomainRuleGroupResponse DescribeDomainRuleGroup(DescribeDomainRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRuleGroupWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDomainRuleGroupRequest
         * @return DescribeDomainRuleGroupResponse
         */
        public async Task<DescribeDomainRuleGroupResponse> DescribeDomainRuleGroupAsync(DescribeDomainRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRuleGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInstanceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceInfoResponse
         */
        public DescribeInstanceInfoResponse DescribeInstanceInfoWithOptions(DescribeInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceInfo",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceInfoResponse
         */
        public async Task<DescribeInstanceInfoResponse> DescribeInstanceInfoWithOptionsAsync(DescribeInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceInfo",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceInfoRequest
         * @return DescribeInstanceInfoResponse
         */
        public DescribeInstanceInfoResponse DescribeInstanceInfo(DescribeInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceInfoWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInstanceInfoRequest
         * @return DescribeInstanceInfoResponse
         */
        public async Task<DescribeInstanceInfoResponse> DescribeInstanceInfoAsync(DescribeInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInstanceSpecInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSpecInfoResponse
         */
        public DescribeInstanceSpecInfoResponse DescribeInstanceSpecInfoWithOptions(DescribeInstanceSpecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSpecInfo",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSpecInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceSpecInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSpecInfoResponse
         */
        public async Task<DescribeInstanceSpecInfoResponse> DescribeInstanceSpecInfoWithOptionsAsync(DescribeInstanceSpecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSpecInfo",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSpecInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceSpecInfoRequest
         * @return DescribeInstanceSpecInfoResponse
         */
        public DescribeInstanceSpecInfoResponse DescribeInstanceSpecInfo(DescribeInstanceSpecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSpecInfoWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInstanceSpecInfoRequest
         * @return DescribeInstanceSpecInfoResponse
         */
        public async Task<DescribeInstanceSpecInfoResponse> DescribeInstanceSpecInfoAsync(DescribeInstanceSpecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSpecInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeLogServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLogServiceStatusResponse
         */
        public DescribeLogServiceStatusResponse DescribeLogServiceStatusWithOptions(DescribeLogServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogServiceStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeLogServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLogServiceStatusResponse
         */
        public async Task<DescribeLogServiceStatusResponse> DescribeLogServiceStatusWithOptionsAsync(DescribeLogServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogServiceStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeLogServiceStatusRequest
         * @return DescribeLogServiceStatusResponse
         */
        public DescribeLogServiceStatusResponse DescribeLogServiceStatus(DescribeLogServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogServiceStatusWithOptions(request, runtime);
        }

        /**
         * @param request DescribeLogServiceStatusRequest
         * @return DescribeLogServiceStatusResponse
         */
        public async Task<DescribeLogServiceStatusResponse> DescribeLogServiceStatusAsync(DescribeLogServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogServiceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeProtectionModuleCodeConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtectionModuleCodeConfigResponse
         */
        public DescribeProtectionModuleCodeConfigResponse DescribeProtectionModuleCodeConfigWithOptions(DescribeProtectionModuleCodeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeType))
            {
                query["CodeType"] = request.CodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeValue))
            {
                query["CodeValue"] = request.CodeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtectionModuleCodeConfig",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtectionModuleCodeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeProtectionModuleCodeConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtectionModuleCodeConfigResponse
         */
        public async Task<DescribeProtectionModuleCodeConfigResponse> DescribeProtectionModuleCodeConfigWithOptionsAsync(DescribeProtectionModuleCodeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeType))
            {
                query["CodeType"] = request.CodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeValue))
            {
                query["CodeValue"] = request.CodeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtectionModuleCodeConfig",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtectionModuleCodeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeProtectionModuleCodeConfigRequest
         * @return DescribeProtectionModuleCodeConfigResponse
         */
        public DescribeProtectionModuleCodeConfigResponse DescribeProtectionModuleCodeConfig(DescribeProtectionModuleCodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtectionModuleCodeConfigWithOptions(request, runtime);
        }

        /**
         * @param request DescribeProtectionModuleCodeConfigRequest
         * @return DescribeProtectionModuleCodeConfigResponse
         */
        public async Task<DescribeProtectionModuleCodeConfigResponse> DescribeProtectionModuleCodeConfigAsync(DescribeProtectionModuleCodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtectionModuleCodeConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeProtectionModuleModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtectionModuleModeResponse
         */
        public DescribeProtectionModuleModeResponse DescribeProtectionModuleModeWithOptions(DescribeProtectionModuleModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtectionModuleMode",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtectionModuleModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeProtectionModuleModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtectionModuleModeResponse
         */
        public async Task<DescribeProtectionModuleModeResponse> DescribeProtectionModuleModeWithOptionsAsync(DescribeProtectionModuleModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtectionModuleMode",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtectionModuleModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeProtectionModuleModeRequest
         * @return DescribeProtectionModuleModeResponse
         */
        public DescribeProtectionModuleModeResponse DescribeProtectionModuleMode(DescribeProtectionModuleModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtectionModuleModeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeProtectionModuleModeRequest
         * @return DescribeProtectionModuleModeResponse
         */
        public async Task<DescribeProtectionModuleModeResponse> DescribeProtectionModuleModeAsync(DescribeProtectionModuleModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtectionModuleModeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeProtectionModuleRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtectionModuleRulesResponse
         */
        public DescribeProtectionModuleRulesResponse DescribeProtectionModuleRulesWithOptions(DescribeProtectionModuleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtectionModuleRules",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtectionModuleRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeProtectionModuleRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtectionModuleRulesResponse
         */
        public async Task<DescribeProtectionModuleRulesResponse> DescribeProtectionModuleRulesWithOptionsAsync(DescribeProtectionModuleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtectionModuleRules",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtectionModuleRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeProtectionModuleRulesRequest
         * @return DescribeProtectionModuleRulesResponse
         */
        public DescribeProtectionModuleRulesResponse DescribeProtectionModuleRules(DescribeProtectionModuleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtectionModuleRulesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeProtectionModuleRulesRequest
         * @return DescribeProtectionModuleRulesResponse
         */
        public async Task<DescribeProtectionModuleRulesResponse> DescribeProtectionModuleRulesAsync(DescribeProtectionModuleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtectionModuleRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeProtectionModuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtectionModuleStatusResponse
         */
        public DescribeProtectionModuleStatusResponse DescribeProtectionModuleStatusWithOptions(DescribeProtectionModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtectionModuleStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtectionModuleStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeProtectionModuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProtectionModuleStatusResponse
         */
        public async Task<DescribeProtectionModuleStatusResponse> DescribeProtectionModuleStatusWithOptionsAsync(DescribeProtectionModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProtectionModuleStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProtectionModuleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeProtectionModuleStatusRequest
         * @return DescribeProtectionModuleStatusResponse
         */
        public DescribeProtectionModuleStatusResponse DescribeProtectionModuleStatus(DescribeProtectionModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtectionModuleStatusWithOptions(request, runtime);
        }

        /**
         * @param request DescribeProtectionModuleStatusRequest
         * @return DescribeProtectionModuleStatusResponse
         */
        public async Task<DescribeProtectionModuleStatusResponse> DescribeProtectionModuleStatusAsync(DescribeProtectionModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtectionModuleStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRuleGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleGroupsResponse
         */
        public DescribeRuleGroupsResponse DescribeRuleGroupsWithOptions(DescribeRuleGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafLang))
            {
                query["WafLang"] = request.WafLang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleGroups",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRuleGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleGroupsResponse
         */
        public async Task<DescribeRuleGroupsResponse> DescribeRuleGroupsWithOptionsAsync(DescribeRuleGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafLang))
            {
                query["WafLang"] = request.WafLang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleGroups",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRuleGroupsRequest
         * @return DescribeRuleGroupsResponse
         */
        public DescribeRuleGroupsResponse DescribeRuleGroups(DescribeRuleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleGroupsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRuleGroupsRequest
         * @return DescribeRuleGroupsResponse
         */
        public async Task<DescribeRuleGroupsResponse> DescribeRuleGroupsAsync(DescribeRuleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRulesResponse
         */
        public DescribeRulesResponse DescribeRulesWithOptions(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveIdKey))
            {
                query["CveIdKey"] = request.CveIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionType))
            {
                query["ProtectionType"] = request.ProtectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleGroupId))
            {
                query["RuleGroupId"] = request.RuleGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIdKey))
            {
                query["RuleIdKey"] = request.RuleIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRules",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRulesResponse
         */
        public async Task<DescribeRulesResponse> DescribeRulesWithOptionsAsync(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveIdKey))
            {
                query["CveIdKey"] = request.CveIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionType))
            {
                query["ProtectionType"] = request.ProtectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleGroupId))
            {
                query["RuleGroupId"] = request.RuleGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIdKey))
            {
                query["RuleIdKey"] = request.RuleIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRules",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRulesRequest
         * @return DescribeRulesResponse
         */
        public DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRulesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRulesRequest
         * @return DescribeRulesResponse
         */
        public async Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeWafSourceIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWafSourceIpSegmentResponse
         */
        public DescribeWafSourceIpSegmentResponse DescribeWafSourceIpSegmentWithOptions(DescribeWafSourceIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWafSourceIpSegment",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWafSourceIpSegmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeWafSourceIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWafSourceIpSegmentResponse
         */
        public async Task<DescribeWafSourceIpSegmentResponse> DescribeWafSourceIpSegmentWithOptionsAsync(DescribeWafSourceIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWafSourceIpSegment",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWafSourceIpSegmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeWafSourceIpSegmentRequest
         * @return DescribeWafSourceIpSegmentResponse
         */
        public DescribeWafSourceIpSegmentResponse DescribeWafSourceIpSegment(DescribeWafSourceIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWafSourceIpSegmentWithOptions(request, runtime);
        }

        /**
         * @param request DescribeWafSourceIpSegmentRequest
         * @return DescribeWafSourceIpSegmentResponse
         */
        public async Task<DescribeWafSourceIpSegmentResponse> DescribeWafSourceIpSegmentAsync(DescribeWafSourceIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWafSourceIpSegmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a domain name.
         *
         * @param request ModifyDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDomainResponse
         */
        public ModifyDomainResponse ModifyDomainWithOptions(ModifyDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessHeaderMode))
            {
                query["AccessHeaderMode"] = request.AccessHeaderMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessHeaders))
            {
                query["AccessHeaders"] = request.AccessHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudNativeInstances))
            {
                query["CloudNativeInstances"] = request.CloudNativeInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionTime))
            {
                query["ConnectionTime"] = request.ConnectionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Port))
            {
                query["Http2Port"] = request.Http2Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpPort))
            {
                query["HttpPort"] = request.HttpPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpToUserIp))
            {
                query["HttpToUserIp"] = request.HttpToUserIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpsPort))
            {
                query["HttpsPort"] = request.HttpsPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpsRedirect))
            {
                query["HttpsRedirect"] = request.HttpsRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpFollowStatus))
            {
                query["IpFollowStatus"] = request.IpFollowStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAccessProduct))
            {
                query["IsAccessProduct"] = request.IsAccessProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keepalive))
            {
                query["Keepalive"] = request.Keepalive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepaliveRequests))
            {
                query["KeepaliveRequests"] = request.KeepaliveRequests;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepaliveTimeout))
            {
                query["KeepaliveTimeout"] = request.KeepaliveTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancing))
            {
                query["LoadBalancing"] = request.LoadBalancing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogHeaders))
            {
                query["LogHeaders"] = request.LogHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadTime))
            {
                query["ReadTime"] = request.ReadTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retry))
            {
                query["Retry"] = request.Retry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniHost))
            {
                query["SniHost"] = request.SniHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniStatus))
            {
                query["SniStatus"] = request.SniStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIps))
            {
                query["SourceIps"] = request.SourceIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WriteTime))
            {
                query["WriteTime"] = request.WriteTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDomain",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a domain name.
         *
         * @param request ModifyDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDomainResponse
         */
        public async Task<ModifyDomainResponse> ModifyDomainWithOptionsAsync(ModifyDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessHeaderMode))
            {
                query["AccessHeaderMode"] = request.AccessHeaderMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessHeaders))
            {
                query["AccessHeaders"] = request.AccessHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudNativeInstances))
            {
                query["CloudNativeInstances"] = request.CloudNativeInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionTime))
            {
                query["ConnectionTime"] = request.ConnectionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Port))
            {
                query["Http2Port"] = request.Http2Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpPort))
            {
                query["HttpPort"] = request.HttpPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpToUserIp))
            {
                query["HttpToUserIp"] = request.HttpToUserIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpsPort))
            {
                query["HttpsPort"] = request.HttpsPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpsRedirect))
            {
                query["HttpsRedirect"] = request.HttpsRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpFollowStatus))
            {
                query["IpFollowStatus"] = request.IpFollowStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAccessProduct))
            {
                query["IsAccessProduct"] = request.IsAccessProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keepalive))
            {
                query["Keepalive"] = request.Keepalive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepaliveRequests))
            {
                query["KeepaliveRequests"] = request.KeepaliveRequests;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepaliveTimeout))
            {
                query["KeepaliveTimeout"] = request.KeepaliveTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancing))
            {
                query["LoadBalancing"] = request.LoadBalancing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogHeaders))
            {
                query["LogHeaders"] = request.LogHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadTime))
            {
                query["ReadTime"] = request.ReadTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retry))
            {
                query["Retry"] = request.Retry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniHost))
            {
                query["SniHost"] = request.SniHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniStatus))
            {
                query["SniStatus"] = request.SniStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIps))
            {
                query["SourceIps"] = request.SourceIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WriteTime))
            {
                query["WriteTime"] = request.WriteTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDomain",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a domain name.
         *
         * @param request ModifyDomainRequest
         * @return ModifyDomainResponse
         */
        public ModifyDomainResponse ModifyDomain(ModifyDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a domain name.
         *
         * @param request ModifyDomainRequest
         * @return ModifyDomainResponse
         */
        public async Task<ModifyDomainResponse> ModifyDomainAsync(ModifyDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyDomainIpv6StatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDomainIpv6StatusResponse
         */
        public ModifyDomainIpv6StatusResponse ModifyDomainIpv6StatusWithOptions(ModifyDomainIpv6StatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDomainIpv6Status",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDomainIpv6StatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyDomainIpv6StatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDomainIpv6StatusResponse
         */
        public async Task<ModifyDomainIpv6StatusResponse> ModifyDomainIpv6StatusWithOptionsAsync(ModifyDomainIpv6StatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDomainIpv6Status",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDomainIpv6StatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyDomainIpv6StatusRequest
         * @return ModifyDomainIpv6StatusResponse
         */
        public ModifyDomainIpv6StatusResponse ModifyDomainIpv6Status(ModifyDomainIpv6StatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainIpv6StatusWithOptions(request, runtime);
        }

        /**
         * @param request ModifyDomainIpv6StatusRequest
         * @return ModifyDomainIpv6StatusResponse
         */
        public async Task<ModifyDomainIpv6StatusResponse> ModifyDomainIpv6StatusAsync(ModifyDomainIpv6StatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainIpv6StatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyLogRetrievalStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLogRetrievalStatusResponse
         */
        public ModifyLogRetrievalStatusResponse ModifyLogRetrievalStatusWithOptions(ModifyLogRetrievalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLogRetrievalStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLogRetrievalStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyLogRetrievalStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLogRetrievalStatusResponse
         */
        public async Task<ModifyLogRetrievalStatusResponse> ModifyLogRetrievalStatusWithOptionsAsync(ModifyLogRetrievalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLogRetrievalStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLogRetrievalStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyLogRetrievalStatusRequest
         * @return ModifyLogRetrievalStatusResponse
         */
        public ModifyLogRetrievalStatusResponse ModifyLogRetrievalStatus(ModifyLogRetrievalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLogRetrievalStatusWithOptions(request, runtime);
        }

        /**
         * @param request ModifyLogRetrievalStatusRequest
         * @return ModifyLogRetrievalStatusResponse
         */
        public async Task<ModifyLogRetrievalStatusResponse> ModifyLogRetrievalStatusAsync(ModifyLogRetrievalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLogRetrievalStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyLogServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLogServiceStatusResponse
         */
        public ModifyLogServiceStatusResponse ModifyLogServiceStatusWithOptions(ModifyLogServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLogServiceStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLogServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyLogServiceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLogServiceStatusResponse
         */
        public async Task<ModifyLogServiceStatusResponse> ModifyLogServiceStatusWithOptionsAsync(ModifyLogServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLogServiceStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLogServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyLogServiceStatusRequest
         * @return ModifyLogServiceStatusResponse
         */
        public ModifyLogServiceStatusResponse ModifyLogServiceStatus(ModifyLogServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLogServiceStatusWithOptions(request, runtime);
        }

        /**
         * @param request ModifyLogServiceStatusRequest
         * @return ModifyLogServiceStatusResponse
         */
        public async Task<ModifyLogServiceStatusResponse> ModifyLogServiceStatusAsync(ModifyLogServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLogServiceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyProtectionModuleModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionModuleModeResponse
         */
        public ModifyProtectionModuleModeResponse ModifyProtectionModuleModeWithOptions(ModifyProtectionModuleModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionModuleMode",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionModuleModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionModuleModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionModuleModeResponse
         */
        public async Task<ModifyProtectionModuleModeResponse> ModifyProtectionModuleModeWithOptionsAsync(ModifyProtectionModuleModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionModuleMode",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionModuleModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionModuleModeRequest
         * @return ModifyProtectionModuleModeResponse
         */
        public ModifyProtectionModuleModeResponse ModifyProtectionModuleMode(ModifyProtectionModuleModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionModuleModeWithOptions(request, runtime);
        }

        /**
         * @param request ModifyProtectionModuleModeRequest
         * @return ModifyProtectionModuleModeResponse
         */
        public async Task<ModifyProtectionModuleModeResponse> ModifyProtectionModuleModeAsync(ModifyProtectionModuleModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionModuleModeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyProtectionModuleRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionModuleRuleResponse
         */
        public ModifyProtectionModuleRuleResponse ModifyProtectionModuleRuleWithOptions(ModifyProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockVersion))
            {
                query["LockVersion"] = request.LockVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionModuleRule",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionModuleRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionModuleRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionModuleRuleResponse
         */
        public async Task<ModifyProtectionModuleRuleResponse> ModifyProtectionModuleRuleWithOptionsAsync(ModifyProtectionModuleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockVersion))
            {
                query["LockVersion"] = request.LockVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionModuleRule",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionModuleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionModuleRuleRequest
         * @return ModifyProtectionModuleRuleResponse
         */
        public ModifyProtectionModuleRuleResponse ModifyProtectionModuleRule(ModifyProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionModuleRuleWithOptions(request, runtime);
        }

        /**
         * @param request ModifyProtectionModuleRuleRequest
         * @return ModifyProtectionModuleRuleResponse
         */
        public async Task<ModifyProtectionModuleRuleResponse> ModifyProtectionModuleRuleAsync(ModifyProtectionModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionModuleRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyProtectionModuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionModuleStatusResponse
         */
        public ModifyProtectionModuleStatusResponse ModifyProtectionModuleStatusWithOptions(ModifyProtectionModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleStatus))
            {
                query["ModuleStatus"] = request.ModuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionModuleStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionModuleStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionModuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionModuleStatusResponse
         */
        public async Task<ModifyProtectionModuleStatusResponse> ModifyProtectionModuleStatusWithOptionsAsync(ModifyProtectionModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleStatus))
            {
                query["ModuleStatus"] = request.ModuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionModuleStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionModuleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionModuleStatusRequest
         * @return ModifyProtectionModuleStatusResponse
         */
        public ModifyProtectionModuleStatusResponse ModifyProtectionModuleStatus(ModifyProtectionModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionModuleStatusWithOptions(request, runtime);
        }

        /**
         * @param request ModifyProtectionModuleStatusRequest
         * @return ModifyProtectionModuleStatusResponse
         */
        public async Task<ModifyProtectionModuleStatusResponse> ModifyProtectionModuleStatusAsync(ModifyProtectionModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionModuleStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyProtectionRuleCacheStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionRuleCacheStatusResponse
         */
        public ModifyProtectionRuleCacheStatusResponse ModifyProtectionRuleCacheStatusWithOptions(ModifyProtectionRuleCacheStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionRuleCacheStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionRuleCacheStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionRuleCacheStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionRuleCacheStatusResponse
         */
        public async Task<ModifyProtectionRuleCacheStatusResponse> ModifyProtectionRuleCacheStatusWithOptionsAsync(ModifyProtectionRuleCacheStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionRuleCacheStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionRuleCacheStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionRuleCacheStatusRequest
         * @return ModifyProtectionRuleCacheStatusResponse
         */
        public ModifyProtectionRuleCacheStatusResponse ModifyProtectionRuleCacheStatus(ModifyProtectionRuleCacheStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionRuleCacheStatusWithOptions(request, runtime);
        }

        /**
         * @param request ModifyProtectionRuleCacheStatusRequest
         * @return ModifyProtectionRuleCacheStatusResponse
         */
        public async Task<ModifyProtectionRuleCacheStatusResponse> ModifyProtectionRuleCacheStatusAsync(ModifyProtectionRuleCacheStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionRuleCacheStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyProtectionRuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionRuleStatusResponse
         */
        public ModifyProtectionRuleStatusResponse ModifyProtectionRuleStatusWithOptions(ModifyProtectionRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockVersion))
            {
                query["LockVersion"] = request.LockVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleStatus))
            {
                query["RuleStatus"] = request.RuleStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionRuleStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionRuleStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionRuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProtectionRuleStatusResponse
         */
        public async Task<ModifyProtectionRuleStatusResponse> ModifyProtectionRuleStatusWithOptionsAsync(ModifyProtectionRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseType))
            {
                query["DefenseType"] = request.DefenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockVersion))
            {
                query["LockVersion"] = request.LockVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleStatus))
            {
                query["RuleStatus"] = request.RuleStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProtectionRuleStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProtectionRuleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyProtectionRuleStatusRequest
         * @return ModifyProtectionRuleStatusResponse
         */
        public ModifyProtectionRuleStatusResponse ModifyProtectionRuleStatus(ModifyProtectionRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProtectionRuleStatusWithOptions(request, runtime);
        }

        /**
         * @param request ModifyProtectionRuleStatusRequest
         * @return ModifyProtectionRuleStatusResponse
         */
        public async Task<ModifyProtectionRuleStatusResponse> ModifyProtectionRuleStatusAsync(ModifyProtectionRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProtectionRuleStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request MoveResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveResourceGroupResponse
         */
        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "MoveResourceGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request MoveResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveResourceGroupResponse
         */
        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "MoveResourceGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request MoveResourceGroupRequest
         * @return MoveResourceGroupResponse
         */
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /**
         * @param request MoveResourceGroupRequest
         * @return MoveResourceGroupResponse
         */
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SetDomainRuleGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDomainRuleGroupResponse
         */
        public SetDomainRuleGroupResponse SetDomainRuleGroupWithOptions(SetDomainRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleGroupId))
            {
                query["RuleGroupId"] = request.RuleGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafAiStatus))
            {
                query["WafAiStatus"] = request.WafAiStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafVersion))
            {
                query["WafVersion"] = request.WafVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDomainRuleGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainRuleGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SetDomainRuleGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDomainRuleGroupResponse
         */
        public async Task<SetDomainRuleGroupResponse> SetDomainRuleGroupWithOptionsAsync(SetDomainRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleGroupId))
            {
                query["RuleGroupId"] = request.RuleGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafAiStatus))
            {
                query["WafAiStatus"] = request.WafAiStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafVersion))
            {
                query["WafVersion"] = request.WafVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDomainRuleGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainRuleGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SetDomainRuleGroupRequest
         * @return SetDomainRuleGroupResponse
         */
        public SetDomainRuleGroupResponse SetDomainRuleGroup(SetDomainRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainRuleGroupWithOptions(request, runtime);
        }

        /**
         * @param request SetDomainRuleGroupRequest
         * @return SetDomainRuleGroupResponse
         */
        public async Task<SetDomainRuleGroupResponse> SetDomainRuleGroupAsync(SetDomainRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainRuleGroupWithOptionsAsync(request, runtime);
        }

    }
}
