// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sts20150401.Models;

namespace AlibabaCloud.SDK.Sts20150401
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "sts.aliyuncs.com"},
                {"cn-beijing-finance-1", "sts.aliyuncs.com"},
                {"cn-beijing-finance-pop", "sts.aliyuncs.com"},
                {"cn-beijing-gov-1", "sts.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "sts.aliyuncs.com"},
                {"cn-edge-1", "sts.aliyuncs.com"},
                {"cn-fujian", "sts.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "sts.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "sts.aliyuncs.com"},
                {"cn-hangzhou-finance", "sts.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "sts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "sts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "sts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "sts.aliyuncs.com"},
                {"cn-hangzhou-test-306", "sts.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "sts.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "sts.aliyuncs.com"},
                {"cn-north-2-gov-1", "sts-vpc.cn-north-2-gov-1.aliyuncs.com"},
                {"cn-qingdao-nebula", "sts.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "sts.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "sts.aliyuncs.com"},
                {"cn-shanghai-inner", "sts.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "sts.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "sts-vpc.cn-shenzhen-finance-1.aliyuncs.com"},
                {"cn-shenzhen-inner", "sts.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "sts.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "sts.aliyuncs.com"},
                {"cn-wuhan", "sts.aliyuncs.com"},
                {"cn-yushanfang", "sts.aliyuncs.com"},
                {"cn-zhangbei", "sts.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "sts.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "sts.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "sts.aliyuncs.com"},
                {"eu-west-1-oxs", "sts.aliyuncs.com"},
                {"rus-west-1-pop", "sts.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("sts", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AssumeRoleResponse AssumeRoleWithOptions(AssumeRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                query["RoleSessionName"] = request.RoleSessionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRole",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssumeRoleResponse> AssumeRoleWithOptionsAsync(AssumeRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                query["RoleSessionName"] = request.RoleSessionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRole",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssumeRoleWithOptions(request, runtime);
        }

        public async Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssumeRoleWithOptionsAsync(request, runtime);
        }

        public AssumeRoleWithOIDCResponse AssumeRoleWithOIDCWithOptions(AssumeRoleWithOIDCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderArn))
            {
                query["OIDCProviderArn"] = request.OIDCProviderArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCToken))
            {
                query["OIDCToken"] = request.OIDCToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                query["RoleSessionName"] = request.RoleSessionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleWithOIDC",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleWithOIDCResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssumeRoleWithOIDCResponse> AssumeRoleWithOIDCWithOptionsAsync(AssumeRoleWithOIDCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderArn))
            {
                query["OIDCProviderArn"] = request.OIDCProviderArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCToken))
            {
                query["OIDCToken"] = request.OIDCToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                query["RoleSessionName"] = request.RoleSessionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleWithOIDC",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleWithOIDCResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssumeRoleWithOIDCResponse AssumeRoleWithOIDC(AssumeRoleWithOIDCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssumeRoleWithOIDCWithOptions(request, runtime);
        }

        public async Task<AssumeRoleWithOIDCResponse> AssumeRoleWithOIDCAsync(AssumeRoleWithOIDCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssumeRoleWithOIDCWithOptionsAsync(request, runtime);
        }

        public AssumeRoleWithSAMLResponse AssumeRoleWithSAMLWithOptions(AssumeRoleWithSAMLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLAssertion))
            {
                query["SAMLAssertion"] = request.SAMLAssertion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderArn))
            {
                query["SAMLProviderArn"] = request.SAMLProviderArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleWithSAML",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleWithSAMLResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLWithOptionsAsync(AssumeRoleWithSAMLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLAssertion))
            {
                query["SAMLAssertion"] = request.SAMLAssertion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderArn))
            {
                query["SAMLProviderArn"] = request.SAMLProviderArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleWithSAML",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleWithSAMLResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssumeRoleWithSAMLWithOptions(request, runtime);
        }

        public async Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssumeRoleWithSAMLWithOptionsAsync(request, runtime);
        }

        public GetCallerIdentityResponse GetCallerIdentityWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallerIdentity",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallerIdentityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCallerIdentityResponse> GetCallerIdentityWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallerIdentity",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallerIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCallerIdentityResponse GetCallerIdentity()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCallerIdentityWithOptions(runtime);
        }

        public async Task<GetCallerIdentityResponse> GetCallerIdentityAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCallerIdentityWithOptionsAsync(runtime);
        }

    }
}
