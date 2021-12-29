// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dcdn20180115.Models;

namespace AlibabaCloud.SDK.Dcdn20180115
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "dcdn.aliyuncs.com"},
                {"ap-northeast-2-pop", "dcdn.aliyuncs.com"},
                {"ap-south-1", "dcdn.aliyuncs.com"},
                {"ap-southeast-1", "dcdn.aliyuncs.com"},
                {"ap-southeast-2", "dcdn.aliyuncs.com"},
                {"ap-southeast-3", "dcdn.aliyuncs.com"},
                {"ap-southeast-5", "dcdn.aliyuncs.com"},
                {"cn-beijing", "dcdn.aliyuncs.com"},
                {"cn-beijing-finance-1", "dcdn.aliyuncs.com"},
                {"cn-beijing-finance-pop", "dcdn.aliyuncs.com"},
                {"cn-beijing-gov-1", "dcdn.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "dcdn.aliyuncs.com"},
                {"cn-chengdu", "dcdn.aliyuncs.com"},
                {"cn-edge-1", "dcdn.aliyuncs.com"},
                {"cn-fujian", "dcdn.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "dcdn.aliyuncs.com"},
                {"cn-hangzhou", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-finance", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-test-306", "dcdn.aliyuncs.com"},
                {"cn-hongkong", "dcdn.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "dcdn.aliyuncs.com"},
                {"cn-huhehaote", "dcdn.aliyuncs.com"},
                {"cn-north-2-gov-1", "dcdn.aliyuncs.com"},
                {"cn-qingdao", "dcdn.aliyuncs.com"},
                {"cn-qingdao-nebula", "dcdn.aliyuncs.com"},
                {"cn-shanghai", "dcdn.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "dcdn.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "dcdn.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dcdn.aliyuncs.com"},
                {"cn-shanghai-inner", "dcdn.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "dcdn.aliyuncs.com"},
                {"cn-shenzhen", "dcdn.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dcdn.aliyuncs.com"},
                {"cn-shenzhen-inner", "dcdn.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "dcdn.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "dcdn.aliyuncs.com"},
                {"cn-wuhan", "dcdn.aliyuncs.com"},
                {"cn-yushanfang", "dcdn.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "dcdn.aliyuncs.com"},
                {"cn-zhangjiakou", "dcdn.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "dcdn.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "dcdn.aliyuncs.com"},
                {"eu-central-1", "dcdn.aliyuncs.com"},
                {"eu-west-1", "dcdn.aliyuncs.com"},
                {"eu-west-1-oxs", "dcdn.aliyuncs.com"},
                {"me-east-1", "dcdn.aliyuncs.com"},
                {"rus-west-1-pop", "dcdn.aliyuncs.com"},
                {"us-east-1", "dcdn.aliyuncs.com"},
                {"us-west-1", "dcdn.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dcdn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddDcdnDomainResponse AddDcdnDomainWithOptions(AddDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDcdnDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddDcdnDomainResponse> AddDcdnDomainWithOptionsAsync(AddDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDcdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddDcdnDomainResponse AddDcdnDomain(AddDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDcdnDomainWithOptions(request, runtime);
        }

        public async Task<AddDcdnDomainResponse> AddDcdnDomainAsync(AddDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDcdnDomainWithOptionsAsync(request, runtime);
        }

        public AddDcdnIpaDomainResponse AddDcdnIpaDomainWithOptions(AddDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDcdnIpaDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddDcdnIpaDomainResponse> AddDcdnIpaDomainWithOptionsAsync(AddDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDcdnIpaDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddDcdnIpaDomainResponse AddDcdnIpaDomain(AddDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<AddDcdnIpaDomainResponse> AddDcdnIpaDomainAsync(AddDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public BatchAddDcdnDomainResponse BatchAddDcdnDomainWithOptions(BatchAddDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddDcdnDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchAddDcdnDomainResponse> BatchAddDcdnDomainWithOptionsAsync(BatchAddDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddDcdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchAddDcdnDomainResponse BatchAddDcdnDomain(BatchAddDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddDcdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchAddDcdnDomainResponse> BatchAddDcdnDomainAsync(BatchAddDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddDcdnDomainWithOptionsAsync(request, runtime);
        }

        public BatchDeleteDcdnDomainConfigsResponse BatchDeleteDcdnDomainConfigsWithOptions(BatchDeleteDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteDcdnDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteDcdnDomainConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchDeleteDcdnDomainConfigsResponse> BatchDeleteDcdnDomainConfigsWithOptionsAsync(BatchDeleteDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteDcdnDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteDcdnDomainConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchDeleteDcdnDomainConfigsResponse BatchDeleteDcdnDomainConfigs(BatchDeleteDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteDcdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchDeleteDcdnDomainConfigsResponse> BatchDeleteDcdnDomainConfigsAsync(BatchDeleteDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteDcdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchSetDcdnDomainCertificateResponse BatchSetDcdnDomainCertificateWithOptions(BatchSetDcdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPri))
            {
                query["SSLPri"] = request.SSLPri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLProtocol))
            {
                query["SSLProtocol"] = request.SSLProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetDcdnDomainCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetDcdnDomainCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchSetDcdnDomainCertificateResponse> BatchSetDcdnDomainCertificateWithOptionsAsync(BatchSetDcdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPri))
            {
                query["SSLPri"] = request.SSLPri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLProtocol))
            {
                query["SSLProtocol"] = request.SSLProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetDcdnDomainCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetDcdnDomainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchSetDcdnDomainCertificateResponse BatchSetDcdnDomainCertificate(BatchSetDcdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetDcdnDomainCertificateWithOptions(request, runtime);
        }

        public async Task<BatchSetDcdnDomainCertificateResponse> BatchSetDcdnDomainCertificateAsync(BatchSetDcdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetDcdnDomainCertificateWithOptionsAsync(request, runtime);
        }

        public BatchSetDcdnDomainConfigsResponse BatchSetDcdnDomainConfigsWithOptions(BatchSetDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                query["Functions"] = request.Functions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetDcdnDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetDcdnDomainConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchSetDcdnDomainConfigsResponse> BatchSetDcdnDomainConfigsWithOptionsAsync(BatchSetDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                query["Functions"] = request.Functions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetDcdnDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetDcdnDomainConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchSetDcdnDomainConfigsResponse BatchSetDcdnDomainConfigs(BatchSetDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetDcdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchSetDcdnDomainConfigsResponse> BatchSetDcdnDomainConfigsAsync(BatchSetDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetDcdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchSetDcdnIpaDomainConfigsResponse BatchSetDcdnIpaDomainConfigsWithOptions(BatchSetDcdnIpaDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                query["Functions"] = request.Functions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetDcdnIpaDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetDcdnIpaDomainConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchSetDcdnIpaDomainConfigsResponse> BatchSetDcdnIpaDomainConfigsWithOptionsAsync(BatchSetDcdnIpaDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                query["Functions"] = request.Functions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetDcdnIpaDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetDcdnIpaDomainConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchSetDcdnIpaDomainConfigsResponse BatchSetDcdnIpaDomainConfigs(BatchSetDcdnIpaDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetDcdnIpaDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchSetDcdnIpaDomainConfigsResponse> BatchSetDcdnIpaDomainConfigsAsync(BatchSetDcdnIpaDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetDcdnIpaDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchStartDcdnDomainResponse BatchStartDcdnDomainWithOptions(BatchStartDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStartDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartDcdnDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchStartDcdnDomainResponse> BatchStartDcdnDomainWithOptionsAsync(BatchStartDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStartDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartDcdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchStartDcdnDomainResponse BatchStartDcdnDomain(BatchStartDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStartDcdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchStartDcdnDomainResponse> BatchStartDcdnDomainAsync(BatchStartDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStartDcdnDomainWithOptionsAsync(request, runtime);
        }

        public BatchStopDcdnDomainResponse BatchStopDcdnDomainWithOptions(BatchStopDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStopDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopDcdnDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchStopDcdnDomainResponse> BatchStopDcdnDomainWithOptionsAsync(BatchStopDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStopDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopDcdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchStopDcdnDomainResponse BatchStopDcdnDomain(BatchStopDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStopDcdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchStopDcdnDomainResponse> BatchStopDcdnDomainAsync(BatchStopDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStopDcdnDomainWithOptionsAsync(request, runtime);
        }

        public CheckDcdnProjectExistResponse CheckDcdnProjectExistWithOptions(CheckDcdnProjectExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDcdnProjectExist",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDcdnProjectExistResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDcdnProjectExistResponse> CheckDcdnProjectExistWithOptionsAsync(CheckDcdnProjectExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDcdnProjectExist",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDcdnProjectExistResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDcdnProjectExistResponse CheckDcdnProjectExist(CheckDcdnProjectExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDcdnProjectExistWithOptions(request, runtime);
        }

        public async Task<CheckDcdnProjectExistResponse> CheckDcdnProjectExistAsync(CheckDcdnProjectExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDcdnProjectExistWithOptionsAsync(request, runtime);
        }

        public CommitStagingRoutineCodeResponse CommitStagingRoutineCodeWithOptions(CommitStagingRoutineCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeDescription))
            {
                body["CodeDescription"] = request.CodeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitStagingRoutineCode",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitStagingRoutineCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CommitStagingRoutineCodeResponse> CommitStagingRoutineCodeWithOptionsAsync(CommitStagingRoutineCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeDescription))
            {
                body["CodeDescription"] = request.CodeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitStagingRoutineCode",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitStagingRoutineCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CommitStagingRoutineCodeResponse CommitStagingRoutineCode(CommitStagingRoutineCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CommitStagingRoutineCodeWithOptions(request, runtime);
        }

        public async Task<CommitStagingRoutineCodeResponse> CommitStagingRoutineCodeAsync(CommitStagingRoutineCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CommitStagingRoutineCodeWithOptionsAsync(request, runtime);
        }

        public CreateDcdnCertificateSigningRequestResponse CreateDcdnCertificateSigningRequestWithOptions(CreateDcdnCertificateSigningRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                query["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationUnit))
            {
                query["OrganizationUnit"] = request.OrganizationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SANs))
            {
                query["SANs"] = request.SANs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDcdnCertificateSigningRequest",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDcdnCertificateSigningRequestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDcdnCertificateSigningRequestResponse> CreateDcdnCertificateSigningRequestWithOptionsAsync(CreateDcdnCertificateSigningRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                query["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationUnit))
            {
                query["OrganizationUnit"] = request.OrganizationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SANs))
            {
                query["SANs"] = request.SANs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDcdnCertificateSigningRequest",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDcdnCertificateSigningRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDcdnCertificateSigningRequestResponse CreateDcdnCertificateSigningRequest(CreateDcdnCertificateSigningRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDcdnCertificateSigningRequestWithOptions(request, runtime);
        }

        public async Task<CreateDcdnCertificateSigningRequestResponse> CreateDcdnCertificateSigningRequestAsync(CreateDcdnCertificateSigningRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDcdnCertificateSigningRequestWithOptionsAsync(request, runtime);
        }

        public CreateDcdnDeliverTaskResponse CreateDcdnDeliverTaskWithOptions(CreateDcdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deliver))
            {
                body["Deliver"] = request.Deliver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reports))
            {
                body["Reports"] = request.Reports;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["Schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDcdnDeliverTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDcdnDeliverTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDcdnDeliverTaskResponse> CreateDcdnDeliverTaskWithOptionsAsync(CreateDcdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deliver))
            {
                body["Deliver"] = request.Deliver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reports))
            {
                body["Reports"] = request.Reports;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["Schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDcdnDeliverTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDcdnDeliverTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDcdnDeliverTaskResponse CreateDcdnDeliverTask(CreateDcdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDcdnDeliverTaskWithOptions(request, runtime);
        }

        public async Task<CreateDcdnDeliverTaskResponse> CreateDcdnDeliverTaskAsync(CreateDcdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDcdnDeliverTaskWithOptionsAsync(request, runtime);
        }

        public CreateDcdnSLSRealTimeLogDeliveryResponse CreateDcdnSLSRealTimeLogDeliveryWithOptions(CreateDcdnSLSRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCenter))
            {
                body["DataCenter"] = request.DataCenter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSLogStore))
            {
                body["SLSLogStore"] = request.SLSLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSProject))
            {
                body["SLSProject"] = request.SLSProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSRegion))
            {
                body["SLSRegion"] = request.SLSRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                body["SamplingRate"] = request.SamplingRate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDcdnSLSRealTimeLogDelivery",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDcdnSLSRealTimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDcdnSLSRealTimeLogDeliveryResponse> CreateDcdnSLSRealTimeLogDeliveryWithOptionsAsync(CreateDcdnSLSRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCenter))
            {
                body["DataCenter"] = request.DataCenter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSLogStore))
            {
                body["SLSLogStore"] = request.SLSLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSProject))
            {
                body["SLSProject"] = request.SLSProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSRegion))
            {
                body["SLSRegion"] = request.SLSRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                body["SamplingRate"] = request.SamplingRate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDcdnSLSRealTimeLogDelivery",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDcdnSLSRealTimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDcdnSLSRealTimeLogDeliveryResponse CreateDcdnSLSRealTimeLogDelivery(CreateDcdnSLSRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDcdnSLSRealTimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<CreateDcdnSLSRealTimeLogDeliveryResponse> CreateDcdnSLSRealTimeLogDeliveryAsync(CreateDcdnSLSRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDcdnSLSRealTimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public CreateDcdnSubTaskResponse CreateDcdnSubTaskWithOptions(CreateDcdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportIds))
            {
                body["ReportIds"] = request.ReportIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDcdnSubTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDcdnSubTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDcdnSubTaskResponse> CreateDcdnSubTaskWithOptionsAsync(CreateDcdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportIds))
            {
                body["ReportIds"] = request.ReportIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDcdnSubTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDcdnSubTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDcdnSubTaskResponse CreateDcdnSubTask(CreateDcdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDcdnSubTaskWithOptions(request, runtime);
        }

        public async Task<CreateDcdnSubTaskResponse> CreateDcdnSubTaskAsync(CreateDcdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDcdnSubTaskWithOptionsAsync(request, runtime);
        }

        public CreateRoutineResponse CreateRoutineWithOptions(CreateRoutineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRoutineShrinkRequest request = new CreateRoutineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EnvConf))
            {
                request.EnvConfShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EnvConf, "EnvConf", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvConfShrink))
            {
                body["EnvConf"] = request.EnvConfShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRoutine",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoutineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRoutineResponse> CreateRoutineWithOptionsAsync(CreateRoutineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRoutineShrinkRequest request = new CreateRoutineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EnvConf))
            {
                request.EnvConfShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EnvConf, "EnvConf", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvConfShrink))
            {
                body["EnvConf"] = request.EnvConfShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRoutine",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoutineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRoutineResponse CreateRoutine(CreateRoutineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRoutineWithOptions(request, runtime);
        }

        public async Task<CreateRoutineResponse> CreateRoutineAsync(CreateRoutineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRoutineWithOptionsAsync(request, runtime);
        }

        public CreateSlrAndSlsProjectResponse CreateSlrAndSlsProjectWithOptions(CreateSlrAndSlsProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSlrAndSlsProject",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSlrAndSlsProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSlrAndSlsProjectResponse> CreateSlrAndSlsProjectWithOptionsAsync(CreateSlrAndSlsProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSlrAndSlsProject",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSlrAndSlsProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSlrAndSlsProjectResponse CreateSlrAndSlsProject(CreateSlrAndSlsProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSlrAndSlsProjectWithOptions(request, runtime);
        }

        public async Task<CreateSlrAndSlsProjectResponse> CreateSlrAndSlsProjectAsync(CreateSlrAndSlsProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSlrAndSlsProjectWithOptionsAsync(request, runtime);
        }

        public DcdnHttpRequestTestToolResponse DcdnHttpRequestTestToolWithOptions(DcdnHttpRequestTestToolRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DcdnHttpRequestTestToolShrinkRequest request = new DcdnHttpRequestTestToolShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Header))
            {
                request.HeaderShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Header, "Header", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                body["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeaderShrink))
            {
                body["Header"] = request.HeaderShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["Method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyIp))
            {
                body["ProxyIp"] = request.ProxyIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                body["Scheme"] = request.Scheme;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DcdnHttpRequestTestTool",
                Version = "2018-01-15",
                Protocol = "HTTP",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DcdnHttpRequestTestToolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DcdnHttpRequestTestToolResponse> DcdnHttpRequestTestToolWithOptionsAsync(DcdnHttpRequestTestToolRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DcdnHttpRequestTestToolShrinkRequest request = new DcdnHttpRequestTestToolShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Header))
            {
                request.HeaderShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Header, "Header", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                body["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeaderShrink))
            {
                body["Header"] = request.HeaderShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["Method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyIp))
            {
                body["ProxyIp"] = request.ProxyIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                body["Scheme"] = request.Scheme;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DcdnHttpRequestTestTool",
                Version = "2018-01-15",
                Protocol = "HTTP",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DcdnHttpRequestTestToolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DcdnHttpRequestTestToolResponse DcdnHttpRequestTestTool(DcdnHttpRequestTestToolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DcdnHttpRequestTestToolWithOptions(request, runtime);
        }

        public async Task<DcdnHttpRequestTestToolResponse> DcdnHttpRequestTestToolAsync(DcdnHttpRequestTestToolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DcdnHttpRequestTestToolWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnDeliverTaskResponse DeleteDcdnDeliverTaskWithOptions(DeleteDcdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["DeliverId"] = request.DeliverId;
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
                Action = "DeleteDcdnDeliverTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnDeliverTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDcdnDeliverTaskResponse> DeleteDcdnDeliverTaskWithOptionsAsync(DeleteDcdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["DeliverId"] = request.DeliverId;
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
                Action = "DeleteDcdnDeliverTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnDeliverTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDcdnDeliverTaskResponse DeleteDcdnDeliverTask(DeleteDcdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnDeliverTaskWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnDeliverTaskResponse> DeleteDcdnDeliverTaskAsync(DeleteDcdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnDeliverTaskWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnDomainResponse DeleteDcdnDomainWithOptions(DeleteDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDcdnDomainResponse> DeleteDcdnDomainWithOptionsAsync(DeleteDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDcdnDomainResponse DeleteDcdnDomain(DeleteDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnDomainResponse> DeleteDcdnDomainAsync(DeleteDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnDomainWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnIpaDomainResponse DeleteDcdnIpaDomainWithOptions(DeleteDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnIpaDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDcdnIpaDomainResponse> DeleteDcdnIpaDomainWithOptionsAsync(DeleteDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnIpaDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDcdnIpaDomainResponse DeleteDcdnIpaDomain(DeleteDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnIpaDomainResponse> DeleteDcdnIpaDomainAsync(DeleteDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnIpaSpecificConfigResponse DeleteDcdnIpaSpecificConfigWithOptions(DeleteDcdnIpaSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnIpaSpecificConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnIpaSpecificConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDcdnIpaSpecificConfigResponse> DeleteDcdnIpaSpecificConfigWithOptionsAsync(DeleteDcdnIpaSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnIpaSpecificConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnIpaSpecificConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDcdnIpaSpecificConfigResponse DeleteDcdnIpaSpecificConfig(DeleteDcdnIpaSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnIpaSpecificConfigWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnIpaSpecificConfigResponse> DeleteDcdnIpaSpecificConfigAsync(DeleteDcdnIpaSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnIpaSpecificConfigWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnRealTimeLogProjectResponse DeleteDcdnRealTimeLogProjectWithOptions(DeleteDcdnRealTimeLogProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnRealTimeLogProject",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnRealTimeLogProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDcdnRealTimeLogProjectResponse> DeleteDcdnRealTimeLogProjectWithOptionsAsync(DeleteDcdnRealTimeLogProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnRealTimeLogProject",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnRealTimeLogProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDcdnRealTimeLogProjectResponse DeleteDcdnRealTimeLogProject(DeleteDcdnRealTimeLogProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnRealTimeLogProjectWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnRealTimeLogProjectResponse> DeleteDcdnRealTimeLogProjectAsync(DeleteDcdnRealTimeLogProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnRealTimeLogProjectWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnSpecificConfigResponse DeleteDcdnSpecificConfigWithOptions(DeleteDcdnSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnSpecificConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnSpecificConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDcdnSpecificConfigResponse> DeleteDcdnSpecificConfigWithOptionsAsync(DeleteDcdnSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnSpecificConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnSpecificConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDcdnSpecificConfigResponse DeleteDcdnSpecificConfig(DeleteDcdnSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnSpecificConfigWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnSpecificConfigResponse> DeleteDcdnSpecificConfigAsync(DeleteDcdnSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnSpecificConfigWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnSpecificStagingConfigResponse DeleteDcdnSpecificStagingConfigWithOptions(DeleteDcdnSpecificStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnSpecificStagingConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnSpecificStagingConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDcdnSpecificStagingConfigResponse> DeleteDcdnSpecificStagingConfigWithOptionsAsync(DeleteDcdnSpecificStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDcdnSpecificStagingConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnSpecificStagingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDcdnSpecificStagingConfigResponse DeleteDcdnSpecificStagingConfig(DeleteDcdnSpecificStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnSpecificStagingConfigWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnSpecificStagingConfigResponse> DeleteDcdnSpecificStagingConfigAsync(DeleteDcdnSpecificStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnSpecificStagingConfigWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnSubTaskResponse DeleteDcdnSubTaskWithOptions(DeleteDcdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteDcdnSubTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnSubTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDcdnSubTaskResponse> DeleteDcdnSubTaskWithOptionsAsync(DeleteDcdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteDcdnSubTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDcdnSubTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDcdnSubTaskResponse DeleteDcdnSubTask(DeleteDcdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnSubTaskWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnSubTaskResponse> DeleteDcdnSubTaskAsync(DeleteDcdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnSubTaskWithOptionsAsync(request, runtime);
        }

        public DeleteRoutineResponse DeleteRoutineWithOptions(DeleteRoutineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRoutine",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoutineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRoutineResponse> DeleteRoutineWithOptionsAsync(DeleteRoutineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRoutine",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoutineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRoutineResponse DeleteRoutine(DeleteRoutineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRoutineWithOptions(request, runtime);
        }

        public async Task<DeleteRoutineResponse> DeleteRoutineAsync(DeleteRoutineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRoutineWithOptionsAsync(request, runtime);
        }

        public DeleteRoutineCodeRevisionResponse DeleteRoutineCodeRevisionWithOptions(DeleteRoutineCodeRevisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectCodeRevision))
            {
                body["SelectCodeRevision"] = request.SelectCodeRevision;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRoutineCodeRevision",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoutineCodeRevisionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRoutineCodeRevisionResponse> DeleteRoutineCodeRevisionWithOptionsAsync(DeleteRoutineCodeRevisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectCodeRevision))
            {
                body["SelectCodeRevision"] = request.SelectCodeRevision;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRoutineCodeRevision",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoutineCodeRevisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRoutineCodeRevisionResponse DeleteRoutineCodeRevision(DeleteRoutineCodeRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRoutineCodeRevisionWithOptions(request, runtime);
        }

        public async Task<DeleteRoutineCodeRevisionResponse> DeleteRoutineCodeRevisionAsync(DeleteRoutineCodeRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRoutineCodeRevisionWithOptionsAsync(request, runtime);
        }

        public DeleteRoutineConfEnvsResponse DeleteRoutineConfEnvsWithOptions(DeleteRoutineConfEnvsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteRoutineConfEnvsShrinkRequest request = new DeleteRoutineConfEnvsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Envs))
            {
                request.EnvsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Envs, "Envs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvsShrink))
            {
                body["Envs"] = request.EnvsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRoutineConfEnvs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoutineConfEnvsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRoutineConfEnvsResponse> DeleteRoutineConfEnvsWithOptionsAsync(DeleteRoutineConfEnvsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteRoutineConfEnvsShrinkRequest request = new DeleteRoutineConfEnvsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Envs))
            {
                request.EnvsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Envs, "Envs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvsShrink))
            {
                body["Envs"] = request.EnvsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRoutineConfEnvs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoutineConfEnvsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRoutineConfEnvsResponse DeleteRoutineConfEnvs(DeleteRoutineConfEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRoutineConfEnvsWithOptions(request, runtime);
        }

        public async Task<DeleteRoutineConfEnvsResponse> DeleteRoutineConfEnvsAsync(DeleteRoutineConfEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRoutineConfEnvsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnAclFieldsResponse DescribeDcdnAclFieldsWithOptions(DescribeDcdnAclFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDcdnAclFields",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnAclFieldsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnAclFieldsResponse> DescribeDcdnAclFieldsWithOptionsAsync(DescribeDcdnAclFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDcdnAclFields",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnAclFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnAclFieldsResponse DescribeDcdnAclFields(DescribeDcdnAclFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnAclFieldsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnAclFieldsResponse> DescribeDcdnAclFieldsAsync(DescribeDcdnAclFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnAclFieldsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnBgpBpsDataResponse DescribeDcdnBgpBpsDataWithOptions(DescribeDcdnBgpBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnBgpBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnBgpBpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnBgpBpsDataResponse> DescribeDcdnBgpBpsDataWithOptionsAsync(DescribeDcdnBgpBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnBgpBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnBgpBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnBgpBpsDataResponse DescribeDcdnBgpBpsData(DescribeDcdnBgpBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnBgpBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnBgpBpsDataResponse> DescribeDcdnBgpBpsDataAsync(DescribeDcdnBgpBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnBgpBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnBgpTrafficDataResponse DescribeDcdnBgpTrafficDataWithOptions(DescribeDcdnBgpTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnBgpTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnBgpTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnBgpTrafficDataResponse> DescribeDcdnBgpTrafficDataWithOptionsAsync(DescribeDcdnBgpTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnBgpTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnBgpTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnBgpTrafficDataResponse DescribeDcdnBgpTrafficData(DescribeDcdnBgpTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnBgpTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnBgpTrafficDataResponse> DescribeDcdnBgpTrafficDataAsync(DescribeDcdnBgpTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnBgpTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnBlockedRegionsResponse DescribeDcdnBlockedRegionsWithOptions(DescribeDcdnBlockedRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnBlockedRegions",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnBlockedRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnBlockedRegionsResponse> DescribeDcdnBlockedRegionsWithOptionsAsync(DescribeDcdnBlockedRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnBlockedRegions",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnBlockedRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnBlockedRegionsResponse DescribeDcdnBlockedRegions(DescribeDcdnBlockedRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnBlockedRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnBlockedRegionsResponse> DescribeDcdnBlockedRegionsAsync(DescribeDcdnBlockedRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnBlockedRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnCertificateDetailResponse DescribeDcdnCertificateDetailWithOptions(DescribeDcdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnCertificateDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnCertificateDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnCertificateDetailResponse> DescribeDcdnCertificateDetailWithOptionsAsync(DescribeDcdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnCertificateDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnCertificateDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnCertificateDetailResponse DescribeDcdnCertificateDetail(DescribeDcdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnCertificateDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnCertificateDetailResponse> DescribeDcdnCertificateDetailAsync(DescribeDcdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnCertificateDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnCertificateListResponse DescribeDcdnCertificateListWithOptions(DescribeDcdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnCertificateList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnCertificateListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnCertificateListResponse> DescribeDcdnCertificateListWithOptionsAsync(DescribeDcdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnCertificateList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnCertificateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnCertificateListResponse DescribeDcdnCertificateList(DescribeDcdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnCertificateListResponse> DescribeDcdnCertificateListAsync(DescribeDcdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnConfigGroupDetailResponse DescribeDcdnConfigGroupDetailWithOptions(DescribeDcdnConfigGroupDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigGroupId))
            {
                query["ConfigGroupId"] = request.ConfigGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigGroupName))
            {
                query["ConfigGroupName"] = request.ConfigGroupName;
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
                Action = "DescribeDcdnConfigGroupDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnConfigGroupDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnConfigGroupDetailResponse> DescribeDcdnConfigGroupDetailWithOptionsAsync(DescribeDcdnConfigGroupDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigGroupId))
            {
                query["ConfigGroupId"] = request.ConfigGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigGroupName))
            {
                query["ConfigGroupName"] = request.ConfigGroupName;
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
                Action = "DescribeDcdnConfigGroupDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnConfigGroupDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnConfigGroupDetailResponse DescribeDcdnConfigGroupDetail(DescribeDcdnConfigGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnConfigGroupDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnConfigGroupDetailResponse> DescribeDcdnConfigGroupDetailAsync(DescribeDcdnConfigGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnConfigGroupDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnConfigOfVersionResponse DescribeDcdnConfigOfVersionWithOptions(DescribeDcdnConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionId))
            {
                query["FunctionId"] = request.FunctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnConfigOfVersion",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnConfigOfVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnConfigOfVersionResponse> DescribeDcdnConfigOfVersionWithOptionsAsync(DescribeDcdnConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionId))
            {
                query["FunctionId"] = request.FunctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnConfigOfVersion",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnConfigOfVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnConfigOfVersionResponse DescribeDcdnConfigOfVersion(DescribeDcdnConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnConfigOfVersionWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnConfigOfVersionResponse> DescribeDcdnConfigOfVersionAsync(DescribeDcdnConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnConfigOfVersionWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDeletedDomainsResponse DescribeDcdnDeletedDomainsWithOptions(DescribeDcdnDeletedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDeletedDomains",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDeletedDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDeletedDomainsResponse> DescribeDcdnDeletedDomainsWithOptionsAsync(DescribeDcdnDeletedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDeletedDomains",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDeletedDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDeletedDomainsResponse DescribeDcdnDeletedDomains(DescribeDcdnDeletedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDeletedDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDeletedDomainsResponse> DescribeDcdnDeletedDomainsAsync(DescribeDcdnDeletedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDeletedDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDeliverListResponse DescribeDcdnDeliverListWithOptions(DescribeDcdnDeliverListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["DeliverId"] = request.DeliverId;
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
                Action = "DescribeDcdnDeliverList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDeliverListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDeliverListResponse> DescribeDcdnDeliverListWithOptionsAsync(DescribeDcdnDeliverListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["DeliverId"] = request.DeliverId;
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
                Action = "DescribeDcdnDeliverList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDeliverListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDeliverListResponse DescribeDcdnDeliverList(DescribeDcdnDeliverListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDeliverListWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDeliverListResponse> DescribeDcdnDeliverListAsync(DescribeDcdnDeliverListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDeliverListWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainBpsDataResponse DescribeDcdnDomainBpsDataWithOptions(DescribeDcdnDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainBpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainBpsDataResponse> DescribeDcdnDomainBpsDataWithOptionsAsync(DescribeDcdnDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainBpsDataResponse DescribeDcdnDomainBpsData(DescribeDcdnDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainBpsDataResponse> DescribeDcdnDomainBpsDataAsync(DescribeDcdnDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainByCertificateResponse DescribeDcdnDomainByCertificateWithOptions(DescribeDcdnDomainByCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainByCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainByCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainByCertificateResponse> DescribeDcdnDomainByCertificateWithOptionsAsync(DescribeDcdnDomainByCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainByCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainByCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainByCertificateResponse DescribeDcdnDomainByCertificate(DescribeDcdnDomainByCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainByCertificateWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainByCertificateResponse> DescribeDcdnDomainByCertificateAsync(DescribeDcdnDomainByCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainByCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainCcActivityLogResponse DescribeDcdnDomainCcActivityLogWithOptions(DescribeDcdnDomainCcActivityLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerObject))
            {
                query["TriggerObject"] = request.TriggerObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainCcActivityLog",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainCcActivityLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainCcActivityLogResponse> DescribeDcdnDomainCcActivityLogWithOptionsAsync(DescribeDcdnDomainCcActivityLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerObject))
            {
                query["TriggerObject"] = request.TriggerObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainCcActivityLog",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainCcActivityLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainCcActivityLogResponse DescribeDcdnDomainCcActivityLog(DescribeDcdnDomainCcActivityLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainCcActivityLogWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainCcActivityLogResponse> DescribeDcdnDomainCcActivityLogAsync(DescribeDcdnDomainCcActivityLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainCcActivityLogWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainCertificateInfoResponse DescribeDcdnDomainCertificateInfoWithOptions(DescribeDcdnDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "DescribeDcdnDomainCertificateInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainCertificateInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainCertificateInfoResponse> DescribeDcdnDomainCertificateInfoWithOptionsAsync(DescribeDcdnDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "DescribeDcdnDomainCertificateInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainCertificateInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainCertificateInfoResponse DescribeDcdnDomainCertificateInfo(DescribeDcdnDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainCertificateInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainCertificateInfoResponse> DescribeDcdnDomainCertificateInfoAsync(DescribeDcdnDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainCnameResponse DescribeDcdnDomainCnameWithOptions(DescribeDcdnDomainCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainCname",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainCnameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainCnameResponse> DescribeDcdnDomainCnameWithOptionsAsync(DescribeDcdnDomainCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainCname",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainCnameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainCnameResponse DescribeDcdnDomainCname(DescribeDcdnDomainCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainCnameWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainCnameResponse> DescribeDcdnDomainCnameAsync(DescribeDcdnDomainCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainCnameWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainConfigsResponse DescribeDcdnDomainConfigsWithOptions(DescribeDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainConfigsResponse> DescribeDcdnDomainConfigsWithOptionsAsync(DescribeDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainConfigsResponse DescribeDcdnDomainConfigs(DescribeDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainConfigsResponse> DescribeDcdnDomainConfigsAsync(DescribeDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainDetailResponse DescribeDcdnDomainDetailWithOptions(DescribeDcdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainDetailResponse> DescribeDcdnDomainDetailWithOptionsAsync(DescribeDcdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainDetailResponse DescribeDcdnDomainDetail(DescribeDcdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainDetailResponse> DescribeDcdnDomainDetailAsync(DescribeDcdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainHitRateDataResponse DescribeDcdnDomainHitRateDataWithOptions(DescribeDcdnDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainHitRateData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainHitRateDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainHitRateDataResponse> DescribeDcdnDomainHitRateDataWithOptionsAsync(DescribeDcdnDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainHitRateData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainHitRateDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainHitRateDataResponse DescribeDcdnDomainHitRateData(DescribeDcdnDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainHitRateDataResponse> DescribeDcdnDomainHitRateDataAsync(DescribeDcdnDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainHttpCodeDataResponse DescribeDcdnDomainHttpCodeDataWithOptions(DescribeDcdnDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainHttpCodeData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainHttpCodeDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainHttpCodeDataResponse> DescribeDcdnDomainHttpCodeDataWithOptionsAsync(DescribeDcdnDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainHttpCodeData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainHttpCodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainHttpCodeDataResponse DescribeDcdnDomainHttpCodeData(DescribeDcdnDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainHttpCodeDataResponse> DescribeDcdnDomainHttpCodeDataAsync(DescribeDcdnDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainIpaBpsDataResponse DescribeDcdnDomainIpaBpsDataWithOptions(DescribeDcdnDomainIpaBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixTimeGap))
            {
                query["FixTimeGap"] = request.FixTimeGap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMerge))
            {
                query["TimeMerge"] = request.TimeMerge;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainIpaBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainIpaBpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainIpaBpsDataResponse> DescribeDcdnDomainIpaBpsDataWithOptionsAsync(DescribeDcdnDomainIpaBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixTimeGap))
            {
                query["FixTimeGap"] = request.FixTimeGap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMerge))
            {
                query["TimeMerge"] = request.TimeMerge;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainIpaBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainIpaBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainIpaBpsDataResponse DescribeDcdnDomainIpaBpsData(DescribeDcdnDomainIpaBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainIpaBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainIpaBpsDataResponse> DescribeDcdnDomainIpaBpsDataAsync(DescribeDcdnDomainIpaBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainIpaBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainIpaTrafficDataResponse DescribeDcdnDomainIpaTrafficDataWithOptions(DescribeDcdnDomainIpaTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixTimeGap))
            {
                query["FixTimeGap"] = request.FixTimeGap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMerge))
            {
                query["TimeMerge"] = request.TimeMerge;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainIpaTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainIpaTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainIpaTrafficDataResponse> DescribeDcdnDomainIpaTrafficDataWithOptionsAsync(DescribeDcdnDomainIpaTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixTimeGap))
            {
                query["FixTimeGap"] = request.FixTimeGap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMerge))
            {
                query["TimeMerge"] = request.TimeMerge;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainIpaTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainIpaTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainIpaTrafficDataResponse DescribeDcdnDomainIpaTrafficData(DescribeDcdnDomainIpaTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainIpaTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainIpaTrafficDataResponse> DescribeDcdnDomainIpaTrafficDataAsync(DescribeDcdnDomainIpaTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainIpaTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainIspDataResponse DescribeDcdnDomainIspDataWithOptions(DescribeDcdnDomainIspDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainIspData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainIspDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainIspDataResponse> DescribeDcdnDomainIspDataWithOptionsAsync(DescribeDcdnDomainIspDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainIspData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainIspDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainIspDataResponse DescribeDcdnDomainIspData(DescribeDcdnDomainIspDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainIspDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainIspDataResponse> DescribeDcdnDomainIspDataAsync(DescribeDcdnDomainIspDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainIspDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainLogResponse DescribeDcdnDomainLogWithOptions(DescribeDcdnDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainLog",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainLogResponse> DescribeDcdnDomainLogWithOptionsAsync(DescribeDcdnDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainLog",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainLogResponse DescribeDcdnDomainLog(DescribeDcdnDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainLogWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainLogResponse> DescribeDcdnDomainLogAsync(DescribeDcdnDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainLogWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainMultiUsageDataResponse DescribeDcdnDomainMultiUsageDataWithOptions(DescribeDcdnDomainMultiUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainMultiUsageData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainMultiUsageDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainMultiUsageDataResponse> DescribeDcdnDomainMultiUsageDataWithOptionsAsync(DescribeDcdnDomainMultiUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainMultiUsageData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainMultiUsageDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainMultiUsageDataResponse DescribeDcdnDomainMultiUsageData(DescribeDcdnDomainMultiUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainMultiUsageDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainMultiUsageDataResponse> DescribeDcdnDomainMultiUsageDataAsync(DescribeDcdnDomainMultiUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainMultiUsageDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainOriginBpsDataResponse DescribeDcdnDomainOriginBpsDataWithOptions(DescribeDcdnDomainOriginBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainOriginBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainOriginBpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainOriginBpsDataResponse> DescribeDcdnDomainOriginBpsDataWithOptionsAsync(DescribeDcdnDomainOriginBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainOriginBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainOriginBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainOriginBpsDataResponse DescribeDcdnDomainOriginBpsData(DescribeDcdnDomainOriginBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainOriginBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainOriginBpsDataResponse> DescribeDcdnDomainOriginBpsDataAsync(DescribeDcdnDomainOriginBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainOriginBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainOriginTrafficDataResponse DescribeDcdnDomainOriginTrafficDataWithOptions(DescribeDcdnDomainOriginTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainOriginTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainOriginTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainOriginTrafficDataResponse> DescribeDcdnDomainOriginTrafficDataWithOptionsAsync(DescribeDcdnDomainOriginTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainOriginTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainOriginTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainOriginTrafficDataResponse DescribeDcdnDomainOriginTrafficData(DescribeDcdnDomainOriginTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainOriginTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainOriginTrafficDataResponse> DescribeDcdnDomainOriginTrafficDataAsync(DescribeDcdnDomainOriginTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainOriginTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainPropertyResponse DescribeDcdnDomainPropertyWithOptions(DescribeDcdnDomainPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "DescribeDcdnDomainProperty",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainPropertyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainPropertyResponse> DescribeDcdnDomainPropertyWithOptionsAsync(DescribeDcdnDomainPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "DescribeDcdnDomainProperty",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainPropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainPropertyResponse DescribeDcdnDomainProperty(DescribeDcdnDomainPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainPropertyWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainPropertyResponse> DescribeDcdnDomainPropertyAsync(DescribeDcdnDomainPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainPropertyWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainPvDataResponse DescribeDcdnDomainPvDataWithOptions(DescribeDcdnDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainPvData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainPvDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainPvDataResponse> DescribeDcdnDomainPvDataWithOptionsAsync(DescribeDcdnDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainPvData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainPvDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainPvDataResponse DescribeDcdnDomainPvData(DescribeDcdnDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainPvDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainPvDataResponse> DescribeDcdnDomainPvDataAsync(DescribeDcdnDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainPvDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainQpsDataResponse DescribeDcdnDomainQpsDataWithOptions(DescribeDcdnDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainQpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainQpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainQpsDataResponse> DescribeDcdnDomainQpsDataWithOptionsAsync(DescribeDcdnDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainQpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainQpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainQpsDataResponse DescribeDcdnDomainQpsData(DescribeDcdnDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainQpsDataResponse> DescribeDcdnDomainQpsDataAsync(DescribeDcdnDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeBpsDataResponse DescribeDcdnDomainRealTimeBpsDataWithOptions(DescribeDcdnDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeBpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeBpsDataResponse> DescribeDcdnDomainRealTimeBpsDataWithOptionsAsync(DescribeDcdnDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeBpsDataResponse DescribeDcdnDomainRealTimeBpsData(DescribeDcdnDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeBpsDataResponse> DescribeDcdnDomainRealTimeBpsDataAsync(DescribeDcdnDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeByteHitRateDataResponse DescribeDcdnDomainRealTimeByteHitRateDataWithOptions(DescribeDcdnDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeByteHitRateData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeByteHitRateDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeByteHitRateDataResponse> DescribeDcdnDomainRealTimeByteHitRateDataWithOptionsAsync(DescribeDcdnDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeByteHitRateData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeByteHitRateDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeByteHitRateDataResponse DescribeDcdnDomainRealTimeByteHitRateData(DescribeDcdnDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeByteHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeByteHitRateDataResponse> DescribeDcdnDomainRealTimeByteHitRateDataAsync(DescribeDcdnDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeByteHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeDetailDataResponse DescribeDcdnDomainRealTimeDetailDataWithOptions(DescribeDcdnDomainRealTimeDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeDetailData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeDetailDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeDetailDataResponse> DescribeDcdnDomainRealTimeDetailDataWithOptionsAsync(DescribeDcdnDomainRealTimeDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeDetailData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeDetailDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeDetailDataResponse DescribeDcdnDomainRealTimeDetailData(DescribeDcdnDomainRealTimeDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeDetailDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeDetailDataResponse> DescribeDcdnDomainRealTimeDetailDataAsync(DescribeDcdnDomainRealTimeDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeDetailDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeHttpCodeDataResponse DescribeDcdnDomainRealTimeHttpCodeDataWithOptions(DescribeDcdnDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeHttpCodeData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeHttpCodeDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeHttpCodeDataResponse> DescribeDcdnDomainRealTimeHttpCodeDataWithOptionsAsync(DescribeDcdnDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeHttpCodeData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeHttpCodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeHttpCodeDataResponse DescribeDcdnDomainRealTimeHttpCodeData(DescribeDcdnDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeHttpCodeDataResponse> DescribeDcdnDomainRealTimeHttpCodeDataAsync(DescribeDcdnDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeQpsDataResponse DescribeDcdnDomainRealTimeQpsDataWithOptions(DescribeDcdnDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeQpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeQpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeQpsDataResponse> DescribeDcdnDomainRealTimeQpsDataWithOptionsAsync(DescribeDcdnDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeQpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeQpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeQpsDataResponse DescribeDcdnDomainRealTimeQpsData(DescribeDcdnDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeQpsDataResponse> DescribeDcdnDomainRealTimeQpsDataAsync(DescribeDcdnDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeReqHitRateDataResponse DescribeDcdnDomainRealTimeReqHitRateDataWithOptions(DescribeDcdnDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeReqHitRateData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeReqHitRateDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeReqHitRateDataResponse> DescribeDcdnDomainRealTimeReqHitRateDataWithOptionsAsync(DescribeDcdnDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeReqHitRateData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeReqHitRateDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeReqHitRateDataResponse DescribeDcdnDomainRealTimeReqHitRateData(DescribeDcdnDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeReqHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeReqHitRateDataResponse> DescribeDcdnDomainRealTimeReqHitRateDataAsync(DescribeDcdnDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeReqHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeSrcBpsDataResponse DescribeDcdnDomainRealTimeSrcBpsDataWithOptions(DescribeDcdnDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeSrcBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcBpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeSrcBpsDataResponse> DescribeDcdnDomainRealTimeSrcBpsDataWithOptionsAsync(DescribeDcdnDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeSrcBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeSrcBpsDataResponse DescribeDcdnDomainRealTimeSrcBpsData(DescribeDcdnDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeSrcBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeSrcBpsDataResponse> DescribeDcdnDomainRealTimeSrcBpsDataAsync(DescribeDcdnDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeSrcBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse DescribeDcdnDomainRealTimeSrcHttpCodeDataWithOptions(DescribeDcdnDomainRealTimeSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeSrcHttpCodeData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse> DescribeDcdnDomainRealTimeSrcHttpCodeDataWithOptionsAsync(DescribeDcdnDomainRealTimeSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeSrcHttpCodeData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse DescribeDcdnDomainRealTimeSrcHttpCodeData(DescribeDcdnDomainRealTimeSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeSrcHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse> DescribeDcdnDomainRealTimeSrcHttpCodeDataAsync(DescribeDcdnDomainRealTimeSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeSrcHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeSrcTrafficDataResponse DescribeDcdnDomainRealTimeSrcTrafficDataWithOptions(DescribeDcdnDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeSrcTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeSrcTrafficDataResponse> DescribeDcdnDomainRealTimeSrcTrafficDataWithOptionsAsync(DescribeDcdnDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeSrcTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeSrcTrafficDataResponse DescribeDcdnDomainRealTimeSrcTrafficData(DescribeDcdnDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeSrcTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeSrcTrafficDataResponse> DescribeDcdnDomainRealTimeSrcTrafficDataAsync(DescribeDcdnDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeTrafficDataResponse DescribeDcdnDomainRealTimeTrafficDataWithOptions(DescribeDcdnDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeTrafficDataResponse> DescribeDcdnDomainRealTimeTrafficDataWithOptionsAsync(DescribeDcdnDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRealTimeTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRealTimeTrafficDataResponse DescribeDcdnDomainRealTimeTrafficData(DescribeDcdnDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeTrafficDataResponse> DescribeDcdnDomainRealTimeTrafficDataAsync(DescribeDcdnDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRegionDataResponse DescribeDcdnDomainRegionDataWithOptions(DescribeDcdnDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRegionData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRegionDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainRegionDataResponse> DescribeDcdnDomainRegionDataWithOptionsAsync(DescribeDcdnDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainRegionData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainRegionDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainRegionDataResponse DescribeDcdnDomainRegionData(DescribeDcdnDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRegionDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRegionDataResponse> DescribeDcdnDomainRegionDataAsync(DescribeDcdnDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRegionDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainStagingConfigResponse DescribeDcdnDomainStagingConfigWithOptions(DescribeDcdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
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
                Action = "DescribeDcdnDomainStagingConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainStagingConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainStagingConfigResponse> DescribeDcdnDomainStagingConfigWithOptionsAsync(DescribeDcdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
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
                Action = "DescribeDcdnDomainStagingConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainStagingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainStagingConfigResponse DescribeDcdnDomainStagingConfig(DescribeDcdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainStagingConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainStagingConfigResponse> DescribeDcdnDomainStagingConfigAsync(DescribeDcdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainStagingConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainTopReferVisitResponse DescribeDcdnDomainTopReferVisitWithOptions(DescribeDcdnDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainTopReferVisit",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainTopReferVisitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainTopReferVisitResponse> DescribeDcdnDomainTopReferVisitWithOptionsAsync(DescribeDcdnDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainTopReferVisit",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainTopReferVisitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainTopReferVisitResponse DescribeDcdnDomainTopReferVisit(DescribeDcdnDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainTopReferVisitWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainTopReferVisitResponse> DescribeDcdnDomainTopReferVisitAsync(DescribeDcdnDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainTopReferVisitWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainTopUrlVisitResponse DescribeDcdnDomainTopUrlVisitWithOptions(DescribeDcdnDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainTopUrlVisit",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainTopUrlVisitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainTopUrlVisitResponse> DescribeDcdnDomainTopUrlVisitWithOptionsAsync(DescribeDcdnDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainTopUrlVisit",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainTopUrlVisitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainTopUrlVisitResponse DescribeDcdnDomainTopUrlVisit(DescribeDcdnDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainTopUrlVisitWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainTopUrlVisitResponse> DescribeDcdnDomainTopUrlVisitAsync(DescribeDcdnDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainTopUrlVisitWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainTrafficDataResponse DescribeDcdnDomainTrafficDataWithOptions(DescribeDcdnDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainTrafficDataResponse> DescribeDcdnDomainTrafficDataWithOptionsAsync(DescribeDcdnDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainTrafficDataResponse DescribeDcdnDomainTrafficData(DescribeDcdnDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainTrafficDataResponse> DescribeDcdnDomainTrafficDataAsync(DescribeDcdnDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainUsageDataResponse DescribeDcdnDomainUsageDataWithOptions(DescribeDcdnDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProtocol))
            {
                query["DataProtocol"] = request.DataProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Field))
            {
                query["Field"] = request.Field;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainUsageData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainUsageDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainUsageDataResponse> DescribeDcdnDomainUsageDataWithOptionsAsync(DescribeDcdnDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProtocol))
            {
                query["DataProtocol"] = request.DataProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Field))
            {
                query["Field"] = request.Field;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainUsageData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainUsageDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainUsageDataResponse DescribeDcdnDomainUsageData(DescribeDcdnDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainUsageDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainUsageDataResponse> DescribeDcdnDomainUsageDataAsync(DescribeDcdnDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainUsageDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainUvDataResponse DescribeDcdnDomainUvDataWithOptions(DescribeDcdnDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainUvData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainUvDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainUvDataResponse> DescribeDcdnDomainUvDataWithOptionsAsync(DescribeDcdnDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainUvData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainUvDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainUvDataResponse DescribeDcdnDomainUvData(DescribeDcdnDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainUvDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainUvDataResponse> DescribeDcdnDomainUvDataAsync(DescribeDcdnDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainUvDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainWebsocketBpsDataResponse DescribeDcdnDomainWebsocketBpsDataWithOptions(DescribeDcdnDomainWebsocketBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainWebsocketBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketBpsDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainWebsocketBpsDataResponse> DescribeDcdnDomainWebsocketBpsDataWithOptionsAsync(DescribeDcdnDomainWebsocketBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainWebsocketBpsData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainWebsocketBpsDataResponse DescribeDcdnDomainWebsocketBpsData(DescribeDcdnDomainWebsocketBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainWebsocketBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainWebsocketBpsDataResponse> DescribeDcdnDomainWebsocketBpsDataAsync(DescribeDcdnDomainWebsocketBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainWebsocketBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainWebsocketHttpCodeDataResponse DescribeDcdnDomainWebsocketHttpCodeDataWithOptions(DescribeDcdnDomainWebsocketHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainWebsocketHttpCodeData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketHttpCodeDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainWebsocketHttpCodeDataResponse> DescribeDcdnDomainWebsocketHttpCodeDataWithOptionsAsync(DescribeDcdnDomainWebsocketHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainWebsocketHttpCodeData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketHttpCodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainWebsocketHttpCodeDataResponse DescribeDcdnDomainWebsocketHttpCodeData(DescribeDcdnDomainWebsocketHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainWebsocketHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainWebsocketHttpCodeDataResponse> DescribeDcdnDomainWebsocketHttpCodeDataAsync(DescribeDcdnDomainWebsocketHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainWebsocketHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainWebsocketTrafficDataResponse DescribeDcdnDomainWebsocketTrafficDataWithOptions(DescribeDcdnDomainWebsocketTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainWebsocketTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnDomainWebsocketTrafficDataResponse> DescribeDcdnDomainWebsocketTrafficDataWithOptionsAsync(DescribeDcdnDomainWebsocketTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnDomainWebsocketTrafficData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnDomainWebsocketTrafficDataResponse DescribeDcdnDomainWebsocketTrafficData(DescribeDcdnDomainWebsocketTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainWebsocketTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainWebsocketTrafficDataResponse> DescribeDcdnDomainWebsocketTrafficDataAsync(DescribeDcdnDomainWebsocketTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainWebsocketTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnEsExceptionDataResponse DescribeDcdnEsExceptionDataWithOptions(DescribeDcdnEsExceptionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnEsExceptionData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnEsExceptionDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnEsExceptionDataResponse> DescribeDcdnEsExceptionDataWithOptionsAsync(DescribeDcdnEsExceptionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnEsExceptionData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnEsExceptionDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnEsExceptionDataResponse DescribeDcdnEsExceptionData(DescribeDcdnEsExceptionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnEsExceptionDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnEsExceptionDataResponse> DescribeDcdnEsExceptionDataAsync(DescribeDcdnEsExceptionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnEsExceptionDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnEsExecuteDataResponse DescribeDcdnEsExecuteDataWithOptions(DescribeDcdnEsExecuteDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnEsExecuteData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnEsExecuteDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnEsExecuteDataResponse> DescribeDcdnEsExecuteDataWithOptionsAsync(DescribeDcdnEsExecuteDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnEsExecuteData",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnEsExecuteDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnEsExecuteDataResponse DescribeDcdnEsExecuteData(DescribeDcdnEsExecuteDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnEsExecuteDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnEsExecuteDataResponse> DescribeDcdnEsExecuteDataAsync(DescribeDcdnEsExecuteDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnEsExecuteDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnHttpsDomainListResponse DescribeDcdnHttpsDomainListWithOptions(DescribeDcdnHttpsDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnHttpsDomainList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnHttpsDomainListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnHttpsDomainListResponse> DescribeDcdnHttpsDomainListWithOptionsAsync(DescribeDcdnHttpsDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnHttpsDomainList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnHttpsDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnHttpsDomainListResponse DescribeDcdnHttpsDomainList(DescribeDcdnHttpsDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnHttpsDomainListWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnHttpsDomainListResponse> DescribeDcdnHttpsDomainListAsync(DescribeDcdnHttpsDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnHttpsDomainListWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpInfoResponse DescribeDcdnIpInfoWithOptions(DescribeDcdnIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IP))
            {
                query["IP"] = request.IP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnIpInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnIpInfoResponse> DescribeDcdnIpInfoWithOptionsAsync(DescribeDcdnIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IP))
            {
                query["IP"] = request.IP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnIpInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnIpInfoResponse DescribeDcdnIpInfo(DescribeDcdnIpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpInfoResponse> DescribeDcdnIpInfoAsync(DescribeDcdnIpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpaDomainConfigsResponse DescribeDcdnIpaDomainConfigsWithOptions(DescribeDcdnIpaDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnIpaDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpaDomainConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnIpaDomainConfigsResponse> DescribeDcdnIpaDomainConfigsWithOptionsAsync(DescribeDcdnIpaDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnIpaDomainConfigs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpaDomainConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnIpaDomainConfigsResponse DescribeDcdnIpaDomainConfigs(DescribeDcdnIpaDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpaDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpaDomainConfigsResponse> DescribeDcdnIpaDomainConfigsAsync(DescribeDcdnIpaDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpaDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpaDomainDetailResponse DescribeDcdnIpaDomainDetailWithOptions(DescribeDcdnIpaDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnIpaDomainDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpaDomainDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnIpaDomainDetailResponse> DescribeDcdnIpaDomainDetailWithOptionsAsync(DescribeDcdnIpaDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnIpaDomainDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpaDomainDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnIpaDomainDetailResponse DescribeDcdnIpaDomainDetail(DescribeDcdnIpaDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpaDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpaDomainDetailResponse> DescribeDcdnIpaDomainDetailAsync(DescribeDcdnIpaDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpaDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpaServiceResponse DescribeDcdnIpaServiceWithOptions(DescribeDcdnIpaServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnIpaService",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpaServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnIpaServiceResponse> DescribeDcdnIpaServiceWithOptionsAsync(DescribeDcdnIpaServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnIpaService",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpaServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnIpaServiceResponse DescribeDcdnIpaService(DescribeDcdnIpaServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpaServiceWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpaServiceResponse> DescribeDcdnIpaServiceAsync(DescribeDcdnIpaServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpaServiceWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpaUserDomainsResponse DescribeDcdnIpaUserDomainsWithOptions(DescribeDcdnIpaUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckDomainShow))
            {
                query["CheckDomainShow"] = request.CheckDomainShow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainSearchType))
            {
                query["DomainSearchType"] = request.DomainSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncFilter))
            {
                query["FuncFilter"] = request.FuncFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncId))
            {
                query["FuncId"] = request.FuncId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeDcdnIpaUserDomains",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpaUserDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnIpaUserDomainsResponse> DescribeDcdnIpaUserDomainsWithOptionsAsync(DescribeDcdnIpaUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckDomainShow))
            {
                query["CheckDomainShow"] = request.CheckDomainShow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainSearchType))
            {
                query["DomainSearchType"] = request.DomainSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncFilter))
            {
                query["FuncFilter"] = request.FuncFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncId))
            {
                query["FuncId"] = request.FuncId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeDcdnIpaUserDomains",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnIpaUserDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnIpaUserDomainsResponse DescribeDcdnIpaUserDomains(DescribeDcdnIpaUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpaUserDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpaUserDomainsResponse> DescribeDcdnIpaUserDomainsAsync(DescribeDcdnIpaUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpaUserDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnRealTimeDeliveryFieldResponse DescribeDcdnRealTimeDeliveryFieldWithOptions(DescribeDcdnRealTimeDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
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
                Action = "DescribeDcdnRealTimeDeliveryField",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRealTimeDeliveryFieldResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnRealTimeDeliveryFieldResponse> DescribeDcdnRealTimeDeliveryFieldWithOptionsAsync(DescribeDcdnRealTimeDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
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
                Action = "DescribeDcdnRealTimeDeliveryField",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRealTimeDeliveryFieldResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnRealTimeDeliveryFieldResponse DescribeDcdnRealTimeDeliveryField(DescribeDcdnRealTimeDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnRealTimeDeliveryFieldWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnRealTimeDeliveryFieldResponse> DescribeDcdnRealTimeDeliveryFieldAsync(DescribeDcdnRealTimeDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnRealTimeDeliveryFieldWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnRefreshQuotaResponse DescribeDcdnRefreshQuotaWithOptions(DescribeDcdnRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnRefreshQuota",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRefreshQuotaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnRefreshQuotaResponse> DescribeDcdnRefreshQuotaWithOptionsAsync(DescribeDcdnRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnRefreshQuota",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRefreshQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnRefreshQuotaResponse DescribeDcdnRefreshQuota(DescribeDcdnRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnRefreshQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnRefreshQuotaResponse> DescribeDcdnRefreshQuotaAsync(DescribeDcdnRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnRefreshQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnRefreshTaskByIdResponse DescribeDcdnRefreshTaskByIdWithOptions(DescribeDcdnRefreshTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDcdnRefreshTaskById",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRefreshTaskByIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnRefreshTaskByIdResponse> DescribeDcdnRefreshTaskByIdWithOptionsAsync(DescribeDcdnRefreshTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDcdnRefreshTaskById",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRefreshTaskByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnRefreshTaskByIdResponse DescribeDcdnRefreshTaskById(DescribeDcdnRefreshTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnRefreshTaskByIdWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnRefreshTaskByIdResponse> DescribeDcdnRefreshTaskByIdAsync(DescribeDcdnRefreshTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnRefreshTaskByIdWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnRefreshTasksResponse DescribeDcdnRefreshTasksWithOptions(DescribeDcdnRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeDcdnRefreshTasks",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRefreshTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnRefreshTasksResponse> DescribeDcdnRefreshTasksWithOptionsAsync(DescribeDcdnRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeDcdnRefreshTasks",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRefreshTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnRefreshTasksResponse DescribeDcdnRefreshTasks(DescribeDcdnRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnRefreshTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnRefreshTasksResponse> DescribeDcdnRefreshTasksAsync(DescribeDcdnRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnRefreshTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnRegionAndIspResponse DescribeDcdnRegionAndIspWithOptions(DescribeDcdnRegionAndIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnRegionAndIsp",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRegionAndIspResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnRegionAndIspResponse> DescribeDcdnRegionAndIspWithOptionsAsync(DescribeDcdnRegionAndIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnRegionAndIsp",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnRegionAndIspResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnRegionAndIspResponse DescribeDcdnRegionAndIsp(DescribeDcdnRegionAndIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnRegionAndIspWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnRegionAndIspResponse> DescribeDcdnRegionAndIspAsync(DescribeDcdnRegionAndIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnRegionAndIspWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnReportResponse DescribeDcdnReportWithOptions(DescribeDcdnReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpCode))
            {
                query["HttpCode"] = request.HttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOverseas))
            {
                query["IsOverseas"] = request.IsOverseas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnReport",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnReportResponse> DescribeDcdnReportWithOptionsAsync(DescribeDcdnReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpCode))
            {
                query["HttpCode"] = request.HttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOverseas))
            {
                query["IsOverseas"] = request.IsOverseas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnReport",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnReportResponse DescribeDcdnReport(DescribeDcdnReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnReportWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnReportResponse> DescribeDcdnReportAsync(DescribeDcdnReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnReportWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnReportListResponse DescribeDcdnReportListWithOptions(DescribeDcdnReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnReportList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnReportListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnReportListResponse> DescribeDcdnReportListWithOptionsAsync(DescribeDcdnReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnReportList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnReportListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnReportListResponse DescribeDcdnReportList(DescribeDcdnReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnReportListWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnReportListResponse> DescribeDcdnReportListAsync(DescribeDcdnReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnReportListWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnSLSRealtimeLogDeliveryResponse DescribeDcdnSLSRealtimeLogDeliveryWithOptions(DescribeDcdnSLSRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnSLSRealtimeLogDelivery",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSLSRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnSLSRealtimeLogDeliveryResponse> DescribeDcdnSLSRealtimeLogDeliveryWithOptionsAsync(DescribeDcdnSLSRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnSLSRealtimeLogDelivery",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSLSRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnSLSRealtimeLogDeliveryResponse DescribeDcdnSLSRealtimeLogDelivery(DescribeDcdnSLSRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnSLSRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnSLSRealtimeLogDeliveryResponse> DescribeDcdnSLSRealtimeLogDeliveryAsync(DescribeDcdnSLSRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnSLSRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnSMCertificateDetailResponse DescribeDcdnSMCertificateDetailWithOptions(DescribeDcdnSMCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnSMCertificateDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSMCertificateDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnSMCertificateDetailResponse> DescribeDcdnSMCertificateDetailWithOptionsAsync(DescribeDcdnSMCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnSMCertificateDetail",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSMCertificateDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnSMCertificateDetailResponse DescribeDcdnSMCertificateDetail(DescribeDcdnSMCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnSMCertificateDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnSMCertificateDetailResponse> DescribeDcdnSMCertificateDetailAsync(DescribeDcdnSMCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnSMCertificateDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnSMCertificateListResponse DescribeDcdnSMCertificateListWithOptions(DescribeDcdnSMCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnSMCertificateList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSMCertificateListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnSMCertificateListResponse> DescribeDcdnSMCertificateListWithOptionsAsync(DescribeDcdnSMCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnSMCertificateList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSMCertificateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnSMCertificateListResponse DescribeDcdnSMCertificateList(DescribeDcdnSMCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnSMCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnSMCertificateListResponse> DescribeDcdnSMCertificateListAsync(DescribeDcdnSMCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnSMCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnSecFuncInfoResponse DescribeDcdnSecFuncInfoWithOptions(DescribeDcdnSecFuncInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecFuncType))
            {
                query["SecFuncType"] = request.SecFuncType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnSecFuncInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSecFuncInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnSecFuncInfoResponse> DescribeDcdnSecFuncInfoWithOptionsAsync(DescribeDcdnSecFuncInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecFuncType))
            {
                query["SecFuncType"] = request.SecFuncType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnSecFuncInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSecFuncInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnSecFuncInfoResponse DescribeDcdnSecFuncInfo(DescribeDcdnSecFuncInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnSecFuncInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnSecFuncInfoResponse> DescribeDcdnSecFuncInfoAsync(DescribeDcdnSecFuncInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnSecFuncInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnSecSpecInfoResponse DescribeDcdnSecSpecInfoWithOptions(DescribeDcdnSecSpecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeDcdnSecSpecInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSecSpecInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnSecSpecInfoResponse> DescribeDcdnSecSpecInfoWithOptionsAsync(DescribeDcdnSecSpecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeDcdnSecSpecInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSecSpecInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnSecSpecInfoResponse DescribeDcdnSecSpecInfo(DescribeDcdnSecSpecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnSecSpecInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnSecSpecInfoResponse> DescribeDcdnSecSpecInfoAsync(DescribeDcdnSecSpecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnSecSpecInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnServiceResponse DescribeDcdnServiceWithOptions(DescribeDcdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnService",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnServiceResponse> DescribeDcdnServiceWithOptionsAsync(DescribeDcdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnService",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnServiceResponse DescribeDcdnService(DescribeDcdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnServiceWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnServiceResponse> DescribeDcdnServiceAsync(DescribeDcdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnServiceWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnStagingIpResponse DescribeDcdnStagingIpWithOptions(DescribeDcdnStagingIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeDcdnStagingIp",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnStagingIpResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnStagingIpResponse> DescribeDcdnStagingIpWithOptionsAsync(DescribeDcdnStagingIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeDcdnStagingIp",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnStagingIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnStagingIpResponse DescribeDcdnStagingIp(DescribeDcdnStagingIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnStagingIpWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnStagingIpResponse> DescribeDcdnStagingIpAsync(DescribeDcdnStagingIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnStagingIpWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnSubListResponse DescribeDcdnSubListWithOptions(DescribeDcdnSubListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeDcdnSubList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSubListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnSubListResponse> DescribeDcdnSubListWithOptionsAsync(DescribeDcdnSubListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeDcdnSubList",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnSubListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnSubListResponse DescribeDcdnSubList(DescribeDcdnSubListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnSubListWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnSubListResponse> DescribeDcdnSubListAsync(DescribeDcdnSubListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnSubListWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnTagResourcesResponse DescribeDcdnTagResourcesWithOptions(DescribeDcdnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDcdnTagResources",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnTagResourcesResponse> DescribeDcdnTagResourcesWithOptionsAsync(DescribeDcdnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDcdnTagResources",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnTagResourcesResponse DescribeDcdnTagResources(DescribeDcdnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnTagResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnTagResourcesResponse> DescribeDcdnTagResourcesAsync(DescribeDcdnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnTagResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnTopDomainsByFlowResponse DescribeDcdnTopDomainsByFlowWithOptions(DescribeDcdnTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnTopDomainsByFlow",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnTopDomainsByFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnTopDomainsByFlowResponse> DescribeDcdnTopDomainsByFlowWithOptionsAsync(DescribeDcdnTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnTopDomainsByFlow",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnTopDomainsByFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnTopDomainsByFlowResponse DescribeDcdnTopDomainsByFlow(DescribeDcdnTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnTopDomainsByFlowWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnTopDomainsByFlowResponse> DescribeDcdnTopDomainsByFlowAsync(DescribeDcdnTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnTopDomainsByFlowWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserBillHistoryResponse DescribeDcdnUserBillHistoryWithOptions(DescribeDcdnUserBillHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserBillHistory",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserBillHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserBillHistoryResponse> DescribeDcdnUserBillHistoryWithOptionsAsync(DescribeDcdnUserBillHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserBillHistory",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserBillHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserBillHistoryResponse DescribeDcdnUserBillHistory(DescribeDcdnUserBillHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserBillHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserBillHistoryResponse> DescribeDcdnUserBillHistoryAsync(DescribeDcdnUserBillHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserBillHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserBillTypeResponse DescribeDcdnUserBillTypeWithOptions(DescribeDcdnUserBillTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserBillType",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserBillTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserBillTypeResponse> DescribeDcdnUserBillTypeWithOptionsAsync(DescribeDcdnUserBillTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserBillType",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserBillTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserBillTypeResponse DescribeDcdnUserBillType(DescribeDcdnUserBillTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserBillTypeWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserBillTypeResponse> DescribeDcdnUserBillTypeAsync(DescribeDcdnUserBillTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserBillTypeWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserDomainsResponse DescribeDcdnUserDomainsWithOptions(DescribeDcdnUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                query["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                query["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckDomainShow))
            {
                query["CheckDomainShow"] = request.CheckDomainShow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coverage))
            {
                query["Coverage"] = request.Coverage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainSearchType))
            {
                query["DomainSearchType"] = request.DomainSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeDcdnUserDomains",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserDomainsResponse> DescribeDcdnUserDomainsWithOptionsAsync(DescribeDcdnUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                query["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                query["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckDomainShow))
            {
                query["CheckDomainShow"] = request.CheckDomainShow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Coverage))
            {
                query["Coverage"] = request.Coverage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainSearchType))
            {
                query["DomainSearchType"] = request.DomainSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeDcdnUserDomains",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserDomainsResponse DescribeDcdnUserDomains(DescribeDcdnUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserDomainsResponse> DescribeDcdnUserDomainsAsync(DescribeDcdnUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserDomainsByFuncResponse DescribeDcdnUserDomainsByFuncWithOptions(DescribeDcdnUserDomainsByFuncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncFilter))
            {
                query["FuncFilter"] = request.FuncFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncId))
            {
                query["FuncId"] = request.FuncId;
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
                Action = "DescribeDcdnUserDomainsByFunc",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserDomainsByFuncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserDomainsByFuncResponse> DescribeDcdnUserDomainsByFuncWithOptionsAsync(DescribeDcdnUserDomainsByFuncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncFilter))
            {
                query["FuncFilter"] = request.FuncFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncId))
            {
                query["FuncId"] = request.FuncId;
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
                Action = "DescribeDcdnUserDomainsByFunc",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserDomainsByFuncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserDomainsByFuncResponse DescribeDcdnUserDomainsByFunc(DescribeDcdnUserDomainsByFuncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserDomainsByFuncWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserDomainsByFuncResponse> DescribeDcdnUserDomainsByFuncAsync(DescribeDcdnUserDomainsByFuncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserDomainsByFuncWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserQuotaResponse DescribeDcdnUserQuotaWithOptions(DescribeDcdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserQuota",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserQuotaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserQuotaResponse> DescribeDcdnUserQuotaWithOptionsAsync(DescribeDcdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserQuota",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserQuotaResponse DescribeDcdnUserQuota(DescribeDcdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserQuotaResponse> DescribeDcdnUserQuotaAsync(DescribeDcdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserRealTimeDeliveryFieldResponse DescribeDcdnUserRealTimeDeliveryFieldWithOptions(DescribeDcdnUserRealTimeDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserRealTimeDeliveryField",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserRealTimeDeliveryFieldResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserRealTimeDeliveryFieldResponse> DescribeDcdnUserRealTimeDeliveryFieldWithOptionsAsync(DescribeDcdnUserRealTimeDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserRealTimeDeliveryField",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserRealTimeDeliveryFieldResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserRealTimeDeliveryFieldResponse DescribeDcdnUserRealTimeDeliveryField(DescribeDcdnUserRealTimeDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserRealTimeDeliveryFieldWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserRealTimeDeliveryFieldResponse> DescribeDcdnUserRealTimeDeliveryFieldAsync(DescribeDcdnUserRealTimeDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserRealTimeDeliveryFieldWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserResourcePackageResponse DescribeDcdnUserResourcePackageWithOptions(DescribeDcdnUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeDcdnUserResourcePackage",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserResourcePackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserResourcePackageResponse> DescribeDcdnUserResourcePackageWithOptionsAsync(DescribeDcdnUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeDcdnUserResourcePackage",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserResourcePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserResourcePackageResponse DescribeDcdnUserResourcePackage(DescribeDcdnUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserResourcePackageWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserResourcePackageResponse> DescribeDcdnUserResourcePackageAsync(DescribeDcdnUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserResourcePackageWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserSecDropResponse DescribeDcdnUserSecDropWithOptions(DescribeDcdnUserSecDropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                query["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecFunc))
            {
                query["SecFunc"] = request.SecFunc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserSecDrop",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserSecDropResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserSecDropResponse> DescribeDcdnUserSecDropWithOptionsAsync(DescribeDcdnUserSecDropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                query["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecFunc))
            {
                query["SecFunc"] = request.SecFunc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserSecDrop",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserSecDropResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserSecDropResponse DescribeDcdnUserSecDrop(DescribeDcdnUserSecDropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserSecDropWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserSecDropResponse> DescribeDcdnUserSecDropAsync(DescribeDcdnUserSecDropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserSecDropWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserSecDropByMinuteResponse DescribeDcdnUserSecDropByMinuteWithOptions(DescribeDcdnUserSecDropByMinuteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Object))
            {
                query["Object"] = request.Object;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecFunc))
            {
                query["SecFunc"] = request.SecFunc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserSecDropByMinute",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserSecDropByMinuteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserSecDropByMinuteResponse> DescribeDcdnUserSecDropByMinuteWithOptionsAsync(DescribeDcdnUserSecDropByMinuteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Object))
            {
                query["Object"] = request.Object;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecFunc))
            {
                query["SecFunc"] = request.SecFunc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnUserSecDropByMinute",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserSecDropByMinuteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserSecDropByMinuteResponse DescribeDcdnUserSecDropByMinute(DescribeDcdnUserSecDropByMinuteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserSecDropByMinuteWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserSecDropByMinuteResponse> DescribeDcdnUserSecDropByMinuteAsync(DescribeDcdnUserSecDropByMinuteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserSecDropByMinuteWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserTagsResponse DescribeDcdnUserTagsWithOptions(DescribeDcdnUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeDcdnUserTags",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnUserTagsResponse> DescribeDcdnUserTagsWithOptionsAsync(DescribeDcdnUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeDcdnUserTags",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnUserTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnUserTagsResponse DescribeDcdnUserTags(DescribeDcdnUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserTagsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserTagsResponse> DescribeDcdnUserTagsAsync(DescribeDcdnUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserTagsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnVerifyContentResponse DescribeDcdnVerifyContentWithOptions(DescribeDcdnVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "DescribeDcdnVerifyContent",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnVerifyContentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnVerifyContentResponse> DescribeDcdnVerifyContentWithOptionsAsync(DescribeDcdnVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "DescribeDcdnVerifyContent",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnVerifyContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnVerifyContentResponse DescribeDcdnVerifyContent(DescribeDcdnVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnVerifyContentWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnVerifyContentResponse> DescribeDcdnVerifyContentAsync(DescribeDcdnVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnVerifyContentWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnWafDomainResponse DescribeDcdnWafDomainWithOptions(DescribeDcdnWafDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDcdnWafDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnWafDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnWafDomainResponse> DescribeDcdnWafDomainWithOptionsAsync(DescribeDcdnWafDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeDcdnWafDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnWafDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnWafDomainResponse DescribeDcdnWafDomain(DescribeDcdnWafDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnWafDomainWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnWafDomainResponse> DescribeDcdnWafDomainAsync(DescribeDcdnWafDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnWafDomainWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnsecServiceResponse DescribeDcdnsecServiceWithOptions(DescribeDcdnsecServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnsecService",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnsecServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDcdnsecServiceResponse> DescribeDcdnsecServiceWithOptionsAsync(DescribeDcdnsecServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDcdnsecService",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDcdnsecServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDcdnsecServiceResponse DescribeDcdnsecService(DescribeDcdnsecServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnsecServiceWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnsecServiceResponse> DescribeDcdnsecServiceAsync(DescribeDcdnsecServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnsecServiceWithOptionsAsync(request, runtime);
        }

        public DescribeRoutineResponse DescribeRoutineWithOptions(DescribeRoutineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRoutine",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRoutineResponse> DescribeRoutineWithOptionsAsync(DescribeRoutineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRoutine",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRoutineResponse DescribeRoutine(DescribeRoutineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoutineWithOptions(request, runtime);
        }

        public async Task<DescribeRoutineResponse> DescribeRoutineAsync(DescribeRoutineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoutineWithOptionsAsync(request, runtime);
        }

        public DescribeRoutineCanaryEnvsResponse DescribeRoutineCanaryEnvsWithOptions(DescribeRoutineCanaryEnvsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRoutineCanaryEnvs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineCanaryEnvsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRoutineCanaryEnvsResponse> DescribeRoutineCanaryEnvsWithOptionsAsync(DescribeRoutineCanaryEnvsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRoutineCanaryEnvs",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineCanaryEnvsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRoutineCanaryEnvsResponse DescribeRoutineCanaryEnvs(DescribeRoutineCanaryEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoutineCanaryEnvsWithOptions(request, runtime);
        }

        public async Task<DescribeRoutineCanaryEnvsResponse> DescribeRoutineCanaryEnvsAsync(DescribeRoutineCanaryEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoutineCanaryEnvsWithOptionsAsync(request, runtime);
        }

        public DescribeRoutineCodeRevisionResponse DescribeRoutineCodeRevisionWithOptions(DescribeRoutineCodeRevisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectCodeRevision))
            {
                body["SelectCodeRevision"] = request.SelectCodeRevision;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRoutineCodeRevision",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineCodeRevisionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRoutineCodeRevisionResponse> DescribeRoutineCodeRevisionWithOptionsAsync(DescribeRoutineCodeRevisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectCodeRevision))
            {
                body["SelectCodeRevision"] = request.SelectCodeRevision;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRoutineCodeRevision",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineCodeRevisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRoutineCodeRevisionResponse DescribeRoutineCodeRevision(DescribeRoutineCodeRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoutineCodeRevisionWithOptions(request, runtime);
        }

        public async Task<DescribeRoutineCodeRevisionResponse> DescribeRoutineCodeRevisionAsync(DescribeRoutineCodeRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoutineCodeRevisionWithOptionsAsync(request, runtime);
        }

        public DescribeRoutineSpecResponse DescribeRoutineSpecWithOptions(DescribeRoutineSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRoutineSpec",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineSpecResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRoutineSpecResponse> DescribeRoutineSpecWithOptionsAsync(DescribeRoutineSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRoutineSpec",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRoutineSpecResponse DescribeRoutineSpec(DescribeRoutineSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoutineSpecWithOptions(request, runtime);
        }

        public async Task<DescribeRoutineSpecResponse> DescribeRoutineSpecAsync(DescribeRoutineSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoutineSpecWithOptionsAsync(request, runtime);
        }

        public DescribeRoutineUserInfoResponse DescribeRoutineUserInfoWithOptions(DescribeRoutineUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRoutineUserInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineUserInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRoutineUserInfoResponse> DescribeRoutineUserInfoWithOptionsAsync(DescribeRoutineUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRoutineUserInfo",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoutineUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRoutineUserInfoResponse DescribeRoutineUserInfo(DescribeRoutineUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoutineUserInfoWithOptions(request, runtime);
        }

        public async Task<DescribeRoutineUserInfoResponse> DescribeRoutineUserInfoAsync(DescribeRoutineUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoutineUserInfoWithOptionsAsync(request, runtime);
        }

        public DescribeUserDcdnIpaStatusResponse DescribeUserDcdnIpaStatusWithOptions(DescribeUserDcdnIpaStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserDcdnIpaStatus",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserDcdnIpaStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserDcdnIpaStatusResponse> DescribeUserDcdnIpaStatusWithOptionsAsync(DescribeUserDcdnIpaStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserDcdnIpaStatus",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserDcdnIpaStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserDcdnIpaStatusResponse DescribeUserDcdnIpaStatus(DescribeUserDcdnIpaStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserDcdnIpaStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserDcdnIpaStatusResponse> DescribeUserDcdnIpaStatusAsync(DescribeUserDcdnIpaStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserDcdnIpaStatusWithOptionsAsync(request, runtime);
        }

        public DescribeUserDcdnStatusResponse DescribeUserDcdnStatusWithOptions(DescribeUserDcdnStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserDcdnStatus",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserDcdnStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserDcdnStatusResponse> DescribeUserDcdnStatusWithOptionsAsync(DescribeUserDcdnStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserDcdnStatus",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserDcdnStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserDcdnStatusResponse DescribeUserDcdnStatus(DescribeUserDcdnStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserDcdnStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserDcdnStatusResponse> DescribeUserDcdnStatusAsync(DescribeUserDcdnStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserDcdnStatusWithOptionsAsync(request, runtime);
        }

        public DescribeUserErStatusResponse DescribeUserErStatusWithOptions(DescribeUserErStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserErStatus",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserErStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserErStatusResponse> DescribeUserErStatusWithOptionsAsync(DescribeUserErStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserErStatus",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserErStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserErStatusResponse DescribeUserErStatus(DescribeUserErStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserErStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserErStatusResponse> DescribeUserErStatusAsync(DescribeUserErStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserErStatusWithOptionsAsync(request, runtime);
        }

        public DescribeUserLogserviceStatusResponse DescribeUserLogserviceStatusWithOptions(DescribeUserLogserviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserLogserviceStatus",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserLogserviceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserLogserviceStatusResponse> DescribeUserLogserviceStatusWithOptionsAsync(DescribeUserLogserviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserLogserviceStatus",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserLogserviceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserLogserviceStatusResponse DescribeUserLogserviceStatus(DescribeUserLogserviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserLogserviceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserLogserviceStatusResponse> DescribeUserLogserviceStatusAsync(DescribeUserLogserviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserLogserviceStatusWithOptionsAsync(request, runtime);
        }

        public EditRoutineConfResponse EditRoutineConfWithOptions(EditRoutineConfRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EditRoutineConfShrinkRequest request = new EditRoutineConfShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EnvConf))
            {
                request.EnvConfShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EnvConf, "EnvConf", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvConfShrink))
            {
                body["EnvConf"] = request.EnvConfShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditRoutineConf",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditRoutineConfResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EditRoutineConfResponse> EditRoutineConfWithOptionsAsync(EditRoutineConfRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EditRoutineConfShrinkRequest request = new EditRoutineConfShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EnvConf))
            {
                request.EnvConfShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EnvConf, "EnvConf", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvConfShrink))
            {
                body["EnvConf"] = request.EnvConfShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditRoutineConf",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditRoutineConfResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EditRoutineConfResponse EditRoutineConf(EditRoutineConfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditRoutineConfWithOptions(request, runtime);
        }

        public async Task<EditRoutineConfResponse> EditRoutineConfAsync(EditRoutineConfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditRoutineConfWithOptionsAsync(request, runtime);
        }

        public ListDcdnEsTemplateInfoResponse ListDcdnEsTemplateInfoWithOptions(ListDcdnEsTemplateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDcdnEsTemplateInfo",
                Version = "2018-01-15",
                Protocol = "HTTP",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDcdnEsTemplateInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDcdnEsTemplateInfoResponse> ListDcdnEsTemplateInfoWithOptionsAsync(ListDcdnEsTemplateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDcdnEsTemplateInfo",
                Version = "2018-01-15",
                Protocol = "HTTP",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDcdnEsTemplateInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDcdnEsTemplateInfoResponse ListDcdnEsTemplateInfo(ListDcdnEsTemplateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDcdnEsTemplateInfoWithOptions(request, runtime);
        }

        public async Task<ListDcdnEsTemplateInfoResponse> ListDcdnEsTemplateInfoAsync(ListDcdnEsTemplateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDcdnEsTemplateInfoWithOptionsAsync(request, runtime);
        }

        public ListDcdnRealTimeDeliveryProjectResponse ListDcdnRealTimeDeliveryProjectWithOptions(ListDcdnRealTimeDeliveryProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDcdnRealTimeDeliveryProject",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDcdnRealTimeDeliveryProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDcdnRealTimeDeliveryProjectResponse> ListDcdnRealTimeDeliveryProjectWithOptionsAsync(ListDcdnRealTimeDeliveryProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDcdnRealTimeDeliveryProject",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDcdnRealTimeDeliveryProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDcdnRealTimeDeliveryProjectResponse ListDcdnRealTimeDeliveryProject(ListDcdnRealTimeDeliveryProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDcdnRealTimeDeliveryProjectWithOptions(request, runtime);
        }

        public async Task<ListDcdnRealTimeDeliveryProjectResponse> ListDcdnRealTimeDeliveryProjectAsync(ListDcdnRealTimeDeliveryProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDcdnRealTimeDeliveryProjectWithOptionsAsync(request, runtime);
        }

        public ModifyDCdnDomainSchdmByPropertyResponse ModifyDCdnDomainSchdmByPropertyWithOptions(ModifyDCdnDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                query["Property"] = request.Property;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDCdnDomainSchdmByProperty",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDCdnDomainSchdmByPropertyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDCdnDomainSchdmByPropertyResponse> ModifyDCdnDomainSchdmByPropertyWithOptionsAsync(ModifyDCdnDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                query["Property"] = request.Property;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDCdnDomainSchdmByProperty",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDCdnDomainSchdmByPropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDCdnDomainSchdmByPropertyResponse ModifyDCdnDomainSchdmByProperty(ModifyDCdnDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDCdnDomainSchdmByPropertyWithOptions(request, runtime);
        }

        public async Task<ModifyDCdnDomainSchdmByPropertyResponse> ModifyDCdnDomainSchdmByPropertyAsync(ModifyDCdnDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDCdnDomainSchdmByPropertyWithOptionsAsync(request, runtime);
        }

        public OpenDcdnServiceResponse OpenDcdnServiceWithOptions(OpenDcdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebsocketBillType))
            {
                query["WebsocketBillType"] = request.WebsocketBillType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDcdnService",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDcdnServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenDcdnServiceResponse> OpenDcdnServiceWithOptionsAsync(OpenDcdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebsocketBillType))
            {
                query["WebsocketBillType"] = request.WebsocketBillType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDcdnService",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDcdnServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenDcdnServiceResponse OpenDcdnService(OpenDcdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenDcdnServiceWithOptions(request, runtime);
        }

        public async Task<OpenDcdnServiceResponse> OpenDcdnServiceAsync(OpenDcdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenDcdnServiceWithOptionsAsync(request, runtime);
        }

        public PreloadDcdnObjectCachesResponse PreloadDcdnObjectCachesWithOptions(PreloadDcdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreloadDcdnObjectCaches",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreloadDcdnObjectCachesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PreloadDcdnObjectCachesResponse> PreloadDcdnObjectCachesWithOptionsAsync(PreloadDcdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreloadDcdnObjectCaches",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreloadDcdnObjectCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PreloadDcdnObjectCachesResponse PreloadDcdnObjectCaches(PreloadDcdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreloadDcdnObjectCachesWithOptions(request, runtime);
        }

        public async Task<PreloadDcdnObjectCachesResponse> PreloadDcdnObjectCachesAsync(PreloadDcdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreloadDcdnObjectCachesWithOptionsAsync(request, runtime);
        }

        public PublishDcdnStagingConfigToProductionResponse PublishDcdnStagingConfigToProductionWithOptions(PublishDcdnStagingConfigToProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
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
                Action = "PublishDcdnStagingConfigToProduction",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishDcdnStagingConfigToProductionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PublishDcdnStagingConfigToProductionResponse> PublishDcdnStagingConfigToProductionWithOptionsAsync(PublishDcdnStagingConfigToProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
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
                Action = "PublishDcdnStagingConfigToProduction",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishDcdnStagingConfigToProductionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PublishDcdnStagingConfigToProductionResponse PublishDcdnStagingConfigToProduction(PublishDcdnStagingConfigToProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishDcdnStagingConfigToProductionWithOptions(request, runtime);
        }

        public async Task<PublishDcdnStagingConfigToProductionResponse> PublishDcdnStagingConfigToProductionAsync(PublishDcdnStagingConfigToProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishDcdnStagingConfigToProductionWithOptionsAsync(request, runtime);
        }

        public PublishRoutineCodeRevisionResponse PublishRoutineCodeRevisionWithOptions(PublishRoutineCodeRevisionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PublishRoutineCodeRevisionShrinkRequest request = new PublishRoutineCodeRevisionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Envs))
            {
                request.EnvsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Envs, "Envs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvsShrink))
            {
                body["Envs"] = request.EnvsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectCodeRevision))
            {
                body["SelectCodeRevision"] = request.SelectCodeRevision;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishRoutineCodeRevision",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRoutineCodeRevisionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PublishRoutineCodeRevisionResponse> PublishRoutineCodeRevisionWithOptionsAsync(PublishRoutineCodeRevisionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PublishRoutineCodeRevisionShrinkRequest request = new PublishRoutineCodeRevisionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Envs))
            {
                request.EnvsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Envs, "Envs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvsShrink))
            {
                body["Envs"] = request.EnvsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectCodeRevision))
            {
                body["SelectCodeRevision"] = request.SelectCodeRevision;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishRoutineCodeRevision",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRoutineCodeRevisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PublishRoutineCodeRevisionResponse PublishRoutineCodeRevision(PublishRoutineCodeRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishRoutineCodeRevisionWithOptions(request, runtime);
        }

        public async Task<PublishRoutineCodeRevisionResponse> PublishRoutineCodeRevisionAsync(PublishRoutineCodeRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishRoutineCodeRevisionWithOptionsAsync(request, runtime);
        }

        public RefreshDcdnObjectCachesResponse RefreshDcdnObjectCachesWithOptions(RefreshDcdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshDcdnObjectCaches",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshDcdnObjectCachesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefreshDcdnObjectCachesResponse> RefreshDcdnObjectCachesWithOptionsAsync(RefreshDcdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshDcdnObjectCaches",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshDcdnObjectCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefreshDcdnObjectCachesResponse RefreshDcdnObjectCaches(RefreshDcdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshDcdnObjectCachesWithOptions(request, runtime);
        }

        public async Task<RefreshDcdnObjectCachesResponse> RefreshDcdnObjectCachesAsync(RefreshDcdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDcdnObjectCachesWithOptionsAsync(request, runtime);
        }

        public RollbackDcdnStagingConfigResponse RollbackDcdnStagingConfigWithOptions(RollbackDcdnStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "RollbackDcdnStagingConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackDcdnStagingConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RollbackDcdnStagingConfigResponse> RollbackDcdnStagingConfigWithOptionsAsync(RollbackDcdnStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "RollbackDcdnStagingConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackDcdnStagingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RollbackDcdnStagingConfigResponse RollbackDcdnStagingConfig(RollbackDcdnStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackDcdnStagingConfigWithOptions(request, runtime);
        }

        public async Task<RollbackDcdnStagingConfigResponse> RollbackDcdnStagingConfigAsync(RollbackDcdnStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackDcdnStagingConfigWithOptionsAsync(request, runtime);
        }

        public SetDcdnConfigOfVersionResponse SetDcdnConfigOfVersionWithOptions(SetDcdnConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionArgs))
            {
                query["FunctionArgs"] = request.FunctionArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionId))
            {
                query["FunctionId"] = request.FunctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnConfigOfVersion",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnConfigOfVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDcdnConfigOfVersionResponse> SetDcdnConfigOfVersionWithOptionsAsync(SetDcdnConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionArgs))
            {
                query["FunctionArgs"] = request.FunctionArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionId))
            {
                query["FunctionId"] = request.FunctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnConfigOfVersion",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnConfigOfVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDcdnConfigOfVersionResponse SetDcdnConfigOfVersion(SetDcdnConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnConfigOfVersionWithOptions(request, runtime);
        }

        public async Task<SetDcdnConfigOfVersionResponse> SetDcdnConfigOfVersionAsync(SetDcdnConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnConfigOfVersionWithOptionsAsync(request, runtime);
        }

        public SetDcdnDomainCSRCertificateResponse SetDcdnDomainCSRCertificateWithOptions(SetDcdnDomainCSRCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificate))
            {
                query["ServerCertificate"] = request.ServerCertificate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnDomainCSRCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnDomainCSRCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDcdnDomainCSRCertificateResponse> SetDcdnDomainCSRCertificateWithOptionsAsync(SetDcdnDomainCSRCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificate))
            {
                query["ServerCertificate"] = request.ServerCertificate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnDomainCSRCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnDomainCSRCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDcdnDomainCSRCertificateResponse SetDcdnDomainCSRCertificate(SetDcdnDomainCSRCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnDomainCSRCertificateWithOptions(request, runtime);
        }

        public async Task<SetDcdnDomainCSRCertificateResponse> SetDcdnDomainCSRCertificateAsync(SetDcdnDomainCSRCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnDomainCSRCertificateWithOptionsAsync(request, runtime);
        }

        public SetDcdnDomainCertificateResponse SetDcdnDomainCertificateWithOptions(SetDcdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSet))
            {
                query["ForceSet"] = request.ForceSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPri))
            {
                query["SSLPri"] = request.SSLPri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLProtocol))
            {
                query["SSLProtocol"] = request.SSLProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnDomainCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnDomainCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDcdnDomainCertificateResponse> SetDcdnDomainCertificateWithOptionsAsync(SetDcdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSet))
            {
                query["ForceSet"] = request.ForceSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPri))
            {
                query["SSLPri"] = request.SSLPri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLProtocol))
            {
                query["SSLProtocol"] = request.SSLProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnDomainCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnDomainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDcdnDomainCertificateResponse SetDcdnDomainCertificate(SetDcdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnDomainCertificateWithOptions(request, runtime);
        }

        public async Task<SetDcdnDomainCertificateResponse> SetDcdnDomainCertificateAsync(SetDcdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnDomainCertificateWithOptionsAsync(request, runtime);
        }

        public SetDcdnDomainSMCertificateResponse SetDcdnDomainSMCertificateWithOptions(SetDcdnDomainSMCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLProtocol))
            {
                query["SSLProtocol"] = request.SSLProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnDomainSMCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnDomainSMCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDcdnDomainSMCertificateResponse> SetDcdnDomainSMCertificateWithOptionsAsync(SetDcdnDomainSMCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLProtocol))
            {
                query["SSLProtocol"] = request.SSLProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnDomainSMCertificate",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnDomainSMCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDcdnDomainSMCertificateResponse SetDcdnDomainSMCertificate(SetDcdnDomainSMCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnDomainSMCertificateWithOptions(request, runtime);
        }

        public async Task<SetDcdnDomainSMCertificateResponse> SetDcdnDomainSMCertificateAsync(SetDcdnDomainSMCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnDomainSMCertificateWithOptionsAsync(request, runtime);
        }

        public SetDcdnDomainStagingConfigResponse SetDcdnDomainStagingConfigWithOptions(SetDcdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                query["Functions"] = request.Functions;
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
                Action = "SetDcdnDomainStagingConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnDomainStagingConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDcdnDomainStagingConfigResponse> SetDcdnDomainStagingConfigWithOptionsAsync(SetDcdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                query["Functions"] = request.Functions;
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
                Action = "SetDcdnDomainStagingConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnDomainStagingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDcdnDomainStagingConfigResponse SetDcdnDomainStagingConfig(SetDcdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnDomainStagingConfigWithOptions(request, runtime);
        }

        public async Task<SetDcdnDomainStagingConfigResponse> SetDcdnDomainStagingConfigAsync(SetDcdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnDomainStagingConfigWithOptionsAsync(request, runtime);
        }

        public SetDcdnFullDomainsBlockIPResponse SetDcdnFullDomainsBlockIPWithOptions(SetDcdnFullDomainsBlockIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockInterval))
            {
                body["BlockInterval"] = request.BlockInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IPList))
            {
                body["IPList"] = request.IPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                body["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnFullDomainsBlockIP",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnFullDomainsBlockIPResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDcdnFullDomainsBlockIPResponse> SetDcdnFullDomainsBlockIPWithOptionsAsync(SetDcdnFullDomainsBlockIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockInterval))
            {
                body["BlockInterval"] = request.BlockInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IPList))
            {
                body["IPList"] = request.IPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                body["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnFullDomainsBlockIP",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnFullDomainsBlockIPResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDcdnFullDomainsBlockIPResponse SetDcdnFullDomainsBlockIP(SetDcdnFullDomainsBlockIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnFullDomainsBlockIPWithOptions(request, runtime);
        }

        public async Task<SetDcdnFullDomainsBlockIPResponse> SetDcdnFullDomainsBlockIPAsync(SetDcdnFullDomainsBlockIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnFullDomainsBlockIPWithOptionsAsync(request, runtime);
        }

        public SetDcdnUserConfigResponse SetDcdnUserConfigWithOptions(SetDcdnUserConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                query["Configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionId))
            {
                query["FunctionId"] = request.FunctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnUserConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnUserConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDcdnUserConfigResponse> SetDcdnUserConfigWithOptionsAsync(SetDcdnUserConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                query["Configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionId))
            {
                query["FunctionId"] = request.FunctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDcdnUserConfig",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDcdnUserConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDcdnUserConfigResponse SetDcdnUserConfig(SetDcdnUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnUserConfigWithOptions(request, runtime);
        }

        public async Task<SetDcdnUserConfigResponse> SetDcdnUserConfigAsync(SetDcdnUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnUserConfigWithOptionsAsync(request, runtime);
        }

        public SetRoutineSubdomainResponse SetRoutineSubdomainWithOptions(SetRoutineSubdomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetRoutineSubdomainShrinkRequest request = new SetRoutineSubdomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Subdomains))
            {
                request.SubdomainsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Subdomains, "Subdomains", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubdomainsShrink))
            {
                body["Subdomains"] = request.SubdomainsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRoutineSubdomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRoutineSubdomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetRoutineSubdomainResponse> SetRoutineSubdomainWithOptionsAsync(SetRoutineSubdomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetRoutineSubdomainShrinkRequest request = new SetRoutineSubdomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Subdomains))
            {
                request.SubdomainsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Subdomains, "Subdomains", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubdomainsShrink))
            {
                body["Subdomains"] = request.SubdomainsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRoutineSubdomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRoutineSubdomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetRoutineSubdomainResponse SetRoutineSubdomain(SetRoutineSubdomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRoutineSubdomainWithOptions(request, runtime);
        }

        public async Task<SetRoutineSubdomainResponse> SetRoutineSubdomainAsync(SetRoutineSubdomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRoutineSubdomainWithOptionsAsync(request, runtime);
        }

        public StartDcdnDomainResponse StartDcdnDomainWithOptions(StartDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDcdnDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartDcdnDomainResponse> StartDcdnDomainWithOptionsAsync(StartDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDcdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartDcdnDomainResponse StartDcdnDomain(StartDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDcdnDomainWithOptions(request, runtime);
        }

        public async Task<StartDcdnDomainResponse> StartDcdnDomainAsync(StartDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDcdnDomainWithOptionsAsync(request, runtime);
        }

        public StartDcdnIpaDomainResponse StartDcdnIpaDomainWithOptions(StartDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDcdnIpaDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartDcdnIpaDomainResponse> StartDcdnIpaDomainWithOptionsAsync(StartDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDcdnIpaDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartDcdnIpaDomainResponse StartDcdnIpaDomain(StartDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<StartDcdnIpaDomainResponse> StartDcdnIpaDomainAsync(StartDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public StopDcdnDomainResponse StopDcdnDomainWithOptions(StopDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDcdnDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopDcdnDomainResponse> StopDcdnDomainWithOptionsAsync(StopDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDcdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopDcdnDomainResponse StopDcdnDomain(StopDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDcdnDomainWithOptions(request, runtime);
        }

        public async Task<StopDcdnDomainResponse> StopDcdnDomainAsync(StopDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDcdnDomainWithOptionsAsync(request, runtime);
        }

        public StopDcdnIpaDomainResponse StopDcdnIpaDomainWithOptions(StopDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDcdnIpaDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopDcdnIpaDomainResponse> StopDcdnIpaDomainWithOptionsAsync(StopDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDcdnIpaDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopDcdnIpaDomainResponse StopDcdnIpaDomain(StopDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<StopDcdnIpaDomainResponse> StopDcdnIpaDomainAsync(StopDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public TagDcdnResourcesResponse TagDcdnResourcesWithOptions(TagDcdnResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "TagDcdnResources",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagDcdnResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagDcdnResourcesResponse> TagDcdnResourcesWithOptionsAsync(TagDcdnResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "TagDcdnResources",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagDcdnResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TagDcdnResourcesResponse TagDcdnResources(TagDcdnResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagDcdnResourcesWithOptions(request, runtime);
        }

        public async Task<TagDcdnResourcesResponse> TagDcdnResourcesAsync(TagDcdnResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagDcdnResourcesWithOptionsAsync(request, runtime);
        }

        public UntagDcdnResourcesResponse UntagDcdnResourcesWithOptions(UntagDcdnResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "UntagDcdnResources",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagDcdnResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagDcdnResourcesResponse> UntagDcdnResourcesWithOptionsAsync(UntagDcdnResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "UntagDcdnResources",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagDcdnResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UntagDcdnResourcesResponse UntagDcdnResources(UntagDcdnResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagDcdnResourcesWithOptions(request, runtime);
        }

        public async Task<UntagDcdnResourcesResponse> UntagDcdnResourcesAsync(UntagDcdnResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagDcdnResourcesWithOptionsAsync(request, runtime);
        }

        public UpdateDcdnDeliverTaskResponse UpdateDcdnDeliverTaskWithOptions(UpdateDcdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deliver))
            {
                body["Deliver"] = request.Deliver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                body["DeliverId"] = request.DeliverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reports))
            {
                body["Reports"] = request.Reports;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["Schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnDeliverTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnDeliverTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDcdnDeliverTaskResponse> UpdateDcdnDeliverTaskWithOptionsAsync(UpdateDcdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deliver))
            {
                body["Deliver"] = request.Deliver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                body["DeliverId"] = request.DeliverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reports))
            {
                body["Reports"] = request.Reports;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["Schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnDeliverTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnDeliverTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDcdnDeliverTaskResponse UpdateDcdnDeliverTask(UpdateDcdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDcdnDeliverTaskWithOptions(request, runtime);
        }

        public async Task<UpdateDcdnDeliverTaskResponse> UpdateDcdnDeliverTaskAsync(UpdateDcdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDcdnDeliverTaskWithOptionsAsync(request, runtime);
        }

        public UpdateDcdnDomainResponse UpdateDcdnDomainWithOptions(UpdateDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDcdnDomainResponse> UpdateDcdnDomainWithOptionsAsync(UpdateDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDcdnDomainResponse UpdateDcdnDomain(UpdateDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDcdnDomainWithOptions(request, runtime);
        }

        public async Task<UpdateDcdnDomainResponse> UpdateDcdnDomainAsync(UpdateDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDcdnDomainWithOptionsAsync(request, runtime);
        }

        public UpdateDcdnIpaDomainResponse UpdateDcdnIpaDomainWithOptions(UpdateDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnIpaDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDcdnIpaDomainResponse> UpdateDcdnIpaDomainWithOptionsAsync(UpdateDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnIpaDomain",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnIpaDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDcdnIpaDomainResponse UpdateDcdnIpaDomain(UpdateDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<UpdateDcdnIpaDomainResponse> UpdateDcdnIpaDomainAsync(UpdateDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public UpdateDcdnSLSRealtimeLogDeliveryResponse UpdateDcdnSLSRealtimeLogDeliveryWithOptions(UpdateDcdnSLSRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCenter))
            {
                body["DataCenter"] = request.DataCenter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSLogStore))
            {
                body["SLSLogStore"] = request.SLSLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSProject))
            {
                body["SLSProject"] = request.SLSProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSRegion))
            {
                body["SLSRegion"] = request.SLSRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                body["SamplingRate"] = request.SamplingRate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnSLSRealtimeLogDelivery",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnSLSRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDcdnSLSRealtimeLogDeliveryResponse> UpdateDcdnSLSRealtimeLogDeliveryWithOptionsAsync(UpdateDcdnSLSRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCenter))
            {
                body["DataCenter"] = request.DataCenter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSLogStore))
            {
                body["SLSLogStore"] = request.SLSLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSProject))
            {
                body["SLSProject"] = request.SLSProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSRegion))
            {
                body["SLSRegion"] = request.SLSRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                body["SamplingRate"] = request.SamplingRate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnSLSRealtimeLogDelivery",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnSLSRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDcdnSLSRealtimeLogDeliveryResponse UpdateDcdnSLSRealtimeLogDelivery(UpdateDcdnSLSRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDcdnSLSRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<UpdateDcdnSLSRealtimeLogDeliveryResponse> UpdateDcdnSLSRealtimeLogDeliveryAsync(UpdateDcdnSLSRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDcdnSLSRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public UpdateDcdnSubTaskResponse UpdateDcdnSubTaskWithOptions(UpdateDcdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportIds))
            {
                body["ReportIds"] = request.ReportIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnSubTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnSubTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDcdnSubTaskResponse> UpdateDcdnSubTaskWithOptionsAsync(UpdateDcdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportIds))
            {
                body["ReportIds"] = request.ReportIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnSubTask",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnSubTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDcdnSubTaskResponse UpdateDcdnSubTask(UpdateDcdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDcdnSubTaskWithOptions(request, runtime);
        }

        public async Task<UpdateDcdnSubTaskResponse> UpdateDcdnSubTaskAsync(UpdateDcdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDcdnSubTaskWithOptionsAsync(request, runtime);
        }

        public UpdateDcdnUserRealTimeDeliveryFieldResponse UpdateDcdnUserRealTimeDeliveryFieldWithOptions(UpdateDcdnUserRealTimeDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnUserRealTimeDeliveryField",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnUserRealTimeDeliveryFieldResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDcdnUserRealTimeDeliveryFieldResponse> UpdateDcdnUserRealTimeDeliveryFieldWithOptionsAsync(UpdateDcdnUserRealTimeDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDcdnUserRealTimeDeliveryField",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDcdnUserRealTimeDeliveryFieldResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDcdnUserRealTimeDeliveryFieldResponse UpdateDcdnUserRealTimeDeliveryField(UpdateDcdnUserRealTimeDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDcdnUserRealTimeDeliveryFieldWithOptions(request, runtime);
        }

        public async Task<UpdateDcdnUserRealTimeDeliveryFieldResponse> UpdateDcdnUserRealTimeDeliveryFieldAsync(UpdateDcdnUserRealTimeDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDcdnUserRealTimeDeliveryFieldWithOptionsAsync(request, runtime);
        }

        public UploadRoutineCodeResponse UploadRoutineCodeWithOptions(UploadRoutineCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeDescription))
            {
                body["CodeDescription"] = request.CodeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadRoutineCode",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRoutineCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadRoutineCodeResponse> UploadRoutineCodeWithOptionsAsync(UploadRoutineCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeDescription))
            {
                body["CodeDescription"] = request.CodeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadRoutineCode",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRoutineCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadRoutineCodeResponse UploadRoutineCode(UploadRoutineCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadRoutineCodeWithOptions(request, runtime);
        }

        public async Task<UploadRoutineCodeResponse> UploadRoutineCodeAsync(UploadRoutineCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadRoutineCodeWithOptionsAsync(request, runtime);
        }

        public UploadStagingRoutineCodeResponse UploadStagingRoutineCodeWithOptions(UploadStagingRoutineCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeDescription))
            {
                body["CodeDescription"] = request.CodeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadStagingRoutineCode",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadStagingRoutineCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadStagingRoutineCodeResponse> UploadStagingRoutineCodeWithOptionsAsync(UploadStagingRoutineCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeDescription))
            {
                body["CodeDescription"] = request.CodeDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadStagingRoutineCode",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadStagingRoutineCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadStagingRoutineCodeResponse UploadStagingRoutineCode(UploadStagingRoutineCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadStagingRoutineCodeWithOptions(request, runtime);
        }

        public async Task<UploadStagingRoutineCodeResponse> UploadStagingRoutineCodeAsync(UploadStagingRoutineCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadStagingRoutineCodeWithOptionsAsync(request, runtime);
        }

        public VerifyDcdnDomainOwnerResponse VerifyDcdnDomainOwnerWithOptions(VerifyDcdnDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyDcdnDomainOwner",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyDcdnDomainOwnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VerifyDcdnDomainOwnerResponse> VerifyDcdnDomainOwnerWithOptionsAsync(VerifyDcdnDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyDcdnDomainOwner",
                Version = "2018-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyDcdnDomainOwnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VerifyDcdnDomainOwnerResponse VerifyDcdnDomainOwner(VerifyDcdnDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyDcdnDomainOwnerWithOptions(request, runtime);
        }

        public async Task<VerifyDcdnDomainOwnerResponse> VerifyDcdnDomainOwnerAsync(VerifyDcdnDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyDcdnDomainOwnerWithOptionsAsync(request, runtime);
        }

    }
}
