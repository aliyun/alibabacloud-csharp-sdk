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
            this._signatureAlgorithm = "v2";
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
         * @summary 账号工厂批量注册账号
         *
         * @param request BatchEnrollAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchEnrollAccountsResponse
         */
        public BatchEnrollAccountsResponse BatchEnrollAccountsWithOptions(BatchEnrollAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accounts))
            {
                query["Accounts"] = request.Accounts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineId))
            {
                query["BaselineId"] = request.BaselineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineItems))
            {
                query["BaselineItems"] = request.BaselineItems;
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
                Action = "BatchEnrollAccounts",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchEnrollAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 账号工厂批量注册账号
         *
         * @param request BatchEnrollAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchEnrollAccountsResponse
         */
        public async Task<BatchEnrollAccountsResponse> BatchEnrollAccountsWithOptionsAsync(BatchEnrollAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accounts))
            {
                query["Accounts"] = request.Accounts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineId))
            {
                query["BaselineId"] = request.BaselineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineItems))
            {
                query["BaselineItems"] = request.BaselineItems;
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
                Action = "BatchEnrollAccounts",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchEnrollAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 账号工厂批量注册账号
         *
         * @param request BatchEnrollAccountsRequest
         * @return BatchEnrollAccountsResponse
         */
        public BatchEnrollAccountsResponse BatchEnrollAccounts(BatchEnrollAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchEnrollAccountsWithOptions(request, runtime);
        }

        /**
         * @summary 账号工厂批量注册账号
         *
         * @param request BatchEnrollAccountsRequest
         * @return BatchEnrollAccountsResponse
         */
        public async Task<BatchEnrollAccountsResponse> BatchEnrollAccountsAsync(BatchEnrollAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchEnrollAccountsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建账号工厂基线
         *
         * @param request CreateAccountFactoryBaselineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccountFactoryBaselineResponse
         */
        public CreateAccountFactoryBaselineResponse CreateAccountFactoryBaselineWithOptions(CreateAccountFactoryBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineItems))
            {
                query["BaselineItems"] = request.BaselineItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineName))
            {
                query["BaselineName"] = request.BaselineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
                Action = "CreateAccountFactoryBaseline",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountFactoryBaselineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建账号工厂基线
         *
         * @param request CreateAccountFactoryBaselineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccountFactoryBaselineResponse
         */
        public async Task<CreateAccountFactoryBaselineResponse> CreateAccountFactoryBaselineWithOptionsAsync(CreateAccountFactoryBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineItems))
            {
                query["BaselineItems"] = request.BaselineItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineName))
            {
                query["BaselineName"] = request.BaselineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
                Action = "CreateAccountFactoryBaseline",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountFactoryBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建账号工厂基线
         *
         * @param request CreateAccountFactoryBaselineRequest
         * @return CreateAccountFactoryBaselineResponse
         */
        public CreateAccountFactoryBaselineResponse CreateAccountFactoryBaseline(CreateAccountFactoryBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccountFactoryBaselineWithOptions(request, runtime);
        }

        /**
         * @summary 创建账号工厂基线
         *
         * @param request CreateAccountFactoryBaselineRequest
         * @return CreateAccountFactoryBaselineResponse
         */
        public async Task<CreateAccountFactoryBaselineResponse> CreateAccountFactoryBaselineAsync(CreateAccountFactoryBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccountFactoryBaselineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除账号工厂基线
         *
         * @param request DeleteAccountFactoryBaselineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccountFactoryBaselineResponse
         */
        public DeleteAccountFactoryBaselineResponse DeleteAccountFactoryBaselineWithOptions(DeleteAccountFactoryBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAccountFactoryBaseline",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountFactoryBaselineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除账号工厂基线
         *
         * @param request DeleteAccountFactoryBaselineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccountFactoryBaselineResponse
         */
        public async Task<DeleteAccountFactoryBaselineResponse> DeleteAccountFactoryBaselineWithOptionsAsync(DeleteAccountFactoryBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAccountFactoryBaseline",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountFactoryBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除账号工厂基线
         *
         * @param request DeleteAccountFactoryBaselineRequest
         * @return DeleteAccountFactoryBaselineResponse
         */
        public DeleteAccountFactoryBaselineResponse DeleteAccountFactoryBaseline(DeleteAccountFactoryBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccountFactoryBaselineWithOptions(request, runtime);
        }

        /**
         * @summary 删除账号工厂基线
         *
         * @param request DeleteAccountFactoryBaselineRequest
         * @return DeleteAccountFactoryBaselineResponse
         */
        public async Task<DeleteAccountFactoryBaselineResponse> DeleteAccountFactoryBaselineAsync(DeleteAccountFactoryBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccountFactoryBaselineWithOptionsAsync(request, runtime);
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
         * @summary 获取账号工厂基线元素列表
         *
         * @param request ListAccountFactoryBaselineItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountFactoryBaselineItemsResponse
         */
        public ListAccountFactoryBaselineItemsResponse ListAccountFactoryBaselineItemsWithOptions(ListAccountFactoryBaselineItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Versions))
            {
                query["Versions"] = request.Versions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountFactoryBaselineItems",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountFactoryBaselineItemsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取账号工厂基线元素列表
         *
         * @param request ListAccountFactoryBaselineItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountFactoryBaselineItemsResponse
         */
        public async Task<ListAccountFactoryBaselineItemsResponse> ListAccountFactoryBaselineItemsWithOptionsAsync(ListAccountFactoryBaselineItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Versions))
            {
                query["Versions"] = request.Versions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountFactoryBaselineItems",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountFactoryBaselineItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取账号工厂基线元素列表
         *
         * @param request ListAccountFactoryBaselineItemsRequest
         * @return ListAccountFactoryBaselineItemsResponse
         */
        public ListAccountFactoryBaselineItemsResponse ListAccountFactoryBaselineItems(ListAccountFactoryBaselineItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountFactoryBaselineItemsWithOptions(request, runtime);
        }

        /**
         * @summary 获取账号工厂基线元素列表
         *
         * @param request ListAccountFactoryBaselineItemsRequest
         * @return ListAccountFactoryBaselineItemsResponse
         */
        public async Task<ListAccountFactoryBaselineItemsResponse> ListAccountFactoryBaselineItemsAsync(ListAccountFactoryBaselineItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountFactoryBaselineItemsWithOptionsAsync(request, runtime);
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

        /**
         * @summary 查看治理检测定义
         *
         * @param request ListEvaluationMetadataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEvaluationMetadataResponse
         */
        public ListEvaluationMetadataResponse ListEvaluationMetadataWithOptions(ListEvaluationMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
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
                Action = "ListEvaluationMetadata",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationMetadataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看治理检测定义
         *
         * @param request ListEvaluationMetadataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEvaluationMetadataResponse
         */
        public async Task<ListEvaluationMetadataResponse> ListEvaluationMetadataWithOptionsAsync(ListEvaluationMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
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
                Action = "ListEvaluationMetadata",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看治理检测定义
         *
         * @param request ListEvaluationMetadataRequest
         * @return ListEvaluationMetadataResponse
         */
        public ListEvaluationMetadataResponse ListEvaluationMetadata(ListEvaluationMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEvaluationMetadataWithOptions(request, runtime);
        }

        /**
         * @summary 查看治理检测定义
         *
         * @param request ListEvaluationMetadataRequest
         * @return ListEvaluationMetadataResponse
         */
        public async Task<ListEvaluationMetadataResponse> ListEvaluationMetadataAsync(ListEvaluationMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEvaluationMetadataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取云治理中心治理检测项结果详情
         *
         * @param request ListEvaluationMetricDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEvaluationMetricDetailsResponse
         */
        public ListEvaluationMetricDetailsResponse ListEvaluationMetricDetailsWithOptions(ListEvaluationMetricDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "ListEvaluationMetricDetails",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationMetricDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取云治理中心治理检测项结果详情
         *
         * @param request ListEvaluationMetricDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEvaluationMetricDetailsResponse
         */
        public async Task<ListEvaluationMetricDetailsResponse> ListEvaluationMetricDetailsWithOptionsAsync(ListEvaluationMetricDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "ListEvaluationMetricDetails",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationMetricDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取云治理中心治理检测项结果详情
         *
         * @param request ListEvaluationMetricDetailsRequest
         * @return ListEvaluationMetricDetailsResponse
         */
        public ListEvaluationMetricDetailsResponse ListEvaluationMetricDetails(ListEvaluationMetricDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEvaluationMetricDetailsWithOptions(request, runtime);
        }

        /**
         * @summary 获取云治理中心治理检测项结果详情
         *
         * @param request ListEvaluationMetricDetailsRequest
         * @return ListEvaluationMetricDetailsResponse
         */
        public async Task<ListEvaluationMetricDetailsResponse> ListEvaluationMetricDetailsAsync(ListEvaluationMetricDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEvaluationMetricDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看检测结果
         *
         * @param request ListEvaluationResultsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEvaluationResultsResponse
         */
        public ListEvaluationResultsResponse ListEvaluationResultsWithOptions(ListEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
                Action = "ListEvaluationResults",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看检测结果
         *
         * @param request ListEvaluationResultsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEvaluationResultsResponse
         */
        public async Task<ListEvaluationResultsResponse> ListEvaluationResultsWithOptionsAsync(ListEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
                Action = "ListEvaluationResults",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看检测结果
         *
         * @param request ListEvaluationResultsRequest
         * @return ListEvaluationResultsResponse
         */
        public ListEvaluationResultsResponse ListEvaluationResults(ListEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEvaluationResultsWithOptions(request, runtime);
        }

        /**
         * @summary 查看检测结果
         *
         * @param request ListEvaluationResultsRequest
         * @return ListEvaluationResultsResponse
         */
        public async Task<ListEvaluationResultsResponse> ListEvaluationResultsAsync(ListEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEvaluationResultsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看治理检测定义
         *
         * @param request ListEvaluationScoreHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEvaluationScoreHistoryResponse
         */
        public ListEvaluationScoreHistoryResponse ListEvaluationScoreHistoryWithOptions(ListEvaluationScoreHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvaluationScoreHistory",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationScoreHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看治理检测定义
         *
         * @param request ListEvaluationScoreHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEvaluationScoreHistoryResponse
         */
        public async Task<ListEvaluationScoreHistoryResponse> ListEvaluationScoreHistoryWithOptionsAsync(ListEvaluationScoreHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvaluationScoreHistory",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationScoreHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看治理检测定义
         *
         * @param request ListEvaluationScoreHistoryRequest
         * @return ListEvaluationScoreHistoryResponse
         */
        public ListEvaluationScoreHistoryResponse ListEvaluationScoreHistory(ListEvaluationScoreHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEvaluationScoreHistoryWithOptions(request, runtime);
        }

        /**
         * @summary 查看治理检测定义
         *
         * @param request ListEvaluationScoreHistoryRequest
         * @return ListEvaluationScoreHistoryResponse
         */
        public async Task<ListEvaluationScoreHistoryResponse> ListEvaluationScoreHistoryAsync(ListEvaluationScoreHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEvaluationScoreHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 运行云治理中心治理检测
         *
         * @param request RunEvaluationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunEvaluationResponse
         */
        public RunEvaluationResponse RunEvaluationWithOptions(RunEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunEvaluation",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunEvaluationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 运行云治理中心治理检测
         *
         * @param request RunEvaluationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunEvaluationResponse
         */
        public async Task<RunEvaluationResponse> RunEvaluationWithOptionsAsync(RunEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunEvaluation",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunEvaluationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 运行云治理中心治理检测
         *
         * @param request RunEvaluationRequest
         * @return RunEvaluationResponse
         */
        public RunEvaluationResponse RunEvaluation(RunEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunEvaluationWithOptions(request, runtime);
        }

        /**
         * @summary 运行云治理中心治理检测
         *
         * @param request RunEvaluationRequest
         * @return RunEvaluationResponse
         */
        public async Task<RunEvaluationResponse> RunEvaluationAsync(RunEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunEvaluationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新账号工厂基线
         *
         * @param request UpdateAccountFactoryBaselineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAccountFactoryBaselineResponse
         */
        public UpdateAccountFactoryBaselineResponse UpdateAccountFactoryBaselineWithOptions(UpdateAccountFactoryBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineId))
            {
                query["BaselineId"] = request.BaselineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineItems))
            {
                query["BaselineItems"] = request.BaselineItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineName))
            {
                query["BaselineName"] = request.BaselineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
                Action = "UpdateAccountFactoryBaseline",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountFactoryBaselineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新账号工厂基线
         *
         * @param request UpdateAccountFactoryBaselineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAccountFactoryBaselineResponse
         */
        public async Task<UpdateAccountFactoryBaselineResponse> UpdateAccountFactoryBaselineWithOptionsAsync(UpdateAccountFactoryBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineId))
            {
                query["BaselineId"] = request.BaselineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineItems))
            {
                query["BaselineItems"] = request.BaselineItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineName))
            {
                query["BaselineName"] = request.BaselineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
                Action = "UpdateAccountFactoryBaseline",
                Version = "2021-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountFactoryBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新账号工厂基线
         *
         * @param request UpdateAccountFactoryBaselineRequest
         * @return UpdateAccountFactoryBaselineResponse
         */
        public UpdateAccountFactoryBaselineResponse UpdateAccountFactoryBaseline(UpdateAccountFactoryBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccountFactoryBaselineWithOptions(request, runtime);
        }

        /**
         * @summary 更新账号工厂基线
         *
         * @param request UpdateAccountFactoryBaselineRequest
         * @return UpdateAccountFactoryBaselineResponse
         */
        public async Task<UpdateAccountFactoryBaselineResponse> UpdateAccountFactoryBaselineAsync(UpdateAccountFactoryBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccountFactoryBaselineWithOptionsAsync(request, runtime);
        }

    }
}
