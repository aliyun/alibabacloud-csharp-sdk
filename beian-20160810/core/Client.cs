// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Beian20160810.Models;

namespace AlibabaCloud.SDK.Beian20160810
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("beian", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request DeleteUnbeianIpCheckTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUnbeianIpCheckTypeResponse
         */
        public DeleteUnbeianIpCheckTypeResponse DeleteUnbeianIpCheckTypeWithOptions(DeleteUnbeianIpCheckTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUnbeianIpCheckType",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUnbeianIpCheckTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteUnbeianIpCheckTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUnbeianIpCheckTypeResponse
         */
        public async Task<DeleteUnbeianIpCheckTypeResponse> DeleteUnbeianIpCheckTypeWithOptionsAsync(DeleteUnbeianIpCheckTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUnbeianIpCheckType",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUnbeianIpCheckTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteUnbeianIpCheckTypeRequest
         * @return DeleteUnbeianIpCheckTypeResponse
         */
        public DeleteUnbeianIpCheckTypeResponse DeleteUnbeianIpCheckType(DeleteUnbeianIpCheckTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUnbeianIpCheckTypeWithOptions(request, runtime);
        }

        /**
         * @param request DeleteUnbeianIpCheckTypeRequest
         * @return DeleteUnbeianIpCheckTypeResponse
         */
        public async Task<DeleteUnbeianIpCheckTypeResponse> DeleteUnbeianIpCheckTypeAsync(DeleteUnbeianIpCheckTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUnbeianIpCheckTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取主域名接口
         *
         * @param request GetMainDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMainDomainResponse
         */
        public GetMainDomainResponse GetMainDomainWithOptions(GetMainDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMainDomain",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMainDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取主域名接口
         *
         * @param request GetMainDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMainDomainResponse
         */
        public async Task<GetMainDomainResponse> GetMainDomainWithOptionsAsync(GetMainDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMainDomain",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMainDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取主域名接口
         *
         * @param request GetMainDomainRequest
         * @return GetMainDomainResponse
         */
        public GetMainDomainResponse GetMainDomain(GetMainDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMainDomainWithOptions(request, runtime);
        }

        /**
         * @summary 获取主域名接口
         *
         * @param request GetMainDomainRequest
         * @return GetMainDomainResponse
         */
        public async Task<GetMainDomainResponse> GetMainDomainAsync(GetMainDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMainDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request InsertUnbeianIpCheckTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertUnbeianIpCheckTypeResponse
         */
        public InsertUnbeianIpCheckTypeResponse InsertUnbeianIpCheckTypeWithOptions(InsertUnbeianIpCheckTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertUnbeianIpCheckType",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertUnbeianIpCheckTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request InsertUnbeianIpCheckTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertUnbeianIpCheckTypeResponse
         */
        public async Task<InsertUnbeianIpCheckTypeResponse> InsertUnbeianIpCheckTypeWithOptionsAsync(InsertUnbeianIpCheckTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertUnbeianIpCheckType",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertUnbeianIpCheckTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request InsertUnbeianIpCheckTypeRequest
         * @return InsertUnbeianIpCheckTypeResponse
         */
        public InsertUnbeianIpCheckTypeResponse InsertUnbeianIpCheckType(InsertUnbeianIpCheckTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertUnbeianIpCheckTypeWithOptions(request, runtime);
        }

        /**
         * @param request InsertUnbeianIpCheckTypeRequest
         * @return InsertUnbeianIpCheckTypeResponse
         */
        public async Task<InsertUnbeianIpCheckTypeResponse> InsertUnbeianIpCheckTypeAsync(InsertUnbeianIpCheckTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertUnbeianIpCheckTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListUnbeianIpCheckTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUnbeianIpCheckTypeResponse
         */
        public ListUnbeianIpCheckTypeResponse ListUnbeianIpCheckTypeWithOptions(ListUnbeianIpCheckTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUnbeianIpCheckType",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUnbeianIpCheckTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListUnbeianIpCheckTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUnbeianIpCheckTypeResponse
         */
        public async Task<ListUnbeianIpCheckTypeResponse> ListUnbeianIpCheckTypeWithOptionsAsync(ListUnbeianIpCheckTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["CheckType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUnbeianIpCheckType",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUnbeianIpCheckTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListUnbeianIpCheckTypeRequest
         * @return ListUnbeianIpCheckTypeResponse
         */
        public ListUnbeianIpCheckTypeResponse ListUnbeianIpCheckType(ListUnbeianIpCheckTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUnbeianIpCheckTypeWithOptions(request, runtime);
        }

        /**
         * @param request ListUnbeianIpCheckTypeRequest
         * @return ListUnbeianIpCheckTypeResponse
         */
        public async Task<ListUnbeianIpCheckTypeResponse> ListUnbeianIpCheckTypeAsync(ListUnbeianIpCheckTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUnbeianIpCheckTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方服务域名上报接口
         *
         * @param request ManageAccessorDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManageAccessorDomainResponse
         */
        public ManageAccessorDomainResponse ManageAccessorDomainWithOptions(ManageAccessorDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManageAccessorDomain",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageAccessorDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方服务域名上报接口
         *
         * @param request ManageAccessorDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManageAccessorDomainResponse
         */
        public async Task<ManageAccessorDomainResponse> ManageAccessorDomainWithOptionsAsync(ManageAccessorDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManageAccessorDomain",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageAccessorDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方服务域名上报接口
         *
         * @param request ManageAccessorDomainRequest
         * @return ManageAccessorDomainResponse
         */
        public ManageAccessorDomainResponse ManageAccessorDomain(ManageAccessorDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManageAccessorDomainWithOptions(request, runtime);
        }

        /**
         * @summary 接入方服务域名上报接口
         *
         * @param request ManageAccessorDomainRequest
         * @return ManageAccessorDomainResponse
         */
        public async Task<ManageAccessorDomainResponse> ManageAccessorDomainAsync(ManageAccessorDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManageAccessorDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方域名白名单上报接口
         *
         * @param request ManageAccessorDomainWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManageAccessorDomainWhiteListResponse
         */
        public ManageAccessorDomainWhiteListResponse ManageAccessorDomainWhiteListWithOptions(ManageAccessorDomainWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "ManageAccessorDomainWhiteList",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageAccessorDomainWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方域名白名单上报接口
         *
         * @param request ManageAccessorDomainWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManageAccessorDomainWhiteListResponse
         */
        public async Task<ManageAccessorDomainWhiteListResponse> ManageAccessorDomainWhiteListWithOptionsAsync(ManageAccessorDomainWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "ManageAccessorDomainWhiteList",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageAccessorDomainWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方域名白名单上报接口
         *
         * @param request ManageAccessorDomainWhiteListRequest
         * @return ManageAccessorDomainWhiteListResponse
         */
        public ManageAccessorDomainWhiteListResponse ManageAccessorDomainWhiteList(ManageAccessorDomainWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManageAccessorDomainWhiteListWithOptions(request, runtime);
        }

        /**
         * @summary 接入方域名白名单上报接口
         *
         * @param request ManageAccessorDomainWhiteListRequest
         * @return ManageAccessorDomainWhiteListResponse
         */
        public async Task<ManageAccessorDomainWhiteListResponse> ManageAccessorDomainWhiteListAsync(ManageAccessorDomainWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManageAccessorDomainWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方管控IP上报接口
         *
         * @param request ManageAccessorIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManageAccessorIpResponse
         */
        public ManageAccessorIpResponse ManageAccessorIpWithOptions(ManageAccessorIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManageAccessorIp",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageAccessorIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方管控IP上报接口
         *
         * @param request ManageAccessorIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManageAccessorIpResponse
         */
        public async Task<ManageAccessorIpResponse> ManageAccessorIpWithOptionsAsync(ManageAccessorIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManageAccessorIp",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManageAccessorIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方管控IP上报接口
         *
         * @param request ManageAccessorIpRequest
         * @return ManageAccessorIpResponse
         */
        public ManageAccessorIpResponse ManageAccessorIp(ManageAccessorIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManageAccessorIpWithOptions(request, runtime);
        }

        /**
         * @summary 接入方管控IP上报接口
         *
         * @param request ManageAccessorIpRequest
         * @return ManageAccessorIpResponse
         */
        public async Task<ManageAccessorIpResponse> ManageAccessorIpAsync(ManageAccessorIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManageAccessorIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方服务域名是否上报查询接口
         *
         * @param request QueryAccessorDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainResponse
         */
        public QueryAccessorDomainResponse QueryAccessorDomainWithOptions(QueryAccessorDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorDomain",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方服务域名是否上报查询接口
         *
         * @param request QueryAccessorDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainResponse
         */
        public async Task<QueryAccessorDomainResponse> QueryAccessorDomainWithOptionsAsync(QueryAccessorDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorDomain",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方服务域名是否上报查询接口
         *
         * @param request QueryAccessorDomainRequest
         * @return QueryAccessorDomainResponse
         */
        public QueryAccessorDomainResponse QueryAccessorDomain(QueryAccessorDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccessorDomainWithOptions(request, runtime);
        }

        /**
         * @summary 接入方服务域名是否上报查询接口
         *
         * @param request QueryAccessorDomainRequest
         * @return QueryAccessorDomainResponse
         */
        public async Task<QueryAccessorDomainResponse> QueryAccessorDomainAsync(QueryAccessorDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccessorDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方查询服务域名列表接口
         *
         * @param request QueryAccessorDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainListResponse
         */
        public QueryAccessorDomainListResponse QueryAccessorDomainListWithOptions(QueryAccessorDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "QueryAccessorDomainList",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方查询服务域名列表接口
         *
         * @param request QueryAccessorDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainListResponse
         */
        public async Task<QueryAccessorDomainListResponse> QueryAccessorDomainListWithOptionsAsync(QueryAccessorDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "QueryAccessorDomainList",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方查询服务域名列表接口
         *
         * @param request QueryAccessorDomainListRequest
         * @return QueryAccessorDomainListResponse
         */
        public QueryAccessorDomainListResponse QueryAccessorDomainList(QueryAccessorDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccessorDomainListWithOptions(request, runtime);
        }

        /**
         * @summary 接入方查询服务域名列表接口
         *
         * @param request QueryAccessorDomainListRequest
         * @return QueryAccessorDomainListResponse
         */
        public async Task<QueryAccessorDomainListResponse> QueryAccessorDomainListAsync(QueryAccessorDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccessorDomainListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方域名状态查询接口
         *
         * @param request QueryAccessorDomainStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainStatusResponse
         */
        public QueryAccessorDomainStatusResponse QueryAccessorDomainStatusWithOptions(QueryAccessorDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorDomainStatus",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方域名状态查询接口
         *
         * @param request QueryAccessorDomainStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainStatusResponse
         */
        public async Task<QueryAccessorDomainStatusResponse> QueryAccessorDomainStatusWithOptionsAsync(QueryAccessorDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorDomainStatus",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方域名状态查询接口
         *
         * @param request QueryAccessorDomainStatusRequest
         * @return QueryAccessorDomainStatusResponse
         */
        public QueryAccessorDomainStatusResponse QueryAccessorDomainStatus(QueryAccessorDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccessorDomainStatusWithOptions(request, runtime);
        }

        /**
         * @summary 接入方域名状态查询接口
         *
         * @param request QueryAccessorDomainStatusRequest
         * @return QueryAccessorDomainStatusResponse
         */
        public async Task<QueryAccessorDomainStatusResponse> QueryAccessorDomainStatusAsync(QueryAccessorDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccessorDomainStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方域名白名单上报查询接口
         *
         * @param request QueryAccessorDomainWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainWhiteListResponse
         */
        public QueryAccessorDomainWhiteListResponse QueryAccessorDomainWhiteListWithOptions(QueryAccessorDomainWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorDomainWhiteList",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方域名白名单上报查询接口
         *
         * @param request QueryAccessorDomainWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainWhiteListResponse
         */
        public async Task<QueryAccessorDomainWhiteListResponse> QueryAccessorDomainWhiteListWithOptionsAsync(QueryAccessorDomainWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorDomainWhiteList",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方域名白名单上报查询接口
         *
         * @param request QueryAccessorDomainWhiteListRequest
         * @return QueryAccessorDomainWhiteListResponse
         */
        public QueryAccessorDomainWhiteListResponse QueryAccessorDomainWhiteList(QueryAccessorDomainWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccessorDomainWhiteListWithOptions(request, runtime);
        }

        /**
         * @summary 接入方域名白名单上报查询接口
         *
         * @param request QueryAccessorDomainWhiteListRequest
         * @return QueryAccessorDomainWhiteListResponse
         */
        public async Task<QueryAccessorDomainWhiteListResponse> QueryAccessorDomainWhiteListAsync(QueryAccessorDomainWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccessorDomainWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方域名状态批量查询接口
         *
         * @param request QueryAccessorDomainsStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainsStatusResponse
         */
        public QueryAccessorDomainsStatusResponse QueryAccessorDomainsStatusWithOptions(QueryAccessorDomainsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorDomainsStatus",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainsStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方域名状态批量查询接口
         *
         * @param request QueryAccessorDomainsStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorDomainsStatusResponse
         */
        public async Task<QueryAccessorDomainsStatusResponse> QueryAccessorDomainsStatusWithOptionsAsync(QueryAccessorDomainsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorDomainsStatus",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorDomainsStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方域名状态批量查询接口
         *
         * @param request QueryAccessorDomainsStatusRequest
         * @return QueryAccessorDomainsStatusResponse
         */
        public QueryAccessorDomainsStatusResponse QueryAccessorDomainsStatus(QueryAccessorDomainsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccessorDomainsStatusWithOptions(request, runtime);
        }

        /**
         * @summary 接入方域名状态批量查询接口
         *
         * @param request QueryAccessorDomainsStatusRequest
         * @return QueryAccessorDomainsStatusResponse
         */
        public async Task<QueryAccessorDomainsStatusResponse> QueryAccessorDomainsStatusAsync(QueryAccessorDomainsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccessorDomainsStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方服务域名上报接口
         *
         * @param request QueryAccessorIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorIpResponse
         */
        public QueryAccessorIpResponse QueryAccessorIpWithOptions(QueryAccessorIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorIp",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方服务域名上报接口
         *
         * @param request QueryAccessorIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccessorIpResponse
         */
        public async Task<QueryAccessorIpResponse> QueryAccessorIpWithOptionsAsync(QueryAccessorIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccessorIp",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccessorIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方服务域名上报接口
         *
         * @param request QueryAccessorIpRequest
         * @return QueryAccessorIpResponse
         */
        public QueryAccessorIpResponse QueryAccessorIp(QueryAccessorIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccessorIpWithOptions(request, runtime);
        }

        /**
         * @summary 接入方服务域名上报接口
         *
         * @param request QueryAccessorIpRequest
         * @return QueryAccessorIpResponse
         */
        public async Task<QueryAccessorIpResponse> QueryAccessorIpAsync(QueryAccessorIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccessorIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 接入方服务域名全量上报接口
         *
         * @param request SubmitAccessorFullDomainsOssListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAccessorFullDomainsOssListResponse
         */
        public SubmitAccessorFullDomainsOssListResponse SubmitAccessorFullDomainsOssListWithOptions(SubmitAccessorFullDomainsOssListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssList))
            {
                query["OssList"] = request.OssList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAccessorFullDomainsOssList",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAccessorFullDomainsOssListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 接入方服务域名全量上报接口
         *
         * @param request SubmitAccessorFullDomainsOssListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAccessorFullDomainsOssListResponse
         */
        public async Task<SubmitAccessorFullDomainsOssListResponse> SubmitAccessorFullDomainsOssListWithOptionsAsync(SubmitAccessorFullDomainsOssListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssList))
            {
                query["OssList"] = request.OssList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAccessorFullDomainsOssList",
                Version = "2016-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAccessorFullDomainsOssListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 接入方服务域名全量上报接口
         *
         * @param request SubmitAccessorFullDomainsOssListRequest
         * @return SubmitAccessorFullDomainsOssListResponse
         */
        public SubmitAccessorFullDomainsOssListResponse SubmitAccessorFullDomainsOssList(SubmitAccessorFullDomainsOssListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAccessorFullDomainsOssListWithOptions(request, runtime);
        }

        /**
         * @summary 接入方服务域名全量上报接口
         *
         * @param request SubmitAccessorFullDomainsOssListRequest
         * @return SubmitAccessorFullDomainsOssListResponse
         */
        public async Task<SubmitAccessorFullDomainsOssListResponse> SubmitAccessorFullDomainsOssListAsync(SubmitAccessorFullDomainsOssListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAccessorFullDomainsOssListWithOptionsAsync(request, runtime);
        }

    }
}
