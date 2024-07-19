// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Governance20210120.Models;

namespace AlibabaCloud.SDK.Governance20210120
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("governance", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Enrolls an account. You can create a new account or manage an existing account in the account factory.
         *
         * @description You can call this API operation to create a new account or manage an existing account and apply the account baseline to the account.
         * Accounts are created in asynchronous mode. After you create an account, you can apply the account baseline to the account. You can call the [GetEnrolledAccount API](~~GetEnrolledAccount~~) operation to view the details about the account to obtain the result of applying the account baseline to the account.
         *
         * @param request EnrollAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnrollAccountResponse
         */
        public EnrollAccountResponse EnrollAccountWithOptions(EnrollAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNamePrefix))
            {
                query["AccountNamePrefix"] = request.AccountNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountUid))
            {
                query["AccountUid"] = request.AccountUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineId))
            {
                query["BaselineId"] = request.BaselineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineItems))
            {
                query["BaselineItems"] = request.BaselineItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerAccountUid))
            {
                query["PayerAccountUid"] = request.PayerAccountUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResellAccountType))
            {
                query["ResellAccountType"] = request.ResellAccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnrollAccount",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnrollAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enrolls an account. You can create a new account or manage an existing account in the account factory.
         *
         * @description You can call this API operation to create a new account or manage an existing account and apply the account baseline to the account.
         * Accounts are created in asynchronous mode. After you create an account, you can apply the account baseline to the account. You can call the [GetEnrolledAccount API](~~GetEnrolledAccount~~) operation to view the details about the account to obtain the result of applying the account baseline to the account.
         *
         * @param request EnrollAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnrollAccountResponse
         */
        public async Task<EnrollAccountResponse> EnrollAccountWithOptionsAsync(EnrollAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNamePrefix))
            {
                query["AccountNamePrefix"] = request.AccountNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountUid))
            {
                query["AccountUid"] = request.AccountUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineId))
            {
                query["BaselineId"] = request.BaselineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineItems))
            {
                query["BaselineItems"] = request.BaselineItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerAccountUid))
            {
                query["PayerAccountUid"] = request.PayerAccountUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResellAccountType))
            {
                query["ResellAccountType"] = request.ResellAccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnrollAccount",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnrollAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enrolls an account. You can create a new account or manage an existing account in the account factory.
         *
         * @description You can call this API operation to create a new account or manage an existing account and apply the account baseline to the account.
         * Accounts are created in asynchronous mode. After you create an account, you can apply the account baseline to the account. You can call the [GetEnrolledAccount API](~~GetEnrolledAccount~~) operation to view the details about the account to obtain the result of applying the account baseline to the account.
         *
         * @param request EnrollAccountRequest
         * @return EnrollAccountResponse
         */
        public EnrollAccountResponse EnrollAccount(EnrollAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnrollAccountWithOptions(request, runtime);
        }

        /**
         * @summary Enrolls an account. You can create a new account or manage an existing account in the account factory.
         *
         * @description You can call this API operation to create a new account or manage an existing account and apply the account baseline to the account.
         * Accounts are created in asynchronous mode. After you create an account, you can apply the account baseline to the account. You can call the [GetEnrolledAccount API](~~GetEnrolledAccount~~) operation to view the details about the account to obtain the result of applying the account baseline to the account.
         *
         * @param request EnrollAccountRequest
         * @return EnrollAccountResponse
         */
        public async Task<EnrollAccountResponse> EnrollAccountAsync(EnrollAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnrollAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the details of an account factory baseline.
         *
         * @param request GetAccountFactoryBaselineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountFactoryBaselineResponse
         */
        public GetAccountFactoryBaselineResponse GetAccountFactoryBaselineWithOptions(GetAccountFactoryBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineId))
            {
                query["BaselineId"] = request.BaselineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountFactoryBaseline",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountFactoryBaselineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of an account factory baseline.
         *
         * @param request GetAccountFactoryBaselineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountFactoryBaselineResponse
         */
        public async Task<GetAccountFactoryBaselineResponse> GetAccountFactoryBaselineWithOptionsAsync(GetAccountFactoryBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineId))
            {
                query["BaselineId"] = request.BaselineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountFactoryBaseline",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountFactoryBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of an account factory baseline.
         *
         * @param request GetAccountFactoryBaselineRequest
         * @return GetAccountFactoryBaselineResponse
         */
        public GetAccountFactoryBaselineResponse GetAccountFactoryBaseline(GetAccountFactoryBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountFactoryBaselineWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the details of an account factory baseline.
         *
         * @param request GetAccountFactoryBaselineRequest
         * @return GetAccountFactoryBaselineResponse
         */
        public async Task<GetAccountFactoryBaselineResponse> GetAccountFactoryBaselineAsync(GetAccountFactoryBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountFactoryBaselineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about an account that is enrolled in the account factory.
         *
         * @param request GetEnrolledAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnrolledAccountResponse
         */
        public GetEnrolledAccountResponse GetEnrolledAccountWithOptions(GetEnrolledAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountUid))
            {
                query["AccountUid"] = request.AccountUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnrolledAccount",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnrolledAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about an account that is enrolled in the account factory.
         *
         * @param request GetEnrolledAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnrolledAccountResponse
         */
        public async Task<GetEnrolledAccountResponse> GetEnrolledAccountWithOptionsAsync(GetEnrolledAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountUid))
            {
                query["AccountUid"] = request.AccountUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnrolledAccount",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnrolledAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about an account that is enrolled in the account factory.
         *
         * @param request GetEnrolledAccountRequest
         * @return GetEnrolledAccountResponse
         */
        public GetEnrolledAccountResponse GetEnrolledAccount(GetEnrolledAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEnrolledAccountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about an account that is enrolled in the account factory.
         *
         * @param request GetEnrolledAccountRequest
         * @return GetEnrolledAccountResponse
         */
        public async Task<GetEnrolledAccountResponse> GetEnrolledAccountAsync(GetEnrolledAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEnrolledAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains a list of baselines in the account factory.
         *
         * @param request ListAccountFactoryBaselinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountFactoryBaselinesResponse
         */
        public ListAccountFactoryBaselinesResponse ListAccountFactoryBaselinesWithOptions(ListAccountFactoryBaselinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountFactoryBaselines",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountFactoryBaselinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of baselines in the account factory.
         *
         * @param request ListAccountFactoryBaselinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountFactoryBaselinesResponse
         */
        public async Task<ListAccountFactoryBaselinesResponse> ListAccountFactoryBaselinesWithOptionsAsync(ListAccountFactoryBaselinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountFactoryBaselines",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountFactoryBaselinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of baselines in the account factory.
         *
         * @param request ListAccountFactoryBaselinesRequest
         * @return ListAccountFactoryBaselinesResponse
         */
        public ListAccountFactoryBaselinesResponse ListAccountFactoryBaselines(ListAccountFactoryBaselinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountFactoryBaselinesWithOptions(request, runtime);
        }

        /**
         * @summary Obtains a list of baselines in the account factory.
         *
         * @param request ListAccountFactoryBaselinesRequest
         * @return ListAccountFactoryBaselinesResponse
         */
        public async Task<ListAccountFactoryBaselinesResponse> ListAccountFactoryBaselinesAsync(ListAccountFactoryBaselinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountFactoryBaselinesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of accounts that are enrolled in the account factory.
         *
         * @param request ListEnrolledAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnrolledAccountsResponse
         */
        public ListEnrolledAccountsResponse ListEnrolledAccountsWithOptions(ListEnrolledAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnrolledAccounts",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnrolledAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of accounts that are enrolled in the account factory.
         *
         * @param request ListEnrolledAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnrolledAccountsResponse
         */
        public async Task<ListEnrolledAccountsResponse> ListEnrolledAccountsWithOptionsAsync(ListEnrolledAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnrolledAccounts",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnrolledAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of accounts that are enrolled in the account factory.
         *
         * @param request ListEnrolledAccountsRequest
         * @return ListEnrolledAccountsResponse
         */
        public ListEnrolledAccountsResponse ListEnrolledAccounts(ListEnrolledAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnrolledAccountsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of accounts that are enrolled in the account factory.
         *
         * @param request ListEnrolledAccountsRequest
         * @return ListEnrolledAccountsResponse
         */
        public async Task<ListEnrolledAccountsResponse> ListEnrolledAccountsAsync(ListEnrolledAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnrolledAccountsWithOptionsAsync(request, runtime);
        }

    }
}
