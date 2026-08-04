// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Account_crm20160606.Models;

namespace AlibabaCloud.SDK.Account_crm20160606
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("account-crm", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// AccountOneKeyDeleteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AccountOneKeyDeleteResponse
        /// </returns>
        public AccountOneKeyDeleteResponse AccountOneKeyDeleteWithOptions(AccountOneKeyDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccountOneKeyDelete",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccountOneKeyDeleteResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AccountOneKeyDeleteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AccountOneKeyDeleteResponse
        /// </returns>
        public async Task<AccountOneKeyDeleteResponse> AccountOneKeyDeleteWithOptionsAsync(AccountOneKeyDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccountOneKeyDelete",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccountOneKeyDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AccountOneKeyDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// AccountOneKeyDeleteResponse
        /// </returns>
        public AccountOneKeyDeleteResponse AccountOneKeyDelete(AccountOneKeyDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AccountOneKeyDeleteWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AccountOneKeyDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// AccountOneKeyDeleteResponse
        /// </returns>
        public async Task<AccountOneKeyDeleteResponse> AccountOneKeyDeleteAsync(AccountOneKeyDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AccountOneKeyDeleteWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AddCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerLabelResponse
        /// </returns>
        public AddCustomerLabelResponse AddCustomerLabelWithOptions(AddCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endtime))
            {
                query["Endtime"] = request.Endtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTypes))
            {
                query["LabelTypes"] = request.LabelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomerLabel",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomerLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerLabelResponse
        /// </returns>
        public async Task<AddCustomerLabelResponse> AddCustomerLabelWithOptionsAsync(AddCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endtime))
            {
                query["Endtime"] = request.Endtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTypes))
            {
                query["LabelTypes"] = request.LabelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomerLabel",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomerLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerLabelResponse
        /// </returns>
        public AddCustomerLabelResponse AddCustomerLabel(AddCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomerLabelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerLabelResponse
        /// </returns>
        public async Task<AddCustomerLabelResponse> AddCustomerLabelAsync(AddCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomerLabelWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AllowAgAccountLoginRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllowAgAccountLoginResponse
        /// </returns>
        public AllowAgAccountLoginResponse AllowAgAccountLoginWithOptions(AllowAgAccountLoginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllowAgAccountLogin",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllowAgAccountLoginResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AllowAgAccountLoginRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllowAgAccountLoginResponse
        /// </returns>
        public async Task<AllowAgAccountLoginResponse> AllowAgAccountLoginWithOptionsAsync(AllowAgAccountLoginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllowAgAccountLogin",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllowAgAccountLoginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AllowAgAccountLoginRequest
        /// </param>
        /// 
        /// <returns>
        /// AllowAgAccountLoginResponse
        /// </returns>
        public AllowAgAccountLoginResponse AllowAgAccountLogin(AllowAgAccountLoginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllowAgAccountLoginWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AllowAgAccountLoginRequest
        /// </param>
        /// 
        /// <returns>
        /// AllowAgAccountLoginResponse
        /// </returns>
        public async Task<AllowAgAccountLoginResponse> AllowAgAccountLoginAsync(AllowAgAccountLoginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllowAgAccountLoginWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAgOneKeyDeleteTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyAgOneKeyDeleteTaskResponse
        /// </returns>
        public ApplyAgOneKeyDeleteTaskResponse ApplyAgOneKeyDeleteTaskWithOptions(ApplyAgOneKeyDeleteTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbandonedDependency))
            {
                query["AbandonedDependency"] = request.AbandonedDependency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAgOneKeyDeleteTask",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAgOneKeyDeleteTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAgOneKeyDeleteTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyAgOneKeyDeleteTaskResponse
        /// </returns>
        public async Task<ApplyAgOneKeyDeleteTaskResponse> ApplyAgOneKeyDeleteTaskWithOptionsAsync(ApplyAgOneKeyDeleteTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbandonedDependency))
            {
                query["AbandonedDependency"] = request.AbandonedDependency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAgOneKeyDeleteTask",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAgOneKeyDeleteTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAgOneKeyDeleteTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyAgOneKeyDeleteTaskResponse
        /// </returns>
        public ApplyAgOneKeyDeleteTaskResponse ApplyAgOneKeyDeleteTask(ApplyAgOneKeyDeleteTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAgOneKeyDeleteTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAgOneKeyDeleteTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyAgOneKeyDeleteTaskResponse
        /// </returns>
        public async Task<ApplyAgOneKeyDeleteTaskResponse> ApplyAgOneKeyDeleteTaskAsync(ApplyAgOneKeyDeleteTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAgOneKeyDeleteTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAgOneKeyOnlyCheckerTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyAgOneKeyOnlyCheckerTaskResponse
        /// </returns>
        public ApplyAgOneKeyOnlyCheckerTaskResponse ApplyAgOneKeyOnlyCheckerTaskWithOptions(ApplyAgOneKeyOnlyCheckerTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAgOneKeyOnlyCheckerTask",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAgOneKeyOnlyCheckerTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAgOneKeyOnlyCheckerTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyAgOneKeyOnlyCheckerTaskResponse
        /// </returns>
        public async Task<ApplyAgOneKeyOnlyCheckerTaskResponse> ApplyAgOneKeyOnlyCheckerTaskWithOptionsAsync(ApplyAgOneKeyOnlyCheckerTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAgOneKeyOnlyCheckerTask",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAgOneKeyOnlyCheckerTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAgOneKeyOnlyCheckerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyAgOneKeyOnlyCheckerTaskResponse
        /// </returns>
        public ApplyAgOneKeyOnlyCheckerTaskResponse ApplyAgOneKeyOnlyCheckerTask(ApplyAgOneKeyOnlyCheckerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAgOneKeyOnlyCheckerTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAgOneKeyOnlyCheckerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyAgOneKeyOnlyCheckerTaskResponse
        /// </returns>
        public async Task<ApplyAgOneKeyOnlyCheckerTaskResponse> ApplyAgOneKeyOnlyCheckerTaskAsync(ApplyAgOneKeyOnlyCheckerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAgOneKeyOnlyCheckerTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ApplyIdentityRegistrationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyIdentityRegistrationResponse
        /// </returns>
        public ApplyIdentityRegistrationResponse ApplyIdentityRegistrationWithOptions(ApplyIdentityRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocBackPic))
            {
                query["DocBackPic"] = request.DocBackPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocFrontPic))
            {
                query["DocFrontPic"] = request.DocFrontPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNum))
            {
                query["DocNum"] = request.DocNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullName))
            {
                query["FullName"] = request.FullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisteredAddress))
            {
                query["RegisteredAddress"] = request.RegisteredAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisteredCountry))
            {
                query["RegisteredCountry"] = request.RegisteredCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisteredNum))
            {
                query["RegisteredNum"] = request.RegisteredNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyIdentityRegistration",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyIdentityRegistrationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ApplyIdentityRegistrationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyIdentityRegistrationResponse
        /// </returns>
        public async Task<ApplyIdentityRegistrationResponse> ApplyIdentityRegistrationWithOptionsAsync(ApplyIdentityRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocBackPic))
            {
                query["DocBackPic"] = request.DocBackPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocFrontPic))
            {
                query["DocFrontPic"] = request.DocFrontPic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNum))
            {
                query["DocNum"] = request.DocNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullName))
            {
                query["FullName"] = request.FullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisteredAddress))
            {
                query["RegisteredAddress"] = request.RegisteredAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisteredCountry))
            {
                query["RegisteredCountry"] = request.RegisteredCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisteredNum))
            {
                query["RegisteredNum"] = request.RegisteredNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyIdentityRegistration",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyIdentityRegistrationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ApplyIdentityRegistrationRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyIdentityRegistrationResponse
        /// </returns>
        public ApplyIdentityRegistrationResponse ApplyIdentityRegistration(ApplyIdentityRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyIdentityRegistrationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ApplyIdentityRegistrationRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyIdentityRegistrationResponse
        /// </returns>
        public async Task<ApplyIdentityRegistrationResponse> ApplyIdentityRegistrationAsync(ApplyIdentityRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyIdentityRegistrationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AsyncCreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsyncCreateAgAccountResponse
        /// </returns>
        public AsyncCreateAgAccountResponse AsyncCreateAgAccountWithOptions(AsyncCreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaserAccountInfo))
            {
                query["MaserAccountInfo"] = request.MaserAccountInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsyncCreateAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AsyncCreateAgAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AsyncCreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsyncCreateAgAccountResponse
        /// </returns>
        public async Task<AsyncCreateAgAccountResponse> AsyncCreateAgAccountWithOptionsAsync(AsyncCreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaserAccountInfo))
            {
                query["MaserAccountInfo"] = request.MaserAccountInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsyncCreateAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AsyncCreateAgAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AsyncCreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// AsyncCreateAgAccountResponse
        /// </returns>
        public AsyncCreateAgAccountResponse AsyncCreateAgAccount(AsyncCreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsyncCreateAgAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AsyncCreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// AsyncCreateAgAccountResponse
        /// </returns>
        public async Task<AsyncCreateAgAccountResponse> AsyncCreateAgAccountAsync(AsyncCreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsyncCreateAgAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AsyncModifyAgLoginEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsyncModifyAgLoginEmailResponse
        /// </returns>
        public AsyncModifyAgLoginEmailResponse AsyncModifyAgLoginEmailWithOptions(AsyncModifyAgLoginEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewLoginEmail))
            {
                query["NewLoginEmail"] = request.NewLoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsyncModifyAgLoginEmail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AsyncModifyAgLoginEmailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AsyncModifyAgLoginEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsyncModifyAgLoginEmailResponse
        /// </returns>
        public async Task<AsyncModifyAgLoginEmailResponse> AsyncModifyAgLoginEmailWithOptionsAsync(AsyncModifyAgLoginEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewLoginEmail))
            {
                query["NewLoginEmail"] = request.NewLoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsyncModifyAgLoginEmail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AsyncModifyAgLoginEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AsyncModifyAgLoginEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// AsyncModifyAgLoginEmailResponse
        /// </returns>
        public AsyncModifyAgLoginEmailResponse AsyncModifyAgLoginEmail(AsyncModifyAgLoginEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsyncModifyAgLoginEmailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AsyncModifyAgLoginEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// AsyncModifyAgLoginEmailResponse
        /// </returns>
        public async Task<AsyncModifyAgLoginEmailResponse> AsyncModifyAgLoginEmailAsync(AsyncModifyAgLoginEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsyncModifyAgLoginEmailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AuthAndActiveWithHidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthAndActiveWithHidResponse
        /// </returns>
        public AuthAndActiveWithHidResponse AuthAndActiveWithHidWithOptions(AuthAndActiveWithHidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthAndActiveWithHid",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthAndActiveWithHidResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthAndActiveWithHidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthAndActiveWithHidResponse
        /// </returns>
        public async Task<AuthAndActiveWithHidResponse> AuthAndActiveWithHidWithOptionsAsync(AuthAndActiveWithHidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthAndActiveWithHid",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthAndActiveWithHidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthAndActiveWithHidRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthAndActiveWithHidResponse
        /// </returns>
        public AuthAndActiveWithHidResponse AuthAndActiveWithHid(AuthAndActiveWithHidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthAndActiveWithHidWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AuthAndActiveWithHidRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthAndActiveWithHidResponse
        /// </returns>
        public async Task<AuthAndActiveWithHidResponse> AuthAndActiveWithHidAsync(AuthAndActiveWithHidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthAndActiveWithHidWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AuthAndRefreshLoginTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthAndRefreshLoginTicketResponse
        /// </returns>
        public AuthAndRefreshLoginTicketResponse AuthAndRefreshLoginTicketWithOptions(AuthAndRefreshLoginTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthAndRefreshLoginTicket",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthAndRefreshLoginTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthAndRefreshLoginTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthAndRefreshLoginTicketResponse
        /// </returns>
        public async Task<AuthAndRefreshLoginTicketResponse> AuthAndRefreshLoginTicketWithOptionsAsync(AuthAndRefreshLoginTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthAndRefreshLoginTicket",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthAndRefreshLoginTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthAndRefreshLoginTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthAndRefreshLoginTicketResponse
        /// </returns>
        public AuthAndRefreshLoginTicketResponse AuthAndRefreshLoginTicket(AuthAndRefreshLoginTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthAndRefreshLoginTicketWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AuthAndRefreshLoginTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthAndRefreshLoginTicketResponse
        /// </returns>
        public async Task<AuthAndRefreshLoginTicketResponse> AuthAndRefreshLoginTicketAsync(AuthAndRefreshLoginTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthAndRefreshLoginTicketWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AuthLoginTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginTicketResponse
        /// </returns>
        public AuthLoginTicketResponse AuthLoginTicketWithOptions(AuthLoginTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorAuthCode))
            {
                query["MinorAuthCode"] = request.MinorAuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthLoginTicket",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthLoginTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginTicketResponse
        /// </returns>
        public async Task<AuthLoginTicketResponse> AuthLoginTicketWithOptionsAsync(AuthLoginTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorAuthCode))
            {
                query["MinorAuthCode"] = request.MinorAuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthLoginTicket",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthLoginTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthLoginTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginTicketResponse
        /// </returns>
        public AuthLoginTicketResponse AuthLoginTicket(AuthLoginTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthLoginTicketWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AuthLoginTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthLoginTicketResponse
        /// </returns>
        public async Task<AuthLoginTicketResponse> AuthLoginTicketAsync(AuthLoginTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthLoginTicketWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// BatchQueryAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryAgAccountResponse
        /// </returns>
        public BatchQueryAgAccountResponse BatchQueryAgAccountWithOptions(BatchQueryAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkList))
            {
                query["PkList"] = request.PkList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryAgAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BatchQueryAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryAgAccountResponse
        /// </returns>
        public async Task<BatchQueryAgAccountResponse> BatchQueryAgAccountWithOptionsAsync(BatchQueryAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkList))
            {
                query["PkList"] = request.PkList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryAgAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BatchQueryAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryAgAccountResponse
        /// </returns>
        public BatchQueryAgAccountResponse BatchQueryAgAccount(BatchQueryAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQueryAgAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BatchQueryAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryAgAccountResponse
        /// </returns>
        public async Task<BatchQueryAgAccountResponse> BatchQueryAgAccountAsync(BatchQueryAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQueryAgAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// BatchQueryCreateAccountTraceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryCreateAccountTraceResponse
        /// </returns>
        public BatchQueryCreateAccountTraceResponse BatchQueryCreateAccountTraceWithOptions(BatchQueryCreateAccountTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNoList))
            {
                query["TraceNoList"] = request.TraceNoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryCreateAccountTrace",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryCreateAccountTraceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BatchQueryCreateAccountTraceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryCreateAccountTraceResponse
        /// </returns>
        public async Task<BatchQueryCreateAccountTraceResponse> BatchQueryCreateAccountTraceWithOptionsAsync(BatchQueryCreateAccountTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNoList))
            {
                query["TraceNoList"] = request.TraceNoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryCreateAccountTrace",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryCreateAccountTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BatchQueryCreateAccountTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryCreateAccountTraceResponse
        /// </returns>
        public BatchQueryCreateAccountTraceResponse BatchQueryCreateAccountTrace(BatchQueryCreateAccountTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQueryCreateAccountTraceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BatchQueryCreateAccountTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryCreateAccountTraceResponse
        /// </returns>
        public async Task<BatchQueryCreateAccountTraceResponse> BatchQueryCreateAccountTraceAsync(BatchQueryCreateAccountTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQueryCreateAccountTraceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// BatchQueryModifyLoginEmailTraceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryModifyLoginEmailTraceResponse
        /// </returns>
        public BatchQueryModifyLoginEmailTraceResponse BatchQueryModifyLoginEmailTraceWithOptions(BatchQueryModifyLoginEmailTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNoList))
            {
                query["TraceNoList"] = request.TraceNoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryModifyLoginEmailTrace",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryModifyLoginEmailTraceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BatchQueryModifyLoginEmailTraceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryModifyLoginEmailTraceResponse
        /// </returns>
        public async Task<BatchQueryModifyLoginEmailTraceResponse> BatchQueryModifyLoginEmailTraceWithOptionsAsync(BatchQueryModifyLoginEmailTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNoList))
            {
                query["TraceNoList"] = request.TraceNoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryModifyLoginEmailTrace",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryModifyLoginEmailTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BatchQueryModifyLoginEmailTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryModifyLoginEmailTraceResponse
        /// </returns>
        public BatchQueryModifyLoginEmailTraceResponse BatchQueryModifyLoginEmailTrace(BatchQueryModifyLoginEmailTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQueryModifyLoginEmailTraceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BatchQueryModifyLoginEmailTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryModifyLoginEmailTraceResponse
        /// </returns>
        public async Task<BatchQueryModifyLoginEmailTraceResponse> BatchQueryModifyLoginEmailTraceAsync(BatchQueryModifyLoginEmailTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQueryModifyLoginEmailTraceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CancelAsyncCreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncCreateAgAccountResponse
        /// </returns>
        public CancelAsyncCreateAgAccountResponse CancelAsyncCreateAgAccountWithOptions(CancelAsyncCreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNo))
            {
                query["TraceNo"] = request.TraceNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAsyncCreateAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAsyncCreateAgAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelAsyncCreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncCreateAgAccountResponse
        /// </returns>
        public async Task<CancelAsyncCreateAgAccountResponse> CancelAsyncCreateAgAccountWithOptionsAsync(CancelAsyncCreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNo))
            {
                query["TraceNo"] = request.TraceNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAsyncCreateAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAsyncCreateAgAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelAsyncCreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncCreateAgAccountResponse
        /// </returns>
        public CancelAsyncCreateAgAccountResponse CancelAsyncCreateAgAccount(CancelAsyncCreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAsyncCreateAgAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CancelAsyncCreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncCreateAgAccountResponse
        /// </returns>
        public async Task<CancelAsyncCreateAgAccountResponse> CancelAsyncCreateAgAccountAsync(CancelAsyncCreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAsyncCreateAgAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CancelAsyncModifyLoginEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncModifyLoginEmailResponse
        /// </returns>
        public CancelAsyncModifyLoginEmailResponse CancelAsyncModifyLoginEmailWithOptions(CancelAsyncModifyLoginEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNo))
            {
                query["TraceNo"] = request.TraceNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAsyncModifyLoginEmail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAsyncModifyLoginEmailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelAsyncModifyLoginEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncModifyLoginEmailResponse
        /// </returns>
        public async Task<CancelAsyncModifyLoginEmailResponse> CancelAsyncModifyLoginEmailWithOptionsAsync(CancelAsyncModifyLoginEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNo))
            {
                query["TraceNo"] = request.TraceNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAsyncModifyLoginEmail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAsyncModifyLoginEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelAsyncModifyLoginEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncModifyLoginEmailResponse
        /// </returns>
        public CancelAsyncModifyLoginEmailResponse CancelAsyncModifyLoginEmail(CancelAsyncModifyLoginEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAsyncModifyLoginEmailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CancelAsyncModifyLoginEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncModifyLoginEmailResponse
        /// </returns>
        public async Task<CancelAsyncModifyLoginEmailResponse> CancelAsyncModifyLoginEmailAsync(CancelAsyncModifyLoginEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAsyncModifyLoginEmailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeAgAccountNationalityCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgAccountNationalityCodeResponse
        /// </returns>
        public ChangeAgAccountNationalityCodeResponse ChangeAgAccountNationalityCodeWithOptions(ChangeAgAccountNationalityCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NationalityCode))
            {
                query["NationalityCode"] = request.NationalityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAgAccountNationalityCode",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAgAccountNationalityCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeAgAccountNationalityCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgAccountNationalityCodeResponse
        /// </returns>
        public async Task<ChangeAgAccountNationalityCodeResponse> ChangeAgAccountNationalityCodeWithOptionsAsync(ChangeAgAccountNationalityCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NationalityCode))
            {
                query["NationalityCode"] = request.NationalityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAgAccountNationalityCode",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAgAccountNationalityCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeAgAccountNationalityCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgAccountNationalityCodeResponse
        /// </returns>
        public ChangeAgAccountNationalityCodeResponse ChangeAgAccountNationalityCode(ChangeAgAccountNationalityCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAgAccountNationalityCodeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeAgAccountNationalityCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgAccountNationalityCodeResponse
        /// </returns>
        public async Task<ChangeAgAccountNationalityCodeResponse> ChangeAgAccountNationalityCodeAsync(ChangeAgAccountNationalityCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAgAccountNationalityCodeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeAgSecurityEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgSecurityEmailResponse
        /// </returns>
        public ChangeAgSecurityEmailResponse ChangeAgSecurityEmailWithOptions(ChangeAgSecurityEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEmail))
            {
                query["SecurityEmail"] = request.SecurityEmail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAgSecurityEmail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAgSecurityEmailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeAgSecurityEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgSecurityEmailResponse
        /// </returns>
        public async Task<ChangeAgSecurityEmailResponse> ChangeAgSecurityEmailWithOptionsAsync(ChangeAgSecurityEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEmail))
            {
                query["SecurityEmail"] = request.SecurityEmail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAgSecurityEmail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAgSecurityEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeAgSecurityEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgSecurityEmailResponse
        /// </returns>
        public ChangeAgSecurityEmailResponse ChangeAgSecurityEmail(ChangeAgSecurityEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAgSecurityEmailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeAgSecurityEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgSecurityEmailResponse
        /// </returns>
        public async Task<ChangeAgSecurityEmailResponse> ChangeAgSecurityEmailAsync(ChangeAgSecurityEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAgSecurityEmailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeAgSecurityMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgSecurityMobileResponse
        /// </returns>
        public ChangeAgSecurityMobileResponse ChangeAgSecurityMobileWithOptions(ChangeAgSecurityMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityMobile))
            {
                query["SecurityMobile"] = request.SecurityMobile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAgSecurityMobile",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAgSecurityMobileResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeAgSecurityMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgSecurityMobileResponse
        /// </returns>
        public async Task<ChangeAgSecurityMobileResponse> ChangeAgSecurityMobileWithOptionsAsync(ChangeAgSecurityMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityMobile))
            {
                query["SecurityMobile"] = request.SecurityMobile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAgSecurityMobile",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAgSecurityMobileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeAgSecurityMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgSecurityMobileResponse
        /// </returns>
        public ChangeAgSecurityMobileResponse ChangeAgSecurityMobile(ChangeAgSecurityMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAgSecurityMobileWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeAgSecurityMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeAgSecurityMobileResponse
        /// </returns>
        public async Task<ChangeAgSecurityMobileResponse> ChangeAgSecurityMobileAsync(ChangeAgSecurityMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAgSecurityMobileWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateAccountProfileInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccountProfileInfoResponse
        /// </returns>
        public CreateAccountProfileInfoResponse CreateAccountProfileInfoWithOptions(CreateAccountProfileInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountJson))
            {
                query["AccountJson"] = request.AccountJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccountProfileInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountProfileInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAccountProfileInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccountProfileInfoResponse
        /// </returns>
        public async Task<CreateAccountProfileInfoResponse> CreateAccountProfileInfoWithOptionsAsync(CreateAccountProfileInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountJson))
            {
                query["AccountJson"] = request.AccountJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccountProfileInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountProfileInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAccountProfileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccountProfileInfoResponse
        /// </returns>
        public CreateAccountProfileInfoResponse CreateAccountProfileInfo(CreateAccountProfileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccountProfileInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateAccountProfileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccountProfileInfoResponse
        /// </returns>
        public async Task<CreateAccountProfileInfoResponse> CreateAccountProfileInfoAsync(CreateAccountProfileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccountProfileInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgAccountResponse
        /// </returns>
        public CreateAgAccountResponse CreateAgAccountWithOptions(CreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NationCode))
            {
                query["NationCode"] = request.NationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Own))
            {
                query["Own"] = request.Own;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealParentPk))
            {
                query["RealParentPk"] = request.RealParentPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityMobile))
            {
                query["SecurityMobile"] = request.SecurityMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowNickName))
            {
                query["ShowNickName"] = request.ShowNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteNick))
            {
                query["SiteNick"] = request.SiteNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcAccountInfo))
            {
                query["srcAccountInfo"] = request.SrcAccountInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgAccountResponse
        /// </returns>
        public async Task<CreateAgAccountResponse> CreateAgAccountWithOptionsAsync(CreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NationCode))
            {
                query["NationCode"] = request.NationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Own))
            {
                query["Own"] = request.Own;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealParentPk))
            {
                query["RealParentPk"] = request.RealParentPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityMobile))
            {
                query["SecurityMobile"] = request.SecurityMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowNickName))
            {
                query["ShowNickName"] = request.ShowNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteNick))
            {
                query["SiteNick"] = request.SiteNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcAccountInfo))
            {
                query["srcAccountInfo"] = request.SrcAccountInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgAccountResponse
        /// </returns>
        public CreateAgAccountResponse CreateAgAccount(CreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgAccountResponse
        /// </returns>
        public async Task<CreateAgAccountResponse> CreateAgAccountAsync(CreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContacterResponse
        /// </returns>
        public CreateContacterResponse CreateContacterWithOptions(CreateContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterAddress))
            {
                query["ContacterAddress"] = request.ContacterAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterDingding))
            {
                query["ContacterDingding"] = request.ContacterDingding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterEmail))
            {
                query["ContacterEmail"] = request.ContacterEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterMobile))
            {
                query["ContacterMobile"] = request.ContacterMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterName))
            {
                query["ContacterName"] = request.ContacterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterPosition))
            {
                query["ContacterPosition"] = request.ContacterPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterStaffNo))
            {
                query["ContacterStaffNo"] = request.ContacterStaffNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterType))
            {
                query["ContacterType"] = request.ContacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterWangwang))
            {
                query["ContacterWangwang"] = request.ContacterWangwang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailConfirmed))
            {
                query["EmailConfirmed"] = request.EmailConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileConfirmed))
            {
                query["MobileConfirmed"] = request.MobileConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContacterResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContacterResponse
        /// </returns>
        public async Task<CreateContacterResponse> CreateContacterWithOptionsAsync(CreateContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterAddress))
            {
                query["ContacterAddress"] = request.ContacterAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterDingding))
            {
                query["ContacterDingding"] = request.ContacterDingding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterEmail))
            {
                query["ContacterEmail"] = request.ContacterEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterMobile))
            {
                query["ContacterMobile"] = request.ContacterMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterName))
            {
                query["ContacterName"] = request.ContacterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterPosition))
            {
                query["ContacterPosition"] = request.ContacterPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterStaffNo))
            {
                query["ContacterStaffNo"] = request.ContacterStaffNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterType))
            {
                query["ContacterType"] = request.ContacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterWangwang))
            {
                query["ContacterWangwang"] = request.ContacterWangwang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailConfirmed))
            {
                query["EmailConfirmed"] = request.EmailConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileConfirmed))
            {
                query["MobileConfirmed"] = request.MobileConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContacterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContacterResponse
        /// </returns>
        public CreateContacterResponse CreateContacter(CreateContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContacterWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContacterResponse
        /// </returns>
        public async Task<CreateContacterResponse> CreateContacterAsync(CreateContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContacterWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateRealNameCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRealNameCertificationResponse
        /// </returns>
        public CreateRealNameCertificationResponse CreateRealNameCertificationWithOptions(CreateRealNameCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCertifyType))
            {
                query["AccountCertifyType"] = request.AccountCertifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorporateLicenseNumber))
            {
                query["CorporateLicenseNumber"] = request.CorporateLicenseNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorporateName))
            {
                query["CorporateName"] = request.CorporateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseNumber))
            {
                query["LicenseNumber"] = request.LicenseNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseType))
            {
                query["LicenseType"] = request.LicenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRealNameCertification",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRealNameCertificationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateRealNameCertificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRealNameCertificationResponse
        /// </returns>
        public async Task<CreateRealNameCertificationResponse> CreateRealNameCertificationWithOptionsAsync(CreateRealNameCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCertifyType))
            {
                query["AccountCertifyType"] = request.AccountCertifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorporateLicenseNumber))
            {
                query["CorporateLicenseNumber"] = request.CorporateLicenseNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorporateName))
            {
                query["CorporateName"] = request.CorporateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseNumber))
            {
                query["LicenseNumber"] = request.LicenseNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseType))
            {
                query["LicenseType"] = request.LicenseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRealNameCertification",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRealNameCertificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateRealNameCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRealNameCertificationResponse
        /// </returns>
        public CreateRealNameCertificationResponse CreateRealNameCertification(CreateRealNameCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRealNameCertificationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateRealNameCertificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRealNameCertificationResponse
        /// </returns>
        public async Task<CreateRealNameCertificationResponse> CreateRealNameCertificationAsync(CreateRealNameCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRealNameCertificationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CustomerSensitiveInfoLogicalDeleteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CustomerSensitiveInfoLogicalDeleteResponse
        /// </returns>
        public CustomerSensitiveInfoLogicalDeleteResponse CustomerSensitiveInfoLogicalDeleteWithOptions(CustomerSensitiveInfoLogicalDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CustomerSensitiveInfoLogicalDelete",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomerSensitiveInfoLogicalDeleteResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CustomerSensitiveInfoLogicalDeleteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CustomerSensitiveInfoLogicalDeleteResponse
        /// </returns>
        public async Task<CustomerSensitiveInfoLogicalDeleteResponse> CustomerSensitiveInfoLogicalDeleteWithOptionsAsync(CustomerSensitiveInfoLogicalDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CustomerSensitiveInfoLogicalDelete",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomerSensitiveInfoLogicalDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CustomerSensitiveInfoLogicalDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// CustomerSensitiveInfoLogicalDeleteResponse
        /// </returns>
        public CustomerSensitiveInfoLogicalDeleteResponse CustomerSensitiveInfoLogicalDelete(CustomerSensitiveInfoLogicalDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CustomerSensitiveInfoLogicalDeleteWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CustomerSensitiveInfoLogicalDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// CustomerSensitiveInfoLogicalDeleteResponse
        /// </returns>
        public async Task<CustomerSensitiveInfoLogicalDeleteResponse> CustomerSensitiveInfoLogicalDeleteAsync(CustomerSensitiveInfoLogicalDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CustomerSensitiveInfoLogicalDeleteWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CustomerSensitiveInfoPhysicalDeleteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CustomerSensitiveInfoPhysicalDeleteResponse
        /// </returns>
        public CustomerSensitiveInfoPhysicalDeleteResponse CustomerSensitiveInfoPhysicalDeleteWithOptions(CustomerSensitiveInfoPhysicalDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CustomerSensitiveInfoPhysicalDelete",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomerSensitiveInfoPhysicalDeleteResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CustomerSensitiveInfoPhysicalDeleteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CustomerSensitiveInfoPhysicalDeleteResponse
        /// </returns>
        public async Task<CustomerSensitiveInfoPhysicalDeleteResponse> CustomerSensitiveInfoPhysicalDeleteWithOptionsAsync(CustomerSensitiveInfoPhysicalDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CustomerSensitiveInfoPhysicalDelete",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomerSensitiveInfoPhysicalDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CustomerSensitiveInfoPhysicalDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// CustomerSensitiveInfoPhysicalDeleteResponse
        /// </returns>
        public CustomerSensitiveInfoPhysicalDeleteResponse CustomerSensitiveInfoPhysicalDelete(CustomerSensitiveInfoPhysicalDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CustomerSensitiveInfoPhysicalDeleteWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CustomerSensitiveInfoPhysicalDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// CustomerSensitiveInfoPhysicalDeleteResponse
        /// </returns>
        public async Task<CustomerSensitiveInfoPhysicalDeleteResponse> CustomerSensitiveInfoPhysicalDeleteAsync(CustomerSensitiveInfoPhysicalDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CustomerSensitiveInfoPhysicalDeleteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步Del缓存操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelCacheOperateSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelCacheOperateSyncResponse
        /// </returns>
        public DelCacheOperateSyncResponse DelCacheOperateSyncWithOptions(DelCacheOperateSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelCacheOperateSync",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelCacheOperateSyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步Del缓存操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelCacheOperateSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelCacheOperateSyncResponse
        /// </returns>
        public async Task<DelCacheOperateSyncResponse> DelCacheOperateSyncWithOptionsAsync(DelCacheOperateSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelCacheOperateSync",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelCacheOperateSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步Del缓存操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelCacheOperateSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DelCacheOperateSyncResponse
        /// </returns>
        public DelCacheOperateSyncResponse DelCacheOperateSync(DelCacheOperateSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DelCacheOperateSyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步Del缓存操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelCacheOperateSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DelCacheOperateSyncResponse
        /// </returns>
        public async Task<DelCacheOperateSyncResponse> DelCacheOperateSyncAsync(DelCacheOperateSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DelCacheOperateSyncWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContacterResponse
        /// </returns>
        public DeleteContacterResponse DeleteContacterWithOptions(DeleteContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterId))
            {
                query["ContacterId"] = request.ContacterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContacterResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContacterResponse
        /// </returns>
        public async Task<DeleteContacterResponse> DeleteContacterWithOptionsAsync(DeleteContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterId))
            {
                query["ContacterId"] = request.ContacterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContacterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContacterResponse
        /// </returns>
        public DeleteContacterResponse DeleteContacter(DeleteContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContacterWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContacterResponse
        /// </returns>
        public async Task<DeleteContacterResponse> DeleteContacterAsync(DeleteContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContacterWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomerLabelResponse
        /// </returns>
        public DeleteCustomerLabelResponse DeleteCustomerLabelWithOptions(DeleteCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTypes))
            {
                query["LabelTypes"] = request.LabelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomerLabel",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomerLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomerLabelResponse
        /// </returns>
        public async Task<DeleteCustomerLabelResponse> DeleteCustomerLabelWithOptionsAsync(DeleteCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTypes))
            {
                query["LabelTypes"] = request.LabelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomerLabel",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomerLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomerLabelResponse
        /// </returns>
        public DeleteCustomerLabelResponse DeleteCustomerLabel(DeleteCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomerLabelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomerLabelResponse
        /// </returns>
        public async Task<DeleteCustomerLabelResponse> DeleteCustomerLabelAsync(DeleteCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomerLabelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据outerId查询是否存在绑定关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExistBindsByOuterIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExistBindsByOuterIdResponse
        /// </returns>
        public ExistBindsByOuterIdResponse ExistBindsByOuterIdWithOptions(ExistBindsByOuterIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExistBindsByOuterId",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExistBindsByOuterIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据outerId查询是否存在绑定关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExistBindsByOuterIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExistBindsByOuterIdResponse
        /// </returns>
        public async Task<ExistBindsByOuterIdResponse> ExistBindsByOuterIdWithOptionsAsync(ExistBindsByOuterIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExistBindsByOuterId",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExistBindsByOuterIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据outerId查询是否存在绑定关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExistBindsByOuterIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ExistBindsByOuterIdResponse
        /// </returns>
        public ExistBindsByOuterIdResponse ExistBindsByOuterId(ExistBindsByOuterIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExistBindsByOuterIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据outerId查询是否存在绑定关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExistBindsByOuterIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ExistBindsByOuterIdResponse
        /// </returns>
        public async Task<ExistBindsByOuterIdResponse> ExistBindsByOuterIdAsync(ExistBindsByOuterIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExistBindsByOuterIdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FindAllContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindAllContacterResponse
        /// </returns>
        public FindAllContacterResponse FindAllContacterWithOptions(FindAllContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocaleString))
            {
                query["LocaleString"] = request.LocaleString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindAllContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindAllContacterResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FindAllContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindAllContacterResponse
        /// </returns>
        public async Task<FindAllContacterResponse> FindAllContacterWithOptionsAsync(FindAllContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocaleString))
            {
                query["LocaleString"] = request.LocaleString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindAllContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindAllContacterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FindAllContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// FindAllContacterResponse
        /// </returns>
        public FindAllContacterResponse FindAllContacter(FindAllContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindAllContacterWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FindAllContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// FindAllContacterResponse
        /// </returns>
        public async Task<FindAllContacterResponse> FindAllContacterAsync(FindAllContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindAllContacterWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FindBizCategoryConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindBizCategoryConfigResponse
        /// </returns>
        public FindBizCategoryConfigResponse FindBizCategoryConfigWithOptions(FindBizCategoryConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocaleString))
            {
                query["LocaleString"] = request.LocaleString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindBizCategoryConfig",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindBizCategoryConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FindBizCategoryConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindBizCategoryConfigResponse
        /// </returns>
        public async Task<FindBizCategoryConfigResponse> FindBizCategoryConfigWithOptionsAsync(FindBizCategoryConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocaleString))
            {
                query["LocaleString"] = request.LocaleString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindBizCategoryConfig",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindBizCategoryConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FindBizCategoryConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// FindBizCategoryConfigResponse
        /// </returns>
        public FindBizCategoryConfigResponse FindBizCategoryConfig(FindBizCategoryConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindBizCategoryConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FindBizCategoryConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// FindBizCategoryConfigResponse
        /// </returns>
        public async Task<FindBizCategoryConfigResponse> FindBizCategoryConfigAsync(FindBizCategoryConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindBizCategoryConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FindContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindContacterResponse
        /// </returns>
        public FindContacterResponse FindContacterWithOptions(FindContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterId))
            {
                query["ContacterId"] = request.ContacterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocaleString))
            {
                query["LocaleString"] = request.LocaleString;
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
                Action = "FindContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindContacterResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FindContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindContacterResponse
        /// </returns>
        public async Task<FindContacterResponse> FindContacterWithOptionsAsync(FindContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterId))
            {
                query["ContacterId"] = request.ContacterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocaleString))
            {
                query["LocaleString"] = request.LocaleString;
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
                Action = "FindContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindContacterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FindContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// FindContacterResponse
        /// </returns>
        public FindContacterResponse FindContacter(FindContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindContacterWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FindContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// FindContacterResponse
        /// </returns>
        public async Task<FindContacterResponse> FindContacterAsync(FindContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindContacterWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FindCustomerInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindCustomerInfoResponse
        /// </returns>
        public FindCustomerInfoResponse FindCustomerInfoWithOptions(FindCustomerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindCustomerInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindCustomerInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FindCustomerInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindCustomerInfoResponse
        /// </returns>
        public async Task<FindCustomerInfoResponse> FindCustomerInfoWithOptionsAsync(FindCustomerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindCustomerInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindCustomerInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FindCustomerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// FindCustomerInfoResponse
        /// </returns>
        public FindCustomerInfoResponse FindCustomerInfo(FindCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindCustomerInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FindCustomerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// FindCustomerInfoResponse
        /// </returns>
        public async Task<FindCustomerInfoResponse> FindCustomerInfoAsync(FindCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindCustomerInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FindCustomerSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindCustomerSnapshotResponse
        /// </returns>
        public FindCustomerSnapshotResponse FindCustomerSnapshotWithOptions(FindCustomerSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoType))
            {
                query["InfoType"] = request.InfoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
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
                Action = "FindCustomerSnapshot",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindCustomerSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FindCustomerSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindCustomerSnapshotResponse
        /// </returns>
        public async Task<FindCustomerSnapshotResponse> FindCustomerSnapshotWithOptionsAsync(FindCustomerSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoType))
            {
                query["InfoType"] = request.InfoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
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
                Action = "FindCustomerSnapshot",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindCustomerSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FindCustomerSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// FindCustomerSnapshotResponse
        /// </returns>
        public FindCustomerSnapshotResponse FindCustomerSnapshot(FindCustomerSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindCustomerSnapshotWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FindCustomerSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// FindCustomerSnapshotResponse
        /// </returns>
        public async Task<FindCustomerSnapshotResponse> FindCustomerSnapshotAsync(FindCustomerSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindCustomerSnapshotWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FindFinanceTaxRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindFinanceTaxResponse
        /// </returns>
        public FindFinanceTaxResponse FindFinanceTaxWithOptions(FindFinanceTaxRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HId))
            {
                query["HId"] = request.HId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxVersion))
            {
                query["TaxVersion"] = request.TaxVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindFinanceTax",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindFinanceTaxResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FindFinanceTaxRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindFinanceTaxResponse
        /// </returns>
        public async Task<FindFinanceTaxResponse> FindFinanceTaxWithOptionsAsync(FindFinanceTaxRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HId))
            {
                query["HId"] = request.HId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxVersion))
            {
                query["TaxVersion"] = request.TaxVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindFinanceTax",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindFinanceTaxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FindFinanceTaxRequest
        /// </param>
        /// 
        /// <returns>
        /// FindFinanceTaxResponse
        /// </returns>
        public FindFinanceTaxResponse FindFinanceTax(FindFinanceTaxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindFinanceTaxWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FindFinanceTaxRequest
        /// </param>
        /// 
        /// <returns>
        /// FindFinanceTaxResponse
        /// </returns>
        public async Task<FindFinanceTaxResponse> FindFinanceTaxAsync(FindFinanceTaxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindFinanceTaxWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FindFinanceTaxDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindFinanceTaxDetailResponse
        /// </returns>
        public FindFinanceTaxDetailResponse FindFinanceTaxDetailWithOptions(FindFinanceTaxDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KpId))
            {
                query["KpId"] = request.KpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindFinanceTaxDetail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindFinanceTaxDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FindFinanceTaxDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindFinanceTaxDetailResponse
        /// </returns>
        public async Task<FindFinanceTaxDetailResponse> FindFinanceTaxDetailWithOptionsAsync(FindFinanceTaxDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KpId))
            {
                query["KpId"] = request.KpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindFinanceTaxDetail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindFinanceTaxDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FindFinanceTaxDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// FindFinanceTaxDetailResponse
        /// </returns>
        public FindFinanceTaxDetailResponse FindFinanceTaxDetail(FindFinanceTaxDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindFinanceTaxDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FindFinanceTaxDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// FindFinanceTaxDetailResponse
        /// </returns>
        public async Task<FindFinanceTaxDetailResponse> FindFinanceTaxDetailAsync(FindFinanceTaxDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindFinanceTaxDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>登录过程中根据HID匹配Pk的历史逻辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindPkByHidForLoginWithLegacyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindPkByHidForLoginWithLegacyResponse
        /// </returns>
        public FindPkByHidForLoginWithLegacyResponse FindPkByHidForLoginWithLegacyWithOptions(FindPkByHidForLoginWithLegacyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindPkByHidForLoginWithLegacy",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindPkByHidForLoginWithLegacyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>登录过程中根据HID匹配Pk的历史逻辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindPkByHidForLoginWithLegacyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindPkByHidForLoginWithLegacyResponse
        /// </returns>
        public async Task<FindPkByHidForLoginWithLegacyResponse> FindPkByHidForLoginWithLegacyWithOptionsAsync(FindPkByHidForLoginWithLegacyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindPkByHidForLoginWithLegacy",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindPkByHidForLoginWithLegacyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>登录过程中根据HID匹配Pk的历史逻辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindPkByHidForLoginWithLegacyRequest
        /// </param>
        /// 
        /// <returns>
        /// FindPkByHidForLoginWithLegacyResponse
        /// </returns>
        public FindPkByHidForLoginWithLegacyResponse FindPkByHidForLoginWithLegacy(FindPkByHidForLoginWithLegacyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindPkByHidForLoginWithLegacyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>登录过程中根据HID匹配Pk的历史逻辑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindPkByHidForLoginWithLegacyRequest
        /// </param>
        /// 
        /// <returns>
        /// FindPkByHidForLoginWithLegacyResponse
        /// </returns>
        public async Task<FindPkByHidForLoginWithLegacyResponse> FindPkByHidForLoginWithLegacyAsync(FindPkByHidForLoginWithLegacyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindPkByHidForLoginWithLegacyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ForbiddenAgAccountLoginRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ForbiddenAgAccountLoginResponse
        /// </returns>
        public ForbiddenAgAccountLoginResponse ForbiddenAgAccountLoginWithOptions(ForbiddenAgAccountLoginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForbiddenAgAccountLogin",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForbiddenAgAccountLoginResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ForbiddenAgAccountLoginRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ForbiddenAgAccountLoginResponse
        /// </returns>
        public async Task<ForbiddenAgAccountLoginResponse> ForbiddenAgAccountLoginWithOptionsAsync(ForbiddenAgAccountLoginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForbiddenAgAccountLogin",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForbiddenAgAccountLoginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ForbiddenAgAccountLoginRequest
        /// </param>
        /// 
        /// <returns>
        /// ForbiddenAgAccountLoginResponse
        /// </returns>
        public ForbiddenAgAccountLoginResponse ForbiddenAgAccountLogin(ForbiddenAgAccountLoginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForbiddenAgAccountLoginWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ForbiddenAgAccountLoginRequest
        /// </param>
        /// 
        /// <returns>
        /// ForbiddenAgAccountLoginResponse
        /// </returns>
        public async Task<ForbiddenAgAccountLoginResponse> ForbiddenAgAccountLoginAsync(ForbiddenAgAccountLoginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForbiddenAgAccountLoginWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实名认证url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAliyunCertUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateAliyunCertUrlResponse
        /// </returns>
        public GenerateAliyunCertUrlResponse GenerateAliyunCertUrlWithOptions(GenerateAliyunCertUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyChannel))
            {
                query["ApplyChannel"] = request.ApplyChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyType))
            {
                query["ApplyType"] = request.ApplyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callback))
            {
                query["Callback"] = request.Callback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertWay))
            {
                query["CertWay"] = request.CertWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreAlreadyCert))
            {
                query["IgnoreAlreadyCert"] = request.IgnoreAlreadyCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMobile))
            {
                query["IsMobile"] = request.IsMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpenApp))
            {
                query["IsOpenApp"] = request.IsOpenApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectType))
            {
                query["SubjectType"] = request.SubjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAliyunCertUrl",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAliyunCertUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实名认证url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAliyunCertUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateAliyunCertUrlResponse
        /// </returns>
        public async Task<GenerateAliyunCertUrlResponse> GenerateAliyunCertUrlWithOptionsAsync(GenerateAliyunCertUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyChannel))
            {
                query["ApplyChannel"] = request.ApplyChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyType))
            {
                query["ApplyType"] = request.ApplyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callback))
            {
                query["Callback"] = request.Callback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertWay))
            {
                query["CertWay"] = request.CertWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreAlreadyCert))
            {
                query["IgnoreAlreadyCert"] = request.IgnoreAlreadyCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMobile))
            {
                query["IsMobile"] = request.IsMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpenApp))
            {
                query["IsOpenApp"] = request.IsOpenApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectType))
            {
                query["SubjectType"] = request.SubjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAliyunCertUrl",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAliyunCertUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实名认证url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAliyunCertUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateAliyunCertUrlResponse
        /// </returns>
        public GenerateAliyunCertUrlResponse GenerateAliyunCertUrl(GenerateAliyunCertUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAliyunCertUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实名认证url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAliyunCertUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateAliyunCertUrlResponse
        /// </returns>
        public async Task<GenerateAliyunCertUrlResponse> GenerateAliyunCertUrlAsync(GenerateAliyunCertUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAliyunCertUrlWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAgAccountAkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgAccountAkResponse
        /// </returns>
        public GetAgAccountAkResponse GetAgAccountAkWithOptions(GetAgAccountAkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgAccountAk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgAccountAkResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgAccountAkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgAccountAkResponse
        /// </returns>
        public async Task<GetAgAccountAkResponse> GetAgAccountAkWithOptionsAsync(GetAgAccountAkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgAccountAk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgAccountAkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgAccountAkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgAccountAkResponse
        /// </returns>
        public GetAgAccountAkResponse GetAgAccountAk(GetAgAccountAkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgAccountAkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAgAccountAkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgAccountAkResponse
        /// </returns>
        public async Task<GetAgAccountAkResponse> GetAgAccountAkAsync(GetAgAccountAkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgAccountAkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgOneKeyDeleteTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgOneKeyDeleteTaskResponse
        /// </returns>
        public GetAgOneKeyDeleteTaskResponse GetAgOneKeyDeleteTaskWithOptions(GetAgOneKeyDeleteTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
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
                Action = "GetAgOneKeyDeleteTask",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgOneKeyDeleteTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgOneKeyDeleteTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgOneKeyDeleteTaskResponse
        /// </returns>
        public async Task<GetAgOneKeyDeleteTaskResponse> GetAgOneKeyDeleteTaskWithOptionsAsync(GetAgOneKeyDeleteTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
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
                Action = "GetAgOneKeyDeleteTask",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgOneKeyDeleteTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgOneKeyDeleteTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgOneKeyDeleteTaskResponse
        /// </returns>
        public GetAgOneKeyDeleteTaskResponse GetAgOneKeyDeleteTask(GetAgOneKeyDeleteTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgOneKeyDeleteTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgOneKeyDeleteTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgOneKeyDeleteTaskResponse
        /// </returns>
        public async Task<GetAgOneKeyDeleteTaskResponse> GetAgOneKeyDeleteTaskAsync(GetAgOneKeyDeleteTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgOneKeyDeleteTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAgRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgRelationResponse
        /// </returns>
        public GetAgRelationResponse GetAgRelationWithOptions(GetAgRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgRelation",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgRelationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgRelationResponse
        /// </returns>
        public async Task<GetAgRelationResponse> GetAgRelationWithOptionsAsync(GetAgRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgRelation",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgRelationResponse
        /// </returns>
        public GetAgRelationResponse GetAgRelation(GetAgRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgRelationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAgRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgRelationResponse
        /// </returns>
        public async Task<GetAgRelationResponse> GetAgRelationAsync(GetAgRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgRelationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAliyunIdByPkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAliyunIdByPkResponse
        /// </returns>
        public GetAliyunIdByPkResponse GetAliyunIdByPkWithOptions(GetAliyunIdByPkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAliyunIdByPk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliyunIdByPkResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAliyunIdByPkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAliyunIdByPkResponse
        /// </returns>
        public async Task<GetAliyunIdByPkResponse> GetAliyunIdByPkWithOptionsAsync(GetAliyunIdByPkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAliyunIdByPk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliyunIdByPkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAliyunIdByPkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAliyunIdByPkResponse
        /// </returns>
        public GetAliyunIdByPkResponse GetAliyunIdByPk(GetAliyunIdByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAliyunIdByPkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAliyunIdByPkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAliyunIdByPkResponse
        /// </returns>
        public async Task<GetAliyunIdByPkResponse> GetAliyunIdByPkAsync(GetAliyunIdByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAliyunIdByPkWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAliyunPKByAliyunIDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAliyunPKByAliyunIDResponse
        /// </returns>
        public GetAliyunPKByAliyunIDResponse GetAliyunPKByAliyunIDWithOptions(GetAliyunPKByAliyunIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunId))
            {
                query["AliyunId"] = request.AliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAliyunPKByAliyunID",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliyunPKByAliyunIDResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAliyunPKByAliyunIDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAliyunPKByAliyunIDResponse
        /// </returns>
        public async Task<GetAliyunPKByAliyunIDResponse> GetAliyunPKByAliyunIDWithOptionsAsync(GetAliyunPKByAliyunIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunId))
            {
                query["AliyunId"] = request.AliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAliyunPKByAliyunID",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliyunPKByAliyunIDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAliyunPKByAliyunIDRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAliyunPKByAliyunIDResponse
        /// </returns>
        public GetAliyunPKByAliyunIDResponse GetAliyunPKByAliyunID(GetAliyunPKByAliyunIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAliyunPKByAliyunIDWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAliyunPKByAliyunIDRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAliyunPKByAliyunIDResponse
        /// </returns>
        public async Task<GetAliyunPKByAliyunIDResponse> GetAliyunPKByAliyunIDAsync(GetAliyunPKByAliyunIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAliyunPKByAliyunIDWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetCustomerCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerCategoryResponse
        /// </returns>
        public GetCustomerCategoryResponse GetCustomerCategoryWithOptions(GetCustomerCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocaleString))
            {
                query["LocaleString"] = request.LocaleString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerCategory",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetCustomerCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerCategoryResponse
        /// </returns>
        public async Task<GetCustomerCategoryResponse> GetCustomerCategoryWithOptionsAsync(GetCustomerCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocaleString))
            {
                query["LocaleString"] = request.LocaleString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerCategory",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetCustomerCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerCategoryResponse
        /// </returns>
        public GetCustomerCategoryResponse GetCustomerCategory(GetCustomerCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerCategoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetCustomerCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerCategoryResponse
        /// </returns>
        public async Task<GetCustomerCategoryResponse> GetCustomerCategoryAsync(GetCustomerCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerCategoryWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetCustomerCategoryDictionaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerCategoryDictionaryResponse
        /// </returns>
        public GetCustomerCategoryDictionaryResponse GetCustomerCategoryDictionaryWithOptions(GetCustomerCategoryDictionaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetCustomerCategoryDictionary",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerCategoryDictionaryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetCustomerCategoryDictionaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerCategoryDictionaryResponse
        /// </returns>
        public async Task<GetCustomerCategoryDictionaryResponse> GetCustomerCategoryDictionaryWithOptionsAsync(GetCustomerCategoryDictionaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetCustomerCategoryDictionary",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerCategoryDictionaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetCustomerCategoryDictionaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerCategoryDictionaryResponse
        /// </returns>
        public GetCustomerCategoryDictionaryResponse GetCustomerCategoryDictionary(GetCustomerCategoryDictionaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerCategoryDictionaryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetCustomerCategoryDictionaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerCategoryDictionaryResponse
        /// </returns>
        public async Task<GetCustomerCategoryDictionaryResponse> GetCustomerCategoryDictionaryAsync(GetCustomerCategoryDictionaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerCategoryDictionaryWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetCustomerInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerInformationResponse
        /// </returns>
        public GetCustomerInformationResponse GetCustomerInformationWithOptions(GetCustomerInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerInformation",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerInformationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetCustomerInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerInformationResponse
        /// </returns>
        public async Task<GetCustomerInformationResponse> GetCustomerInformationWithOptionsAsync(GetCustomerInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerInformation",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerInformationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetCustomerInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerInformationResponse
        /// </returns>
        public GetCustomerInformationResponse GetCustomerInformation(GetCustomerInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerInformationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetCustomerInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerInformationResponse
        /// </returns>
        public async Task<GetCustomerInformationResponse> GetCustomerInformationAsync(GetCustomerInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerInformationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetDingTalkUserOrgByAliyunTmpCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingTalkUserOrgByAliyunTmpCodeResponse
        /// </returns>
        public GetDingTalkUserOrgByAliyunTmpCodeResponse GetDingTalkUserOrgByAliyunTmpCodeWithOptions(GetDingTalkUserOrgByAliyunTmpCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDingTalkUserOrgByAliyunTmpCode",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingTalkUserOrgByAliyunTmpCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetDingTalkUserOrgByAliyunTmpCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingTalkUserOrgByAliyunTmpCodeResponse
        /// </returns>
        public async Task<GetDingTalkUserOrgByAliyunTmpCodeResponse> GetDingTalkUserOrgByAliyunTmpCodeWithOptionsAsync(GetDingTalkUserOrgByAliyunTmpCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDingTalkUserOrgByAliyunTmpCode",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingTalkUserOrgByAliyunTmpCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetDingTalkUserOrgByAliyunTmpCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDingTalkUserOrgByAliyunTmpCodeResponse
        /// </returns>
        public GetDingTalkUserOrgByAliyunTmpCodeResponse GetDingTalkUserOrgByAliyunTmpCode(GetDingTalkUserOrgByAliyunTmpCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDingTalkUserOrgByAliyunTmpCodeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetDingTalkUserOrgByAliyunTmpCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDingTalkUserOrgByAliyunTmpCodeResponse
        /// </returns>
        public async Task<GetDingTalkUserOrgByAliyunTmpCodeResponse> GetDingTalkUserOrgByAliyunTmpCodeAsync(GetDingTalkUserOrgByAliyunTmpCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDingTalkUserOrgByAliyunTmpCodeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetIdentityRegistrationByCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityRegistrationByCustomerResponse
        /// </returns>
        public GetIdentityRegistrationByCustomerResponse GetIdentityRegistrationByCustomerWithOptions(GetIdentityRegistrationByCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityRegistrationByCustomer",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdentityRegistrationByCustomerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetIdentityRegistrationByCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityRegistrationByCustomerResponse
        /// </returns>
        public async Task<GetIdentityRegistrationByCustomerResponse> GetIdentityRegistrationByCustomerWithOptionsAsync(GetIdentityRegistrationByCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityRegistrationByCustomer",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdentityRegistrationByCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetIdentityRegistrationByCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityRegistrationByCustomerResponse
        /// </returns>
        public GetIdentityRegistrationByCustomerResponse GetIdentityRegistrationByCustomer(GetIdentityRegistrationByCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIdentityRegistrationByCustomerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetIdentityRegistrationByCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityRegistrationByCustomerResponse
        /// </returns>
        public async Task<GetIdentityRegistrationByCustomerResponse> GetIdentityRegistrationByCustomerAsync(GetIdentityRegistrationByCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIdentityRegistrationByCustomerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetProfileTypeByPkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProfileTypeByPkResponse
        /// </returns>
        public GetProfileTypeByPkResponse GetProfileTypeByPkWithOptions(GetProfileTypeByPkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProfileTypeByPk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProfileTypeByPkResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetProfileTypeByPkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProfileTypeByPkResponse
        /// </returns>
        public async Task<GetProfileTypeByPkResponse> GetProfileTypeByPkWithOptionsAsync(GetProfileTypeByPkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProfileTypeByPk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProfileTypeByPkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetProfileTypeByPkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProfileTypeByPkResponse
        /// </returns>
        public GetProfileTypeByPkResponse GetProfileTypeByPk(GetProfileTypeByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProfileTypeByPkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetProfileTypeByPkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProfileTypeByPkResponse
        /// </returns>
        public async Task<GetProfileTypeByPkResponse> GetProfileTypeByPkAsync(GetProfileTypeByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProfileTypeByPkWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetUploadIdentityRegistrationDocConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadIdentityRegistrationDocConfigResponse
        /// </returns>
        public GetUploadIdentityRegistrationDocConfigResponse GetUploadIdentityRegistrationDocConfigWithOptions(GetUploadIdentityRegistrationDocConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadIdentityRegistrationDocConfig",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadIdentityRegistrationDocConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetUploadIdentityRegistrationDocConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUploadIdentityRegistrationDocConfigResponse
        /// </returns>
        public async Task<GetUploadIdentityRegistrationDocConfigResponse> GetUploadIdentityRegistrationDocConfigWithOptionsAsync(GetUploadIdentityRegistrationDocConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadIdentityRegistrationDocConfig",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadIdentityRegistrationDocConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetUploadIdentityRegistrationDocConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadIdentityRegistrationDocConfigResponse
        /// </returns>
        public GetUploadIdentityRegistrationDocConfigResponse GetUploadIdentityRegistrationDocConfig(GetUploadIdentityRegistrationDocConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUploadIdentityRegistrationDocConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetUploadIdentityRegistrationDocConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUploadIdentityRegistrationDocConfigResponse
        /// </returns>
        public async Task<GetUploadIdentityRegistrationDocConfigResponse> GetUploadIdentityRegistrationDocConfigAsync(GetUploadIdentityRegistrationDocConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUploadIdentityRegistrationDocConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>IncrBy缓存操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IncrByCacheOperateSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IncrByCacheOperateSyncResponse
        /// </returns>
        public IncrByCacheOperateSyncResponse IncrByCacheOperateSyncWithOptions(IncrByCacheOperateSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultValue))
            {
                query["DefaultValue"] = request.DefaultValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSeconds))
            {
                query["ExpireSeconds"] = request.ExpireSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Step))
            {
                query["Step"] = request.Step;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IncrByCacheOperateSync",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IncrByCacheOperateSyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>IncrBy缓存操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IncrByCacheOperateSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IncrByCacheOperateSyncResponse
        /// </returns>
        public async Task<IncrByCacheOperateSyncResponse> IncrByCacheOperateSyncWithOptionsAsync(IncrByCacheOperateSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultValue))
            {
                query["DefaultValue"] = request.DefaultValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSeconds))
            {
                query["ExpireSeconds"] = request.ExpireSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Step))
            {
                query["Step"] = request.Step;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IncrByCacheOperateSync",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IncrByCacheOperateSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>IncrBy缓存操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IncrByCacheOperateSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// IncrByCacheOperateSyncResponse
        /// </returns>
        public IncrByCacheOperateSyncResponse IncrByCacheOperateSync(IncrByCacheOperateSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IncrByCacheOperateSyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>IncrBy缓存操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IncrByCacheOperateSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// IncrByCacheOperateSyncResponse
        /// </returns>
        public async Task<IncrByCacheOperateSyncResponse> IncrByCacheOperateSyncAsync(IncrByCacheOperateSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IncrByCacheOperateSyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JudgeAgExistQuietPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JudgeAgExistQuietPeriodResponse
        /// </returns>
        public JudgeAgExistQuietPeriodResponse JudgeAgExistQuietPeriodWithOptions(JudgeAgExistQuietPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JudgeAgExistQuietPeriod",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JudgeAgExistQuietPeriodResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JudgeAgExistQuietPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JudgeAgExistQuietPeriodResponse
        /// </returns>
        public async Task<JudgeAgExistQuietPeriodResponse> JudgeAgExistQuietPeriodWithOptionsAsync(JudgeAgExistQuietPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JudgeAgExistQuietPeriod",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JudgeAgExistQuietPeriodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JudgeAgExistQuietPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// JudgeAgExistQuietPeriodResponse
        /// </returns>
        public JudgeAgExistQuietPeriodResponse JudgeAgExistQuietPeriod(JudgeAgExistQuietPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JudgeAgExistQuietPeriodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请ag注销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JudgeAgExistQuietPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// JudgeAgExistQuietPeriodResponse
        /// </returns>
        public async Task<JudgeAgExistQuietPeriodResponse> JudgeAgExistQuietPeriodAsync(JudgeAgExistQuietPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JudgeAgExistQuietPeriodWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// LoadRealNameInfoByPkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadRealNameInfoByPkResponse
        /// </returns>
        public LoadRealNameInfoByPkResponse LoadRealNameInfoByPkWithOptions(LoadRealNameInfoByPkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadRealNameInfoByPk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadRealNameInfoByPkResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// LoadRealNameInfoByPkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadRealNameInfoByPkResponse
        /// </returns>
        public async Task<LoadRealNameInfoByPkResponse> LoadRealNameInfoByPkWithOptionsAsync(LoadRealNameInfoByPkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadRealNameInfoByPk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadRealNameInfoByPkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// LoadRealNameInfoByPkRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadRealNameInfoByPkResponse
        /// </returns>
        public LoadRealNameInfoByPkResponse LoadRealNameInfoByPk(LoadRealNameInfoByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoadRealNameInfoByPkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// LoadRealNameInfoByPkRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadRealNameInfoByPkResponse
        /// </returns>
        public async Task<LoadRealNameInfoByPkResponse> LoadRealNameInfoByPkAsync(LoadRealNameInfoByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoadRealNameInfoByPkWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// MapFromHavanaBindIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MapFromHavanaBindIdResponse
        /// </returns>
        public MapFromHavanaBindIdResponse MapFromHavanaBindIdWithOptions(MapFromHavanaBindIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MapFromHavanaBindIdShrinkRequest request = new MapFromHavanaBindIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HavanaBindStations))
            {
                request.HavanaBindStationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HavanaBindStations, "HavanaBindStations", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaBindId))
            {
                query["HavanaBindId"] = request.HavanaBindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaBindStationsShrink))
            {
                query["HavanaBindStations"] = request.HavanaBindStationsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapFromHavanaBindId",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapFromHavanaBindIdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// MapFromHavanaBindIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MapFromHavanaBindIdResponse
        /// </returns>
        public async Task<MapFromHavanaBindIdResponse> MapFromHavanaBindIdWithOptionsAsync(MapFromHavanaBindIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MapFromHavanaBindIdShrinkRequest request = new MapFromHavanaBindIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HavanaBindStations))
            {
                request.HavanaBindStationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HavanaBindStations, "HavanaBindStations", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaBindId))
            {
                query["HavanaBindId"] = request.HavanaBindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaBindStationsShrink))
            {
                query["HavanaBindStations"] = request.HavanaBindStationsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapFromHavanaBindId",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapFromHavanaBindIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// MapFromHavanaBindIdRequest
        /// </param>
        /// 
        /// <returns>
        /// MapFromHavanaBindIdResponse
        /// </returns>
        public MapFromHavanaBindIdResponse MapFromHavanaBindId(MapFromHavanaBindIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MapFromHavanaBindIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// MapFromHavanaBindIdRequest
        /// </param>
        /// 
        /// <returns>
        /// MapFromHavanaBindIdResponse
        /// </returns>
        public async Task<MapFromHavanaBindIdResponse> MapFromHavanaBindIdAsync(MapFromHavanaBindIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MapFromHavanaBindIdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// MapPkFromHidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MapPkFromHidResponse
        /// </returns>
        public MapPkFromHidResponse MapPkFromHidWithOptions(MapPkFromHidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hid))
            {
                query["Hid"] = request.Hid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingScenes))
            {
                query["MappingScenes"] = request.MappingScenes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapPkFromHid",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapPkFromHidResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// MapPkFromHidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MapPkFromHidResponse
        /// </returns>
        public async Task<MapPkFromHidResponse> MapPkFromHidWithOptionsAsync(MapPkFromHidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hid))
            {
                query["Hid"] = request.Hid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingScenes))
            {
                query["MappingScenes"] = request.MappingScenes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapPkFromHid",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapPkFromHidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// MapPkFromHidRequest
        /// </param>
        /// 
        /// <returns>
        /// MapPkFromHidResponse
        /// </returns>
        public MapPkFromHidResponse MapPkFromHid(MapPkFromHidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MapPkFromHidWithOptions(request, runtime);
        }

        /// <param name="request">
        /// MapPkFromHidRequest
        /// </param>
        /// 
        /// <returns>
        /// MapPkFromHidResponse
        /// </returns>
        public async Task<MapPkFromHidResponse> MapPkFromHidAsync(MapPkFromHidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MapPkFromHidWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// MapPkToHidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MapPkToHidResponse
        /// </returns>
        public MapPkToHidResponse MapPkToHidWithOptions(MapPkToHidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingScenes))
            {
                query["MappingScenes"] = request.MappingScenes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapPkToHid",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapPkToHidResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// MapPkToHidRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MapPkToHidResponse
        /// </returns>
        public async Task<MapPkToHidResponse> MapPkToHidWithOptionsAsync(MapPkToHidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingScenes))
            {
                query["MappingScenes"] = request.MappingScenes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapPkToHid",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapPkToHidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// MapPkToHidRequest
        /// </param>
        /// 
        /// <returns>
        /// MapPkToHidResponse
        /// </returns>
        public MapPkToHidResponse MapPkToHid(MapPkToHidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MapPkToHidWithOptions(request, runtime);
        }

        /// <param name="request">
        /// MapPkToHidRequest
        /// </param>
        /// 
        /// <returns>
        /// MapPkToHidResponse
        /// </returns>
        public async Task<MapPkToHidResponse> MapPkToHidAsync(MapPkToHidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MapPkToHidWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// MapToHavanaBindIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MapToHavanaBindIdResponse
        /// </returns>
        public MapToHavanaBindIdResponse MapToHavanaBindIdWithOptions(MapToHavanaBindIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MapToHavanaBindIdShrinkRequest request = new MapToHavanaBindIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HavanaBindStations))
            {
                request.HavanaBindStationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HavanaBindStations, "HavanaBindStations", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaBindStationsShrink))
            {
                query["HavanaBindStations"] = request.HavanaBindStationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapToHavanaBindId",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapToHavanaBindIdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// MapToHavanaBindIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MapToHavanaBindIdResponse
        /// </returns>
        public async Task<MapToHavanaBindIdResponse> MapToHavanaBindIdWithOptionsAsync(MapToHavanaBindIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MapToHavanaBindIdShrinkRequest request = new MapToHavanaBindIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HavanaBindStations))
            {
                request.HavanaBindStationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HavanaBindStations, "HavanaBindStations", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaBindStationsShrink))
            {
                query["HavanaBindStations"] = request.HavanaBindStationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MapToHavanaBindId",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MapToHavanaBindIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// MapToHavanaBindIdRequest
        /// </param>
        /// 
        /// <returns>
        /// MapToHavanaBindIdResponse
        /// </returns>
        public MapToHavanaBindIdResponse MapToHavanaBindId(MapToHavanaBindIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MapToHavanaBindIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// MapToHavanaBindIdRequest
        /// </param>
        /// 
        /// <returns>
        /// MapToHavanaBindIdResponse
        /// </returns>
        public async Task<MapToHavanaBindIdResponse> MapToHavanaBindIdAsync(MapToHavanaBindIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MapToHavanaBindIdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyBizCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBizCategoryResponse
        /// </returns>
        public ModifyBizCategoryResponse ModifyBizCategoryWithOptions(ModifyBizCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamList))
            {
                query["ParamList"] = request.ParamList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBizCategory",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBizCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyBizCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBizCategoryResponse
        /// </returns>
        public async Task<ModifyBizCategoryResponse> ModifyBizCategoryWithOptionsAsync(ModifyBizCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamList))
            {
                query["ParamList"] = request.ParamList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBizCategory",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBizCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyBizCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBizCategoryResponse
        /// </returns>
        public ModifyBizCategoryResponse ModifyBizCategory(ModifyBizCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBizCategoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyBizCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBizCategoryResponse
        /// </returns>
        public async Task<ModifyBizCategoryResponse> ModifyBizCategoryAsync(ModifyBizCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBizCategoryWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyContacterResponse
        /// </returns>
        public ModifyContacterResponse ModifyContacterWithOptions(ModifyContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterAddress))
            {
                query["ContacterAddress"] = request.ContacterAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterDingding))
            {
                query["ContacterDingding"] = request.ContacterDingding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterEmail))
            {
                query["ContacterEmail"] = request.ContacterEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterId))
            {
                query["ContacterId"] = request.ContacterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterMobile))
            {
                query["ContacterMobile"] = request.ContacterMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterName))
            {
                query["ContacterName"] = request.ContacterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterPosition))
            {
                query["ContacterPosition"] = request.ContacterPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterStaffNo))
            {
                query["ContacterStaffNo"] = request.ContacterStaffNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterType))
            {
                query["ContacterType"] = request.ContacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterWangwang))
            {
                query["ContacterWangwang"] = request.ContacterWangwang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailConfirmed))
            {
                query["EmailConfirmed"] = request.EmailConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileConfirmed))
            {
                query["MobileConfirmed"] = request.MobileConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyContacterResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyContacterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyContacterResponse
        /// </returns>
        public async Task<ModifyContacterResponse> ModifyContacterWithOptionsAsync(ModifyContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterAddress))
            {
                query["ContacterAddress"] = request.ContacterAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterDingding))
            {
                query["ContacterDingding"] = request.ContacterDingding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterEmail))
            {
                query["ContacterEmail"] = request.ContacterEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterId))
            {
                query["ContacterId"] = request.ContacterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterMobile))
            {
                query["ContacterMobile"] = request.ContacterMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterName))
            {
                query["ContacterName"] = request.ContacterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterPosition))
            {
                query["ContacterPosition"] = request.ContacterPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterStaffNo))
            {
                query["ContacterStaffNo"] = request.ContacterStaffNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterType))
            {
                query["ContacterType"] = request.ContacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContacterWangwang))
            {
                query["ContacterWangwang"] = request.ContacterWangwang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailConfirmed))
            {
                query["EmailConfirmed"] = request.EmailConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileConfirmed))
            {
                query["MobileConfirmed"] = request.MobileConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyContacter",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyContacterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyContacterResponse
        /// </returns>
        public ModifyContacterResponse ModifyContacter(ModifyContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyContacterWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyContacterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyContacterResponse
        /// </returns>
        public async Task<ModifyContacterResponse> ModifyContacterAsync(ModifyContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyContacterWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyCustomerInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCustomerInfoResponse
        /// </returns>
        public ModifyCustomerInfoResponse ModifyCustomerInfoWithOptions(ModifyCustomerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Biz))
            {
                query["Biz"] = request.Biz;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerCategory))
            {
                query["CustomerCategory"] = request.CustomerCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerSubCategory))
            {
                query["CustomerSubCategory"] = request.CustomerSubCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Website))
            {
                query["Website"] = request.Website;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCustomerInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCustomerInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyCustomerInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCustomerInfoResponse
        /// </returns>
        public async Task<ModifyCustomerInfoResponse> ModifyCustomerInfoWithOptionsAsync(ModifyCustomerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Biz))
            {
                query["Biz"] = request.Biz;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerCategory))
            {
                query["CustomerCategory"] = request.CustomerCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerSubCategory))
            {
                query["CustomerSubCategory"] = request.CustomerSubCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Website))
            {
                query["Website"] = request.Website;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCustomerInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCustomerInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyCustomerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCustomerInfoResponse
        /// </returns>
        public ModifyCustomerInfoResponse ModifyCustomerInfo(ModifyCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCustomerInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyCustomerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCustomerInfoResponse
        /// </returns>
        public async Task<ModifyCustomerInfoResponse> ModifyCustomerInfoAsync(ModifyCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCustomerInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// OperateFinanceTaxRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateFinanceTaxResponse
        /// </returns>
        public OperateFinanceTaxResponse OperateFinanceTaxWithOptions(OperateFinanceTaxRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceTax))
            {
                query["FinanceTax"] = request.FinanceTax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceTaxCertificateImgName))
            {
                query["FinanceTaxCertificateImgName"] = request.FinanceTaxCertificateImgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HId))
            {
                query["HId"] = request.HId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondFinanceTax))
            {
                query["SecondFinanceTax"] = request.SecondFinanceTax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondFinanceTaxCertificateImgName))
            {
                query["SecondFinanceTaxCertificateImgName"] = request.SecondFinanceTaxCertificateImgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondFinanceTaxCertificateImgUrl))
            {
                query["SecondFinanceTaxCertificateImgUrl"] = request.SecondFinanceTaxCertificateImgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceTaxCertificateImgUrl))
            {
                query["financeTaxCertificateImgUrl"] = request.FinanceTaxCertificateImgUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateFinanceTax",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateFinanceTaxResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// OperateFinanceTaxRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateFinanceTaxResponse
        /// </returns>
        public async Task<OperateFinanceTaxResponse> OperateFinanceTaxWithOptionsAsync(OperateFinanceTaxRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceTax))
            {
                query["FinanceTax"] = request.FinanceTax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceTaxCertificateImgName))
            {
                query["FinanceTaxCertificateImgName"] = request.FinanceTaxCertificateImgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HId))
            {
                query["HId"] = request.HId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondFinanceTax))
            {
                query["SecondFinanceTax"] = request.SecondFinanceTax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondFinanceTaxCertificateImgName))
            {
                query["SecondFinanceTaxCertificateImgName"] = request.SecondFinanceTaxCertificateImgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondFinanceTaxCertificateImgUrl))
            {
                query["SecondFinanceTaxCertificateImgUrl"] = request.SecondFinanceTaxCertificateImgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceTaxCertificateImgUrl))
            {
                query["financeTaxCertificateImgUrl"] = request.FinanceTaxCertificateImgUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateFinanceTax",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateFinanceTaxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// OperateFinanceTaxRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateFinanceTaxResponse
        /// </returns>
        public OperateFinanceTaxResponse OperateFinanceTax(OperateFinanceTaxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateFinanceTaxWithOptions(request, runtime);
        }

        /// <param name="request">
        /// OperateFinanceTaxRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateFinanceTaxResponse
        /// </returns>
        public async Task<OperateFinanceTaxResponse> OperateFinanceTaxAsync(OperateFinanceTaxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateFinanceTaxWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountAddressInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountAddressInfoResponse
        /// </returns>
        public QueryAccountAddressInfoResponse QueryAccountAddressInfoWithOptions(QueryAccountAddressInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressVersion))
            {
                query["AddressVersion"] = request.AddressVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountAddressInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountAddressInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountAddressInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountAddressInfoResponse
        /// </returns>
        public async Task<QueryAccountAddressInfoResponse> QueryAccountAddressInfoWithOptionsAsync(QueryAccountAddressInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressVersion))
            {
                query["AddressVersion"] = request.AddressVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountAddressInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountAddressInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountAddressInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountAddressInfoResponse
        /// </returns>
        public QueryAccountAddressInfoResponse QueryAccountAddressInfo(QueryAccountAddressInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountAddressInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountAddressInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountAddressInfoResponse
        /// </returns>
        public async Task<QueryAccountAddressInfoResponse> QueryAccountAddressInfoAsync(QueryAccountAddressInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountAddressInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountAddressInfoWithoutHavanaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountAddressInfoWithoutHavanaResponse
        /// </returns>
        public QueryAccountAddressInfoWithoutHavanaResponse QueryAccountAddressInfoWithoutHavanaWithOptions(QueryAccountAddressInfoWithoutHavanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressVersion))
            {
                query["AddressVersion"] = request.AddressVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountAddressInfoWithoutHavana",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountAddressInfoWithoutHavanaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountAddressInfoWithoutHavanaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountAddressInfoWithoutHavanaResponse
        /// </returns>
        public async Task<QueryAccountAddressInfoWithoutHavanaResponse> QueryAccountAddressInfoWithoutHavanaWithOptionsAsync(QueryAccountAddressInfoWithoutHavanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressVersion))
            {
                query["AddressVersion"] = request.AddressVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountAddressInfoWithoutHavana",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountAddressInfoWithoutHavanaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountAddressInfoWithoutHavanaRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountAddressInfoWithoutHavanaResponse
        /// </returns>
        public QueryAccountAddressInfoWithoutHavanaResponse QueryAccountAddressInfoWithoutHavana(QueryAccountAddressInfoWithoutHavanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountAddressInfoWithoutHavanaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountAddressInfoWithoutHavanaRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountAddressInfoWithoutHavanaResponse
        /// </returns>
        public async Task<QueryAccountAddressInfoWithoutHavanaResponse> QueryAccountAddressInfoWithoutHavanaAsync(QueryAccountAddressInfoWithoutHavanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountAddressInfoWithoutHavanaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账号收货地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountDeliveryAddressInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountDeliveryAddressInfoResponse
        /// </returns>
        public QueryAccountDeliveryAddressInfoResponse QueryAccountDeliveryAddressInfoWithOptions(QueryAccountDeliveryAddressInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountDeliveryAddressInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountDeliveryAddressInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账号收货地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountDeliveryAddressInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountDeliveryAddressInfoResponse
        /// </returns>
        public async Task<QueryAccountDeliveryAddressInfoResponse> QueryAccountDeliveryAddressInfoWithOptionsAsync(QueryAccountDeliveryAddressInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountDeliveryAddressInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountDeliveryAddressInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账号收货地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountDeliveryAddressInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountDeliveryAddressInfoResponse
        /// </returns>
        public QueryAccountDeliveryAddressInfoResponse QueryAccountDeliveryAddressInfo(QueryAccountDeliveryAddressInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountDeliveryAddressInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账号收货地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountDeliveryAddressInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountDeliveryAddressInfoResponse
        /// </returns>
        public async Task<QueryAccountDeliveryAddressInfoResponse> QueryAccountDeliveryAddressInfoAsync(QueryAccountDeliveryAddressInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountDeliveryAddressInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountProfileInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountProfileInfoResponse
        /// </returns>
        public QueryAccountProfileInfoResponse QueryAccountProfileInfoWithOptions(QueryAccountProfileInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountProfileInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountProfileInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountProfileInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountProfileInfoResponse
        /// </returns>
        public async Task<QueryAccountProfileInfoResponse> QueryAccountProfileInfoWithOptionsAsync(QueryAccountProfileInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountProfileInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountProfileInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountProfileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountProfileInfoResponse
        /// </returns>
        public QueryAccountProfileInfoResponse QueryAccountProfileInfo(QueryAccountProfileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountProfileInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountProfileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountProfileInfoResponse
        /// </returns>
        public async Task<QueryAccountProfileInfoResponse> QueryAccountProfileInfoAsync(QueryAccountProfileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountProfileInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountRealNameInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountRealNameInfoResponse
        /// </returns>
        public QueryAccountRealNameInfoResponse QueryAccountRealNameInfoWithOptions(QueryAccountRealNameInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountRealNameInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountRealNameInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountRealNameInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountRealNameInfoResponse
        /// </returns>
        public async Task<QueryAccountRealNameInfoResponse> QueryAccountRealNameInfoWithOptionsAsync(QueryAccountRealNameInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountRealNameInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountRealNameInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountRealNameInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountRealNameInfoResponse
        /// </returns>
        public QueryAccountRealNameInfoResponse QueryAccountRealNameInfo(QueryAccountRealNameInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountRealNameInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountRealNameInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountRealNameInfoResponse
        /// </returns>
        public async Task<QueryAccountRealNameInfoResponse> QueryAccountRealNameInfoAsync(QueryAccountRealNameInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountRealNameInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountSiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountSiteResponse
        /// </returns>
        public QueryAccountSiteResponse QueryAccountSiteWithOptions(QueryAccountSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountSite",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountSiteResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountSiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountSiteResponse
        /// </returns>
        public async Task<QueryAccountSiteResponse> QueryAccountSiteWithOptionsAsync(QueryAccountSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountSite",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountSiteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountSiteRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountSiteResponse
        /// </returns>
        public QueryAccountSiteResponse QueryAccountSite(QueryAccountSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountSiteWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountSiteRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountSiteResponse
        /// </returns>
        public async Task<QueryAccountSiteResponse> QueryAccountSiteAsync(QueryAccountSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountSiteWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountTrueNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTrueNameResponse
        /// </returns>
        public QueryAccountTrueNameResponse QueryAccountTrueNameWithOptions(QueryAccountTrueNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountTrueName",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountTrueNameResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountTrueNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTrueNameResponse
        /// </returns>
        public async Task<QueryAccountTrueNameResponse> QueryAccountTrueNameWithOptionsAsync(QueryAccountTrueNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountTrueName",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountTrueNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAccountTrueNameRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTrueNameResponse
        /// </returns>
        public QueryAccountTrueNameResponse QueryAccountTrueName(QueryAccountTrueNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountTrueNameWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAccountTrueNameRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTrueNameResponse
        /// </returns>
        public async Task<QueryAccountTrueNameResponse> QueryAccountTrueNameAsync(QueryAccountTrueNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountTrueNameWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAgAccountLoginPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAgAccountLoginPermissionResponse
        /// </returns>
        public QueryAgAccountLoginPermissionResponse QueryAgAccountLoginPermissionWithOptions(QueryAgAccountLoginPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAgAccountLoginPermission",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAgAccountLoginPermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAgAccountLoginPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAgAccountLoginPermissionResponse
        /// </returns>
        public async Task<QueryAgAccountLoginPermissionResponse> QueryAgAccountLoginPermissionWithOptionsAsync(QueryAgAccountLoginPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAgAccountLoginPermission",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAgAccountLoginPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAgAccountLoginPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAgAccountLoginPermissionResponse
        /// </returns>
        public QueryAgAccountLoginPermissionResponse QueryAgAccountLoginPermission(QueryAgAccountLoginPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAgAccountLoginPermissionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAgAccountLoginPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAgAccountLoginPermissionResponse
        /// </returns>
        public async Task<QueryAgAccountLoginPermissionResponse> QueryAgAccountLoginPermissionAsync(QueryAgAccountLoginPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAgAccountLoginPermissionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAgRelationCountAndQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAgRelationCountAndQuotaResponse
        /// </returns>
        public QueryAgRelationCountAndQuotaResponse QueryAgRelationCountAndQuotaWithOptions(QueryAgRelationCountAndQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerBid))
            {
                body["CallerBid"] = request.CallerBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                body["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                body["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                body["CallerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                body["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NullObject))
            {
                body["NullObject"] = request.NullObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                body["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StsTokenCallerBid))
            {
                body["StsTokenCallerBid"] = request.StsTokenCallerBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StsTokenCallerUid))
            {
                body["StsTokenCallerUid"] = request.StsTokenCallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StsTokenRoleId))
            {
                body["StsTokenRoleId"] = request.StsTokenRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAgRelationCountAndQuota",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAgRelationCountAndQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAgRelationCountAndQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAgRelationCountAndQuotaResponse
        /// </returns>
        public async Task<QueryAgRelationCountAndQuotaResponse> QueryAgRelationCountAndQuotaWithOptionsAsync(QueryAgRelationCountAndQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerBid))
            {
                body["CallerBid"] = request.CallerBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                body["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                body["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                body["CallerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                body["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NullObject))
            {
                body["NullObject"] = request.NullObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                body["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StsTokenCallerBid))
            {
                body["StsTokenCallerBid"] = request.StsTokenCallerBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StsTokenCallerUid))
            {
                body["StsTokenCallerUid"] = request.StsTokenCallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StsTokenRoleId))
            {
                body["StsTokenRoleId"] = request.StsTokenRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAgRelationCountAndQuota",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAgRelationCountAndQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAgRelationCountAndQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAgRelationCountAndQuotaResponse
        /// </returns>
        public QueryAgRelationCountAndQuotaResponse QueryAgRelationCountAndQuota(QueryAgRelationCountAndQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAgRelationCountAndQuotaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAgRelationCountAndQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAgRelationCountAndQuotaResponse
        /// </returns>
        public async Task<QueryAgRelationCountAndQuotaResponse> QueryAgRelationCountAndQuotaAsync(QueryAgRelationCountAndQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAgRelationCountAndQuotaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAgSecurityMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAgSecurityMobileResponse
        /// </returns>
        public QueryAgSecurityMobileResponse QueryAgSecurityMobileWithOptions(QueryAgSecurityMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAgSecurityMobile",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAgSecurityMobileResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAgSecurityMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAgSecurityMobileResponse
        /// </returns>
        public async Task<QueryAgSecurityMobileResponse> QueryAgSecurityMobileWithOptionsAsync(QueryAgSecurityMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAgSecurityMobile",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAgSecurityMobileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAgSecurityMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAgSecurityMobileResponse
        /// </returns>
        public QueryAgSecurityMobileResponse QueryAgSecurityMobile(QueryAgSecurityMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAgSecurityMobileWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAgSecurityMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAgSecurityMobileResponse
        /// </returns>
        public async Task<QueryAgSecurityMobileResponse> QueryAgSecurityMobileAsync(QueryAgSecurityMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAgSecurityMobileWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryBindsByOuterIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBindsByOuterIdResponse
        /// </returns>
        public QueryBindsByOuterIdResponse QueryBindsByOuterIdWithOptions(QueryBindsByOuterIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorOuterId))
            {
                query["MinorOuterId"] = request.MinorOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                query["OuterId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBindsByOuterId",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBindsByOuterIdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBindsByOuterIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBindsByOuterIdResponse
        /// </returns>
        public async Task<QueryBindsByOuterIdResponse> QueryBindsByOuterIdWithOptionsAsync(QueryBindsByOuterIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorOuterId))
            {
                query["MinorOuterId"] = request.MinorOuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterId))
            {
                query["OuterId"] = request.OuterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBindsByOuterId",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBindsByOuterIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBindsByOuterIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBindsByOuterIdResponse
        /// </returns>
        public QueryBindsByOuterIdResponse QueryBindsByOuterId(QueryBindsByOuterIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBindsByOuterIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryBindsByOuterIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBindsByOuterIdResponse
        /// </returns>
        public async Task<QueryBindsByOuterIdResponse> QueryBindsByOuterIdAsync(QueryBindsByOuterIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBindsByOuterIdWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// QueryBindsByPkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBindsByPkResponse
        /// </returns>
        public QueryBindsByPkResponse QueryBindsByPkWithOptions(QueryBindsByPkRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBindsByPkShrinkRequest request = new QueryBindsByPkShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantIds))
            {
                request.TenantIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantIds, "TenantIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIdsShrink))
            {
                query["TenantIds"] = request.TenantIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBindsByPk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBindsByPkResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// QueryBindsByPkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBindsByPkResponse
        /// </returns>
        public async Task<QueryBindsByPkResponse> QueryBindsByPkWithOptionsAsync(QueryBindsByPkRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBindsByPkShrinkRequest request = new QueryBindsByPkShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantIds))
            {
                request.TenantIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantIds, "TenantIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIdsShrink))
            {
                query["TenantIds"] = request.TenantIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBindsByPk",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBindsByPkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBindsByPkRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBindsByPkResponse
        /// </returns>
        public QueryBindsByPkResponse QueryBindsByPk(QueryBindsByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBindsByPkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryBindsByPkRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBindsByPkResponse
        /// </returns>
        public async Task<QueryBindsByPkResponse> QueryBindsByPkAsync(QueryBindsByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBindsByPkWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelResponse
        /// </returns>
        public QueryCustomerLabelResponse QueryCustomerLabelWithOptions(QueryCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomerLabel",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelResponse
        /// </returns>
        public async Task<QueryCustomerLabelResponse> QueryCustomerLabelWithOptionsAsync(QueryCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomerLabel",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelResponse
        /// </returns>
        public QueryCustomerLabelResponse QueryCustomerLabel(QueryCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomerLabelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelResponse
        /// </returns>
        public async Task<QueryCustomerLabelResponse> QueryCustomerLabelAsync(QueryCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomerLabelWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryDeleteTaskCheckDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeleteTaskCheckDataResponse
        /// </returns>
        public QueryDeleteTaskCheckDataResponse QueryDeleteTaskCheckDataWithOptions(QueryDeleteTaskCheckDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongLang))
            {
                query["LongLang"] = request.LongLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeleteTaskCheckData",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeleteTaskCheckDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryDeleteTaskCheckDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeleteTaskCheckDataResponse
        /// </returns>
        public async Task<QueryDeleteTaskCheckDataResponse> QueryDeleteTaskCheckDataWithOptionsAsync(QueryDeleteTaskCheckDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongLang))
            {
                query["LongLang"] = request.LongLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeleteTaskCheckData",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeleteTaskCheckDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryDeleteTaskCheckDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeleteTaskCheckDataResponse
        /// </returns>
        public QueryDeleteTaskCheckDataResponse QueryDeleteTaskCheckData(QueryDeleteTaskCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeleteTaskCheckDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryDeleteTaskCheckDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeleteTaskCheckDataResponse
        /// </returns>
        public async Task<QueryDeleteTaskCheckDataResponse> QueryDeleteTaskCheckDataAsync(QueryDeleteTaskCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeleteTaskCheckDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryEncryptedAccountProfileInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEncryptedAccountProfileInfoResponse
        /// </returns>
        public QueryEncryptedAccountProfileInfoResponse QueryEncryptedAccountProfileInfoWithOptions(QueryEncryptedAccountProfileInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEncryptedAccountProfileInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEncryptedAccountProfileInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryEncryptedAccountProfileInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEncryptedAccountProfileInfoResponse
        /// </returns>
        public async Task<QueryEncryptedAccountProfileInfoResponse> QueryEncryptedAccountProfileInfoWithOptionsAsync(QueryEncryptedAccountProfileInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEncryptedAccountProfileInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEncryptedAccountProfileInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryEncryptedAccountProfileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEncryptedAccountProfileInfoResponse
        /// </returns>
        public QueryEncryptedAccountProfileInfoResponse QueryEncryptedAccountProfileInfo(QueryEncryptedAccountProfileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEncryptedAccountProfileInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryEncryptedAccountProfileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEncryptedAccountProfileInfoResponse
        /// </returns>
        public async Task<QueryEncryptedAccountProfileInfoResponse> QueryEncryptedAccountProfileInfoAsync(QueryEncryptedAccountProfileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEncryptedAccountProfileInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryEnterpriseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseInfoResponse
        /// </returns>
        public QueryEnterpriseInfoResponse QueryEnterpriseInfoWithOptions(QueryEnterpriseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseVersion))
            {
                query["EnterpriseVersion"] = request.EnterpriseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEnterpriseInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnterpriseInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryEnterpriseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseInfoResponse
        /// </returns>
        public async Task<QueryEnterpriseInfoResponse> QueryEnterpriseInfoWithOptionsAsync(QueryEnterpriseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseVersion))
            {
                query["EnterpriseVersion"] = request.EnterpriseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HavanaId))
            {
                query["HavanaId"] = request.HavanaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEnterpriseInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnterpriseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryEnterpriseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseInfoResponse
        /// </returns>
        public QueryEnterpriseInfoResponse QueryEnterpriseInfo(QueryEnterpriseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEnterpriseInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryEnterpriseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseInfoResponse
        /// </returns>
        public async Task<QueryEnterpriseInfoResponse> QueryEnterpriseInfoAsync(QueryEnterpriseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEnterpriseInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryEnumConfigByTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnumConfigByTypeResponse
        /// </returns>
        public QueryEnumConfigByTypeResponse QueryEnumConfigByTypeWithOptions(QueryEnumConfigByTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryEnumConfigByType",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnumConfigByTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryEnumConfigByTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnumConfigByTypeResponse
        /// </returns>
        public async Task<QueryEnumConfigByTypeResponse> QueryEnumConfigByTypeWithOptionsAsync(QueryEnumConfigByTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryEnumConfigByType",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnumConfigByTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryEnumConfigByTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnumConfigByTypeResponse
        /// </returns>
        public QueryEnumConfigByTypeResponse QueryEnumConfigByType(QueryEnumConfigByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEnumConfigByTypeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryEnumConfigByTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnumConfigByTypeResponse
        /// </returns>
        public async Task<QueryEnumConfigByTypeResponse> QueryEnumConfigByTypeAsync(QueryEnumConfigByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEnumConfigByTypeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryOneKeyDeleteBlockListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOneKeyDeleteBlockListResponse
        /// </returns>
        public QueryOneKeyDeleteBlockListResponse QueryOneKeyDeleteBlockListWithOptions(QueryOneKeyDeleteBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOneKeyDeleteBlockList",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOneKeyDeleteBlockListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryOneKeyDeleteBlockListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOneKeyDeleteBlockListResponse
        /// </returns>
        public async Task<QueryOneKeyDeleteBlockListResponse> QueryOneKeyDeleteBlockListWithOptionsAsync(QueryOneKeyDeleteBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOneKeyDeleteBlockList",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOneKeyDeleteBlockListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryOneKeyDeleteBlockListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOneKeyDeleteBlockListResponse
        /// </returns>
        public QueryOneKeyDeleteBlockListResponse QueryOneKeyDeleteBlockList(QueryOneKeyDeleteBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOneKeyDeleteBlockListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryOneKeyDeleteBlockListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOneKeyDeleteBlockListResponse
        /// </returns>
        public async Task<QueryOneKeyDeleteBlockListResponse> QueryOneKeyDeleteBlockListAsync(QueryOneKeyDeleteBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOneKeyDeleteBlockListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QuerySecurityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySecurityInfoResponse
        /// </returns>
        public QuerySecurityInfoResponse QuerySecurityInfoWithOptions(QuerySecurityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySecurityInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecurityInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySecurityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySecurityInfoResponse
        /// </returns>
        public async Task<QuerySecurityInfoResponse> QuerySecurityInfoWithOptionsAsync(QuerySecurityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySecurityInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecurityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySecurityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySecurityInfoResponse
        /// </returns>
        public QuerySecurityInfoResponse QuerySecurityInfo(QuerySecurityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecurityInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QuerySecurityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySecurityInfoResponse
        /// </returns>
        public async Task<QuerySecurityInfoResponse> QuerySecurityInfoAsync(QuerySecurityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecurityInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RegisterInternalAccountForBucRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterInternalAccountForBucResponse
        /// </returns>
        public RegisterInternalAccountForBucResponse RegisterInternalAccountForBucWithOptions(RegisterInternalAccountForBucRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEmailConfirmed))
            {
                query["IsEmailConfirmed"] = request.IsEmailConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMobileConfirmed))
            {
                query["IsMobileConfirmed"] = request.IsMobileConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMobileLogin))
            {
                query["IsMobileLogin"] = request.IsMobileLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NationalityCode))
            {
                query["NationalityCode"] = request.NationalityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainPassword))
            {
                query["PlainPassword"] = request.PlainPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredLanguage))
            {
                query["PreferredLanguage"] = request.PreferredLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountTypeCode))
            {
                query["accountTypeCode"] = request.AccountTypeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterInternalAccountForBuc",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterInternalAccountForBucResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RegisterInternalAccountForBucRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterInternalAccountForBucResponse
        /// </returns>
        public async Task<RegisterInternalAccountForBucResponse> RegisterInternalAccountForBucWithOptionsAsync(RegisterInternalAccountForBucRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEmailConfirmed))
            {
                query["IsEmailConfirmed"] = request.IsEmailConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMobileConfirmed))
            {
                query["IsMobileConfirmed"] = request.IsMobileConfirmed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMobileLogin))
            {
                query["IsMobileLogin"] = request.IsMobileLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NationalityCode))
            {
                query["NationalityCode"] = request.NationalityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainPassword))
            {
                query["PlainPassword"] = request.PlainPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredLanguage))
            {
                query["PreferredLanguage"] = request.PreferredLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountTypeCode))
            {
                query["accountTypeCode"] = request.AccountTypeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterInternalAccountForBuc",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterInternalAccountForBucResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RegisterInternalAccountForBucRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterInternalAccountForBucResponse
        /// </returns>
        public RegisterInternalAccountForBucResponse RegisterInternalAccountForBuc(RegisterInternalAccountForBucRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterInternalAccountForBucWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RegisterInternalAccountForBucRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterInternalAccountForBucResponse
        /// </returns>
        public async Task<RegisterInternalAccountForBucResponse> RegisterInternalAccountForBucAsync(RegisterInternalAccountForBucRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterInternalAccountForBucWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ReleaseAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseAgAccountResponse
        /// </returns>
        public ReleaseAgAccountResponse ReleaseAgAccountWithOptions(ReleaseAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseReason))
            {
                query["ReleaseReason"] = request.ReleaseReason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseAgAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ReleaseAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseAgAccountResponse
        /// </returns>
        public async Task<ReleaseAgAccountResponse> ReleaseAgAccountWithOptionsAsync(ReleaseAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseReason))
            {
                query["ReleaseReason"] = request.ReleaseReason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseAgAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ReleaseAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseAgAccountResponse
        /// </returns>
        public ReleaseAgAccountResponse ReleaseAgAccount(ReleaseAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseAgAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ReleaseAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseAgAccountResponse
        /// </returns>
        public async Task<ReleaseAgAccountResponse> ReleaseAgAccountAsync(ReleaseAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseAgAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ResendAsyncCreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResendAsyncCreateAgAccountResponse
        /// </returns>
        public ResendAsyncCreateAgAccountResponse ResendAsyncCreateAgAccountWithOptions(ResendAsyncCreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNo))
            {
                query["TraceNo"] = request.TraceNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendAsyncCreateAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendAsyncCreateAgAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ResendAsyncCreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResendAsyncCreateAgAccountResponse
        /// </returns>
        public async Task<ResendAsyncCreateAgAccountResponse> ResendAsyncCreateAgAccountWithOptionsAsync(ResendAsyncCreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNo))
            {
                query["TraceNo"] = request.TraceNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendAsyncCreateAgAccount",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendAsyncCreateAgAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ResendAsyncCreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ResendAsyncCreateAgAccountResponse
        /// </returns>
        public ResendAsyncCreateAgAccountResponse ResendAsyncCreateAgAccount(ResendAsyncCreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendAsyncCreateAgAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ResendAsyncCreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ResendAsyncCreateAgAccountResponse
        /// </returns>
        public async Task<ResendAsyncCreateAgAccountResponse> ResendAsyncCreateAgAccountAsync(ResendAsyncCreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendAsyncCreateAgAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ResendAsyncModifyLoginEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResendAsyncModifyLoginEmailResponse
        /// </returns>
        public ResendAsyncModifyLoginEmailResponse ResendAsyncModifyLoginEmailWithOptions(ResendAsyncModifyLoginEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNo))
            {
                query["TraceNo"] = request.TraceNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendAsyncModifyLoginEmail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendAsyncModifyLoginEmailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ResendAsyncModifyLoginEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResendAsyncModifyLoginEmailResponse
        /// </returns>
        public async Task<ResendAsyncModifyLoginEmailResponse> ResendAsyncModifyLoginEmailWithOptionsAsync(ResendAsyncModifyLoginEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceNo))
            {
                query["TraceNo"] = request.TraceNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendAsyncModifyLoginEmail",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendAsyncModifyLoginEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ResendAsyncModifyLoginEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// ResendAsyncModifyLoginEmailResponse
        /// </returns>
        public ResendAsyncModifyLoginEmailResponse ResendAsyncModifyLoginEmail(ResendAsyncModifyLoginEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendAsyncModifyLoginEmailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ResendAsyncModifyLoginEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// ResendAsyncModifyLoginEmailResponse
        /// </returns>
        public async Task<ResendAsyncModifyLoginEmailResponse> ResendAsyncModifyLoginEmailAsync(ResendAsyncModifyLoginEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendAsyncModifyLoginEmailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SeparateAgRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SeparateAgRelationResponse
        /// </returns>
        public SeparateAgRelationResponse SeparateAgRelationWithOptions(SeparateAgRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SeparateAgRelation",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SeparateAgRelationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SeparateAgRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SeparateAgRelationResponse
        /// </returns>
        public async Task<SeparateAgRelationResponse> SeparateAgRelationWithOptionsAsync(SeparateAgRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SeparateAgRelation",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SeparateAgRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SeparateAgRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// SeparateAgRelationResponse
        /// </returns>
        public SeparateAgRelationResponse SeparateAgRelation(SeparateAgRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SeparateAgRelationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SeparateAgRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// SeparateAgRelationResponse
        /// </returns>
        public async Task<SeparateAgRelationResponse> SeparateAgRelationAsync(SeparateAgRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SeparateAgRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步set操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCacheOperateSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetCacheOperateSyncResponse
        /// </returns>
        public SetCacheOperateSyncResponse SetCacheOperateSyncWithOptions(SetCacheOperateSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExceptVersion))
            {
                query["ExceptVersion"] = request.ExceptVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSeconds))
            {
                query["ExpireSeconds"] = request.ExpireSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetType))
            {
                query["SetType"] = request.SetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueClazz))
            {
                query["ValueClazz"] = request.ValueClazz;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueString))
            {
                query["ValueString"] = request.ValueString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCacheOperateSync",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCacheOperateSyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步set操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCacheOperateSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetCacheOperateSyncResponse
        /// </returns>
        public async Task<SetCacheOperateSyncResponse> SetCacheOperateSyncWithOptionsAsync(SetCacheOperateSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExceptVersion))
            {
                query["ExceptVersion"] = request.ExceptVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSeconds))
            {
                query["ExpireSeconds"] = request.ExpireSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetType))
            {
                query["SetType"] = request.SetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueClazz))
            {
                query["ValueClazz"] = request.ValueClazz;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueString))
            {
                query["ValueString"] = request.ValueString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCacheOperateSync",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCacheOperateSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步set操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCacheOperateSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// SetCacheOperateSyncResponse
        /// </returns>
        public SetCacheOperateSyncResponse SetCacheOperateSync(SetCacheOperateSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCacheOperateSyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步set操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCacheOperateSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// SetCacheOperateSyncResponse
        /// </returns>
        public async Task<SetCacheOperateSyncResponse> SetCacheOperateSyncAsync(SetCacheOperateSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCacheOperateSyncWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// UpdateAccountAddressInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccountAddressInfoResponse
        /// </returns>
        public UpdateAccountAddressInfoResponse UpdateAccountAddressInfoWithOptions(UpdateAccountAddressInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAccountAddressInfoShrinkRequest request = new UpdateAccountAddressInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CityJsonString))
            {
                request.CityJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CityJsonString, "CityJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DistrictJsonString))
            {
                request.DistrictJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DistrictJsonString, "DistrictJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProvinceJsonString))
            {
                request.ProvinceJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProvinceJsonString, "ProvinceJsonString", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address2))
            {
                query["Address2"] = request.Address2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityJsonStringShrink))
            {
                query["CityJsonString"] = request.CityJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictJsonStringShrink))
            {
                query["DistrictJsonString"] = request.DistrictJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostCode))
            {
                query["PostCode"] = request.PostCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceJsonStringShrink))
            {
                query["ProvinceJsonString"] = request.ProvinceJsonStringShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccountAddressInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountAddressInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// UpdateAccountAddressInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccountAddressInfoResponse
        /// </returns>
        public async Task<UpdateAccountAddressInfoResponse> UpdateAccountAddressInfoWithOptionsAsync(UpdateAccountAddressInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAccountAddressInfoShrinkRequest request = new UpdateAccountAddressInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CityJsonString))
            {
                request.CityJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CityJsonString, "CityJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DistrictJsonString))
            {
                request.DistrictJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DistrictJsonString, "DistrictJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProvinceJsonString))
            {
                request.ProvinceJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProvinceJsonString, "ProvinceJsonString", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address2))
            {
                query["Address2"] = request.Address2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityJsonStringShrink))
            {
                query["CityJsonString"] = request.CityJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictJsonStringShrink))
            {
                query["DistrictJsonString"] = request.DistrictJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostCode))
            {
                query["PostCode"] = request.PostCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceJsonStringShrink))
            {
                query["ProvinceJsonString"] = request.ProvinceJsonStringShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccountAddressInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountAddressInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAccountAddressInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccountAddressInfoResponse
        /// </returns>
        public UpdateAccountAddressInfoResponse UpdateAccountAddressInfo(UpdateAccountAddressInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccountAddressInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAccountAddressInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccountAddressInfoResponse
        /// </returns>
        public async Task<UpdateAccountAddressInfoResponse> UpdateAccountAddressInfoAsync(UpdateAccountAddressInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccountAddressInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// UpdateAccountProfileInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccountProfileInfoResponse
        /// </returns>
        public UpdateAccountProfileInfoResponse UpdateAccountProfileInfoWithOptions(UpdateAccountProfileInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAccountProfileInfoShrinkRequest request = new UpdateAccountProfileInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CityJsonString))
            {
                request.CityJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CityJsonString, "CityJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DistrictJsonString))
            {
                request.DistrictJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DistrictJsonString, "DistrictJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProvinceJsonString))
            {
                request.ProvinceJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProvinceJsonString, "ProvinceJsonString", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountAttribute))
            {
                query["AccountAttribute"] = request.AccountAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address2))
            {
                query["Address2"] = request.Address2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindAlipayNo))
            {
                query["BindAlipayNo"] = request.BindAlipayNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityJsonStringShrink))
            {
                query["CityJsonString"] = request.CityJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactMethod))
            {
                query["ContactMethod"] = request.ContactMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictJsonStringShrink))
            {
                query["DistrictJsonString"] = request.DistrictJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fax))
            {
                query["Fax"] = request.Fax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstName))
            {
                query["FirstName"] = request.FirstName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Head))
            {
                query["Head"] = request.Head;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeadColor))
            {
                query["HeadColor"] = request.HeadColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastName))
            {
                query["LastName"] = request.LastName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostCode))
            {
                query["PostCode"] = request.PostCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceJsonStringShrink))
            {
                query["ProvinceJsonString"] = request.ProvinceJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfServicingBusinessRegNum))
            {
                query["SelfServicingBusinessRegNum"] = request.SelfServicingBusinessRegNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfServicingIdentificationNum))
            {
                query["SelfServicingIdentificationNum"] = request.SelfServicingIdentificationNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrueName))
            {
                query["TrueName"] = request.TrueName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccountProfileInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountProfileInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// UpdateAccountProfileInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccountProfileInfoResponse
        /// </returns>
        public async Task<UpdateAccountProfileInfoResponse> UpdateAccountProfileInfoWithOptionsAsync(UpdateAccountProfileInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAccountProfileInfoShrinkRequest request = new UpdateAccountProfileInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CityJsonString))
            {
                request.CityJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CityJsonString, "CityJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DistrictJsonString))
            {
                request.DistrictJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DistrictJsonString, "DistrictJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProvinceJsonString))
            {
                request.ProvinceJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProvinceJsonString, "ProvinceJsonString", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountAttribute))
            {
                query["AccountAttribute"] = request.AccountAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address2))
            {
                query["Address2"] = request.Address2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindAlipayNo))
            {
                query["BindAlipayNo"] = request.BindAlipayNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityJsonStringShrink))
            {
                query["CityJsonString"] = request.CityJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactMethod))
            {
                query["ContactMethod"] = request.ContactMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictJsonStringShrink))
            {
                query["DistrictJsonString"] = request.DistrictJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fax))
            {
                query["Fax"] = request.Fax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstName))
            {
                query["FirstName"] = request.FirstName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Head))
            {
                query["Head"] = request.Head;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeadColor))
            {
                query["HeadColor"] = request.HeadColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastName))
            {
                query["LastName"] = request.LastName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostCode))
            {
                query["PostCode"] = request.PostCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceJsonStringShrink))
            {
                query["ProvinceJsonString"] = request.ProvinceJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfServicingBusinessRegNum))
            {
                query["SelfServicingBusinessRegNum"] = request.SelfServicingBusinessRegNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfServicingIdentificationNum))
            {
                query["SelfServicingIdentificationNum"] = request.SelfServicingIdentificationNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrueName))
            {
                query["TrueName"] = request.TrueName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccountProfileInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountProfileInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAccountProfileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccountProfileInfoResponse
        /// </returns>
        public UpdateAccountProfileInfoResponse UpdateAccountProfileInfo(UpdateAccountProfileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccountProfileInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAccountProfileInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccountProfileInfoResponse
        /// </returns>
        public async Task<UpdateAccountProfileInfoResponse> UpdateAccountProfileInfoAsync(UpdateAccountProfileInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccountProfileInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateAgAccountAddressInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgAccountAddressInfoResponse
        /// </returns>
        public UpdateAgAccountAddressInfoResponse UpdateAgAccountAddressInfoWithOptions(UpdateAgAccountAddressInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address2))
            {
                query["Address2"] = request.Address2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostCode))
            {
                query["PostCode"] = request.PostCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgAccountAddressInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgAccountAddressInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAgAccountAddressInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgAccountAddressInfoResponse
        /// </returns>
        public async Task<UpdateAgAccountAddressInfoResponse> UpdateAgAccountAddressInfoWithOptionsAsync(UpdateAgAccountAddressInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address2))
            {
                query["Address2"] = request.Address2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostCode))
            {
                query["PostCode"] = request.PostCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgAccountAddressInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgAccountAddressInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAgAccountAddressInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgAccountAddressInfoResponse
        /// </returns>
        public UpdateAgAccountAddressInfoResponse UpdateAgAccountAddressInfo(UpdateAgAccountAddressInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgAccountAddressInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAgAccountAddressInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgAccountAddressInfoResponse
        /// </returns>
        public async Task<UpdateAgAccountAddressInfoResponse> UpdateAgAccountAddressInfoAsync(UpdateAgAccountAddressInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgAccountAddressInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateAgServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgServiceStatusResponse
        /// </returns>
        public UpdateAgServiceStatusResponse UpdateAgServiceStatusWithOptions(UpdateAgServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
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
                Action = "UpdateAgServiceStatus",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAgServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgServiceStatusResponse
        /// </returns>
        public async Task<UpdateAgServiceStatusResponse> UpdateAgServiceStatusWithOptionsAsync(UpdateAgServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgAccountType))
            {
                query["AgAccountType"] = request.AgAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mpk))
            {
                query["Mpk"] = request.Mpk;
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
                Action = "UpdateAgServiceStatus",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAgServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgServiceStatusResponse
        /// </returns>
        public UpdateAgServiceStatusResponse UpdateAgServiceStatus(UpdateAgServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgServiceStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAgServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgServiceStatusResponse
        /// </returns>
        public async Task<UpdateAgServiceStatusResponse> UpdateAgServiceStatusAsync(UpdateAgServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgServiceStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateCustomerCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerCategoryResponse
        /// </returns>
        public UpdateCustomerCategoryResponse UpdateCustomerCategoryWithOptions(UpdateCustomerCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamList))
            {
                query["ParamList"] = request.ParamList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomerCategory",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomerCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateCustomerCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerCategoryResponse
        /// </returns>
        public async Task<UpdateCustomerCategoryResponse> UpdateCustomerCategoryWithOptionsAsync(UpdateCustomerCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamList))
            {
                query["ParamList"] = request.ParamList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomerCategory",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomerCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateCustomerCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerCategoryResponse
        /// </returns>
        public UpdateCustomerCategoryResponse UpdateCustomerCategory(UpdateCustomerCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomerCategoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateCustomerCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerCategoryResponse
        /// </returns>
        public async Task<UpdateCustomerCategoryResponse> UpdateCustomerCategoryAsync(UpdateCustomerCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomerCategoryWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateCustomerInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerInformationResponse
        /// </returns>
        public UpdateCustomerInformationResponse UpdateCustomerInformationWithOptions(UpdateCustomerInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Biz))
            {
                query["Biz"] = request.Biz;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerCategory))
            {
                query["CustomerCategory"] = request.CustomerCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerSubCategory))
            {
                query["CustomerSubCategory"] = request.CustomerSubCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Website))
            {
                query["Website"] = request.Website;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomerInformation",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomerInformationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateCustomerInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerInformationResponse
        /// </returns>
        public async Task<UpdateCustomerInformationResponse> UpdateCustomerInformationWithOptionsAsync(UpdateCustomerInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Biz))
            {
                query["Biz"] = request.Biz;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerCategory))
            {
                query["CustomerCategory"] = request.CustomerCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerSubCategory))
            {
                query["CustomerSubCategory"] = request.CustomerSubCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Website))
            {
                query["Website"] = request.Website;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomerInformation",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomerInformationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateCustomerInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerInformationResponse
        /// </returns>
        public UpdateCustomerInformationResponse UpdateCustomerInformation(UpdateCustomerInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomerInformationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateCustomerInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomerInformationResponse
        /// </returns>
        public async Task<UpdateCustomerInformationResponse> UpdateCustomerInformationAsync(UpdateCustomerInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomerInformationWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// UpdateOrInsertEnterpriseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrInsertEnterpriseInfoResponse
        /// </returns>
        public UpdateOrInsertEnterpriseInfoResponse UpdateOrInsertEnterpriseInfoWithOptions(UpdateOrInsertEnterpriseInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateOrInsertEnterpriseInfoShrinkRequest request = new UpdateOrInsertEnterpriseInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CityJsonString))
            {
                request.CityJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CityJsonString, "CityJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProvinceJsonString))
            {
                request.ProvinceJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProvinceJsonString, "ProvinceJsonString", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityJsonStringShrink))
            {
                query["CityJsonString"] = request.CityJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseSize))
            {
                query["EnterpriseSize"] = request.EnterpriseSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fax))
            {
                query["Fax"] = request.Fax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceJsonStringShrink))
            {
                query["ProvinceJsonString"] = request.ProvinceJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Years))
            {
                query["Years"] = request.Years;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrInsertEnterpriseInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrInsertEnterpriseInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// UpdateOrInsertEnterpriseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrInsertEnterpriseInfoResponse
        /// </returns>
        public async Task<UpdateOrInsertEnterpriseInfoResponse> UpdateOrInsertEnterpriseInfoWithOptionsAsync(UpdateOrInsertEnterpriseInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateOrInsertEnterpriseInfoShrinkRequest request = new UpdateOrInsertEnterpriseInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CityJsonString))
            {
                request.CityJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CityJsonString, "CityJsonString", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProvinceJsonString))
            {
                request.ProvinceJsonStringShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProvinceJsonString, "ProvinceJsonString", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityJsonStringShrink))
            {
                query["CityJsonString"] = request.CityJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseSize))
            {
                query["EnterpriseSize"] = request.EnterpriseSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fax))
            {
                query["Fax"] = request.Fax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceJsonStringShrink))
            {
                query["ProvinceJsonString"] = request.ProvinceJsonStringShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Years))
            {
                query["Years"] = request.Years;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrInsertEnterpriseInfo",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrInsertEnterpriseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateOrInsertEnterpriseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrInsertEnterpriseInfoResponse
        /// </returns>
        public UpdateOrInsertEnterpriseInfoResponse UpdateOrInsertEnterpriseInfo(UpdateOrInsertEnterpriseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOrInsertEnterpriseInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateOrInsertEnterpriseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrInsertEnterpriseInfoResponse
        /// </returns>
        public async Task<UpdateOrInsertEnterpriseInfoResponse> UpdateOrInsertEnterpriseInfoAsync(UpdateOrInsertEnterpriseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOrInsertEnterpriseInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DoLogicalDeleteResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DoLogicalDeleteResourceResponse
        /// </returns>
        public DoLogicalDeleteResourceResponse DoLogicalDeleteResourceWithOptions(DoLogicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtWakeup))
            {
                query["GmtWakeup"] = request.GmtWakeup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hid))
            {
                query["Hid"] = request.Hid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interrupt))
            {
                query["Interrupt"] = request.Interrupt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoker))
            {
                query["Invoker"] = request.Invoker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                query["Success"] = request.Success;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExtraData))
            {
                query["TaskExtraData"] = request.TaskExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdentifier))
            {
                query["TaskIdentifier"] = request.TaskIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "doLogicalDeleteResource",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoLogicalDeleteResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DoLogicalDeleteResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DoLogicalDeleteResourceResponse
        /// </returns>
        public async Task<DoLogicalDeleteResourceResponse> DoLogicalDeleteResourceWithOptionsAsync(DoLogicalDeleteResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtWakeup))
            {
                query["GmtWakeup"] = request.GmtWakeup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hid))
            {
                query["Hid"] = request.Hid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interrupt))
            {
                query["Interrupt"] = request.Interrupt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoker))
            {
                query["Invoker"] = request.Invoker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                query["Success"] = request.Success;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExtraData))
            {
                query["TaskExtraData"] = request.TaskExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdentifier))
            {
                query["TaskIdentifier"] = request.TaskIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "doLogicalDeleteResource",
                Version = "2016-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoLogicalDeleteResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DoLogicalDeleteResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DoLogicalDeleteResourceResponse
        /// </returns>
        public DoLogicalDeleteResourceResponse DoLogicalDeleteResource(DoLogicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoLogicalDeleteResourceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DoLogicalDeleteResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DoLogicalDeleteResourceResponse
        /// </returns>
        public async Task<DoLogicalDeleteResourceResponse> DoLogicalDeleteResourceAsync(DoLogicalDeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoLogicalDeleteResourceWithOptionsAsync(request, runtime);
        }

    }
}
