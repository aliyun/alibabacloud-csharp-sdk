// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Brain_industrial20200920.Models;

namespace AlibabaCloud.SDK.Brain_industrial20200920
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("brain-industrial", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活License</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public ActivateLicenseResponse ActivateLicenseWithOptions(ActivateLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fingerprint))
            {
                body["Fingerprint"] = request.Fingerprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateLicense",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateLicenseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活License</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public async Task<ActivateLicenseResponse> ActivateLicenseWithOptionsAsync(ActivateLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fingerprint))
            {
                body["Fingerprint"] = request.Fingerprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateLicense",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活License</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public ActivateLicenseResponse ActivateLicense(ActivateLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活License</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public async Task<ActivateLicenseResponse> ActivateLicenseAsync(ActivateLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>License详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLicenseResponse
        /// </returns>
        public GetLicenseResponse GetLicenseWithOptions(GetLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLicense",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLicenseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>License详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLicenseResponse
        /// </returns>
        public async Task<GetLicenseResponse> GetLicenseWithOptionsAsync(GetLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLicense",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>License详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLicenseResponse
        /// </returns>
        public GetLicenseResponse GetLicense(GetLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>License详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLicenseResponse
        /// </returns>
        public async Task<GetLicenseResponse> GetLicenseAsync(GetLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>License列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLicensesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLicensesResponse
        /// </returns>
        public ListLicensesResponse ListLicensesWithOptions(ListLicensesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryStr))
            {
                body["QueryStr"] = request.QueryStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLicenses",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLicensesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>License列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLicensesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLicensesResponse
        /// </returns>
        public async Task<ListLicensesResponse> ListLicensesWithOptionsAsync(ListLicensesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryStr))
            {
                body["QueryStr"] = request.QueryStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLicenses",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLicensesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>License列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLicensesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLicensesResponse
        /// </returns>
        public ListLicensesResponse ListLicenses(ListLicensesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLicensesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>License列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLicensesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLicensesResponse
        /// </returns>
        public async Task<ListLicensesResponse> ListLicensesAsync(ListLicensesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLicensesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserResourcesResponse
        /// </returns>
        public ListUserResourcesResponse ListUserResourcesWithOptions(ListUserResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserResources",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserResourcesResponse
        /// </returns>
        public async Task<ListUserResourcesResponse> ListUserResourcesWithOptionsAsync(ListUserResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserResources",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserResourcesResponse
        /// </returns>
        public ListUserResourcesResponse ListUserResources(ListUserResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserResourcesResponse
        /// </returns>
        public async Task<ListUserResourcesResponse> ListUserResourcesAsync(ListUserResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新license描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLicenseDescriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLicenseDescriptionResponse
        /// </returns>
        public UpdateLicenseDescriptionResponse UpdateLicenseDescriptionWithOptions(UpdateLicenseDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLicenseDescription",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLicenseDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新license描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLicenseDescriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLicenseDescriptionResponse
        /// </returns>
        public async Task<UpdateLicenseDescriptionResponse> UpdateLicenseDescriptionWithOptionsAsync(UpdateLicenseDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLicenseDescription",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLicenseDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新license描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLicenseDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLicenseDescriptionResponse
        /// </returns>
        public UpdateLicenseDescriptionResponse UpdateLicenseDescription(UpdateLicenseDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLicenseDescriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新license描述</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLicenseDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLicenseDescriptionResponse
        /// </returns>
        public async Task<UpdateLicenseDescriptionResponse> UpdateLicenseDescriptionAsync(UpdateLicenseDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLicenseDescriptionWithOptionsAsync(request, runtime);
        }

    }
}
