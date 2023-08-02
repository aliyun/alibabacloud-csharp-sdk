// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cdn20180510.Models;

namespace AlibabaCloud.SDK.Cdn20180510
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "cdn.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "cdn.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cdn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * *   You must activate Alibaba Cloud CDN before you can add a domain name to it. For more information, see [Activate Alibaba Cloud CDN](~~27272~~).
          * *   The domain name that you want to add has a valid Internet Content Provider (ICP) number.
          * *   You can add only one domain name to Alibaba Cloud CDN in each call. Each Alibaba Cloud account can add a maximum of 50 domain names to Alibaba Cloud CDN.
          * *   If the content of the origin server is not stored on Alibaba Cloud, the content must be reviewed. The review will be completed by the end of the next business day after you submit the application.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request AddCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddCdnDomainResponse
         */
        public AddCdnDomainResponse AddCdnDomainWithOptions(AddCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CdnType))
            {
                query["CdnType"] = request.CdnType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalResourcePlan))
            {
                query["GlobalResourcePlan"] = request.GlobalResourcePlan;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "AddCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You must activate Alibaba Cloud CDN before you can add a domain name to it. For more information, see [Activate Alibaba Cloud CDN](~~27272~~).
          * *   The domain name that you want to add has a valid Internet Content Provider (ICP) number.
          * *   You can add only one domain name to Alibaba Cloud CDN in each call. Each Alibaba Cloud account can add a maximum of 50 domain names to Alibaba Cloud CDN.
          * *   If the content of the origin server is not stored on Alibaba Cloud, the content must be reviewed. The review will be completed by the end of the next business day after you submit the application.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request AddCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddCdnDomainResponse
         */
        public async Task<AddCdnDomainResponse> AddCdnDomainWithOptionsAsync(AddCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CdnType))
            {
                query["CdnType"] = request.CdnType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalResourcePlan))
            {
                query["GlobalResourcePlan"] = request.GlobalResourcePlan;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "AddCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You must activate Alibaba Cloud CDN before you can add a domain name to it. For more information, see [Activate Alibaba Cloud CDN](~~27272~~).
          * *   The domain name that you want to add has a valid Internet Content Provider (ICP) number.
          * *   You can add only one domain name to Alibaba Cloud CDN in each call. Each Alibaba Cloud account can add a maximum of 50 domain names to Alibaba Cloud CDN.
          * *   If the content of the origin server is not stored on Alibaba Cloud, the content must be reviewed. The review will be completed by the end of the next business day after you submit the application.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request AddCdnDomainRequest
          * @return AddCdnDomainResponse
         */
        public AddCdnDomainResponse AddCdnDomain(AddCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCdnDomainWithOptions(request, runtime);
        }

        /**
          * *   You must activate Alibaba Cloud CDN before you can add a domain name to it. For more information, see [Activate Alibaba Cloud CDN](~~27272~~).
          * *   The domain name that you want to add has a valid Internet Content Provider (ICP) number.
          * *   You can add only one domain name to Alibaba Cloud CDN in each call. Each Alibaba Cloud account can add a maximum of 50 domain names to Alibaba Cloud CDN.
          * *   If the content of the origin server is not stored on Alibaba Cloud, the content must be reviewed. The review will be completed by the end of the next business day after you submit the application.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request AddCdnDomainRequest
          * @return AddCdnDomainResponse
         */
        public async Task<AddCdnDomainResponse> AddCdnDomainAsync(AddCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCdnDomainWithOptionsAsync(request, runtime);
        }

        public AddFCTriggerResponse AddFCTriggerWithOptions(AddFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerARN))
            {
                query["TriggerARN"] = request.TriggerARN;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventMetaName))
            {
                body["EventMetaName"] = request.EventMetaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventMetaVersion))
            {
                body["EventMetaVersion"] = request.EventMetaVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionARN))
            {
                body["FunctionARN"] = request.FunctionARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                body["Notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleARN))
            {
                body["RoleARN"] = request.RoleARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceARN))
            {
                body["SourceARN"] = request.SourceARN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFCTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFCTriggerResponse> AddFCTriggerWithOptionsAsync(AddFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerARN))
            {
                query["TriggerARN"] = request.TriggerARN;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventMetaName))
            {
                body["EventMetaName"] = request.EventMetaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventMetaVersion))
            {
                body["EventMetaVersion"] = request.EventMetaVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionARN))
            {
                body["FunctionARN"] = request.FunctionARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                body["Notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleARN))
            {
                body["RoleARN"] = request.RoleARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceARN))
            {
                body["SourceARN"] = request.SourceARN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFCTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFCTriggerResponse AddFCTrigger(AddFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFCTriggerWithOptions(request, runtime);
        }

        public async Task<AddFCTriggerResponse> AddFCTriggerAsync(AddFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFCTriggerWithOptionsAsync(request, runtime);
        }

        /**
          * *   You must activate Alibaba Cloud CDN before you can add a domain name to it. For more information, see [Activate Alibaba Cloud CDN](~~27272~~).
          * *   If the acceleration region is Chinese Mainland Only or Global, you must apply for an ICP filing for the domain name.
          * *   You can specify multiple domain names and separate them with commas (,). You can specify at most 50 domain names in each call.
          * *   For more information, see [Add a domain name](~~122181~~).
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request BatchAddCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchAddCdnDomainResponse
         */
        public BatchAddCdnDomainResponse BatchAddCdnDomainWithOptions(BatchAddCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CdnType))
            {
                query["CdnType"] = request.CdnType;
            }
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
                Action = "BatchAddCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You must activate Alibaba Cloud CDN before you can add a domain name to it. For more information, see [Activate Alibaba Cloud CDN](~~27272~~).
          * *   If the acceleration region is Chinese Mainland Only or Global, you must apply for an ICP filing for the domain name.
          * *   You can specify multiple domain names and separate them with commas (,). You can specify at most 50 domain names in each call.
          * *   For more information, see [Add a domain name](~~122181~~).
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request BatchAddCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchAddCdnDomainResponse
         */
        public async Task<BatchAddCdnDomainResponse> BatchAddCdnDomainWithOptionsAsync(BatchAddCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CdnType))
            {
                query["CdnType"] = request.CdnType;
            }
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
                Action = "BatchAddCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You must activate Alibaba Cloud CDN before you can add a domain name to it. For more information, see [Activate Alibaba Cloud CDN](~~27272~~).
          * *   If the acceleration region is Chinese Mainland Only or Global, you must apply for an ICP filing for the domain name.
          * *   You can specify multiple domain names and separate them with commas (,). You can specify at most 50 domain names in each call.
          * *   For more information, see [Add a domain name](~~122181~~).
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request BatchAddCdnDomainRequest
          * @return BatchAddCdnDomainResponse
         */
        public BatchAddCdnDomainResponse BatchAddCdnDomain(BatchAddCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddCdnDomainWithOptions(request, runtime);
        }

        /**
          * *   You must activate Alibaba Cloud CDN before you can add a domain name to it. For more information, see [Activate Alibaba Cloud CDN](~~27272~~).
          * *   If the acceleration region is Chinese Mainland Only or Global, you must apply for an ICP filing for the domain name.
          * *   You can specify multiple domain names and separate them with commas (,). You can specify at most 50 domain names in each call.
          * *   For more information, see [Add a domain name](~~122181~~).
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request BatchAddCdnDomainRequest
          * @return BatchAddCdnDomainResponse
         */
        public async Task<BatchAddCdnDomainResponse> BatchAddCdnDomainAsync(BatchAddCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddCdnDomainWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can specify up to 50 domain names in each request.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request BatchDeleteCdnDomainConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchDeleteCdnDomainConfigResponse
         */
        public BatchDeleteCdnDomainConfigResponse BatchDeleteCdnDomainConfigWithOptions(BatchDeleteCdnDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchDeleteCdnDomainConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteCdnDomainConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can specify up to 50 domain names in each request.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request BatchDeleteCdnDomainConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchDeleteCdnDomainConfigResponse
         */
        public async Task<BatchDeleteCdnDomainConfigResponse> BatchDeleteCdnDomainConfigWithOptionsAsync(BatchDeleteCdnDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchDeleteCdnDomainConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteCdnDomainConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can specify up to 50 domain names in each request.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request BatchDeleteCdnDomainConfigRequest
          * @return BatchDeleteCdnDomainConfigResponse
         */
        public BatchDeleteCdnDomainConfigResponse BatchDeleteCdnDomainConfig(BatchDeleteCdnDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteCdnDomainConfigWithOptions(request, runtime);
        }

        /**
          * *   You can specify up to 50 domain names in each request.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request BatchDeleteCdnDomainConfigRequest
          * @return BatchDeleteCdnDomainConfigResponse
         */
        public async Task<BatchDeleteCdnDomainConfigResponse> BatchDeleteCdnDomainConfigAsync(BatchDeleteCdnDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteCdnDomainConfigWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify multiple domain names and must separate them with commas (,). You can specify up to 50 domain names in each call.
          * *   If the BatchSetCdnDomainConfig operation is successful, a unique configuration ID (ConfigId) is generated. You can use configuration IDs to update or delete configurations. For more information, see [Usage notes on ConfigId](~~388994~~).
          *
          * @param request BatchSetCdnDomainConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchSetCdnDomainConfigResponse
         */
        public BatchSetCdnDomainConfigResponse BatchSetCdnDomainConfigWithOptions(BatchSetCdnDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchSetCdnDomainConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetCdnDomainConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify multiple domain names and must separate them with commas (,). You can specify up to 50 domain names in each call.
          * *   If the BatchSetCdnDomainConfig operation is successful, a unique configuration ID (ConfigId) is generated. You can use configuration IDs to update or delete configurations. For more information, see [Usage notes on ConfigId](~~388994~~).
          *
          * @param request BatchSetCdnDomainConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchSetCdnDomainConfigResponse
         */
        public async Task<BatchSetCdnDomainConfigResponse> BatchSetCdnDomainConfigWithOptionsAsync(BatchSetCdnDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchSetCdnDomainConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetCdnDomainConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify multiple domain names and must separate them with commas (,). You can specify up to 50 domain names in each call.
          * *   If the BatchSetCdnDomainConfig operation is successful, a unique configuration ID (ConfigId) is generated. You can use configuration IDs to update or delete configurations. For more information, see [Usage notes on ConfigId](~~388994~~).
          *
          * @param request BatchSetCdnDomainConfigRequest
          * @return BatchSetCdnDomainConfigResponse
         */
        public BatchSetCdnDomainConfigResponse BatchSetCdnDomainConfig(BatchSetCdnDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetCdnDomainConfigWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify multiple domain names and must separate them with commas (,). You can specify up to 50 domain names in each call.
          * *   If the BatchSetCdnDomainConfig operation is successful, a unique configuration ID (ConfigId) is generated. You can use configuration IDs to update or delete configurations. For more information, see [Usage notes on ConfigId](~~388994~~).
          *
          * @param request BatchSetCdnDomainConfigRequest
          * @return BatchSetCdnDomainConfigResponse
         */
        public async Task<BatchSetCdnDomainConfigResponse> BatchSetCdnDomainConfigAsync(BatchSetCdnDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetCdnDomainConfigWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 10 times per second per account.
          * *   You can specify up to 10 domain names in each request. Separate multiple domain names with commas (,)
          *
          * @param request BatchSetCdnDomainServerCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchSetCdnDomainServerCertificateResponse
         */
        public BatchSetCdnDomainServerCertificateResponse BatchSetCdnDomainServerCertificateWithOptions(BatchSetCdnDomainServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchSetCdnDomainServerCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetCdnDomainServerCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 10 times per second per account.
          * *   You can specify up to 10 domain names in each request. Separate multiple domain names with commas (,)
          *
          * @param request BatchSetCdnDomainServerCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchSetCdnDomainServerCertificateResponse
         */
        public async Task<BatchSetCdnDomainServerCertificateResponse> BatchSetCdnDomainServerCertificateWithOptionsAsync(BatchSetCdnDomainServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchSetCdnDomainServerCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetCdnDomainServerCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 10 times per second per account.
          * *   You can specify up to 10 domain names in each request. Separate multiple domain names with commas (,)
          *
          * @param request BatchSetCdnDomainServerCertificateRequest
          * @return BatchSetCdnDomainServerCertificateResponse
         */
        public BatchSetCdnDomainServerCertificateResponse BatchSetCdnDomainServerCertificate(BatchSetCdnDomainServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetCdnDomainServerCertificateWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 10 times per second per account.
          * *   You can specify up to 10 domain names in each request. Separate multiple domain names with commas (,)
          *
          * @param request BatchSetCdnDomainServerCertificateRequest
          * @return BatchSetCdnDomainServerCertificateResponse
         */
        public async Task<BatchSetCdnDomainServerCertificateResponse> BatchSetCdnDomainServerCertificateAsync(BatchSetCdnDomainServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetCdnDomainServerCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * *   If a domain name specified in the request is in an invalid state or your account has an overdue payment, the domain name cannot be enabled.
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request.
          *
          * @param request BatchStartCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchStartCdnDomainResponse
         */
        public BatchStartCdnDomainResponse BatchStartCdnDomainWithOptions(BatchStartCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchStartCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If a domain name specified in the request is in an invalid state or your account has an overdue payment, the domain name cannot be enabled.
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request.
          *
          * @param request BatchStartCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchStartCdnDomainResponse
         */
        public async Task<BatchStartCdnDomainResponse> BatchStartCdnDomainWithOptionsAsync(BatchStartCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchStartCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If a domain name specified in the request is in an invalid state or your account has an overdue payment, the domain name cannot be enabled.
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request.
          *
          * @param request BatchStartCdnDomainRequest
          * @return BatchStartCdnDomainResponse
         */
        public BatchStartCdnDomainResponse BatchStartCdnDomain(BatchStartCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStartCdnDomainWithOptions(request, runtime);
        }

        /**
          * *   If a domain name specified in the request is in an invalid state or your account has an overdue payment, the domain name cannot be enabled.
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request.
          *
          * @param request BatchStartCdnDomainRequest
          * @return BatchStartCdnDomainResponse
         */
        public async Task<BatchStartCdnDomainResponse> BatchStartCdnDomainAsync(BatchStartCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStartCdnDomainWithOptionsAsync(request, runtime);
        }

        /**
          * *   After an accelerated domain name is disabled, Alibaba Cloud CDN retains its information and reroutes all the requests that are destined for the accelerated domain name to the origin.
          * *   If you need to temporarily disable CDN acceleration for a domain name, we recommend that you call the StopDomain operation.
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request.
          *
          * @param request BatchStopCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchStopCdnDomainResponse
         */
        public BatchStopCdnDomainResponse BatchStopCdnDomainWithOptions(BatchStopCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchStopCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   After an accelerated domain name is disabled, Alibaba Cloud CDN retains its information and reroutes all the requests that are destined for the accelerated domain name to the origin.
          * *   If you need to temporarily disable CDN acceleration for a domain name, we recommend that you call the StopDomain operation.
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request.
          *
          * @param request BatchStopCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchStopCdnDomainResponse
         */
        public async Task<BatchStopCdnDomainResponse> BatchStopCdnDomainWithOptionsAsync(BatchStopCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchStopCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   After an accelerated domain name is disabled, Alibaba Cloud CDN retains its information and reroutes all the requests that are destined for the accelerated domain name to the origin.
          * *   If you need to temporarily disable CDN acceleration for a domain name, we recommend that you call the StopDomain operation.
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request.
          *
          * @param request BatchStopCdnDomainRequest
          * @return BatchStopCdnDomainResponse
         */
        public BatchStopCdnDomainResponse BatchStopCdnDomain(BatchStopCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStopCdnDomainWithOptions(request, runtime);
        }

        /**
          * *   After an accelerated domain name is disabled, Alibaba Cloud CDN retains its information and reroutes all the requests that are destined for the accelerated domain name to the origin.
          * *   If you need to temporarily disable CDN acceleration for a domain name, we recommend that you call the StopDomain operation.
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request.
          *
          * @param request BatchStopCdnDomainRequest
          * @return BatchStopCdnDomainResponse
         */
        public async Task<BatchStopCdnDomainResponse> BatchStopCdnDomainAsync(BatchStopCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStopCdnDomainWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request BatchUpdateCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchUpdateCdnDomainResponse
         */
        public BatchUpdateCdnDomainResponse BatchUpdateCdnDomainWithOptions(BatchUpdateCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchUpdateCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request BatchUpdateCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchUpdateCdnDomainResponse
         */
        public async Task<BatchUpdateCdnDomainResponse> BatchUpdateCdnDomainWithOptionsAsync(BatchUpdateCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchUpdateCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request BatchUpdateCdnDomainRequest
          * @return BatchUpdateCdnDomainResponse
         */
        public BatchUpdateCdnDomainResponse BatchUpdateCdnDomain(BatchUpdateCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateCdnDomainWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request BatchUpdateCdnDomainRequest
          * @return BatchUpdateCdnDomainResponse
         */
        public async Task<BatchUpdateCdnDomainResponse> BatchUpdateCdnDomainAsync(BatchUpdateCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateCdnDomainWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request CreateCdnCertificateSigningRequestRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCdnCertificateSigningRequestResponse
         */
        public CreateCdnCertificateSigningRequestResponse CreateCdnCertificateSigningRequestWithOptions(CreateCdnCertificateSigningRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateCdnCertificateSigningRequest",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCdnCertificateSigningRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request CreateCdnCertificateSigningRequestRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCdnCertificateSigningRequestResponse
         */
        public async Task<CreateCdnCertificateSigningRequestResponse> CreateCdnCertificateSigningRequestWithOptionsAsync(CreateCdnCertificateSigningRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateCdnCertificateSigningRequest",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCdnCertificateSigningRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request CreateCdnCertificateSigningRequestRequest
          * @return CreateCdnCertificateSigningRequestResponse
         */
        public CreateCdnCertificateSigningRequestResponse CreateCdnCertificateSigningRequest(CreateCdnCertificateSigningRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCdnCertificateSigningRequestWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request CreateCdnCertificateSigningRequestRequest
          * @return CreateCdnCertificateSigningRequestResponse
         */
        public async Task<CreateCdnCertificateSigningRequestResponse> CreateCdnCertificateSigningRequestAsync(CreateCdnCertificateSigningRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCdnCertificateSigningRequestWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request CreateCdnDeliverTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCdnDeliverTaskResponse
         */
        public CreateCdnDeliverTaskResponse CreateCdnDeliverTaskWithOptions(CreateCdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCdnDeliverTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCdnDeliverTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request CreateCdnDeliverTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCdnDeliverTaskResponse
         */
        public async Task<CreateCdnDeliverTaskResponse> CreateCdnDeliverTaskWithOptionsAsync(CreateCdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCdnDeliverTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCdnDeliverTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request CreateCdnDeliverTaskRequest
          * @return CreateCdnDeliverTaskResponse
         */
        public CreateCdnDeliverTaskResponse CreateCdnDeliverTask(CreateCdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCdnDeliverTaskWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request CreateCdnDeliverTaskRequest
          * @return CreateCdnDeliverTaskResponse
         */
        public async Task<CreateCdnDeliverTaskResponse> CreateCdnDeliverTaskAsync(CreateCdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCdnDeliverTaskWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation allows you to create a custom operations report for a specific domain name. You can view the statistics about the domain name in the report.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request CreateCdnSubTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCdnSubTaskResponse
         */
        public CreateCdnSubTaskResponse CreateCdnSubTaskWithOptions(CreateCdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCdnSubTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCdnSubTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation allows you to create a custom operations report for a specific domain name. You can view the statistics about the domain name in the report.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request CreateCdnSubTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCdnSubTaskResponse
         */
        public async Task<CreateCdnSubTaskResponse> CreateCdnSubTaskWithOptionsAsync(CreateCdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCdnSubTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCdnSubTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation allows you to create a custom operations report for a specific domain name. You can view the statistics about the domain name in the report.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request CreateCdnSubTaskRequest
          * @return CreateCdnSubTaskResponse
         */
        public CreateCdnSubTaskResponse CreateCdnSubTask(CreateCdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCdnSubTaskWithOptions(request, runtime);
        }

        /**
          * *   This operation allows you to create a custom operations report for a specific domain name. You can view the statistics about the domain name in the report.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request CreateCdnSubTaskRequest
          * @return CreateCdnSubTaskResponse
         */
        public async Task<CreateCdnSubTaskResponse> CreateCdnSubTaskAsync(CreateCdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCdnSubTaskWithOptionsAsync(request, runtime);
        }

        /**
          * >  You can call this API operation up to 100 times per second per account.
          *
          * @param request CreateRealTimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRealTimeLogDeliveryResponse
         */
        public CreateRealTimeLogDeliveryResponse CreateRealTimeLogDeliveryWithOptions(CreateRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRealTimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRealTimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  You can call this API operation up to 100 times per second per account.
          *
          * @param request CreateRealTimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRealTimeLogDeliveryResponse
         */
        public async Task<CreateRealTimeLogDeliveryResponse> CreateRealTimeLogDeliveryWithOptionsAsync(CreateRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRealTimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRealTimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  You can call this API operation up to 100 times per second per account.
          *
          * @param request CreateRealTimeLogDeliveryRequest
          * @return CreateRealTimeLogDeliveryResponse
         */
        public CreateRealTimeLogDeliveryResponse CreateRealTimeLogDelivery(CreateRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRealTimeLogDeliveryWithOptions(request, runtime);
        }

        /**
          * >  You can call this API operation up to 100 times per second per account.
          *
          * @param request CreateRealTimeLogDeliveryRequest
          * @return CreateRealTimeLogDeliveryResponse
         */
        public async Task<CreateRealTimeLogDeliveryResponse> CreateRealTimeLogDeliveryAsync(CreateRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRealTimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can create a task to query data in the last year. The maximum time range that can be queried is one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request CreateUsageDetailDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUsageDetailDataExportTaskResponse
         */
        public CreateUsageDetailDataExportTaskResponse CreateUsageDetailDataExportTaskWithOptions(CreateUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
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
                Action = "CreateUsageDetailDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUsageDetailDataExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can create a task to query data in the last year. The maximum time range that can be queried is one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request CreateUsageDetailDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUsageDetailDataExportTaskResponse
         */
        public async Task<CreateUsageDetailDataExportTaskResponse> CreateUsageDetailDataExportTaskWithOptionsAsync(CreateUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
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
                Action = "CreateUsageDetailDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUsageDetailDataExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can create a task to query data in the last year. The maximum time range that can be queried is one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request CreateUsageDetailDataExportTaskRequest
          * @return CreateUsageDetailDataExportTaskResponse
         */
        public CreateUsageDetailDataExportTaskResponse CreateUsageDetailDataExportTask(CreateUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUsageDetailDataExportTaskWithOptions(request, runtime);
        }

        /**
          * *   You can create a task to query data in the last year. The maximum time range that can be queried is one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request CreateUsageDetailDataExportTaskRequest
          * @return CreateUsageDetailDataExportTaskResponse
         */
        public async Task<CreateUsageDetailDataExportTaskResponse> CreateUsageDetailDataExportTaskAsync(CreateUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUsageDetailDataExportTaskWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can create a task to query data in the last year. The maximum time range that can be queried is one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request CreateUserUsageDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUserUsageDataExportTaskResponse
         */
        public CreateUserUsageDataExportTaskResponse CreateUserUsageDataExportTaskWithOptions(CreateUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserUsageDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserUsageDataExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can create a task to query data in the last year. The maximum time range that can be queried is one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request CreateUserUsageDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUserUsageDataExportTaskResponse
         */
        public async Task<CreateUserUsageDataExportTaskResponse> CreateUserUsageDataExportTaskWithOptionsAsync(CreateUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserUsageDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserUsageDataExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can create a task to query data in the last year. The maximum time range that can be queried is one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request CreateUserUsageDataExportTaskRequest
          * @return CreateUserUsageDataExportTaskResponse
         */
        public CreateUserUsageDataExportTaskResponse CreateUserUsageDataExportTask(CreateUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserUsageDataExportTaskWithOptions(request, runtime);
        }

        /**
          * *   You can create a task to query data in the last year. The maximum time range that can be queried is one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request CreateUserUsageDataExportTaskRequest
          * @return CreateUserUsageDataExportTaskResponse
         */
        public async Task<CreateUserUsageDataExportTaskResponse> CreateUserUsageDataExportTaskAsync(CreateUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserUsageDataExportTaskWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request DeleteCdnDeliverTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCdnDeliverTaskResponse
         */
        public DeleteCdnDeliverTaskResponse DeleteCdnDeliverTaskWithOptions(DeleteCdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["DeliverId"] = request.DeliverId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCdnDeliverTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCdnDeliverTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request DeleteCdnDeliverTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCdnDeliverTaskResponse
         */
        public async Task<DeleteCdnDeliverTaskResponse> DeleteCdnDeliverTaskWithOptionsAsync(DeleteCdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["DeliverId"] = request.DeliverId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCdnDeliverTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCdnDeliverTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request DeleteCdnDeliverTaskRequest
          * @return DeleteCdnDeliverTaskResponse
         */
        public DeleteCdnDeliverTaskResponse DeleteCdnDeliverTask(DeleteCdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCdnDeliverTaskWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request DeleteCdnDeliverTaskRequest
          * @return DeleteCdnDeliverTaskResponse
         */
        public async Task<DeleteCdnDeliverTaskResponse> DeleteCdnDeliverTaskAsync(DeleteCdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCdnDeliverTaskWithOptionsAsync(request, runtime);
        }

        /**
          * *   We recommend that you add an A record for the domain name in the system of your DNS service provider before you remove the domain name from Alibaba Cloud CDN. Otherwise, the domain name may become inaccessible. Proceed with caution.
          * *   After you successfully call the DeleteCdnDomain operation, all records of the removed domain name are deleted. If you need to only disable the domain name, we recommend that you call the StopCdnDomain operation.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DeleteCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCdnDomainResponse
         */
        public DeleteCdnDomainResponse DeleteCdnDomainWithOptions(DeleteCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   We recommend that you add an A record for the domain name in the system of your DNS service provider before you remove the domain name from Alibaba Cloud CDN. Otherwise, the domain name may become inaccessible. Proceed with caution.
          * *   After you successfully call the DeleteCdnDomain operation, all records of the removed domain name are deleted. If you need to only disable the domain name, we recommend that you call the StopCdnDomain operation.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DeleteCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCdnDomainResponse
         */
        public async Task<DeleteCdnDomainResponse> DeleteCdnDomainWithOptionsAsync(DeleteCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   We recommend that you add an A record for the domain name in the system of your DNS service provider before you remove the domain name from Alibaba Cloud CDN. Otherwise, the domain name may become inaccessible. Proceed with caution.
          * *   After you successfully call the DeleteCdnDomain operation, all records of the removed domain name are deleted. If you need to only disable the domain name, we recommend that you call the StopCdnDomain operation.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DeleteCdnDomainRequest
          * @return DeleteCdnDomainResponse
         */
        public DeleteCdnDomainResponse DeleteCdnDomain(DeleteCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCdnDomainWithOptions(request, runtime);
        }

        /**
          * *   We recommend that you add an A record for the domain name in the system of your DNS service provider before you remove the domain name from Alibaba Cloud CDN. Otherwise, the domain name may become inaccessible. Proceed with caution.
          * *   After you successfully call the DeleteCdnDomain operation, all records of the removed domain name are deleted. If you need to only disable the domain name, we recommend that you call the StopCdnDomain operation.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DeleteCdnDomainRequest
          * @return DeleteCdnDomainResponse
         */
        public async Task<DeleteCdnDomainResponse> DeleteCdnDomainAsync(DeleteCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCdnDomainWithOptionsAsync(request, runtime);
        }

        /**
          * >  You can call this API operation up to three times per second per account.
          *
          * @param request DeleteCdnSubTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCdnSubTaskResponse
         */
        public DeleteCdnSubTaskResponse DeleteCdnSubTaskWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCdnSubTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCdnSubTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  You can call this API operation up to three times per second per account.
          *
          * @param request DeleteCdnSubTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCdnSubTaskResponse
         */
        public async Task<DeleteCdnSubTaskResponse> DeleteCdnSubTaskWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCdnSubTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCdnSubTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  You can call this API operation up to three times per second per account.
          *
          * @return DeleteCdnSubTaskResponse
         */
        public DeleteCdnSubTaskResponse DeleteCdnSubTask()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCdnSubTaskWithOptions(runtime);
        }

        /**
          * >  You can call this API operation up to three times per second per account.
          *
          * @return DeleteCdnSubTaskResponse
         */
        public async Task<DeleteCdnSubTaskResponse> DeleteCdnSubTaskAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCdnSubTaskWithOptionsAsync(runtime);
        }

        public DeleteFCTriggerResponse DeleteFCTriggerWithOptions(DeleteFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerARN))
            {
                query["TriggerARN"] = request.TriggerARN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFCTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFCTriggerResponse> DeleteFCTriggerWithOptionsAsync(DeleteFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerARN))
            {
                query["TriggerARN"] = request.TriggerARN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFCTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFCTriggerResponse DeleteFCTrigger(DeleteFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFCTriggerWithOptions(request, runtime);
        }

        public async Task<DeleteFCTriggerResponse> DeleteFCTriggerAsync(DeleteFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFCTriggerWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteRealTimeLogLogstoreRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteRealTimeLogLogstoreResponse
         */
        public DeleteRealTimeLogLogstoreResponse DeleteRealTimeLogLogstoreWithOptions(DeleteRealTimeLogLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRealTimeLogLogstore",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRealTimeLogLogstoreResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteRealTimeLogLogstoreRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteRealTimeLogLogstoreResponse
         */
        public async Task<DeleteRealTimeLogLogstoreResponse> DeleteRealTimeLogLogstoreWithOptionsAsync(DeleteRealTimeLogLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRealTimeLogLogstore",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRealTimeLogLogstoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteRealTimeLogLogstoreRequest
          * @return DeleteRealTimeLogLogstoreResponse
         */
        public DeleteRealTimeLogLogstoreResponse DeleteRealTimeLogLogstore(DeleteRealTimeLogLogstoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRealTimeLogLogstoreWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteRealTimeLogLogstoreRequest
          * @return DeleteRealTimeLogLogstoreResponse
         */
        public async Task<DeleteRealTimeLogLogstoreResponse> DeleteRealTimeLogLogstoreAsync(DeleteRealTimeLogLogstoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRealTimeLogLogstoreWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteRealtimeLogDeliveryResponse
         */
        public DeleteRealtimeLogDeliveryResponse DeleteRealtimeLogDeliveryWithOptions(DeleteRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteRealtimeLogDeliveryResponse
         */
        public async Task<DeleteRealtimeLogDeliveryResponse> DeleteRealtimeLogDeliveryWithOptionsAsync(DeleteRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteRealtimeLogDeliveryRequest
          * @return DeleteRealtimeLogDeliveryResponse
         */
        public DeleteRealtimeLogDeliveryResponse DeleteRealtimeLogDelivery(DeleteRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRealtimeLogDeliveryWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteRealtimeLogDeliveryRequest
          * @return DeleteRealtimeLogDeliveryResponse
         */
        public async Task<DeleteRealtimeLogDeliveryResponse> DeleteRealtimeLogDeliveryAsync(DeleteRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DeleteSpecificConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSpecificConfigResponse
         */
        public DeleteSpecificConfigResponse DeleteSpecificConfigWithOptions(DeleteSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSpecificConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSpecificConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DeleteSpecificConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSpecificConfigResponse
         */
        public async Task<DeleteSpecificConfigResponse> DeleteSpecificConfigWithOptionsAsync(DeleteSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSpecificConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSpecificConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DeleteSpecificConfigRequest
          * @return DeleteSpecificConfigResponse
         */
        public DeleteSpecificConfigResponse DeleteSpecificConfig(DeleteSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSpecificConfigWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DeleteSpecificConfigRequest
          * @return DeleteSpecificConfigResponse
         */
        public async Task<DeleteSpecificConfigResponse> DeleteSpecificConfigAsync(DeleteSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSpecificConfigWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DeleteSpecificStagingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSpecificStagingConfigResponse
         */
        public DeleteSpecificStagingConfigResponse DeleteSpecificStagingConfigWithOptions(DeleteSpecificStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSpecificStagingConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSpecificStagingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DeleteSpecificStagingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSpecificStagingConfigResponse
         */
        public async Task<DeleteSpecificStagingConfigResponse> DeleteSpecificStagingConfigWithOptionsAsync(DeleteSpecificStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSpecificStagingConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSpecificStagingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DeleteSpecificStagingConfigRequest
          * @return DeleteSpecificStagingConfigResponse
         */
        public DeleteSpecificStagingConfigResponse DeleteSpecificStagingConfig(DeleteSpecificStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSpecificStagingConfigWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DeleteSpecificStagingConfigRequest
          * @return DeleteSpecificStagingConfigResponse
         */
        public async Task<DeleteSpecificStagingConfigResponse> DeleteSpecificStagingConfigAsync(DeleteSpecificStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSpecificStagingConfigWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteUsageDetailDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteUsageDetailDataExportTaskResponse
         */
        public DeleteUsageDetailDataExportTaskResponse DeleteUsageDetailDataExportTaskWithOptions(DeleteUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteUsageDetailDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUsageDetailDataExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteUsageDetailDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteUsageDetailDataExportTaskResponse
         */
        public async Task<DeleteUsageDetailDataExportTaskResponse> DeleteUsageDetailDataExportTaskWithOptionsAsync(DeleteUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteUsageDetailDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUsageDetailDataExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteUsageDetailDataExportTaskRequest
          * @return DeleteUsageDetailDataExportTaskResponse
         */
        public DeleteUsageDetailDataExportTaskResponse DeleteUsageDetailDataExportTask(DeleteUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUsageDetailDataExportTaskWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteUsageDetailDataExportTaskRequest
          * @return DeleteUsageDetailDataExportTaskResponse
         */
        public async Task<DeleteUsageDetailDataExportTaskResponse> DeleteUsageDetailDataExportTaskAsync(DeleteUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUsageDetailDataExportTaskWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteUserUsageDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteUserUsageDataExportTaskResponse
         */
        public DeleteUserUsageDataExportTaskResponse DeleteUserUsageDataExportTaskWithOptions(DeleteUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteUserUsageDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserUsageDataExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteUserUsageDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteUserUsageDataExportTaskResponse
         */
        public async Task<DeleteUserUsageDataExportTaskResponse> DeleteUserUsageDataExportTaskWithOptionsAsync(DeleteUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteUserUsageDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserUsageDataExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteUserUsageDataExportTaskRequest
          * @return DeleteUserUsageDataExportTaskResponse
         */
        public DeleteUserUsageDataExportTaskResponse DeleteUserUsageDataExportTask(DeleteUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserUsageDataExportTaskWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DeleteUserUsageDataExportTaskRequest
          * @return DeleteUserUsageDataExportTaskResponse
         */
        public async Task<DeleteUserUsageDataExportTaskResponse> DeleteUserUsageDataExportTaskAsync(DeleteUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserUsageDataExportTaskWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeBlockedRegionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeBlockedRegionsResponse
         */
        public DescribeBlockedRegionsResponse DescribeBlockedRegionsWithOptions(DescribeBlockedRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBlockedRegions",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBlockedRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeBlockedRegionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeBlockedRegionsResponse
         */
        public async Task<DescribeBlockedRegionsResponse> DescribeBlockedRegionsWithOptionsAsync(DescribeBlockedRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBlockedRegions",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBlockedRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeBlockedRegionsRequest
          * @return DescribeBlockedRegionsResponse
         */
        public DescribeBlockedRegionsResponse DescribeBlockedRegions(DescribeBlockedRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBlockedRegionsWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeBlockedRegionsRequest
          * @return DescribeBlockedRegionsResponse
         */
        public async Task<DescribeBlockedRegionsResponse> DescribeBlockedRegionsAsync(DescribeBlockedRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBlockedRegionsWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeCdnCertificateDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnCertificateDetailResponse
         */
        public DescribeCdnCertificateDetailResponse DescribeCdnCertificateDetailWithOptions(DescribeCdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnCertificateDetail",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnCertificateDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeCdnCertificateDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnCertificateDetailResponse
         */
        public async Task<DescribeCdnCertificateDetailResponse> DescribeCdnCertificateDetailWithOptionsAsync(DescribeCdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnCertificateDetail",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnCertificateDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeCdnCertificateDetailRequest
          * @return DescribeCdnCertificateDetailResponse
         */
        public DescribeCdnCertificateDetailResponse DescribeCdnCertificateDetail(DescribeCdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnCertificateDetailWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeCdnCertificateDetailRequest
          * @return DescribeCdnCertificateDetailResponse
         */
        public async Task<DescribeCdnCertificateDetailResponse> DescribeCdnCertificateDetailAsync(DescribeCdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnCertificateDetailWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnCertificateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnCertificateListResponse
         */
        public DescribeCdnCertificateListResponse DescribeCdnCertificateListWithOptions(DescribeCdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnCertificateList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnCertificateListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnCertificateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnCertificateListResponse
         */
        public async Task<DescribeCdnCertificateListResponse> DescribeCdnCertificateListWithOptionsAsync(DescribeCdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnCertificateList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnCertificateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnCertificateListRequest
          * @return DescribeCdnCertificateListResponse
         */
        public DescribeCdnCertificateListResponse DescribeCdnCertificateList(DescribeCdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnCertificateListWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnCertificateListRequest
          * @return DescribeCdnCertificateListResponse
         */
        public async Task<DescribeCdnCertificateListResponse> DescribeCdnCertificateListAsync(DescribeCdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeCdnConditionIPBInfoResponse DescribeCdnConditionIPBInfoWithOptions(DescribeCdnConditionIPBInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnConditionIPBInfo",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnConditionIPBInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCdnConditionIPBInfoResponse> DescribeCdnConditionIPBInfoWithOptionsAsync(DescribeCdnConditionIPBInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnConditionIPBInfo",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnConditionIPBInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCdnConditionIPBInfoResponse DescribeCdnConditionIPBInfo(DescribeCdnConditionIPBInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnConditionIPBInfoWithOptions(request, runtime);
        }

        public async Task<DescribeCdnConditionIPBInfoResponse> DescribeCdnConditionIPBInfoAsync(DescribeCdnConditionIPBInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnConditionIPBInfoWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeCdnDeletedDomainsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDeletedDomainsResponse
         */
        public DescribeCdnDeletedDomainsResponse DescribeCdnDeletedDomainsWithOptions(DescribeCdnDeletedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnDeletedDomains",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDeletedDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeCdnDeletedDomainsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDeletedDomainsResponse
         */
        public async Task<DescribeCdnDeletedDomainsResponse> DescribeCdnDeletedDomainsWithOptionsAsync(DescribeCdnDeletedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnDeletedDomains",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDeletedDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeCdnDeletedDomainsRequest
          * @return DescribeCdnDeletedDomainsResponse
         */
        public DescribeCdnDeletedDomainsResponse DescribeCdnDeletedDomains(DescribeCdnDeletedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDeletedDomainsWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeCdnDeletedDomainsRequest
          * @return DescribeCdnDeletedDomainsResponse
         */
        public async Task<DescribeCdnDeletedDomainsResponse> DescribeCdnDeletedDomainsAsync(DescribeCdnDeletedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDeletedDomainsWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 3 times per second per account.
          *
          * @param request DescribeCdnDeliverListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDeliverListResponse
         */
        public DescribeCdnDeliverListResponse DescribeCdnDeliverListWithOptions(DescribeCdnDeliverListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["DeliverId"] = request.DeliverId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnDeliverList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDeliverListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 3 times per second per account.
          *
          * @param request DescribeCdnDeliverListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDeliverListResponse
         */
        public async Task<DescribeCdnDeliverListResponse> DescribeCdnDeliverListWithOptionsAsync(DescribeCdnDeliverListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["DeliverId"] = request.DeliverId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnDeliverList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDeliverListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 3 times per second per account.
          *
          * @param request DescribeCdnDeliverListRequest
          * @return DescribeCdnDeliverListResponse
         */
        public DescribeCdnDeliverListResponse DescribeCdnDeliverList(DescribeCdnDeliverListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDeliverListWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 3 times per second per account.
          *
          * @param request DescribeCdnDeliverListRequest
          * @return DescribeCdnDeliverListResponse
         */
        public async Task<DescribeCdnDeliverListResponse> DescribeCdnDeliverListAsync(DescribeCdnDeliverListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDeliverListWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnDomainByCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainByCertificateResponse
         */
        public DescribeCdnDomainByCertificateResponse DescribeCdnDomainByCertificateWithOptions(DescribeCdnDomainByCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLStatus))
            {
                query["SSLStatus"] = request.SSLStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnDomainByCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainByCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnDomainByCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainByCertificateResponse
         */
        public async Task<DescribeCdnDomainByCertificateResponse> DescribeCdnDomainByCertificateWithOptionsAsync(DescribeCdnDomainByCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLStatus))
            {
                query["SSLStatus"] = request.SSLStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnDomainByCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainByCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnDomainByCertificateRequest
          * @return DescribeCdnDomainByCertificateResponse
         */
        public DescribeCdnDomainByCertificateResponse DescribeCdnDomainByCertificate(DescribeCdnDomainByCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainByCertificateWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnDomainByCertificateRequest
          * @return DescribeCdnDomainByCertificateResponse
         */
        public async Task<DescribeCdnDomainByCertificateResponse> DescribeCdnDomainByCertificateAsync(DescribeCdnDomainByCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainByCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnDomainConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainConfigsResponse
         */
        public DescribeCdnDomainConfigsResponse DescribeCdnDomainConfigsWithOptions(DescribeCdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnDomainConfigs",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnDomainConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainConfigsResponse
         */
        public async Task<DescribeCdnDomainConfigsResponse> DescribeCdnDomainConfigsWithOptionsAsync(DescribeCdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnDomainConfigs",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnDomainConfigsRequest
          * @return DescribeCdnDomainConfigsResponse
         */
        public DescribeCdnDomainConfigsResponse DescribeCdnDomainConfigs(DescribeCdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainConfigsWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnDomainConfigsRequest
          * @return DescribeCdnDomainConfigsResponse
         */
        public async Task<DescribeCdnDomainConfigsResponse> DescribeCdnDomainConfigsAsync(DescribeCdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnDomainDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainDetailResponse
         */
        public DescribeCdnDomainDetailResponse DescribeCdnDomainDetailWithOptions(DescribeCdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnDomainDetail",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnDomainDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainDetailResponse
         */
        public async Task<DescribeCdnDomainDetailResponse> DescribeCdnDomainDetailWithOptionsAsync(DescribeCdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnDomainDetail",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnDomainDetailRequest
          * @return DescribeCdnDomainDetailResponse
         */
        public DescribeCdnDomainDetailResponse DescribeCdnDomainDetail(DescribeCdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainDetailWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnDomainDetailRequest
          * @return DescribeCdnDomainDetailResponse
         */
        public async Task<DescribeCdnDomainDetailResponse> DescribeCdnDomainDetailAsync(DescribeCdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainDetailWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you do not set **StartTime** or **EndTime**, the request returns the data collected in the last 24 hours. If you set both **StartTime** and **EndTime**, the request returns the data collected within the specified time range.
          * *   The log data is collected every hour.
          * *   You can call this operation up to 100 times per second per account.
          * *   You can query only logs in the last month. The start time and the current time cannot exceed 31 days.
          *
          * @param request DescribeCdnDomainLogsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainLogsResponse
         */
        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogsWithOptions(DescribeCdnDomainLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnDomainLogs",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you do not set **StartTime** or **EndTime**, the request returns the data collected in the last 24 hours. If you set both **StartTime** and **EndTime**, the request returns the data collected within the specified time range.
          * *   The log data is collected every hour.
          * *   You can call this operation up to 100 times per second per account.
          * *   You can query only logs in the last month. The start time and the current time cannot exceed 31 days.
          *
          * @param request DescribeCdnDomainLogsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainLogsResponse
         */
        public async Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogsWithOptionsAsync(DescribeCdnDomainLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnDomainLogs",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you do not set **StartTime** or **EndTime**, the request returns the data collected in the last 24 hours. If you set both **StartTime** and **EndTime**, the request returns the data collected within the specified time range.
          * *   The log data is collected every hour.
          * *   You can call this operation up to 100 times per second per account.
          * *   You can query only logs in the last month. The start time and the current time cannot exceed 31 days.
          *
          * @param request DescribeCdnDomainLogsRequest
          * @return DescribeCdnDomainLogsResponse
         */
        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogs(DescribeCdnDomainLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainLogsWithOptions(request, runtime);
        }

        /**
          * *   If you do not set **StartTime** or **EndTime**, the request returns the data collected in the last 24 hours. If you set both **StartTime** and **EndTime**, the request returns the data collected within the specified time range.
          * *   The log data is collected every hour.
          * *   You can call this operation up to 100 times per second per account.
          * *   You can query only logs in the last month. The start time and the current time cannot exceed 31 days.
          *
          * @param request DescribeCdnDomainLogsRequest
          * @return DescribeCdnDomainLogsResponse
         */
        public async Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogsAsync(DescribeCdnDomainLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainLogsWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnDomainStagingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainStagingConfigResponse
         */
        public DescribeCdnDomainStagingConfigResponse DescribeCdnDomainStagingConfigWithOptions(DescribeCdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnDomainStagingConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainStagingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnDomainStagingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnDomainStagingConfigResponse
         */
        public async Task<DescribeCdnDomainStagingConfigResponse> DescribeCdnDomainStagingConfigWithOptionsAsync(DescribeCdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnDomainStagingConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnDomainStagingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnDomainStagingConfigRequest
          * @return DescribeCdnDomainStagingConfigResponse
         */
        public DescribeCdnDomainStagingConfigResponse DescribeCdnDomainStagingConfig(DescribeCdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainStagingConfigWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnDomainStagingConfigRequest
          * @return DescribeCdnDomainStagingConfigResponse
         */
        public async Task<DescribeCdnDomainStagingConfigResponse> DescribeCdnDomainStagingConfigAsync(DescribeCdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainStagingConfigWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnHttpsDomainListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnHttpsDomainListResponse
         */
        public DescribeCdnHttpsDomainListResponse DescribeCdnHttpsDomainListWithOptions(DescribeCdnHttpsDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
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
                Action = "DescribeCdnHttpsDomainList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnHttpsDomainListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnHttpsDomainListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnHttpsDomainListResponse
         */
        public async Task<DescribeCdnHttpsDomainListResponse> DescribeCdnHttpsDomainListWithOptionsAsync(DescribeCdnHttpsDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
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
                Action = "DescribeCdnHttpsDomainList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnHttpsDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnHttpsDomainListRequest
          * @return DescribeCdnHttpsDomainListResponse
         */
        public DescribeCdnHttpsDomainListResponse DescribeCdnHttpsDomainList(DescribeCdnHttpsDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnHttpsDomainListWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnHttpsDomainListRequest
          * @return DescribeCdnHttpsDomainListResponse
         */
        public async Task<DescribeCdnHttpsDomainListResponse> DescribeCdnHttpsDomainListAsync(DescribeCdnHttpsDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnHttpsDomainListWithOptionsAsync(request, runtime);
        }

        public DescribeCdnOrderCommodityCodeResponse DescribeCdnOrderCommodityCodeWithOptions(DescribeCdnOrderCommodityCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
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
                Action = "DescribeCdnOrderCommodityCode",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnOrderCommodityCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCdnOrderCommodityCodeResponse> DescribeCdnOrderCommodityCodeWithOptionsAsync(DescribeCdnOrderCommodityCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
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
                Action = "DescribeCdnOrderCommodityCode",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnOrderCommodityCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCdnOrderCommodityCodeResponse DescribeCdnOrderCommodityCode(DescribeCdnOrderCommodityCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnOrderCommodityCodeWithOptions(request, runtime);
        }

        public async Task<DescribeCdnOrderCommodityCodeResponse> DescribeCdnOrderCommodityCodeAsync(DescribeCdnOrderCommodityCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnOrderCommodityCodeWithOptionsAsync(request, runtime);
        }

        /**
          * *   The lists of ISPs and regions that are supported by Alibaba Cloud CDN are updated and published on the Alibaba Cloud International site.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnRegionAndIspRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnRegionAndIspResponse
         */
        public DescribeCdnRegionAndIspResponse DescribeCdnRegionAndIspWithOptions(DescribeCdnRegionAndIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnRegionAndIsp",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnRegionAndIspResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   The lists of ISPs and regions that are supported by Alibaba Cloud CDN are updated and published on the Alibaba Cloud International site.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnRegionAndIspRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnRegionAndIspResponse
         */
        public async Task<DescribeCdnRegionAndIspResponse> DescribeCdnRegionAndIspWithOptionsAsync(DescribeCdnRegionAndIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnRegionAndIsp",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnRegionAndIspResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   The lists of ISPs and regions that are supported by Alibaba Cloud CDN are updated and published on the Alibaba Cloud International site.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnRegionAndIspRequest
          * @return DescribeCdnRegionAndIspResponse
         */
        public DescribeCdnRegionAndIspResponse DescribeCdnRegionAndIsp(DescribeCdnRegionAndIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnRegionAndIspWithOptions(request, runtime);
        }

        /**
          * *   The lists of ISPs and regions that are supported by Alibaba Cloud CDN are updated and published on the Alibaba Cloud International site.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnRegionAndIspRequest
          * @return DescribeCdnRegionAndIspResponse
         */
        public async Task<DescribeCdnRegionAndIspResponse> DescribeCdnRegionAndIspAsync(DescribeCdnRegionAndIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnRegionAndIspWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnReportResponse
         */
        public DescribeCdnReportResponse DescribeCdnReportWithOptions(DescribeCdnReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnReport",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnReportResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnReportResponse
         */
        public async Task<DescribeCdnReportResponse> DescribeCdnReportWithOptionsAsync(DescribeCdnReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnReport",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnReportRequest
          * @return DescribeCdnReportResponse
         */
        public DescribeCdnReportResponse DescribeCdnReport(DescribeCdnReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnReportWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnReportRequest
          * @return DescribeCdnReportResponse
         */
        public async Task<DescribeCdnReportResponse> DescribeCdnReportAsync(DescribeCdnReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnReportWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation queries the metadata of all operations reports. The statistics in the reports are not returned.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnReportListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnReportListResponse
         */
        public DescribeCdnReportListResponse DescribeCdnReportListWithOptions(DescribeCdnReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeCdnReportList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnReportListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation queries the metadata of all operations reports. The statistics in the reports are not returned.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnReportListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnReportListResponse
         */
        public async Task<DescribeCdnReportListResponse> DescribeCdnReportListWithOptionsAsync(DescribeCdnReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeCdnReportList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnReportListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation queries the metadata of all operations reports. The statistics in the reports are not returned.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnReportListRequest
          * @return DescribeCdnReportListResponse
         */
        public DescribeCdnReportListResponse DescribeCdnReportList(DescribeCdnReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnReportListWithOptions(request, runtime);
        }

        /**
          * *   This operation queries the metadata of all operations reports. The statistics in the reports are not returned.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnReportListRequest
          * @return DescribeCdnReportListResponse
         */
        public async Task<DescribeCdnReportListResponse> DescribeCdnReportListAsync(DescribeCdnReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnReportListWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeCdnSMCertificateDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnSMCertificateDetailResponse
         */
        public DescribeCdnSMCertificateDetailResponse DescribeCdnSMCertificateDetailWithOptions(DescribeCdnSMCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnSMCertificateDetail",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnSMCertificateDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeCdnSMCertificateDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnSMCertificateDetailResponse
         */
        public async Task<DescribeCdnSMCertificateDetailResponse> DescribeCdnSMCertificateDetailWithOptionsAsync(DescribeCdnSMCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnSMCertificateDetail",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnSMCertificateDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeCdnSMCertificateDetailRequest
          * @return DescribeCdnSMCertificateDetailResponse
         */
        public DescribeCdnSMCertificateDetailResponse DescribeCdnSMCertificateDetail(DescribeCdnSMCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnSMCertificateDetailWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeCdnSMCertificateDetailRequest
          * @return DescribeCdnSMCertificateDetailResponse
         */
        public async Task<DescribeCdnSMCertificateDetailResponse> DescribeCdnSMCertificateDetailAsync(DescribeCdnSMCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnSMCertificateDetailWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnSMCertificateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnSMCertificateListResponse
         */
        public DescribeCdnSMCertificateListResponse DescribeCdnSMCertificateListWithOptions(DescribeCdnSMCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnSMCertificateList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnSMCertificateListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnSMCertificateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnSMCertificateListResponse
         */
        public async Task<DescribeCdnSMCertificateListResponse> DescribeCdnSMCertificateListWithOptionsAsync(DescribeCdnSMCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnSMCertificateList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnSMCertificateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnSMCertificateListRequest
          * @return DescribeCdnSMCertificateListResponse
         */
        public DescribeCdnSMCertificateListResponse DescribeCdnSMCertificateList(DescribeCdnSMCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnSMCertificateListWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnSMCertificateListRequest
          * @return DescribeCdnSMCertificateListResponse
         */
        public async Task<DescribeCdnSMCertificateListResponse> DescribeCdnSMCertificateListAsync(DescribeCdnSMCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnSMCertificateListWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnServiceResponse
         */
        public DescribeCdnServiceResponse DescribeCdnServiceWithOptions(DescribeCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnService",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnServiceResponse
         */
        public async Task<DescribeCdnServiceResponse> DescribeCdnServiceWithOptionsAsync(DescribeCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnService",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnServiceRequest
          * @return DescribeCdnServiceResponse
         */
        public DescribeCdnServiceResponse DescribeCdnService(DescribeCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnServiceWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnServiceRequest
          * @return DescribeCdnServiceResponse
         */
        public async Task<DescribeCdnServiceResponse> DescribeCdnServiceAsync(DescribeCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnServiceWithOptionsAsync(request, runtime);
        }

        /**
          * *   By default, this operation queries all custom operations reports. However, only one operations report can be displayed. Therefore, only one operations report is returned.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnSubListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnSubListResponse
         */
        public DescribeCdnSubListResponse DescribeCdnSubListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnSubList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnSubListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   By default, this operation queries all custom operations reports. However, only one operations report can be displayed. Therefore, only one operations report is returned.
          * *   You can call this operation up to three times per second per account.
          *
          * @param request DescribeCdnSubListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnSubListResponse
         */
        public async Task<DescribeCdnSubListResponse> DescribeCdnSubListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnSubList",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnSubListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   By default, this operation queries all custom operations reports. However, only one operations report can be displayed. Therefore, only one operations report is returned.
          * *   You can call this operation up to three times per second per account.
          *
          * @return DescribeCdnSubListResponse
         */
        public DescribeCdnSubListResponse DescribeCdnSubList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnSubListWithOptions(runtime);
        }

        /**
          * *   By default, this operation queries all custom operations reports. However, only one operations report can be displayed. Therefore, only one operations report is returned.
          * *   You can call this operation up to three times per second per account.
          *
          * @return DescribeCdnSubListResponse
         */
        public async Task<DescribeCdnSubListResponse> DescribeCdnSubListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnSubListWithOptionsAsync(runtime);
        }

        /**
          * *   You can query billing history up to the last one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnUserBillHistoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserBillHistoryResponse
         */
        public DescribeCdnUserBillHistoryResponse DescribeCdnUserBillHistoryWithOptions(DescribeCdnUserBillHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeCdnUserBillHistory",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserBillHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can query billing history up to the last one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnUserBillHistoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserBillHistoryResponse
         */
        public async Task<DescribeCdnUserBillHistoryResponse> DescribeCdnUserBillHistoryWithOptionsAsync(DescribeCdnUserBillHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeCdnUserBillHistory",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserBillHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can query billing history up to the last one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnUserBillHistoryRequest
          * @return DescribeCdnUserBillHistoryResponse
         */
        public DescribeCdnUserBillHistoryResponse DescribeCdnUserBillHistory(DescribeCdnUserBillHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserBillHistoryWithOptions(request, runtime);
        }

        /**
          * *   You can query billing history up to the last one month.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnUserBillHistoryRequest
          * @return DescribeCdnUserBillHistoryResponse
         */
        public async Task<DescribeCdnUserBillHistoryResponse> DescribeCdnUserBillHistoryAsync(DescribeCdnUserBillHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserBillHistoryWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to estimate resource usage of the current month based on the metering method that is specified on the first day of the current month. You can call this operation to estimate resource usage only of the current month within your Alibaba Cloud account. The time range used for the estimation starts at 00:00 on the first day of the current month and ends 2 hours earlier than the current time.
          * *   Pay by monthly 95th percentile: The top 5% values between the start time and end time are excluded. The estimated value is the highest value among the remaining values.
          * *   Pay by average daily peak bandwidth per month: Estimated value = Sum of daily peak bandwidth values/Number of days. The current day is excluded.
          * *   Pay by 4th peak bandwidth per month: The estimated value is the 4th peak bandwidth value between the start time and end time. If the time range is less than four days, the estimated value is 0.
          * *   Pay by average daily 95th percentile bandwidth per month: Estimated value = Sum of daily 95th percentile bandwidth values/Number of days. The current day is excluded.
          * *   Pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00: The top 5% values between the start time and end time are excluded. The estimated value is the highest value among the remaining values.
          * > You can call this operation only once per second per account.
          *
          * @param request DescribeCdnUserBillPredictionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserBillPredictionResponse
         */
        public DescribeCdnUserBillPredictionResponse DescribeCdnUserBillPredictionWithOptions(DescribeCdnUserBillPredictionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeCdnUserBillPrediction",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserBillPredictionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to estimate resource usage of the current month based on the metering method that is specified on the first day of the current month. You can call this operation to estimate resource usage only of the current month within your Alibaba Cloud account. The time range used for the estimation starts at 00:00 on the first day of the current month and ends 2 hours earlier than the current time.
          * *   Pay by monthly 95th percentile: The top 5% values between the start time and end time are excluded. The estimated value is the highest value among the remaining values.
          * *   Pay by average daily peak bandwidth per month: Estimated value = Sum of daily peak bandwidth values/Number of days. The current day is excluded.
          * *   Pay by 4th peak bandwidth per month: The estimated value is the 4th peak bandwidth value between the start time and end time. If the time range is less than four days, the estimated value is 0.
          * *   Pay by average daily 95th percentile bandwidth per month: Estimated value = Sum of daily 95th percentile bandwidth values/Number of days. The current day is excluded.
          * *   Pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00: The top 5% values between the start time and end time are excluded. The estimated value is the highest value among the remaining values.
          * > You can call this operation only once per second per account.
          *
          * @param request DescribeCdnUserBillPredictionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserBillPredictionResponse
         */
        public async Task<DescribeCdnUserBillPredictionResponse> DescribeCdnUserBillPredictionWithOptionsAsync(DescribeCdnUserBillPredictionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeCdnUserBillPrediction",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserBillPredictionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to estimate resource usage of the current month based on the metering method that is specified on the first day of the current month. You can call this operation to estimate resource usage only of the current month within your Alibaba Cloud account. The time range used for the estimation starts at 00:00 on the first day of the current month and ends 2 hours earlier than the current time.
          * *   Pay by monthly 95th percentile: The top 5% values between the start time and end time are excluded. The estimated value is the highest value among the remaining values.
          * *   Pay by average daily peak bandwidth per month: Estimated value = Sum of daily peak bandwidth values/Number of days. The current day is excluded.
          * *   Pay by 4th peak bandwidth per month: The estimated value is the 4th peak bandwidth value between the start time and end time. If the time range is less than four days, the estimated value is 0.
          * *   Pay by average daily 95th percentile bandwidth per month: Estimated value = Sum of daily 95th percentile bandwidth values/Number of days. The current day is excluded.
          * *   Pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00: The top 5% values between the start time and end time are excluded. The estimated value is the highest value among the remaining values.
          * > You can call this operation only once per second per account.
          *
          * @param request DescribeCdnUserBillPredictionRequest
          * @return DescribeCdnUserBillPredictionResponse
         */
        public DescribeCdnUserBillPredictionResponse DescribeCdnUserBillPrediction(DescribeCdnUserBillPredictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserBillPredictionWithOptions(request, runtime);
        }

        /**
          * You can call this operation to estimate resource usage of the current month based on the metering method that is specified on the first day of the current month. You can call this operation to estimate resource usage only of the current month within your Alibaba Cloud account. The time range used for the estimation starts at 00:00 on the first day of the current month and ends 2 hours earlier than the current time.
          * *   Pay by monthly 95th percentile: The top 5% values between the start time and end time are excluded. The estimated value is the highest value among the remaining values.
          * *   Pay by average daily peak bandwidth per month: Estimated value = Sum of daily peak bandwidth values/Number of days. The current day is excluded.
          * *   Pay by 4th peak bandwidth per month: The estimated value is the 4th peak bandwidth value between the start time and end time. If the time range is less than four days, the estimated value is 0.
          * *   Pay by average daily 95th percentile bandwidth per month: Estimated value = Sum of daily 95th percentile bandwidth values/Number of days. The current day is excluded.
          * *   Pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00: The top 5% values between the start time and end time are excluded. The estimated value is the highest value among the remaining values.
          * > You can call this operation only once per second per account.
          *
          * @param request DescribeCdnUserBillPredictionRequest
          * @return DescribeCdnUserBillPredictionResponse
         */
        public async Task<DescribeCdnUserBillPredictionResponse> DescribeCdnUserBillPredictionAsync(DescribeCdnUserBillPredictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserBillPredictionWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnUserBillTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserBillTypeResponse
         */
        public DescribeCdnUserBillTypeResponse DescribeCdnUserBillTypeWithOptions(DescribeCdnUserBillTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeCdnUserBillType",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserBillTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnUserBillTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserBillTypeResponse
         */
        public async Task<DescribeCdnUserBillTypeResponse> DescribeCdnUserBillTypeWithOptionsAsync(DescribeCdnUserBillTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeCdnUserBillType",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserBillTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnUserBillTypeRequest
          * @return DescribeCdnUserBillTypeResponse
         */
        public DescribeCdnUserBillTypeResponse DescribeCdnUserBillType(DescribeCdnUserBillTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserBillTypeWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCdnUserBillTypeRequest
          * @return DescribeCdnUserBillTypeResponse
         */
        public async Task<DescribeCdnUserBillTypeResponse> DescribeCdnUserBillTypeAsync(DescribeCdnUserBillTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserBillTypeWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserConfigsResponse
         */
        public DescribeCdnUserConfigsResponse DescribeCdnUserConfigsWithOptions(DescribeCdnUserConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnUserConfigs",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserConfigsResponse
         */
        public async Task<DescribeCdnUserConfigsResponse> DescribeCdnUserConfigsWithOptionsAsync(DescribeCdnUserConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCdnUserConfigs",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserConfigsRequest
          * @return DescribeCdnUserConfigsResponse
         */
        public DescribeCdnUserConfigsResponse DescribeCdnUserConfigs(DescribeCdnUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserConfigsWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserConfigsRequest
          * @return DescribeCdnUserConfigsResponse
         */
        public async Task<DescribeCdnUserConfigsResponse> DescribeCdnUserConfigsAsync(DescribeCdnUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserConfigsWithOptionsAsync(request, runtime);
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request DescribeCdnUserDomainsByFuncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserDomainsByFuncResponse
         */
        public DescribeCdnUserDomainsByFuncResponse DescribeCdnUserDomainsByFuncWithOptions(DescribeCdnUserDomainsByFuncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncId))
            {
                query["FuncId"] = request.FuncId;
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
                Action = "DescribeCdnUserDomainsByFunc",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserDomainsByFuncResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request DescribeCdnUserDomainsByFuncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserDomainsByFuncResponse
         */
        public async Task<DescribeCdnUserDomainsByFuncResponse> DescribeCdnUserDomainsByFuncWithOptionsAsync(DescribeCdnUserDomainsByFuncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuncId))
            {
                query["FuncId"] = request.FuncId;
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
                Action = "DescribeCdnUserDomainsByFunc",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserDomainsByFuncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request DescribeCdnUserDomainsByFuncRequest
          * @return DescribeCdnUserDomainsByFuncResponse
         */
        public DescribeCdnUserDomainsByFuncResponse DescribeCdnUserDomainsByFunc(DescribeCdnUserDomainsByFuncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserDomainsByFuncWithOptions(request, runtime);
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request DescribeCdnUserDomainsByFuncRequest
          * @return DescribeCdnUserDomainsByFuncResponse
         */
        public async Task<DescribeCdnUserDomainsByFuncResponse> DescribeCdnUserDomainsByFuncAsync(DescribeCdnUserDomainsByFuncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserDomainsByFuncWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserQuotaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserQuotaResponse
         */
        public DescribeCdnUserQuotaResponse DescribeCdnUserQuotaWithOptions(DescribeCdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnUserQuota",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserQuotaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserQuotaResponse
         */
        public async Task<DescribeCdnUserQuotaResponse> DescribeCdnUserQuotaWithOptionsAsync(DescribeCdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnUserQuota",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserQuotaRequest
          * @return DescribeCdnUserQuotaResponse
         */
        public DescribeCdnUserQuotaResponse DescribeCdnUserQuota(DescribeCdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserQuotaWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserQuotaRequest
          * @return DescribeCdnUserQuotaResponse
         */
        public async Task<DescribeCdnUserQuotaResponse> DescribeCdnUserQuotaAsync(DescribeCdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserQuotaWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserResourcePackageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserResourcePackageResponse
         */
        public DescribeCdnUserResourcePackageResponse DescribeCdnUserResourcePackageWithOptions(DescribeCdnUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnUserResourcePackage",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserResourcePackageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserResourcePackageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnUserResourcePackageResponse
         */
        public async Task<DescribeCdnUserResourcePackageResponse> DescribeCdnUserResourcePackageWithOptionsAsync(DescribeCdnUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCdnUserResourcePackage",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnUserResourcePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserResourcePackageRequest
          * @return DescribeCdnUserResourcePackageResponse
         */
        public DescribeCdnUserResourcePackageResponse DescribeCdnUserResourcePackage(DescribeCdnUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserResourcePackageWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeCdnUserResourcePackageRequest
          * @return DescribeCdnUserResourcePackageResponse
         */
        public async Task<DescribeCdnUserResourcePackageResponse> DescribeCdnUserResourcePackageAsync(DescribeCdnUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserResourcePackageWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 150 times per second per account.
          *
          * @param request DescribeCdnWafDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnWafDomainResponse
         */
        public DescribeCdnWafDomainResponse DescribeCdnWafDomainWithOptions(DescribeCdnWafDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "DescribeCdnWafDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnWafDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 150 times per second per account.
          *
          * @param request DescribeCdnWafDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCdnWafDomainResponse
         */
        public async Task<DescribeCdnWafDomainResponse> DescribeCdnWafDomainWithOptionsAsync(DescribeCdnWafDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "DescribeCdnWafDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCdnWafDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 150 times per second per account.
          *
          * @param request DescribeCdnWafDomainRequest
          * @return DescribeCdnWafDomainResponse
         */
        public DescribeCdnWafDomainResponse DescribeCdnWafDomain(DescribeCdnWafDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnWafDomainWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 150 times per second per account.
          *
          * @param request DescribeCdnWafDomainRequest
          * @return DescribeCdnWafDomainResponse
         */
        public async Task<DescribeCdnWafDomainResponse> DescribeCdnWafDomainAsync(DescribeCdnWafDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnWafDomainWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          * *   If a certificate is associated with a domain name but the certificate is not enabled, the result of this operation shows that the certificate does not exist.
          *
          * @param request DescribeCertificateInfoByIDRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCertificateInfoByIDResponse
         */
        public DescribeCertificateInfoByIDResponse DescribeCertificateInfoByIDWithOptions(DescribeCertificateInfoByIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertificateInfoByID",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificateInfoByIDResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          * *   If a certificate is associated with a domain name but the certificate is not enabled, the result of this operation shows that the certificate does not exist.
          *
          * @param request DescribeCertificateInfoByIDRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCertificateInfoByIDResponse
         */
        public async Task<DescribeCertificateInfoByIDResponse> DescribeCertificateInfoByIDWithOptionsAsync(DescribeCertificateInfoByIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertificateInfoByID",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificateInfoByIDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          * *   If a certificate is associated with a domain name but the certificate is not enabled, the result of this operation shows that the certificate does not exist.
          *
          * @param request DescribeCertificateInfoByIDRequest
          * @return DescribeCertificateInfoByIDResponse
         */
        public DescribeCertificateInfoByIDResponse DescribeCertificateInfoByID(DescribeCertificateInfoByIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificateInfoByIDWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          * *   If a certificate is associated with a domain name but the certificate is not enabled, the result of this operation shows that the certificate does not exist.
          *
          * @param request DescribeCertificateInfoByIDRequest
          * @return DescribeCertificateInfoByIDResponse
         */
        public async Task<DescribeCertificateInfoByIDResponse> DescribeCertificateInfoByIDAsync(DescribeCertificateInfoByIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificateInfoByIDWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCustomLogConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCustomLogConfigResponse
         */
        public DescribeCustomLogConfigResponse DescribeCustomLogConfigWithOptions(DescribeCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomLogConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCustomLogConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCustomLogConfigResponse
         */
        public async Task<DescribeCustomLogConfigResponse> DescribeCustomLogConfigWithOptionsAsync(DescribeCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomLogConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCustomLogConfigRequest
          * @return DescribeCustomLogConfigResponse
         */
        public DescribeCustomLogConfigResponse DescribeCustomLogConfig(DescribeCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomLogConfigWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeCustomLogConfigRequest
          * @return DescribeCustomLogConfigResponse
         */
        public async Task<DescribeCustomLogConfigResponse> DescribeCustomLogConfigAsync(DescribeCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomLogConfigWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 100 times per second per account.
          * >*   You can specify up to 500 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request DescribeDomainAverageResponseTimeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainAverageResponseTimeResponse
         */
        public DescribeDomainAverageResponseTimeResponse DescribeDomainAverageResponseTimeWithOptions(DescribeDomainAverageResponseTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
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
                Action = "DescribeDomainAverageResponseTime",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainAverageResponseTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 100 times per second per account.
          * >*   You can specify up to 500 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request DescribeDomainAverageResponseTimeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainAverageResponseTimeResponse
         */
        public async Task<DescribeDomainAverageResponseTimeResponse> DescribeDomainAverageResponseTimeWithOptionsAsync(DescribeDomainAverageResponseTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
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
                Action = "DescribeDomainAverageResponseTime",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainAverageResponseTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 100 times per second per account.
          * >*   You can specify up to 500 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request DescribeDomainAverageResponseTimeRequest
          * @return DescribeDomainAverageResponseTimeResponse
         */
        public DescribeDomainAverageResponseTimeResponse DescribeDomainAverageResponseTime(DescribeDomainAverageResponseTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAverageResponseTimeWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 100 times per second per account.
          * >*   You can specify up to 500 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request DescribeDomainAverageResponseTimeRequest
          * @return DescribeDomainAverageResponseTimeResponse
         */
        public async Task<DescribeDomainAverageResponseTimeResponse> DescribeDomainAverageResponseTimeAsync(DescribeDomainAverageResponseTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAverageResponseTimeWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 150 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainBpsDataResponse
         */
        public DescribeDomainBpsDataResponse DescribeDomainBpsDataWithOptions(DescribeDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainBpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainBpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 150 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainBpsDataResponse
         */
        public async Task<DescribeDomainBpsDataResponse> DescribeDomainBpsDataWithOptionsAsync(DescribeDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainBpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 150 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainBpsDataRequest
          * @return DescribeDomainBpsDataResponse
         */
        public DescribeDomainBpsDataResponse DescribeDomainBpsData(DescribeDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainBpsDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 150 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainBpsDataRequest
          * @return DescribeDomainBpsDataResponse
         */
        public async Task<DescribeDomainBpsDataResponse> DescribeDomainBpsDataAsync(DescribeDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainBpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 20 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainBpsDataByLayerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainBpsDataByLayerResponse
         */
        public DescribeDomainBpsDataByLayerResponse DescribeDomainBpsDataByLayerWithOptions(DescribeDomainBpsDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                query["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
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
                Action = "DescribeDomainBpsDataByLayer",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainBpsDataByLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 20 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainBpsDataByLayerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainBpsDataByLayerResponse
         */
        public async Task<DescribeDomainBpsDataByLayerResponse> DescribeDomainBpsDataByLayerWithOptionsAsync(DescribeDomainBpsDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                query["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
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
                Action = "DescribeDomainBpsDataByLayer",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainBpsDataByLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 20 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainBpsDataByLayerRequest
          * @return DescribeDomainBpsDataByLayerResponse
         */
        public DescribeDomainBpsDataByLayerResponse DescribeDomainBpsDataByLayer(DescribeDomainBpsDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainBpsDataByLayerWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 20 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainBpsDataByLayerRequest
          * @return DescribeDomainBpsDataByLayerResponse
         */
        public async Task<DescribeDomainBpsDataByLayerResponse> DescribeDomainBpsDataByLayerAsync(DescribeDomainBpsDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainBpsDataByLayerWithOptionsAsync(request, runtime);
        }

        /**
          * *   The bandwidth is measured in bit/s.
          * *   You can specify only one accelerated domain name in each request.
          * *   The data is collected every 5 minutes.
          * *   You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeDomainBpsDataByTimeStampRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainBpsDataByTimeStampResponse
         */
        public DescribeDomainBpsDataByTimeStampResponse DescribeDomainBpsDataByTimeStampWithOptions(DescribeDomainBpsDataByTimeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNames))
            {
                query["IspNames"] = request.IspNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNames))
            {
                query["LocationNames"] = request.LocationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainBpsDataByTimeStamp",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainBpsDataByTimeStampResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   The bandwidth is measured in bit/s.
          * *   You can specify only one accelerated domain name in each request.
          * *   The data is collected every 5 minutes.
          * *   You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeDomainBpsDataByTimeStampRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainBpsDataByTimeStampResponse
         */
        public async Task<DescribeDomainBpsDataByTimeStampResponse> DescribeDomainBpsDataByTimeStampWithOptionsAsync(DescribeDomainBpsDataByTimeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNames))
            {
                query["IspNames"] = request.IspNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNames))
            {
                query["LocationNames"] = request.LocationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainBpsDataByTimeStamp",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainBpsDataByTimeStampResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   The bandwidth is measured in bit/s.
          * *   You can specify only one accelerated domain name in each request.
          * *   The data is collected every 5 minutes.
          * *   You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeDomainBpsDataByTimeStampRequest
          * @return DescribeDomainBpsDataByTimeStampResponse
         */
        public DescribeDomainBpsDataByTimeStampResponse DescribeDomainBpsDataByTimeStamp(DescribeDomainBpsDataByTimeStampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainBpsDataByTimeStampWithOptions(request, runtime);
        }

        /**
          * *   The bandwidth is measured in bit/s.
          * *   You can specify only one accelerated domain name in each request.
          * *   The data is collected every 5 minutes.
          * *   You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeDomainBpsDataByTimeStampRequest
          * @return DescribeDomainBpsDataByTimeStampResponse
         */
        public async Task<DescribeDomainBpsDataByTimeStampResponse> DescribeDomainBpsDataByTimeStampAsync(DescribeDomainBpsDataByTimeStampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainBpsDataByTimeStampWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range. You must set both parameters or leave both parameters empty.
          * *   You can specify up to 20 domain names in reach request. If you specify multiple domain names, separate them with commas (,).
          * *   You can query data collected over the last 30 days.
          * *   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainCcActivityLogRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainCcActivityLogResponse
         */
        public DescribeDomainCcActivityLogResponse DescribeDomainCcActivityLogWithOptions(DescribeDomainCcActivityLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainCcActivityLog",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainCcActivityLogResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range. You must set both parameters or leave both parameters empty.
          * *   You can specify up to 20 domain names in reach request. If you specify multiple domain names, separate them with commas (,).
          * *   You can query data collected over the last 30 days.
          * *   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainCcActivityLogRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainCcActivityLogResponse
         */
        public async Task<DescribeDomainCcActivityLogResponse> DescribeDomainCcActivityLogWithOptionsAsync(DescribeDomainCcActivityLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainCcActivityLog",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainCcActivityLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range. You must set both parameters or leave both parameters empty.
          * *   You can specify up to 20 domain names in reach request. If you specify multiple domain names, separate them with commas (,).
          * *   You can query data collected over the last 30 days.
          * *   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainCcActivityLogRequest
          * @return DescribeDomainCcActivityLogResponse
         */
        public DescribeDomainCcActivityLogResponse DescribeDomainCcActivityLog(DescribeDomainCcActivityLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainCcActivityLogWithOptions(request, runtime);
        }

        /**
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range. You must set both parameters or leave both parameters empty.
          * *   You can specify up to 20 domain names in reach request. If you specify multiple domain names, separate them with commas (,).
          * *   You can query data collected over the last 30 days.
          * *   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainCcActivityLogRequest
          * @return DescribeDomainCcActivityLogResponse
         */
        public async Task<DescribeDomainCcActivityLogResponse> DescribeDomainCcActivityLogAsync(DescribeDomainCcActivityLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainCcActivityLogWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainCertificateInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainCertificateInfoResponse
         */
        public DescribeDomainCertificateInfoResponse DescribeDomainCertificateInfoWithOptions(DescribeDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainCertificateInfo",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainCertificateInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainCertificateInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainCertificateInfoResponse
         */
        public async Task<DescribeDomainCertificateInfoResponse> DescribeDomainCertificateInfoWithOptionsAsync(DescribeDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainCertificateInfo",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainCertificateInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainCertificateInfoRequest
          * @return DescribeDomainCertificateInfoResponse
         */
        public DescribeDomainCertificateInfoResponse DescribeDomainCertificateInfo(DescribeDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainCertificateInfoWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainCertificateInfoRequest
          * @return DescribeDomainCertificateInfoResponse
         */
        public async Task<DescribeDomainCertificateInfoResponse> DescribeDomainCertificateInfoAsync(DescribeDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDomainCnameResponse DescribeDomainCnameWithOptions(DescribeDomainCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainCname",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainCnameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDomainCnameResponse> DescribeDomainCnameWithOptionsAsync(DescribeDomainCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainCname",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainCnameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDomainCnameResponse DescribeDomainCname(DescribeDomainCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainCnameWithOptions(request, runtime);
        }

        public async Task<DescribeDomainCnameResponse> DescribeDomainCnameAsync(DescribeDomainCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainCnameWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainCustomLogConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainCustomLogConfigResponse
         */
        public DescribeDomainCustomLogConfigResponse DescribeDomainCustomLogConfigWithOptions(DescribeDomainCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainCustomLogConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainCustomLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainCustomLogConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainCustomLogConfigResponse
         */
        public async Task<DescribeDomainCustomLogConfigResponse> DescribeDomainCustomLogConfigWithOptionsAsync(DescribeDomainCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainCustomLogConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainCustomLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainCustomLogConfigRequest
          * @return DescribeDomainCustomLogConfigResponse
         */
        public DescribeDomainCustomLogConfigResponse DescribeDomainCustomLogConfig(DescribeDomainCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainCustomLogConfigWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainCustomLogConfigRequest
          * @return DescribeDomainCustomLogConfigResponse
         */
        public async Task<DescribeDomainCustomLogConfigResponse> DescribeDomainCustomLogConfigAsync(DescribeDomainCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainCustomLogConfigWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeDomainDetailDataByLayerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainDetailDataByLayerResponse
         */
        public DescribeDomainDetailDataByLayerResponse DescribeDomainDetailDataByLayerWithOptions(DescribeDomainDetailDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainDetailDataByLayer",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainDetailDataByLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeDomainDetailDataByLayerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainDetailDataByLayerResponse
         */
        public async Task<DescribeDomainDetailDataByLayerResponse> DescribeDomainDetailDataByLayerWithOptionsAsync(DescribeDomainDetailDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainDetailDataByLayer",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainDetailDataByLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeDomainDetailDataByLayerRequest
          * @return DescribeDomainDetailDataByLayerResponse
         */
        public DescribeDomainDetailDataByLayerResponse DescribeDomainDetailDataByLayer(DescribeDomainDetailDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainDetailDataByLayerWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeDomainDetailDataByLayerRequest
          * @return DescribeDomainDetailDataByLayerResponse
         */
        public async Task<DescribeDomainDetailDataByLayerResponse> DescribeDomainDetailDataByLayerAsync(DescribeDomainDetailDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainDetailDataByLayerWithOptionsAsync(request, runtime);
        }

        /**
          * > 
          * *   If you do not specify StartTime or EndTime, the request returns the data collected in the last 24 hours. If you specify both StartTime and EndTime, the request returns the data collected within the specified time range.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainFileSizeProportionDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainFileSizeProportionDataResponse
         */
        public DescribeDomainFileSizeProportionDataResponse DescribeDomainFileSizeProportionDataWithOptions(DescribeDomainFileSizeProportionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeDomainFileSizeProportionData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainFileSizeProportionDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > 
          * *   If you do not specify StartTime or EndTime, the request returns the data collected in the last 24 hours. If you specify both StartTime and EndTime, the request returns the data collected within the specified time range.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainFileSizeProportionDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainFileSizeProportionDataResponse
         */
        public async Task<DescribeDomainFileSizeProportionDataResponse> DescribeDomainFileSizeProportionDataWithOptionsAsync(DescribeDomainFileSizeProportionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeDomainFileSizeProportionData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainFileSizeProportionDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > 
          * *   If you do not specify StartTime or EndTime, the request returns the data collected in the last 24 hours. If you specify both StartTime and EndTime, the request returns the data collected within the specified time range.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainFileSizeProportionDataRequest
          * @return DescribeDomainFileSizeProportionDataResponse
         */
        public DescribeDomainFileSizeProportionDataResponse DescribeDomainFileSizeProportionData(DescribeDomainFileSizeProportionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainFileSizeProportionDataWithOptions(request, runtime);
        }

        /**
          * > 
          * *   If you do not specify StartTime or EndTime, the request returns the data collected in the last 24 hours. If you specify both StartTime and EndTime, the request returns the data collected within the specified time range.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainFileSizeProportionDataRequest
          * @return DescribeDomainFileSizeProportionDataResponse
         */
        public async Task<DescribeDomainFileSizeProportionDataResponse> DescribeDomainFileSizeProportionDataAsync(DescribeDomainFileSizeProportionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainFileSizeProportionDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHitRateDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainHitRateDataResponse
         */
        public DescribeDomainHitRateDataResponse DescribeDomainHitRateDataWithOptions(DescribeDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainHitRateData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainHitRateDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHitRateDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainHitRateDataResponse
         */
        public async Task<DescribeDomainHitRateDataResponse> DescribeDomainHitRateDataWithOptionsAsync(DescribeDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainHitRateData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainHitRateDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHitRateDataRequest
          * @return DescribeDomainHitRateDataResponse
         */
        public DescribeDomainHitRateDataResponse DescribeDomainHitRateData(DescribeDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainHitRateDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHitRateDataRequest
          * @return DescribeDomainHitRateDataResponse
         */
        public async Task<DescribeDomainHitRateDataResponse> DescribeDomainHitRateDataAsync(DescribeDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainHitRateDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHttpCodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainHttpCodeDataResponse
         */
        public DescribeDomainHttpCodeDataResponse DescribeDomainHttpCodeDataWithOptions(DescribeDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainHttpCodeData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainHttpCodeDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHttpCodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainHttpCodeDataResponse
         */
        public async Task<DescribeDomainHttpCodeDataResponse> DescribeDomainHttpCodeDataWithOptionsAsync(DescribeDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainHttpCodeData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainHttpCodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHttpCodeDataRequest
          * @return DescribeDomainHttpCodeDataResponse
         */
        public DescribeDomainHttpCodeDataResponse DescribeDomainHttpCodeData(DescribeDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainHttpCodeDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHttpCodeDataRequest
          * @return DescribeDomainHttpCodeDataResponse
         */
        public async Task<DescribeDomainHttpCodeDataResponse> DescribeDomainHttpCodeDataAsync(DescribeDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainHttpCodeDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 20 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * ### Time granularity
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHttpCodeDataByLayerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainHttpCodeDataByLayerResponse
         */
        public DescribeDomainHttpCodeDataByLayerResponse DescribeDomainHttpCodeDataByLayerWithOptions(DescribeDomainHttpCodeDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                query["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
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
                Action = "DescribeDomainHttpCodeDataByLayer",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainHttpCodeDataByLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 20 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * ### Time granularity
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHttpCodeDataByLayerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainHttpCodeDataByLayerResponse
         */
        public async Task<DescribeDomainHttpCodeDataByLayerResponse> DescribeDomainHttpCodeDataByLayerWithOptionsAsync(DescribeDomainHttpCodeDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                query["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
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
                Action = "DescribeDomainHttpCodeDataByLayer",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainHttpCodeDataByLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 20 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * ### Time granularity
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHttpCodeDataByLayerRequest
          * @return DescribeDomainHttpCodeDataByLayerResponse
         */
        public DescribeDomainHttpCodeDataByLayerResponse DescribeDomainHttpCodeDataByLayer(DescribeDomainHttpCodeDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainHttpCodeDataByLayerWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 20 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * ### Time granularity
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainHttpCodeDataByLayerRequest
          * @return DescribeDomainHttpCodeDataByLayerResponse
         */
        public async Task<DescribeDomainHttpCodeDataByLayerResponse> DescribeDomainHttpCodeDataByLayerAsync(DescribeDomainHttpCodeDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainHttpCodeDataByLayerWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set StartTime or EndTime, the request returns the data collected in the last 24 hours. If you set both StartTime and EndTime, the request returns the data collected within the specified time range.
          * >*   This operation queries proportions of data usage of different ISPs for only a specific accelerated domain name, or for all accelerated domain names in your Alibaba Cloud account.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainISPDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainISPDataResponse
         */
        public DescribeDomainISPDataResponse DescribeDomainISPDataWithOptions(DescribeDomainISPDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainISPData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainISPDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set StartTime or EndTime, the request returns the data collected in the last 24 hours. If you set both StartTime and EndTime, the request returns the data collected within the specified time range.
          * >*   This operation queries proportions of data usage of different ISPs for only a specific accelerated domain name, or for all accelerated domain names in your Alibaba Cloud account.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainISPDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainISPDataResponse
         */
        public async Task<DescribeDomainISPDataResponse> DescribeDomainISPDataWithOptionsAsync(DescribeDomainISPDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainISPData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainISPDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set StartTime or EndTime, the request returns the data collected in the last 24 hours. If you set both StartTime and EndTime, the request returns the data collected within the specified time range.
          * >*   This operation queries proportions of data usage of different ISPs for only a specific accelerated domain name, or for all accelerated domain names in your Alibaba Cloud account.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainISPDataRequest
          * @return DescribeDomainISPDataResponse
         */
        public DescribeDomainISPDataResponse DescribeDomainISPData(DescribeDomainISPDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainISPDataWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set StartTime or EndTime, the request returns the data collected in the last 24 hours. If you set both StartTime and EndTime, the request returns the data collected within the specified time range.
          * >*   This operation queries proportions of data usage of different ISPs for only a specific accelerated domain name, or for all accelerated domain names in your Alibaba Cloud account.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainISPDataRequest
          * @return DescribeDomainISPDataResponse
         */
        public async Task<DescribeDomainISPDataResponse> DescribeDomainISPDataAsync(DescribeDomainISPDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainISPDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   The unit of the bandwidth is bit/s.
          * *   The time granularity of the queried data is 5 minutes.
          * *   You can query data in the last 90 days.
          * *   You can specify the StartTime and EndTime parameters, or the TimePoint and Cycle parameters to query the 95th percentile bandwidth data. If you specify the StartTime and EndTime parameters and the time range that is specified by these parameters is less than or equal to 24 hours, the 95th percentile bandwidth data on the day of the start time is returned. If the time range that is specified by these parameters is more than 24 hours, the 95th percentile bandwidth data in the month of the start time is returned. If you specify the TimePoint and Cycle parameters, the 95th percentile bandwidth data of the cycle is returned. If you do not specify parameters as previously mentioned, the 95th percentile bandwidth data in the last 24 hours is returned.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainMax95BpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainMax95BpsDataResponse
         */
        public DescribeDomainMax95BpsDataResponse DescribeDomainMax95BpsDataWithOptions(DescribeDomainMax95BpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cycle))
            {
                query["Cycle"] = request.Cycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainMax95BpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainMax95BpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   The unit of the bandwidth is bit/s.
          * *   The time granularity of the queried data is 5 minutes.
          * *   You can query data in the last 90 days.
          * *   You can specify the StartTime and EndTime parameters, or the TimePoint and Cycle parameters to query the 95th percentile bandwidth data. If you specify the StartTime and EndTime parameters and the time range that is specified by these parameters is less than or equal to 24 hours, the 95th percentile bandwidth data on the day of the start time is returned. If the time range that is specified by these parameters is more than 24 hours, the 95th percentile bandwidth data in the month of the start time is returned. If you specify the TimePoint and Cycle parameters, the 95th percentile bandwidth data of the cycle is returned. If you do not specify parameters as previously mentioned, the 95th percentile bandwidth data in the last 24 hours is returned.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainMax95BpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainMax95BpsDataResponse
         */
        public async Task<DescribeDomainMax95BpsDataResponse> DescribeDomainMax95BpsDataWithOptionsAsync(DescribeDomainMax95BpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cycle))
            {
                query["Cycle"] = request.Cycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainMax95BpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainMax95BpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   The unit of the bandwidth is bit/s.
          * *   The time granularity of the queried data is 5 minutes.
          * *   You can query data in the last 90 days.
          * *   You can specify the StartTime and EndTime parameters, or the TimePoint and Cycle parameters to query the 95th percentile bandwidth data. If you specify the StartTime and EndTime parameters and the time range that is specified by these parameters is less than or equal to 24 hours, the 95th percentile bandwidth data on the day of the start time is returned. If the time range that is specified by these parameters is more than 24 hours, the 95th percentile bandwidth data in the month of the start time is returned. If you specify the TimePoint and Cycle parameters, the 95th percentile bandwidth data of the cycle is returned. If you do not specify parameters as previously mentioned, the 95th percentile bandwidth data in the last 24 hours is returned.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainMax95BpsDataRequest
          * @return DescribeDomainMax95BpsDataResponse
         */
        public DescribeDomainMax95BpsDataResponse DescribeDomainMax95BpsData(DescribeDomainMax95BpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainMax95BpsDataWithOptions(request, runtime);
        }

        /**
          * *   The unit of the bandwidth is bit/s.
          * *   The time granularity of the queried data is 5 minutes.
          * *   You can query data in the last 90 days.
          * *   You can specify the StartTime and EndTime parameters, or the TimePoint and Cycle parameters to query the 95th percentile bandwidth data. If you specify the StartTime and EndTime parameters and the time range that is specified by these parameters is less than or equal to 24 hours, the 95th percentile bandwidth data on the day of the start time is returned. If the time range that is specified by these parameters is more than 24 hours, the 95th percentile bandwidth data in the month of the start time is returned. If you specify the TimePoint and Cycle parameters, the 95th percentile bandwidth data of the cycle is returned. If you do not specify parameters as previously mentioned, the 95th percentile bandwidth data in the last 24 hours is returned.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainMax95BpsDataRequest
          * @return DescribeDomainMax95BpsDataResponse
         */
        public async Task<DescribeDomainMax95BpsDataResponse> DescribeDomainMax95BpsDataAsync(DescribeDomainMax95BpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainMax95BpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you do not set StartTime or EndTime, data collected within the last 10 minutes is queried.
          * *   The maximum interval between StartTime and EndTime is 1 hour.
          * *   You can query data within the last 90 days.
          * *   You can query the traffic data and the number of requests for accelerated domain names that are deleted.
          * *   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainMultiUsageDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainMultiUsageDataResponse
         */
        public DescribeDomainMultiUsageDataResponse DescribeDomainMultiUsageDataWithOptions(DescribeDomainMultiUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainMultiUsageData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainMultiUsageDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you do not set StartTime or EndTime, data collected within the last 10 minutes is queried.
          * *   The maximum interval between StartTime and EndTime is 1 hour.
          * *   You can query data within the last 90 days.
          * *   You can query the traffic data and the number of requests for accelerated domain names that are deleted.
          * *   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainMultiUsageDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainMultiUsageDataResponse
         */
        public async Task<DescribeDomainMultiUsageDataResponse> DescribeDomainMultiUsageDataWithOptionsAsync(DescribeDomainMultiUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainMultiUsageData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainMultiUsageDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you do not set StartTime or EndTime, data collected within the last 10 minutes is queried.
          * *   The maximum interval between StartTime and EndTime is 1 hour.
          * *   You can query data within the last 90 days.
          * *   You can query the traffic data and the number of requests for accelerated domain names that are deleted.
          * *   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainMultiUsageDataRequest
          * @return DescribeDomainMultiUsageDataResponse
         */
        public DescribeDomainMultiUsageDataResponse DescribeDomainMultiUsageData(DescribeDomainMultiUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainMultiUsageDataWithOptions(request, runtime);
        }

        /**
          * *   If you do not set StartTime or EndTime, data collected within the last 10 minutes is queried.
          * *   The maximum interval between StartTime and EndTime is 1 hour.
          * *   You can query data within the last 90 days.
          * *   You can query the traffic data and the number of requests for accelerated domain names that are deleted.
          * *   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainMultiUsageDataRequest
          * @return DescribeDomainMultiUsageDataResponse
         */
        public async Task<DescribeDomainMultiUsageDataResponse> DescribeDomainMultiUsageDataAsync(DescribeDomainMultiUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainMultiUsageDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only to users that are on the whitelist. If the daily peak bandwidth value of your workloads reaches 10 Gbit/s, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex) to apply to be included in the whitelist.
          * *   You can call this API operation up to 6,000 times per second per account.
          * *   Data collection by directory is available only to specified domain names within your Alibaba Cloud account. It cannot be enabled for all domain names within your Alibaba Cloud account.
          * *   The average size of the files that belong to the domain name must be larger than 1 MB.
          * *   The number of directories specified for a single domain name cannot exceed 100. If the number of directories exceeds 100, the data accuracy reduces.
          * *   If you do not set StartTime or EndTime, data collected within the last 24 hours is queried. If you set both StartTime and EndTime, data within the specified time range is queried.
          * *   You can query data collected within the last 30 days.
          *
          * @param request DescribeDomainPathDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainPathDataResponse
         */
        public DescribeDomainPathDataResponse DescribeDomainPathDataWithOptions(DescribeDomainPathDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainPathData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainPathDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only to users that are on the whitelist. If the daily peak bandwidth value of your workloads reaches 10 Gbit/s, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex) to apply to be included in the whitelist.
          * *   You can call this API operation up to 6,000 times per second per account.
          * *   Data collection by directory is available only to specified domain names within your Alibaba Cloud account. It cannot be enabled for all domain names within your Alibaba Cloud account.
          * *   The average size of the files that belong to the domain name must be larger than 1 MB.
          * *   The number of directories specified for a single domain name cannot exceed 100. If the number of directories exceeds 100, the data accuracy reduces.
          * *   If you do not set StartTime or EndTime, data collected within the last 24 hours is queried. If you set both StartTime and EndTime, data within the specified time range is queried.
          * *   You can query data collected within the last 30 days.
          *
          * @param request DescribeDomainPathDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainPathDataResponse
         */
        public async Task<DescribeDomainPathDataResponse> DescribeDomainPathDataWithOptionsAsync(DescribeDomainPathDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainPathData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainPathDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only to users that are on the whitelist. If the daily peak bandwidth value of your workloads reaches 10 Gbit/s, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex) to apply to be included in the whitelist.
          * *   You can call this API operation up to 6,000 times per second per account.
          * *   Data collection by directory is available only to specified domain names within your Alibaba Cloud account. It cannot be enabled for all domain names within your Alibaba Cloud account.
          * *   The average size of the files that belong to the domain name must be larger than 1 MB.
          * *   The number of directories specified for a single domain name cannot exceed 100. If the number of directories exceeds 100, the data accuracy reduces.
          * *   If you do not set StartTime or EndTime, data collected within the last 24 hours is queried. If you set both StartTime and EndTime, data within the specified time range is queried.
          * *   You can query data collected within the last 30 days.
          *
          * @param request DescribeDomainPathDataRequest
          * @return DescribeDomainPathDataResponse
         */
        public DescribeDomainPathDataResponse DescribeDomainPathData(DescribeDomainPathDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainPathDataWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only to users that are on the whitelist. If the daily peak bandwidth value of your workloads reaches 10 Gbit/s, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex) to apply to be included in the whitelist.
          * *   You can call this API operation up to 6,000 times per second per account.
          * *   Data collection by directory is available only to specified domain names within your Alibaba Cloud account. It cannot be enabled for all domain names within your Alibaba Cloud account.
          * *   The average size of the files that belong to the domain name must be larger than 1 MB.
          * *   The number of directories specified for a single domain name cannot exceed 100. If the number of directories exceeds 100, the data accuracy reduces.
          * *   If you do not set StartTime or EndTime, data collected within the last 24 hours is queried. If you set both StartTime and EndTime, data within the specified time range is queried.
          * *   You can query data collected within the last 30 days.
          *
          * @param request DescribeDomainPathDataRequest
          * @return DescribeDomainPathDataResponse
         */
        public async Task<DescribeDomainPathDataResponse> DescribeDomainPathDataAsync(DescribeDomainPathDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainPathDataWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainPvDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainPvDataResponse
         */
        public DescribeDomainPvDataResponse DescribeDomainPvDataWithOptions(DescribeDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainPvData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainPvDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainPvDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainPvDataResponse
         */
        public async Task<DescribeDomainPvDataResponse> DescribeDomainPvDataWithOptionsAsync(DescribeDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainPvData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainPvDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainPvDataRequest
          * @return DescribeDomainPvDataResponse
         */
        public DescribeDomainPvDataResponse DescribeDomainPvData(DescribeDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainPvDataWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeDomainPvDataRequest
          * @return DescribeDomainPvDataResponse
         */
        public async Task<DescribeDomainPvDataResponse> DescribeDomainPvDataAsync(DescribeDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainPvDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainQpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainQpsDataResponse
         */
        public DescribeDomainQpsDataResponse DescribeDomainQpsDataWithOptions(DescribeDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainQpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainQpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainQpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainQpsDataResponse
         */
        public async Task<DescribeDomainQpsDataResponse> DescribeDomainQpsDataWithOptionsAsync(DescribeDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainQpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainQpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainQpsDataRequest
          * @return DescribeDomainQpsDataResponse
         */
        public DescribeDomainQpsDataResponse DescribeDomainQpsData(DescribeDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQpsDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainQpsDataRequest
          * @return DescribeDomainQpsDataResponse
         */
        public async Task<DescribeDomainQpsDataResponse> DescribeDomainQpsDataAsync(DescribeDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 20 times per second per user.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter varies with the maximum time range per query. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainQpsDataByLayerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainQpsDataByLayerResponse
         */
        public DescribeDomainQpsDataByLayerResponse DescribeDomainQpsDataByLayerWithOptions(DescribeDomainQpsDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                query["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
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
                Action = "DescribeDomainQpsDataByLayer",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainQpsDataByLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 20 times per second per user.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter varies with the maximum time range per query. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainQpsDataByLayerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainQpsDataByLayerResponse
         */
        public async Task<DescribeDomainQpsDataByLayerResponse> DescribeDomainQpsDataByLayerWithOptionsAsync(DescribeDomainQpsDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                query["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
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
                Action = "DescribeDomainQpsDataByLayer",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainQpsDataByLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 20 times per second per user.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter varies with the maximum time range per query. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainQpsDataByLayerRequest
          * @return DescribeDomainQpsDataByLayerResponse
         */
        public DescribeDomainQpsDataByLayerResponse DescribeDomainQpsDataByLayer(DescribeDomainQpsDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQpsDataByLayerWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 20 times per second per user.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter varies with the maximum time range per query. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainQpsDataByLayerRequest
          * @return DescribeDomainQpsDataByLayerResponse
         */
        public async Task<DescribeDomainQpsDataByLayerResponse> DescribeDomainQpsDataByLayerAsync(DescribeDomainQpsDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQpsDataByLayerWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity** The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeBpsDataResponse
         */
        public DescribeDomainRealTimeBpsDataResponse DescribeDomainRealTimeBpsDataWithOptions(DescribeDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeBpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeBpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity** The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeBpsDataResponse
         */
        public async Task<DescribeDomainRealTimeBpsDataResponse> DescribeDomainRealTimeBpsDataWithOptionsAsync(DescribeDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeBpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity** The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeBpsDataRequest
          * @return DescribeDomainRealTimeBpsDataResponse
         */
        public DescribeDomainRealTimeBpsDataResponse DescribeDomainRealTimeBpsData(DescribeDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeBpsDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity** The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeBpsDataRequest
          * @return DescribeDomainRealTimeBpsDataResponse
         */
        public async Task<DescribeDomainRealTimeBpsDataResponse> DescribeDomainRealTimeBpsDataAsync(DescribeDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeBpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * * The network traffic destined for different domain names may be redirected to the same origin server. Therefore, the byte hit ratios may be inaccurate. The accuracy of query results is based on the actual configurations.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeByteHitRateDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeByteHitRateDataResponse
         */
        public DescribeDomainRealTimeByteHitRateDataResponse DescribeDomainRealTimeByteHitRateDataWithOptions(DescribeDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeByteHitRateData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeByteHitRateDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * * The network traffic destined for different domain names may be redirected to the same origin server. Therefore, the byte hit ratios may be inaccurate. The accuracy of query results is based on the actual configurations.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeByteHitRateDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeByteHitRateDataResponse
         */
        public async Task<DescribeDomainRealTimeByteHitRateDataResponse> DescribeDomainRealTimeByteHitRateDataWithOptionsAsync(DescribeDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeByteHitRateData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeByteHitRateDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * * The network traffic destined for different domain names may be redirected to the same origin server. Therefore, the byte hit ratios may be inaccurate. The accuracy of query results is based on the actual configurations.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeByteHitRateDataRequest
          * @return DescribeDomainRealTimeByteHitRateDataResponse
         */
        public DescribeDomainRealTimeByteHitRateDataResponse DescribeDomainRealTimeByteHitRateData(DescribeDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeByteHitRateDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * * The network traffic destined for different domain names may be redirected to the same origin server. Therefore, the byte hit ratios may be inaccurate. The accuracy of query results is based on the actual configurations.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeByteHitRateDataRequest
          * @return DescribeDomainRealTimeByteHitRateDataResponse
         */
        public async Task<DescribeDomainRealTimeByteHitRateDataResponse> DescribeDomainRealTimeByteHitRateDataAsync(DescribeDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeByteHitRateDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can query data in the last seven days. Data is collected every minute.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainRealTimeDetailDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeDetailDataResponse
         */
        public DescribeDomainRealTimeDetailDataResponse DescribeDomainRealTimeDetailDataWithOptions(DescribeDomainRealTimeDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeDetailData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeDetailDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can query data in the last seven days. Data is collected every minute.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainRealTimeDetailDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeDetailDataResponse
         */
        public async Task<DescribeDomainRealTimeDetailDataResponse> DescribeDomainRealTimeDetailDataWithOptionsAsync(DescribeDomainRealTimeDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeDetailData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeDetailDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can query data in the last seven days. Data is collected every minute.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainRealTimeDetailDataRequest
          * @return DescribeDomainRealTimeDetailDataResponse
         */
        public DescribeDomainRealTimeDetailDataResponse DescribeDomainRealTimeDetailData(DescribeDomainRealTimeDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeDetailDataWithOptions(request, runtime);
        }

        /**
          * *   You can query data in the last seven days. Data is collected every minute.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainRealTimeDetailDataRequest
          * @return DescribeDomainRealTimeDetailDataResponse
         */
        public async Task<DescribeDomainRealTimeDetailDataResponse> DescribeDomainRealTimeDetailDataAsync(DescribeDomainRealTimeDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeDetailDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeHttpCodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeHttpCodeDataResponse
         */
        public DescribeDomainRealTimeHttpCodeDataResponse DescribeDomainRealTimeHttpCodeDataWithOptions(DescribeDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeHttpCodeData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeHttpCodeDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeHttpCodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeHttpCodeDataResponse
         */
        public async Task<DescribeDomainRealTimeHttpCodeDataResponse> DescribeDomainRealTimeHttpCodeDataWithOptionsAsync(DescribeDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeHttpCodeData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeHttpCodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeHttpCodeDataRequest
          * @return DescribeDomainRealTimeHttpCodeDataResponse
         */
        public DescribeDomainRealTimeHttpCodeDataResponse DescribeDomainRealTimeHttpCodeData(DescribeDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeHttpCodeDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeHttpCodeDataRequest
          * @return DescribeDomainRealTimeHttpCodeDataResponse
         */
        public async Task<DescribeDomainRealTimeHttpCodeDataResponse> DescribeDomainRealTimeHttpCodeDataAsync(DescribeDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeHttpCodeDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeQpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeQpsDataResponse
         */
        public DescribeDomainRealTimeQpsDataResponse DescribeDomainRealTimeQpsDataWithOptions(DescribeDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeQpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeQpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeQpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeQpsDataResponse
         */
        public async Task<DescribeDomainRealTimeQpsDataResponse> DescribeDomainRealTimeQpsDataWithOptionsAsync(DescribeDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeQpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeQpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeQpsDataRequest
          * @return DescribeDomainRealTimeQpsDataResponse
         */
        public DescribeDomainRealTimeQpsDataResponse DescribeDomainRealTimeQpsData(DescribeDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeQpsDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeQpsDataRequest
          * @return DescribeDomainRealTimeQpsDataResponse
         */
        public async Task<DescribeDomainRealTimeQpsDataResponse> DescribeDomainRealTimeQpsDataAsync(DescribeDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeQpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * * By default, requests in the Go programming language use the POST request method. You must manually change the request method to GET by declaring: request.Method="GET".
          * * The network traffic destined for different domain names may be redirected to the same origin server. Therefore, the request hit ratios may be inaccurate. The accuracy of query results is based on the actual configurations.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeReqHitRateDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeReqHitRateDataResponse
         */
        public DescribeDomainRealTimeReqHitRateDataResponse DescribeDomainRealTimeReqHitRateDataWithOptions(DescribeDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeReqHitRateData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeReqHitRateDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * * By default, requests in the Go programming language use the POST request method. You must manually change the request method to GET by declaring: request.Method="GET".
          * * The network traffic destined for different domain names may be redirected to the same origin server. Therefore, the request hit ratios may be inaccurate. The accuracy of query results is based on the actual configurations.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeReqHitRateDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeReqHitRateDataResponse
         */
        public async Task<DescribeDomainRealTimeReqHitRateDataResponse> DescribeDomainRealTimeReqHitRateDataWithOptionsAsync(DescribeDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealTimeReqHitRateData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeReqHitRateDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * * By default, requests in the Go programming language use the POST request method. You must manually change the request method to GET by declaring: request.Method="GET".
          * * The network traffic destined for different domain names may be redirected to the same origin server. Therefore, the request hit ratios may be inaccurate. The accuracy of query results is based on the actual configurations.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeReqHitRateDataRequest
          * @return DescribeDomainRealTimeReqHitRateDataResponse
         */
        public DescribeDomainRealTimeReqHitRateDataResponse DescribeDomainRealTimeReqHitRateData(DescribeDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeReqHitRateDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * * By default, requests in the Go programming language use the POST request method. You must manually change the request method to GET by declaring: request.Method="GET".
          * * The network traffic destined for different domain names may be redirected to the same origin server. Therefore, the request hit ratios may be inaccurate. The accuracy of query results is based on the actual configurations.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeReqHitRateDataRequest
          * @return DescribeDomainRealTimeReqHitRateDataResponse
         */
        public async Task<DescribeDomainRealTimeReqHitRateDataResponse> DescribeDomainRealTimeReqHitRateDataAsync(DescribeDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeReqHitRateDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeSrcBpsDataResponse
         */
        public DescribeDomainRealTimeSrcBpsDataResponse DescribeDomainRealTimeSrcBpsDataWithOptions(DescribeDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeSrcBpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcBpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeSrcBpsDataResponse
         */
        public async Task<DescribeDomainRealTimeSrcBpsDataResponse> DescribeDomainRealTimeSrcBpsDataWithOptionsAsync(DescribeDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeSrcBpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcBpsDataRequest
          * @return DescribeDomainRealTimeSrcBpsDataResponse
         */
        public DescribeDomainRealTimeSrcBpsDataResponse DescribeDomainRealTimeSrcBpsData(DescribeDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeSrcBpsDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcBpsDataRequest
          * @return DescribeDomainRealTimeSrcBpsDataResponse
         */
        public async Task<DescribeDomainRealTimeSrcBpsDataResponse> DescribeDomainRealTimeSrcBpsDataAsync(DescribeDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeSrcBpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcHttpCodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeSrcHttpCodeDataResponse
         */
        public DescribeDomainRealTimeSrcHttpCodeDataResponse DescribeDomainRealTimeSrcHttpCodeDataWithOptions(DescribeDomainRealTimeSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeSrcHttpCodeData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcHttpCodeDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcHttpCodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeSrcHttpCodeDataResponse
         */
        public async Task<DescribeDomainRealTimeSrcHttpCodeDataResponse> DescribeDomainRealTimeSrcHttpCodeDataWithOptionsAsync(DescribeDomainRealTimeSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeSrcHttpCodeData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcHttpCodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcHttpCodeDataRequest
          * @return DescribeDomainRealTimeSrcHttpCodeDataResponse
         */
        public DescribeDomainRealTimeSrcHttpCodeDataResponse DescribeDomainRealTimeSrcHttpCodeData(DescribeDomainRealTimeSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeSrcHttpCodeDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you set both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcHttpCodeDataRequest
          * @return DescribeDomainRealTimeSrcHttpCodeDataResponse
         */
        public async Task<DescribeDomainRealTimeSrcHttpCodeDataResponse> DescribeDomainRealTimeSrcHttpCodeDataAsync(DescribeDomainRealTimeSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeSrcHttpCodeDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last hour by default. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeSrcTrafficDataResponse
         */
        public DescribeDomainRealTimeSrcTrafficDataResponse DescribeDomainRealTimeSrcTrafficDataWithOptions(DescribeDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeSrcTrafficData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last hour by default. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeSrcTrafficDataResponse
         */
        public async Task<DescribeDomainRealTimeSrcTrafficDataResponse> DescribeDomainRealTimeSrcTrafficDataWithOptionsAsync(DescribeDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeSrcTrafficData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last hour by default. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcTrafficDataRequest
          * @return DescribeDomainRealTimeSrcTrafficDataResponse
         */
        public DescribeDomainRealTimeSrcTrafficDataResponse DescribeDomainRealTimeSrcTrafficData(DescribeDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeSrcTrafficDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last hour by default. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeSrcTrafficDataRequest
          * @return DescribeDomainRealTimeSrcTrafficDataResponse
         */
        public async Task<DescribeDomainRealTimeSrcTrafficDataResponse> DescribeDomainRealTimeSrcTrafficDataAsync(DescribeDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 50 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeTrafficDataResponse
         */
        public DescribeDomainRealTimeTrafficDataResponse DescribeDomainRealTimeTrafficDataWithOptions(DescribeDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeTrafficData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 50 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealTimeTrafficDataResponse
         */
        public async Task<DescribeDomainRealTimeTrafficDataResponse> DescribeDomainRealTimeTrafficDataWithOptionsAsync(DescribeDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRealTimeTrafficData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealTimeTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 50 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeTrafficDataRequest
          * @return DescribeDomainRealTimeTrafficDataResponse
         */
        public DescribeDomainRealTimeTrafficDataResponse DescribeDomainRealTimeTrafficData(DescribeDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeTrafficDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 50 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last hour. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity varies with the time range specified by the StartTime and EndTime parameters. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |1 minute|1 hour|7 days|5 minutes|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          *
          * @param request DescribeDomainRealTimeTrafficDataRequest
          * @return DescribeDomainRealTimeTrafficDataResponse
         */
        public async Task<DescribeDomainRealTimeTrafficDataResponse> DescribeDomainRealTimeTrafficDataAsync(DescribeDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeTrafficDataWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealtimeLogDeliveryResponse
         */
        public DescribeDomainRealtimeLogDeliveryResponse DescribeDomainRealtimeLogDeliveryWithOptions(DescribeDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRealtimeLogDeliveryResponse
         */
        public async Task<DescribeDomainRealtimeLogDeliveryResponse> DescribeDomainRealtimeLogDeliveryWithOptionsAsync(DescribeDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainRealtimeLogDeliveryRequest
          * @return DescribeDomainRealtimeLogDeliveryResponse
         */
        public DescribeDomainRealtimeLogDeliveryResponse DescribeDomainRealtimeLogDelivery(DescribeDomainRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealtimeLogDeliveryWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainRealtimeLogDeliveryRequest
          * @return DescribeDomainRealtimeLogDeliveryResponse
         */
        public async Task<DescribeDomainRealtimeLogDeliveryResponse> DescribeDomainRealtimeLogDeliveryAsync(DescribeDomainRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you not use this operation because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not specify the **StartTime** or **EndTime** parameter, data collected within the last **24** hours is queried. If you specify both the **StartTime** and **EndTime** parameters, data collected within the specified time range is queried.
          * >*   There is delay in data collection. If you want to query data collected within the last day, we recommend that you query the data on the next day.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainRegionDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRegionDataResponse
         */
        public DescribeDomainRegionDataResponse DescribeDomainRegionDataWithOptions(DescribeDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRegionData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRegionDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you not use this operation because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not specify the **StartTime** or **EndTime** parameter, data collected within the last **24** hours is queried. If you specify both the **StartTime** and **EndTime** parameters, data collected within the specified time range is queried.
          * >*   There is delay in data collection. If you want to query data collected within the last day, we recommend that you query the data on the next day.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainRegionDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainRegionDataResponse
         */
        public async Task<DescribeDomainRegionDataResponse> DescribeDomainRegionDataWithOptionsAsync(DescribeDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainRegionData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRegionDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you not use this operation because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not specify the **StartTime** or **EndTime** parameter, data collected within the last **24** hours is queried. If you specify both the **StartTime** and **EndTime** parameters, data collected within the specified time range is queried.
          * >*   There is delay in data collection. If you want to query data collected within the last day, we recommend that you query the data on the next day.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainRegionDataRequest
          * @return DescribeDomainRegionDataResponse
         */
        public DescribeDomainRegionDataResponse DescribeDomainRegionData(DescribeDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRegionDataWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you not use this operation because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not specify the **StartTime** or **EndTime** parameter, data collected within the last **24** hours is queried. If you specify both the **StartTime** and **EndTime** parameters, data collected within the specified time range is queried.
          * >*   There is delay in data collection. If you want to query data collected within the last day, we recommend that you query the data on the next day.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainRegionDataRequest
          * @return DescribeDomainRegionDataResponse
         */
        public async Task<DescribeDomainRegionDataResponse> DescribeDomainRegionDataAsync(DescribeDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRegionDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainReqHitRateDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainReqHitRateDataResponse
         */
        public DescribeDomainReqHitRateDataResponse DescribeDomainReqHitRateDataWithOptions(DescribeDomainReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainReqHitRateData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainReqHitRateDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainReqHitRateDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainReqHitRateDataResponse
         */
        public async Task<DescribeDomainReqHitRateDataResponse> DescribeDomainReqHitRateDataWithOptionsAsync(DescribeDomainReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainReqHitRateData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainReqHitRateDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainReqHitRateDataRequest
          * @return DescribeDomainReqHitRateDataResponse
         */
        public DescribeDomainReqHitRateDataResponse DescribeDomainReqHitRateData(DescribeDomainReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainReqHitRateDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainReqHitRateDataRequest
          * @return DescribeDomainReqHitRateDataResponse
         */
        public async Task<DescribeDomainReqHitRateDataResponse> DescribeDomainReqHitRateDataAsync(DescribeDomainReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainReqHitRateDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the time range to query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcBpsDataResponse
         */
        public DescribeDomainSrcBpsDataResponse DescribeDomainSrcBpsDataWithOptions(DescribeDomainSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcBpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcBpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the time range to query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcBpsDataResponse
         */
        public async Task<DescribeDomainSrcBpsDataResponse> DescribeDomainSrcBpsDataWithOptionsAsync(DescribeDomainSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcBpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the time range to query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcBpsDataRequest
          * @return DescribeDomainSrcBpsDataResponse
         */
        public DescribeDomainSrcBpsDataResponse DescribeDomainSrcBpsData(DescribeDomainSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcBpsDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not specify the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you specify both the StartTime and EndTime parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the time range to query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcBpsDataRequest
          * @return DescribeDomainSrcBpsDataResponse
         */
        public async Task<DescribeDomainSrcBpsDataResponse> DescribeDomainSrcBpsDataAsync(DescribeDomainSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcBpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter varies with the maximum time range per query. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcHttpCodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcHttpCodeDataResponse
         */
        public DescribeDomainSrcHttpCodeDataResponse DescribeDomainSrcHttpCodeDataWithOptions(DescribeDomainSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcHttpCodeData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcHttpCodeDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter varies with the maximum time range per query. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcHttpCodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcHttpCodeDataResponse
         */
        public async Task<DescribeDomainSrcHttpCodeDataResponse> DescribeDomainSrcHttpCodeDataWithOptionsAsync(DescribeDomainSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcHttpCodeData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcHttpCodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter varies with the maximum time range per query. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcHttpCodeDataRequest
          * @return DescribeDomainSrcHttpCodeDataResponse
         */
        public DescribeDomainSrcHttpCodeDataResponse DescribeDomainSrcHttpCodeData(DescribeDomainSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcHttpCodeDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter varies with the maximum time range per query. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcHttpCodeDataRequest
          * @return DescribeDomainSrcHttpCodeDataResponse
         */
        public async Task<DescribeDomainSrcHttpCodeDataResponse> DescribeDomainSrcHttpCodeDataAsync(DescribeDomainSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcHttpCodeDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * ### Time granularity
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcQpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcQpsDataResponse
         */
        public DescribeDomainSrcQpsDataResponse DescribeDomainSrcQpsDataWithOptions(DescribeDomainSrcQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcQpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcQpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * ### Time granularity
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcQpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcQpsDataResponse
         */
        public async Task<DescribeDomainSrcQpsDataResponse> DescribeDomainSrcQpsDataWithOptionsAsync(DescribeDomainSrcQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcQpsData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcQpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * ### Time granularity
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcQpsDataRequest
          * @return DescribeDomainSrcQpsDataResponse
         */
        public DescribeDomainSrcQpsDataResponse DescribeDomainSrcQpsData(DescribeDomainSrcQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcQpsDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * ### Time granularity
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcQpsDataRequest
          * @return DescribeDomainSrcQpsDataResponse
         */
        public async Task<DescribeDomainSrcQpsDataResponse> DescribeDomainSrcQpsDataAsync(DescribeDomainSrcQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcQpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   The data is collected at an interval of 5 minutes.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainSrcTopUrlVisitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcTopUrlVisitResponse
         */
        public DescribeDomainSrcTopUrlVisitResponse DescribeDomainSrcTopUrlVisitWithOptions(DescribeDomainSrcTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcTopUrlVisit",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcTopUrlVisitResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   The data is collected at an interval of 5 minutes.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainSrcTopUrlVisitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcTopUrlVisitResponse
         */
        public async Task<DescribeDomainSrcTopUrlVisitResponse> DescribeDomainSrcTopUrlVisitWithOptionsAsync(DescribeDomainSrcTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcTopUrlVisit",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcTopUrlVisitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   The data is collected at an interval of 5 minutes.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainSrcTopUrlVisitRequest
          * @return DescribeDomainSrcTopUrlVisitResponse
         */
        public DescribeDomainSrcTopUrlVisitResponse DescribeDomainSrcTopUrlVisit(DescribeDomainSrcTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcTopUrlVisitWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   The data is collected at an interval of 5 minutes.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainSrcTopUrlVisitRequest
          * @return DescribeDomainSrcTopUrlVisitResponse
         */
        public async Task<DescribeDomainSrcTopUrlVisitResponse> DescribeDomainSrcTopUrlVisitAsync(DescribeDomainSrcTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcTopUrlVisitWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcTrafficDataResponse
         */
        public DescribeDomainSrcTrafficDataResponse DescribeDomainSrcTrafficDataWithOptions(DescribeDomainSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcTrafficData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainSrcTrafficDataResponse
         */
        public async Task<DescribeDomainSrcTrafficDataResponse> DescribeDomainSrcTrafficDataWithOptionsAsync(DescribeDomainSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainSrcTrafficData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainSrcTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcTrafficDataRequest
          * @return DescribeDomainSrcTrafficDataResponse
         */
        public DescribeDomainSrcTrafficDataResponse DescribeDomainSrcTrafficData(DescribeDomainSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcTrafficDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainSrcTrafficDataRequest
          * @return DescribeDomainSrcTrafficDataResponse
         */
        public async Task<DescribeDomainSrcTrafficDataResponse> DescribeDomainSrcTrafficDataAsync(DescribeDomainSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   Data is collected every hour.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopClientIpVisitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainTopClientIpVisitResponse
         */
        public DescribeDomainTopClientIpVisitResponse DescribeDomainTopClientIpVisitWithOptions(DescribeDomainTopClientIpVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
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
                Action = "DescribeDomainTopClientIpVisit",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainTopClientIpVisitResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   Data is collected every hour.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopClientIpVisitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainTopClientIpVisitResponse
         */
        public async Task<DescribeDomainTopClientIpVisitResponse> DescribeDomainTopClientIpVisitWithOptionsAsync(DescribeDomainTopClientIpVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
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
                Action = "DescribeDomainTopClientIpVisit",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainTopClientIpVisitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   Data is collected every hour.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopClientIpVisitRequest
          * @return DescribeDomainTopClientIpVisitResponse
         */
        public DescribeDomainTopClientIpVisitResponse DescribeDomainTopClientIpVisit(DescribeDomainTopClientIpVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTopClientIpVisitWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature to for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   Data is collected every hour.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopClientIpVisitRequest
          * @return DescribeDomainTopClientIpVisitResponse
         */
        public async Task<DescribeDomainTopClientIpVisitResponse> DescribeDomainTopClientIpVisitAsync(DescribeDomainTopClientIpVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTopClientIpVisitWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature or [ship real-time logs in Log Service](~~440145~~) to analyze data.
          * > 
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * *   Data is collected at an interval of five minutes.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopReferVisitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainTopReferVisitResponse
         */
        public DescribeDomainTopReferVisitResponse DescribeDomainTopReferVisitWithOptions(DescribeDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainTopReferVisit",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainTopReferVisitResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature or [ship real-time logs in Log Service](~~440145~~) to analyze data.
          * > 
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * *   Data is collected at an interval of five minutes.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopReferVisitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainTopReferVisitResponse
         */
        public async Task<DescribeDomainTopReferVisitResponse> DescribeDomainTopReferVisitWithOptionsAsync(DescribeDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainTopReferVisit",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainTopReferVisitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature or [ship real-time logs in Log Service](~~440145~~) to analyze data.
          * > 
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * *   Data is collected at an interval of five minutes.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopReferVisitRequest
          * @return DescribeDomainTopReferVisitResponse
         */
        public DescribeDomainTopReferVisitResponse DescribeDomainTopReferVisit(DescribeDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTopReferVisitWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature or [ship real-time logs in Log Service](~~440145~~) to analyze data.
          * > 
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * *   Data is collected at an interval of five minutes.
          * *   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopReferVisitRequest
          * @return DescribeDomainTopReferVisitResponse
         */
        public async Task<DescribeDomainTopReferVisitResponse> DescribeDomainTopReferVisitAsync(DescribeDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTopReferVisitWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can query data collected in the last 90 days.
          * >*   You can specify only one domain name in each call.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopUrlVisitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainTopUrlVisitResponse
         */
        public DescribeDomainTopUrlVisitResponse DescribeDomainTopUrlVisitWithOptions(DescribeDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainTopUrlVisit",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainTopUrlVisitResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can query data collected in the last 90 days.
          * >*   You can specify only one domain name in each call.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopUrlVisitRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainTopUrlVisitResponse
         */
        public async Task<DescribeDomainTopUrlVisitResponse> DescribeDomainTopUrlVisitWithOptionsAsync(DescribeDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainTopUrlVisit",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainTopUrlVisitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can query data collected in the last 90 days.
          * >*   You can specify only one domain name in each call.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopUrlVisitRequest
          * @return DescribeDomainTopUrlVisitResponse
         */
        public DescribeDomainTopUrlVisitResponse DescribeDomainTopUrlVisit(DescribeDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTopUrlVisitWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can query data collected in the last 90 days.
          * >*   You can specify only one domain name in each call.
          * >*   You can call this operation up to 10 times per second per account.
          *
          * @param request DescribeDomainTopUrlVisitRequest
          * @return DescribeDomainTopUrlVisitResponse
         */
        public async Task<DescribeDomainTopUrlVisitResponse> DescribeDomainTopUrlVisitAsync(DescribeDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTopUrlVisitWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366|04:00 on the next day|
          *
          * @param request DescribeDomainTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainTrafficDataResponse
         */
        public DescribeDomainTrafficDataResponse DescribeDomainTrafficDataWithOptions(DescribeDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainTrafficData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366|04:00 on the next day|
          *
          * @param request DescribeDomainTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainTrafficDataResponse
         */
        public async Task<DescribeDomainTrafficDataResponse> DescribeDomainTrafficDataWithOptionsAsync(DescribeDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainTrafficData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366|04:00 on the next day|
          *
          * @param request DescribeDomainTrafficDataRequest
          * @return DescribeDomainTrafficDataResponse
         */
        public DescribeDomainTrafficDataResponse DescribeDomainTrafficData(DescribeDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTrafficDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 100 times per second per account.
          * * If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * **Time granularity**
          * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|366 days|366|04:00 on the next day|
          *
          * @param request DescribeDomainTrafficDataRequest
          * @return DescribeDomainTrafficDataResponse
         */
        public async Task<DescribeDomainTrafficDataResponse> DescribeDomainTrafficDataAsync(DescribeDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|90 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainUsageDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainUsageDataResponse
         */
        public DescribeDomainUsageDataResponse DescribeDomainUsageDataWithOptions(DescribeDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeDomainUsageData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainUsageDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|90 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainUsageDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainUsageDataResponse
         */
        public async Task<DescribeDomainUsageDataResponse> DescribeDomainUsageDataWithOptionsAsync(DescribeDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeDomainUsageData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainUsageDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|90 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainUsageDataRequest
          * @return DescribeDomainUsageDataResponse
         */
        public DescribeDomainUsageDataResponse DescribeDomainUsageData(DescribeDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainUsageDataWithOptions(request, runtime);
        }

        /**
          * * You can call this operation up to 10 times per second per account.
          * * The time granularity supported by the Interval parameter, the maximum time period within which historical data is available, and the data delay vary with the maximum time range per query, as described in the following table.
          * |Time granularity|Maximum time range per query|Historical data available|Data delay|
          * |---|---|---|---|
          * |5 minutes|3 days|93 days|15 minutes|
          * |1 hour|31 days|186 days|4 hours|
          * |1 day|90 days|366 days|04:00 on the next day|
          *
          * @param request DescribeDomainUsageDataRequest
          * @return DescribeDomainUsageDataResponse
         */
        public async Task<DescribeDomainUsageDataResponse> DescribeDomainUsageDataAsync(DescribeDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainUsageDataWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > 
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * *   You can specify only one accelerated domain name or all accelerated domain names in your Alibaba Cloud account.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainUvDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainUvDataResponse
         */
        public DescribeDomainUvDataResponse DescribeDomainUvDataWithOptions(DescribeDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainUvData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainUvDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > 
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * *   You can specify only one accelerated domain name or all accelerated domain names in your Alibaba Cloud account.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainUvDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainUvDataResponse
         */
        public async Task<DescribeDomainUvDataResponse> DescribeDomainUvDataWithOptionsAsync(DescribeDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainUvData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainUvDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > 
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * *   You can specify only one accelerated domain name or all accelerated domain names in your Alibaba Cloud account.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainUvDataRequest
          * @return DescribeDomainUvDataResponse
         */
        public DescribeDomainUvDataResponse DescribeDomainUvData(DescribeDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainUvDataWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > 
          * *   If you do not set the StartTime or EndTime parameter, the request returns the data collected in the last 24 hours. If you set both these parameters, the request returns the data collected within the specified time range.
          * *   You can specify only one accelerated domain name or all accelerated domain names in your Alibaba Cloud account.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeDomainUvDataRequest
          * @return DescribeDomainUvDataResponse
         */
        public async Task<DescribeDomainUvDataResponse> DescribeDomainUvDataAsync(DescribeDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainUvDataWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeDomainsBySourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainsBySourceResponse
         */
        public DescribeDomainsBySourceResponse DescribeDomainsBySourceWithOptions(DescribeDomainsBySourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainsBySource",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainsBySourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeDomainsBySourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainsBySourceResponse
         */
        public async Task<DescribeDomainsBySourceResponse> DescribeDomainsBySourceWithOptionsAsync(DescribeDomainsBySourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainsBySource",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainsBySourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeDomainsBySourceRequest
          * @return DescribeDomainsBySourceResponse
         */
        public DescribeDomainsBySourceResponse DescribeDomainsBySource(DescribeDomainsBySourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsBySourceWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeDomainsBySourceRequest
          * @return DescribeDomainsBySourceResponse
         */
        public async Task<DescribeDomainsBySourceResponse> DescribeDomainsBySourceAsync(DescribeDomainsBySourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsBySourceWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 10 times per second per account.
          * *   If you do not set StartTime or EndTime, data within the last 24 hours is queried. If you set both StartTime and EndTime, data within the specified time range is queried.
          * *   You can query the monitoring data of a specific accelerated domain name or all accelerated domain names that belong to your Alibaba Cloud account.
          *
          * @param request DescribeDomainsUsageByDayRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainsUsageByDayResponse
         */
        public DescribeDomainsUsageByDayResponse DescribeDomainsUsageByDayWithOptions(DescribeDomainsUsageByDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainsUsageByDay",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainsUsageByDayResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 10 times per second per account.
          * *   If you do not set StartTime or EndTime, data within the last 24 hours is queried. If you set both StartTime and EndTime, data within the specified time range is queried.
          * *   You can query the monitoring data of a specific accelerated domain name or all accelerated domain names that belong to your Alibaba Cloud account.
          *
          * @param request DescribeDomainsUsageByDayRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDomainsUsageByDayResponse
         */
        public async Task<DescribeDomainsUsageByDayResponse> DescribeDomainsUsageByDayWithOptionsAsync(DescribeDomainsUsageByDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDomainsUsageByDay",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainsUsageByDayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 10 times per second per account.
          * *   If you do not set StartTime or EndTime, data within the last 24 hours is queried. If you set both StartTime and EndTime, data within the specified time range is queried.
          * *   You can query the monitoring data of a specific accelerated domain name or all accelerated domain names that belong to your Alibaba Cloud account.
          *
          * @param request DescribeDomainsUsageByDayRequest
          * @return DescribeDomainsUsageByDayResponse
         */
        public DescribeDomainsUsageByDayResponse DescribeDomainsUsageByDay(DescribeDomainsUsageByDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsUsageByDayWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 10 times per second per account.
          * *   If you do not set StartTime or EndTime, data within the last 24 hours is queried. If you set both StartTime and EndTime, data within the specified time range is queried.
          * *   You can query the monitoring data of a specific accelerated domain name or all accelerated domain names that belong to your Alibaba Cloud account.
          *
          * @param request DescribeDomainsUsageByDayRequest
          * @return DescribeDomainsUsageByDayResponse
         */
        public async Task<DescribeDomainsUsageByDayResponse> DescribeDomainsUsageByDayAsync(DescribeDomainsUsageByDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsUsageByDayWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeEsExceptionDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEsExceptionDataResponse
         */
        public DescribeEsExceptionDataResponse DescribeEsExceptionDataWithOptions(DescribeEsExceptionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeEsExceptionData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEsExceptionDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeEsExceptionDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEsExceptionDataResponse
         */
        public async Task<DescribeEsExceptionDataResponse> DescribeEsExceptionDataWithOptionsAsync(DescribeEsExceptionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeEsExceptionData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEsExceptionDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeEsExceptionDataRequest
          * @return DescribeEsExceptionDataResponse
         */
        public DescribeEsExceptionDataResponse DescribeEsExceptionData(DescribeEsExceptionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEsExceptionDataWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeEsExceptionDataRequest
          * @return DescribeEsExceptionDataResponse
         */
        public async Task<DescribeEsExceptionDataResponse> DescribeEsExceptionDataAsync(DescribeEsExceptionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEsExceptionDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeEsExecuteDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEsExecuteDataResponse
         */
        public DescribeEsExecuteDataResponse DescribeEsExecuteDataWithOptions(DescribeEsExecuteDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeEsExecuteData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEsExecuteDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeEsExecuteDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEsExecuteDataResponse
         */
        public async Task<DescribeEsExecuteDataResponse> DescribeEsExecuteDataWithOptionsAsync(DescribeEsExecuteDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeEsExecuteData",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEsExecuteDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeEsExecuteDataRequest
          * @return DescribeEsExecuteDataResponse
         */
        public DescribeEsExecuteDataResponse DescribeEsExecuteData(DescribeEsExecuteDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEsExecuteDataWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeEsExecuteDataRequest
          * @return DescribeEsExecuteDataResponse
         */
        public async Task<DescribeEsExecuteDataResponse> DescribeEsExecuteDataAsync(DescribeEsExecuteDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEsExecuteDataWithOptionsAsync(request, runtime);
        }

        public DescribeFCTriggerResponse DescribeFCTriggerWithOptions(DescribeFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFCTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFCTriggerResponse> DescribeFCTriggerWithOptionsAsync(DescribeFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFCTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFCTriggerResponse DescribeFCTrigger(DescribeFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFCTriggerWithOptions(request, runtime);
        }

        public async Task<DescribeFCTriggerResponse> DescribeFCTriggerAsync(DescribeFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFCTriggerWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeIpInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeIpInfoResponse
         */
        public DescribeIpInfoResponse DescribeIpInfoWithOptions(DescribeIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IP))
            {
                query["IP"] = request.IP;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpInfo",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeIpInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeIpInfoResponse
         */
        public async Task<DescribeIpInfoResponse> DescribeIpInfoWithOptionsAsync(DescribeIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IP))
            {
                query["IP"] = request.IP;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpInfo",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeIpInfoRequest
          * @return DescribeIpInfoResponse
         */
        public DescribeIpInfoResponse DescribeIpInfo(DescribeIpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpInfoWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeIpInfoRequest
          * @return DescribeIpInfoResponse
         */
        public async Task<DescribeIpInfoResponse> DescribeIpInfoAsync(DescribeIpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpInfoWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeIpStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeIpStatusResponse
         */
        public DescribeIpStatusResponse DescribeIpStatusWithOptions(DescribeIpStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpStatus",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeIpStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeIpStatusResponse
         */
        public async Task<DescribeIpStatusResponse> DescribeIpStatusWithOptionsAsync(DescribeIpStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpStatus",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeIpStatusRequest
          * @return DescribeIpStatusResponse
         */
        public DescribeIpStatusResponse DescribeIpStatus(DescribeIpStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpStatusWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 50 times per second per account.
          *
          * @param request DescribeIpStatusRequest
          * @return DescribeIpStatusResponse
         */
        public async Task<DescribeIpStatusResponse> DescribeIpStatusAsync(DescribeIpStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpStatusWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only to users whose daily peak bandwidth value is higher than 1 Gbit/s. If you meet this requirement, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex) to apply for permissions to use this operation.
          * *   You can call this operation up to 40 times per second per account.
          *
          * @param request DescribeL2VipsByDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeL2VipsByDomainResponse
         */
        public DescribeL2VipsByDomainResponse DescribeL2VipsByDomainWithOptions(DescribeL2VipsByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeL2VipsByDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeL2VipsByDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only to users whose daily peak bandwidth value is higher than 1 Gbit/s. If you meet this requirement, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex) to apply for permissions to use this operation.
          * *   You can call this operation up to 40 times per second per account.
          *
          * @param request DescribeL2VipsByDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeL2VipsByDomainResponse
         */
        public async Task<DescribeL2VipsByDomainResponse> DescribeL2VipsByDomainWithOptionsAsync(DescribeL2VipsByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeL2VipsByDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeL2VipsByDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only to users whose daily peak bandwidth value is higher than 1 Gbit/s. If you meet this requirement, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex) to apply for permissions to use this operation.
          * *   You can call this operation up to 40 times per second per account.
          *
          * @param request DescribeL2VipsByDomainRequest
          * @return DescribeL2VipsByDomainResponse
         */
        public DescribeL2VipsByDomainResponse DescribeL2VipsByDomain(DescribeL2VipsByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeL2VipsByDomainWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only to users whose daily peak bandwidth value is higher than 1 Gbit/s. If you meet this requirement, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex) to apply for permissions to use this operation.
          * *   You can call this operation up to 40 times per second per account.
          *
          * @param request DescribeL2VipsByDomainRequest
          * @return DescribeL2VipsByDomainResponse
         */
        public async Task<DescribeL2VipsByDomainResponse> DescribeL2VipsByDomainAsync(DescribeL2VipsByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeL2VipsByDomainWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can query data within the last 3 days.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribePreloadDetailByIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePreloadDetailByIdResponse
         */
        public DescribePreloadDetailByIdResponse DescribePreloadDetailByIdWithOptions(DescribePreloadDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribePreloadDetailById",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreloadDetailByIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can query data within the last 3 days.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribePreloadDetailByIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePreloadDetailByIdResponse
         */
        public async Task<DescribePreloadDetailByIdResponse> DescribePreloadDetailByIdWithOptionsAsync(DescribePreloadDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribePreloadDetailById",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreloadDetailByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can query data within the last 3 days.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribePreloadDetailByIdRequest
          * @return DescribePreloadDetailByIdResponse
         */
        public DescribePreloadDetailByIdResponse DescribePreloadDetailById(DescribePreloadDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePreloadDetailByIdWithOptions(request, runtime);
        }

        /**
          * *   You can query data within the last 3 days.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribePreloadDetailByIdRequest
          * @return DescribePreloadDetailByIdResponse
         */
        public async Task<DescribePreloadDetailByIdResponse> DescribePreloadDetailByIdAsync(DescribePreloadDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePreloadDetailByIdWithOptionsAsync(request, runtime);
        }

        /**
          * *   The data is collected every 5 minutes.
          * *   You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeRangeDataByLocateAndIspServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRangeDataByLocateAndIspServiceResponse
         */
        public DescribeRangeDataByLocateAndIspServiceResponse DescribeRangeDataByLocateAndIspServiceWithOptions(DescribeRangeDataByLocateAndIspServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNames))
            {
                query["IspNames"] = request.IspNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNames))
            {
                query["LocationNames"] = request.LocationNames;
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
                Action = "DescribeRangeDataByLocateAndIspService",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRangeDataByLocateAndIspServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   The data is collected every 5 minutes.
          * *   You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeRangeDataByLocateAndIspServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRangeDataByLocateAndIspServiceResponse
         */
        public async Task<DescribeRangeDataByLocateAndIspServiceResponse> DescribeRangeDataByLocateAndIspServiceWithOptionsAsync(DescribeRangeDataByLocateAndIspServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNames))
            {
                query["IspNames"] = request.IspNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNames))
            {
                query["LocationNames"] = request.LocationNames;
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
                Action = "DescribeRangeDataByLocateAndIspService",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRangeDataByLocateAndIspServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   The data is collected every 5 minutes.
          * *   You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeRangeDataByLocateAndIspServiceRequest
          * @return DescribeRangeDataByLocateAndIspServiceResponse
         */
        public DescribeRangeDataByLocateAndIspServiceResponse DescribeRangeDataByLocateAndIspService(DescribeRangeDataByLocateAndIspServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRangeDataByLocateAndIspServiceWithOptions(request, runtime);
        }

        /**
          * *   The data is collected every 5 minutes.
          * *   You can call this operation up to 20 times per second per account.
          *
          * @param request DescribeRangeDataByLocateAndIspServiceRequest
          * @return DescribeRangeDataByLocateAndIspServiceResponse
         */
        public async Task<DescribeRangeDataByLocateAndIspServiceResponse> DescribeRangeDataByLocateAndIspServiceAsync(DescribeRangeDataByLocateAndIspServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRangeDataByLocateAndIspServiceWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeRealtimeDeliveryAccRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRealtimeDeliveryAccResponse
         */
        public DescribeRealtimeDeliveryAccResponse DescribeRealtimeDeliveryAccWithOptions(DescribeRealtimeDeliveryAccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                query["LogStore"] = request.LogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "DescribeRealtimeDeliveryAcc",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRealtimeDeliveryAccResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeRealtimeDeliveryAccRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRealtimeDeliveryAccResponse
         */
        public async Task<DescribeRealtimeDeliveryAccResponse> DescribeRealtimeDeliveryAccWithOptionsAsync(DescribeRealtimeDeliveryAccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                query["LogStore"] = request.LogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "DescribeRealtimeDeliveryAcc",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRealtimeDeliveryAccResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeRealtimeDeliveryAccRequest
          * @return DescribeRealtimeDeliveryAccResponse
         */
        public DescribeRealtimeDeliveryAccResponse DescribeRealtimeDeliveryAcc(DescribeRealtimeDeliveryAccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRealtimeDeliveryAccWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeRealtimeDeliveryAccRequest
          * @return DescribeRealtimeDeliveryAccResponse
         */
        public async Task<DescribeRealtimeDeliveryAccResponse> DescribeRealtimeDeliveryAccAsync(DescribeRealtimeDeliveryAccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRealtimeDeliveryAccWithOptionsAsync(request, runtime);
        }

        /**
          * Queries the maximum and remaining numbers of URLs and directories that can be refreshed, the maximum and remaining numbers of times that you can prefetch content, and the maximum and remaining numbers of URLs and directories that can be blocked on the current day.
          *
          * @param request DescribeRefreshQuotaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRefreshQuotaResponse
         */
        public DescribeRefreshQuotaResponse DescribeRefreshQuotaWithOptions(DescribeRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeRefreshQuota",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRefreshQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Queries the maximum and remaining numbers of URLs and directories that can be refreshed, the maximum and remaining numbers of times that you can prefetch content, and the maximum and remaining numbers of URLs and directories that can be blocked on the current day.
          *
          * @param request DescribeRefreshQuotaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRefreshQuotaResponse
         */
        public async Task<DescribeRefreshQuotaResponse> DescribeRefreshQuotaWithOptionsAsync(DescribeRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeRefreshQuota",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRefreshQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Queries the maximum and remaining numbers of URLs and directories that can be refreshed, the maximum and remaining numbers of times that you can prefetch content, and the maximum and remaining numbers of URLs and directories that can be blocked on the current day.
          *
          * @param request DescribeRefreshQuotaRequest
          * @return DescribeRefreshQuotaResponse
         */
        public DescribeRefreshQuotaResponse DescribeRefreshQuota(DescribeRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRefreshQuotaWithOptions(request, runtime);
        }

        /**
          * Queries the maximum and remaining numbers of URLs and directories that can be refreshed, the maximum and remaining numbers of times that you can prefetch content, and the maximum and remaining numbers of URLs and directories that can be blocked on the current day.
          *
          * @param request DescribeRefreshQuotaRequest
          * @return DescribeRefreshQuotaResponse
         */
        public async Task<DescribeRefreshQuotaResponse> DescribeRefreshQuotaAsync(DescribeRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRefreshQuotaWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can query data in the last three days.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeRefreshTaskByIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRefreshTaskByIdResponse
         */
        public DescribeRefreshTaskByIdResponse DescribeRefreshTaskByIdWithOptions(DescribeRefreshTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRefreshTaskById",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRefreshTaskByIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can query data in the last three days.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeRefreshTaskByIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRefreshTaskByIdResponse
         */
        public async Task<DescribeRefreshTaskByIdResponse> DescribeRefreshTaskByIdWithOptionsAsync(DescribeRefreshTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRefreshTaskById",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRefreshTaskByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can query data in the last three days.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeRefreshTaskByIdRequest
          * @return DescribeRefreshTaskByIdResponse
         */
        public DescribeRefreshTaskByIdResponse DescribeRefreshTaskById(DescribeRefreshTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRefreshTaskByIdWithOptions(request, runtime);
        }

        /**
          * *   You can query data in the last three days.
          * *   You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeRefreshTaskByIdRequest
          * @return DescribeRefreshTaskByIdResponse
         */
        public async Task<DescribeRefreshTaskByIdResponse> DescribeRefreshTaskByIdAsync(DescribeRefreshTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRefreshTaskByIdWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can query the status of tasks by task ID or URL.
          * *   You can set both the **TaskId** and **ObjectPath** parameters. If you do not set the **TaskId** or **ObjectPath** parameter, data entries on the first page (20 entries) collected in the last 3 days are returned.
          * *   You can query data collected in the last 3 days.
          * *   If auto CDN cache update is enabled in the Object Storage Service (OSS) console, you cannot call the DescribeRefreshTasks operation to query automatic refresh tasks in OSS.
          * *   You can call this operation up to 10 times per second per account. If you want to query tasks at a higher frequency, call the [DescribeRefreshTaskById](~~187709~~) operation. This operation allows you to query tasks by task ID.
          *
          * @param request DescribeRefreshTasksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRefreshTasksResponse
         */
        public DescribeRefreshTasksResponse DescribeRefreshTasksWithOptions(DescribeRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "DescribeRefreshTasks",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRefreshTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can query the status of tasks by task ID or URL.
          * *   You can set both the **TaskId** and **ObjectPath** parameters. If you do not set the **TaskId** or **ObjectPath** parameter, data entries on the first page (20 entries) collected in the last 3 days are returned.
          * *   You can query data collected in the last 3 days.
          * *   If auto CDN cache update is enabled in the Object Storage Service (OSS) console, you cannot call the DescribeRefreshTasks operation to query automatic refresh tasks in OSS.
          * *   You can call this operation up to 10 times per second per account. If you want to query tasks at a higher frequency, call the [DescribeRefreshTaskById](~~187709~~) operation. This operation allows you to query tasks by task ID.
          *
          * @param request DescribeRefreshTasksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRefreshTasksResponse
         */
        public async Task<DescribeRefreshTasksResponse> DescribeRefreshTasksWithOptionsAsync(DescribeRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "DescribeRefreshTasks",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRefreshTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can query the status of tasks by task ID or URL.
          * *   You can set both the **TaskId** and **ObjectPath** parameters. If you do not set the **TaskId** or **ObjectPath** parameter, data entries on the first page (20 entries) collected in the last 3 days are returned.
          * *   You can query data collected in the last 3 days.
          * *   If auto CDN cache update is enabled in the Object Storage Service (OSS) console, you cannot call the DescribeRefreshTasks operation to query automatic refresh tasks in OSS.
          * *   You can call this operation up to 10 times per second per account. If you want to query tasks at a higher frequency, call the [DescribeRefreshTaskById](~~187709~~) operation. This operation allows you to query tasks by task ID.
          *
          * @param request DescribeRefreshTasksRequest
          * @return DescribeRefreshTasksResponse
         */
        public DescribeRefreshTasksResponse DescribeRefreshTasks(DescribeRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRefreshTasksWithOptions(request, runtime);
        }

        /**
          * *   You can query the status of tasks by task ID or URL.
          * *   You can set both the **TaskId** and **ObjectPath** parameters. If you do not set the **TaskId** or **ObjectPath** parameter, data entries on the first page (20 entries) collected in the last 3 days are returned.
          * *   You can query data collected in the last 3 days.
          * *   If auto CDN cache update is enabled in the Object Storage Service (OSS) console, you cannot call the DescribeRefreshTasks operation to query automatic refresh tasks in OSS.
          * *   You can call this operation up to 10 times per second per account. If you want to query tasks at a higher frequency, call the [DescribeRefreshTaskById](~~187709~~) operation. This operation allows you to query tasks by task ID.
          *
          * @param request DescribeRefreshTasksRequest
          * @return DescribeRefreshTasksResponse
         */
        public async Task<DescribeRefreshTasksResponse> DescribeRefreshTasksAsync(DescribeRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRefreshTasksWithOptionsAsync(request, runtime);
        }

        /**
          * >The maximum number of times that each user can call this operation per second is 30.
          *
          * @param request DescribeStagingIpRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeStagingIpResponse
         */
        public DescribeStagingIpResponse DescribeStagingIpWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStagingIp",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStagingIpResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >The maximum number of times that each user can call this operation per second is 30.
          *
          * @param request DescribeStagingIpRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeStagingIpResponse
         */
        public async Task<DescribeStagingIpResponse> DescribeStagingIpWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStagingIp",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStagingIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >The maximum number of times that each user can call this operation per second is 30.
          *
          * @return DescribeStagingIpResponse
         */
        public DescribeStagingIpResponse DescribeStagingIp()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStagingIpWithOptions(runtime);
        }

        /**
          * >The maximum number of times that each user can call this operation per second is 30.
          *
          * @return DescribeStagingIpResponse
         */
        public async Task<DescribeStagingIpResponse> DescribeStagingIpAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStagingIpWithOptionsAsync(runtime);
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 10.
          *
          * @param request DescribeTagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTagResourcesResponse
         */
        public DescribeTagResourcesResponse DescribeTagResourcesWithOptions(DescribeTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeTagResources",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 10.
          *
          * @param request DescribeTagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTagResourcesResponse
         */
        public async Task<DescribeTagResourcesResponse> DescribeTagResourcesWithOptionsAsync(DescribeTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeTagResources",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 10.
          *
          * @param request DescribeTagResourcesRequest
          * @return DescribeTagResourcesResponse
         */
        public DescribeTagResourcesResponse DescribeTagResources(DescribeTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagResourcesWithOptions(request, runtime);
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 10.
          *
          * @param request DescribeTagResourcesRequest
          * @return DescribeTagResourcesResponse
         */
        public async Task<DescribeTagResourcesResponse> DescribeTagResourcesAsync(DescribeTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set the **StartTime** or **EndTime** parameter, the request returns the data collected in the current month. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeTopDomainsByFlowRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTopDomainsByFlowResponse
         */
        public DescribeTopDomainsByFlowResponse DescribeTopDomainsByFlowWithOptions(DescribeTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeTopDomainsByFlow",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopDomainsByFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set the **StartTime** or **EndTime** parameter, the request returns the data collected in the current month. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeTopDomainsByFlowRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTopDomainsByFlowResponse
         */
        public async Task<DescribeTopDomainsByFlowResponse> DescribeTopDomainsByFlowWithOptionsAsync(DescribeTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeTopDomainsByFlow",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopDomainsByFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set the **StartTime** or **EndTime** parameter, the request returns the data collected in the current month. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeTopDomainsByFlowRequest
          * @return DescribeTopDomainsByFlowResponse
         */
        public DescribeTopDomainsByFlowResponse DescribeTopDomainsByFlow(DescribeTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopDomainsByFlowWithOptions(request, runtime);
        }

        /**
          * The statistical analysis feature of Alibaba Cloud CDN is no longer available. The API operations related to the statistical analysis feature are no longer maintained. We recommend that you do not use the API operations because data may be missing or inaccurate. You can use the [operations report](~~279577~~) feature for data analysis.
          * > *   If you do not set the **StartTime** or **EndTime** parameter, the request returns the data collected in the current month. If you set both these parameters, the request returns the data collected within the specified time range.
          * >*   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeTopDomainsByFlowRequest
          * @return DescribeTopDomainsByFlowResponse
         */
        public async Task<DescribeTopDomainsByFlowResponse> DescribeTopDomainsByFlowAsync(DescribeTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopDomainsByFlowWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserCertificateExpireCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserCertificateExpireCountResponse
         */
        public DescribeUserCertificateExpireCountResponse DescribeUserCertificateExpireCountWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserCertificateExpireCount",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserCertificateExpireCountResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserCertificateExpireCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserCertificateExpireCountResponse
         */
        public async Task<DescribeUserCertificateExpireCountResponse> DescribeUserCertificateExpireCountWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserCertificateExpireCount",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserCertificateExpireCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @return DescribeUserCertificateExpireCountResponse
         */
        public DescribeUserCertificateExpireCountResponse DescribeUserCertificateExpireCount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserCertificateExpireCountWithOptions(runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @return DescribeUserCertificateExpireCountResponse
         */
        public async Task<DescribeUserCertificateExpireCountResponse> DescribeUserCertificateExpireCountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserCertificateExpireCountWithOptionsAsync(runtime);
        }

        /**
          * @deprecated
          *
          * @param request DescribeUserConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserConfigsResponse
         */
        // Deprecated
        public DescribeUserConfigsResponse DescribeUserConfigsWithOptions(DescribeUserConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
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
                Action = "DescribeUserConfigs",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request DescribeUserConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserConfigsResponse
         */
        // Deprecated
        public async Task<DescribeUserConfigsResponse> DescribeUserConfigsWithOptionsAsync(DescribeUserConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
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
                Action = "DescribeUserConfigs",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request DescribeUserConfigsRequest
          * @return DescribeUserConfigsResponse
         */
        // Deprecated
        public DescribeUserConfigsResponse DescribeUserConfigs(DescribeUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserConfigsWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request DescribeUserConfigsRequest
          * @return DescribeUserConfigsResponse
         */
        // Deprecated
        public async Task<DescribeUserConfigsResponse> DescribeUserConfigsAsync(DescribeUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserConfigsWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          * *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request DescribeUserDomainsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserDomainsResponse
         */
        public DescribeUserDomainsResponse DescribeUserDomainsWithOptions(DescribeUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CdnType))
            {
                query["CdnType"] = request.CdnType;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
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
                Action = "DescribeUserDomains",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          * *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request DescribeUserDomainsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserDomainsResponse
         */
        public async Task<DescribeUserDomainsResponse> DescribeUserDomainsWithOptionsAsync(DescribeUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CdnType))
            {
                query["CdnType"] = request.CdnType;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
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
                Action = "DescribeUserDomains",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          * *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request DescribeUserDomainsRequest
          * @return DescribeUserDomainsResponse
         */
        public DescribeUserDomainsResponse DescribeUserDomains(DescribeUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserDomainsWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 100 times per second per account.
          * *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
          *
          * @param request DescribeUserDomainsRequest
          * @return DescribeUserDomainsResponse
         */
        public async Task<DescribeUserDomainsResponse> DescribeUserDomainsAsync(DescribeUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserDomainsWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserTagsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserTagsResponse
         */
        public DescribeUserTagsResponse DescribeUserTagsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserTags",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserTagsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserTagsResponse
         */
        public async Task<DescribeUserTagsResponse> DescribeUserTagsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserTags",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @return DescribeUserTagsResponse
         */
        public DescribeUserTagsResponse DescribeUserTags()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserTagsWithOptions(runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @return DescribeUserTagsResponse
         */
        public async Task<DescribeUserTagsResponse> DescribeUserTagsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserTagsWithOptionsAsync(runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserUsageDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserUsageDataExportTaskResponse
         */
        public DescribeUserUsageDataExportTaskResponse DescribeUserUsageDataExportTaskWithOptions(DescribeUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeUserUsageDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserUsageDataExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserUsageDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserUsageDataExportTaskResponse
         */
        public async Task<DescribeUserUsageDataExportTaskResponse> DescribeUserUsageDataExportTaskWithOptionsAsync(DescribeUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeUserUsageDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserUsageDataExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserUsageDataExportTaskRequest
          * @return DescribeUserUsageDataExportTaskResponse
         */
        public DescribeUserUsageDataExportTaskResponse DescribeUserUsageDataExportTask(DescribeUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserUsageDataExportTaskWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserUsageDataExportTaskRequest
          * @return DescribeUserUsageDataExportTaskResponse
         */
        public async Task<DescribeUserUsageDataExportTaskResponse> DescribeUserUsageDataExportTaskAsync(DescribeUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserUsageDataExportTaskWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation has been available since July 20, 2018. You can query information about resource usage collected within the last three months.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserUsageDetailDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserUsageDetailDataExportTaskResponse
         */
        public DescribeUserUsageDetailDataExportTaskResponse DescribeUserUsageDetailDataExportTaskWithOptions(DescribeUserUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeUserUsageDetailDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserUsageDetailDataExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation has been available since July 20, 2018. You can query information about resource usage collected within the last three months.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserUsageDetailDataExportTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserUsageDetailDataExportTaskResponse
         */
        public async Task<DescribeUserUsageDetailDataExportTaskResponse> DescribeUserUsageDetailDataExportTaskWithOptionsAsync(DescribeUserUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeUserUsageDetailDataExportTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserUsageDetailDataExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation has been available since July 20, 2018. You can query information about resource usage collected within the last three months.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserUsageDetailDataExportTaskRequest
          * @return DescribeUserUsageDetailDataExportTaskResponse
         */
        public DescribeUserUsageDetailDataExportTaskResponse DescribeUserUsageDetailDataExportTask(DescribeUserUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserUsageDetailDataExportTaskWithOptions(request, runtime);
        }

        /**
          * *   This operation has been available since July 20, 2018. You can query information about resource usage collected within the last three months.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request DescribeUserUsageDetailDataExportTaskRequest
          * @return DescribeUserUsageDetailDataExportTaskResponse
         */
        public async Task<DescribeUserUsageDetailDataExportTaskResponse> DescribeUserUsageDetailDataExportTaskAsync(DescribeUserUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserUsageDetailDataExportTaskWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeUserVipsByDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserVipsByDomainResponse
         */
        public DescribeUserVipsByDomainResponse DescribeUserVipsByDomainWithOptions(DescribeUserVipsByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserVipsByDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserVipsByDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeUserVipsByDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeUserVipsByDomainResponse
         */
        public async Task<DescribeUserVipsByDomainResponse> DescribeUserVipsByDomainWithOptionsAsync(DescribeUserVipsByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserVipsByDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserVipsByDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeUserVipsByDomainRequest
          * @return DescribeUserVipsByDomainResponse
         */
        public DescribeUserVipsByDomainResponse DescribeUserVipsByDomain(DescribeUserVipsByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserVipsByDomainWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request DescribeUserVipsByDomainRequest
          * @return DescribeUserVipsByDomainResponse
         */
        public async Task<DescribeUserVipsByDomainResponse> DescribeUserVipsByDomainAsync(DescribeUserVipsByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserVipsByDomainWithOptionsAsync(request, runtime);
        }

        public DescribeVerifyContentResponse DescribeVerifyContentWithOptions(DescribeVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVerifyContent",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifyContentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVerifyContentResponse> DescribeVerifyContentWithOptionsAsync(DescribeVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVerifyContent",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifyContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVerifyContentResponse DescribeVerifyContent(DescribeVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyContentWithOptions(request, runtime);
        }

        public async Task<DescribeVerifyContentResponse> DescribeVerifyContentAsync(DescribeVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyContentWithOptionsAsync(request, runtime);
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request DisableRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableRealtimeLogDeliveryResponse
         */
        public DisableRealtimeLogDeliveryResponse DisableRealtimeLogDeliveryWithOptions(DisableRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request DisableRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableRealtimeLogDeliveryResponse
         */
        public async Task<DisableRealtimeLogDeliveryResponse> DisableRealtimeLogDeliveryWithOptionsAsync(DisableRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request DisableRealtimeLogDeliveryRequest
          * @return DisableRealtimeLogDeliveryResponse
         */
        public DisableRealtimeLogDeliveryResponse DisableRealtimeLogDelivery(DisableRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableRealtimeLogDeliveryWithOptions(request, runtime);
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request DisableRealtimeLogDeliveryRequest
          * @return DisableRealtimeLogDeliveryResponse
         */
        public async Task<DisableRealtimeLogDeliveryResponse> DisableRealtimeLogDeliveryAsync(DisableRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request EnableRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableRealtimeLogDeliveryResponse
         */
        public EnableRealtimeLogDeliveryResponse EnableRealtimeLogDeliveryWithOptions(EnableRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request EnableRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableRealtimeLogDeliveryResponse
         */
        public async Task<EnableRealtimeLogDeliveryResponse> EnableRealtimeLogDeliveryWithOptionsAsync(EnableRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request EnableRealtimeLogDeliveryRequest
          * @return EnableRealtimeLogDeliveryResponse
         */
        public EnableRealtimeLogDeliveryResponse EnableRealtimeLogDelivery(EnableRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableRealtimeLogDeliveryWithOptions(request, runtime);
        }

        /**
          * >  The maximum number of times that each user can call this operation per second is 100.
          *
          * @param request EnableRealtimeLogDeliveryRequest
          * @return EnableRealtimeLogDeliveryResponse
         */
        public async Task<EnableRealtimeLogDeliveryResponse> EnableRealtimeLogDeliveryAsync(EnableRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListDomainsByLogConfigIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDomainsByLogConfigIdResponse
         */
        public ListDomainsByLogConfigIdResponse ListDomainsByLogConfigIdWithOptions(ListDomainsByLogConfigIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomainsByLogConfigId",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsByLogConfigIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListDomainsByLogConfigIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDomainsByLogConfigIdResponse
         */
        public async Task<ListDomainsByLogConfigIdResponse> ListDomainsByLogConfigIdWithOptionsAsync(ListDomainsByLogConfigIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomainsByLogConfigId",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsByLogConfigIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListDomainsByLogConfigIdRequest
          * @return ListDomainsByLogConfigIdResponse
         */
        public ListDomainsByLogConfigIdResponse ListDomainsByLogConfigId(ListDomainsByLogConfigIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDomainsByLogConfigIdWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListDomainsByLogConfigIdRequest
          * @return ListDomainsByLogConfigIdResponse
         */
        public async Task<ListDomainsByLogConfigIdResponse> ListDomainsByLogConfigIdAsync(ListDomainsByLogConfigIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDomainsByLogConfigIdWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListFCTriggerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListFCTriggerResponse
         */
        public ListFCTriggerResponse ListFCTriggerWithOptions(ListFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFCTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListFCTriggerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListFCTriggerResponse
         */
        public async Task<ListFCTriggerResponse> ListFCTriggerWithOptionsAsync(ListFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFCTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListFCTriggerRequest
          * @return ListFCTriggerResponse
         */
        public ListFCTriggerResponse ListFCTrigger(ListFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFCTriggerWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListFCTriggerRequest
          * @return ListFCTriggerResponse
         */
        public async Task<ListFCTriggerResponse> ListFCTriggerAsync(ListFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFCTriggerWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListRealtimeLogDeliveryDomainsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRealtimeLogDeliveryDomainsResponse
         */
        public ListRealtimeLogDeliveryDomainsResponse ListRealtimeLogDeliveryDomainsWithOptions(ListRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRealtimeLogDeliveryDomains",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRealtimeLogDeliveryDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListRealtimeLogDeliveryDomainsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRealtimeLogDeliveryDomainsResponse
         */
        public async Task<ListRealtimeLogDeliveryDomainsResponse> ListRealtimeLogDeliveryDomainsWithOptionsAsync(ListRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRealtimeLogDeliveryDomains",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRealtimeLogDeliveryDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListRealtimeLogDeliveryDomainsRequest
          * @return ListRealtimeLogDeliveryDomainsResponse
         */
        public ListRealtimeLogDeliveryDomainsResponse ListRealtimeLogDeliveryDomains(ListRealtimeLogDeliveryDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealtimeLogDeliveryDomainsWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListRealtimeLogDeliveryDomainsRequest
          * @return ListRealtimeLogDeliveryDomainsResponse
         */
        public async Task<ListRealtimeLogDeliveryDomainsResponse> ListRealtimeLogDeliveryDomainsAsync(ListRealtimeLogDeliveryDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealtimeLogDeliveryDomainsWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListRealtimeLogDeliveryInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRealtimeLogDeliveryInfosResponse
         */
        public ListRealtimeLogDeliveryInfosResponse ListRealtimeLogDeliveryInfosWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRealtimeLogDeliveryInfos",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRealtimeLogDeliveryInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListRealtimeLogDeliveryInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRealtimeLogDeliveryInfosResponse
         */
        public async Task<ListRealtimeLogDeliveryInfosResponse> ListRealtimeLogDeliveryInfosWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRealtimeLogDeliveryInfos",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRealtimeLogDeliveryInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @return ListRealtimeLogDeliveryInfosResponse
         */
        public ListRealtimeLogDeliveryInfosResponse ListRealtimeLogDeliveryInfos()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealtimeLogDeliveryInfosWithOptions(runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @return ListRealtimeLogDeliveryInfosResponse
         */
        public async Task<ListRealtimeLogDeliveryInfosResponse> ListRealtimeLogDeliveryInfosAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealtimeLogDeliveryInfosWithOptionsAsync(runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagOwnerBid))
            {
                query["TagOwnerBid"] = request.TagOwnerBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagOwnerUid))
            {
                query["TagOwnerUid"] = request.TagOwnerUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2018-05-10",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagOwnerBid))
            {
                query["TagOwnerBid"] = request.TagOwnerBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagOwnerUid))
            {
                query["TagOwnerUid"] = request.TagOwnerUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2018-05-10",
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

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListUserCustomLogConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListUserCustomLogConfigResponse
         */
        public ListUserCustomLogConfigResponse ListUserCustomLogConfigWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserCustomLogConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserCustomLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ListUserCustomLogConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListUserCustomLogConfigResponse
         */
        public async Task<ListUserCustomLogConfigResponse> ListUserCustomLogConfigWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserCustomLogConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserCustomLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @return ListUserCustomLogConfigResponse
         */
        public ListUserCustomLogConfigResponse ListUserCustomLogConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserCustomLogConfigWithOptions(runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @return ListUserCustomLogConfigResponse
         */
        public async Task<ListUserCustomLogConfigResponse> ListUserCustomLogConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserCustomLogConfigWithOptionsAsync(runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request ModifyCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyCdnDomainResponse
         */
        public ModifyCdnDomainResponse ModifyCdnDomainWithOptions(ModifyCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModifyCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request ModifyCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyCdnDomainResponse
         */
        public async Task<ModifyCdnDomainResponse> ModifyCdnDomainWithOptionsAsync(ModifyCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModifyCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request ModifyCdnDomainRequest
          * @return ModifyCdnDomainResponse
         */
        public ModifyCdnDomainResponse ModifyCdnDomain(ModifyCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCdnDomainWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request ModifyCdnDomainRequest
          * @return ModifyCdnDomainResponse
         */
        public async Task<ModifyCdnDomainResponse> ModifyCdnDomainAsync(ModifyCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCdnDomainWithOptionsAsync(request, runtime);
        }

        public ModifyCdnDomainOwnerResponse ModifyCdnDomainOwnerWithOptions(ModifyCdnDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModifyCdnDomainOwner",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCdnDomainOwnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyCdnDomainOwnerResponse> ModifyCdnDomainOwnerWithOptionsAsync(ModifyCdnDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModifyCdnDomainOwner",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCdnDomainOwnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyCdnDomainOwnerResponse ModifyCdnDomainOwner(ModifyCdnDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCdnDomainOwnerWithOptions(request, runtime);
        }

        public async Task<ModifyCdnDomainOwnerResponse> ModifyCdnDomainOwnerAsync(ModifyCdnDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCdnDomainOwnerWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ModifyCdnDomainSchdmByPropertyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyCdnDomainSchdmByPropertyResponse
         */
        public ModifyCdnDomainSchdmByPropertyResponse ModifyCdnDomainSchdmByPropertyWithOptions(ModifyCdnDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "ModifyCdnDomainSchdmByProperty",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCdnDomainSchdmByPropertyResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ModifyCdnDomainSchdmByPropertyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyCdnDomainSchdmByPropertyResponse
         */
        public async Task<ModifyCdnDomainSchdmByPropertyResponse> ModifyCdnDomainSchdmByPropertyWithOptionsAsync(ModifyCdnDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "ModifyCdnDomainSchdmByProperty",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCdnDomainSchdmByPropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ModifyCdnDomainSchdmByPropertyRequest
          * @return ModifyCdnDomainSchdmByPropertyResponse
         */
        public ModifyCdnDomainSchdmByPropertyResponse ModifyCdnDomainSchdmByProperty(ModifyCdnDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCdnDomainSchdmByPropertyWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ModifyCdnDomainSchdmByPropertyRequest
          * @return ModifyCdnDomainSchdmByPropertyResponse
         */
        public async Task<ModifyCdnDomainSchdmByPropertyResponse> ModifyCdnDomainSchdmByPropertyAsync(ModifyCdnDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCdnDomainSchdmByPropertyWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ModifyRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyRealtimeLogDeliveryResponse
         */
        public ModifyRealtimeLogDeliveryResponse ModifyRealtimeLogDeliveryWithOptions(ModifyRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ModifyRealtimeLogDeliveryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyRealtimeLogDeliveryResponse
         */
        public async Task<ModifyRealtimeLogDeliveryResponse> ModifyRealtimeLogDeliveryWithOptionsAsync(ModifyRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRealtimeLogDelivery",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ModifyRealtimeLogDeliveryRequest
          * @return ModifyRealtimeLogDeliveryResponse
         */
        public ModifyRealtimeLogDeliveryResponse ModifyRealtimeLogDelivery(ModifyRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRealtimeLogDeliveryWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request ModifyRealtimeLogDeliveryRequest
          * @return ModifyRealtimeLogDeliveryResponse
         */
        public async Task<ModifyRealtimeLogDeliveryResponse> ModifyRealtimeLogDeliveryAsync(ModifyRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        /**
          * *   Alibaba Cloud CDN can be activated only once per Alibaba Cloud account. The Alibaba Cloud account must complete real-name verification to activate Alibaba Cloud CDN.
          * *   You can call this operation up to five times per second per user.
          *
          * @param request OpenCdnServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OpenCdnServiceResponse
         */
        public OpenCdnServiceResponse OpenCdnServiceWithOptions(OpenCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
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
                Action = "OpenCdnService",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenCdnServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Alibaba Cloud CDN can be activated only once per Alibaba Cloud account. The Alibaba Cloud account must complete real-name verification to activate Alibaba Cloud CDN.
          * *   You can call this operation up to five times per second per user.
          *
          * @param request OpenCdnServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OpenCdnServiceResponse
         */
        public async Task<OpenCdnServiceResponse> OpenCdnServiceWithOptionsAsync(OpenCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
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
                Action = "OpenCdnService",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenCdnServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Alibaba Cloud CDN can be activated only once per Alibaba Cloud account. The Alibaba Cloud account must complete real-name verification to activate Alibaba Cloud CDN.
          * *   You can call this operation up to five times per second per user.
          *
          * @param request OpenCdnServiceRequest
          * @return OpenCdnServiceResponse
         */
        public OpenCdnServiceResponse OpenCdnService(OpenCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenCdnServiceWithOptions(request, runtime);
        }

        /**
          * *   Alibaba Cloud CDN can be activated only once per Alibaba Cloud account. The Alibaba Cloud account must complete real-name verification to activate Alibaba Cloud CDN.
          * *   You can call this operation up to five times per second per user.
          *
          * @param request OpenCdnServiceRequest
          * @return OpenCdnServiceResponse
         */
        public async Task<OpenCdnServiceResponse> OpenCdnServiceAsync(OpenCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenCdnServiceWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request PublishStagingConfigToProductionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PublishStagingConfigToProductionResponse
         */
        public PublishStagingConfigToProductionResponse PublishStagingConfigToProductionWithOptions(PublishStagingConfigToProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishStagingConfigToProduction",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishStagingConfigToProductionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request PublishStagingConfigToProductionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PublishStagingConfigToProductionResponse
         */
        public async Task<PublishStagingConfigToProductionResponse> PublishStagingConfigToProductionWithOptionsAsync(PublishStagingConfigToProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishStagingConfigToProduction",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishStagingConfigToProductionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request PublishStagingConfigToProductionRequest
          * @return PublishStagingConfigToProductionResponse
         */
        public PublishStagingConfigToProductionResponse PublishStagingConfigToProduction(PublishStagingConfigToProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishStagingConfigToProductionWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request PublishStagingConfigToProductionRequest
          * @return PublishStagingConfigToProductionResponse
         */
        public async Task<PublishStagingConfigToProductionResponse> PublishStagingConfigToProductionAsync(PublishStagingConfigToProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishStagingConfigToProductionWithOptionsAsync(request, runtime);
        }

        /**
          * *   Alibaba Cloud CDN supports POST requests in which parameters are sent as a form.
          * *   You can call the [RefreshObjectCaches](~~91164~~) operation to refresh content and call the [PushObjectCache](~~91161~~) operation to prefetch content.
          * *   By default, each Alibaba Cloud account can submit up to 1,000 URLs per day. If the daily peak bandwidth value of your workloads exceeds 200 Mbit/s, you can [submit a ticket](https://account.alibabacloud.com/login/login.htm?oauth_callback=https%3A//ticket-intl.console.aliyun.com/%23/ticket/createIndex) to increase your daily quota. Alibaba Cloud reviews your application and then increases the quota accordingly.
          * *   You can specify at most 100 URLs in each prefetch request.
          * *   For each Alibaba Cloud account, the prefetch queue can contain up to 50,000 URLs. Content is prefetched based on the time when the URLs are submitted. The URL that is submitted the earliest has the highest priority. If the number of URLs in the queue reaches 50,000, you cannot submit more URLs until the number drops below 50,000.
          * *   You can call this operation up to 50 times per second per account.
          * *   For more information about how to automate refresh or prefetch tasks, see [Run scripts to refresh and prefetch content](~~151829~~).
          * ## Precautions
          * *   After a prefetch task is submitted and completed, the POPs immediately start to retrieve resources from the origin server. Therefore, a large number of refresh tasks cause a large number of concurrent download tasks. This increases the number of requests that are redirected to the origin server. The back-to-origin routing process consumes more bandwidth resources and the origin server may be overwhelmed.
          * *   The time required for a prefetch task to complete is proportional to the size of the prefetched file. In actual practice, most prefetch tasks require 5 to 30 minutes to complete. A task with a smaller average file size requires less time.
          * *   To allow RAM users to perform this operation, you must first grant them the required permissions. For more information, see [Authorize a RAM user to prefetch and refresh resources](~~260300~~).
          *
          * @param request PushObjectCacheRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PushObjectCacheResponse
         */
        public PushObjectCacheResponse PushObjectCacheWithOptions(PushObjectCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L2Preload))
            {
                query["L2Preload"] = request.L2Preload;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithHeader))
            {
                query["WithHeader"] = request.WithHeader;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushObjectCache",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushObjectCacheResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Alibaba Cloud CDN supports POST requests in which parameters are sent as a form.
          * *   You can call the [RefreshObjectCaches](~~91164~~) operation to refresh content and call the [PushObjectCache](~~91161~~) operation to prefetch content.
          * *   By default, each Alibaba Cloud account can submit up to 1,000 URLs per day. If the daily peak bandwidth value of your workloads exceeds 200 Mbit/s, you can [submit a ticket](https://account.alibabacloud.com/login/login.htm?oauth_callback=https%3A//ticket-intl.console.aliyun.com/%23/ticket/createIndex) to increase your daily quota. Alibaba Cloud reviews your application and then increases the quota accordingly.
          * *   You can specify at most 100 URLs in each prefetch request.
          * *   For each Alibaba Cloud account, the prefetch queue can contain up to 50,000 URLs. Content is prefetched based on the time when the URLs are submitted. The URL that is submitted the earliest has the highest priority. If the number of URLs in the queue reaches 50,000, you cannot submit more URLs until the number drops below 50,000.
          * *   You can call this operation up to 50 times per second per account.
          * *   For more information about how to automate refresh or prefetch tasks, see [Run scripts to refresh and prefetch content](~~151829~~).
          * ## Precautions
          * *   After a prefetch task is submitted and completed, the POPs immediately start to retrieve resources from the origin server. Therefore, a large number of refresh tasks cause a large number of concurrent download tasks. This increases the number of requests that are redirected to the origin server. The back-to-origin routing process consumes more bandwidth resources and the origin server may be overwhelmed.
          * *   The time required for a prefetch task to complete is proportional to the size of the prefetched file. In actual practice, most prefetch tasks require 5 to 30 minutes to complete. A task with a smaller average file size requires less time.
          * *   To allow RAM users to perform this operation, you must first grant them the required permissions. For more information, see [Authorize a RAM user to prefetch and refresh resources](~~260300~~).
          *
          * @param request PushObjectCacheRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PushObjectCacheResponse
         */
        public async Task<PushObjectCacheResponse> PushObjectCacheWithOptionsAsync(PushObjectCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L2Preload))
            {
                query["L2Preload"] = request.L2Preload;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithHeader))
            {
                query["WithHeader"] = request.WithHeader;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushObjectCache",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushObjectCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Alibaba Cloud CDN supports POST requests in which parameters are sent as a form.
          * *   You can call the [RefreshObjectCaches](~~91164~~) operation to refresh content and call the [PushObjectCache](~~91161~~) operation to prefetch content.
          * *   By default, each Alibaba Cloud account can submit up to 1,000 URLs per day. If the daily peak bandwidth value of your workloads exceeds 200 Mbit/s, you can [submit a ticket](https://account.alibabacloud.com/login/login.htm?oauth_callback=https%3A//ticket-intl.console.aliyun.com/%23/ticket/createIndex) to increase your daily quota. Alibaba Cloud reviews your application and then increases the quota accordingly.
          * *   You can specify at most 100 URLs in each prefetch request.
          * *   For each Alibaba Cloud account, the prefetch queue can contain up to 50,000 URLs. Content is prefetched based on the time when the URLs are submitted. The URL that is submitted the earliest has the highest priority. If the number of URLs in the queue reaches 50,000, you cannot submit more URLs until the number drops below 50,000.
          * *   You can call this operation up to 50 times per second per account.
          * *   For more information about how to automate refresh or prefetch tasks, see [Run scripts to refresh and prefetch content](~~151829~~).
          * ## Precautions
          * *   After a prefetch task is submitted and completed, the POPs immediately start to retrieve resources from the origin server. Therefore, a large number of refresh tasks cause a large number of concurrent download tasks. This increases the number of requests that are redirected to the origin server. The back-to-origin routing process consumes more bandwidth resources and the origin server may be overwhelmed.
          * *   The time required for a prefetch task to complete is proportional to the size of the prefetched file. In actual practice, most prefetch tasks require 5 to 30 minutes to complete. A task with a smaller average file size requires less time.
          * *   To allow RAM users to perform this operation, you must first grant them the required permissions. For more information, see [Authorize a RAM user to prefetch and refresh resources](~~260300~~).
          *
          * @param request PushObjectCacheRequest
          * @return PushObjectCacheResponse
         */
        public PushObjectCacheResponse PushObjectCache(PushObjectCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushObjectCacheWithOptions(request, runtime);
        }

        /**
          * *   Alibaba Cloud CDN supports POST requests in which parameters are sent as a form.
          * *   You can call the [RefreshObjectCaches](~~91164~~) operation to refresh content and call the [PushObjectCache](~~91161~~) operation to prefetch content.
          * *   By default, each Alibaba Cloud account can submit up to 1,000 URLs per day. If the daily peak bandwidth value of your workloads exceeds 200 Mbit/s, you can [submit a ticket](https://account.alibabacloud.com/login/login.htm?oauth_callback=https%3A//ticket-intl.console.aliyun.com/%23/ticket/createIndex) to increase your daily quota. Alibaba Cloud reviews your application and then increases the quota accordingly.
          * *   You can specify at most 100 URLs in each prefetch request.
          * *   For each Alibaba Cloud account, the prefetch queue can contain up to 50,000 URLs. Content is prefetched based on the time when the URLs are submitted. The URL that is submitted the earliest has the highest priority. If the number of URLs in the queue reaches 50,000, you cannot submit more URLs until the number drops below 50,000.
          * *   You can call this operation up to 50 times per second per account.
          * *   For more information about how to automate refresh or prefetch tasks, see [Run scripts to refresh and prefetch content](~~151829~~).
          * ## Precautions
          * *   After a prefetch task is submitted and completed, the POPs immediately start to retrieve resources from the origin server. Therefore, a large number of refresh tasks cause a large number of concurrent download tasks. This increases the number of requests that are redirected to the origin server. The back-to-origin routing process consumes more bandwidth resources and the origin server may be overwhelmed.
          * *   The time required for a prefetch task to complete is proportional to the size of the prefetched file. In actual practice, most prefetch tasks require 5 to 30 minutes to complete. A task with a smaller average file size requires less time.
          * *   To allow RAM users to perform this operation, you must first grant them the required permissions. For more information, see [Authorize a RAM user to prefetch and refresh resources](~~260300~~).
          *
          * @param request PushObjectCacheRequest
          * @return PushObjectCacheResponse
         */
        public async Task<PushObjectCacheResponse> PushObjectCacheAsync(PushObjectCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushObjectCacheWithOptionsAsync(request, runtime);
        }

        /**
          * *   Alibaba Cloud CDN supports POST requests in which parameters are sent as a form.
          * *   You can call the [RefreshObjectCaches](~~91164~~) operation to refresh content and call the [PushObjectCache](~~91161~~) operation to prefetch content.
          * *   You can call the RefreshObjectCaches operation up to 50 times per second per account.
          * *   For more information about how to automatically refresh or prefetch tasks, see [Run scripts to refresh and prefetch content](~~151829~~).
          * ## Precautions
          * *   After a refresh task is submitted and completed, specific resources are removed from POPs. When a POP receives a request for the removed resources, the POP forwards the request to the origin server to retrieve the resources. The retrieved resources are returned to the client and cached on the POP. Multiple refresh tasks may cause a large number of resources to be removed from the POPs. This increases the number of requests that are forwarded to the origin server. The back-to-origin routing process consumes more bandwidth resources and the origin server may be overwhelmed.
          * *   A refresh task takes effect 5 to 6 minutes after being submitted. This means that if the resource you want to refresh has a TTL of less than five minutes, you wait for it to expire instead of manually running a refresh task.
          * *   If you want to use RAM users to refresh or prefetch resources, you must obtain the required permissions. For more information, see [Authorize a RAM user to prefetch and refresh resources](~~260300~~).
          * ### Refresh quota
          * *   By default, each Alibaba Cloud account can refresh content from up to 10,000 URLs and 100 directories per day. The directories include subdirectories. If the daily peak bandwidth value exceeds 200 Mbit/s, you can [submit a ticket](https://account.alibabacloud.com/login/login.htm?oauth_callback=https%3A//ticket-intl.console.aliyun.com/%23/ticket/createIndex) to request a quota increase. Alibaba Cloud CDN evaluates your application based on your workloads.
          * *   By default, each Alibaba Cloud account can submit up to 20 refresh rules that contain regular expressions per day. If the daily peak bandwidth of your Alibaba Cloud account exceeds 10 Gbit/s, you can [submit a ticket](https://workorder-intl.console.aliyun.com/#/ticket/createIndex) to request a quota increase.
          * *   You can specify up to 1,000 URL refresh rules, 100 directory refresh rules, or 1 refresh rule that contains regular expressions in each call.
          * *   You can refresh up to 1,000 URLs per minute for each domain name.
          *
          * @param request RefreshObjectCachesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RefreshObjectCachesResponse
         */
        public RefreshObjectCachesResponse RefreshObjectCachesWithOptions(RefreshObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RefreshObjectCaches",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshObjectCachesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Alibaba Cloud CDN supports POST requests in which parameters are sent as a form.
          * *   You can call the [RefreshObjectCaches](~~91164~~) operation to refresh content and call the [PushObjectCache](~~91161~~) operation to prefetch content.
          * *   You can call the RefreshObjectCaches operation up to 50 times per second per account.
          * *   For more information about how to automatically refresh or prefetch tasks, see [Run scripts to refresh and prefetch content](~~151829~~).
          * ## Precautions
          * *   After a refresh task is submitted and completed, specific resources are removed from POPs. When a POP receives a request for the removed resources, the POP forwards the request to the origin server to retrieve the resources. The retrieved resources are returned to the client and cached on the POP. Multiple refresh tasks may cause a large number of resources to be removed from the POPs. This increases the number of requests that are forwarded to the origin server. The back-to-origin routing process consumes more bandwidth resources and the origin server may be overwhelmed.
          * *   A refresh task takes effect 5 to 6 minutes after being submitted. This means that if the resource you want to refresh has a TTL of less than five minutes, you wait for it to expire instead of manually running a refresh task.
          * *   If you want to use RAM users to refresh or prefetch resources, you must obtain the required permissions. For more information, see [Authorize a RAM user to prefetch and refresh resources](~~260300~~).
          * ### Refresh quota
          * *   By default, each Alibaba Cloud account can refresh content from up to 10,000 URLs and 100 directories per day. The directories include subdirectories. If the daily peak bandwidth value exceeds 200 Mbit/s, you can [submit a ticket](https://account.alibabacloud.com/login/login.htm?oauth_callback=https%3A//ticket-intl.console.aliyun.com/%23/ticket/createIndex) to request a quota increase. Alibaba Cloud CDN evaluates your application based on your workloads.
          * *   By default, each Alibaba Cloud account can submit up to 20 refresh rules that contain regular expressions per day. If the daily peak bandwidth of your Alibaba Cloud account exceeds 10 Gbit/s, you can [submit a ticket](https://workorder-intl.console.aliyun.com/#/ticket/createIndex) to request a quota increase.
          * *   You can specify up to 1,000 URL refresh rules, 100 directory refresh rules, or 1 refresh rule that contains regular expressions in each call.
          * *   You can refresh up to 1,000 URLs per minute for each domain name.
          *
          * @param request RefreshObjectCachesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RefreshObjectCachesResponse
         */
        public async Task<RefreshObjectCachesResponse> RefreshObjectCachesWithOptionsAsync(RefreshObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RefreshObjectCaches",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshObjectCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Alibaba Cloud CDN supports POST requests in which parameters are sent as a form.
          * *   You can call the [RefreshObjectCaches](~~91164~~) operation to refresh content and call the [PushObjectCache](~~91161~~) operation to prefetch content.
          * *   You can call the RefreshObjectCaches operation up to 50 times per second per account.
          * *   For more information about how to automatically refresh or prefetch tasks, see [Run scripts to refresh and prefetch content](~~151829~~).
          * ## Precautions
          * *   After a refresh task is submitted and completed, specific resources are removed from POPs. When a POP receives a request for the removed resources, the POP forwards the request to the origin server to retrieve the resources. The retrieved resources are returned to the client and cached on the POP. Multiple refresh tasks may cause a large number of resources to be removed from the POPs. This increases the number of requests that are forwarded to the origin server. The back-to-origin routing process consumes more bandwidth resources and the origin server may be overwhelmed.
          * *   A refresh task takes effect 5 to 6 minutes after being submitted. This means that if the resource you want to refresh has a TTL of less than five minutes, you wait for it to expire instead of manually running a refresh task.
          * *   If you want to use RAM users to refresh or prefetch resources, you must obtain the required permissions. For more information, see [Authorize a RAM user to prefetch and refresh resources](~~260300~~).
          * ### Refresh quota
          * *   By default, each Alibaba Cloud account can refresh content from up to 10,000 URLs and 100 directories per day. The directories include subdirectories. If the daily peak bandwidth value exceeds 200 Mbit/s, you can [submit a ticket](https://account.alibabacloud.com/login/login.htm?oauth_callback=https%3A//ticket-intl.console.aliyun.com/%23/ticket/createIndex) to request a quota increase. Alibaba Cloud CDN evaluates your application based on your workloads.
          * *   By default, each Alibaba Cloud account can submit up to 20 refresh rules that contain regular expressions per day. If the daily peak bandwidth of your Alibaba Cloud account exceeds 10 Gbit/s, you can [submit a ticket](https://workorder-intl.console.aliyun.com/#/ticket/createIndex) to request a quota increase.
          * *   You can specify up to 1,000 URL refresh rules, 100 directory refresh rules, or 1 refresh rule that contains regular expressions in each call.
          * *   You can refresh up to 1,000 URLs per minute for each domain name.
          *
          * @param request RefreshObjectCachesRequest
          * @return RefreshObjectCachesResponse
         */
        public RefreshObjectCachesResponse RefreshObjectCaches(RefreshObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshObjectCachesWithOptions(request, runtime);
        }

        /**
          * *   Alibaba Cloud CDN supports POST requests in which parameters are sent as a form.
          * *   You can call the [RefreshObjectCaches](~~91164~~) operation to refresh content and call the [PushObjectCache](~~91161~~) operation to prefetch content.
          * *   You can call the RefreshObjectCaches operation up to 50 times per second per account.
          * *   For more information about how to automatically refresh or prefetch tasks, see [Run scripts to refresh and prefetch content](~~151829~~).
          * ## Precautions
          * *   After a refresh task is submitted and completed, specific resources are removed from POPs. When a POP receives a request for the removed resources, the POP forwards the request to the origin server to retrieve the resources. The retrieved resources are returned to the client and cached on the POP. Multiple refresh tasks may cause a large number of resources to be removed from the POPs. This increases the number of requests that are forwarded to the origin server. The back-to-origin routing process consumes more bandwidth resources and the origin server may be overwhelmed.
          * *   A refresh task takes effect 5 to 6 minutes after being submitted. This means that if the resource you want to refresh has a TTL of less than five minutes, you wait for it to expire instead of manually running a refresh task.
          * *   If you want to use RAM users to refresh or prefetch resources, you must obtain the required permissions. For more information, see [Authorize a RAM user to prefetch and refresh resources](~~260300~~).
          * ### Refresh quota
          * *   By default, each Alibaba Cloud account can refresh content from up to 10,000 URLs and 100 directories per day. The directories include subdirectories. If the daily peak bandwidth value exceeds 200 Mbit/s, you can [submit a ticket](https://account.alibabacloud.com/login/login.htm?oauth_callback=https%3A//ticket-intl.console.aliyun.com/%23/ticket/createIndex) to request a quota increase. Alibaba Cloud CDN evaluates your application based on your workloads.
          * *   By default, each Alibaba Cloud account can submit up to 20 refresh rules that contain regular expressions per day. If the daily peak bandwidth of your Alibaba Cloud account exceeds 10 Gbit/s, you can [submit a ticket](https://workorder-intl.console.aliyun.com/#/ticket/createIndex) to request a quota increase.
          * *   You can specify up to 1,000 URL refresh rules, 100 directory refresh rules, or 1 refresh rule that contains regular expressions in each call.
          * *   You can refresh up to 1,000 URLs per minute for each domain name.
          *
          * @param request RefreshObjectCachesRequest
          * @return RefreshObjectCachesResponse
         */
        public async Task<RefreshObjectCachesResponse> RefreshObjectCachesAsync(RefreshObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshObjectCachesWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request RollbackStagingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RollbackStagingConfigResponse
         */
        public RollbackStagingConfigResponse RollbackStagingConfigWithOptions(RollbackStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackStagingConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackStagingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request RollbackStagingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RollbackStagingConfigResponse
         */
        public async Task<RollbackStagingConfigResponse> RollbackStagingConfigWithOptionsAsync(RollbackStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackStagingConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackStagingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request RollbackStagingConfigRequest
          * @return RollbackStagingConfigResponse
         */
        public RollbackStagingConfigResponse RollbackStagingConfig(RollbackStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackStagingConfigWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request RollbackStagingConfigRequest
          * @return RollbackStagingConfigResponse
         */
        public async Task<RollbackStagingConfigResponse> RollbackStagingConfigAsync(RollbackStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackStagingConfigWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request SetCdnDomainCSRCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCdnDomainCSRCertificateResponse
         */
        public SetCdnDomainCSRCertificateResponse SetCdnDomainCSRCertificateWithOptions(SetCdnDomainCSRCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "SetCdnDomainCSRCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCdnDomainCSRCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request SetCdnDomainCSRCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCdnDomainCSRCertificateResponse
         */
        public async Task<SetCdnDomainCSRCertificateResponse> SetCdnDomainCSRCertificateWithOptionsAsync(SetCdnDomainCSRCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "SetCdnDomainCSRCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCdnDomainCSRCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request SetCdnDomainCSRCertificateRequest
          * @return SetCdnDomainCSRCertificateResponse
         */
        public SetCdnDomainCSRCertificateResponse SetCdnDomainCSRCertificate(SetCdnDomainCSRCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCdnDomainCSRCertificateWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request SetCdnDomainCSRCertificateRequest
          * @return SetCdnDomainCSRCertificateResponse
         */
        public async Task<SetCdnDomainCSRCertificateResponse> SetCdnDomainCSRCertificateAsync(SetCdnDomainCSRCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCdnDomainCSRCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request SetCdnDomainSMCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCdnDomainSMCertificateResponse
         */
        public SetCdnDomainSMCertificateResponse SetCdnDomainSMCertificateWithOptions(SetCdnDomainSMCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SetCdnDomainSMCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCdnDomainSMCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request SetCdnDomainSMCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCdnDomainSMCertificateResponse
         */
        public async Task<SetCdnDomainSMCertificateResponse> SetCdnDomainSMCertificateWithOptionsAsync(SetCdnDomainSMCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SetCdnDomainSMCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCdnDomainSMCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request SetCdnDomainSMCertificateRequest
          * @return SetCdnDomainSMCertificateResponse
         */
        public SetCdnDomainSMCertificateResponse SetCdnDomainSMCertificate(SetCdnDomainSMCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCdnDomainSMCertificateWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request SetCdnDomainSMCertificateRequest
          * @return SetCdnDomainSMCertificateResponse
         */
        public async Task<SetCdnDomainSMCertificateResponse> SetCdnDomainSMCertificateAsync(SetCdnDomainSMCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCdnDomainSMCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   Method: POST.
          *
          * @param request SetCdnDomainSSLCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCdnDomainSSLCertificateResponse
         */
        public SetCdnDomainSSLCertificateResponse SetCdnDomainSSLCertificateWithOptions(SetCdnDomainSSLCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRegion))
            {
                query["CertRegion"] = request.CertRegion;
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
                Action = "SetCdnDomainSSLCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCdnDomainSSLCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   Method: POST.
          *
          * @param request SetCdnDomainSSLCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCdnDomainSSLCertificateResponse
         */
        public async Task<SetCdnDomainSSLCertificateResponse> SetCdnDomainSSLCertificateWithOptionsAsync(SetCdnDomainSSLCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRegion))
            {
                query["CertRegion"] = request.CertRegion;
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
                Action = "SetCdnDomainSSLCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCdnDomainSSLCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   Method: POST.
          *
          * @param request SetCdnDomainSSLCertificateRequest
          * @return SetCdnDomainSSLCertificateResponse
         */
        public SetCdnDomainSSLCertificateResponse SetCdnDomainSSLCertificate(SetCdnDomainSSLCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCdnDomainSSLCertificateWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation up to 30 times per second per account.
          * *   Method: POST.
          *
          * @param request SetCdnDomainSSLCertificateRequest
          * @return SetCdnDomainSSLCertificateResponse
         */
        public async Task<SetCdnDomainSSLCertificateResponse> SetCdnDomainSSLCertificateAsync(SetCdnDomainSSLCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCdnDomainSSLCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * >  You can call this operation up to 30 times per second per account.
          *
          * @param request SetCdnDomainStagingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCdnDomainStagingConfigResponse
         */
        public SetCdnDomainStagingConfigResponse SetCdnDomainStagingConfigWithOptions(SetCdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCdnDomainStagingConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCdnDomainStagingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  You can call this operation up to 30 times per second per account.
          *
          * @param request SetCdnDomainStagingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCdnDomainStagingConfigResponse
         */
        public async Task<SetCdnDomainStagingConfigResponse> SetCdnDomainStagingConfigWithOptionsAsync(SetCdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCdnDomainStagingConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCdnDomainStagingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  You can call this operation up to 30 times per second per account.
          *
          * @param request SetCdnDomainStagingConfigRequest
          * @return SetCdnDomainStagingConfigResponse
         */
        public SetCdnDomainStagingConfigResponse SetCdnDomainStagingConfig(SetCdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCdnDomainStagingConfigWithOptions(request, runtime);
        }

        /**
          * >  You can call this operation up to 30 times per second per account.
          *
          * @param request SetCdnDomainStagingConfigRequest
          * @return SetCdnDomainStagingConfigResponse
         */
        public async Task<SetCdnDomainStagingConfigResponse> SetCdnDomainStagingConfigAsync(SetCdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCdnDomainStagingConfigWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated : SetDomainServerCertificate is deprecated, please use Cdn::2018-05-10::SetCdnDomainSSLCertificate instead.
          * *   You can call this operation up to 10 times per second per user.
          * *   Method: POST.
          *
          * @param request SetDomainServerCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetDomainServerCertificateResponse
         */
        // Deprecated
        public SetDomainServerCertificateResponse SetDomainServerCertificateWithOptions(SetDomainServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificate))
            {
                query["ServerCertificate"] = request.ServerCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateStatus))
            {
                query["ServerCertificateStatus"] = request.ServerCertificateStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDomainServerCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainServerCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated : SetDomainServerCertificate is deprecated, please use Cdn::2018-05-10::SetCdnDomainSSLCertificate instead.
          * *   You can call this operation up to 10 times per second per user.
          * *   Method: POST.
          *
          * @param request SetDomainServerCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetDomainServerCertificateResponse
         */
        // Deprecated
        public async Task<SetDomainServerCertificateResponse> SetDomainServerCertificateWithOptionsAsync(SetDomainServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificate))
            {
                query["ServerCertificate"] = request.ServerCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateStatus))
            {
                query["ServerCertificateStatus"] = request.ServerCertificateStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDomainServerCertificate",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainServerCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated : SetDomainServerCertificate is deprecated, please use Cdn::2018-05-10::SetCdnDomainSSLCertificate instead.
          * *   You can call this operation up to 10 times per second per user.
          * *   Method: POST.
          *
          * @param request SetDomainServerCertificateRequest
          * @return SetDomainServerCertificateResponse
         */
        // Deprecated
        public SetDomainServerCertificateResponse SetDomainServerCertificate(SetDomainServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainServerCertificateWithOptions(request, runtime);
        }

        /**
          * @deprecated : SetDomainServerCertificate is deprecated, please use Cdn::2018-05-10::SetCdnDomainSSLCertificate instead.
          * *   You can call this operation up to 10 times per second per user.
          * *   Method: POST.
          *
          * @param request SetDomainServerCertificateRequest
          * @return SetDomainServerCertificateResponse
         */
        // Deprecated
        public async Task<SetDomainServerCertificateResponse> SetDomainServerCertificateAsync(SetDomainServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainServerCertificateWithOptionsAsync(request, runtime);
        }

        public SetReqHeaderConfigResponse SetReqHeaderConfigWithOptions(SetReqHeaderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "SetReqHeaderConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetReqHeaderConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetReqHeaderConfigResponse> SetReqHeaderConfigWithOptionsAsync(SetReqHeaderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "SetReqHeaderConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetReqHeaderConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetReqHeaderConfigResponse SetReqHeaderConfig(SetReqHeaderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetReqHeaderConfigWithOptions(request, runtime);
        }

        public async Task<SetReqHeaderConfigResponse> SetReqHeaderConfigAsync(SetReqHeaderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetReqHeaderConfigWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request SetWaitingRoomConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetWaitingRoomConfigResponse
         */
        public SetWaitingRoomConfigResponse SetWaitingRoomConfigWithOptions(SetWaitingRoomConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPct))
            {
                query["AllowPct"] = request.AllowPct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GapTime))
            {
                query["GapTime"] = request.GapTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTimeWait))
            {
                query["MaxTimeWait"] = request.MaxTimeWait;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitUri))
            {
                query["WaitUri"] = request.WaitUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitUrl))
            {
                query["WaitUrl"] = request.WaitUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWaitingRoomConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWaitingRoomConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request SetWaitingRoomConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetWaitingRoomConfigResponse
         */
        public async Task<SetWaitingRoomConfigResponse> SetWaitingRoomConfigWithOptionsAsync(SetWaitingRoomConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPct))
            {
                query["AllowPct"] = request.AllowPct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GapTime))
            {
                query["GapTime"] = request.GapTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTimeWait))
            {
                query["MaxTimeWait"] = request.MaxTimeWait;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitUri))
            {
                query["WaitUri"] = request.WaitUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitUrl))
            {
                query["WaitUrl"] = request.WaitUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWaitingRoomConfig",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWaitingRoomConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request SetWaitingRoomConfigRequest
          * @return SetWaitingRoomConfigResponse
         */
        public SetWaitingRoomConfigResponse SetWaitingRoomConfig(SetWaitingRoomConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWaitingRoomConfigWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 30 times per second per account.
          *
          * @param request SetWaitingRoomConfigRequest
          * @return SetWaitingRoomConfigResponse
         */
        public async Task<SetWaitingRoomConfigResponse> SetWaitingRoomConfigAsync(SetWaitingRoomConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWaitingRoomConfigWithOptionsAsync(request, runtime);
        }

        /**
          * *   If the domain name is in an invalid state or you have an overdue payment in your account, the domain name cannot be enabled.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request StartCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartCdnDomainResponse
         */
        public StartCdnDomainResponse StartCdnDomainWithOptions(StartCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If the domain name is in an invalid state or you have an overdue payment in your account, the domain name cannot be enabled.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request StartCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartCdnDomainResponse
         */
        public async Task<StartCdnDomainResponse> StartCdnDomainWithOptionsAsync(StartCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If the domain name is in an invalid state or you have an overdue payment in your account, the domain name cannot be enabled.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request StartCdnDomainRequest
          * @return StartCdnDomainResponse
         */
        public StartCdnDomainResponse StartCdnDomain(StartCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCdnDomainWithOptions(request, runtime);
        }

        /**
          * *   If the domain name is in an invalid state or you have an overdue payment in your account, the domain name cannot be enabled.
          * *   You can call this operation up to 100 times per second per account.
          *
          * @param request StartCdnDomainRequest
          * @return StartCdnDomainResponse
         */
        public async Task<StartCdnDomainResponse> StartCdnDomainAsync(StartCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCdnDomainWithOptionsAsync(request, runtime);
        }

        /**
          * *   After an accelerated domain is disabled, Alibaba Cloud CDN retains its information and routes all the requests that are destined for the accelerated domain to the origin server.
          * *   You can call this operation up to 40 times per second per account.
          *
          * @param request StopCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopCdnDomainResponse
         */
        public StopCdnDomainResponse StopCdnDomainWithOptions(StopCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCdnDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   After an accelerated domain is disabled, Alibaba Cloud CDN retains its information and routes all the requests that are destined for the accelerated domain to the origin server.
          * *   You can call this operation up to 40 times per second per account.
          *
          * @param request StopCdnDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopCdnDomainResponse
         */
        public async Task<StopCdnDomainResponse> StopCdnDomainWithOptionsAsync(StopCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopCdnDomain",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCdnDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   After an accelerated domain is disabled, Alibaba Cloud CDN retains its information and routes all the requests that are destined for the accelerated domain to the origin server.
          * *   You can call this operation up to 40 times per second per account.
          *
          * @param request StopCdnDomainRequest
          * @return StopCdnDomainResponse
         */
        public StopCdnDomainResponse StopCdnDomain(StopCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCdnDomainWithOptions(request, runtime);
        }

        /**
          * *   After an accelerated domain is disabled, Alibaba Cloud CDN retains its information and routes all the requests that are destined for the accelerated domain to the origin server.
          * *   You can call this operation up to 40 times per second per account.
          *
          * @param request StopCdnDomainRequest
          * @return StopCdnDomainResponse
         */
        public async Task<StopCdnDomainResponse> StopCdnDomainAsync(StopCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCdnDomainWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
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
                Version = "2018-05-10",
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
          * > You can call this operation up to 100 times per second per account.
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
                Version = "2018-05-10",
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
          * > You can call this operation up to 100 times per second per account.
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
          * > You can call this operation up to 100 times per second per account.
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
          * > You can call this operation up to 100 times per second per account.
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
                Version = "2018-05-10",
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
          * > You can call this operation up to 100 times per second per account.
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
                Version = "2018-05-10",
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
          * > You can call this operation up to 100 times per second per account.
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
          * > You can call this operation up to 100 times per second per account.
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
          * > You can call this operation up to three times per second per account.
          *
          * @param request UpdateCdnDeliverTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateCdnDeliverTaskResponse
         */
        public UpdateCdnDeliverTaskResponse UpdateCdnDeliverTaskWithOptions(UpdateCdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCdnDeliverTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCdnDeliverTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request UpdateCdnDeliverTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateCdnDeliverTaskResponse
         */
        public async Task<UpdateCdnDeliverTaskResponse> UpdateCdnDeliverTaskWithOptionsAsync(UpdateCdnDeliverTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCdnDeliverTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCdnDeliverTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request UpdateCdnDeliverTaskRequest
          * @return UpdateCdnDeliverTaskResponse
         */
        public UpdateCdnDeliverTaskResponse UpdateCdnDeliverTask(UpdateCdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCdnDeliverTaskWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request UpdateCdnDeliverTaskRequest
          * @return UpdateCdnDeliverTaskResponse
         */
        public async Task<UpdateCdnDeliverTaskResponse> UpdateCdnDeliverTaskAsync(UpdateCdnDeliverTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCdnDeliverTaskWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request UpdateCdnSubTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateCdnSubTaskResponse
         */
        public UpdateCdnSubTaskResponse UpdateCdnSubTaskWithOptions(UpdateCdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCdnSubTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCdnSubTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request UpdateCdnSubTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateCdnSubTaskResponse
         */
        public async Task<UpdateCdnSubTaskResponse> UpdateCdnSubTaskWithOptionsAsync(UpdateCdnSubTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCdnSubTask",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCdnSubTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request UpdateCdnSubTaskRequest
          * @return UpdateCdnSubTaskResponse
         */
        public UpdateCdnSubTaskResponse UpdateCdnSubTask(UpdateCdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCdnSubTaskWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to three times per second per account.
          *
          * @param request UpdateCdnSubTaskRequest
          * @return UpdateCdnSubTaskResponse
         */
        public async Task<UpdateCdnSubTaskResponse> UpdateCdnSubTaskAsync(UpdateCdnSubTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCdnSubTaskWithOptionsAsync(request, runtime);
        }

        public UpdateFCTriggerResponse UpdateFCTriggerWithOptions(UpdateFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerARN))
            {
                query["TriggerARN"] = request.TriggerARN;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionARN))
            {
                body["FunctionARN"] = request.FunctionARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                body["Notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleARN))
            {
                body["RoleARN"] = request.RoleARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceARN))
            {
                body["SourceARN"] = request.SourceARN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFCTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFCTriggerResponse> UpdateFCTriggerWithOptionsAsync(UpdateFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerARN))
            {
                query["TriggerARN"] = request.TriggerARN;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionARN))
            {
                body["FunctionARN"] = request.FunctionARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                body["Notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleARN))
            {
                body["RoleARN"] = request.RoleARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceARN))
            {
                body["SourceARN"] = request.SourceARN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFCTrigger",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFCTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFCTriggerResponse UpdateFCTrigger(UpdateFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFCTriggerWithOptions(request, runtime);
        }

        public async Task<UpdateFCTriggerResponse> UpdateFCTriggerAsync(UpdateFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFCTriggerWithOptionsAsync(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request VerifyDomainOwnerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return VerifyDomainOwnerResponse
         */
        public VerifyDomainOwnerResponse VerifyDomainOwnerWithOptions(VerifyDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalResourcePlan))
            {
                query["GlobalResourcePlan"] = request.GlobalResourcePlan;
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
                Action = "VerifyDomainOwner",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyDomainOwnerResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request VerifyDomainOwnerRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return VerifyDomainOwnerResponse
         */
        public async Task<VerifyDomainOwnerResponse> VerifyDomainOwnerWithOptionsAsync(VerifyDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalResourcePlan))
            {
                query["GlobalResourcePlan"] = request.GlobalResourcePlan;
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
                Action = "VerifyDomainOwner",
                Version = "2018-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyDomainOwnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request VerifyDomainOwnerRequest
          * @return VerifyDomainOwnerResponse
         */
        public VerifyDomainOwnerResponse VerifyDomainOwner(VerifyDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyDomainOwnerWithOptions(request, runtime);
        }

        /**
          * > You can call this operation up to 100 times per second per account.
          *
          * @param request VerifyDomainOwnerRequest
          * @return VerifyDomainOwnerResponse
         */
        public async Task<VerifyDomainOwnerResponse> VerifyDomainOwnerAsync(VerifyDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyDomainOwnerWithOptionsAsync(request, runtime);
        }

    }
}
