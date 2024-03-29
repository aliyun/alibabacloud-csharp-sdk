// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.FC_Open20210406.Models;

namespace AlibabaCloud.SDK.FC_Open20210406
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "account-id.ap-northeast-1.fc.aliyuncs.com"},
                {"ap-south-1", "account-id.ap-south-1.fc.aliyuncs.com"},
                {"ap-southeast-1", "account-id.ap-southeast-1.fc.aliyuncs.com"},
                {"ap-southeast-2", "account-id.ap-southeast-2.fc.aliyuncs.com"},
                {"ap-southeast-3", "account-id.ap-southeast-3.fc.aliyuncs.com"},
                {"ap-southeast-5", "account-id.ap-southeast-5.fc.aliyuncs.com"},
                {"cn-beijing", "account-id.cn-beijing.fc.aliyuncs.com"},
                {"cn-chengdu", "account-id.cn-chengdu.fc.aliyuncs.com"},
                {"cn-hangzhou", "account-id.cn-hangzhou.fc.aliyuncs.com"},
                {"cn-hangzhou-finance", "account-id.cn-hangzhou-finance.fc.aliyuncs.com"},
                {"cn-hongkong", "account-id.cn-hongkong.fc.aliyuncs.com"},
                {"cn-huhehaote", "account-id.cn-huhehaote.fc.aliyuncs.com"},
                {"cn-north-2-gov-1", "account-id.cn-north-2-gov-1.fc.aliyuncs.com"},
                {"cn-qingdao", "account-id.cn-qingdao.fc.aliyuncs.com"},
                {"cn-shanghai", "account-id.cn-shanghai.fc.aliyuncs.com"},
                {"cn-shenzhen", "account-id.cn-shenzhen.fc.aliyuncs.com"},
                {"cn-zhangjiakou", "account-id.cn-zhangjiakou.fc.aliyuncs.com"},
                {"eu-central-1", "account-id.eu-central-1.fc.aliyuncs.com"},
                {"eu-west-1", "account-id.eu-west-1.fc.aliyuncs.com"},
                {"us-east-1", "account-id.us-east-1.fc.aliyuncs.com"},
                {"us-west-1", "account-id.us-west-1.fc.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("fc-open", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ClaimGPUInstanceResponse ClaimGPUInstanceWithOptions(ClaimGPUInstanceRequest request, ClaimGPUInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskPerformanceLevel))
            {
                body["diskPerformanceLevel"] = request.DiskPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSizeGigabytes))
            {
                body["diskSizeGigabytes"] = request.DiskSizeGigabytes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["imageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetBandwidthOut))
            {
                body["internetBandwidthOut"] = request.InternetBandwidthOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgId))
            {
                body["sgId"] = request.SgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                body["sourceCidrIp"] = request.SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TcpPortRange))
            {
                body["tcpPortRange"] = request.TcpPortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdpPortRange))
            {
                body["udpPortRange"] = request.UdpPortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswId))
            {
                body["vswId"] = request.VswId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClaimGPUInstance",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/gpuInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClaimGPUInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ClaimGPUInstanceResponse> ClaimGPUInstanceWithOptionsAsync(ClaimGPUInstanceRequest request, ClaimGPUInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskPerformanceLevel))
            {
                body["diskPerformanceLevel"] = request.DiskPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSizeGigabytes))
            {
                body["diskSizeGigabytes"] = request.DiskSizeGigabytes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["imageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetBandwidthOut))
            {
                body["internetBandwidthOut"] = request.InternetBandwidthOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgId))
            {
                body["sgId"] = request.SgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                body["sourceCidrIp"] = request.SourceCidrIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TcpPortRange))
            {
                body["tcpPortRange"] = request.TcpPortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdpPortRange))
            {
                body["udpPortRange"] = request.UdpPortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswId))
            {
                body["vswId"] = request.VswId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClaimGPUInstance",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/gpuInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClaimGPUInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ClaimGPUInstanceResponse ClaimGPUInstance(ClaimGPUInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClaimGPUInstanceHeaders headers = new ClaimGPUInstanceHeaders();
            return ClaimGPUInstanceWithOptions(request, headers, runtime);
        }

        public async Task<ClaimGPUInstanceResponse> ClaimGPUInstanceAsync(ClaimGPUInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClaimGPUInstanceHeaders headers = new ClaimGPUInstanceHeaders();
            return await ClaimGPUInstanceWithOptionsAsync(request, headers, runtime);
        }

        public CreateAliasResponse CreateAliasWithOptions(string serviceName, CreateAliasRequest request, CreateAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalVersionWeight))
            {
                body["additionalVersionWeight"] = request.AdditionalVersionWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                body["aliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolvePolicy))
            {
                body["resolvePolicy"] = request.ResolvePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutePolicy))
            {
                body["routePolicy"] = request.RoutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlias",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAliasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAliasResponse> CreateAliasWithOptionsAsync(string serviceName, CreateAliasRequest request, CreateAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalVersionWeight))
            {
                body["additionalVersionWeight"] = request.AdditionalVersionWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                body["aliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolvePolicy))
            {
                body["resolvePolicy"] = request.ResolvePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutePolicy))
            {
                body["routePolicy"] = request.RoutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlias",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAliasResponse CreateAlias(string serviceName, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAliasHeaders headers = new CreateAliasHeaders();
            return CreateAliasWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<CreateAliasResponse> CreateAliasAsync(string serviceName, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAliasHeaders headers = new CreateAliasHeaders();
            return await CreateAliasWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public CreateCustomDomainResponse CreateCustomDomainWithOptions(CreateCustomDomainRequest request, CreateCustomDomainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertConfig))
            {
                body["certConfig"] = request.CertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteConfig))
            {
                body["routeConfig"] = request.RouteConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsConfig))
            {
                body["tlsConfig"] = request.TlsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafConfig))
            {
                body["wafConfig"] = request.WafConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomDomain",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCustomDomainResponse> CreateCustomDomainWithOptionsAsync(CreateCustomDomainRequest request, CreateCustomDomainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertConfig))
            {
                body["certConfig"] = request.CertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteConfig))
            {
                body["routeConfig"] = request.RouteConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsConfig))
            {
                body["tlsConfig"] = request.TlsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafConfig))
            {
                body["wafConfig"] = request.WafConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomDomain",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCustomDomainResponse CreateCustomDomain(CreateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomDomainHeaders headers = new CreateCustomDomainHeaders();
            return CreateCustomDomainWithOptions(request, headers, runtime);
        }

        public async Task<CreateCustomDomainResponse> CreateCustomDomainAsync(CreateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomDomainHeaders headers = new CreateCustomDomainHeaders();
            return await CreateCustomDomainWithOptionsAsync(request, headers, runtime);
        }

        public CreateFunctionResponse CreateFunctionWithOptions(string serviceName, CreateFunctionRequest request, CreateFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaPort))
            {
                body["caPort"] = request.CaPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomContainerConfig))
            {
                body["customContainerConfig"] = request.CustomContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDNS))
            {
                body["customDNS"] = request.CustomDNS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHealthCheckConfig))
            {
                body["customHealthCheckConfig"] = request.CustomHealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomRuntimeConfig))
            {
                body["customRuntimeConfig"] = request.CustomRuntimeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["diskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["environmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                body["functionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuMemorySize))
            {
                body["gpuMemorySize"] = request.GpuMemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                body["handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializationTimeout))
            {
                body["initializationTimeout"] = request.InitializationTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initializer))
            {
                body["initializer"] = request.Initializer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceConcurrency))
            {
                body["instanceConcurrency"] = request.InstanceConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLifecycleConfig))
            {
                body["instanceLifecycleConfig"] = request.InstanceLifecycleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSoftConcurrency))
            {
                body["instanceSoftConcurrency"] = request.InstanceSoftConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layers))
            {
                body["layers"] = request.Layers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemorySize))
            {
                body["memorySize"] = request.MemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFunctionResponse> CreateFunctionWithOptionsAsync(string serviceName, CreateFunctionRequest request, CreateFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaPort))
            {
                body["caPort"] = request.CaPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomContainerConfig))
            {
                body["customContainerConfig"] = request.CustomContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDNS))
            {
                body["customDNS"] = request.CustomDNS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHealthCheckConfig))
            {
                body["customHealthCheckConfig"] = request.CustomHealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomRuntimeConfig))
            {
                body["customRuntimeConfig"] = request.CustomRuntimeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["diskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["environmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                body["functionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuMemorySize))
            {
                body["gpuMemorySize"] = request.GpuMemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                body["handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializationTimeout))
            {
                body["initializationTimeout"] = request.InitializationTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initializer))
            {
                body["initializer"] = request.Initializer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceConcurrency))
            {
                body["instanceConcurrency"] = request.InstanceConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLifecycleConfig))
            {
                body["instanceLifecycleConfig"] = request.InstanceLifecycleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSoftConcurrency))
            {
                body["instanceSoftConcurrency"] = request.InstanceSoftConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layers))
            {
                body["layers"] = request.Layers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemorySize))
            {
                body["memorySize"] = request.MemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFunctionResponse CreateFunction(string serviceName, CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFunctionHeaders headers = new CreateFunctionHeaders();
            return CreateFunctionWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<CreateFunctionResponse> CreateFunctionAsync(string serviceName, CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFunctionHeaders headers = new CreateFunctionHeaders();
            return await CreateFunctionWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public CreateLayerVersionResponse CreateLayerVersionWithOptions(string layerName, CreateLayerVersionRequest request, CreateLayerVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompatibleRuntime))
            {
                body["compatibleRuntime"] = request.CompatibleRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayerVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLayerVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLayerVersionResponse> CreateLayerVersionWithOptionsAsync(string layerName, CreateLayerVersionRequest request, CreateLayerVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompatibleRuntime))
            {
                body["compatibleRuntime"] = request.CompatibleRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayerVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLayerVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLayerVersionResponse CreateLayerVersion(string layerName, CreateLayerVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateLayerVersionHeaders headers = new CreateLayerVersionHeaders();
            return CreateLayerVersionWithOptions(layerName, request, headers, runtime);
        }

        public async Task<CreateLayerVersionResponse> CreateLayerVersionAsync(string layerName, CreateLayerVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateLayerVersionHeaders headers = new CreateLayerVersionHeaders();
            return await CreateLayerVersionWithOptionsAsync(layerName, request, headers, runtime);
        }

        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, CreateServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetAccess))
            {
                body["internetAccess"] = request.InternetAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfig))
            {
                body["nasConfig"] = request.NasConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountConfig))
            {
                body["ossMountConfig"] = request.OssMountConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingConfig))
            {
                body["tracingConfig"] = request.TracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcConfig))
            {
                body["vpcConfig"] = request.VpcConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, CreateServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetAccess))
            {
                body["internetAccess"] = request.InternetAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfig))
            {
                body["nasConfig"] = request.NasConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountConfig))
            {
                body["ossMountConfig"] = request.OssMountConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingConfig))
            {
                body["tracingConfig"] = request.TracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcConfig))
            {
                body["vpcConfig"] = request.VpcConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateServiceHeaders headers = new CreateServiceHeaders();
            return CreateServiceWithOptions(request, headers, runtime);
        }

        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateServiceHeaders headers = new CreateServiceHeaders();
            return await CreateServiceWithOptionsAsync(request, headers, runtime);
        }

        public CreateTriggerResponse CreateTriggerWithOptions(string serviceName, string functionName, CreateTriggerRequest request, CreateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationRole))
            {
                body["invocationRole"] = request.InvocationRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["sourceArn"] = request.SourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerName))
            {
                body["triggerName"] = request.TriggerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                body["triggerType"] = request.TriggerType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTriggerResponse> CreateTriggerWithOptionsAsync(string serviceName, string functionName, CreateTriggerRequest request, CreateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationRole))
            {
                body["invocationRole"] = request.InvocationRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["sourceArn"] = request.SourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerName))
            {
                body["triggerName"] = request.TriggerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                body["triggerType"] = request.TriggerType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTriggerResponse CreateTrigger(string serviceName, string functionName, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTriggerHeaders headers = new CreateTriggerHeaders();
            return CreateTriggerWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<CreateTriggerResponse> CreateTriggerAsync(string serviceName, string functionName, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTriggerHeaders headers = new CreateTriggerHeaders();
            return await CreateTriggerWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public CreateVpcBindingResponse CreateVpcBindingWithOptions(string serviceName, CreateVpcBindingRequest request, CreateVpcBindingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcBinding",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/bindings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateVpcBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVpcBindingResponse> CreateVpcBindingWithOptionsAsync(string serviceName, CreateVpcBindingRequest request, CreateVpcBindingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcBinding",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/bindings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateVpcBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVpcBindingResponse CreateVpcBinding(string serviceName, CreateVpcBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVpcBindingHeaders headers = new CreateVpcBindingHeaders();
            return CreateVpcBindingWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<CreateVpcBindingResponse> CreateVpcBindingAsync(string serviceName, CreateVpcBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVpcBindingHeaders headers = new CreateVpcBindingHeaders();
            return await CreateVpcBindingWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public DeleteAliasResponse DeleteAliasWithOptions(string serviceName, string aliasName, DeleteAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlias",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAliasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAliasResponse> DeleteAliasWithOptionsAsync(string serviceName, string aliasName, DeleteAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlias",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAliasResponse DeleteAlias(string serviceName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAliasHeaders headers = new DeleteAliasHeaders();
            return DeleteAliasWithOptions(serviceName, aliasName, headers, runtime);
        }

        public async Task<DeleteAliasResponse> DeleteAliasAsync(string serviceName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAliasHeaders headers = new DeleteAliasHeaders();
            return await DeleteAliasWithOptionsAsync(serviceName, aliasName, headers, runtime);
        }

        public DeleteCustomDomainResponse DeleteCustomDomainWithOptions(string domainName, DeleteCustomDomainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomDomain",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCustomDomainResponse> DeleteCustomDomainWithOptionsAsync(string domainName, DeleteCustomDomainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomDomain",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCustomDomainResponse DeleteCustomDomain(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomDomainHeaders headers = new DeleteCustomDomainHeaders();
            return DeleteCustomDomainWithOptions(domainName, headers, runtime);
        }

        public async Task<DeleteCustomDomainResponse> DeleteCustomDomainAsync(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomDomainHeaders headers = new DeleteCustomDomainHeaders();
            return await DeleteCustomDomainWithOptionsAsync(domainName, headers, runtime);
        }

        public DeleteFunctionResponse DeleteFunctionWithOptions(string serviceName, string functionName, DeleteFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFunctionResponse> DeleteFunctionWithOptionsAsync(string serviceName, string functionName, DeleteFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFunctionResponse DeleteFunction(string serviceName, string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionHeaders headers = new DeleteFunctionHeaders();
            return DeleteFunctionWithOptions(serviceName, functionName, headers, runtime);
        }

        public async Task<DeleteFunctionResponse> DeleteFunctionAsync(string serviceName, string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionHeaders headers = new DeleteFunctionHeaders();
            return await DeleteFunctionWithOptionsAsync(serviceName, functionName, headers, runtime);
        }

        public DeleteFunctionAsyncInvokeConfigResponse DeleteFunctionAsyncInvokeConfigWithOptions(string serviceName, string functionName, DeleteFunctionAsyncInvokeConfigRequest request, DeleteFunctionAsyncInvokeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionAsyncInvokeConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionAsyncInvokeConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFunctionAsyncInvokeConfigResponse> DeleteFunctionAsyncInvokeConfigWithOptionsAsync(string serviceName, string functionName, DeleteFunctionAsyncInvokeConfigRequest request, DeleteFunctionAsyncInvokeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionAsyncInvokeConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionAsyncInvokeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFunctionAsyncInvokeConfigResponse DeleteFunctionAsyncInvokeConfig(string serviceName, string functionName, DeleteFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionAsyncInvokeConfigHeaders headers = new DeleteFunctionAsyncInvokeConfigHeaders();
            return DeleteFunctionAsyncInvokeConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<DeleteFunctionAsyncInvokeConfigResponse> DeleteFunctionAsyncInvokeConfigAsync(string serviceName, string functionName, DeleteFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionAsyncInvokeConfigHeaders headers = new DeleteFunctionAsyncInvokeConfigHeaders();
            return await DeleteFunctionAsyncInvokeConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public DeleteFunctionOnDemandConfigResponse DeleteFunctionOnDemandConfigWithOptions(string serviceName, string functionName, DeleteFunctionOnDemandConfigRequest request, DeleteFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionOnDemandConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/on-demand-config",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionOnDemandConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFunctionOnDemandConfigResponse> DeleteFunctionOnDemandConfigWithOptionsAsync(string serviceName, string functionName, DeleteFunctionOnDemandConfigRequest request, DeleteFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionOnDemandConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/on-demand-config",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionOnDemandConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFunctionOnDemandConfigResponse DeleteFunctionOnDemandConfig(string serviceName, string functionName, DeleteFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionOnDemandConfigHeaders headers = new DeleteFunctionOnDemandConfigHeaders();
            return DeleteFunctionOnDemandConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<DeleteFunctionOnDemandConfigResponse> DeleteFunctionOnDemandConfigAsync(string serviceName, string functionName, DeleteFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionOnDemandConfigHeaders headers = new DeleteFunctionOnDemandConfigHeaders();
            return await DeleteFunctionOnDemandConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public DeleteLayerVersionResponse DeleteLayerVersionWithOptions(string layerName, string version, DeleteLayerVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayerVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLayerVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteLayerVersionResponse> DeleteLayerVersionWithOptionsAsync(string layerName, string version, DeleteLayerVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayerVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLayerVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteLayerVersionResponse DeleteLayerVersion(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLayerVersionHeaders headers = new DeleteLayerVersionHeaders();
            return DeleteLayerVersionWithOptions(layerName, version, headers, runtime);
        }

        public async Task<DeleteLayerVersionResponse> DeleteLayerVersionAsync(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteLayerVersionHeaders headers = new DeleteLayerVersionHeaders();
            return await DeleteLayerVersionWithOptionsAsync(layerName, version, headers, runtime);
        }

        public DeleteServiceResponse DeleteServiceWithOptions(string serviceName, DeleteServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(string serviceName, DeleteServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceResponse DeleteService(string serviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteServiceHeaders headers = new DeleteServiceHeaders();
            return DeleteServiceWithOptions(serviceName, headers, runtime);
        }

        public async Task<DeleteServiceResponse> DeleteServiceAsync(string serviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteServiceHeaders headers = new DeleteServiceHeaders();
            return await DeleteServiceWithOptionsAsync(serviceName, headers, runtime);
        }

        public DeleteServiceVersionResponse DeleteServiceVersionWithOptions(string serviceName, string versionId, DeleteServiceVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceVersionResponse> DeleteServiceVersionWithOptionsAsync(string serviceName, string versionId, DeleteServiceVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceVersionResponse DeleteServiceVersion(string serviceName, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteServiceVersionHeaders headers = new DeleteServiceVersionHeaders();
            return DeleteServiceVersionWithOptions(serviceName, versionId, headers, runtime);
        }

        public async Task<DeleteServiceVersionResponse> DeleteServiceVersionAsync(string serviceName, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteServiceVersionHeaders headers = new DeleteServiceVersionHeaders();
            return await DeleteServiceVersionWithOptionsAsync(serviceName, versionId, headers, runtime);
        }

        public DeleteTriggerResponse DeleteTriggerWithOptions(string serviceName, string functionName, string triggerName, DeleteTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerWithOptionsAsync(string serviceName, string functionName, string triggerName, DeleteTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTriggerResponse DeleteTrigger(string serviceName, string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTriggerHeaders headers = new DeleteTriggerHeaders();
            return DeleteTriggerWithOptions(serviceName, functionName, triggerName, headers, runtime);
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(string serviceName, string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTriggerHeaders headers = new DeleteTriggerHeaders();
            return await DeleteTriggerWithOptionsAsync(serviceName, functionName, triggerName, headers, runtime);
        }

        public DeleteVpcBindingResponse DeleteVpcBindingWithOptions(string serviceName, string vpcId, DeleteVpcBindingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcBinding",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/bindings/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(vpcId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteVpcBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVpcBindingResponse> DeleteVpcBindingWithOptionsAsync(string serviceName, string vpcId, DeleteVpcBindingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcBinding",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/bindings/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(vpcId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteVpcBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVpcBindingResponse DeleteVpcBinding(string serviceName, string vpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVpcBindingHeaders headers = new DeleteVpcBindingHeaders();
            return DeleteVpcBindingWithOptions(serviceName, vpcId, headers, runtime);
        }

        public async Task<DeleteVpcBindingResponse> DeleteVpcBindingAsync(string serviceName, string vpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVpcBindingHeaders headers = new DeleteVpcBindingHeaders();
            return await DeleteVpcBindingWithOptionsAsync(serviceName, vpcId, headers, runtime);
        }

        public DeregisterEventSourceResponse DeregisterEventSourceWithOptions(string serviceName, string functionName, string sourceArn, DeregisterEventSourceRequest request, DeregisterEventSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterEventSource",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/event-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceArn),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeregisterEventSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeregisterEventSourceResponse> DeregisterEventSourceWithOptionsAsync(string serviceName, string functionName, string sourceArn, DeregisterEventSourceRequest request, DeregisterEventSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterEventSource",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/event-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceArn),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeregisterEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeregisterEventSourceResponse DeregisterEventSource(string serviceName, string functionName, string sourceArn, DeregisterEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeregisterEventSourceHeaders headers = new DeregisterEventSourceHeaders();
            return DeregisterEventSourceWithOptions(serviceName, functionName, sourceArn, request, headers, runtime);
        }

        public async Task<DeregisterEventSourceResponse> DeregisterEventSourceAsync(string serviceName, string functionName, string sourceArn, DeregisterEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeregisterEventSourceHeaders headers = new DeregisterEventSourceHeaders();
            return await DeregisterEventSourceWithOptionsAsync(serviceName, functionName, sourceArn, request, headers, runtime);
        }

        public GetAccountSettingsResponse GetAccountSettingsWithOptions(GetAccountSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountSettings",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/account-settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountSettingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAccountSettingsResponse> GetAccountSettingsWithOptionsAsync(GetAccountSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountSettings",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/account-settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAccountSettingsResponse GetAccountSettings()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountSettingsHeaders headers = new GetAccountSettingsHeaders();
            return GetAccountSettingsWithOptions(headers, runtime);
        }

        public async Task<GetAccountSettingsResponse> GetAccountSettingsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountSettingsHeaders headers = new GetAccountSettingsHeaders();
            return await GetAccountSettingsWithOptionsAsync(headers, runtime);
        }

        public GetAliasResponse GetAliasWithOptions(string serviceName, string aliasName, GetAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlias",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAliasResponse> GetAliasWithOptionsAsync(string serviceName, string aliasName, GetAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlias",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAliasResponse GetAlias(string serviceName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAliasHeaders headers = new GetAliasHeaders();
            return GetAliasWithOptions(serviceName, aliasName, headers, runtime);
        }

        public async Task<GetAliasResponse> GetAliasAsync(string serviceName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAliasHeaders headers = new GetAliasHeaders();
            return await GetAliasWithOptionsAsync(serviceName, aliasName, headers, runtime);
        }

        public GetCustomDomainResponse GetCustomDomainWithOptions(string domainName, GetCustomDomainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomDomain",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCustomDomainResponse> GetCustomDomainWithOptionsAsync(string domainName, GetCustomDomainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomDomain",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCustomDomainResponse GetCustomDomain(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCustomDomainHeaders headers = new GetCustomDomainHeaders();
            return GetCustomDomainWithOptions(domainName, headers, runtime);
        }

        public async Task<GetCustomDomainResponse> GetCustomDomainAsync(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCustomDomainHeaders headers = new GetCustomDomainHeaders();
            return await GetCustomDomainWithOptionsAsync(domainName, headers, runtime);
        }

        public GetFunctionResponse GetFunctionWithOptions(string serviceName, string functionName, GetFunctionRequest request, GetFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionResponse> GetFunctionWithOptionsAsync(string serviceName, string functionName, GetFunctionRequest request, GetFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionResponse GetFunction(string serviceName, string functionName, GetFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFunctionHeaders headers = new GetFunctionHeaders();
            return GetFunctionWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetFunctionResponse> GetFunctionAsync(string serviceName, string functionName, GetFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFunctionHeaders headers = new GetFunctionHeaders();
            return await GetFunctionWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        /**
          * StatefulAsyncInvocation indicates whether the asynchronous task feature is enabled. If the value of StatefulAsyncInvocation is true, the asynchronous task feature is enabled. All asynchronous invocations change to asynchronous task mode.
          *
          * @param request GetFunctionAsyncInvokeConfigRequest
          * @param headers GetFunctionAsyncInvokeConfigHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFunctionAsyncInvokeConfigResponse
         */
        public GetFunctionAsyncInvokeConfigResponse GetFunctionAsyncInvokeConfigWithOptions(string serviceName, string functionName, GetFunctionAsyncInvokeConfigRequest request, GetFunctionAsyncInvokeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionAsyncInvokeConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionAsyncInvokeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * StatefulAsyncInvocation indicates whether the asynchronous task feature is enabled. If the value of StatefulAsyncInvocation is true, the asynchronous task feature is enabled. All asynchronous invocations change to asynchronous task mode.
          *
          * @param request GetFunctionAsyncInvokeConfigRequest
          * @param headers GetFunctionAsyncInvokeConfigHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFunctionAsyncInvokeConfigResponse
         */
        public async Task<GetFunctionAsyncInvokeConfigResponse> GetFunctionAsyncInvokeConfigWithOptionsAsync(string serviceName, string functionName, GetFunctionAsyncInvokeConfigRequest request, GetFunctionAsyncInvokeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionAsyncInvokeConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionAsyncInvokeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * StatefulAsyncInvocation indicates whether the asynchronous task feature is enabled. If the value of StatefulAsyncInvocation is true, the asynchronous task feature is enabled. All asynchronous invocations change to asynchronous task mode.
          *
          * @param request GetFunctionAsyncInvokeConfigRequest
          * @return GetFunctionAsyncInvokeConfigResponse
         */
        public GetFunctionAsyncInvokeConfigResponse GetFunctionAsyncInvokeConfig(string serviceName, string functionName, GetFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFunctionAsyncInvokeConfigHeaders headers = new GetFunctionAsyncInvokeConfigHeaders();
            return GetFunctionAsyncInvokeConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        /**
          * StatefulAsyncInvocation indicates whether the asynchronous task feature is enabled. If the value of StatefulAsyncInvocation is true, the asynchronous task feature is enabled. All asynchronous invocations change to asynchronous task mode.
          *
          * @param request GetFunctionAsyncInvokeConfigRequest
          * @return GetFunctionAsyncInvokeConfigResponse
         */
        public async Task<GetFunctionAsyncInvokeConfigResponse> GetFunctionAsyncInvokeConfigAsync(string serviceName, string functionName, GetFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFunctionAsyncInvokeConfigHeaders headers = new GetFunctionAsyncInvokeConfigHeaders();
            return await GetFunctionAsyncInvokeConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetFunctionCodeResponse GetFunctionCodeWithOptions(string serviceName, string functionName, GetFunctionCodeRequest request, GetFunctionCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionCode",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/code",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionCodeResponse> GetFunctionCodeWithOptionsAsync(string serviceName, string functionName, GetFunctionCodeRequest request, GetFunctionCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionCode",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/code",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionCodeResponse GetFunctionCode(string serviceName, string functionName, GetFunctionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFunctionCodeHeaders headers = new GetFunctionCodeHeaders();
            return GetFunctionCodeWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetFunctionCodeResponse> GetFunctionCodeAsync(string serviceName, string functionName, GetFunctionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFunctionCodeHeaders headers = new GetFunctionCodeHeaders();
            return await GetFunctionCodeWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetFunctionOnDemandConfigResponse GetFunctionOnDemandConfigWithOptions(string serviceName, string functionName, GetFunctionOnDemandConfigRequest request, GetFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionOnDemandConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/on-demand-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionOnDemandConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionOnDemandConfigResponse> GetFunctionOnDemandConfigWithOptionsAsync(string serviceName, string functionName, GetFunctionOnDemandConfigRequest request, GetFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionOnDemandConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/on-demand-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionOnDemandConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionOnDemandConfigResponse GetFunctionOnDemandConfig(string serviceName, string functionName, GetFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFunctionOnDemandConfigHeaders headers = new GetFunctionOnDemandConfigHeaders();
            return GetFunctionOnDemandConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetFunctionOnDemandConfigResponse> GetFunctionOnDemandConfigAsync(string serviceName, string functionName, GetFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFunctionOnDemandConfigHeaders headers = new GetFunctionOnDemandConfigHeaders();
            return await GetFunctionOnDemandConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetLayerVersionResponse GetLayerVersionWithOptions(string layerName, string version, GetLayerVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayerVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLayerVersionResponse> GetLayerVersionWithOptionsAsync(string layerName, string version, GetLayerVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayerVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLayerVersionResponse GetLayerVersion(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLayerVersionHeaders headers = new GetLayerVersionHeaders();
            return GetLayerVersionWithOptions(layerName, version, headers, runtime);
        }

        public async Task<GetLayerVersionResponse> GetLayerVersionAsync(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLayerVersionHeaders headers = new GetLayerVersionHeaders();
            return await GetLayerVersionWithOptionsAsync(layerName, version, headers, runtime);
        }

        public GetProvisionConfigResponse GetProvisionConfigWithOptions(string serviceName, string functionName, GetProvisionConfigRequest request, GetProvisionConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProvisionConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProvisionConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProvisionConfigResponse> GetProvisionConfigWithOptionsAsync(string serviceName, string functionName, GetProvisionConfigRequest request, GetProvisionConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProvisionConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProvisionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProvisionConfigResponse GetProvisionConfig(string serviceName, string functionName, GetProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProvisionConfigHeaders headers = new GetProvisionConfigHeaders();
            return GetProvisionConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetProvisionConfigResponse> GetProvisionConfigAsync(string serviceName, string functionName, GetProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProvisionConfigHeaders headers = new GetProvisionConfigHeaders();
            return await GetProvisionConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetResourceTagsResponse GetResourceTagsWithOptions(GetResourceTagsRequest request, GetResourceTagsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                query["resourceArn"] = request.ResourceArn;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceTags",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/tag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceTagsResponse> GetResourceTagsWithOptionsAsync(GetResourceTagsRequest request, GetResourceTagsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                query["resourceArn"] = request.ResourceArn;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceTags",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/tag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceTagsResponse GetResourceTags(GetResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResourceTagsHeaders headers = new GetResourceTagsHeaders();
            return GetResourceTagsWithOptions(request, headers, runtime);
        }

        public async Task<GetResourceTagsResponse> GetResourceTagsAsync(GetResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResourceTagsHeaders headers = new GetResourceTagsHeaders();
            return await GetResourceTagsWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceResponse GetServiceWithOptions(string serviceName, GetServiceRequest request, GetServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(string serviceName, GetServiceRequest request, GetServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetServiceResponse GetService(string serviceName, GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetServiceHeaders headers = new GetServiceHeaders();
            return GetServiceWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<GetServiceResponse> GetServiceAsync(string serviceName, GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetServiceHeaders headers = new GetServiceHeaders();
            return await GetServiceWithOptionsAsync(serviceName, request, headers, runtime);
        }

        /**
          * The version or alias of the service to which the asynchronous task belongs.
          *
          * @param request GetStatefulAsyncInvocationRequest
          * @param headers GetStatefulAsyncInvocationHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStatefulAsyncInvocationResponse
         */
        public GetStatefulAsyncInvocationResponse GetStatefulAsyncInvocationWithOptions(string serviceName, string functionName, string invocationId, GetStatefulAsyncInvocationRequest request, GetStatefulAsyncInvocationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["X-Fc-Invocation-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["X-Fc-Log-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStatefulAsyncInvocation",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/stateful-async-invocations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(invocationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStatefulAsyncInvocationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The version or alias of the service to which the asynchronous task belongs.
          *
          * @param request GetStatefulAsyncInvocationRequest
          * @param headers GetStatefulAsyncInvocationHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStatefulAsyncInvocationResponse
         */
        public async Task<GetStatefulAsyncInvocationResponse> GetStatefulAsyncInvocationWithOptionsAsync(string serviceName, string functionName, string invocationId, GetStatefulAsyncInvocationRequest request, GetStatefulAsyncInvocationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["X-Fc-Invocation-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["X-Fc-Log-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStatefulAsyncInvocation",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/stateful-async-invocations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(invocationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStatefulAsyncInvocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The version or alias of the service to which the asynchronous task belongs.
          *
          * @param request GetStatefulAsyncInvocationRequest
          * @return GetStatefulAsyncInvocationResponse
         */
        public GetStatefulAsyncInvocationResponse GetStatefulAsyncInvocation(string serviceName, string functionName, string invocationId, GetStatefulAsyncInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStatefulAsyncInvocationHeaders headers = new GetStatefulAsyncInvocationHeaders();
            return GetStatefulAsyncInvocationWithOptions(serviceName, functionName, invocationId, request, headers, runtime);
        }

        /**
          * The version or alias of the service to which the asynchronous task belongs.
          *
          * @param request GetStatefulAsyncInvocationRequest
          * @return GetStatefulAsyncInvocationResponse
         */
        public async Task<GetStatefulAsyncInvocationResponse> GetStatefulAsyncInvocationAsync(string serviceName, string functionName, string invocationId, GetStatefulAsyncInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStatefulAsyncInvocationHeaders headers = new GetStatefulAsyncInvocationHeaders();
            return await GetStatefulAsyncInvocationWithOptionsAsync(serviceName, functionName, invocationId, request, headers, runtime);
        }

        public GetTriggerResponse GetTriggerWithOptions(string serviceName, string functionName, string triggerName, GetTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrigger",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTriggerResponse> GetTriggerWithOptionsAsync(string serviceName, string functionName, string triggerName, GetTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrigger",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTriggerResponse GetTrigger(string serviceName, string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTriggerHeaders headers = new GetTriggerHeaders();
            return GetTriggerWithOptions(serviceName, functionName, triggerName, headers, runtime);
        }

        public async Task<GetTriggerResponse> GetTriggerAsync(string serviceName, string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTriggerHeaders headers = new GetTriggerHeaders();
            return await GetTriggerWithOptionsAsync(serviceName, functionName, triggerName, headers, runtime);
        }

        public InvokeFunctionResponse InvokeFunctionWithOptions(string serviceName, string functionName, InvokeFunctionRequest request, InvokeFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            byte[] body = null;
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body = request.Body;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["X-Fc-Invocation-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["X-Fc-Log-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcStatefulAsyncInvocationEnable))
            {
                realHeaders["X-Fc-Stateful-Async-Invocation-Enable"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcStatefulAsyncInvocationEnable);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcStatefulAsyncInvocationId))
            {
                realHeaders["X-Fc-Stateful-Async-Invocation-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcStatefulAsyncInvocationId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/invocations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "byte",
                BodyType = "byte",
            };
            return TeaModel.ToObject<InvokeFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvokeFunctionResponse> InvokeFunctionWithOptionsAsync(string serviceName, string functionName, InvokeFunctionRequest request, InvokeFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            byte[] body = null;
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body = request.Body;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["X-Fc-Invocation-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["X-Fc-Log-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcStatefulAsyncInvocationEnable))
            {
                realHeaders["X-Fc-Stateful-Async-Invocation-Enable"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcStatefulAsyncInvocationEnable);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcStatefulAsyncInvocationId))
            {
                realHeaders["X-Fc-Stateful-Async-Invocation-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcStatefulAsyncInvocationId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/invocations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "byte",
                BodyType = "byte",
            };
            return TeaModel.ToObject<InvokeFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvokeFunctionResponse InvokeFunction(string serviceName, string functionName, InvokeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeFunctionHeaders headers = new InvokeFunctionHeaders();
            return InvokeFunctionWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<InvokeFunctionResponse> InvokeFunctionAsync(string serviceName, string functionName, InvokeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeFunctionHeaders headers = new InvokeFunctionHeaders();
            return await InvokeFunctionWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListAliasesResponse ListAliasesWithOptions(string serviceName, ListAliasesRequest request, ListAliasesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliases",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliasesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAliasesResponse> ListAliasesWithOptionsAsync(string serviceName, ListAliasesRequest request, ListAliasesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliases",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAliasesResponse ListAliases(string serviceName, ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAliasesHeaders headers = new ListAliasesHeaders();
            return ListAliasesWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<ListAliasesResponse> ListAliasesAsync(string serviceName, ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAliasesHeaders headers = new ListAliasesHeaders();
            return await ListAliasesWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public ListCustomDomainsResponse ListCustomDomainsWithOptions(ListCustomDomainsRequest request, ListCustomDomainsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomDomains",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCustomDomainsResponse> ListCustomDomainsWithOptionsAsync(ListCustomDomainsRequest request, ListCustomDomainsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomDomains",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCustomDomainsResponse ListCustomDomains(ListCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomDomainsHeaders headers = new ListCustomDomainsHeaders();
            return ListCustomDomainsWithOptions(request, headers, runtime);
        }

        public async Task<ListCustomDomainsResponse> ListCustomDomainsAsync(ListCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomDomainsHeaders headers = new ListCustomDomainsHeaders();
            return await ListCustomDomainsWithOptionsAsync(request, headers, runtime);
        }

        public ListEventSourcesResponse ListEventSourcesWithOptions(string serviceName, string functionName, ListEventSourcesRequest request, ListEventSourcesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventSources",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/event-sources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventSourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEventSourcesResponse> ListEventSourcesWithOptionsAsync(string serviceName, string functionName, ListEventSourcesRequest request, ListEventSourcesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventSources",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/event-sources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEventSourcesResponse ListEventSources(string serviceName, string functionName, ListEventSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventSourcesHeaders headers = new ListEventSourcesHeaders();
            return ListEventSourcesWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<ListEventSourcesResponse> ListEventSourcesAsync(string serviceName, string functionName, ListEventSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEventSourcesHeaders headers = new ListEventSourcesHeaders();
            return await ListEventSourcesWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        /**
          * StatefulAsyncInvocation indicates whether the asynchronous task feature is enabled. If StatefulAsyncInvocation is set to true, the asynchronous task is enabled. All asynchronous invocations to the function corresponding to this configuration change to asynchronous task mode.
          *
          * @param request ListFunctionAsyncInvokeConfigsRequest
          * @param headers ListFunctionAsyncInvokeConfigsHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListFunctionAsyncInvokeConfigsResponse
         */
        public ListFunctionAsyncInvokeConfigsResponse ListFunctionAsyncInvokeConfigsWithOptions(string serviceName, string functionName, ListFunctionAsyncInvokeConfigsRequest request, ListFunctionAsyncInvokeConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["X-Fc-Invocation-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["X-Fc-Log-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionAsyncInvokeConfigs",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionAsyncInvokeConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * StatefulAsyncInvocation indicates whether the asynchronous task feature is enabled. If StatefulAsyncInvocation is set to true, the asynchronous task is enabled. All asynchronous invocations to the function corresponding to this configuration change to asynchronous task mode.
          *
          * @param request ListFunctionAsyncInvokeConfigsRequest
          * @param headers ListFunctionAsyncInvokeConfigsHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListFunctionAsyncInvokeConfigsResponse
         */
        public async Task<ListFunctionAsyncInvokeConfigsResponse> ListFunctionAsyncInvokeConfigsWithOptionsAsync(string serviceName, string functionName, ListFunctionAsyncInvokeConfigsRequest request, ListFunctionAsyncInvokeConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["X-Fc-Invocation-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["X-Fc-Log-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionAsyncInvokeConfigs",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionAsyncInvokeConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * StatefulAsyncInvocation indicates whether the asynchronous task feature is enabled. If StatefulAsyncInvocation is set to true, the asynchronous task is enabled. All asynchronous invocations to the function corresponding to this configuration change to asynchronous task mode.
          *
          * @param request ListFunctionAsyncInvokeConfigsRequest
          * @return ListFunctionAsyncInvokeConfigsResponse
         */
        public ListFunctionAsyncInvokeConfigsResponse ListFunctionAsyncInvokeConfigs(string serviceName, string functionName, ListFunctionAsyncInvokeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFunctionAsyncInvokeConfigsHeaders headers = new ListFunctionAsyncInvokeConfigsHeaders();
            return ListFunctionAsyncInvokeConfigsWithOptions(serviceName, functionName, request, headers, runtime);
        }

        /**
          * StatefulAsyncInvocation indicates whether the asynchronous task feature is enabled. If StatefulAsyncInvocation is set to true, the asynchronous task is enabled. All asynchronous invocations to the function corresponding to this configuration change to asynchronous task mode.
          *
          * @param request ListFunctionAsyncInvokeConfigsRequest
          * @return ListFunctionAsyncInvokeConfigsResponse
         */
        public async Task<ListFunctionAsyncInvokeConfigsResponse> ListFunctionAsyncInvokeConfigsAsync(string serviceName, string functionName, ListFunctionAsyncInvokeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFunctionAsyncInvokeConfigsHeaders headers = new ListFunctionAsyncInvokeConfigsHeaders();
            return await ListFunctionAsyncInvokeConfigsWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListFunctionsResponse ListFunctionsWithOptions(string serviceName, ListFunctionsRequest request, ListFunctionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFunctionsResponse> ListFunctionsWithOptionsAsync(string serviceName, ListFunctionsRequest request, ListFunctionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFunctionsResponse ListFunctions(string serviceName, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFunctionsHeaders headers = new ListFunctionsHeaders();
            return ListFunctionsWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<ListFunctionsResponse> ListFunctionsAsync(string serviceName, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFunctionsHeaders headers = new ListFunctionsHeaders();
            return await ListFunctionsWithOptionsAsync(serviceName, request, headers, runtime);
        }

        /**
          * The ListInstances operation allows you to query the available instances of a function.
          * Available instances are instances that are processing requests or can be scheduled to process requests. Available instances queried by the ListInstances operation are the same as those that can be used when you call the InvokeFunction operation with the same values specified for the `serviceName`, `functionName`, and `qualifier` parameters.
          *
          * @param request ListInstancesRequest
          * @param headers ListInstancesHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(string serviceName, string functionName, ListInstancesRequest request, ListInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The ListInstances operation allows you to query the available instances of a function.
          * Available instances are instances that are processing requests or can be scheduled to process requests. Available instances queried by the ListInstances operation are the same as those that can be used when you call the InvokeFunction operation with the same values specified for the `serviceName`, `functionName`, and `qualifier` parameters.
          *
          * @param request ListInstancesRequest
          * @param headers ListInstancesHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(string serviceName, string functionName, ListInstancesRequest request, ListInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The ListInstances operation allows you to query the available instances of a function.
          * Available instances are instances that are processing requests or can be scheduled to process requests. Available instances queried by the ListInstances operation are the same as those that can be used when you call the InvokeFunction operation with the same values specified for the `serviceName`, `functionName`, and `qualifier` parameters.
          *
          * @param request ListInstancesRequest
          * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(string serviceName, string functionName, ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInstancesHeaders headers = new ListInstancesHeaders();
            return ListInstancesWithOptions(serviceName, functionName, request, headers, runtime);
        }

        /**
          * The ListInstances operation allows you to query the available instances of a function.
          * Available instances are instances that are processing requests or can be scheduled to process requests. Available instances queried by the ListInstances operation are the same as those that can be used when you call the InvokeFunction operation with the same values specified for the `serviceName`, `functionName`, and `qualifier` parameters.
          *
          * @param request ListInstancesRequest
          * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(string serviceName, string functionName, ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInstancesHeaders headers = new ListInstancesHeaders();
            return await ListInstancesWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListLayerVersionsResponse ListLayerVersionsWithOptions(string layerName, ListLayerVersionsRequest request, ListLayerVersionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartVersion))
            {
                query["startVersion"] = request.StartVersion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayerVersions",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayerVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLayerVersionsResponse> ListLayerVersionsWithOptionsAsync(string layerName, ListLayerVersionsRequest request, ListLayerVersionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartVersion))
            {
                query["startVersion"] = request.StartVersion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayerVersions",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayerVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLayerVersionsResponse ListLayerVersions(string layerName, ListLayerVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListLayerVersionsHeaders headers = new ListLayerVersionsHeaders();
            return ListLayerVersionsWithOptions(layerName, request, headers, runtime);
        }

        public async Task<ListLayerVersionsResponse> ListLayerVersionsAsync(string layerName, ListLayerVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListLayerVersionsHeaders headers = new ListLayerVersionsHeaders();
            return await ListLayerVersionsWithOptionsAsync(layerName, request, headers, runtime);
        }

        public ListLayersResponse ListLayersWithOptions(ListLayersRequest request, ListLayersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Official))
            {
                query["official"] = request.Official;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayers",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLayersResponse> ListLayersWithOptionsAsync(ListLayersRequest request, ListLayersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Official))
            {
                query["official"] = request.Official;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayers",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLayersResponse ListLayers(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListLayersHeaders headers = new ListLayersHeaders();
            return ListLayersWithOptions(request, headers, runtime);
        }

        public async Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListLayersHeaders headers = new ListLayersHeaders();
            return await ListLayersWithOptionsAsync(request, headers, runtime);
        }

        public ListOnDemandConfigsResponse ListOnDemandConfigsWithOptions(ListOnDemandConfigsRequest request, ListOnDemandConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOnDemandConfigs",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/on-demand-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOnDemandConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOnDemandConfigsResponse> ListOnDemandConfigsWithOptionsAsync(ListOnDemandConfigsRequest request, ListOnDemandConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOnDemandConfigs",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/on-demand-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOnDemandConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOnDemandConfigsResponse ListOnDemandConfigs(ListOnDemandConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOnDemandConfigsHeaders headers = new ListOnDemandConfigsHeaders();
            return ListOnDemandConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListOnDemandConfigsResponse> ListOnDemandConfigsAsync(ListOnDemandConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOnDemandConfigsHeaders headers = new ListOnDemandConfigsHeaders();
            return await ListOnDemandConfigsWithOptionsAsync(request, headers, runtime);
        }

        public ListProvisionConfigsResponse ListProvisionConfigsWithOptions(ListProvisionConfigsRequest request, ListProvisionConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProvisionConfigs",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/provision-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProvisionConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProvisionConfigsResponse> ListProvisionConfigsWithOptionsAsync(ListProvisionConfigsRequest request, ListProvisionConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProvisionConfigs",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/provision-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProvisionConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProvisionConfigsResponse ListProvisionConfigs(ListProvisionConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProvisionConfigsHeaders headers = new ListProvisionConfigsHeaders();
            return ListProvisionConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListProvisionConfigsResponse> ListProvisionConfigsAsync(ListProvisionConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProvisionConfigsHeaders headers = new ListProvisionConfigsHeaders();
            return await ListProvisionConfigsWithOptionsAsync(request, headers, runtime);
        }

        public ListReservedCapacitiesResponse ListReservedCapacitiesWithOptions(ListReservedCapacitiesRequest request, ListReservedCapacitiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReservedCapacities",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/reserved-capacities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReservedCapacitiesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListReservedCapacitiesResponse> ListReservedCapacitiesWithOptionsAsync(ListReservedCapacitiesRequest request, ListReservedCapacitiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReservedCapacities",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/reserved-capacities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReservedCapacitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListReservedCapacitiesResponse ListReservedCapacities(ListReservedCapacitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListReservedCapacitiesHeaders headers = new ListReservedCapacitiesHeaders();
            return ListReservedCapacitiesWithOptions(request, headers, runtime);
        }

        public async Task<ListReservedCapacitiesResponse> ListReservedCapacitiesAsync(ListReservedCapacitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListReservedCapacitiesHeaders headers = new ListReservedCapacitiesHeaders();
            return await ListReservedCapacitiesWithOptionsAsync(request, headers, runtime);
        }

        public ListServiceVersionsResponse ListServiceVersionsWithOptions(string serviceName, ListServiceVersionsRequest request, ListServiceVersionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceVersions",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceVersionsResponse> ListServiceVersionsWithOptionsAsync(string serviceName, ListServiceVersionsRequest request, ListServiceVersionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceVersions",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceVersionsResponse ListServiceVersions(string serviceName, ListServiceVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListServiceVersionsHeaders headers = new ListServiceVersionsHeaders();
            return ListServiceVersionsWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<ListServiceVersionsResponse> ListServiceVersionsAsync(string serviceName, ListServiceVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListServiceVersionsHeaders headers = new ListServiceVersionsHeaders();
            return await ListServiceVersionsWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, ListServicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, ListServicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListServicesHeaders headers = new ListServicesHeaders();
            return ListServicesWithOptions(request, headers, runtime);
        }

        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListServicesHeaders headers = new ListServicesHeaders();
            return await ListServicesWithOptionsAsync(request, headers, runtime);
        }

        /**
          * The metadata of the service and function to which the asynchronous task belongs.
          *
          * @param request ListStatefulAsyncInvocationFunctionsRequest
          * @param headers ListStatefulAsyncInvocationFunctionsHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStatefulAsyncInvocationFunctionsResponse
         */
        public ListStatefulAsyncInvocationFunctionsResponse ListStatefulAsyncInvocationFunctionsWithOptions(ListStatefulAsyncInvocationFunctionsRequest request, ListStatefulAsyncInvocationFunctionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStatefulAsyncInvocationFunctions",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/stateful-async-invocation-functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStatefulAsyncInvocationFunctionsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The metadata of the service and function to which the asynchronous task belongs.
          *
          * @param request ListStatefulAsyncInvocationFunctionsRequest
          * @param headers ListStatefulAsyncInvocationFunctionsHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStatefulAsyncInvocationFunctionsResponse
         */
        public async Task<ListStatefulAsyncInvocationFunctionsResponse> ListStatefulAsyncInvocationFunctionsWithOptionsAsync(ListStatefulAsyncInvocationFunctionsRequest request, ListStatefulAsyncInvocationFunctionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStatefulAsyncInvocationFunctions",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/stateful-async-invocation-functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStatefulAsyncInvocationFunctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The metadata of the service and function to which the asynchronous task belongs.
          *
          * @param request ListStatefulAsyncInvocationFunctionsRequest
          * @return ListStatefulAsyncInvocationFunctionsResponse
         */
        public ListStatefulAsyncInvocationFunctionsResponse ListStatefulAsyncInvocationFunctions(ListStatefulAsyncInvocationFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListStatefulAsyncInvocationFunctionsHeaders headers = new ListStatefulAsyncInvocationFunctionsHeaders();
            return ListStatefulAsyncInvocationFunctionsWithOptions(request, headers, runtime);
        }

        /**
          * The metadata of the service and function to which the asynchronous task belongs.
          *
          * @param request ListStatefulAsyncInvocationFunctionsRequest
          * @return ListStatefulAsyncInvocationFunctionsResponse
         */
        public async Task<ListStatefulAsyncInvocationFunctionsResponse> ListStatefulAsyncInvocationFunctionsAsync(ListStatefulAsyncInvocationFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListStatefulAsyncInvocationFunctionsHeaders headers = new ListStatefulAsyncInvocationFunctionsHeaders();
            return await ListStatefulAsyncInvocationFunctionsWithOptionsAsync(request, headers, runtime);
        }

        /**
          * The name of the service to which the asynchronous task belongs.
          *
          * @param request ListStatefulAsyncInvocationsRequest
          * @param headers ListStatefulAsyncInvocationsHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStatefulAsyncInvocationsResponse
         */
        public ListStatefulAsyncInvocationsResponse ListStatefulAsyncInvocationsWithOptions(string serviceName, string functionName, ListStatefulAsyncInvocationsRequest request, ListStatefulAsyncInvocationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePayload))
            {
                query["includePayload"] = request.IncludePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationIdPrefix))
            {
                query["invocationIdPrefix"] = request.InvocationIdPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrderByTime))
            {
                query["sortOrderByTime"] = request.SortOrderByTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartedTimeBegin))
            {
                query["startedTimeBegin"] = request.StartedTimeBegin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartedTimeEnd))
            {
                query["startedTimeEnd"] = request.StartedTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["X-Fc-Invocation-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["X-Fc-Log-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStatefulAsyncInvocations",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/stateful-async-invocations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStatefulAsyncInvocationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The name of the service to which the asynchronous task belongs.
          *
          * @param request ListStatefulAsyncInvocationsRequest
          * @param headers ListStatefulAsyncInvocationsHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStatefulAsyncInvocationsResponse
         */
        public async Task<ListStatefulAsyncInvocationsResponse> ListStatefulAsyncInvocationsWithOptionsAsync(string serviceName, string functionName, ListStatefulAsyncInvocationsRequest request, ListStatefulAsyncInvocationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePayload))
            {
                query["includePayload"] = request.IncludePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationIdPrefix))
            {
                query["invocationIdPrefix"] = request.InvocationIdPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrderByTime))
            {
                query["sortOrderByTime"] = request.SortOrderByTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartedTimeBegin))
            {
                query["startedTimeBegin"] = request.StartedTimeBegin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartedTimeEnd))
            {
                query["startedTimeEnd"] = request.StartedTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["X-Fc-Invocation-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["X-Fc-Log-Type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStatefulAsyncInvocations",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/stateful-async-invocations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStatefulAsyncInvocationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The name of the service to which the asynchronous task belongs.
          *
          * @param request ListStatefulAsyncInvocationsRequest
          * @return ListStatefulAsyncInvocationsResponse
         */
        public ListStatefulAsyncInvocationsResponse ListStatefulAsyncInvocations(string serviceName, string functionName, ListStatefulAsyncInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListStatefulAsyncInvocationsHeaders headers = new ListStatefulAsyncInvocationsHeaders();
            return ListStatefulAsyncInvocationsWithOptions(serviceName, functionName, request, headers, runtime);
        }

        /**
          * The name of the service to which the asynchronous task belongs.
          *
          * @param request ListStatefulAsyncInvocationsRequest
          * @return ListStatefulAsyncInvocationsResponse
         */
        public async Task<ListStatefulAsyncInvocationsResponse> ListStatefulAsyncInvocationsAsync(string serviceName, string functionName, ListStatefulAsyncInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListStatefulAsyncInvocationsHeaders headers = new ListStatefulAsyncInvocationsHeaders();
            return await ListStatefulAsyncInvocationsWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListTaggedResourcesResponse ListTaggedResourcesWithOptions(ListTaggedResourcesRequest request, ListTaggedResourcesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaggedResources",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaggedResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTaggedResourcesResponse> ListTaggedResourcesWithOptionsAsync(ListTaggedResourcesRequest request, ListTaggedResourcesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaggedResources",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaggedResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTaggedResourcesResponse ListTaggedResources(ListTaggedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTaggedResourcesHeaders headers = new ListTaggedResourcesHeaders();
            return ListTaggedResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListTaggedResourcesResponse> ListTaggedResourcesAsync(ListTaggedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTaggedResourcesHeaders headers = new ListTaggedResourcesHeaders();
            return await ListTaggedResourcesWithOptionsAsync(request, headers, runtime);
        }

        public ListTriggersResponse ListTriggersWithOptions(string serviceName, string functionName, ListTriggersRequest request, ListTriggersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTriggers",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTriggersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTriggersResponse> ListTriggersWithOptionsAsync(string serviceName, string functionName, ListTriggersRequest request, ListTriggersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTriggers",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTriggersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTriggersResponse ListTriggers(string serviceName, string functionName, ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTriggersHeaders headers = new ListTriggersHeaders();
            return ListTriggersWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<ListTriggersResponse> ListTriggersAsync(string serviceName, string functionName, ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTriggersHeaders headers = new ListTriggersHeaders();
            return await ListTriggersWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListVpcBindingsResponse ListVpcBindingsWithOptions(string serviceName, ListVpcBindingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcBindings",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/bindings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcBindingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVpcBindingsResponse> ListVpcBindingsWithOptionsAsync(string serviceName, ListVpcBindingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcBindings",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/bindings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVpcBindingsResponse ListVpcBindings(string serviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVpcBindingsHeaders headers = new ListVpcBindingsHeaders();
            return ListVpcBindingsWithOptions(serviceName, headers, runtime);
        }

        public async Task<ListVpcBindingsResponse> ListVpcBindingsAsync(string serviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVpcBindingsHeaders headers = new ListVpcBindingsHeaders();
            return await ListVpcBindingsWithOptionsAsync(serviceName, headers, runtime);
        }

        public PublishServiceVersionResponse PublishServiceVersionWithOptions(string serviceName, PublishServiceVersionRequest request, PublishServiceVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishServiceVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PublishServiceVersionResponse> PublishServiceVersionWithOptionsAsync(string serviceName, PublishServiceVersionRequest request, PublishServiceVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishServiceVersion",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PublishServiceVersionResponse PublishServiceVersion(string serviceName, PublishServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishServiceVersionHeaders headers = new PublishServiceVersionHeaders();
            return PublishServiceVersionWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<PublishServiceVersionResponse> PublishServiceVersionAsync(string serviceName, PublishServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishServiceVersionHeaders headers = new PublishServiceVersionHeaders();
            return await PublishServiceVersionWithOptionsAsync(serviceName, request, headers, runtime);
        }

        /**
          * The maximum validity period of messages.
          *
          * @param request PutFunctionAsyncInvokeConfigRequest
          * @param headers PutFunctionAsyncInvokeConfigHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutFunctionAsyncInvokeConfigResponse
         */
        public PutFunctionAsyncInvokeConfigResponse PutFunctionAsyncInvokeConfigWithOptions(string serviceName, string functionName, PutFunctionAsyncInvokeConfigRequest request, PutFunctionAsyncInvokeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationConfig))
            {
                body["destinationConfig"] = request.DestinationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAsyncEventAgeInSeconds))
            {
                body["maxAsyncEventAgeInSeconds"] = request.MaxAsyncEventAgeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAsyncRetryAttempts))
            {
                body["maxAsyncRetryAttempts"] = request.MaxAsyncRetryAttempts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatefulInvocation))
            {
                body["statefulInvocation"] = request.StatefulInvocation;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutFunctionAsyncInvokeConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutFunctionAsyncInvokeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The maximum validity period of messages.
          *
          * @param request PutFunctionAsyncInvokeConfigRequest
          * @param headers PutFunctionAsyncInvokeConfigHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutFunctionAsyncInvokeConfigResponse
         */
        public async Task<PutFunctionAsyncInvokeConfigResponse> PutFunctionAsyncInvokeConfigWithOptionsAsync(string serviceName, string functionName, PutFunctionAsyncInvokeConfigRequest request, PutFunctionAsyncInvokeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationConfig))
            {
                body["destinationConfig"] = request.DestinationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAsyncEventAgeInSeconds))
            {
                body["maxAsyncEventAgeInSeconds"] = request.MaxAsyncEventAgeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAsyncRetryAttempts))
            {
                body["maxAsyncRetryAttempts"] = request.MaxAsyncRetryAttempts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatefulInvocation))
            {
                body["statefulInvocation"] = request.StatefulInvocation;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutFunctionAsyncInvokeConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutFunctionAsyncInvokeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The maximum validity period of messages.
          *
          * @param request PutFunctionAsyncInvokeConfigRequest
          * @return PutFunctionAsyncInvokeConfigResponse
         */
        public PutFunctionAsyncInvokeConfigResponse PutFunctionAsyncInvokeConfig(string serviceName, string functionName, PutFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutFunctionAsyncInvokeConfigHeaders headers = new PutFunctionAsyncInvokeConfigHeaders();
            return PutFunctionAsyncInvokeConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        /**
          * The maximum validity period of messages.
          *
          * @param request PutFunctionAsyncInvokeConfigRequest
          * @return PutFunctionAsyncInvokeConfigResponse
         */
        public async Task<PutFunctionAsyncInvokeConfigResponse> PutFunctionAsyncInvokeConfigAsync(string serviceName, string functionName, PutFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutFunctionAsyncInvokeConfigHeaders headers = new PutFunctionAsyncInvokeConfigHeaders();
            return await PutFunctionAsyncInvokeConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public PutFunctionOnDemandConfigResponse PutFunctionOnDemandConfigWithOptions(string serviceName, string functionName, PutFunctionOnDemandConfigRequest request, PutFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumInstanceCount))
            {
                body["maximumInstanceCount"] = request.MaximumInstanceCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutFunctionOnDemandConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/on-demand-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutFunctionOnDemandConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutFunctionOnDemandConfigResponse> PutFunctionOnDemandConfigWithOptionsAsync(string serviceName, string functionName, PutFunctionOnDemandConfigRequest request, PutFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumInstanceCount))
            {
                body["maximumInstanceCount"] = request.MaximumInstanceCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutFunctionOnDemandConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/on-demand-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutFunctionOnDemandConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutFunctionOnDemandConfigResponse PutFunctionOnDemandConfig(string serviceName, string functionName, PutFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutFunctionOnDemandConfigHeaders headers = new PutFunctionOnDemandConfigHeaders();
            return PutFunctionOnDemandConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<PutFunctionOnDemandConfigResponse> PutFunctionOnDemandConfigAsync(string serviceName, string functionName, PutFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutFunctionOnDemandConfigHeaders headers = new PutFunctionOnDemandConfigHeaders();
            return await PutFunctionOnDemandConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public PutLayerACLResponse PutLayerACLWithOptions(string layerName, PutLayerACLRequest request, PutLayerACLHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLayerACL",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/acl",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutLayerACLResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutLayerACLResponse> PutLayerACLWithOptionsAsync(string layerName, PutLayerACLRequest request, PutLayerACLHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLayerACL",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/acl",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutLayerACLResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutLayerACLResponse PutLayerACL(string layerName, PutLayerACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutLayerACLHeaders headers = new PutLayerACLHeaders();
            return PutLayerACLWithOptions(layerName, request, headers, runtime);
        }

        public async Task<PutLayerACLResponse> PutLayerACLAsync(string layerName, PutLayerACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutLayerACLHeaders headers = new PutLayerACLHeaders();
            return await PutLayerACLWithOptionsAsync(layerName, request, headers, runtime);
        }

        public PutProvisionConfigResponse PutProvisionConfigWithOptions(string serviceName, string functionName, PutProvisionConfigRequest request, PutProvisionConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlwaysAllocateCPU))
            {
                body["alwaysAllocateCPU"] = request.AlwaysAllocateCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledActions))
            {
                body["scheduledActions"] = request.ScheduledActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTrackingPolicies))
            {
                body["targetTrackingPolicies"] = request.TargetTrackingPolicies;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProvisionConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProvisionConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutProvisionConfigResponse> PutProvisionConfigWithOptionsAsync(string serviceName, string functionName, PutProvisionConfigRequest request, PutProvisionConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlwaysAllocateCPU))
            {
                body["alwaysAllocateCPU"] = request.AlwaysAllocateCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledActions))
            {
                body["scheduledActions"] = request.ScheduledActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTrackingPolicies))
            {
                body["targetTrackingPolicies"] = request.TargetTrackingPolicies;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProvisionConfig",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProvisionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutProvisionConfigResponse PutProvisionConfig(string serviceName, string functionName, PutProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutProvisionConfigHeaders headers = new PutProvisionConfigHeaders();
            return PutProvisionConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<PutProvisionConfigResponse> PutProvisionConfigAsync(string serviceName, string functionName, PutProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutProvisionConfigHeaders headers = new PutProvisionConfigHeaders();
            return await PutProvisionConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public RegisterEventSourceResponse RegisterEventSourceWithOptions(string serviceName, string functionName, RegisterEventSourceRequest request, RegisterEventSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["sourceArn"] = request.SourceArn;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterEventSource",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/event-sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterEventSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterEventSourceResponse> RegisterEventSourceWithOptionsAsync(string serviceName, string functionName, RegisterEventSourceRequest request, RegisterEventSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["sourceArn"] = request.SourceArn;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterEventSource",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/event-sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterEventSourceResponse RegisterEventSource(string serviceName, string functionName, RegisterEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterEventSourceHeaders headers = new RegisterEventSourceHeaders();
            return RegisterEventSourceWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<RegisterEventSourceResponse> RegisterEventSourceAsync(string serviceName, string functionName, RegisterEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterEventSourceHeaders headers = new RegisterEventSourceHeaders();
            return await RegisterEventSourceWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ReleaseGPUInstanceResponse ReleaseGPUInstanceWithOptions(string instanceId, ReleaseGPUInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGPUInstance",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/gpuInstances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ReleaseGPUInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseGPUInstanceResponse> ReleaseGPUInstanceWithOptionsAsync(string instanceId, ReleaseGPUInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseGPUInstance",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/gpuInstances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ReleaseGPUInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseGPUInstanceResponse ReleaseGPUInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGPUInstanceHeaders headers = new ReleaseGPUInstanceHeaders();
            return ReleaseGPUInstanceWithOptions(instanceId, headers, runtime);
        }

        public async Task<ReleaseGPUInstanceResponse> ReleaseGPUInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseGPUInstanceHeaders headers = new ReleaseGPUInstanceHeaders();
            return await ReleaseGPUInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
          * StatefulAsyncInvocation: asynchronous task. Asynchronous tasks allow you to manage the states on the basis of common asynchronous invocations, which is more suitable for task scenarios.
          *
          * @param request StopStatefulAsyncInvocationRequest
          * @param headers StopStatefulAsyncInvocationHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopStatefulAsyncInvocationResponse
         */
        public StopStatefulAsyncInvocationResponse StopStatefulAsyncInvocationWithOptions(string serviceName, string functionName, string invocationId, StopStatefulAsyncInvocationRequest request, StopStatefulAsyncInvocationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopStatefulAsyncInvocation",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/stateful-async-invocations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(invocationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopStatefulAsyncInvocationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * StatefulAsyncInvocation: asynchronous task. Asynchronous tasks allow you to manage the states on the basis of common asynchronous invocations, which is more suitable for task scenarios.
          *
          * @param request StopStatefulAsyncInvocationRequest
          * @param headers StopStatefulAsyncInvocationHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopStatefulAsyncInvocationResponse
         */
        public async Task<StopStatefulAsyncInvocationResponse> StopStatefulAsyncInvocationWithOptionsAsync(string serviceName, string functionName, string invocationId, StopStatefulAsyncInvocationRequest request, StopStatefulAsyncInvocationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopStatefulAsyncInvocation",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/stateful-async-invocations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(invocationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopStatefulAsyncInvocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * StatefulAsyncInvocation: asynchronous task. Asynchronous tasks allow you to manage the states on the basis of common asynchronous invocations, which is more suitable for task scenarios.
          *
          * @param request StopStatefulAsyncInvocationRequest
          * @return StopStatefulAsyncInvocationResponse
         */
        public StopStatefulAsyncInvocationResponse StopStatefulAsyncInvocation(string serviceName, string functionName, string invocationId, StopStatefulAsyncInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopStatefulAsyncInvocationHeaders headers = new StopStatefulAsyncInvocationHeaders();
            return StopStatefulAsyncInvocationWithOptions(serviceName, functionName, invocationId, request, headers, runtime);
        }

        /**
          * StatefulAsyncInvocation: asynchronous task. Asynchronous tasks allow you to manage the states on the basis of common asynchronous invocations, which is more suitable for task scenarios.
          *
          * @param request StopStatefulAsyncInvocationRequest
          * @return StopStatefulAsyncInvocationResponse
         */
        public async Task<StopStatefulAsyncInvocationResponse> StopStatefulAsyncInvocationAsync(string serviceName, string functionName, string invocationId, StopStatefulAsyncInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopStatefulAsyncInvocationHeaders headers = new StopStatefulAsyncInvocationHeaders();
            return await StopStatefulAsyncInvocationWithOptionsAsync(serviceName, functionName, invocationId, request, headers, runtime);
        }

        public TagResourceResponse TagResourceWithOptions(TagResourceRequest request, TagResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["resourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResource",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/tag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<TagResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourceResponse> TagResourceWithOptionsAsync(TagResourceRequest request, TagResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["resourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResource",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/tag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<TagResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TagResourceResponse TagResource(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TagResourceHeaders headers = new TagResourceHeaders();
            return TagResourceWithOptions(request, headers, runtime);
        }

        public async Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TagResourceHeaders headers = new TagResourceHeaders();
            return await TagResourceWithOptionsAsync(request, headers, runtime);
        }

        public UntagResourceResponse UntagResourceWithOptions(UntagResourceRequest request, UntagResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["resourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                body["tagKeys"] = request.TagKeys;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResource",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/tag",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UntagResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourceResponse> UntagResourceWithOptionsAsync(UntagResourceRequest request, UntagResourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["resourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                body["tagKeys"] = request.TagKeys;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResource",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/tag",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UntagResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UntagResourceHeaders headers = new UntagResourceHeaders();
            return UntagResourceWithOptions(request, headers, runtime);
        }

        public async Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UntagResourceHeaders headers = new UntagResourceHeaders();
            return await UntagResourceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAliasResponse UpdateAliasWithOptions(string serviceName, string aliasName, UpdateAliasRequest request, UpdateAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalVersionWeight))
            {
                body["additionalVersionWeight"] = request.AdditionalVersionWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolvePolicy))
            {
                body["resolvePolicy"] = request.ResolvePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutePolicy))
            {
                body["routePolicy"] = request.RoutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlias",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAliasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAliasResponse> UpdateAliasWithOptionsAsync(string serviceName, string aliasName, UpdateAliasRequest request, UpdateAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalVersionWeight))
            {
                body["additionalVersionWeight"] = request.AdditionalVersionWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolvePolicy))
            {
                body["resolvePolicy"] = request.ResolvePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutePolicy))
            {
                body["routePolicy"] = request.RoutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlias",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAliasResponse UpdateAlias(string serviceName, string aliasName, UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAliasHeaders headers = new UpdateAliasHeaders();
            return UpdateAliasWithOptions(serviceName, aliasName, request, headers, runtime);
        }

        public async Task<UpdateAliasResponse> UpdateAliasAsync(string serviceName, string aliasName, UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAliasHeaders headers = new UpdateAliasHeaders();
            return await UpdateAliasWithOptionsAsync(serviceName, aliasName, request, headers, runtime);
        }

        public UpdateCustomDomainResponse UpdateCustomDomainWithOptions(string domainName, UpdateCustomDomainRequest request, UpdateCustomDomainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertConfig))
            {
                body["certConfig"] = request.CertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteConfig))
            {
                body["routeConfig"] = request.RouteConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsConfig))
            {
                body["tlsConfig"] = request.TlsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafConfig))
            {
                body["wafConfig"] = request.WafConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomDomain",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateCustomDomainResponse> UpdateCustomDomainWithOptionsAsync(string domainName, UpdateCustomDomainRequest request, UpdateCustomDomainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertConfig))
            {
                body["certConfig"] = request.CertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteConfig))
            {
                body["routeConfig"] = request.RouteConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsConfig))
            {
                body["tlsConfig"] = request.TlsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WafConfig))
            {
                body["wafConfig"] = request.WafConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomDomain",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateCustomDomainResponse UpdateCustomDomain(string domainName, UpdateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomDomainHeaders headers = new UpdateCustomDomainHeaders();
            return UpdateCustomDomainWithOptions(domainName, request, headers, runtime);
        }

        public async Task<UpdateCustomDomainResponse> UpdateCustomDomainAsync(string domainName, UpdateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomDomainHeaders headers = new UpdateCustomDomainHeaders();
            return await UpdateCustomDomainWithOptionsAsync(domainName, request, headers, runtime);
        }

        public UpdateFunctionResponse UpdateFunctionWithOptions(string serviceName, string functionName, UpdateFunctionRequest request, UpdateFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceConcurrency))
            {
                body["InstanceConcurrency"] = request.InstanceConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaPort))
            {
                body["caPort"] = request.CaPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomContainerConfig))
            {
                body["customContainerConfig"] = request.CustomContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDNS))
            {
                body["customDNS"] = request.CustomDNS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHealthCheckConfig))
            {
                body["customHealthCheckConfig"] = request.CustomHealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomRuntimeConfig))
            {
                body["customRuntimeConfig"] = request.CustomRuntimeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["diskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["environmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuMemorySize))
            {
                body["gpuMemorySize"] = request.GpuMemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                body["handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializationTimeout))
            {
                body["initializationTimeout"] = request.InitializationTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initializer))
            {
                body["initializer"] = request.Initializer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLifecycleConfig))
            {
                body["instanceLifecycleConfig"] = request.InstanceLifecycleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSoftConcurrency))
            {
                body["instanceSoftConcurrency"] = request.InstanceSoftConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layers))
            {
                body["layers"] = request.Layers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemorySize))
            {
                body["memorySize"] = request.MemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFunctionResponse> UpdateFunctionWithOptionsAsync(string serviceName, string functionName, UpdateFunctionRequest request, UpdateFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceConcurrency))
            {
                body["InstanceConcurrency"] = request.InstanceConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaPort))
            {
                body["caPort"] = request.CaPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomContainerConfig))
            {
                body["customContainerConfig"] = request.CustomContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDNS))
            {
                body["customDNS"] = request.CustomDNS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHealthCheckConfig))
            {
                body["customHealthCheckConfig"] = request.CustomHealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomRuntimeConfig))
            {
                body["customRuntimeConfig"] = request.CustomRuntimeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["diskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["environmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuMemorySize))
            {
                body["gpuMemorySize"] = request.GpuMemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                body["handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializationTimeout))
            {
                body["initializationTimeout"] = request.InitializationTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initializer))
            {
                body["initializer"] = request.Initializer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLifecycleConfig))
            {
                body["instanceLifecycleConfig"] = request.InstanceLifecycleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSoftConcurrency))
            {
                body["instanceSoftConcurrency"] = request.InstanceSoftConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layers))
            {
                body["layers"] = request.Layers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemorySize))
            {
                body["memorySize"] = request.MemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["X-Fc-Code-Checksum"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcCodeChecksum);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunction",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFunctionResponse UpdateFunction(string serviceName, string functionName, UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFunctionHeaders headers = new UpdateFunctionHeaders();
            return UpdateFunctionWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<UpdateFunctionResponse> UpdateFunctionAsync(string serviceName, string functionName, UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFunctionHeaders headers = new UpdateFunctionHeaders();
            return await UpdateFunctionWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public UpdateServiceResponse UpdateServiceWithOptions(string serviceName, UpdateServiceRequest request, UpdateServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetAccess))
            {
                body["internetAccess"] = request.InternetAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfig))
            {
                body["nasConfig"] = request.NasConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountConfig))
            {
                body["ossMountConfig"] = request.OssMountConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingConfig))
            {
                body["tracingConfig"] = request.TracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcConfig))
            {
                body["vpcConfig"] = request.VpcConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(string serviceName, UpdateServiceRequest request, UpdateServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetAccess))
            {
                body["internetAccess"] = request.InternetAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfig))
            {
                body["nasConfig"] = request.NasConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountConfig))
            {
                body["ossMountConfig"] = request.OssMountConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingConfig))
            {
                body["tracingConfig"] = request.TracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcConfig))
            {
                body["vpcConfig"] = request.VpcConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceResponse UpdateService(string serviceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateServiceHeaders headers = new UpdateServiceHeaders();
            return UpdateServiceWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<UpdateServiceResponse> UpdateServiceAsync(string serviceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateServiceHeaders headers = new UpdateServiceHeaders();
            return await UpdateServiceWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public UpdateTriggerResponse UpdateTriggerWithOptions(string serviceName, string functionName, string triggerName, UpdateTriggerRequest request, UpdateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationRole))
            {
                body["invocationRole"] = request.InvocationRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrigger",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerWithOptionsAsync(string serviceName, string functionName, string triggerName, UpdateTriggerRequest request, UpdateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationRole))
            {
                body["invocationRole"] = request.InvocationRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAccountId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcDate))
            {
                realHeaders["X-Fc-Date"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcDate);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcTraceId))
            {
                realHeaders["X-Fc-Trace-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcTraceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrigger",
                Version = "2021-04-06",
                Protocol = "HTTPS",
                Pathname = "/2021-04-06/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTriggerResponse UpdateTrigger(string serviceName, string functionName, string triggerName, UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
            return UpdateTriggerWithOptions(serviceName, functionName, triggerName, request, headers, runtime);
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(string serviceName, string functionName, string triggerName, UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
            return await UpdateTriggerWithOptionsAsync(serviceName, functionName, triggerName, request, headers, runtime);
        }

    }
}
