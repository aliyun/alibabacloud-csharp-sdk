// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Marketing_event20210101.Models;

namespace AlibabaCloud.SDK.Marketing_event20210101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("marketing_event", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 拉取领证人员记录
         *
         * @param request FindGuestCredentialsRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindGuestCredentialsRecordResponse
         */
        public FindGuestCredentialsRecordResponse FindGuestCredentialsRecordWithOptions(FindGuestCredentialsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTimeString))
            {
                query["DateTimeString"] = request.DateTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateTime))
            {
                query["EndDateTime"] = request.EndDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateTime))
            {
                query["StartDateTime"] = request.StartDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindGuestCredentialsRecord",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindGuestCredentialsRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 拉取领证人员记录
         *
         * @param request FindGuestCredentialsRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindGuestCredentialsRecordResponse
         */
        public async Task<FindGuestCredentialsRecordResponse> FindGuestCredentialsRecordWithOptionsAsync(FindGuestCredentialsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTimeString))
            {
                query["DateTimeString"] = request.DateTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateTime))
            {
                query["EndDateTime"] = request.EndDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateTime))
            {
                query["StartDateTime"] = request.StartDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindGuestCredentialsRecord",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindGuestCredentialsRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 拉取领证人员记录
         *
         * @param request FindGuestCredentialsRecordRequest
         * @return FindGuestCredentialsRecordResponse
         */
        public FindGuestCredentialsRecordResponse FindGuestCredentialsRecord(FindGuestCredentialsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindGuestCredentialsRecordWithOptions(request, runtime);
        }

        /**
         * @summary 拉取领证人员记录
         *
         * @param request FindGuestCredentialsRecordRequest
         * @return FindGuestCredentialsRecordResponse
         */
        public async Task<FindGuestCredentialsRecordResponse> FindGuestCredentialsRecordAsync(FindGuestCredentialsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindGuestCredentialsRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 云栖大会获取取票人信息list接口
         *
         * @param request FindGuestTicketRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindGuestTicketRecordResponse
         */
        public FindGuestTicketRecordResponse FindGuestTicketRecordWithOptions(FindGuestTicketRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTimeString))
            {
                query["DateTimeString"] = request.DateTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateTime))
            {
                query["EndDateTime"] = request.EndDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateTime))
            {
                query["StartDateTime"] = request.StartDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindGuestTicketRecord",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindGuestTicketRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云栖大会获取取票人信息list接口
         *
         * @param request FindGuestTicketRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindGuestTicketRecordResponse
         */
        public async Task<FindGuestTicketRecordResponse> FindGuestTicketRecordWithOptionsAsync(FindGuestTicketRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTimeString))
            {
                query["DateTimeString"] = request.DateTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateTime))
            {
                query["EndDateTime"] = request.EndDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateTime))
            {
                query["StartDateTime"] = request.StartDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindGuestTicketRecord",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindGuestTicketRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云栖大会获取取票人信息list接口
         *
         * @param request FindGuestTicketRecordRequest
         * @return FindGuestTicketRecordResponse
         */
        public FindGuestTicketRecordResponse FindGuestTicketRecord(FindGuestTicketRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindGuestTicketRecordWithOptions(request, runtime);
        }

        /**
         * @summary 云栖大会获取取票人信息list接口
         *
         * @param request FindGuestTicketRecordRequest
         * @return FindGuestTicketRecordResponse
         */
        public async Task<FindGuestTicketRecordResponse> FindGuestTicketRecordAsync(FindGuestTicketRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindGuestTicketRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryAllActivityInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllActivityInfoResponse
         */
        public QueryAllActivityInfoResponse QueryAllActivityInfoWithOptions(QueryAllActivityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAllActivityInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllActivityInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryAllActivityInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllActivityInfoResponse
         */
        public async Task<QueryAllActivityInfoResponse> QueryAllActivityInfoWithOptionsAsync(QueryAllActivityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAllActivityInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllActivityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryAllActivityInfoRequest
         * @return QueryAllActivityInfoResponse
         */
        public QueryAllActivityInfoResponse QueryAllActivityInfo(QueryAllActivityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAllActivityInfoWithOptions(request, runtime);
        }

        /**
         * @param request QueryAllActivityInfoRequest
         * @return QueryAllActivityInfoResponse
         */
        public async Task<QueryAllActivityInfoResponse> QueryAllActivityInfoAsync(QueryAllActivityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAllActivityInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QuerySingleActivityInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySingleActivityInfoResponse
         */
        public QuerySingleActivityInfoResponse QuerySingleActivityInfoWithOptions(QuerySingleActivityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySingleActivityInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleActivityInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QuerySingleActivityInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySingleActivityInfoResponse
         */
        public async Task<QuerySingleActivityInfoResponse> QuerySingleActivityInfoWithOptionsAsync(QuerySingleActivityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySingleActivityInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleActivityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QuerySingleActivityInfoRequest
         * @return QuerySingleActivityInfoResponse
         */
        public QuerySingleActivityInfoResponse QuerySingleActivityInfo(QuerySingleActivityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySingleActivityInfoWithOptions(request, runtime);
        }

        /**
         * @param request QuerySingleActivityInfoRequest
         * @return QuerySingleActivityInfoResponse
         */
        public async Task<QuerySingleActivityInfoResponse> QuerySingleActivityInfoAsync(QuerySingleActivityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySingleActivityInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SyncSignInInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncSignInInfoResponse
         */
        public SyncSignInInfoResponse SyncSignInInfoWithOptions(SyncSignInInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSignInInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSignInInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SyncSignInInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncSignInInfoResponse
         */
        public async Task<SyncSignInInfoResponse> SyncSignInInfoWithOptionsAsync(SyncSignInInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSignInInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSignInInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SyncSignInInfoRequest
         * @return SyncSignInInfoResponse
         */
        public SyncSignInInfoResponse SyncSignInInfo(SyncSignInInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncSignInInfoWithOptions(request, runtime);
        }

        /**
         * @param request SyncSignInInfoRequest
         * @return SyncSignInInfoResponse
         */
        public async Task<SyncSignInInfoResponse> SyncSignInInfoAsync(SyncSignInInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncSignInInfoWithOptionsAsync(request, runtime);
        }

    }
}
